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
            if(dt.Rows.Count > 0)
            {
                tbRate.Text = dt.Rows[0]["Rate"].ToString();
            }

            strSQL = "select * from StoreInfo ";
            dt = ah.SelectToDataTable(strSQL);
            if(dt.Rows.Count > 0)
            {
                dgvStore.AutoGenerateColumns = false;
                dgvStore.DataSource = dt;
            }

            strSQL = "select * from AgentInfo ";
            dt = ah.SelectToDataTable(strSQL);
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

            strSQL = "delete from StoreInfo";
            ah.ExecuteSQLNonquery(strSQL);
            DataTable dt = GenClass.GetTableFromDgv(dgvStore, "StoreInfo");
            ah.AddRowsToTable(dt, "StoreInfo");

            strSQL = "delete from AgentInfo ";
            ah.ExecuteSQLNonquery(strSQL);
            dt = GenClass.GetTableFromDgv(dgvAgent, "AgentInfo");
            ah.AddRowsToTable(dt, "AgentInfo");
        }
    }
}
