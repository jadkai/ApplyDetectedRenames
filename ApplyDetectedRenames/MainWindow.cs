using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplyDetectedRenames
{
  public partial class MainWindow : Form
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void btnApplyRenames_Click(object sender, EventArgs e)
    {
      var skyrimLocation = GetSteamSkyrimLocation();
      string probableSoundDir = skyrimLocation == null ? null : skyrimLocation + @"\Data\Sound\Voice";
      bool haveGoodDir = false;

      if (probableSoundDir != null)
      {
        var result = MessageBox.Show(
          "Is this the directory you want to work from?\n\n" + probableSoundDir,
          "Confirm working directory",
          MessageBoxButtons.YesNoCancel);

        if (result == DialogResult.Yes)
        {
          haveGoodDir = true;
        }
        else if (result == DialogResult.Cancel)
        {
          return;
        }
      }

      if (haveGoodDir || folderBrowserDialog.ShowDialog() == DialogResult.OK)
      {
        var baseFolder = haveGoodDir ? probableSoundDir : folderBrowserDialog.SelectedPath;

        if (!baseFolder.EndsWith("\\"))
        {
          baseFolder += "\\";
        }

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
          var renamesFile = openFileDialog.FileName;

          var operations = File.ReadAllLines(renamesFile)
            .Select(line => line.Trim())
            .Where(line => !string.IsNullOrEmpty(line))
            .Select(line =>
            {
              var parts = line.Split(';');
              var operationName = parts.Length > 0 ? parts[0] : null;
              var oldPath = parts.Length > 1 ? parts[1] : null;
              var newPath = parts.Length > 2 ? parts[2] : null;

              OperationType? operation =
                operationName == "Move" ? OperationType.Move :
                operationName == "Move multiple" ? OperationType.MoveMultiple :
                operationName == "Copy" ? OperationType.Copy :
                null as OperationType?;

              return (operation, oldPath, newPath);
            })
            .Where(operationInfo =>
              operationInfo.operation != null &&
              operationInfo.oldPath != null &&
              operationInfo.newPath != null)
            .Select(operationInfo =>
            {
              var operationType = operationInfo.operation.Value;
              var oldPath = operationInfo.oldPath;
              var newPath = operationInfo.newPath;

              return (operationType, oldPath, newPath);
            })
            .Select(operationInfo => new Operation
            {
              OperationType = operationInfo.operationType,
              Source = baseFolder + operationInfo.oldPath,
              SourceRelative = operationInfo.oldPath,
              Destination = baseFolder + operationInfo.newPath,
              DestinationRelative = operationInfo.newPath
            });

          var resultSummary = ApplyRenames(baseFolder, operations);

          if (resultSummary.FailureReason != null)
          {
            MessageBox.Show(resultSummary.FailureReason.ToString());
          }

          bool isDryRun = dryRunCheckbox.Checked;
          bool isCopyOnly = copyCheckbox.Checked;

          using (var resultsWindow = new ResultsWindow(resultSummary, isDryRun, isCopyOnly))
          {
            resultsWindow.ShowDialog();
          }
        }
      }
    }

    private string GetSteamSkyrimLocation()
    {
      try
      {
        var steamInstallPath = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Steam", "InstallPath", null);

        if (steamInstallPath == null)
        {
          return null;
        }

        return steamInstallPath + @"\steamapps\common\Skyrim Special Edition";
      }
      catch (Exception ex)
      {
        MessageBox.Show("Unable to find Skyrim path automatically.\n\n" + ex.ToString());
        return null;
      }
    }

    private ResultSummary ApplyRenames(string baseFolder, IEnumerable<Operation> operations)
    {
      var moveMultiples = new HashSet<string>();
      var resultSummary = new ResultSummary();

      bool isDryRun = dryRunCheckbox.Checked;
      bool isCopyOnly = copyCheckbox.Checked;

      try
      {
        foreach (var operation in operations)
        {
          if (operation.OperationType == OperationType.MoveMultiple)
          {
            moveMultiples.Add(operation.Source);
          }

          try
          {
            if (!isDryRun)
            {
              if (operation.OperationType == OperationType.Move && !isCopyOnly)
              {
                File.Move(operation.Source, operation.Destination);
              }
              else
              {
                // This branch is if the operation is Copy or MoveMultiple, or
                // if the option to always copy is enabled.
                //
                // "MoveMultiple" means that the source file should be gone,
                // but there are multiple destination files that are sourced
                // from it, so it's basically treated as a copy, then delete
                // the source file later.           

                File.Copy(operation.Source, operation.Destination);
              }
            }

            resultSummary.Operations.Add(operation);
          }
          catch (Exception ex)
          {
            resultSummary.Errors.Add(new OperationError
            {
              Operation = operation,
              Exception = ex
            });
          }
        }

        if (!isDryRun && !isCopyOnly)
        {
          foreach (var movedFile in moveMultiples)
          {
            var operation = new Operation
            {
              OperationType = OperationType.DeleteMovedMultiple,
              Source = movedFile
            };

            try
            {
              File.Delete(movedFile);
            }
            catch (Exception ex)
            {
              resultSummary.Errors.Add(new OperationError
              {
                Operation = operation,
                Exception = ex
              });
            }
          }
        }
      }
      catch (Exception ex)
      {
        resultSummary.FailureReason = ex;
      }

      return resultSummary;
    }
  }
}
