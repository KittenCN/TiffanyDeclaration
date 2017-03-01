using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BHair.Business.Table;
using System.Text.RegularExpressions;

namespace BHair.Business
{
    public partial class frmDecOrder : WinFormsUI.Docking.DockContent
    {
        public frmDecOrder()
        {
            InitializeComponent();
        }
        private void frmStoreApp_Load(object sender, EventArgs e)
        {
            this.TopMost = false;
            Reflush();
        }

        private void btnCreateNewOrder_Click(object sender, EventArgs e)
        {
            frmDecNewOrder fdno = new Business.frmDecNewOrder();
            fdno.Show();
        }

        public void Reflush()
        {
            AccessHelper ah = new AccessHelper();
            string strSQL_GetAllMainData = "select * from DecMain ";
            DataTable dtDecMain = ah.SelectToDataTable(strSQL_GetAllMainData);
            dgvDecMain.AutoGenerateColumns = false;
            dgvDecMain.DataSource = dtDecMain;
        }

        private void dgvDecMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("提交成功::" + dgvDecMain.Rows[e.RowIndex].Cells[0].Value.ToString(), "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string strUUID = dgvDecMain.Rows[e.RowIndex].Cells[0].Value.ToString();
            frmDecOrderEdit fdoe = new frmDecOrderEdit(strUUID);
            fdoe.Show();
        }
    }
}
