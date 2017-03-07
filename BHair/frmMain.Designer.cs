namespace BHair
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dPanelMain = new WinFormsUI.Docking.DockPanel();
            this.ssrMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssrMain_Timer = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbDscOrder = new System.Windows.Forms.ToolStripButton();
            this.tt = new System.Windows.Forms.ToolStripSeparator();
            this.tsbWMSMain = new System.Windows.Forms.ToolStripButton();
            this.tsbInbound = new System.Windows.Forms.ToolStripButton();
            this.tsbOutbound = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.tsbWMConfig = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.ssrMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dPanelMain
            // 
            this.dPanelMain.ActiveAutoHideContent = null;
            this.dPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dPanelMain.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dPanelMain.Location = new System.Drawing.Point(0, 73);
            this.dPanelMain.Name = "dPanelMain";
            this.dPanelMain.Size = new System.Drawing.Size(668, 402);
            this.dPanelMain.TabIndex = 0;
            // 
            // ssrMain
            // 
            this.ssrMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ssrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssrMain_Timer});
            this.ssrMain.Location = new System.Drawing.Point(0, 449);
            this.ssrMain.Name = "ssrMain";
            this.ssrMain.Size = new System.Drawing.Size(668, 26);
            this.ssrMain.SizingGrip = false;
            this.ssrMain.TabIndex = 4;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(545, 21);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "入关流程系统";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tssrMain_Timer
            // 
            this.tssrMain_Timer.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tssrMain_Timer.Name = "tssrMain_Timer";
            this.tssrMain_Timer.Size = new System.Drawing.Size(108, 21);
            this.tssrMain_Timer.Text = "[tssrMain_Timer]";
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDscOrder,
            this.tt,
            this.tsbWMSMain,
            this.tsbInbound,
            this.tsbOutbound,
            this.toolStripSeparator2,
            this.toolStripButton8,
            this.tsbWMConfig,
            this.toolStripButton2,
            this.toolStripButton9});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(668, 73);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbDscOrder
            // 
            this.tsbDscOrder.Image = ((System.Drawing.Image)(resources.GetObject("tsbDscOrder.Image")));
            this.tsbDscOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDscOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDscOrder.Name = "tsbDscOrder";
            this.tsbDscOrder.Size = new System.Drawing.Size(60, 70);
            this.tsbDscOrder.Text = "入关流程";
            this.tsbDscOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDscOrder.Visible = false;
            this.tsbDscOrder.Click += new System.EventHandler(this.tsbDscOrder_Click);
            // 
            // tt
            // 
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(6, 73);
            // 
            // tsbWMSMain
            // 
            this.tsbWMSMain.Image = ((System.Drawing.Image)(resources.GetObject("tsbWMSMain.Image")));
            this.tsbWMSMain.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbWMSMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWMSMain.Name = "tsbWMSMain";
            this.tsbWMSMain.Size = new System.Drawing.Size(60, 70);
            this.tsbWMSMain.Text = "库存管理";
            this.tsbWMSMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbWMSMain.Visible = false;
            this.tsbWMSMain.Click += new System.EventHandler(this.tsbWMSMain_Click);
            // 
            // tsbInbound
            // 
            this.tsbInbound.Image = ((System.Drawing.Image)(resources.GetObject("tsbInbound.Image")));
            this.tsbInbound.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbInbound.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInbound.Name = "tsbInbound";
            this.tsbInbound.Size = new System.Drawing.Size(60, 70);
            this.tsbInbound.Text = "入库流程";
            this.tsbInbound.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbInbound.Visible = false;
            this.tsbInbound.Click += new System.EventHandler(this.tsbInbound_Click);
            // 
            // tsbOutbound
            // 
            this.tsbOutbound.Image = ((System.Drawing.Image)(resources.GetObject("tsbOutbound.Image")));
            this.tsbOutbound.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbOutbound.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOutbound.Name = "tsbOutbound";
            this.tsbOutbound.Size = new System.Drawing.Size(60, 70);
            this.tsbOutbound.Text = "出库流程";
            this.tsbOutbound.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbOutbound.Visible = false;
            this.tsbOutbound.Click += new System.EventHandler(this.tsbOutbound_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 73);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(60, 70);
            this.toolStripButton8.Text = "商品管理";
            this.toolStripButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton8.Visible = false;
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // tsbWMConfig
            // 
            this.tsbWMConfig.Image = ((System.Drawing.Image)(resources.GetObject("tsbWMConfig.Image")));
            this.tsbWMConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbWMConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWMConfig.Name = "tsbWMConfig";
            this.tsbWMConfig.Size = new System.Drawing.Size(60, 70);
            this.tsbWMConfig.Text = "系统设置";
            this.tsbWMConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbWMConfig.Visible = false;
            this.tsbWMConfig.Click += new System.EventHandler(this.tsbWMConfig_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(60, 70);
            this.toolStripButton2.Text = "会员管理";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Visible = false;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(52, 70);
            this.toolStripButton9.Text = "退出";
            this.toolStripButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 475);
            this.Controls.Add(this.ssrMain);
            this.Controls.Add(this.dPanelMain);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1285, 733);
            this.MinimumSize = new System.Drawing.Size(539, 413);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "转货管理系统";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.ssrMain.ResumeLayout(false);
            this.ssrMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinFormsUI.Docking.DockPanel dPanelMain;
        private System.Windows.Forms.StatusStrip ssrMain;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssrMain_Timer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator tt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton tsbDscOrder;
        private System.Windows.Forms.ToolStripButton tsbInbound;
        private System.Windows.Forms.ToolStripButton tsbWMConfig;
        private System.Windows.Forms.ToolStripButton tsbWMSMain;
        private System.Windows.Forms.ToolStripButton tsbOutbound;
    }
}