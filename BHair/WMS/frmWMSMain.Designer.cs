namespace BHair.Business
{
    partial class frmWMSMain
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
            this.dgvWMSMain = new System.Windows.Forms.DataGridView();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WearHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbWearHouse = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWMSMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWMSMain
            // 
            this.dgvWMSMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWMSMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWMSMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWMSMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SKU,
            this.Amount,
            this.WearHouse});
            this.dgvWMSMain.Location = new System.Drawing.Point(13, 61);
            this.dgvWMSMain.MultiSelect = false;
            this.dgvWMSMain.Name = "dgvWMSMain";
            this.dgvWMSMain.RowTemplate.Height = 23;
            this.dgvWMSMain.Size = new System.Drawing.Size(521, 310);
            this.dgvWMSMain.TabIndex = 0;
            // 
            // SKU
            // 
            this.SKU.DataPropertyName = "SKU";
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "件数";
            this.Amount.Name = "Amount";
            // 
            // WearHouse
            // 
            this.WearHouse.DataPropertyName = "WearHouse";
            this.WearHouse.HeaderText = "仓库";
            this.WearHouse.Name = "WearHouse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择仓库:";
            // 
            // cbWearHouse
            // 
            this.cbWearHouse.FormattingEnabled = true;
            this.cbWearHouse.Location = new System.Drawing.Point(78, 10);
            this.cbWearHouse.Name = "cbWearHouse";
            this.cbWearHouse.Size = new System.Drawing.Size(73, 20);
            this.cbWearHouse.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(157, 8);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(238, 8);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(75, 23);
            this.btnInit.TabIndex = 4;
            this.btnInit.Text = "重置";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // frmWMSMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 383);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbWearHouse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvWMSMain);
            this.Name = "frmWMSMain";
            this.TabText = "frmWMSMain";
            this.Text = "frmWMSMain";
            this.Load += new System.EventHandler(this.frmWMSMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWMSMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWMSMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn WearHouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbWearHouse;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnInit;
    }
}