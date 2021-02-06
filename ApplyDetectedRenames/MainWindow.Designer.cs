namespace ApplyDetectedRenames
{
  partial class MainWindow
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnApplyRenames = new System.Windows.Forms.Button();
      this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.dryRunCheckbox = new System.Windows.Forms.CheckBox();
      this.copyCheckbox = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // btnApplyRenames
      // 
      this.btnApplyRenames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnApplyRenames.Location = new System.Drawing.Point(12, 12);
      this.btnApplyRenames.Name = "btnApplyRenames";
      this.btnApplyRenames.Size = new System.Drawing.Size(467, 129);
      this.btnApplyRenames.TabIndex = 0;
      this.btnApplyRenames.Text = "Apply renames...";
      this.btnApplyRenames.UseVisualStyleBackColor = true;
      this.btnApplyRenames.Click += new System.EventHandler(this.btnApplyRenames_Click);
      // 
      // folderBrowserDialog
      // 
      this.folderBrowserDialog.Description = "Select your Data/Sound/Voices directory";
      // 
      // openFileDialog
      // 
      this.openFileDialog.FileName = "openFileDialog1";
      this.openFileDialog.Filter = "Text files|*.txt|All files|*.*";
      this.openFileDialog.Title = "Select renames file";
      // 
      // dryRunCheckbox
      // 
      this.dryRunCheckbox.AutoSize = true;
      this.dryRunCheckbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dryRunCheckbox.Location = new System.Drawing.Point(12, 147);
      this.dryRunCheckbox.Name = "dryRunCheckbox";
      this.dryRunCheckbox.Size = new System.Drawing.Size(76, 24);
      this.dryRunCheckbox.TabIndex = 1;
      this.dryRunCheckbox.Text = "Dry run";
      this.dryRunCheckbox.UseVisualStyleBackColor = true;
      // 
      // copyCheckbox
      // 
      this.copyCheckbox.AutoSize = true;
      this.copyCheckbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.copyCheckbox.Location = new System.Drawing.Point(12, 177);
      this.copyCheckbox.Name = "copyCheckbox";
      this.copyCheckbox.Size = new System.Drawing.Size(178, 24);
      this.copyCheckbox.TabIndex = 2;
      this.copyCheckbox.Text = "Copy only, never move";
      this.copyCheckbox.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(491, 211);
      this.Controls.Add(this.copyCheckbox);
      this.Controls.Add(this.dryRunCheckbox);
      this.Controls.Add(this.btnApplyRenames);
      this.Name = "Form1";
      this.Text = "Apply Detected Renames";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button btnApplyRenames;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.CheckBox dryRunCheckbox;
        private System.Windows.Forms.CheckBox copyCheckbox;
    }
}

