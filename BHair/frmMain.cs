using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsUI.Docking;
using BHair.Base;
using BHair.Business;
using BHair.SystemSet;
using BHair.Business.Table;

namespace BHair
{

    public partial class frmMain : Form
    {
        ApplicationInfo applicationInfo = new ApplicationInfo();
        public frmMain()
        {
            InitializeComponent();
            this.Text = "入关流程系统 " + " V " + Application.ProductVersion + " 最后编译时间 " + System.IO.File.GetLastWriteTime(this.GetType().Assembly.Location);

            this.tssrMain_Timer.Text = DateTime.Now.ToString();
            this.dPanelMain_AutoSize();

            Login login = new Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                this.InitMenu();
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        }
        private void frmMain_Resize(object sender, EventArgs e)
        {
            this.dPanelMain_AutoSize();
        }
        private void dPanelMain_AutoSize()
        {
            this.dPanelMain.Width = this.ClientSize.Width;
            this.dPanelMain.Height = this.ClientSize.Height - 45;
        }
        #region 检查选项卡是否存在...

        /// <summary>检查选项卡是否存在。</summary>
        /// <param name="text">选项卡名称</param>
        /// <returns></returns>
        private IDockContent FindTab(string text)
        {
            if (this.dPanelMain.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                {
                    if (form.Text == text)
                    {
                        return form as IDockContent;
                    }
                }
            }
            else
            {
                foreach (IDockContent content in this.dPanelMain.Documents)
                {
                    if (content.DockHandler.TabText == text)
                    {
                        return content;
                    }
                }
            }
            return null;
        }

        #endregion
        #region 打开选项卡窗体..

        /// <summary>打开窗体</summary>
        /// <param name="form">窗体实例</param>
        private void ShowWindows_Click(DockContent form)
        {
            string strText = form.Text;
            if (this.FindTab(strText) == null)
            {
                form.Show(this.dPanelMain);
            }
            else
            {
                this.FindTab(strText).DockHandler.Show();
            }
        }

        #endregion
        private void tmrMain_Tick(object sender, EventArgs e)
        {
            this.tssrMain_Timer.Text = DateTime.Now.ToString();
        }
        #region 日常操作...
        private void menuMain_System_Member_Click(object sender, EventArgs e)
        {
            frmMember_List objfrmMemberList = new frmMember_List();
            this.ShowWindows_Click(objfrmMemberList);
        }
        #endregion
        #region 转货流程

        /// <summary>
        /// 申请转货
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuMain_Flow_add_Click(object sender, EventArgs e)
        {
            frmAddApplication objfrmAddApp = new frmAddApplication();
            objfrmAddApp.Show();
        }

        /// <summary>
        /// 店面申请单状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuMain_Manage_StoreApp_Click(object sender, EventArgs e)
        {
            frmStoreApp objfrmStoreApp = new frmStoreApp();
            this.ShowWindows_Click(objfrmStoreApp);
        }

        /// <summary>
        /// 财务部审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuMain_Manage_Approval2App_Click(object sender, EventArgs e)
        {
            frmAppAproval2 objfrmAppAproval2 = new frmAppAproval2();
            this.ShowWindows_Click(objfrmAppAproval2);
        }

        /// <summary>
        /// 商品部审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuMain_Manage_ApprovalApp_Click(object sender, EventArgs e)
        {
            frmAppAproval objfrmAppAproval = new frmAppAproval();
            this.ShowWindows_Click(objfrmAppAproval);
        }

        private void 物流确认ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAppDone objfrmAppDone = new frmAppDone();
            this.ShowWindows_Click(objfrmAppDone);
        }

        #endregion
        #region 查询

        /// <summary>
        /// 历史查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuMain_Manage_History_Click(object sender, EventArgs e)
        {
            frmHistoryInfo objfrmHisApp = new frmHistoryInfo();
            this.ShowWindows_Click(objfrmHisApp);
        }

        /// <summary>
        /// 转货报表查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmApplicationReport objfrmApplicationReport = new frmApplicationReport();
            this.ShowWindows_Click(objfrmApplicationReport);
        }

        #endregion
        #region 统计报表...



        /// <summary>员工工资统计</summary>
        private void menuMain_Table_Salary_Click(object sender, EventArgs e)
        {
            //frmSalary objfrmSalary = new frmSalary();
            //this.ShowWindows_Click(objfrmSalary);
        }



        #endregion
        #region 系统维护...

        /// <summary>商品信息管理</summary>
        private void menuMain_System_Item_Click(object sender, EventArgs e)
        {
            frmItem_List objfrmItemsList = new frmItem_List();
            this.ShowWindows_Click(objfrmItemsList);
        }

        /// <summary>
        /// 店面管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuMain_Manage_Store_Click(object sender, EventArgs e)
        {
            frmStore_List objfrmStoreList = new frmStore_List();
            this.ShowWindows_Click(objfrmStoreList);
        }




        /// <summary>系统设置</summary>
        private void menuMain_System_Config_Click(object sender, EventArgs e)
        {
            Login objfrmLogin = new Login();
            CloseAllTab();
            if (objfrmLogin.ShowDialog() == DialogResult.OK)
            {
                this.InitMenu();
            }
        }

        private void menuMain_System_Log_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 修改个人信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuMain_System_Pwd_Click(object sender, EventArgs e)
        {
            frmMember objfrmMember = new frmMember(Login.LoginUser.UID);
            objfrmMember.Show();
        }

        /// <summary>退出</summary>
        private void menuMain_System_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
        #region Regist Button

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            menuMain_System_Member_Click(null, null);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            menuMain_Manage_History_Click(null, null);
        }

        /// <summary>
        /// 申请转货
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            menuMain_Flow_add_Click(null, null);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            menuMain_Table_Salary_Click(null, null);
        }



        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            menuMain_System_Item_Click(null, null);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            menuMain_System_Config_Click(null, null);
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            menuMain_Manage_StoreApp_Click(null, null);
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            物流确认ToolStripMenuItem_Click(null, null);
        }
        #endregion
        bool IsLogin()
        {
            if (Login.LoginUser.UID != null && Login.LoginUser.UID != "")
            {

                return true;
            }
            else
            {
                MessageBox.Show("请先登录", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        #region
        /// <summary>
        /// 权限按钮
        /// </summary>
        void InitMenu()
        {
            if (Login.LoginUser.UID == null || Login.LoginUser.UID == "")
            {
                //toolStripButton3.Visible = false;
                toolStripButton8.Visible = false;
                toolStripButton2.Visible = false;
            }
            else if (Login.LoginUser.Character == 1)    //入关
            {
                tsbDscOrder.Visible = true;
                if (Login.LoginUser.IsAdmin == 1)
                {
                    toolStripButton2.Visible = true;
                }
                else
                {
                    toolStripButton2.Visible = false;
                }
                toolStripButton8.Visible = true;
                //tsbDscOrder_Click(null, null);
                //menuMain_Manage_ApprovalApp_Click(null, null);//入关窗口
            }
            else if (Login.LoginUser.Character == 2)
            {
                tsbInbound.Visible = true;
                tsbWMSMain.Visible = true;
                tsbOutbound.Visible = true;
                //toolStripButton3.Visible = false;
                toolStripButton8.Visible = false;
                toolStripButton2.Visible = false;
                //menuMain_Manage_Approval2App_Click(null, null);//仓管窗口
            }
            if (Login.LoginUser.UID == "Administrator")
            {
                tsbInbound.Visible = true;
                tsbDscOrder.Visible = true;
                toolStripButton2.Visible = true;
                //toolStripButton3.Visible = true;
                toolStripButton8.Visible = true;
                tsbWMConfig.Visible = true;
                tsbWMSMain.Visible = true;
                tsbOutbound.Visible = true;
            }
        }
        #endregion
        void CloseAllTab()
        {
            IDockContent[] documents = this.dPanelMain.DocumentsToArray();
            foreach (IDockContent content in documents)
            {
                content.DockHandler.Close();
            }
        }
        private void tsbDscOrder_Click(object sender, EventArgs e)
        {
            frmDecOrder fdo = new frmDecOrder();
            this.ShowWindows_Click(fdo);
        }

        private void tsbInbound_Click(object sender, EventArgs e)
        {
            frmWMSInbound fwmsi = new Business.frmWMSInbound();
            this.ShowWindows_Click(fwmsi);
        }

        private void tsbWMConfig_Click(object sender, EventArgs e)
        {
            frmStore_List fsl = new frmStore_List();
            this.ShowWindows_Click(fsl);
        }

        private void tsbWMSMain_Click(object sender, EventArgs e)
        {
            frmWMSMain fwmsm = new frmWMSMain();
            this.ShowWindows_Click(fwmsm);
        }

        private void tsbOutbound_Click(object sender, EventArgs e)
        {
            frmWMSOutbound fwms = new Business.frmWMSOutbound();
            this.ShowWindows_Click(fwms);
        }
    }
}
