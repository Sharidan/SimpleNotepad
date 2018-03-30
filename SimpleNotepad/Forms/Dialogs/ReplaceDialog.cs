using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleNotepad
{
  public partial class ReplaceDialog : Form
  {

    public string SearchTerm { get; set; } = "";

    public bool SearchDirectionForward { get; set; } = true;

    public bool SearchCaseSensitive { get; set; } = false;

    public string ReplaceWith { get; set; } = "";

    #region ===== Control Events =====

    private void btnFind_Click(object sender, EventArgs e)
    {
      SearchTerm = txtSearchTerm.Text;
      SearchDirectionForward = rbForwards.Checked;
      SearchCaseSensitive = chkCaseSensitive.Checked;
      ReplaceWith = txtReplaceWith.Text;

      this.DialogResult = DialogResult.OK;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
    }

    #endregion

    #region ===== Form Events =====

    private void ReplaceDialog_Load(object sender, EventArgs e)
    {

    }

    private void ReplaceDialog_Shown(object sender, EventArgs e)
    {
      txtSearchTerm.Text = SearchTerm;
      txtReplaceWith.Text = ReplaceWith;

      if (SearchDirectionForward)
      {
        rbForwards.Checked = true;
      }
      else
      {
        rbBackwards.Checked = true;
      }

      chkCaseSensitive.Checked = SearchCaseSensitive;

      txtSearchTerm.Focus();
    }

    #endregion

    #region ===== Constructor =====

    public ReplaceDialog()
    {
      InitializeComponent();

      this.Shown += ReplaceDialog_Shown;
    }

    #endregion

  }
}
