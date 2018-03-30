namespace SimpleNotepad
{
  partial class MainForm
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileSep01 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileSep02 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileSep03 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
      this.txtEditor = new System.Windows.Forms.TextBox();
      this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuEditCut = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuEditDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuEditSep01 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuEditFind = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuEditFindNext = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuEditReplace = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // mnuFile
      // 
      this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileSep01,
            this.mnuFileOpen,
            this.mnuFileSep02,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.mnuFileSep03,
            this.mnuFileExit});
      this.mnuFile.Name = "mnuFile";
      this.mnuFile.Size = new System.Drawing.Size(37, 20);
      this.mnuFile.Text = "&File";
      // 
      // mnuFileNew
      // 
      this.mnuFileNew.Name = "mnuFileNew";
      this.mnuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.mnuFileNew.Size = new System.Drawing.Size(196, 22);
      this.mnuFileNew.Text = "&New";
      this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
      // 
      // mnuFileSep01
      // 
      this.mnuFileSep01.Name = "mnuFileSep01";
      this.mnuFileSep01.Size = new System.Drawing.Size(193, 6);
      // 
      // mnuFileOpen
      // 
      this.mnuFileOpen.Name = "mnuFileOpen";
      this.mnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.mnuFileOpen.Size = new System.Drawing.Size(196, 22);
      this.mnuFileOpen.Text = "&Open ...";
      this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
      // 
      // mnuFileSep02
      // 
      this.mnuFileSep02.Name = "mnuFileSep02";
      this.mnuFileSep02.Size = new System.Drawing.Size(193, 6);
      // 
      // mnuFileSave
      // 
      this.mnuFileSave.Name = "mnuFileSave";
      this.mnuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.mnuFileSave.Size = new System.Drawing.Size(196, 22);
      this.mnuFileSave.Text = "&Save";
      this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
      // 
      // mnuFileSaveAs
      // 
      this.mnuFileSaveAs.Name = "mnuFileSaveAs";
      this.mnuFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
      this.mnuFileSaveAs.Size = new System.Drawing.Size(196, 22);
      this.mnuFileSaveAs.Text = "Save &as ...";
      this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
      // 
      // mnuFileSep03
      // 
      this.mnuFileSep03.Name = "mnuFileSep03";
      this.mnuFileSep03.Size = new System.Drawing.Size(193, 6);
      // 
      // mnuFileExit
      // 
      this.mnuFileExit.Name = "mnuFileExit";
      this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
      this.mnuFileExit.Size = new System.Drawing.Size(196, 22);
      this.mnuFileExit.Text = "E&xit";
      this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
      // 
      // txtEditor
      // 
      this.txtEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtEditor.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtEditor.HideSelection = false;
      this.txtEditor.Location = new System.Drawing.Point(0, 25);
      this.txtEditor.MaxLength = 4194304;
      this.txtEditor.Multiline = true;
      this.txtEditor.Name = "txtEditor";
      this.txtEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtEditor.Size = new System.Drawing.Size(800, 426);
      this.txtEditor.TabIndex = 1;
      this.txtEditor.WordWrap = false;
      this.txtEditor.TextChanged += new System.EventHandler(this.txtEditor_TextChanged);
      // 
      // mnuEdit
      // 
      this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditCut,
            this.mnuEditCopy,
            this.mnuEditPaste,
            this.mnuEditDelete,
            this.mnuEditSep01,
            this.mnuEditFind,
            this.mnuEditFindNext,
            this.mnuEditReplace});
      this.mnuEdit.Name = "mnuEdit";
      this.mnuEdit.Size = new System.Drawing.Size(39, 20);
      this.mnuEdit.Text = "&Edit";
      // 
      // mnuEditCut
      // 
      this.mnuEditCut.Name = "mnuEditCut";
      this.mnuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.mnuEditCut.Size = new System.Drawing.Size(180, 22);
      this.mnuEditCut.Text = "C&ut";
      this.mnuEditCut.Click += new System.EventHandler(this.mnuEditCut_Click);
      // 
      // mnuEditCopy
      // 
      this.mnuEditCopy.Name = "mnuEditCopy";
      this.mnuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.mnuEditCopy.Size = new System.Drawing.Size(180, 22);
      this.mnuEditCopy.Text = "&Copy";
      this.mnuEditCopy.Click += new System.EventHandler(this.mnuEditCopy_Click);
      // 
      // mnuEditPaste
      // 
      this.mnuEditPaste.Name = "mnuEditPaste";
      this.mnuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.mnuEditPaste.Size = new System.Drawing.Size(180, 22);
      this.mnuEditPaste.Text = "&Paste";
      this.mnuEditPaste.Click += new System.EventHandler(this.mnuEditPaste_Click);
      // 
      // mnuEditDelete
      // 
      this.mnuEditDelete.Name = "mnuEditDelete";
      this.mnuEditDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
      this.mnuEditDelete.Size = new System.Drawing.Size(180, 22);
      this.mnuEditDelete.Text = "&Delete";
      this.mnuEditDelete.Click += new System.EventHandler(this.mnuEditDelete_Click);
      // 
      // mnuEditSep01
      // 
      this.mnuEditSep01.Name = "mnuEditSep01";
      this.mnuEditSep01.Size = new System.Drawing.Size(177, 6);
      // 
      // mnuEditFind
      // 
      this.mnuEditFind.Name = "mnuEditFind";
      this.mnuEditFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
      this.mnuEditFind.Size = new System.Drawing.Size(180, 22);
      this.mnuEditFind.Text = "&Find ...";
      this.mnuEditFind.Click += new System.EventHandler(this.mnuEditFind_Click);
      // 
      // mnuEditFindNext
      // 
      this.mnuEditFindNext.Name = "mnuEditFindNext";
      this.mnuEditFindNext.ShortcutKeys = System.Windows.Forms.Keys.F3;
      this.mnuEditFindNext.Size = new System.Drawing.Size(180, 22);
      this.mnuEditFindNext.Text = "Find &next ...";
      this.mnuEditFindNext.Click += new System.EventHandler(this.mnuEditFindNext_Click);
      // 
      // mnuEditReplace
      // 
      this.mnuEditReplace.Name = "mnuEditReplace";
      this.mnuEditReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
      this.mnuEditReplace.Size = new System.Drawing.Size(180, 22);
      this.mnuEditReplace.Text = "&Replace ...";
      this.mnuEditReplace.Click += new System.EventHandler(this.mnuEditReplace_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.txtEditor);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Simple Notepad";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnuFile;
    private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
    private System.Windows.Forms.ToolStripSeparator mnuFileSep01;
    private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
    private System.Windows.Forms.ToolStripSeparator mnuFileSep02;
    private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
    private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
    private System.Windows.Forms.ToolStripSeparator mnuFileSep03;
    private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
    private System.Windows.Forms.TextBox txtEditor;
    private System.Windows.Forms.ToolStripMenuItem mnuEdit;
    private System.Windows.Forms.ToolStripMenuItem mnuEditCut;
    private System.Windows.Forms.ToolStripMenuItem mnuEditCopy;
    private System.Windows.Forms.ToolStripMenuItem mnuEditPaste;
    private System.Windows.Forms.ToolStripMenuItem mnuEditDelete;
    private System.Windows.Forms.ToolStripSeparator mnuEditSep01;
    private System.Windows.Forms.ToolStripMenuItem mnuEditFind;
    private System.Windows.Forms.ToolStripMenuItem mnuEditFindNext;
    private System.Windows.Forms.ToolStripMenuItem mnuEditReplace;
  }
}

