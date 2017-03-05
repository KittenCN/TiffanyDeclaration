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
            // frmWMSMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 383);
            this.Controls.Add(this.dgvWMSMain);
            this.Name = "frmWMSMain";
            this.TabText = "frmWMSMain";
            this.Text = "frmWMSMain";
            this.Load += new System.EventHandler(this.frmWMSMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWMSMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWMSMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn WearHouse;
    }
}