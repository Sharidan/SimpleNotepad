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

namespace SimpleNotepad
{
  public partial class MainForm : Form
  {

    private bool ContentsChanged = false;

    private string LastFilePathName = "";

    private string LastOpenPath = "";

    private string LastSearchTerm = "";

    private bool LastSearchDirectionForward = true;

    private bool LastSearchCaseSensitive = false;

    #region ===== UI Updating Stuff =====

    private void UpdateUI()
    {
      string fileName = SplitFileName(LastFilePathName);

      if (fileName.Length > 0)
      {
        if (ContentsChanged)
        {
          this.Text = "* " + fileName + " - Simple Notepad";
        }
        else
        {
          this.Text = fileName + " - Simple Notepad";
        }
      }
      else
      {
        if (ContentsChanged)
        {
          this.Text = "* Simple Notepad";
        }
        else
        {
          this.Text = "Simple Notepad";
        }
      }

      mnuFileSave.Enabled = ContentsChanged;

      // Handling of the Edit menu

      mnuEditCut.Enabled = (txtEditor.SelectionLength > 0);
      mnuEditCopy.Enabled = (txtEditor.SelectionLength > 0);

      mnuEditPaste.Enabled = Clipboard.ContainsText();

      mnuEditDelete.Enabled = (txtEditor.SelectionLength > 0);

      mnuEditFindNext.Enabled = false;

      // Check the find option
      mnuEditFindNext.Enabled = (LastSearchTerm.Length > 0);
    }

    #endregion

    #region ===== File I/O =====

    private string SplitFileName(string filePathName)
    {
      if (filePathName.IndexOf('\\') > -1)
      {
        return filePathName.Substring(
          filePathName.LastIndexOf('\\') + 1, 
          filePathName.Length - (filePathName.LastIndexOf('\\') + 1)
          );
      }
      return filePathName;
    }

    private string SplitPath(string filePathName)
    {
      if (filePathName.IndexOf('\\') > -1)
      {
        return filePathName.Substring(
          0, // Start position
          filePathName.LastIndexOf('\\') + 1 // Position + 1 = length including the trailing backslash
          );
      }

      return "";
    }

    private string LoadFile(string filePathName)
    {
      string fileData = "";

      if (File.Exists(filePathName))
      {
        try
        {
          fileData = File.ReadAllText(filePathName);
        }
        catch // (Exception ex)
        {
          fileData = "";
        }
      }

      return fileData;
    }

    private void SaveFile(string filePathName, string fileData)
    {
      if (File.Exists(filePathName))
      {
        try
        {
          File.Delete(filePathName);
        }
        catch
        {
          // Ignore it for now
        }
      }

      // if (File.Exists(filePathName) == false)
      // if ( not File.Exists(filePathName) )
      // if ( !File.Exists(filePathName) )

      if (!File.Exists(filePathName))
      {
        try
        {
          File.WriteAllText(filePathName, fileData);
          ContentsChanged = false;
        }
        catch // (Exception ex)
        {
          //TODO: Throw the user some kind of error message stating that we were unable to save the changes!
        }
      }
    }

    #endregion

    #region ===== Control Events =====

    #region ----- Text Editor -----

    private void txtEditor_TextChanged(object sender, EventArgs e)
    {
      // We will come back to this and expand it further
      // to update the titlebar of the window.
      ContentsChanged = true;
      UpdateUI();
    }

    private void TxtEditor_MouseMove(object sender, MouseEventArgs e)
    {
      // Update the UI whenever the mouse moves inside our text editor.
      UpdateUI();
      // We do this to get the edit menu refreshed.
    }

    private void TxtEditor_KeyDown(object sender, KeyEventArgs e)
    {
      // Update the UI whenever a key is pressed.
      UpdateUI();
      // We do this to get the edit menu refreshed.
    }

    #endregion

    #endregion

    #region ===== Helper Stuff =====

    private void UpdateLastOpenPath(string filePathName)
    {
      string path = SplitPath(filePathName);

      if (path.Length == 0)
      {
        path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
      }
      if (path.Length == 0)
      {
        path = "C:\\";
      }

      if (path.Length > 0)
      {
        if (path[path.Length - 1] != '\\')
        {
          path += '\\';
        }
      }

      LastOpenPath = path;
    }

    private string GetEditorContents()
    {
      string contents = "";
      int selectionStart = txtEditor.SelectionStart;
      int selectionLength = txtEditor.SelectionLength;

      contents = txtEditor.Text;

      txtEditor.SelectionStart = selectionStart;
      txtEditor.SelectionLength = 0;

      return contents;
    }

    private bool SaveAndCancel(string question)
    {
      bool cancel = false;

      if (ContentsChanged)
      {
        switch (MessageBox.Show(
          "There are unsaved changes made to the current text!\n\n" + question + "?",
          "Save changes?",
          MessageBoxButtons.YesNoCancel,
          MessageBoxIcon.Question
          ))
        {
          case DialogResult.Yes:
            // Figure out whether we have a filepathname or not and save from there...
            if (LastFilePathName.Length > 0)
            {
              SaveFile(LastFilePathName, GetEditorContents());
            }
            else
            {
              cancel = SaveFileAs();
            }

            if (ContentsChanged)
            {
              cancel = true;
            }

            break;
          case DialogResult.No:
            // Skip saving ...
            break;
          case DialogResult.Cancel:
            cancel = true;
            break;
        }
      }

      UpdateUI();

      return cancel;
    }

    private bool SaveFileAs()
    {
      bool cancel = false;
      SaveFileDialog dialog = new SaveFileDialog();
      dialog.InitialDirectory = LastOpenPath;
      dialog.Filter = "Text files|*.txt";
      dialog.Title = "Save text as ...";
      dialog.CheckFileExists = false; // We don't care whether it exists, since we will be creating it :)
      dialog.CheckPathExists = true;

      if (dialog.ShowDialog(this) == DialogResult.OK)
      {
        LastFilePathName = dialog.FileName;
        UpdateLastOpenPath(LastFilePathName);
        SaveFile(dialog.FileName, GetEditorContents());
      }
      else
      {
        cancel = true;
      }

      txtEditor.SelectionLength = 0;

      dialog.Dispose();

      UpdateUI();

      return cancel;
    }

    private bool Search()
    {
      bool showMessage = false;
      int foundPos = -1;

      if (LastSearchCaseSensitive)
      { // Search must be case sensitive

        if (LastSearchDirectionForward)
        { // Search direction: Forward
          int startPos = txtEditor.SelectionStart + 1;
          //Note: .IndexOf() is CaSe sensItiVe!
          int nextPos = txtEditor.Text.IndexOf(LastSearchTerm, startPos);

          if (nextPos > -1)
          {
            foundPos = nextPos;
          }
          else
          { // No results found
            showMessage = true;
          }
        }
        else
        { // Search direction: Backward
          int startPos = txtEditor.SelectionStart - 1;
          int nextPos = 0;

          if (startPos > -1)
          {
            //Note: .LastIndexOf() is CaSe sensItiVe!
            nextPos = txtEditor.Text.LastIndexOf(LastSearchTerm, startPos);
            if (nextPos > -1)
            {
              foundPos = nextPos;
            }
            else
            {
              showMessage = true;
            }
          }
          else
          {
            showMessage = true;
          }

        }



      }
      else
      { // Search must be case IN-sensitive (as in not sensitive)
        if (LastSearchDirectionForward)
        { // Search direction: Forward
          int startPos = txtEditor.SelectionStart + 1;
          //Note: .IndexOf() is CaSe sensItiVe! hence why we .ToLower() both!
          int nextPos = txtEditor.Text.ToLower().IndexOf(LastSearchTerm.ToLower(), startPos);

          if (nextPos > -1)
          {
            foundPos = nextPos;
          }
          else
          { // No results found
            showMessage = true;
          }
        }
        else
        { // Search direction: Backward
          int startPos = txtEditor.SelectionStart - 1;
          int nextPos = 0;

          if (startPos > -1)
          {
            //Note: .LastIndexOf() is CaSe sensItiVe! hence why we .ToLower() both!
            nextPos = txtEditor.Text.ToLower().LastIndexOf(LastSearchTerm.ToLower(), startPos);
            if (nextPos > -1)
            {
              foundPos = nextPos;
            }
            else
            {
              showMessage = true;
            }
          }
          else
          {
            showMessage = true;
          }

        }
      }

      if (foundPos > -1)
      {
        txtEditor.SelectionStart = foundPos;
        txtEditor.SelectionLength = LastSearchTerm.Length;
        txtEditor.ScrollToCaret();

        return true;
      }
      // Do we need to inform the user that we didnt find it?
      if (showMessage)
      { // Yup - show the message
        MessageBox.Show(
          "No more occurances of \"" + LastSearchTerm + "\" were found!",
          "No more results!",
          MessageBoxButtons.OK,
          MessageBoxIcon.Exclamation
          );
      }

      return false;
    }

    #endregion

    #region ===== Menu Strip =====

    #region ----- Menu: File -----

    private void mnuFileNew_Click(object sender, EventArgs e)
    {
      if (SaveAndCancel("Would you like to save these changes now"))
      {
        return;
      }

      txtEditor.Text = "";
      txtEditor.SelectionStart = 0;
      txtEditor.SelectionLength = 0;
      ContentsChanged = false;
      LastFilePathName = "";
      UpdateUI();
    }

    private void mnuFileOpen_Click(object sender, EventArgs e)
    {
      if (SaveAndCancel("Would you like to save these changes now"))
      {
        return;
      }

      OpenFileDialog dialog = new OpenFileDialog();
      dialog.InitialDirectory = LastOpenPath;
      dialog.Filter = "Text files|*.txt|All files|*.*";
      dialog.Title = "Open some random text file ...";
      dialog.CheckFileExists = true;
      dialog.CheckPathExists = true;
      dialog.Multiselect = false;

      if (dialog.ShowDialog(this) == DialogResult.OK)
      {
        string fileData = LoadFile(dialog.FileName);
        LastFilePathName = dialog.FileName;
        UpdateLastOpenPath(LastFilePathName);

        if (fileData.Length > 0)
        {
          if (fileData.Length > txtEditor.MaxLength)
          {
            txtEditor.Text = fileData.Substring(0, txtEditor.MaxLength);
            txtEditor.SelectionLength = 0;
            ContentsChanged = true;
          }
          else
          {
            txtEditor.Text = fileData;
            txtEditor.SelectionLength = 0;
            ContentsChanged = false;
          }
        }
      }

      dialog.Dispose();

      UpdateUI();
    }

    private void mnuFileSave_Click(object sender, EventArgs e)
    {
      if (ContentsChanged)
      {
        if (LastFilePathName.Length > 0)
        {
          SaveFile(LastFilePathName, GetEditorContents());
        }
        else
        {
          SaveFileAs();
        }
      }

      UpdateUI();
    }

    private void mnuFileSaveAs_Click(object sender, EventArgs e)
    {
      SaveFileAs();
    }

    private void mnuFileExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    #endregion

    #region ----- Menu: Edit -----

    private void mnuEditCut_Click(object sender, EventArgs e)
    {
      txtEditor.Cut();
    }

    private void mnuEditCopy_Click(object sender, EventArgs e)
    {
      txtEditor.Copy();
    }

    private void mnuEditPaste_Click(object sender, EventArgs e)
    {
      txtEditor.Paste();
    }

    private void mnuEditDelete_Click(object sender, EventArgs e)
    {
      if (txtEditor.SelectionLength > 0)
      {
        txtEditor.SelectedText = "";
      }
    }

    private void mnuEditFind_Click(object sender, EventArgs e)
    {
      SearchDialog dialog = new SearchDialog();
      dialog.SearchTerm = LastSearchTerm;
      dialog.SearchDirectionForward = LastSearchDirectionForward;
      dialog.SearchCaseSensitive = LastSearchCaseSensitive;

      if (dialog.ShowDialog(this) == DialogResult.OK)
      {
        LastSearchTerm = dialog.SearchTerm;
        LastSearchDirectionForward = dialog.SearchDirectionForward;
        LastSearchCaseSensitive = dialog.SearchCaseSensitive;
        //TODO: Call the actual search method that we havnt made yet :P
        Search(); // Derpidan!
        UpdateUI();
      }

      dialog.Dispose();
    }

    private void mnuEditFindNext_Click(object sender, EventArgs e)
    {
      Search();
    }

    private void mnuEditReplace_Click(object sender, EventArgs e)
    {
      ReplaceDialog dialog = new ReplaceDialog();
      dialog.SearchTerm = LastSearchTerm;
      dialog.SearchDirectionForward = LastSearchDirectionForward;
      dialog.SearchCaseSensitive = LastSearchCaseSensitive;
      dialog.ReplaceWith = "";

      if (dialog.ShowDialog(this) == DialogResult.OK)
      {
        LastSearchTerm = dialog.SearchTerm;
        LastSearchDirectionForward = dialog.SearchDirectionForward;
        LastSearchCaseSensitive = dialog.SearchCaseSensitive;
        string replaceWith = dialog.ReplaceWith;

        if (Search())
        { // Search was successfull:
          // The textbox is now pre-selected with the found result
          int selectionStart = txtEditor.SelectionStart;

          txtEditor.SelectedText = replaceWith;

          txtEditor.SelectionStart = selectionStart;
          txtEditor.SelectionLength = replaceWith.Length;
        }
        UpdateUI();
      }

      dialog.Dispose();
    }

    #endregion

    #endregion

    #region ===== Form Events =====

    private void MainForm_Load(object sender, EventArgs e)
    {
      UpdateLastOpenPath("");
    }

    private void MainForm_Shown(object sender, EventArgs e)
    {
      UpdateUI();
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (ContentsChanged)
      {
        if (SaveAndCancel("Would you like to save these changes before exitting"))
        {
          e.Cancel = true;
        }
      }
    }

    #endregion

    #region ===== Constructor =====

    public MainForm()
    {
      InitializeComponent();

      this.Shown += MainForm_Shown;

      this.FormClosing += MainForm_FormClosing;

      txtEditor.KeyDown += TxtEditor_KeyDown;
      txtEditor.MouseMove += TxtEditor_MouseMove;
    }


    #endregion

  }
}
