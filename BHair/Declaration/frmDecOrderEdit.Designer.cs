namespace BHair.Business
{
    partial class frmDecOrderEdit
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
            this.tbAgentFee = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.dtpJD_Receiving_Date = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.tbContainerNo = new System.Windows.Forms.TextBox();
            this.tbCTinJD = new System.Windows.Forms.TextBox();
            this.tbVATinJD = new System.Windows.Forms.TextBox();
            this.tbDutyInJD = new System.Windows.Forms.TextBox();
            this.tbCust_Fee = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbCT = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbVAT = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbDuty = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbFreight = new System.Windows.Forms.TextBox();
            this.tbContract_NO = new System.Windows.Forms.TextBox();
            this.tbMAWB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpARRDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.btnCalINV = new System.Windows.Forms.Button();
            this.btnAddINV = new System.Windows.Forms.Button();
            this.dgvINV = new System.Windows.Forms.DataGridView();
            this.OrderNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INV_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INV_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cart_INV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shop_Receiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Freight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbShop_Receiver = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPCs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCart_INV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbINV_Amount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbINV_NO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnInputD_V = new System.Windows.Forms.Button();
            this.btnCalHS = new System.Windows.Forms.Button();
            this.btnInputHS = new System.Windows.Forms.Button();
            this.btnAddHS = new System.Windows.Forms.Button();
            this.dgvHS = new System.Windows.Forms.DataGridView();
            this.OrderNO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HS_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duty_System = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duty_Input = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAT_System = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAT_Input = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbM = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tbHS_Code = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tcDecNewOrder.SuspendLayout();
            this.tabStep1.SuspendLayout();
            this.tabStep2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvINV)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHS)).BeginInit();
            this.SuspendLayout();
            // 
            // tcDecNewOrder
            // 
            this.tcDecNewOrder.Controls.Add(this.tabStep1);
            this.tcDecNewOrder.Controls.Add(this.tabStep2);
            this.tcDecNewOrder.Controls.Add(this.tabPage3);
            this.tcDecNewOrder.Location = new System.Drawing.Point(12, 12);
            this.tcDecNewOrder.Name = "tcDecNewOrder";
            this.tcDecNewOrder.SelectedIndex = 0;
            this.tcDecNewOrder.Size = new System.Drawing.Size(652, 551);
            this.tcDecNewOrder.TabIndex = 0;
            // 
            // tabStep1
            // 
            this.tabStep1.Controls.Add(this.tbAgentFee);
            this.tabStep1.Controls.Add(this.label24);
            this.tabStep1.Controls.Add(this.dtpJD_Receiving_Date);
            this.tabStep1.Controls.Add(this.label23);
            this.tabStep1.Controls.Add(this.tbContainerNo);
            this.tabStep1.Controls.Add(this.tbCTinJD);
            this.tabStep1.Controls.Add(this.tbVATinJD);
            this.tabStep1.Controls.Add(this.tbDutyInJD);
            this.tabStep1.Controls.Add(this.tbCust_Fee);
            this.tabStep1.Controls.Add(this.label22);
            this.tabStep1.Controls.Add(this.label21);
            this.tabStep1.Controls.Add(this.label20);
            this.tabStep1.Controls.Add(this.label19);
            this.tabStep1.Controls.Add(this.label18);
            this.tabStep1.Controls.Add(this.tbCT);
            this.tabStep1.Controls.Add(this.label17);
            this.tabStep1.Controls.Add(this.tbVAT);
            this.tabStep1.Controls.Add(this.label16);
            this.tabStep1.Controls.Add(this.tbDuty);
            this.tabStep1.Controls.Add(this.label15);
            this.tabStep1.Controls.Add(this.tbFreight);
            this.tabStep1.Controls.Add(this.tbContract_NO);
            this.tabStep1.Controls.Add(this.tbMAWB);
            this.tabStep1.Controls.Add(this.label14);
            this.tabStep1.Controls.Add(this.label13);
            this.tabStep1.Controls.Add(this.dtpARRDate);
            this.tabStep1.Controls.Add(this.label12);
            this.tabStep1.Controls.Add(this.label11);
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
            this.tabStep1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabStep1.Size = new System.Drawing.Size(644, 525);
            this.tabStep1.TabIndex = 0;
            this.tabStep1.Text = "基础信息";
            this.tabStep1.UseVisualStyleBackColor = true;
            // 
            // tbAgentFee
            // 
            this.tbAgentFee.Location = new System.Drawing.Point(86, 350);
            this.tbAgentFee.Name = "tbAgentFee";
            this.tbAgentFee.Size = new System.Drawing.Size(201, 21);
            this.tbAgentFee.TabIndex = 47;
            // 
            // label24
            // 
            this.label24.AllowDrop = true;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(5, 352);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 12);
            this.label24.TabIndex = 46;
            this.label24.Text = "代理费:";
            // 
            // dtpJD_Receiving_Date
            // 
            this.dtpJD_Receiving_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJD_Receiving_Date.Location = new System.Drawing.Point(399, 300);
            this.dtpJD_Receiving_Date.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpJD_Receiving_Date.Name = "dtpJD_Receiving_Date";
            this.dtpJD_Receiving_Date.Size = new System.Drawing.Size(201, 21);
            this.dtpJD_Receiving_Date.TabIndex = 45;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(310, 305);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 12);
            this.label23.TabIndex = 44;
            this.label23.Text = "入系统的时间:";
            // 
            // tbContainerNo
            // 
            this.tbContainerNo.Location = new System.Drawing.Point(86, 305);
            this.tbContainerNo.Name = "tbContainerNo";
            this.tbContainerNo.Size = new System.Drawing.Size(201, 21);
            this.tbContainerNo.TabIndex = 43;
            // 
            // tbCTinJD
            // 
            this.tbCTinJD.Location = new System.Drawing.Point(399, 271);
            this.tbCTinJD.Name = "tbCTinJD";
            this.tbCTinJD.Size = new System.Drawing.Size(201, 21);
            this.tbCTinJD.TabIndex = 41;
            // 
            // tbVATinJD
            // 
            this.tbVATinJD.Location = new System.Drawing.Point(86, 273);
            this.tbVATinJD.Name = "tbVATinJD";
            this.tbVATinJD.Size = new System.Drawing.Size(201, 21);
            this.tbVATinJD.TabIndex = 39;
            // 
            // tbDutyInJD
            // 
            this.tbDutyInJD.Location = new System.Drawing.Point(399, 241);
            this.tbDutyInJD.Name = "tbDutyInJD";
            this.tbDutyInJD.Size = new System.Drawing.Size(201, 21);
            this.tbDutyInJD.TabIndex = 37;
            // 
            // tbCust_Fee
            // 
            this.tbCust_Fee.Location = new System.Drawing.Point(86, 243);
            this.tbCust_Fee.Name = "tbCust_Fee";
            this.tbCust_Fee.Size = new System.Drawing.Size(201, 21);
            this.tbCust_Fee.TabIndex = 35;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(5, 307);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 12);
            this.label22.TabIndex = 42;
            this.label22.Text = "入系统的号码:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(310, 273);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 12);
            this.label21.TabIndex = 40;
            this.label21.Text = "系统消费税:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 275);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 12);
            this.label20.TabIndex = 38;
            this.label20.Text = "系统增值税:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(310, 243);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 12);
            this.label19.TabIndex = 36;
            this.label19.Text = "系统关税:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 245);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 12);
            this.label18.TabIndex = 34;
            this.label18.Text = "报关费:";
            // 
            // tbCT
            // 
            this.tbCT.Location = new System.Drawing.Point(85, 198);
            this.tbCT.Name = "tbCT";
            this.tbCT.Size = new System.Drawing.Size(201, 21);
            this.tbCT.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 200);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 12);
            this.label17.TabIndex = 32;
            this.label17.Text = "消费税:";
            // 
            // tbVAT
            // 
            this.tbVAT.Location = new System.Drawing.Point(399, 174);
            this.tbVAT.Name = "tbVAT";
            this.tbVAT.Size = new System.Drawing.Size(201, 21);
            this.tbVAT.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(310, 176);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 30;
            this.label16.Text = "增值税:";
            // 
            // tbDuty
            // 
            this.tbDuty.Location = new System.Drawing.Point(85, 174);
            this.tbDuty.Name = "tbDuty";
            this.tbDuty.Size = new System.Drawing.Size(201, 21);
            this.tbDuty.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 176);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 12);
            this.label15.TabIndex = 28;
            this.label15.Text = "关税:";
            // 
            // tbFreight
            // 
            this.tbFreight.Location = new System.Drawing.Point(399, 128);
            this.tbFreight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFreight.Name = "tbFreight";
            this.tbFreight.Size = new System.Drawing.Size(200, 21);
            this.tbFreight.TabIndex = 27;
            // 
            // tbContract_NO
            // 
            this.tbContract_NO.Location = new System.Drawing.Point(84, 129);
            this.tbContract_NO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbContract_NO.Name = "tbContract_NO";
            this.tbContract_NO.Size = new System.Drawing.Size(201, 21);
            this.tbContract_NO.TabIndex = 25;
            // 
            // tbMAWB
            // 
            this.tbMAWB.Location = new System.Drawing.Point(84, 101);
            this.tbMAWB.Name = "tbMAWB";
            this.tbMAWB.Size = new System.Drawing.Size(201, 21);
            this.tbMAWB.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(310, 130);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 12);
            this.label14.TabIndex = 26;
            this.label14.Text = "运费:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 131);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "合同号:";
            // 
            // dtpARRDate
            // 
            this.dtpARRDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpARRDate.Location = new System.Drawing.Point(399, 99);
            this.dtpARRDate.Name = "dtpARRDate";
            this.dtpARRDate.Size = new System.Drawing.Size(200, 21);
            this.dtpARRDate.TabIndex = 23;
            this.dtpARRDate.Value = new System.DateTime(2017, 2, 27, 15, 22, 7, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(310, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 22;
            this.label12.Text = "到达时间:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "运单号:";
            // 
            // cbImport_Agent
            // 
            this.cbImport_Agent.FormattingEnabled = true;
            this.cbImport_Agent.Items.AddRange(new object[] {
            "代理1",
            "代理2",
            "代理3"});
            this.cbImport_Agent.Location = new System.Drawing.Point(84, 62);
            this.cbImport_Agent.Name = "cbImport_Agent";
            this.cbImport_Agent.Size = new System.Drawing.Size(201, 20);
            this.cbImport_Agent.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "进口代理:";
            // 
            // cbcust_gl_agent
            // 
            this.cbcust_gl_agent.FormattingEnabled = true;
            this.cbcust_gl_agent.Items.AddRange(new object[] {
            "代理1",
            "代理2",
            "代理3"});
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
            this.cbARRport.Items.AddRange(new object[] {
            "上海",
            "北京"});
            this.cbARRport.Location = new System.Drawing.Point(84, 35);
            this.cbARRport.Name = "cbARRport";
            this.cbARRport.Size = new System.Drawing.Size(201, 20);
            this.cbARRport.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 38);
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
            this.tbOrderNO.Location = new System.Drawing.Point(84, 9);
            this.tbOrderNO.Name = "tbOrderNO";
            this.tbOrderNO.Size = new System.Drawing.Size(201, 21);
            this.tbOrderNO.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "单号:";
            // 
            // tabStep2
            // 
            this.tabStep2.Controls.Add(this.btnCalINV);
            this.tabStep2.Controls.Add(this.btnAddINV);
            this.tabStep2.Controls.Add(this.dgvINV);
            this.tabStep2.Controls.Add(this.tbShop_Receiver);
            this.tabStep2.Controls.Add(this.label10);
            this.tabStep2.Controls.Add(this.tbPCs);
            this.tabStep2.Controls.Add(this.label9);
            this.tabStep2.Controls.Add(this.tbCart_INV);
            this.tabStep2.Controls.Add(this.label8);
            this.tabStep2.Controls.Add(this.tbINV_Amount);
            this.tabStep2.Controls.Add(this.label7);
            this.tabStep2.Controls.Add(this.tbINV_NO);
            this.tabStep2.Controls.Add(this.label6);
            this.tabStep2.Location = new System.Drawing.Point(4, 22);
            this.tabStep2.Name = "tabStep2";
            this.tabStep2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabStep2.Size = new System.Drawing.Size(644, 525);
            this.tabStep2.TabIndex = 1;
            this.tabStep2.Text = "发票信息";
            this.tabStep2.UseVisualStyleBackColor = true;
            // 
            // btnCalINV
            // 
            this.btnCalINV.Location = new System.Drawing.Point(427, 56);
            this.btnCalINV.Name = "btnCalINV";
            this.btnCalINV.Size = new System.Drawing.Size(88, 23);
            this.btnCalINV.TabIndex = 32;
            this.btnCalINV.Text = "运费分摊计算";
            this.btnCalINV.UseVisualStyleBackColor = true;
            this.btnCalINV.Click += new System.EventHandler(this.btnCalINV_Click);
            // 
            // btnAddINV
            // 
            this.btnAddINV.Location = new System.Drawing.Point(529, 56);
            this.btnAddINV.Name = "btnAddINV";
            this.btnAddINV.Size = new System.Drawing.Size(75, 23);
            this.btnAddINV.TabIndex = 31;
            this.btnAddINV.Text = "添加发票";
            this.btnAddINV.UseVisualStyleBackColor = true;
            this.btnAddINV.Click += new System.EventHandler(this.btnAddINV_Click);
            // 
            // dgvINV
            // 
            this.dgvINV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvINV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvINV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNO,
            this.Status,
            this.INV_NO,
            this.INV_Amount,
            this.Cart_INV,
            this.PCs,
            this.Shop_Receiver,
            this.Freight,
            this.Duty,
            this.VAT});
            this.dgvINV.Location = new System.Drawing.Point(5, 118);
            this.dgvINV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvINV.Name = "dgvINV";
            this.dgvINV.RowTemplate.Height = 30;
            this.dgvINV.Size = new System.Drawing.Size(637, 407);
            this.dgvINV.TabIndex = 30;
            // 
            // OrderNO
            // 
            this.OrderNO.DataPropertyName = "OrderNO";
            this.OrderNO.HeaderText = "OrderNO";
            this.OrderNO.Name = "OrderNO";
            this.OrderNO.Visible = false;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Visible = false;
            // 
            // INV_NO
            // 
            this.INV_NO.DataPropertyName = "INV_NO";
            this.INV_NO.HeaderText = "INV_NO";
            this.INV_NO.Name = "INV_NO";
            // 
            // INV_Amount
            // 
            this.INV_Amount.DataPropertyName = "INV_Amount";
            this.INV_Amount.HeaderText = "INV_Amount";
            this.INV_Amount.Name = "INV_Amount";
            // 
            // Cart_INV
            // 
            this.Cart_INV.DataPropertyName = "Cart_INV";
            this.Cart_INV.HeaderText = "Cart_INV";
            this.Cart_INV.Name = "Cart_INV";
            // 
            // PCs
            // 
            this.PCs.DataPropertyName = "PCs";
            this.PCs.HeaderText = "PCs";
            this.PCs.Name = "PCs";
            // 
            // Shop_Receiver
            // 
            this.Shop_Receiver.DataPropertyName = "Shop_Receiver";
            this.Shop_Receiver.HeaderText = "Shop_Receiver";
            this.Shop_Receiver.Name = "Shop_Receiver";
            // 
            // Freight
            // 
            this.Freight.DataPropertyName = "Freight";
            this.Freight.HeaderText = "Freight";
            this.Freight.Name = "Freight";
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
            // tbShop_Receiver
            // 
            this.tbShop_Receiver.Location = new System.Drawing.Point(405, 4);
            this.tbShop_Receiver.Name = "tbShop_Receiver";
            this.tbShop_Receiver.Size = new System.Drawing.Size(200, 21);
            this.tbShop_Receiver.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(317, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 12);
            this.label10.TabIndex = 28;
            this.label10.Text = "店铺两字代码:";
            // 
            // tbPCs
            // 
            this.tbPCs.Location = new System.Drawing.Point(91, 58);
            this.tbPCs.Name = "tbPCs";
            this.tbPCs.Size = new System.Drawing.Size(201, 21);
            this.tbPCs.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "件数:";
            // 
            // tbCart_INV
            // 
            this.tbCart_INV.Location = new System.Drawing.Point(405, 31);
            this.tbCart_INV.Name = "tbCart_INV";
            this.tbCart_INV.Size = new System.Drawing.Size(200, 21);
            this.tbCart_INV.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "箱数:";
            // 
            // tbINV_Amount
            // 
            this.tbINV_Amount.Location = new System.Drawing.Point(91, 30);
            this.tbINV_Amount.Name = "tbINV_Amount";
            this.tbINV_Amount.Size = new System.Drawing.Size(201, 21);
            this.tbINV_Amount.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "发票金额:";
            // 
            // tbINV_NO
            // 
            this.tbINV_NO.Location = new System.Drawing.Point(92, 5);
            this.tbINV_NO.Name = "tbINV_NO";
            this.tbINV_NO.Size = new System.Drawing.Size(200, 21);
            this.tbINV_NO.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "发票号:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnInputD_V);
            this.tabPage3.Controls.Add(this.btnCalHS);
            this.tabPage3.Controls.Add(this.btnInputHS);
            this.tabPage3.Controls.Add(this.btnAddHS);
            this.tabPage3.Controls.Add(this.dgvHS);
            this.tabPage3.Controls.Add(this.tbM);
            this.tabPage3.Controls.Add(this.label27);
            this.tabPage3.Controls.Add(this.tbHS_Code);
            this.tabPage3.Controls.Add(this.label26);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(644, 525);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "税分摊";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnInputD_V
            // 
            this.btnInputD_V.Location = new System.Drawing.Point(541, 13);
            this.btnInputD_V.Name = "btnInputD_V";
            this.btnInputD_V.Size = new System.Drawing.Size(99, 25);
            this.btnInputD_V.TabIndex = 40;
            this.btnInputD_V.Text = "上传税信息";
            this.btnInputD_V.UseVisualStyleBackColor = true;
            // 
            // btnCalHS
            // 
            this.btnCalHS.Location = new System.Drawing.Point(427, 45);
            this.btnCalHS.Name = "btnCalHS";
            this.btnCalHS.Size = new System.Drawing.Size(99, 25);
            this.btnCalHS.TabIndex = 39;
            this.btnCalHS.Text = "计算分摊信息";
            this.btnCalHS.UseVisualStyleBackColor = true;
            this.btnCalHS.Click += new System.EventHandler(this.btnCalHS_Click);
            // 
            // btnInputHS
            // 
            this.btnInputHS.Location = new System.Drawing.Point(427, 13);
            this.btnInputHS.Name = "btnInputHS";
            this.btnInputHS.Size = new System.Drawing.Size(99, 25);
            this.btnInputHS.TabIndex = 38;
            this.btnInputHS.Text = "上传分摊信息";
            this.btnInputHS.UseVisualStyleBackColor = true;
            this.btnInputHS.Click += new System.EventHandler(this.btnInputHS_Click);
            // 
            // btnAddHS
            // 
            this.btnAddHS.Location = new System.Drawing.Point(541, 45);
            this.btnAddHS.Name = "btnAddHS";
            this.btnAddHS.Size = new System.Drawing.Size(99, 25);
            this.btnAddHS.TabIndex = 37;
            this.btnAddHS.Text = "添加分摊信息";
            this.btnAddHS.UseVisualStyleBackColor = true;
            this.btnAddHS.Click += new System.EventHandler(this.btnAddHS_Click);
            // 
            // dgvHS
            // 
            this.dgvHS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNO2,
            this.Status2,
            this.HS_CODE,
            this.M,
            this.Duty_System,
            this.Duty_Input,
            this.VAT_System,
            this.VAT_Input});
            this.dgvHS.Location = new System.Drawing.Point(-3, 87);
            this.dgvHS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvHS.Name = "dgvHS";
            this.dgvHS.RowTemplate.Height = 30;
            this.dgvHS.Size = new System.Drawing.Size(642, 432);
            this.dgvHS.TabIndex = 36;
            // 
            // OrderNO2
            // 
            this.OrderNO2.DataPropertyName = "OrderNO";
            this.OrderNO2.HeaderText = "OrderNO";
            this.OrderNO2.Name = "OrderNO2";
            this.OrderNO2.Visible = false;
            // 
            // Status2
            // 
            this.Status2.DataPropertyName = "Status";
            this.Status2.HeaderText = "Status";
            this.Status2.Name = "Status2";
            this.Status2.Visible = false;
            // 
            // HS_CODE
            // 
            this.HS_CODE.DataPropertyName = "HS_CODE";
            this.HS_CODE.HeaderText = "HS_CODE";
            this.HS_CODE.Name = "HS_CODE";
            // 
            // M
            // 
            this.M.DataPropertyName = "M";
            this.M.HeaderText = "M";
            this.M.Name = "M";
            // 
            // Duty_System
            // 
            this.Duty_System.DataPropertyName = "Duty_System";
            this.Duty_System.HeaderText = "Duty_System";
            this.Duty_System.Name = "Duty_System";
            // 
            // Duty_Input
            // 
            this.Duty_Input.DataPropertyName = "Duty_Input";
            this.Duty_Input.HeaderText = "Duty_Input";
            this.Duty_Input.Name = "Duty_Input";
            // 
            // VAT_System
            // 
            this.VAT_System.DataPropertyName = "VAT_System";
            this.VAT_System.HeaderText = "VAT_System";
            this.VAT_System.Name = "VAT_System";
            // 
            // VAT_Input
            // 
            this.VAT_Input.DataPropertyName = "VAT_Input";
            this.VAT_Input.HeaderText = "VAT_Input";
            this.VAT_Input.Name = "VAT_Input";
            // 
            // tbM
            // 
            this.tbM.Location = new System.Drawing.Point(89, 50);
            this.tbM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(200, 21);
            this.tbM.TabIndex = 35;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 52);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(35, 12);
            this.label27.TabIndex = 34;
            this.label27.Text = "总价:";
            // 
            // tbHS_Code
            // 
            this.tbHS_Code.Location = new System.Drawing.Point(89, 17);
            this.tbHS_Code.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbHS_Code.Name = "tbHS_Code";
            this.tbHS_Code.Size = new System.Drawing.Size(200, 21);
            this.tbHS_Code.TabIndex = 33;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(1, 19);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 12);
            this.label26.TabIndex = 32;
            this.label26.Text = "HS CODE:";
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Location = new System.Drawing.Point(487, 575);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(75, 23);
            this.btnSaveOrder.TabIndex = 1;
            this.btnSaveOrder.Text = "保存";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(587, 575);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmDecOrderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(676, 614);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.tcDecNewOrder);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDecOrderEdit";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDecOrderEdit";
            this.Load += new System.EventHandler(this.frmDecNewOrder_Load);
            this.tcDecNewOrder.ResumeLayout(false);
            this.tabStep1.ResumeLayout(false);
            this.tabStep1.PerformLayout();
            this.tabStep2.ResumeLayout(false);
            this.tabStep2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvINV)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHS)).EndInit();
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
        private System.Windows.Forms.ComboBox cbImport_Agent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbcust_gl_agent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbARRport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbAgentFee;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dtpJD_Receiving_Date;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbContainerNo;
        private System.Windows.Forms.TextBox tbCTinJD;
        private System.Windows.Forms.TextBox tbVATinJD;
        private System.Windows.Forms.TextBox tbDutyInJD;
        private System.Windows.Forms.TextBox tbCust_Fee;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbCT;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbVAT;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbDuty;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbFreight;
        private System.Windows.Forms.TextBox tbContract_NO;
        private System.Windows.Forms.TextBox tbMAWB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpARRDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddINV;
        private System.Windows.Forms.DataGridView dgvINV;
        private System.Windows.Forms.TextBox tbShop_Receiver;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPCs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCart_INV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbINV_Amount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbINV_NO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalINV;
        private System.Windows.Forms.Button btnCalHS;
        private System.Windows.Forms.Button btnInputHS;
        private System.Windows.Forms.Button btnAddHS;
        private System.Windows.Forms.DataGridView dgvHS;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tbHS_Code;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnInputD_V;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNO2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status2;
        private System.Windows.Forms.DataGridViewTextBoxColumn HS_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn M;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duty_System;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duty_Input;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAT_System;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAT_Input;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn INV_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn INV_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cart_INV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shop_Receiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Freight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duty;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAT;
    }
}