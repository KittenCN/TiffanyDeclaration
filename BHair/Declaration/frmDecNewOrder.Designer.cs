namespace BHair.Business
{
    partial class frmDecNewOrder
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
            this.tcDecNewOrder = new System.Windows.Forms.TabControl();
            this.tabStep1 = new System.Windows.Forms.TabPage();
            this.tbShop_Receiver = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbPCs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCart_INV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbINV_Amount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbINV_NO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbImport_Agent = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbcust_gl_agent = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbARRport = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtExCusClearTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOrderNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabStep2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabStep4 = new System.Windows.Forms.TabPage();
            this.tabStep5 = new System.Windows.Forms.TabPage();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tcDecNewOrder.SuspendLayout();
            this.tabStep1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcDecNewOrder
            // 
            this.tcDecNewOrder.Controls.Add(this.tabStep1);
            this.tcDecNewOrder.Controls.Add(this.tabStep2);
            this.tcDecNewOrder.Controls.Add(this.tabPage3);
            this.tcDecNewOrder.Controls.Add(this.tabStep4);
            this.tcDecNewOrder.Controls.Add(this.tabStep5);
            this.tcDecNewOrder.Location = new System.Drawing.Point(12, 12);
            this.tcDecNewOrder.Name = "tcDecNewOrder";
            this.tcDecNewOrder.SelectedIndex = 0;
            this.tcDecNewOrder.Size = new System.Drawing.Size(652, 373);
            this.tcDecNewOrder.TabIndex = 0;
            // 
            // tabStep1
            // 
            this.tabStep1.Controls.Add(this.tbShop_Receiver);
            this.tabStep1.Controls.Add(this.label10);
            this.tabStep1.Controls.Add(this.cbPCs);
            this.tabStep1.Controls.Add(this.label9);
            this.tabStep1.Controls.Add(this.tbCart_INV);
            this.tabStep1.Controls.Add(this.label8);
            this.tabStep1.Controls.Add(this.tbINV_Amount);
            this.tabStep1.Controls.Add(this.label7);
            this.tabStep1.Controls.Add(this.tbINV_NO);
            this.tabStep1.Controls.Add(this.label6);
            this.tabStep1.Controls.Add(this.cbImport_Agent);
            this.tabStep1.Controls.Add(this.label5);
            this.tabStep1.Controls.Add(this.cbcust_gl_agent);
            this.tabStep1.Controls.Add(this.label4);
            this.tabStep1.Controls.Add(this.cbARRport);
            this.tabStep1.Controls.Add(this.label3);
            this.tabStep1.Controls.Add(this.dtExCusClearTime);
            this.tabStep1.Controls.Add(this.label2);
            this.tabStep1.Controls.Add(this.tbOrderNO);
            this.tabStep1.Controls.Add(this.label1);
            this.tabStep1.Location = new System.Drawing.Point(4, 22);
            this.tabStep1.Name = "tabStep1";
            this.tabStep1.Padding = new System.Windows.Forms.Padding(3);
            this.tabStep1.Size = new System.Drawing.Size(644, 347);
            this.tabStep1.TabIndex = 0;
            this.tabStep1.Text = "Step 1";
            this.tabStep1.UseVisualStyleBackColor = true;
            // 
            // tbShop_Receiver
            // 
            this.tbShop_Receiver.Location = new System.Drawing.Point(399, 118);
            this.tbShop_Receiver.Name = "tbShop_Receiver";
            this.tbShop_Receiver.Size = new System.Drawing.Size(200, 21);
            this.tbShop_Receiver.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(310, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "店铺两字代码:";
            // 
            // cbPCs
            // 
            this.cbPCs.Location = new System.Drawing.Point(85, 118);
            this.cbPCs.Name = "cbPCs";
            this.cbPCs.Size = new System.Drawing.Size(201, 21);
            this.cbPCs.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "件数:";
            // 
            // tbCart_INV
            // 
            this.tbCart_INV.Location = new System.Drawing.Point(399, 90);
            this.tbCart_INV.Name = "tbCart_INV";
            this.tbCart_INV.Size = new System.Drawing.Size(200, 21);
            this.tbCart_INV.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "箱数:";
            // 
            // tbINV_Amount
            // 
            this.tbINV_Amount.Location = new System.Drawing.Point(85, 90);
            this.tbINV_Amount.Name = "tbINV_Amount";
            this.tbINV_Amount.Size = new System.Drawing.Size(201, 21);
            this.tbINV_Amount.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "发票金额:";
            // 
            // tbINV_NO
            // 
            this.tbINV_NO.Location = new System.Drawing.Point(399, 63);
            this.tbINV_NO.Name = "tbINV_NO";
            this.tbINV_NO.Size = new System.Drawing.Size(200, 21);
            this.tbINV_NO.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "发票号:";
            // 
            // cbImport_Agent
            // 
            this.cbImport_Agent.FormattingEnabled = true;
            this.cbImport_Agent.Location = new System.Drawing.Point(85, 63);
            this.cbImport_Agent.Name = "cbImport_Agent";
            this.cbImport_Agent.Size = new System.Drawing.Size(201, 20);
            this.cbImport_Agent.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "进口代理:";
            // 
            // cbcust_gl_agent
            // 
            this.cbcust_gl_agent.FormattingEnabled = true;
            this.cbcust_gl_agent.Location = new System.Drawing.Point(399, 36);
            this.cbcust_gl_agent.Name = "cbcust_gl_agent";
            this.cbcust_gl_agent.Size = new System.Drawing.Size(200, 20);
            this.cbcust_gl_agent.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "报关代理:";
            // 
            // cbARRport
            // 
            this.cbARRport.FormattingEnabled = true;
            this.cbARRport.Location = new System.Drawing.Point(85, 36);
            this.cbARRport.Name = "cbARRport";
            this.cbARRport.Size = new System.Drawing.Size(201, 20);
            this.cbARRport.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "到达港口:";
            // 
            // dtExCusClearTime
            // 
            this.dtExCusClearTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtExCusClearTime.Location = new System.Drawing.Point(399, 6);
            this.dtExCusClearTime.Name = "dtExCusClearTime";
            this.dtExCusClearTime.Size = new System.Drawing.Size(200, 21);
            this.dtExCusClearTime.TabIndex = 3;
            this.dtExCusClearTime.Value = new System.DateTime(2017, 2, 27, 15, 22, 7, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "预计清关时间:";
            // 
            // tbOrderNO
            // 
            this.tbOrderNO.Location = new System.Drawing.Point(85, 9);
            this.tbOrderNO.Name = "tbOrderNO";
            this.tbOrderNO.Size = new System.Drawing.Size(201, 21);
            this.tbOrderNO.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "单号:";
            // 
            // tabStep2
            // 
            this.tabStep2.Location = new System.Drawing.Point(4, 22);
            this.tabStep2.Name = "tabStep2";
            this.tabStep2.Padding = new System.Windows.Forms.Padding(3);
            this.tabStep2.Size = new System.Drawing.Size(644, 347);
            this.tabStep2.TabIndex = 1;
            this.tabStep2.Text = "Step 2";
            this.tabStep2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(644, 347);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Step 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabStep4
            // 
            this.tabStep4.Location = new System.Drawing.Point(4, 22);
            this.tabStep4.Name = "tabStep4";
            this.tabStep4.Size = new System.Drawing.Size(644, 347);
            this.tabStep4.TabIndex = 3;
            this.tabStep4.Text = "Step 4";
            this.tabStep4.UseVisualStyleBackColor = true;
            // 
            // tabStep5
            // 
            this.tabStep5.Location = new System.Drawing.Point(4, 22);
            this.tabStep5.Name = "tabStep5";
            this.tabStep5.Size = new System.Drawing.Size(644, 347);
            this.tabStep5.TabIndex = 4;
            this.tabStep5.Text = "Step 5";
            this.tabStep5.UseVisualStyleBackColor = true;
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Location = new System.Drawing.Point(470, 418);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(75, 23);
            this.btnSaveOrder.TabIndex = 1;
            this.btnSaveOrder.Text = "保存";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(569, 418);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmDecNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(676, 472);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.tcDecNewOrder);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDecNewOrder";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDecNewOrder";
            this.tcDecNewOrder.ResumeLayout(false);
            this.tabStep1.ResumeLayout(false);
            this.tabStep1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcDecNewOrder;
        private System.Windows.Forms.TabPage tabStep1;
        private System.Windows.Forms.DateTimePicker dtExCusClearTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOrderNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabStep2;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbShop_Receiver;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cbPCs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCart_INV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbINV_Amount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbINV_NO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbImport_Agent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbcust_gl_agent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbARRport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabStep4;
        private System.Windows.Forms.TabPage tabStep5;
    }
}