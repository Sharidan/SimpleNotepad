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
  public partial class SearchDialog : Form
  {

    public string SearchTerm { get; set; } = "";

    public bool SearchDirectionForward { get; set; } = true;

    public bool SearchCaseSensitive { get; set; } = false;

    #region ===== Control Events =====

    private void btnFind_Click(object sender, EventArgs e)
    {
      SearchTerm = txtSearchTerm.Text;
      SearchDirectionForward = rbForwards.Checked;
      SearchCaseSensitive = chkCaseSensitive.Checked;

      this.DialogResult = DialogResult.OK;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
    }

    #endregion

    #region ===== Form Events ====

    private void SearchDialog_Load(object sender, EventArgs e)
    {

    }

    private void SearchDialog_Shown(object sender, EventArgs e)
    {
      txtSearchTerm.Text = SearchTerm;

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

    public SearchDialog()
    {
      InitializeComponent();

      this.Shown += SearchDialog_Shown;
    }

    #endregion

  }
}
