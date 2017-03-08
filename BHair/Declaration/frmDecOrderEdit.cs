using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Security.Cryptography;

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
            DataTable dttemp = GenClass.GetTableFromDgv(dgvINV, "DecINV");
            if (!GenClass.CheckDT(dttemp, "INV_NO"))
            {
                AccessHelper ah = new AccessHelper();
                DataTable dtSaveMain = dtDecMain.Clone();
                DataRow drMainData = dtSaveMain.NewRow();

                drMainData["OrderNO"] = tbOrderNO.Text;
                drMainData["Status"] = 0;
                drMainData["ExCusClearTime"] = dtExCusClearTime.Value;
                drMainData["MAWB"] = tbMAWB.Text;
                drMainData["ARRport"] = cbARRport.Text;
                drMainData["ARRdate"] = dtpARRDate.Value;
                drMainData["cust_gl_agent"] = cbcust_gl_agent.Text;
                drMainData["cust_fee"] = tbCust_Fee.Text;
                drMainData["Import_Agent"] = cbImport_Agent.Text;
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
                ah.Close();
                ah = new AccessHelper();
                ah.AddRowsToTable(dtSaveMain, "DecMain");
                ah.Close();

                ah = new AccessHelper();
                string strSQL_DropINV = "delete from DecINV where OrderNO='" + tbOrderNO.Text + "'";
                ah.ExecuteSQLNonquery(strSQL_DropINV);
                ah.Close();
                ah = new AccessHelper();
                DataTable dtSaveINV;
                dtSaveINV = GenClass.GetTableFromDgv(dgvINV, "DecINV");
                ah.AddRowsToTable(dtSaveINV, "DecINV");
                ah.Close();

                ah = new AccessHelper();
                string strSQL_DropHS = "delete from DecHS where OrderNO='" + tbOrderNO.Text + "'";
                ah.ExecuteSQLNonquery(strSQL_DropHS);
                ah.Close();
                ah = new AccessHelper();
                DataTable dtSaveHS;
                dtSaveHS = GenClass.GetTableFromDgv(dgvHS, "DecHS");
                ah.AddRowsToTable(dtSaveHS, "DecHS");
                ah.Close();

                MessageBox.Show("提交成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                frmDecOrder fdo = new Business.frmDecOrder();
                fdo.Reflush();
            }
            else
            {
                MessageBox.Show("INV_NO有重复值,请检查!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

            foreach (DataRow drMainData in dtDecMain.Rows)
            {
                dtExCusClearTime.Value = DateTime.Parse(drMainData["ExCusClearTime"].ToString());
                tbMAWB.Text = drMainData["MAWB"].ToString();
                cbARRport.Text= drMainData["ARRport"].ToString();
                dtpARRDate.Value = DateTime.Parse(drMainData["ARRdate"].ToString());
                cbcust_gl_agent.Text= drMainData["cust_gl_agent"].ToString();
                tbCust_Fee.Text = drMainData["cust_fee"].ToString();
                cbImport_Agent.Text= drMainData["Import_Agent"].ToString();
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
            dgvHS.Sort(this.dgvHS.Columns["Shop_Receiver2"], ListSortDirection.Ascending);
        }

        private void btnAddINV_Click(object sender, EventArgs e)
        {
            DataTable dttemp = GenClass.GetTableFromDgv(dgvINV, "DecINV");
            if (GenClass.CheckDB_String(dttemp, "INV_NO", tbINV_NO.Text))
            {
                MessageBox.Show("INV_NO:" + tbINV_NO.Text + "重复,请检查!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
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
        }

        private void btnAddHS_Click(object sender, EventArgs e)
        {
            DataRow drHSData = dtShowHS.NewRow();
            drHSData["OrderNO"] = tbOrderNO.Text;
            drHSData["Status"] = 0;
            drHSData["HS_Code"] = tbHS_Code.Text;
            drHSData["M"] = tbM.Text;
            drHSData["Shop_Receiver"] = tbShopReceiver.Text;
            dtShowHS.Rows.Add(drHSData);

            dgvHS.AutoGenerateColumns = false;
            dgvHS.DataSource = dtShowHS;

            tbHS_Code.Text = "";
            tbM.Text = "0";
        }

        private void btnCalINV_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtSaveINV;
                dtSaveINV = GenClass.GetTableFromDgv(dgvINV, "DecINV");
                double douSumAmount = double.Parse(dtSaveINV.Compute("Sum(INV_Amount)", "True").ToString());
                double douSumDutyHS = double.Parse(tbDuty.Text);
                double douSumVATHS = double.Parse(tbVAT.Text);
                double douSumFreight = double.Parse(tbFreight.Text);
                double douSumCT = double.Parse(tbCT.Text);
                int intRowsnum = 0;

                foreach (DataRow dr in dtSaveINV.Rows)
                {
                    if (dr[1].ToString() != null && dr[1].ToString() != "")
                    {
                        double douINV_Amount = double.Parse(dr["INV_Amount"].ToString());
                        double douFreight = douSumFreight * (douINV_Amount / douSumAmount);
                        double douDuty = douSumDutyHS * (douINV_Amount / douSumAmount);
                        double douVAT = douSumVATHS * (douINV_Amount / douSumAmount);
                        double douCT = douSumCT * (douINV_Amount / douSumAmount);

                        dgvINV.Rows[intRowsnum].Cells["Freight"].Value = douFreight.ToString("0.00");
                        dgvINV.Rows[intRowsnum].Cells["Duty"].Value = douDuty.ToString("0.00");
                        dgvINV.Rows[intRowsnum].Cells["VAT"].Value = douVAT.ToString("0.00");
                        dgvINV.Rows[intRowsnum].Cells["CT"].Value = douCT.ToString("0.00");
                    }
                    intRowsnum++;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("计算发生异常,错误信息为:" + ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCalHS_Click(object sender, EventArgs e)
        {
            try
            {
                AccessHelper ah = new AccessHelper();
                string strSQL = "select * from SetupConfig ";
                DataTable dt = ah.SelectToDataTable(strSQL);
                double douExRate = 0.0;
                ah.Close();
                if (dt.Rows.Count > 0 && dt.Rows[0]["Rate"].ToString() != null && dt.Rows[0]["Rate"].ToString().Length > 0)
                {
                    douExRate = double.Parse(dt.Rows[0]["Rate"].ToString());
                }
                DataTable dtSaveHS;
                dtSaveHS = GenClass.GetTableFromDgv(dgvHS, "DecHS");
                DataTable dtHSSetting;
                string strSQL_GetHSSetting = "select * from DecHSSetting ";
                ah = new AccessHelper();
                dtHSSetting = ah.SelectToDataTable(strSQL_GetHSSetting);
                int intRowsNum = 0;

                foreach (DataRow dr in dtSaveHS.Rows)
                {
                    if (dr[1].ToString() != null && dr[1].ToString() != "")
                    {
                        string strHSCODE = dr["HS_CODE"].ToString();
                        DataRow[] drs;
                        drs = dtHSSetting.Select("HSCODE = '" + strHSCODE + "' ");
                        if (drs.Length > 0)
                        {
                            double douDutyS = double.Parse(drs[0][2].ToString());
                            double douVATs = double.Parse(drs[0][3].ToString());
                            double douM = double.Parse(dr["M"].ToString());
                            double douDuty = douM * douExRate * douDutyS;
                            double douVAT = (douDuty + (douM * douExRate)) * douVATs;

                            dgvHS.Rows[intRowsNum].Cells["Duty_System"].Value = douDuty.ToString("0.00");
                            dgvHS.Rows[intRowsNum].Cells["VAT_System"].Value = douVAT.ToString("0.00");
                        }
                        else
                        {
                            MessageBox.Show("HSCODE:" + strHSCODE + ",在系统中没有设定,请检查.", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    intRowsNum++;
                }
                dgvHS.Sort(this.dgvHS.Columns["Shop_Receiver2"], ListSortDirection.Ascending);
            }
            catch(Exception ex)
            {
                MessageBox.Show("计算发生异常,错误信息为:" + ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInputHS_Click(object sender, EventArgs e)
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
                    TempDT = pe.ExcelToDataTable_HS(filePath, tbOrderNO.Text);
                    dgvHS.AutoGenerateColumns = false;
                    dgvHS.DataSource = TempDT;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excel数据导入失败,详见数据错误列表::" + ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            DataTable TempDT;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel文件|*.xls";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;
                    PrintExcel pe = new PrintExcel();
                    TempDT = pe.ExcelToDataTable_INV(filePath, tbOrderNO.Text);
                    dgvINV.AutoGenerateColumns = false;
                    dgvINV.DataSource = TempDT;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excel数据导入失败,详见数据错误列表::" + ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnInputD_V_Click(object sender, EventArgs e)
        {
            DataTable dtTempHS = GenClass.GetTableFromDgv(dgvHS, "DecHS");
            DataTable dtTempINV = GenClass.GetTableFromDgv(dgvINV, "DecINV");
            DataTable dtResultHS = new DataTable();
            dtResultHS.Columns.Add(new DataColumn("Shop_Receiver", typeof(string)));
            dtResultHS.Columns.Add(new DataColumn("Duty_HSCODE", typeof(string)));
            dtResultHS.Columns.Add(new DataColumn("VAT_HSCODE", typeof(string)));
            DataTable dtResultINV = new DataTable();
            //dtResultINV.Columns.Add(new DataColumn("INV_NO", typeof(string)));
            //dtResultINV.Columns.Add(new DataColumn("INV_Amount", typeof(double)));
            //dtResultINV.Columns.Add(new DataColumn("Cart_INV", typeof(int)));
            //dtResultINV.Columns.Add(new DataColumn("PCs", typeof(int)));
            dtResultINV.Columns.Add(new DataColumn("Shop_Receiver", typeof(string)));
            dtResultINV.Columns.Add(new DataColumn("Freight", typeof(double)));
            dtResultINV.Columns.Add(new DataColumn("Duty", typeof(double)));
            dtResultINV.Columns.Add(new DataColumn("VAT", typeof(double)));
            dtResultINV.Columns.Add(new DataColumn("CT", typeof(double)));
            string strLastStringHS = "";
            double douSumDutyHS = 0.00;
            double douSumVATHS = 0.00;
            DataRow drNewHS;
            string strLastStringINV = "";
            double douSumDutyINV = 0.00;
            double douSumVATINV = 0.00;
            double douSumCTINV = 0.00;
            double douSumFreightINV = 0.00;
            DataRow drNewINV;

            foreach (DataRow dr in dtTempINV.Rows)
            {
                if (dr["Shop_Receiver"].ToString() != strLastStringINV && strLastStringINV.Length != 0)
                {
                    drNewINV = dtResultINV.NewRow();
                    drNewINV["Shop_Receiver"] = strLastStringINV;
                    drNewINV["Duty"] = douSumDutyINV.ToString("0.00");
                    drNewINV["VAT"] = douSumVATINV.ToString("0.00");
                    drNewINV["CT"] = douSumCTINV.ToString("0.00");
                    drNewINV["Freight"] = douSumFreightINV.ToString("0.00");
                    dtResultINV.Rows.Add(drNewINV);

                    strLastStringINV = dr["Shop_Receiver"].ToString();
                    douSumDutyINV = double.Parse(dr["Duty"].ToString());
                    douSumVATINV = double.Parse(dr["VAT"].ToString());
                    douSumCTINV = double.Parse(dr["CT"].ToString());
                    douSumFreightINV = double.Parse(dr["Freight"].ToString());
                }
                else if (dr["Shop_Receiver"].ToString() != strLastStringINV && strLastStringINV.Length == 0)
                {
                    strLastStringINV = dr["Shop_Receiver"].ToString();
                    douSumDutyINV = double.Parse(dr["Duty"].ToString());
                    douSumVATINV = double.Parse(dr["VAT"].ToString());
                    douSumCTINV = double.Parse(dr["CT"].ToString());
                    douSumFreightINV = double.Parse(dr["Freight"].ToString());
                }
                else if (dr["Shop_Receiver"].ToString() == strLastStringINV)
                {
                    douSumDutyINV = douSumDutyINV + double.Parse(dr["Duty"].ToString());
                    douSumVATINV = douSumVATINV + double.Parse(dr["VAT"].ToString());
                    douSumCTINV = douSumCTINV + double.Parse(dr["CT"].ToString());
                    douSumFreightINV = douSumFreightINV + double.Parse(dr["Freight"].ToString());
                }
                else
                {
                    MessageBox.Show("状态异常", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //The last data can not calculat in the method of foreach
            drNewINV = dtResultINV.NewRow();
            drNewINV["Shop_Receiver"] = strLastStringINV;
            drNewINV["Duty"] = douSumDutyINV.ToString("0.00");
            drNewINV["VAT"] = douSumVATINV.ToString("0.00");
            drNewINV["CT"] = douSumCTINV.ToString("0.00");
            drNewINV["Freight"] = douSumFreightINV.ToString("0.00");
            dtResultINV.Rows.Add(drNewINV);

            foreach (DataRow dr in dtTempHS.Rows)
            {
                if (dr["Shop_Receiver"].ToString() != strLastStringHS && strLastStringHS.Length != 0)
                {
                    drNewHS = dtResultHS.NewRow();
                    drNewHS["Shop_Receiver"] = strLastStringHS;
                    drNewHS["Duty_HSCODE"] = douSumDutyHS.ToString("0.00");
                    drNewHS["VAT_HSCODE"] = douSumVATHS.ToString("0.00");
                    dtResultHS.Rows.Add(drNewHS);

                    strLastStringHS = dr["Shop_Receiver"].ToString();
                    douSumDutyHS = double.Parse(dr["Duty_System"].ToString());
                    douSumVATHS = double.Parse(dr["VAT_System"].ToString());
                }
                else if (dr["Shop_Receiver"].ToString() != strLastStringHS && strLastStringHS.Length == 0)
                {
                    strLastStringHS = dr["Shop_Receiver"].ToString();
                    douSumDutyHS = double.Parse(dr["Duty_System"].ToString());
                    douSumVATHS = double.Parse(dr["VAT_System"].ToString());
                }
                else if (dr["Shop_Receiver"].ToString() == strLastStringHS)
                {
                    douSumDutyHS = douSumDutyHS + double.Parse(dr["Duty_System"].ToString());
                    douSumVATHS = douSumVATHS + double.Parse(dr["VAT_System"].ToString());
                }
                else
                {
                    MessageBox.Show("状态异常", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //The last data can not calculat in the method of foreach
            drNewHS = dtResultHS.NewRow();
            drNewHS["Shop_Receiver"] = strLastStringHS;
            drNewHS["Duty_HSCODE"] = douSumDutyHS.ToString("0.00");
            drNewHS["VAT_HSCODE"] = douSumVATHS.ToString("0.00");
            dtResultHS.Rows.Add(drNewHS);
        }

    }
}
