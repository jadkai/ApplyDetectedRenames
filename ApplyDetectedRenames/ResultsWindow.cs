using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplyDetectedRenames
{
  public partial class ResultsWindow : Form
  {
    public ResultsWindow(ResultSummary resultSummary, bool isDryRun, bool isCopyOnly)
    {
      InitializeComponent();

      string resultsLabel = "Results";

      if (isDryRun)
      {
        resultsLabel += " (dry run)";
      }

      if (isCopyOnly)
      {
        resultsLabel += " (copy not move)";
      }

      if (resultSummary.FailureReason != null)
      {
        resultsLabel += " (FAILED)";
      }

      foreach (var operation in resultSummary.Operations)
      {
        var lvitem = new ListViewItem(operation.OperationType.ToString());
        lvitem.SubItems.Add(operation.Source);

        if (operation.Destination != null)
        {
          lvitem.SubItems.Add(operation.Destination);
        }

        completedListView.Items.Add(lvitem);
      }

      var errorStrBuilder = new StringBuilder();

      foreach (var error in resultSummary.Errors)
      {
        errorStrBuilder.AppendFormat(
          "{0} - {1}{2}{3} - {4}\n\n",
          error.Operation.OperationType,
          error.Operation.Source,
          error.Operation.Destination != null ? " to " : string.Empty,
          error.Operation.Destination != null ? error.Operation.Destination : string.Empty,
          error.Exception.ToString());
      }

      errorTextBox.Text = errorStrBuilder.ToString();
    }
  }
}
