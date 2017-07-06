namespace BHair.Business
{
    partial class frmReceptInfo
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
            this.dgvReceiptInfo = new System.Windows.Forms.DataGridView();
            this.Shop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clerk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReceiptInfo
            // 
            this.dgvReceiptInfo.AllowUserToAddRows = false;
            this.dgvReceiptInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceiptInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiptInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Shop,
            this.Clerk,
            this.Contact,
            this.Level,
            this.Address});
            this.dgvReceiptInfo.Location = new System.Drawing.Point(13, 13);
            this.dgvReceiptInfo.Name = "dgvReceiptInfo";
            this.dgvReceiptInfo.RowTemplate.Height = 30;
            this.dgvReceiptInfo.Size = new System.Drawing.Size(1068, 613);
            this.dgvReceiptInfo.TabIndex = 0;
            // 
            // Shop
            // 
            this.Shop.DataPropertyName = "Shop";
            this.Shop.HeaderText = "店铺两字代码";
            this.Shop.Name = "Shop";
            // 
            // Clerk
            // 
            this.Clerk.DataPropertyName = "Clerk";
            this.Clerk.HeaderText = "店员";
            this.Clerk.Name = "Clerk";
            // 
            // Contact
            // 
            this.Contact.DataPropertyName = "Contact";
            this.Contact.HeaderText = "联系方式";
            this.Contact.Name = "Contact";
            // 
            // Level
            // 
            this.Level.DataPropertyName = "Level";
            this.Level.HeaderText = "级别";
            this.Level.Items.AddRange(new object[] {
            "主管",
            "店员"});
            this.Level.Name = "Level";
            this.Level.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Level.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "地址";
            this.Address.Name = "Address";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(811, 632);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(86, 45);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(903, 632);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 45);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(995, 632);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 45);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmReceptInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 684);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.dgvReceiptInfo);
            this.Name = "frmReceptInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReceptInfo";
            this.Load += new System.EventHandler(this.frmReceptInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReceiptInfo;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clerk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewComboBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}