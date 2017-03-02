namespace BHair.Business
{
    partial class frmDecOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHSSetting = new System.Windows.Forms.Button();
            this.btnUnSearch = new System.Windows.Forms.Button();
            this.btnCreateNewOrder = new System.Windows.Forms.Button();
            this.dgvDecMain = new System.Windows.Forms.DataGridView();
            this.OrderNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExCusClearTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAWB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARRport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARRdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cust_gl_agent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cust_fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Import_Agent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INV_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INV_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Feright = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cart_INV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgentFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DutyInJD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VATinJD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTinJD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shop_Receiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContainerNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JD_Receiveing_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHSSetting);
            this.panel1.Controls.Add(this.btnUnSearch);
            this.panel1.Controls.Add(this.btnCreateNewOrder);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 33);
            this.panel1.TabIndex = 0;
            // 
            // btnHSSetting
            // 
            this.btnHSSetting.Location = new System.Drawing.Point(203, 3);
            this.btnHSSetting.Name = "btnHSSetting";
            this.btnHSSetting.Size = new System.Drawing.Size(94, 23);
            this.btnHSSetting.TabIndex = 2;
            this.btnHSSetting.Text = "配置HSCODE";
            this.btnHSSetting.UseVisualStyleBackColor = true;
            this.btnHSSetting.Click += new System.EventHandler(this.btnHSSetting_Click);
            // 
            // btnUnSearch
            // 
            this.btnUnSearch.Location = new System.Drawing.Point(3, 3);
            this.btnUnSearch.Name = "btnUnSearch";
            this.btnUnSearch.Size = new System.Drawing.Size(94, 23);
            this.btnUnSearch.TabIndex = 1;
            this.btnUnSearch.Text = "重置搜索条件";
            this.btnUnSearch.UseVisualStyleBackColor = true;
            this.btnUnSearch.Click += new System.EventHandler(this.btnUnSearch_Click);
            // 
            // btnCreateNewOrder
            // 
            this.btnCreateNewOrder.Location = new System.Drawing.Point(103, 3);
            this.btnCreateNewOrder.Name = "btnCreateNewOrder";
            this.btnCreateNewOrder.Size = new System.Drawing.Size(94, 23);
            this.btnCreateNewOrder.TabIndex = 0;
            this.btnCreateNewOrder.Text = "新建入关流程";
            this.btnCreateNewOrder.UseVisualStyleBackColor = true;
            this.btnCreateNewOrder.Click += new System.EventHandler(this.btnCreateNewOrder_Click);
            // 
            // dgvDecMain
            // 
            this.dgvDecMain.AllowUserToAddRows = false;
            this.dgvDecMain.AllowUserToDeleteRows = false;
            this.dgvDecMain.AllowUserToResizeRows = false;
            this.dgvDecMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDecMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDecMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNO,
            this.Status,
            this.ExCusClearTime,
            this.MAWB,
            this.ARRport,
            this.ARRdate,
            this.cust_gl_agent,
            this.cust_fee,
            this.Import_Agent,
            this.ContractNO,
            this.INV_NO,
            this.INV_Amount,
            this.Feright,
            this.Cart_INV,
            this.PCs,
            this.Duty,
            this.VAT,
            this.CT,
            this.AgentFee,
            this.DutyInJD,
            this.VATinJD,
            this.CTinJD,
            this.Shop_Receiver,
            this.ContainerNO,
            this.JD_Receiveing_Date});
            this.dgvDecMain.Location = new System.Drawing.Point(12, 51);
            this.dgvDecMain.MultiSelect = false;
            this.dgvDecMain.Name = "dgvDecMain";
            this.dgvDecMain.ReadOnly = true;
            this.dgvDecMain.RowTemplate.Height = 23;
            this.dgvDecMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDecMain.Size = new System.Drawing.Size(960, 497);
            this.dgvDecMain.TabIndex = 1;
            this.dgvDecMain.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDecMain_CellDoubleClick);
            // 
            // OrderNO
            // 
            this.OrderNO.DataPropertyName = "OrderNO";
            this.OrderNO.HeaderText = "OrderNO";
            this.OrderNO.Name = "OrderNO";
            this.OrderNO.ReadOnly = true;
            this.OrderNO.Visible = false;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // ExCusClearTime
            // 
            this.ExCusClearTime.DataPropertyName = "ExCusClearTime";
            this.ExCusClearTime.FillWeight = 12.63736F;
            this.ExCusClearTime.HeaderText = "预计清关时间";
            this.ExCusClearTime.Name = "ExCusClearTime";
            this.ExCusClearTime.ReadOnly = true;
            // 
            // MAWB
            // 
            this.MAWB.DataPropertyName = "MAWB";
            this.MAWB.FillWeight = 20.98F;
            this.MAWB.HeaderText = "运单号";
            this.MAWB.Name = "MAWB";
            this.MAWB.ReadOnly = true;
            // 
            // ARRport
            // 
            this.ARRport.DataPropertyName = "ARRport";
            this.ARRport.FillWeight = 29.06257F;
            this.ARRport.HeaderText = "到达港口";
            this.ARRport.Name = "ARRport";
            this.ARRport.ReadOnly = true;
            // 
            // ARRdate
            // 
            this.ARRdate.DataPropertyName = "ARRdate";
            this.ARRdate.FillWeight = 37.31632F;
            this.ARRdate.HeaderText = "到达时间";
            this.ARRdate.Name = "ARRdate";
            this.ARRdate.ReadOnly = true;
            // 
            // cust_gl_agent
            // 
            this.cust_gl_agent.DataPropertyName = "cust_gl_agent";
            this.cust_gl_agent.FillWeight = 45.31037F;
            this.cust_gl_agent.HeaderText = "报关代理";
            this.cust_gl_agent.Name = "cust_gl_agent";
            this.cust_gl_agent.ReadOnly = true;
            // 
            // cust_fee
            // 
            this.cust_fee.DataPropertyName = "cust_fee";
            this.cust_fee.FillWeight = 53.47607F;
            this.cust_fee.HeaderText = "报关费";
            this.cust_fee.Name = "cust_fee";
            this.cust_fee.ReadOnly = true;
            // 
            // Import_Agent
            // 
            this.Import_Agent.DataPropertyName = "Import_Agent";
            this.Import_Agent.FillWeight = 61.3825F;
            this.Import_Agent.HeaderText = "进口代理";
            this.Import_Agent.Name = "Import_Agent";
            this.Import_Agent.ReadOnly = true;
            // 
            // ContractNO
            // 
            this.ContractNO.DataPropertyName = "ContractNO";
            this.ContractNO.FillWeight = 69.46102F;
            this.ContractNO.HeaderText = "合同号";
            this.ContractNO.Name = "ContractNO";
            this.ContractNO.ReadOnly = true;
            // 
            // INV_NO
            // 
            this.INV_NO.DataPropertyName = "INV_NO";
            this.INV_NO.FillWeight = 77.49096F;
            this.INV_NO.HeaderText = "发票号";
            this.INV_NO.Name = "INV_NO";
            this.INV_NO.ReadOnly = true;
            this.INV_NO.Visible = false;
            // 
            // INV_Amount
            // 
            this.INV_Amount.DataPropertyName = "INV_Amount";
            this.INV_Amount.FillWeight = 85.26257F;
            this.INV_Amount.HeaderText = "发票金额";
            this.INV_Amount.Name = "INV_Amount";
            this.INV_Amount.ReadOnly = true;
            this.INV_Amount.Visible = false;
            // 
            // Feright
            // 
            this.Feright.DataPropertyName = "Feright";
            this.Feright.FillWeight = 93.20705F;
            this.Feright.HeaderText = "运费";
            this.Feright.Name = "Feright";
            this.Feright.ReadOnly = true;
            this.Feright.Visible = false;
            // 
            // Cart_INV
            // 
            this.Cart_INV.DataPropertyName = "Cart_INV";
            this.Cart_INV.FillWeight = 100.8936F;
            this.Cart_INV.HeaderText = "箱数";
            this.Cart_INV.Name = "Cart_INV";
            this.Cart_INV.ReadOnly = true;
            this.Cart_INV.Visible = false;
            // 
            // PCs
            // 
            this.PCs.DataPropertyName = "PCs";
            this.PCs.FillWeight = 108.7535F;
            this.PCs.HeaderText = "件数";
            this.PCs.Name = "PCs";
            this.PCs.ReadOnly = true;
            this.PCs.Visible = false;
            // 
            // Duty
            // 
            this.Duty.DataPropertyName = "Duty";
            this.Duty.FillWeight = 116.3558F;
            this.Duty.HeaderText = "关税";
            this.Duty.Name = "Duty";
            this.Duty.ReadOnly = true;
            this.Duty.Visible = false;
            // 
            // VAT
            // 
            this.VAT.DataPropertyName = "VAT";
            this.VAT.FillWeight = 124.1319F;
            this.VAT.HeaderText = "增值税";
            this.VAT.Name = "VAT";
            this.VAT.ReadOnly = true;
            this.VAT.Visible = false;
            // 
            // CT
            // 
            this.CT.DataPropertyName = "CT";
            this.CT.FillWeight = 131.6508F;
            this.CT.HeaderText = "消费税";
            this.CT.Name = "CT";
            this.CT.ReadOnly = true;
            // 
            // AgentFee
            // 
            this.AgentFee.DataPropertyName = "AgentFee";
            this.AgentFee.FillWeight = 139.3439F;
            this.AgentFee.HeaderText = "代理费";
            this.AgentFee.Name = "AgentFee";
            this.AgentFee.ReadOnly = true;
            // 
            // DutyInJD
            // 
            this.DutyInJD.DataPropertyName = "DutyInJD";
            this.DutyInJD.FillWeight = 146.9906F;
            this.DutyInJD.HeaderText = "系统关税";
            this.DutyInJD.Name = "DutyInJD";
            this.DutyInJD.ReadOnly = true;
            // 
            // VATinJD
            // 
            this.VATinJD.DataPropertyName = "VATinJD";
            this.VATinJD.FillWeight = 154.3809F;
            this.VATinJD.HeaderText = "系统增值税";
            this.VATinJD.Name = "VATinJD";
            this.VATinJD.ReadOnly = true;
            // 
            // CTinJD
            // 
            this.CTinJD.DataPropertyName = "CTinJD";
            this.CTinJD.FillWeight = 161.9463F;
            this.CTinJD.HeaderText = "系统消费税";
            this.CTinJD.Name = "CTinJD";
            this.CTinJD.ReadOnly = true;
            // 
            // Shop_Receiver
            // 
            this.Shop_Receiver.DataPropertyName = "Shop_Receiver";
            this.Shop_Receiver.FillWeight = 169.2556F;
            this.Shop_Receiver.HeaderText = "店铺两字代码";
            this.Shop_Receiver.Name = "Shop_Receiver";
            this.Shop_Receiver.ReadOnly = true;
            this.Shop_Receiver.Visible = false;
            // 
            // ContainerNO
            // 
            this.ContainerNO.DataPropertyName = "ContainerNO";
            this.ContainerNO.FillWeight = 176.7405F;
            this.ContainerNO.HeaderText = "入系统的号码";
            this.ContainerNO.Name = "ContainerNO";
            this.ContainerNO.ReadOnly = true;
            // 
            // JD_Receiveing_Date
            // 
            this.JD_Receiveing_Date.DataPropertyName = "JD_Receiveing_Date";
            this.JD_Receiveing_Date.FillWeight = 183.9697F;
            this.JD_Receiveing_Date.HeaderText = "入系统的时间";
            this.JD_Receiveing_Date.Name = "JD_Receiveing_Date";
            this.JD_Receiveing_Date.ReadOnly = true;
            // 
            // frmDecOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 572);
            this.Controls.Add(this.dgvDecMain);
            this.Controls.Add(this.panel1);
            this.Name = "frmDecOrder";
            this.TabText = "入关流程管理";
            this.Text = "入关流程管理";
            this.Load += new System.EventHandler(this.frmStoreApp_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDecMain;
        private System.Windows.Forms.Button btnCreateNewOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExCusClearTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAWB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARRport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARRdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cust_gl_agent;
        private System.Windows.Forms.DataGridViewTextBoxColumn cust_fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Import_Agent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn INV_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn INV_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Feright;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cart_INV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duty;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CT;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgentFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn DutyInJD;
        private System.Windows.Forms.DataGridViewTextBoxColumn VATinJD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTinJD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shop_Receiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContainerNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn JD_Receiveing_Date;
        private System.Windows.Forms.Button btnUnSearch;
        private System.Windows.Forms.Button btnHSSetting;
    }
}