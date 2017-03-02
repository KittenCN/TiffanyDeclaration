namespace BHair.Business
{
    partial class frmHSSetting
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
            this.dgvHSSetting = new System.Windows.Forms.DataGridView();
            this.HSCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHSSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHSSetting
            // 
            this.dgvHSSetting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHSSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHSSetting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HSCODE,
            this.Duty,
            this.VAT});
            this.dgvHSSetting.Location = new System.Drawing.Point(13, 13);
            this.dgvHSSetting.Name = "dgvHSSetting";
            this.dgvHSSetting.RowTemplate.Height = 30;
            this.dgvHSSetting.Size = new System.Drawing.Size(456, 451);
            this.dgvHSSetting.TabIndex = 0;
            // 
            // HSCODE
            // 
            this.HSCODE.DataPropertyName = "HSCODE";
            this.HSCODE.HeaderText = "HSCODE";
            this.HSCODE.Name = "HSCODE";
            // 
            // Duty
            // 
            this.Duty.DataPropertyName = "Duty";
            this.Duty.HeaderText = "Duty";
            this.Duty.Name = "Duty";
            // 
            // VAT
            // 
            this.VAT.DataPropertyName = "VAT";
            this.VAT.HeaderText = "VAT";
            this.VAT.Name = "VAT";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(273, 488);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 36);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(381, 488);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 36);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmHSSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 548);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvHSSetting);
            this.Name = "frmHSSetting";
            this.TabText = "frmHSSetting";
            this.Text = "frmHSSetting";
            this.Load += new System.EventHandler(this.frmHSSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHSSetting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHSSetting;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duty;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAT;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}