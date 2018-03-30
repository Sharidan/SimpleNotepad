namespace SimpleNotepad
{
  partial class ReplaceDialog
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
      this.grpSearchDirection = new System.Windows.Forms.GroupBox();
      this.rbForwards = new System.Windows.Forms.RadioButton();
      this.rbBackwards = new System.Windows.Forms.RadioButton();
      this.btnFind = new System.Windows.Forms.Button();
      this.txtSearchTerm = new System.Windows.Forms.TextBox();
      this.lblSearchForInfo = new System.Windows.Forms.Label();
      this.btnCancel = new System.Windows.Forms.Button();
      this.chkCaseSensitive = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtReplaceWith = new System.Windows.Forms.TextBox();
      this.grpSearchDirection.SuspendLayout();
      this.SuspendLayout();
      // 
      // grpSearchDirection
      // 
      this.grpSearchDirection.Controls.Add(this.rbForwards);
      this.grpSearchDirection.Controls.Add(this.rbBackwards);
      this.grpSearchDirection.Location = new System.Drawing.Point(99, 88);
      this.grpSearchDirection.Name = "grpSearchDirection";
      this.grpSearchDirection.Size = new System.Drawing.Size(310, 77);
      this.grpSearchDirection.TabIndex = 6;
      this.grpSearchDirection.TabStop = false;
      this.grpSearchDirection.Text = "Direction";
      // 
      // rbForwards
      // 
      this.rbForwards.AutoSize = true;
      this.rbForwards.Checked = true;
      this.rbForwards.Location = new System.Drawing.Point(19, 46);
      this.rbForwards.Name = "rbForwards";
      this.rbForwards.Size = new System.Drawing.Size(68, 17);
      this.rbForwards.TabIndex = 8;
      this.rbForwards.TabStop = true;
      this.rbForwards.Text = "F&orwards";
      this.rbForwards.UseVisualStyleBackColor = true;
      // 
      // rbBackwards
      // 
      this.rbBackwards.AutoSize = true;
      this.rbBackwards.Location = new System.Drawing.Point(19, 23);
      this.rbBackwards.Name = "rbBackwards";
      this.rbBackwards.Size = new System.Drawing.Size(78, 17);
      this.rbBackwards.TabIndex = 7;
      this.rbBackwards.Text = "&Backwards";
      this.rbBackwards.UseVisualStyleBackColor = true;
      // 
      // btnFind
      // 
      this.btnFind.Location = new System.Drawing.Point(429, 15);
      this.btnFind.Name = "btnFind";
      this.btnFind.Size = new System.Drawing.Size(75, 23);
      this.btnFind.TabIndex = 4;
      this.btnFind.Text = "&Find";
      this.btnFind.UseVisualStyleBackColor = true;
      this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
      // 
      // txtSearchTerm
      // 
      this.txtSearchTerm.Location = new System.Drawing.Point(99, 17);
      this.txtSearchTerm.Name = "txtSearchTerm";
      this.txtSearchTerm.Size = new System.Drawing.Size(310, 20);
      this.txtSearchTerm.TabIndex = 1;
      // 
      // lblSearchForInfo
      // 
      this.lblSearchForInfo.AutoSize = true;
      this.lblSearchForInfo.Location = new System.Drawing.Point(12, 20);
      this.lblSearchForInfo.Name = "lblSearchForInfo";
      this.lblSearchForInfo.Size = new System.Drawing.Size(62, 13);
      this.lblSearchForInfo.TabIndex = 0;
      this.lblSearchForInfo.Text = "&Search for: ";
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(429, 44);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 5;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // chkCaseSensitive
      // 
      this.chkCaseSensitive.AutoSize = true;
      this.chkCaseSensitive.Location = new System.Drawing.Point(99, 180);
      this.chkCaseSensitive.Name = "chkCaseSensitive";
      this.chkCaseSensitive.Size = new System.Drawing.Size(376, 17);
      this.chkCaseSensitive.TabIndex = 9;
      this.chkCaseSensitive.Text = "Search is c&ase sensitive (difference between upper and lower case letters)";
      this.chkCaseSensitive.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 54);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(72, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "&Replace with:";
      // 
      // txtReplaceWith
      // 
      this.txtReplaceWith.Location = new System.Drawing.Point(99, 51);
      this.txtReplaceWith.Name = "txtReplaceWith";
      this.txtReplaceWith.Size = new System.Drawing.Size(310, 20);
      this.txtReplaceWith.TabIndex = 3;
      // 
      // ReplaceDialog
      // 
      this.AcceptButton = this.btnFind;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(523, 210);
      this.Controls.Add(this.txtReplaceWith);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.grpSearchDirection);
      this.Controls.Add(this.btnFind);
      this.Controls.Add(this.txtSearchTerm);
      this.Controls.Add(this.lblSearchForInfo);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.chkCaseSensitive);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ReplaceDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Find and replace ...";
      this.Load += new System.EventHandler(this.ReplaceDialog_Load);
      this.grpSearchDirection.ResumeLayout(false);
      this.grpSearchDirection.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox grpSearchDirection;
    private System.Windows.Forms.RadioButton rbForwards;
    private System.Windows.Forms.RadioButton rbBackwards;
    private System.Windows.Forms.Button btnFind;
    private System.Windows.Forms.TextBox txtSearchTerm;
    private System.Windows.Forms.Label lblSearchForInfo;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.CheckBox chkCaseSensitive;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtReplaceWith;
  }
}