namespace SimpleNotepad
{
  partial class SearchDialog
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
      this.lblSearchForInfo = new System.Windows.Forms.Label();
      this.txtSearchTerm = new System.Windows.Forms.TextBox();
      this.btnFind = new System.Windows.Forms.Button();
      this.grpSearchDirection = new System.Windows.Forms.GroupBox();
      this.rbBackwards = new System.Windows.Forms.RadioButton();
      this.rbForwards = new System.Windows.Forms.RadioButton();
      this.chkCaseSensitive = new System.Windows.Forms.CheckBox();
      this.btnCancel = new System.Windows.Forms.Button();
      this.grpSearchDirection.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblSearchForInfo
      // 
      this.lblSearchForInfo.AutoSize = true;
      this.lblSearchForInfo.Location = new System.Drawing.Point(16, 20);
      this.lblSearchForInfo.Name = "lblSearchForInfo";
      this.lblSearchForInfo.Size = new System.Drawing.Size(62, 13);
      this.lblSearchForInfo.TabIndex = 0;
      this.lblSearchForInfo.Text = "&Search for: ";
      // 
      // txtSearchTerm
      // 
      this.txtSearchTerm.Location = new System.Drawing.Point(84, 17);
      this.txtSearchTerm.Name = "txtSearchTerm";
      this.txtSearchTerm.Size = new System.Drawing.Size(310, 20);
      this.txtSearchTerm.TabIndex = 1;
      // 
      // btnFind
      // 
      this.btnFind.Location = new System.Drawing.Point(414, 15);
      this.btnFind.Name = "btnFind";
      this.btnFind.Size = new System.Drawing.Size(75, 23);
      this.btnFind.TabIndex = 2;
      this.btnFind.Text = "&Find";
      this.btnFind.UseVisualStyleBackColor = true;
      this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
      // 
      // grpSearchDirection
      // 
      this.grpSearchDirection.Controls.Add(this.rbForwards);
      this.grpSearchDirection.Controls.Add(this.rbBackwards);
      this.grpSearchDirection.Location = new System.Drawing.Point(84, 53);
      this.grpSearchDirection.Name = "grpSearchDirection";
      this.grpSearchDirection.Size = new System.Drawing.Size(310, 77);
      this.grpSearchDirection.TabIndex = 3;
      this.grpSearchDirection.TabStop = false;
      this.grpSearchDirection.Text = "Direction";
      // 
      // rbBackwards
      // 
      this.rbBackwards.AutoSize = true;
      this.rbBackwards.Location = new System.Drawing.Point(19, 23);
      this.rbBackwards.Name = "rbBackwards";
      this.rbBackwards.Size = new System.Drawing.Size(78, 17);
      this.rbBackwards.TabIndex = 0;
      this.rbBackwards.Text = "&Backwards";
      this.rbBackwards.UseVisualStyleBackColor = true;
      // 
      // rbForwards
      // 
      this.rbForwards.AutoSize = true;
      this.rbForwards.Checked = true;
      this.rbForwards.Location = new System.Drawing.Point(19, 46);
      this.rbForwards.Name = "rbForwards";
      this.rbForwards.Size = new System.Drawing.Size(68, 17);
      this.rbForwards.TabIndex = 1;
      this.rbForwards.TabStop = true;
      this.rbForwards.Text = "F&orwards";
      this.rbForwards.UseVisualStyleBackColor = true;
      // 
      // chkCaseSensitive
      // 
      this.chkCaseSensitive.AutoSize = true;
      this.chkCaseSensitive.Location = new System.Drawing.Point(84, 146);
      this.chkCaseSensitive.Name = "chkCaseSensitive";
      this.chkCaseSensitive.Size = new System.Drawing.Size(376, 17);
      this.chkCaseSensitive.TabIndex = 4;
      this.chkCaseSensitive.Text = "Search is c&ase sensitive (difference between upper and lower case letters)";
      this.chkCaseSensitive.UseVisualStyleBackColor = true;
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(414, 44);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 5;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // SearchDialog
      // 
      this.AcceptButton = this.btnFind;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(501, 181);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.chkCaseSensitive);
      this.Controls.Add(this.grpSearchDirection);
      this.Controls.Add(this.btnFind);
      this.Controls.Add(this.txtSearchTerm);
      this.Controls.Add(this.lblSearchForInfo);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SearchDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Search ...";
      this.Load += new System.EventHandler(this.SearchDialog_Load);
      this.grpSearchDirection.ResumeLayout(false);
      this.grpSearchDirection.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblSearchForInfo;
    private System.Windows.Forms.TextBox txtSearchTerm;
    private System.Windows.Forms.Button btnFind;
    private System.Windows.Forms.GroupBox grpSearchDirection;
    private System.Windows.Forms.RadioButton rbForwards;
    private System.Windows.Forms.RadioButton rbBackwards;
    private System.Windows.Forms.CheckBox chkCaseSensitive;
    private System.Windows.Forms.Button btnCancel;
  }
}