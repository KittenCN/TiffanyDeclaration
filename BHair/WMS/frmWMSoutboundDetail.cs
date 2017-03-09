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
    public partial class frmWMSoutboundDetail : Form
    {
        public DataTable dtShowWMSOutDetail;
        public DataTable dtShowWMSOut;
        public DataTable dtSaveWMSOut;
        public DataTable dtSaveWMSOutDetail;
        public string strOutboundNO = "";
        public frmWMSoutboundDetail()
        {
            InitializeComponent();
        }
        public frmWMSoutboundDetail(string strOutNO)
        {
            InitializeComponent();
            strOutboundNO = strOutNO;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            string strSQL = "select * from WMSMain where SKU='" + tbSKU.Text + "' and WearHouse='" + cbWearHouse.Text + "' ";
            AccessHelper ah = new AccessHelper();
            DataTable dt = ah.SelectToDataTable(strSQL);
            ah.Close();
            DataTable dttemp = GenClass.GetTableFromDgv(dgvWMSOutboundDetail, "WMSOutboundDetail");
            if (GenClass.CheckDB_String(dttemp, "SKU", tbSKU.Text))
            {
                MessageBox.Show("SKU:" + tbSKU.Text + "重复,请检查!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dt.Rows.Count > 0 && int.Parse(dt.Rows[0]["Amount"].ToString()) > int.Parse(tbPCss.Text))
                {
                    DataRow drShow = dtShowWMSOutDetail.NewRow();
                    drShow["OrderNO"] = "";
                    drShow["Status"] = 0;
                    drShow["OutboundNO"] = tbOutboundNO.Text;
                    drShow["SKU"] = tbSKU.Text;
                    drShow["Description"] = tbDescription.Text;
                    drShow["OutsiteSize"] = tbOutsiteSize.Text;
                    drShow["Specification"] = tbSpecification.Text;
                    drShow["Carton"] = tbCarton.Text;
                    drShow["PCs"] = tbPCss.Text;
                    drShow["Remarks"] = tbRemarks.Text;
                    drShow["WMSNO"] = tbWMSNO.Text;
                    drShow["ItemNO"] = tbItemNO.Text;
                    dtSaveWMSOutDetail.Rows.Add(drShow.ItemArray);
                    dgvWMSOutboundDetail.AutoGenerateColumns = false;
                    dgvWMSOutboundDetail.DataSource = dtSaveWMSOutDetail;

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
                else
                {
                    MessageBox.Show("SKU:" + tbSKU.Text + "库存不足!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void frmWMSinboundDetail_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from WMSOutboundDetail where OutboundNO='" + strOutboundNO + "' ";
            AccessHelper ah = new Business.AccessHelper();
            dtShowWMSOutDetail = ah.SelectToDataTable(strSQL);
            dtSaveWMSOutDetail = dtShowWMSOutDetail.Clone();
            strSQL = "select * from WMSOutbound where OutboundNO='" + strOutboundNO + "' ";
            dtShowWMSOut = ah.SelectToDataTable(strSQL);
            dtSaveWMSOut = dtShowWMSOut.Clone();
            ah.Close();

            dgvWMSOutboundDetail.AutoGenerateColumns = false;
            dgvWMSOutboundDetail.DataSource = dtShowWMSOutDetail;

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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dttemp = GenClass.GetTableFromDgv(dgvWMSOutboundDetail, "WMSOutboundDetail");
            if (!GenClass.CheckDT(dttemp, "OutboundNO"))
            {
                DataRow drSaveWMSOut = dtSaveWMSOut.NewRow();
                drSaveWMSOut["OrderNO"] = "";
                drSaveWMSOut["Status"] = 0;
                drSaveWMSOut["OutDate"] = dtOutDate.Value;
                drSaveWMSOut["OutboundNO"] = tbOutboundNO.Text;
                drSaveWMSOut["WHSup"] = tbWHSup.Text;
                drSaveWMSOut["Shipper"] = tbShipper.Text;
                drSaveWMSOut["Contact"] = tbContact.Text;
                drSaveWMSOut["OutType"] = tbOutType.Text;
                drSaveWMSOut["ReceiptAdd"] = tbReceiptAdd.Text;
                drSaveWMSOut["Deadline"] = dtpDeadline.Value;
                drSaveWMSOut["WearHouse"] = cbWearHouse.Text;
                drSaveWMSOut["Prepared"] = tbPrerared.Text;
                drSaveWMSOut["OperSup"] = tbOperSup.Text;
                dtSaveWMSOut.Rows.Add(drSaveWMSOut);

                AccessHelper ah = new AccessHelper();
                string strSQL_DropMain = "delete from WMSOutbound where OutboundNO='" + strOutboundNO + "' ";
                ah.ExecuteSQLNonquery(strSQL_DropMain);
                ah.AddRowsToTable(dtSaveWMSOut, "WMSOutbound");

                string strSQL_DropWMSD = "delete from WMSOutboundDetail where OutboundNO='" + strOutboundNO + "' ";
                ah.ExecuteSQLNonquery(strSQL_DropWMSD);
                DataTable dtSaveWMSD;
                dtSaveWMSD = GenClass.GetTableFromDgv(dgvWMSOutboundDetail, "WMSOutboundDetail");
                ah.AddRowsToTable(dtSaveWMSD, "WMSOutboundDetail");

                foreach (DataRow dr in dtSaveWMSD.Rows)
                {
                    string strSKU = dr["SKU"].ToString();
                    int intAmount = int.Parse(dr["PCs"].ToString());

                    string strSQL = "select * from WMSMain where sku='" + strSKU + "' and wearhouse='" + cbWearHouse.Text + "' ";
                    DataTable dtTemp = ah.SelectToDataTable(strSQL);
                    ah.Close();
                    ah = new AccessHelper();
                    if (dtTemp.Rows.Count > 0 && int.Parse(dtTemp.Rows[0]["Amount"].ToString()) > intAmount)
                    {
                        strSQL = "update WMSMain set Amount=Amount-" + intAmount + " where sku='" + strSKU + "' and wearhouse='" + cbWearHouse.Text + "' ";
                    }
                    else
                    {
                        strSQL = "";
                        MessageBox.Show("SKU:" + tbSKU.Text + "库存不足!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ah.ExecuteSQLNonquery(strSQL);
                }

                ah.Close();
                MessageBox.Show("提交成功", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("出库单号有重复值,请检查!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    TempDT = pe.ExcelToDataTable_WMSinDetail(filePath, "");
                    dgvWMSOutboundDetail.AutoGenerateColumns = false;
                    dgvWMSOutboundDetail.DataSource = TempDT;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excel数据导入失败,详见数据错误列表::" + ex.Message, "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
