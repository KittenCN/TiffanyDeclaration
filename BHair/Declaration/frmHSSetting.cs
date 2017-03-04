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
    public partial class frmHSSetting : WinFormsUI.Docking.DockContent
    {
        public frmHSSetting()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dtSaveHS;
            dtSaveHS = GetTableFromDgv(dgvHSSetting, "DecHSSetting");
            if(!GenClass.CheckDT(dtSaveHS,"HSCODE"))
            {
                AccessHelper ah = new AccessHelper();
                string strSQL_DropHS = "delete from DecHSSetting ";
                ah.ExecuteSQLNonquery(strSQL_DropHS);
                ah.AddRowsToTable(dtSaveHS, "DecHSSetting");
                ah.Close();
                MessageBox.Show("提交成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("HSCODE有重复,提交失败", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private static DataTable GetTableFromDgv(DataGridView dgv, string strDataTableName)
        {
            DataTable dt = new DataTable();
            string strSQL = "select top 1 * from " + strDataTableName;
            AccessHelper ah = new AccessHelper();
            dt = ah.SelectToDataTable(strSQL);
            DataTable dtNew = dt.Clone();
            DataRow dr = dtNew.NewRow();
            int intdgvRowsCount = dgv.Rows.Count - 1;
            int intdgvColsCount = dgv.Columns.Count;
            if (intdgvRowsCount > 0 && intdgvColsCount > 0)
            {
                for (int x = 0; x < intdgvRowsCount; x++)
                {
                    for (int y = 0; y < intdgvColsCount; y++)
                    {
                        dr[y + 1] = dgv.Rows[x].Cells[y].Value;
                    }
                    dtNew.Rows.Add(dr.ItemArray);
                    dr = dtNew.NewRow();
                }
            }
            return dtNew;
        }

        private void frmHSSetting_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string strSQL = "select * from DecHSSetting ";
            AccessHelper ah = new AccessHelper();
            dt = ah.SelectToDataTable(strSQL);
            ah.Close();
            dgvHSSetting.AutoGenerateColumns = false;
            dgvHSSetting.DataSource = dt;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUploadHSSetting_Click(object sender, EventArgs e)
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
                    TempDT = pe.ExcelToDataTable_HSSetting(filePath);
                    dgvHSSetting.AutoGenerateColumns = false;
                    dgvHSSetting.DataSource = TempDT;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excel数据导入失败,详见数据错误列表::" + ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
