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
    public partial class frmWMSInbound : WinFormsUI.Docking.DockContent
    {
        public frmWMSInbound()
        {
            InitializeComponent();
        }

        private void btnCreateIn_Click(object sender, EventArgs e)
        {
            frmWMSinboundDetail fwmsd = new Business.frmWMSinboundDetail();
            fwmsd.Show();
        }

        private void frmWMSInbound_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            string[] strWMTemp = Login.LoginUser.Store.ToString().Split(',');
            DataTable dtWMSinfo = SelectApplicationByApplicants(strWMTemp, "");
            dgvWMSInList.AutoGenerateColumns = false;
            dgvWMSInList.DataSource = dtWMSinfo;
        }

        public DataTable SelectApplicationByApplicants(string[] Applicants, string sql)
        {
            DataTable Result = null;
            Boolean boolFlag = false;
            for (int i = 0; i < Applicants.Length; i++)
            {
                if (Applicants[i].ToString() != null && Applicants[i].ToString() != "")
                {
                    AccessHelper ah = new AccessHelper();
                    string sqlString = string.Format("select * from WMSInbound where WearHouse='{0}' {1} order by [InDate] desc", Applicants[i].ToString(), sql);
                    DataTable tempResult = ah.SelectToDataTable(sqlString);
                    if (boolFlag == false)
                    {
                        Result = tempResult;
                        boolFlag = true;
                    }
                    else
                    {
                        foreach (DataRow dr in tempResult.Rows)
                        {
                            Result.Rows.Add(dr.ItemArray);
                        }
                    }
                    ah.Close();
                }
            }
            return Result;
        }
        private void dgvWMSInList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("提交成功::" + dgvDecMain.Rows[e.RowIndex].Cells[0].Value.ToString(), "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string strUUID = dgvWMSInList.Rows[e.RowIndex].Cells[3].Value.ToString();
            frmWMSinboundDetailEdit fwmsde = new frmWMSinboundDetailEdit(strUUID);
            fwmsde.Show();
        }
    }
}
