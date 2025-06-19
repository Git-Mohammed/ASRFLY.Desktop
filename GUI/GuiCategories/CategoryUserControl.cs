using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASRFLY.Desktop.GUI.GuiCategories
{
    public partial class CategoryUserControl : UserControl
    {
        private static CategoryUserControl? _instance;
        public static CategoryUserControl Instance =>  _instance ?? new CategoryUserControl();
        public CategoryUserControl()
        {
            InitializeComponent();
        }

        #region Events
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void dgvCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion


    }
}
