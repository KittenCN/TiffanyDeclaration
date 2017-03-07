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
            DataTable dttemp = GenClass.GetTableFromDgv(dgvINV, "DecINV");
            if (!GenClass.CheckDT(dttemp, "INV_NO"))
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

                dtDecMain.Rows.Add(drMainData);

                string strSQL_DropMain = "delete from DecMain where OrderNO='" + tbOrderNO.Text + "'";
                ah.ExecuteSQLNonquery(strSQL_DropMain);
                ah.AddRowsToTable(dtDecMain, "DecMain");

                string strSQL_DropINV = "delete from DecINV where OrderNO='" + tbOrderNO.Text + "'";
                ah.ExecuteSQLNonquery(strSQL_DropINV);
                DataTable dtSaveINV;
                //dtSaveINV = GetDgvToTable(dgvINV);
                dtSaveINV = GenClass.GetTableFromDgv(dgvINV, "DecINV");
                ah.AddRowsToTable(dtSaveINV, "DecINV");

                string strSQL_DropHS = "delete from DecHS where OrderNO='" + tbOrderNO.Text + "'";
                ah.ExecuteSQLNonquery(strSQL_DropHS);
                DataTable dtSaveHS;
                //dtSaveHS = GetDgvToTable(dgvHS);
                dtSaveHS = GenClass.GetTableFromDgv(dgvHS, "DecHS");
                ah.AddRowsToTable(dtSaveHS, "DecHS");
                ah.Close();

                MessageBox.Show("提交成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("INV_NO有重复值,请检查!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            dtShowHS.Rows.Add(drHSData);

            dgvHS.AutoGenerateColumns = false;
            dgvHS.DataSource = dtShowHS;

            tbHS_Code.Text = "";
            tbM.Text = "0";
        }

        private void btnCalINV_Click(object sender, EventArgs e)
        {

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
    }
}
