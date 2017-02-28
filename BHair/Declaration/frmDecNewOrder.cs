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
            DataTable dtDecMain;
            AccessHelper ah = new AccessHelper();
            string strSQL_GetAOneMainData = "select top 1 * from DecMain ";
            dtDecMain = ah.SelectToDataTable(strSQL_GetAOneMainData);
            DataRow drMainData = dtDecMain.NewRow();

            drMainData["OrderNO"] = tbOrderNO.Text;
            drMainData["Status"] = 0;
            drMainData["ExCusClearTime"] = "#" + dtExCusClearTime.ToString() + "#";
        }
    }
}
