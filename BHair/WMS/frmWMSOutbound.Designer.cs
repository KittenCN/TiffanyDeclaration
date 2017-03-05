namespace BHair.Business
{
    partial class frmWMSOutbound
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
            this.dgvWMSOutList = new System.Windows.Forms.DataGridView();
            this.OrderNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutboundNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WearHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shipper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prepared = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WHSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWMSOutList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreateIn);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 32);
            this.panel1.TabIndex = 0;
            // 
            // btnCreateIn
            // 
            this.btnCreateIn.Location = new System.Drawing.Point(4, 4);
            this.btnCreateIn.Name = "btnCreateIn";
            this.btnCreateIn.Size = new System.Drawing.Size(75, 23);
            this.btnCreateIn.TabIndex = 0;
            this.btnCreateIn.Text = "创建出库单";
            this.btnCreateIn.UseVisualStyleBackColor = true;
            this.btnCreateIn.Click += new System.EventHandler(this.btnCreateIn_Click);
            // 
            // dgvWMSOutList
            // 
            this.dgvWMSOutList.AllowUserToAddRows = false;
            this.dgvWMSOutList.AllowUserToDeleteRows = false;
            this.dgvWMSOutList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWMSOutList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWMSOutList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWMSOutList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNO,
            this.Status,
            this.OutDate,
            this.OutboundNO,
            this.WearHouse,
            this.Shipper,
            this.Contact,
            this.OutType,
            this.ReceiptAdd,
            this.Deadline,
            this.Prepared,
            this.OperSup,
            this.WHSup});
            this.dgvWMSOutList.Location = new System.Drawing.Point(13, 51);
            this.dgvWMSOutList.Name = "dgvWMSOutList";
            this.dgvWMSOutList.ReadOnly = true;
            this.dgvWMSOutList.RowTemplate.Height = 23;
            this.dgvWMSOutList.Size = new System.Drawing.Size(706, 422);
            this.dgvWMSOutList.TabIndex = 1;
            this.dgvWMSOutList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWMSInList_CellDoubleClick);
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
            // OutDate
            // 
            this.OutDate.DataPropertyName = "OutDate";
            this.OutDate.HeaderText = "出库日期";
            this.OutDate.Name = "OutDate";
            this.OutDate.ReadOnly = true;
            // 
            // OutboundNO
            // 
            this.OutboundNO.DataPropertyName = "OutboundNO";
            this.OutboundNO.HeaderText = "出库单编号";
            this.OutboundNO.Name = "OutboundNO";
            this.OutboundNO.ReadOnly = true;
            // 
            // WearHouse
            // 
            this.WearHouse.DataPropertyName = "WearHouse";
            this.WearHouse.HeaderText = "出库仓库";
            this.WearHouse.Name = "WearHouse";
            this.WearHouse.ReadOnly = true;
            // 
            // Shipper
            // 
            this.Shipper.DataPropertyName = "Shipper";
            this.Shipper.HeaderText = "发货人";
            this.Shipper.Name = "Shipper";
            this.Shipper.ReadOnly = true;
            // 
            // Contact
            // 
            this.Contact.DataPropertyName = "Contact";
            this.Contact.HeaderText = "联系方式";
            this.Contact.Name = "Contact";
            this.Contact.ReadOnly = true;
            // 
            // OutType
            // 
            this.OutType.DataPropertyName = "OutType";
            this.OutType.HeaderText = "出货方式";
            this.OutType.Name = "OutType";
            this.OutType.ReadOnly = true;
            // 
            // ReceiptAdd
            // 
            this.ReceiptAdd.DataPropertyName = "ReceiptAdd";
            this.ReceiptAdd.HeaderText = "收货地址";
            this.ReceiptAdd.Name = "ReceiptAdd";
            this.ReceiptAdd.ReadOnly = true;
            // 
            // Deadline
            // 
            this.Deadline.DataPropertyName = "Deadline";
            this.Deadline.HeaderText = "要求到货时间";
            this.Deadline.Name = "Deadline";
            this.Deadline.ReadOnly = true;
            // 
            // Prepared
            // 
            this.Prepared.DataPropertyName = "Prepared";
            this.Prepared.HeaderText = "制单";
            this.Prepared.Name = "Prepared";
            this.Prepared.ReadOnly = true;
            // 
            // OperSup
            // 
            this.OperSup.DataPropertyName = "OperSup";
            this.OperSup.HeaderText = "物流主管";
            this.OperSup.Name = "OperSup";
            this.OperSup.ReadOnly = true;
            // 
            // WHSup
            // 
            this.WHSup.DataPropertyName = "WHSup";
            this.WHSup.HeaderText = "仓库主管";
            this.WHSup.Name = "WHSup";
            this.WHSup.ReadOnly = true;
            // 
            // frmWMSOutbound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 485);
            this.Controls.Add(this.dgvWMSOutList);
            this.Controls.Add(this.panel1);
            this.Name = "frmWMSOutbound";
            this.TabText = "frmWMSOutbound";
            this.Text = "frmWMSOutbound";
            this.Load += new System.EventHandler(this.frmWMSInbound_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWMSOutList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvWMSOutList;
        private System.Windows.Forms.Button btnCreateIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutboundNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn WearHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shipper;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prepared;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn WHSup;
    }
}