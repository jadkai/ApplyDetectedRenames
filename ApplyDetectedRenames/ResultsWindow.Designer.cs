namespace ApplyDetectedRenames
{
  partial class ResultsWindow
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
      this.completedListView = new System.Windows.Forms.ListView();
      this.oldNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.newNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.completedLabel = new System.Windows.Forms.Label();
      this.resultsLabel = new System.Windows.Forms.Label();
      this.operationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.errorsLabel = new System.Windows.Forms.Label();
      this.errorTextBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // completedListView
      // 
      this.completedListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.completedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.operationHeader,
            this.oldNameHeader,
            this.newNameHeader});
      this.completedListView.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.completedListView.HideSelection = false;
      this.completedListView.Location = new System.Drawing.Point(20, 77);
      this.completedListView.Name = "completedListView";
      this.completedListView.Size = new System.Drawing.Size(939, 260);
      this.completedListView.TabIndex = 11;
      this.completedListView.UseCompatibleStateImageBehavior = false;
      this.completedListView.View = System.Windows.Forms.View.Details;
      // 
      // oldNameHeader
      // 
      this.oldNameHeader.Text = "Old name";
      this.oldNameHeader.Width = 386;
      // 
      // newNameHeader
      // 
      this.newNameHeader.Text = "New name";
      this.newNameHeader.Width = 420;
      // 
      // completedLabel
      // 
      this.completedLabel.AutoSize = true;
      this.completedLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.completedLabel.Location = new System.Drawing.Point(16, 54);
      this.completedLabel.Name = "completedLabel";
      this.completedLabel.Size = new System.Drawing.Size(158, 20);
      this.completedLabel.TabIndex = 10;
      this.completedLabel.Text = "Completed operations";
      // 
      // resultsLabel
      // 
      this.resultsLabel.AutoSize = true;
      this.resultsLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.resultsLabel.Location = new System.Drawing.Point(12, 9);
      this.resultsLabel.Name = "resultsLabel";
      this.resultsLabel.Size = new System.Drawing.Size(120, 45);
      this.resultsLabel.TabIndex = 9;
      this.resultsLabel.Text = "Results";
      // 
      // operationHeader
      // 
      this.operationHeader.Text = "Operation";
      this.operationHeader.Width = 126;
      // 
      // errorsLabel
      // 
      this.errorsLabel.AutoSize = true;
      this.errorsLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.errorsLabel.Location = new System.Drawing.Point(16, 340);
      this.errorsLabel.Name = "errorsLabel";
      this.errorsLabel.Size = new System.Drawing.Size(47, 20);
      this.errorsLabel.TabIndex = 12;
      this.errorsLabel.Text = "Errors";
      // 
      // errorTextBox
      // 
      this.errorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.errorTextBox.Location = new System.Drawing.Point(20, 363);
      this.errorTextBox.Multiline = true;
      this.errorTextBox.Name = "errorTextBox";
      this.errorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.errorTextBox.Size = new System.Drawing.Size(939, 382);
      this.errorTextBox.TabIndex = 13;
      // 
      // ResultsWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(971, 757);
      this.Controls.Add(this.errorTextBox);
      this.Controls.Add(this.errorsLabel);
      this.Controls.Add(this.completedListView);
      this.Controls.Add(this.completedLabel);
      this.Controls.Add(this.resultsLabel);
      this.Name = "ResultsWindow";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Results";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.ListView completedListView;
        private System.Windows.Forms.ColumnHeader operationHeader;
        private System.Windows.Forms.ColumnHeader oldNameHeader;
        private System.Windows.Forms.ColumnHeader newNameHeader;
        private System.Windows.Forms.Label completedLabel;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label errorsLabel;
        private System.Windows.Forms.TextBox errorTextBox;
    }
}