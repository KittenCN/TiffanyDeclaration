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
    public partial class frmSystemConfig : Form
    {
        public frmSystemConfig()
        {
            InitializeComponent();
        }

        private void frmSystemConfig_Load(object sender, EventArgs e)
        {
            AccessHelper ah = new AccessHelper();
            string strSQL = "select * from SetupConfig ";
            DataTable dt = ah.SelectToDataTable(strSQL);
            ah.Close();
            if(dt.Rows.Count > 0)
            {
                tbRate.Text = dt.Rows[0]["Rate"].ToString();
            }

            ah = new AccessHelper();
            strSQL = "select * from StoreInfo ";
            dt = new DataTable();
            dt = ah.SelectToDataTable(strSQL);
            ah.Close();
            if(dt.Rows.Count > 0)
            {
                dgvStore.AutoGenerateColumns = false;
                dgvStore.DataSource = dt;
            }

            ah = new AccessHelper();
            strSQL = "select * from AgentInfo ";
            dt = new DataTable();
            dt = ah.SelectToDataTable(strSQL);
            ah.Close();
            if (dt.Rows.Count > 0)
            {
                dgvAgent.AutoGenerateColumns = false;
                dgvAgent.DataSource = dt;
            }
            ah.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AccessHelper ah = new AccessHelper();
            string strSQL = "update SetupConfig set Rate=" + double.Parse(tbRate.Text);
            ah.ExecuteSQLNonquery(strSQL);
            ah.Close();

            ah = new AccessHelper();
            strSQL = "delete from StoreInfo";
            ah.ExecuteSQLNonquery(strSQL);
            ah.Close();
            ah = new AccessHelper();
            DataTable dt = GenClass.GetTableFromDgv(dgvStore, "StoreInfo");
            ah.AddRowsToTable(dt, "StoreInfo");
            ah.Close();

            ah = new AccessHelper();
            strSQL = "delete from AgentInfo ";
            ah.ExecuteSQLNonquery(strSQL);
            ah.Close();
            ah = new AccessHelper();
            dt = new DataTable();
            dt = GenClass.GetTableFromDgv(dgvAgent, "AgentInfo");
            ah.AddRowsToTable(dt, "AgentInfo");
            ah.Close();

            MessageBox.Show("提交成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
