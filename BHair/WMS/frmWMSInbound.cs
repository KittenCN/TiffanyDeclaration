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
    public partial class frmWMSInbound : WinFormsUI.Docking.DockContent
    {
        public frmWMSInbound()
        {
            InitializeComponent();
        }

        private void btnCreateIn_Click(object sender, EventArgs e)
        {

        }

        private void frmWMSInbound_Load(object sender, EventArgs e)
        {

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
                    string sqlString = string.Format("select * from ApplicationInfo where IsDelete = 0 and AppState<9 and ( DeliverStore='{0}' or ReceiptStore='{0}') {1} order by [ApplicantsDate] desc", Applicants[i].ToString(), sql);
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
