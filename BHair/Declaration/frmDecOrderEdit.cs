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
    public partial class frmDecOrderEdit : Form
    {
        public DataTable dtShowINV;
        public DataTable dtDecINV;
        public DataTable dtDecMain;
        public DataTable dtShowHS;
        public DataTable dtDecHS;
        public frmDecOrderEdit(string strUUID)
        {
            InitializeComponent();
            tbOrderNO.Text = strUUID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            AccessHelper ah = new AccessHelper();
            DataTable dtSaveMain = dtDecMain.Clone();
            DataRow drMainData = dtSaveMain.NewRow();

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
            drMainData["Freight"] = tbFreight.Text;
            drMainData["Duty"] = tbDuty.Text;
            drMainData["VAT"] = tbVAT.Text;
            drMainData["CT"] = tbCT.Text;
            drMainData["AgentFee"] = tbAgentFee.Text;
            drMainData["DutyInJD"] = tbDutyInJD.Text;
            drMainData["VATinJD"] = tbVATinJD.Text;
            drMainData["CTinJD"] = tbCTinJD.Text;
            drMainData["ContainerNO"] = tbContainerNo.Text;
            drMainData["JD_Receiving_Date"] = dtpJD_Receiving_Date.Value;

            dtSaveMain.Rows.Add(drMainData);

            string strSQL_DropMain = "delete from DecMain where OrderNO='" + tbOrderNO.Text + "'";
            ah.ExecuteSQLNonquery(strSQL_DropMain);
            ah.AddRowsToTable(dtSaveMain, "DecMain");

            string strSQL_DropINV = "delete from DecINV where OrderNO='" + tbOrderNO.Text + "'";
            ah.ExecuteSQLNonquery(strSQL_DropINV);
            DataTable dtSaveINV;
            dtSaveINV = GetTableFromDgv(dgvINV, "DecINV");
            ah.AddRowsToTable(dtSaveINV, "DecINV");

            string strSQL_DropHS = "delete from DecHS where OrderNO='" + tbOrderNO.Text + "'";
            ah.ExecuteSQLNonquery(strSQL_DropHS);
            DataTable dtSaveHS;
            dtSaveHS = GetTableFromDgv(dgvHS, "DecHS");
            ah.AddRowsToTable(dtSaveHS, "DecHS");
            ah.Close();

            MessageBox.Show("提交成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            frmDecOrder fdo = new Business.frmDecOrder();
            fdo.Reflush();
        }

        private void frmDecNewOrder_Load(object sender, EventArgs e)
        {
            //string strUUID = System.Guid.NewGuid().ToString();
            //tbOrderNO.Text = strUUID;

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
            dtShowINV = dtDecINV.Copy();
            dgvINV.AutoGenerateColumns = false;
            dgvINV.DataSource = dtShowINV;
            dtShowHS = dtDecHS.Copy();
            dgvHS.AutoGenerateColumns = false;
            dgvHS.DataSource = dtShowHS;

            foreach(DataRow drMainData in dtDecMain.Rows)
            {
                dtExCusClearTime.Value = DateTime.Parse(drMainData["ExCusClearTime"].ToString());
                tbMAWB.Text = drMainData["MAWB"].ToString();
                cbARRport.SelectedIndex = int.Parse(drMainData["ARRport"].ToString());
                dtpARRDate.Value = DateTime.Parse(drMainData["ARRdate"].ToString());
                cbcust_gl_agent.SelectedIndex = int.Parse(drMainData["cust_gl_agent"].ToString());
                tbCust_Fee.Text = drMainData["cust_fee"].ToString();
                cbImport_Agent.SelectedIndex = int.Parse(drMainData["Import_Agent"].ToString());
                tbContract_NO.Text = drMainData["ContractNO"].ToString();
                tbFreight.Text = drMainData["Freight"].ToString();
                tbDuty.Text = drMainData["Duty"].ToString();
                tbVAT.Text = drMainData["VAT"].ToString();
                tbCT.Text = drMainData["CT"].ToString();
                tbAgentFee.Text = drMainData["AgentFee"].ToString();
                tbDutyInJD.Text = drMainData["DutyInJD"].ToString();
                tbVATinJD.Text = drMainData["VATinJD"].ToString();
                tbCTinJD.Text = drMainData["CTinJD"].ToString();
                tbContainerNo.Text = drMainData["ContainerNO"].ToString();
                dtpJD_Receiving_Date.Value = DateTime.Parse(drMainData["JD_Receiving_Date"].ToString());
            }
        }

        private void btnAddINV_Click(object sender, EventArgs e)
        {
            DataRow drINVData = dtShowINV.NewRow();
            drINVData["OrderNO"] = tbOrderNO.Text;
            drINVData["Status"] = 0;
            drINVData["INV_NO"] = tbINV_NO.Text;
            drINVData["INV_Amount"] = tbINV_Amount.Text;
            //drINVData["Freight"] = tbFreight.Text;
            drINVData["Cart_INV"] = tbCart_INV.Text;
            drINVData["PCs"] = tbPCs.Text;
            drINVData["Shop_Receiver"] = tbShop_Receiver.Text;
            dtShowINV.Rows.Add(drINVData);

            dgvINV.AutoGenerateColumns = false;
            dgvINV.DataSource = dtShowINV;

            tbINV_NO.Text = "";
            tbINV_Amount.Text = "0";
            //tbFreight.Text = "0";
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

        private static DataTable GetTableFromDgv(DataGridView dgv,string strDataTableName)
        {
            DataTable dt = new DataTable();
            string strSQL = "select top 1 * from " + strDataTableName;
            AccessHelper ah = new AccessHelper();
            dt = ah.SelectToDataTable(strSQL);
            DataTable dtNew = dt.Clone();
            DataRow dr = dtNew.NewRow();
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
                    dtNew.Rows.Add(dr.ItemArray);
                    dr = dtNew.NewRow();
                }
            }
            return dtNew;
        }

        private void btnCalINV_Click(object sender, EventArgs e)
        {
            DataTable dtSaveINV;
            dtSaveINV = GetTableFromDgv(dgvINV, "DecINV");
            double douSumAmount = double.Parse(dtSaveINV.Compute("Sum(INV_Amount)", "True").ToString());
            double douSumDuty = double.Parse(tbDuty.Text);
            double douSumVAT = double.Parse(tbVAT.Text);
            double douSumFreight = double.Parse(tbFreight.Text);
            int intRowsnum = 0;

            foreach (DataRow dr in dtSaveINV.Rows)
            {               
                if(dr[1].ToString() != null && dr[1].ToString() != "")
                {
                    double douINV_Amount = double.Parse(dr["INV_Amount"].ToString());
                    double douFreight = douSumFreight * (douINV_Amount / douSumAmount);
                    double douDuty = douSumDuty * (douINV_Amount / douSumAmount);
                    double douVAT = douSumVAT * (douINV_Amount / douSumAmount);

                    dgvINV.Rows[intRowsnum].Cells["Freight"].Value = douFreight.ToString();
                    dgvINV.Rows[intRowsnum].Cells["Duty"].Value = douDuty.ToString();
                    dgvINV.Rows[intRowsnum].Cells["VAT"].Value = douVAT.ToString();
                }
                intRowsnum++;
            }
        }

        private void btnCalHS_Click(object sender, EventArgs e)
        {
            DataTable dtSaveHS;
            dtSaveHS = GetTableFromDgv(dgvHS, "DecHS");
            DataTable dtHSSetting;
            string strSQL_GetHSSetting = "select * from DecHSSetting ";
            AccessHelper ah = new AccessHelper();
            dtHSSetting = ah.SelectToDataTable(strSQL_GetHSSetting);
            int intRowsNum = 0;
            double douExRate = 6.6056;

            foreach (DataRow dr in dtSaveHS.Rows)
            {
                if (dr[1].ToString() != null && dr[1].ToString() != "")
                {
                    string strHSCODE = dr["HS_CODE"].ToString();
                    DataRow[] drs;
                    drs = dtHSSetting.Select("HSCODE = '" + strHSCODE + "' ");
                    if(drs.Length > 0)
                    {
                        double douDutyS = double.Parse(drs[0][2].ToString());
                        double douVATs = double.Parse(drs[0][3].ToString());
                        double douM = double.Parse(dr["M"].ToString());
                        double douDuty = douM * douExRate * douDutyS;
                        double douVAT = (douDuty + (douM * douExRate)) * douVATs;

                        dgvHS.Rows[intRowsNum].Cells["Duty_System"].Value = douDuty.ToString();
                        dgvHS.Rows[intRowsNum].Cells["VAT_System"].Value = douVAT.ToString();
                    }
                    else
                    {
                        MessageBox.Show("HSCODE:" + strHSCODE + ",在系统中没有设定,请检查.", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                intRowsNum++;
            }
        }
    }
}
