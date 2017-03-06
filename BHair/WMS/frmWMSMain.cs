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
    public partial class frmWMSMain : WinFormsUI.Docking.DockContent
    {
        public frmWMSMain()
        {
            InitializeComponent();
        }

        private void frmWMSMain_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            string[] strWMTemp = Login.LoginUser.Store.ToString().Split(',');
            DataTable dtShowdgvWMSMain = SelectApplicationByApplicants(strWMTemp, "");
            dgvWMSMain.AutoGenerateColumns = false;
            dgvWMSMain.DataSource = dtShowdgvWMSMain;
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
                    string sqlString = string.Format("select * from WMSMain where WearHouse='{0}' {1} order by [SKU] desc", Applicants[i].ToString(), sql);
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
    }
}
