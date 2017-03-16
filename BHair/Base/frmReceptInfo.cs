using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BHair.Business
{
    public partial class frmReceptInfo : Form
    {
        public frmReceptInfo()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            DataTable TempDT;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel文件|*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;
                    PrintExcel pe = new PrintExcel();
                    TempDT = pe.ExcelToDataTable_WMSReceiptInfo(filePath, "");
                    dgvReceiptInfo.AutoGenerateColumns = false;
                    dgvReceiptInfo.DataSource = TempDT;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excel数据导入失败,详见数据错误列表::" + ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                AccessHelper ah = new AccessHelper();
                string strSQL_DropWMSRI = "delete from WMSReceiptInfo ";
                ah.ExecuteSQLNonquery(strSQL_DropWMSRI);
                DataTable dtSaveWMSRI;
                dtSaveWMSRI = GenClass.GetTableFromDgv(dgvReceiptInfo, "WMSReceiptInfo");
                ah.AddRowsToTable(dtSaveWMSRI, "WMSReceiptInfo");
                ah.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败,详见数据错误列表::" + ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmReceptInfo_Load(object sender, EventArgs e)
        {
            AccessHelper ah = new AccessHelper();
            string strSQL = "select * from WMSReceiptInfo ";
            DataTable dt = ah.SelectToDataTable(strSQL);
            ah.Close();
            dgvReceiptInfo.AutoGenerateColumns = false;
            dgvReceiptInfo.DataSource = dt;
        }
    }
}
