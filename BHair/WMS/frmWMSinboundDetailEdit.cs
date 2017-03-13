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
    public partial class frmWMSinboundDetailEdit : Form
    {
        public DataTable dtShowWMSInDetail;
        public DataTable dtShowWMSIn;
        public DataTable dtSaveWMSIn;
        public DataTable dtSaveWMSInDetail;
        public string strInboundNO = "";
        public frmWMSinboundDetailEdit()
        {
            InitializeComponent();
        }
        public frmWMSinboundDetailEdit(string strInNO)
        {
            InitializeComponent();
            strInboundNO = strInNO;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            DataTable dttemp = GenClass.GetTableFromDgv(dgvWMSInboundDetail, "WMSinboundDetail");
            if (GenClass.CheckDB_String(dttemp, "SKU", tbSKU.Text))
            {
                MessageBox.Show("SKU:" + tbSKU.Text + "重复,请检查!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataRow drShow = dtShowWMSInDetail.NewRow();
                drShow["OrderNO"] = "";
                drShow["Status"] = 0;
                drShow["InboundNO"] = tbInboundNO.Text;
                drShow["SKU"] = tbSKU.Text;
                drShow["Description"] = tbDescription.Text;
                drShow["OutsiteSize"] = tbOutsiteSize.Text;
                drShow["Specification"] = tbSpecification.Text;
                drShow["Carton"] = tbCarton.Text;
                drShow["PCs"] = tbPCss.Text;
                drShow["Remarks"] = tbRemarks.Text;
                drShow["WMSNO"] = tbWMSNO.Text;
                drShow["ItemNO"] = tbItemNO.Text;
                dtSaveWMSInDetail.Rows.Add(drShow.ItemArray);
                dgvWMSInboundDetail.AutoGenerateColumns = false;
                dgvWMSInboundDetail.DataSource = dtSaveWMSInDetail;

                tbSKU.Text = "";
                tbDescription.Text = "";
                tbOutsiteSize.Text = "";
                tbSpecification.Text = "";
                tbCarton.Text = "";
                tbPCss.Text = "";
                tbRemarks.Text = "";
                tbWMSNO.Text = "";
                tbItemNO.Text = "";
            }
        }

        private void frmWMSinboundDetail_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            string strSQL = "select * from WMSInboundDetail where InboundNO='" + strInboundNO + "' ";
            AccessHelper ah = new Business.AccessHelper();
            dtShowWMSInDetail = ah.SelectToDataTable(strSQL);
            dtSaveWMSInDetail = dtShowWMSInDetail.Copy();
            strSQL = "select * from WMSInbound where InboundNO='" + strInboundNO + "' ";
            dtShowWMSIn = ah.SelectToDataTable(strSQL);
            dtSaveWMSIn = dtShowWMSIn.Clone();
            ah.Close();

            dgvWMSInboundDetail.AutoGenerateColumns = false;
            dgvWMSInboundDetail.DataSource = dtShowWMSInDetail;

            string[] strWMSTemp = Login.LoginUser.Store.ToString().Split(',');
            if (strWMSTemp[0] != "" && strWMSTemp[0] != null && strWMSTemp.Length > 1)
            {
                for (int i = 0; i < strWMSTemp.Length; i++)
                {
                    if (strWMSTemp[i].ToString() != null && strWMSTemp[i].ToString() != "")
                    {
                        cbWearHouse.Items.Add(strWMSTemp[i].ToString());
                    }
                }
            }
            else
            {
                cbWearHouse.Items.Add(strWMSTemp[0]);
            }
            if (cbWearHouse.Items.Count > 0)
            {
                cbWearHouse.SelectedIndex = 0;
            }

            foreach (DataRow drShowWMSIn in dtShowWMSIn.Rows)
            {
                dtInDate.Value = DateTime.Parse(drShowWMSIn["InDate"].ToString());
                tbInboundNO.Text = drShowWMSIn["InboundNO"].ToString();
                tbShipper.Text = drShowWMSIn["Shipper"].ToString();
                tbUser.Text = drShowWMSIn["User"].ToString();
                tbDosNO.Text = drShowWMSIn["DocNO"].ToString();
                tbDocNOs.Text = drShowWMSIn["DocNOs"].ToString();
                tbPCs.Text = drShowWMSIn["PCs"].ToString();
                tbGrossWGT.Text = drShowWMSIn["GrossWGT"].ToString();
                cbWearHouse.Text = drShowWMSIn["WearHouse"].ToString();
                tbPrerared.Text = drShowWMSIn["Prepared"].ToString();
                tbOperSup.Text = drShowWMSIn["OperSup"].ToString();
                tbWHSup.Text = drShowWMSIn["WHSup"].ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dttemp = GenClass.GetTableFromDgv(dgvWMSInboundDetail, "WMSInboundDetail");
            if (!GenClass.CheckDT(dttemp, "SKU"))
            {
                DataRow drSaveWMSIn = dtSaveWMSIn.NewRow();
                drSaveWMSIn["OrderNO"] = "";
                drSaveWMSIn["Status"] = 0;
                drSaveWMSIn["InDate"] = dtInDate.Value;
                drSaveWMSIn["InboundNO"] = tbInboundNO.Text;
                drSaveWMSIn["Shipper"] = tbShipper.Text;
                drSaveWMSIn["User"] = tbUser.Text;
                drSaveWMSIn["DocNO"] = tbDosNO.Text;
                drSaveWMSIn["DocNOs"] = tbDocNOs.Text;
                drSaveWMSIn["PCs"] = tbPCs.Text;
                drSaveWMSIn["GrossWGT"] = tbGrossWGT.Text;
                drSaveWMSIn["WearHouse"] = cbWearHouse.Text;
                drSaveWMSIn["Prepared"] = tbPrerared.Text;
                drSaveWMSIn["OperSup"] = tbOperSup.Text;
                drSaveWMSIn["WHSup"] = tbWHSup.Text;
                dtSaveWMSIn.Rows.Add(drSaveWMSIn);

                AccessHelper ah = new AccessHelper();
                string strSQL_DropMain = "delete from WMSInbound where InboundNO='" + strInboundNO + "' ";
                ah.ExecuteSQLNonquery(strSQL_DropMain);
                ah.AddRowsToTable(dtSaveWMSIn, "WMSInbound");

                DataTable dtSaveWMSD;
                dtSaveWMSD = GenClass.GetTableFromDgv(dgvWMSInboundDetail, "WMSInboundDetail");
                foreach (DataRow dr in dtSaveWMSD.Rows)
                {
                    string strSKU = dr["SKU"].ToString();
                    int intAmount = int.Parse(dr["PCs"].ToString());

                    string strSQL = "select * from WMSMain where sku='" + strSKU + "' and wearhouse='" + cbWearHouse.Text + "' ";
                    DataTable dtTemp = ah.SelectToDataTable(strSQL);
                    ah.Close();
                    ah = new AccessHelper();
                    if (dtTemp.Rows.Count > 0)
                    {
                        strSQL = "select * from WMSInboundDetail where InboundNO='" + strInboundNO + "' and SKU='" + strSKU + "' ";
                        AccessHelper ahin = new AccessHelper();
                        DataTable dtin = ahin.SelectToDataTable(strSQL);
                        ahin.Close();
                        if (dtin.Rows.Count > 0)
                        {
                            int intOldAmount = int.Parse(dtin.Rows[0]["PCs"].ToString());
                            strSQL = "update WMSMain set Amount=Amount-" + intOldAmount + "+" + intAmount + " where sku='" + strSKU + "' and wearhouse='" + cbWearHouse.Text + "' ";
                        }
                        else
                        {
                            strSQL = "update WMSMain set Amount=Amount+" + intAmount + " where sku='" + strSKU + "' and wearhouse='" + cbWearHouse.Text + "' ";
                        }

                    }
                    else
                    {
                        strSQL = "insert into WMSMain(SKU,Amount,WearHouse) values('" + strSKU + "'," + intAmount + ",'" + cbWearHouse.Text + "') ";
                    }
                    ah.ExecuteSQLNonquery(strSQL);
                }
                string strSQL_DropWMSD = "delete from WMSInboundDetail where InboundNO='" + strInboundNO + "' ";
                ah.ExecuteSQLNonquery(strSQL_DropWMSD);
                ah.AddRowsToTable(dtSaveWMSD, "WMSInboundDetail");

                ah.Close();
                MessageBox.Show("提交成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("SKU有重复值,请检查!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                    TempDT = pe.ExcelToDataTable_WMSinDetail(filePath, tbInboundNO.Text);
                    dgvWMSInboundDetail.AutoGenerateColumns = false;
                    dgvWMSInboundDetail.DataSource = TempDT;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excel数据导入失败,详见数据错误列表::" + ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExToExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel文件(*.xls)|*.xls";
            // Show save file dialog box
            DialogResult result = saveFileDialog.ShowDialog();
            //点了保存按钮进入
            if (result == DialogResult.OK)
            {
                //获得文件路径
                string localFilePath = saveFileDialog.FileName.ToString();
                PrintExcel pe = new PrintExcel();
                try
                {
                    string strSQL = "select * from WMSInbound where InboundNO='" + tbInboundNO.Text + "' ";
                    AccessHelper ah = new AccessHelper();
                    DataTable dtWMSIn = ah.SelectToDataTable(strSQL);
                    ah.Close();
                    strSQL = "select * from WMSInboundDetail where InboundNO='" + tbInboundNO.Text + "' ";
                    ah = new AccessHelper();
                    DataTable dtWMSInD = ah.SelectToDataTable(strSQL);
                    ah.Close();
                    pe.ExtoEXCELfromInD(dtWMSIn, dtWMSInD, localFilePath);
                    MessageBox.Show("保存成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存失败", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExToPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF文件(*.pdf)|*.pdf";
            // Show save file dialog box
            DialogResult result = saveFileDialog.ShowDialog();
            //点了保存按钮进入
            if (result == DialogResult.OK)
            {
                //获得文件路径
                string localFilePath = saveFileDialog.FileName.ToString();
                PrintExcel pe = new PrintExcel();
                try
                {
                    string strSQL = "select * from WMSInbound where InboundNO='" + tbInboundNO.Text + "' ";
                    AccessHelper ah = new AccessHelper();
                    DataTable dtWMSIn = ah.SelectToDataTable(strSQL);
                    ah.Close();
                    strSQL = "select * from WMSInboundDetail where InboundNO='" + tbInboundNO.Text + "' ";
                    ah = new AccessHelper();
                    DataTable dtWMSInD = ah.SelectToDataTable(strSQL);
                    ah.Close();
                    pe.ExPDFfromInD(dtWMSIn, dtWMSInD, localFilePath);
                    MessageBox.Show("保存成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存失败", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnRelate_Click(object sender, EventArgs e)
        {
            if (tbDocNOs.Text.Length > 0)
            {
                string strSQL = "select * from DecMain where MAWB='" + tbDocNOs.Text + "' ";
                AccessHelper ah = new AccessHelper();
                DataTable dt = ah.SelectToDataTable(strSQL);
                ah.Close();
                if (dt.Rows.Count > 0)
                {
                    frmDecOrderRelate fdor = new frmDecOrderRelate(dt.Rows[0]["OrderNO"].ToString());
                    fdor.ShowDialog();
                }
                else
                {
                    MessageBox.Show("未查询到与此分单号相同的入关信息!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("分单号为空!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReportToExcel_Click(object sender, EventArgs e)
        {
            string strSQL = "select * from WMSInboundDetail where InboundNO='" + strInboundNO + "' ";
            AccessHelper ah = new Business.AccessHelper();
            dtShowWMSInDetail = ah.SelectToDataTable(strSQL);
            strSQL = "select * from WMSInbound where InboundNO='" + strInboundNO + "' ";
            dtShowWMSIn = ah.SelectToDataTable(strSQL);
            ah.Close();
            DataTable dtWMSInDResult = new DataTable();
            dtWMSInDResult.Columns.Add(new DataColumn("SKU", typeof(string)));
            dtWMSInDResult.Columns.Add(new DataColumn("Description", typeof(string)));
            dtWMSInDResult.Columns.Add(new DataColumn("OutsiteSize", typeof(double)));
            dtWMSInDResult.Columns.Add(new DataColumn("Specification", typeof(string)));
            dtWMSInDResult.Columns.Add(new DataColumn("Carton", typeof(int)));
            dtWMSInDResult.Columns.Add(new DataColumn("PCs", typeof(int)));
            dtWMSInDResult.Columns.Add(new DataColumn("Remarks", typeof(string)));
            dtWMSInDResult.Columns.Add(new DataColumn("WMSNO", typeof(string)));
            dtWMSInDResult.Columns.Add(new DataColumn("ItemNO", typeof(string)));
            DataRow drWMSInD;
            DataTable dtResult = new DataTable();
            dtResult.Columns.Add(new DataColumn("MAWB", typeof(string)));
            dtResult.Columns.Add(new DataColumn("HAWB", typeof(string)));
            dtResult.Columns.Add(new DataColumn("FORWARDER", typeof(string)));
            dtResult.Columns.Add(new DataColumn("ORG", typeof(string)));
            dtResult.Columns.Add(new DataColumn("ARRport", typeof(string)));
            dtResult.Columns.Add(new DataColumn("ARRdate", typeof(DateTime)));
            dtResult.Columns.Add(new DataColumn("CUST DATE", typeof(DateTime)));
            dtResult.Columns.Add(new DataColumn("TOTAL CARTONS", typeof(int)));
            dtResult.Columns.Add(new DataColumn("GROSS WGT", typeof(double)));
            dtResult.Columns.Add(new DataColumn("CHARGEABEL WGT", typeof(double)));
            dtResult.Columns.Add(new DataColumn("SHIPPER/VENDOR", typeof(string)));
            dtResult.Columns.Add(new DataColumn("INV_NO", typeof(string)));
            dtResult.Columns.Add(new DataColumn("INV_Amount", typeof(double)));
            dtResult.Columns.Add(new DataColumn("Cart_INV", typeof(int)));
            dtResult.Columns.Add(new DataColumn("PCs", typeof(int)));
            dtResult.Columns.Add(new DataColumn("Shop_Receiver", typeof(string)));
            dtResult.Columns.Add(new DataColumn("Duty", typeof(double)));
            dtResult.Columns.Add(new DataColumn("VAT", typeof(double)));
            dtResult.Columns.Add(new DataColumn("CT", typeof(double)));
            dtResult.Columns.Add(new DataColumn("SHOP/ RECEIVER", typeof(string)));
            dtResult.Columns.Add(new DataColumn("DUTY BILL RETURN DATE", typeof(DateTime)));
            dtResult.Columns.Add(new DataColumn("INBOUND DATE", typeof(DateTime)));
            dtResult.Columns.Add(new DataColumn("DESCRIPTION", typeof(string)));
            dtResult.Columns.Add(new DataColumn("WEARHOUSE NUMBER", typeof(string)));
            dtResult.Columns.Add(new DataColumn("Freight Cost", typeof(double)));
            dtResult.Columns.Add(new DataColumn("MIS. FEE", typeof(double)));

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel文件(*.csv)|*.csv";
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    string localFilePath = saveFileDialog.FileName.ToString();
                    PrintExcel pe = new PrintExcel();
                    Boolean boolRunFirst = false;
                    string strLastString = "";
                    foreach(DataRow dr in dtShowWMSInDetail.Rows)
                    {
                        DataRow drR = dtResult.NewRow();
                        if (!boolRunFirst)
                        {
                            drR.ItemArray = drData(drR,tbDocNOs.Text).ItemArray.Clone() as object[];
                            boolRunFirst = true;
                        }

                    }
                }
                catch(Exception ex)
                {

                }
             }
        }
        private DataRow drData(DataRow drMainData,string strUUID)
        {
            string strSQL = "select * from DecMain where MAWB='" + tbDocNOs.Text + "' ";
            AccessHelper ah = new AccessHelper();
            DataTable dt = ah.SelectToDataTable(strSQL);
            ah.Close();
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                drMainData["CUST DATE"] = DateTime.Parse(dr["ExCusClearTime"].ToString());
                drMainData["MAWB"] = dr["MAWB"].ToString();
                drMainData["ARRport"] = dr["ARRport"].ToString();
                drMainData["ARRdate"] = DateTime.Parse(dr["ARRdate"].ToString());
                drMainData["TOTAL CARTONS"] = int.Parse(dr["Cart_INV"].ToString());
            }
            return drMainData;
        }
    }
}
