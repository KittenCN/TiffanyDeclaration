namespace BHair.Business
{
    partial class frmWMSInbound
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
            this.btnCreateIn = new System.Windows.Forms.Button();
            this.dgvWMSInList = new System.Windows.Forms.DataGridView();
            this.OrderNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InboundNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shipper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocNOs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrossWGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WearHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAWB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReflush = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWMSInList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReflush);
            this.panel1.Controls.Add(this.btnCreateIn);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 48);
            this.panel1.TabIndex = 0;
            // 
            // btnCreateIn
            // 
            this.btnCreateIn.Location = new System.Drawing.Point(6, 6);
            this.btnCreateIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateIn.Name = "btnCreateIn";
            this.btnCreateIn.Size = new System.Drawing.Size(112, 34);
            this.btnCreateIn.TabIndex = 0;
            this.btnCreateIn.Text = "创建入库单";
            this.btnCreateIn.UseVisualStyleBackColor = true;
            this.btnCreateIn.Click += new System.EventHandler(this.btnCreateIn_Click);
            // 
            // dgvWMSInList
            // 
            this.dgvWMSInList.AllowUserToAddRows = false;
            this.dgvWMSInList.AllowUserToDeleteRows = false;
            this.dgvWMSInList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWMSInList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWMSInList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWMSInList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNO,
            this.Status,
            this.InDate,
            this.InboundNO,
            this.Shipper,
            this.User,
            this.DocNO,
            this.DocNOs,
            this.PCs,
            this.GrossWGT,
            this.WearHouse,
            this.MAWB});
            this.dgvWMSInList.Location = new System.Drawing.Point(20, 76);
            this.dgvWMSInList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvWMSInList.MultiSelect = false;
            this.dgvWMSInList.Name = "dgvWMSInList";
            this.dgvWMSInList.ReadOnly = true;
            this.dgvWMSInList.RowTemplate.Height = 23;
            this.dgvWMSInList.Size = new System.Drawing.Size(1059, 633);
            this.dgvWMSInList.TabIndex = 1;
            this.dgvWMSInList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWMSInList_CellDoubleClick);
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
            // InDate
            // 
            this.InDate.DataPropertyName = "InDate";
            this.InDate.HeaderText = "入库日期";
            this.InDate.Name = "InDate";
            this.InDate.ReadOnly = true;
            // 
            // InboundNO
            // 
            this.InboundNO.DataPropertyName = "InboundNO";
            this.InboundNO.HeaderText = "入库单号";
            this.InboundNO.Name = "InboundNO";
            this.InboundNO.ReadOnly = true;
            // 
            // Shipper
            // 
            this.Shipper.DataPropertyName = "Shipper";
            this.Shipper.HeaderText = "发货人";
            this.Shipper.Name = "Shipper";
            this.Shipper.ReadOnly = true;
            // 
            // User
            // 
            this.User.DataPropertyName = "User";
            this.User.HeaderText = "使用人";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            // 
            // DocNO
            // 
            this.DocNO.DataPropertyName = "DocNO";
            this.DocNO.HeaderText = "总单号";
            this.DocNO.Name = "DocNO";
            this.DocNO.ReadOnly = true;
            // 
            // DocNOs
            // 
            this.DocNOs.DataPropertyName = "DocNOs";
            this.DocNOs.HeaderText = "分单号";
            this.DocNOs.Name = "DocNOs";
            this.DocNOs.ReadOnly = true;
            // 
            // PCs
            // 
            this.PCs.DataPropertyName = "PCs";
            this.PCs.HeaderText = "件数";
            this.PCs.Name = "PCs";
            this.PCs.ReadOnly = true;
            // 
            // GrossWGT
            // 
            this.GrossWGT.DataPropertyName = "GrossWGT";
            this.GrossWGT.HeaderText = "毛重";
            this.GrossWGT.Name = "GrossWGT";
            this.GrossWGT.ReadOnly = true;
            // 
            // WearHouse
            // 
            this.WearHouse.DataPropertyName = "WearHouse";
            this.WearHouse.HeaderText = "收货仓库";
            this.WearHouse.Name = "WearHouse";
            this.WearHouse.ReadOnly = true;
            // 
            // MAWB
            // 
            this.MAWB.DataPropertyName = "MAWB";
            this.MAWB.HeaderText = "MAWB";
            this.MAWB.Name = "MAWB";
            this.MAWB.ReadOnly = true;
            this.MAWB.Visible = false;
            // 
            // btnReflush
            // 
            this.btnReflush.Location = new System.Drawing.Point(126, 6);
            this.btnReflush.Margin = new System.Windows.Forms.Padding(4);
            this.btnReflush.Name = "btnReflush";
            this.btnReflush.Size = new System.Drawing.Size(112, 34);
            this.btnReflush.TabIndex = 1;
            this.btnReflush.Text = "刷新入库单";
            this.btnReflush.UseVisualStyleBackColor = true;
            this.btnReflush.Click += new System.EventHandler(this.btnReflush_Click);
            // 
            // frmWMSInbound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 728);
            this.Controls.Add(this.dgvWMSInList);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmWMSInbound";
            this.TabText = "frmWMSInbound";
            this.Text = "frmWMSInbound";
            this.Load += new System.EventHandler(this.frmWMSInbound_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWMSInList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvWMSInList;
        private System.Windows.Forms.Button btnCreateIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn InDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InboundNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shipper;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocNOs;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCs;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrossWGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn WearHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAWB;
        private System.Windows.Forms.Button btnReflush;
    }
}