using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BHair.Business.Table;
using System.Text.RegularExpressions;

namespace BHair.Business
{
    public partial class frmDecOrder : WinFormsUI.Docking.DockContent
    {
        public frmDecOrder()
        {
            InitializeComponent();
        }
        private void frmStoreApp_Load(object sender, EventArgs e)
        {
            this.TopMost = false;
        }

        private void btnCreateNewOrder_Click(object sender, EventArgs e)
        {
            frmDecNewOrder fdno = new Business.frmDecNewOrder();
            fdno.Show();
        }
    }
}
