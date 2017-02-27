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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.btnCreateNewOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreateNewOrder);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 111);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 129);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(960, 420);
            this.dataGridView1.TabIndex = 1;
            // 
            // ExCusClearTime
            // 
            this.ExCusClearTime.DataPropertyName = "ExCusClearTime";
            this.ExCusClearTime.FillWeight = 12.63736F;
            this.ExCusClearTime.HeaderText = "预计清关时间";
            this.ExCusClearTime.Name = "ExCusClearTime";
            // 
            // MAWB
            // 
            this.MAWB.FillWeight = 20.98F;
            this.MAWB.HeaderText = "运单号";
            this.MAWB.Name = "MAWB";
            // 
            // ARRport
            // 
            this.ARRport.FillWeight = 29.06257F;
            this.ARRport.HeaderText = "到达港口";
            this.ARRport.Name = "ARRport";
            // 
            // ARRdate
            // 
            this.ARRdate.FillWeight = 37.31632F;
            this.ARRdate.HeaderText = "到达时间";
            this.ARRdate.Name = "ARRdate";
            // 
            // cust_gl_agent
            // 
            this.cust_gl_agent.FillWeight = 45.31037F;
            this.cust_gl_agent.HeaderText = "报关代理";
            this.cust_gl_agent.Name = "cust_gl_agent";
            // 
            // cust_fee
            // 
            this.cust_fee.FillWeight = 53.47607F;
            this.cust_fee.HeaderText = "报关费";
            this.cust_fee.Name = "cust_fee";
            // 
            // Import_Agent
            // 
            this.Import_Agent.FillWeight = 61.3825F;
            this.Import_Agent.HeaderText = "进口代理";
            this.Import_Agent.Name = "Import_Agent";
            // 
            // ContractNO
            // 
            this.ContractNO.FillWeight = 69.46102F;
            this.ContractNO.HeaderText = "合同号";
            this.ContractNO.Name = "ContractNO";
            // 
            // INV_NO
            // 
            this.INV_NO.FillWeight = 77.49096F;
            this.INV_NO.HeaderText = "发票号";
            this.INV_NO.Name = "INV_NO";
            // 
            // INV_Amount
            // 
            this.INV_Amount.FillWeight = 85.26257F;
            this.INV_Amount.HeaderText = "发票金额";
            this.INV_Amount.Name = "INV_Amount";
            // 
            // Feright
            // 
            this.Feright.FillWeight = 93.20705F;
            this.Feright.HeaderText = "运费";
            this.Feright.Name = "Feright";
            // 
            // Cart_INV
            // 
            this.Cart_INV.FillWeight = 100.8936F;
            this.Cart_INV.HeaderText = "箱数";
            this.Cart_INV.Name = "Cart_INV";
            // 
            // PCs
            // 
            this.PCs.FillWeight = 108.7535F;
            this.PCs.HeaderText = "件数";
            this.PCs.Name = "PCs";
            // 
            // Duty
            // 
            this.Duty.FillWeight = 116.3558F;
            this.Duty.HeaderText = "关税";
            this.Duty.Name = "Duty";
            // 
            // VAT
            // 
            this.VAT.FillWeight = 124.1319F;
            this.VAT.HeaderText = "增值税";
            this.VAT.Name = "VAT";
            // 
            // CT
            // 
            this.CT.FillWeight = 131.6508F;
            this.CT.HeaderText = "消费税";
            this.CT.Name = "CT";
            // 
            // AgentFee
            // 
            this.AgentFee.FillWeight = 139.3439F;
            this.AgentFee.HeaderText = "代理费";
            this.AgentFee.Name = "AgentFee";
            // 
            // DutyInJD
            // 
            this.DutyInJD.FillWeight = 146.9906F;
            this.DutyInJD.HeaderText = "系统关税";
            this.DutyInJD.Name = "DutyInJD";
            // 
            // VATinJD
            // 
            this.VATinJD.FillWeight = 154.3809F;
            this.VATinJD.HeaderText = "系统增值税";
            this.VATinJD.Name = "VATinJD";
            // 
            // CTinJD
            // 
            this.CTinJD.FillWeight = 161.9463F;
            this.CTinJD.HeaderText = "系统消费税";
            this.CTinJD.Name = "CTinJD";
            // 
            // Shop_Receiver
            // 
            this.Shop_Receiver.FillWeight = 169.2556F;
            this.Shop_Receiver.HeaderText = "店铺两字代码";
            this.Shop_Receiver.Name = "Shop_Receiver";
            // 
            // ContainerNO
            // 
            this.ContainerNO.FillWeight = 176.7405F;
            this.ContainerNO.HeaderText = "入系统的号码";
            this.ContainerNO.Name = "ContainerNO";
            // 
            // JD_Receiveing_Date
            // 
            this.JD_Receiveing_Date.FillWeight = 183.9697F;
            this.JD_Receiveing_Date.HeaderText = "入系统的时间";
            this.JD_Receiveing_Date.Name = "JD_Receiveing_Date";
            // 
            // btnCreateNewOrder
            // 
            this.btnCreateNewOrder.Location = new System.Drawing.Point(3, 3);
            this.btnCreateNewOrder.Name = "btnCreateNewOrder";
            this.btnCreateNewOrder.Size = new System.Drawing.Size(94, 23);
            this.btnCreateNewOrder.TabIndex = 0;
            this.btnCreateNewOrder.Text = "新建入关流程";
            this.btnCreateNewOrder.UseVisualStyleBackColor = true;
            this.btnCreateNewOrder.Click += new System.EventHandler(this.btnCreateNewOrder_Click);
            // 
            // frmDecOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frmDecOrder";
            this.TabText = "入关流程管理";
            this.Text = "入关流程管理";
            this.Load += new System.EventHandler(this.frmStoreApp_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button btnCreateNewOrder;
    }
}