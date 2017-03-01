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
    public partial class frmDecNewOrder : Form
    {
        public DataTable dtShowINV;
        public DataTable dtDecINV;
        public DataTable dtDecMain;
        public DataTable dtShowHS;
        public DataTable dtDecHS;
        public frmDecNewOrder()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            AccessHelper ah = new AccessHelper();
            DataRow drMainData = dtDecMain.NewRow();

            drMainData["OrderNO"] = tbOrderNO.Text;
            drMainData["Status"] = 0;
            drMainData["ExCusClearTime"] = dtExCusClearTime.Value;
            drMainData["MAWB"] = tbMAWB.Text;
            drMainData["ARRport"] = cbARRport.SelectedIndex;
            drMainData["ARRdate"] = dtpARRDate.Value;
            drMainData["cust_gl_agent"] = cbcust_gl_agent.SelectedIndex;
            drMainData["cust_fee"] = tbCust_Fee.Text;
            drMainData["Import_Agent"] = cbImport_Agent.SelectedIndex;
            drMainData["ContractNO"] = tbContract_NO.Text;
            drMainData["Duty"] = tbDuty.Text;
            drMainData["VAT"] = tbVAT.Text;
            drMainData["CT"] = tbCT.Text;
            drMainData["AgentFee"] = tbAgentFee.Text;
            drMainData["DutyInJD"] = tbDutyInJD.Text;
            drMainData["VATinJD"] = tbVATinJD.Text;
            drMainData["CTinJD"] = tbCTinJD.Text;
            drMainData["ContainerNO"] = tbContainerNo.Text;
            drMainData["JD_Receiving_Date"] = dtpJD_Receiving_Date.Value;

            dtDecMain.Rows.Add(drMainData);

            string strSQL_DropMain = "delete from DecMain where OrderNO='" + tbOrderNO.Text + "'";
            ah.ExecuteSQLNonquery(strSQL_DropMain);
            ah.AddRowsToTable(dtDecMain, "DecMain");

            string strSQL_DropINV = "delete from DecINV where OrderNO='" + tbOrderNO.Text + "'";
            ah.ExecuteSQLNonquery(strSQL_DropINV);
            DataTable dtSaveINV;
            //dtSaveINV = GetDgvToTable(dgvINV);
            dtSaveINV = GetTableFromDgv(dgvINV, "DecINV");
            ah.AddRowsToTable(dtSaveINV, "DecINV");

            string strSQL_DropHS = "delete from DecHS where OrderNO='" + tbOrderNO.Text + "'";
            ah.ExecuteSQLNonquery(strSQL_DropHS);
            DataTable dtSaveHS;
            //dtSaveHS = GetDgvToTable(dgvHS);
            dtSaveHS = GetTableFromDgv(dgvHS, "DecHS");
            ah.AddRowsToTable(dtSaveHS, "DecHS");
            ah.Close();

            MessageBox.Show("提交成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void frmDecNewOrder_Load(object sender, EventArgs e)
        {
            string strUUID = System.Guid.NewGuid().ToString();
            tbOrderNO.Text = strUUID;

            dtExCusClearTime.Value = DateTime.Now;
            dtpARRDate.Value = DateTime.Now;
            dtpJD_Receiving_Date.Value = DateTime.Now;

            cbARRport.SelectedIndex = 0;
            cbcust_gl_agent.SelectedIndex = 0;
            cbImport_Agent.SelectedIndex = 0;

            tbCust_Fee.Text = "0";
            tbINV_Amount.Text = "0";
            tbFreight.Text = "0";
            tbDuty.Text = "0";
            tbVAT.Text = "0";
            tbCT.Text = "0";
            tbAgentFee.Text = "0";
            tbDutyInJD.Text = "0";
            tbVATinJD.Text = "0";
            tbCTinJD.Text = "0";
            tbINV_NO.Text = "";
            tbINV_Amount.Text = "0";
            tbFreight.Text = "0";
            tbCart_INV.Text = "0";
            tbPCs.Text = "0";

            AccessHelper ah = new AccessHelper();
            string strSQL_GetAllINVData = "select * from DecINV where OrderNO='" + tbOrderNO.Text + "' ";
            dtDecINV = ah.SelectToDataTable(strSQL_GetAllINVData);
            string strSQL_GetAllMainData = "select * from DecMain where OrderNO='" + tbOrderNO.Text + "' ";
            dtDecMain = ah.SelectToDataTable(strSQL_GetAllMainData);
            string strSQL_GetAllHS = "select * from DecHS where OrderNO='" + tbOrderNO.Text + "' ";
            dtDecHS = ah.SelectToDataTable(strSQL_GetAllHS);
            ah.Close();
            dtShowINV = dtDecINV.Clone();
            dgvINV.AutoGenerateColumns = false;
            dgvINV.DataSource = dtShowINV;
            dtShowHS = dtDecHS.Clone();
            dgvHS.AutoGenerateColumns = false;
            dgvHS.DataSource = dtShowHS;
        }

        private void btnAddINV_Click(object sender, EventArgs e)
        {
            DataRow drINVData = dtShowINV.NewRow();
            drINVData["OrderNO"] = tbOrderNO.Text;
            drINVData["Status"] = 0;
            drINVData["INV_NO"] = tbINV_NO.Text;
            drINVData["INV_Amount"] = tbINV_Amount.Text;
            drINVData["Freight"] = tbFreight.Text;
            drINVData["Cart_INV"] = tbCart_INV.Text;
            drINVData["PCs"] = tbPCs.Text;
            drINVData["Shop_Receiver"] = tbShop_Receiver.Text;
            dtShowINV.Rows.Add(drINVData);

            dgvINV.AutoGenerateColumns = false;
            dgvINV.DataSource = dtShowINV;

            tbINV_NO.Text = "";
            tbINV_Amount.Text = "0";
            tbFreight.Text = "0";
            tbCart_INV.Text = "0";
            tbPCs.Text = "0";
        }

        private void btnAddHS_Click(object sender, EventArgs e)
        {
            DataRow drHSData = dtShowHS.NewRow();
            drHSData["OrderNO"] = tbOrderNO.Text;
            drHSData["Status"] = 0;
            drHSData["HS_Code"] = tbHS_Code.Text;
            drHSData["M"] = tbM.Text;
            dtShowHS.Rows.Add(drHSData);

            dgvHS.AutoGenerateColumns = false;
            dgvHS.DataSource = dtShowHS;

            tbHS_Code.Text = "";
            tbM.Text = "0";
        }

        /// <summary>
        /// 方法实现把dgv里的数据完整的复制到一张内存表
        /// </summary>
        /// <param name="dgv">dgv控件作为参数</param>
        /// <returns>返回临时内存表</returns>
        public static DataTable GetDgvToTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();
            for (int count = 0; count < dgv.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());
                dt.Columns.Add(dc);
            }
            for (int count = 0; count < dgv.Rows.Count; count++)
            {
                DataRow dr = dt.NewRow();
                for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)
                {
                    if(dgv.Rows[count].Cells[countsub].Value != null)
                    {
                        dr[countsub] = dgv.Rows[count].Cells[countsub].Value.ToString();
                    }                   
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        private static DataTable GetTableFromDgv(DataGridView dgv,string strDataTableName)
        {
            DataTable dt = new DataTable();
            string strSQL = "select top 1 * from " + strDataTableName;
            AccessHelper ah = new AccessHelper();
            dt = ah.SelectToDataTable(strSQL);
            DataRow dr = dt.NewRow();
            int intdgvRowsCount = dgv.Rows.Count - 1;
            int intdgvColsCount = dgv.Columns.Count;
            if(intdgvRowsCount>0 && intdgvColsCount>0)
            {
                for(int x = 0;x < intdgvRowsCount;x++)
                {
                    for(int y = 0;y < intdgvColsCount;y++)
                    {
                        dr[y + 1] = dgv.Rows[x].Cells[y].Value;
                    }
                    dt.Rows.Add(dr.ItemArray);
                    dr = dt.NewRow();
                }
            }

            return dt;
        }

        private void btnCalINV_Click(object sender, EventArgs e)
        {

        }
    }
}
