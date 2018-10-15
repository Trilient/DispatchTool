namespace Engine
{
    partial class Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generator));
            this.etaDateTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.etbDateTime = new System.Windows.Forms.DateTimePicker();
            this.chkNoEta = new System.Windows.Forms.CheckBox();
            this.chkNoEtb = new System.Windows.Forms.CheckBox();
            this.portSelector = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEtaTime = new System.Windows.Forms.TextBox();
            this.tbEtbTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.etaSelector = new System.Windows.Forms.ComboBox();
            this.cbBerthingArrival = new System.Windows.Forms.CheckBox();
            this.dailyUpdatePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.dailyUpdateTab = new System.Windows.Forms.TabPage();
            this.btnCopyEta = new System.Windows.Forms.Button();
            this.btnGenerateEta = new System.Windows.Forms.Button();
            this.richTextEta = new System.Windows.Forms.RichTextBox();
            this.btnResetData = new System.Windows.Forms.Button();
            this.etcTab = new System.Windows.Forms.TabPage();
            this.btnCopyEtc = new System.Windows.Forms.Button();
            this.btnGenerateEtc = new System.Windows.Forms.Button();
            this.richTextEtc = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panelSecondGrade = new System.Windows.Forms.Panel();
            this.lblSecondGrade = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbIntendedLoad2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbRateOfLoading2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbTotalLoaded2 = new System.Windows.Forms.TextBox();
            this.panelFirstGrade = new System.Windows.Forms.Panel();
            this.lblFirstGrade = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbIntendedLoad1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbRateOfLoading1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTotalLoaded1 = new System.Windows.Forms.TextBox();
            this.tbTimeString = new System.Windows.Forms.TextBox();
            this.rdMetricTons = new System.Windows.Forms.RadioButton();
            this.rdBarrels = new System.Windows.Forms.RadioButton();
            this.ddProduct2 = new System.Windows.Forms.ComboBox();
            this.ddProduct1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dailyUpdatePanel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.dailyUpdateTab.SuspendLayout();
            this.etcTab.SuspendLayout();
            this.panelSecondGrade.SuspendLayout();
            this.panelFirstGrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // etaDateTime
            // 
            this.etaDateTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.etaDateTime.Location = new System.Drawing.Point(42, 34);
            this.etaDateTime.Name = "etaDateTime";
            this.etaDateTime.Size = new System.Drawing.Size(200, 20);
            this.etaDateTime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ETA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ETB";
            // 
            // etbDateTime
            // 
            this.etbDateTime.Location = new System.Drawing.Point(42, 60);
            this.etbDateTime.Name = "etbDateTime";
            this.etbDateTime.Size = new System.Drawing.Size(200, 20);
            this.etbDateTime.TabIndex = 5;
            // 
            // chkNoEta
            // 
            this.chkNoEta.AutoSize = true;
            this.chkNoEta.Location = new System.Drawing.Point(42, 96);
            this.chkNoEta.Name = "chkNoEta";
            this.chkNoEta.Size = new System.Drawing.Size(64, 17);
            this.chkNoEta.TabIndex = 7;
            this.chkNoEta.Text = "No ETA";
            this.chkNoEta.UseVisualStyleBackColor = true;
            this.chkNoEta.CheckedChanged += new System.EventHandler(this.chkNoEta_CheckedChanged);
            // 
            // chkNoEtb
            // 
            this.chkNoEtb.AutoSize = true;
            this.chkNoEtb.Location = new System.Drawing.Point(112, 96);
            this.chkNoEtb.Name = "chkNoEtb";
            this.chkNoEtb.Size = new System.Drawing.Size(64, 17);
            this.chkNoEtb.TabIndex = 8;
            this.chkNoEtb.Text = "No ETB";
            this.chkNoEtb.UseVisualStyleBackColor = true;
            this.chkNoEtb.CheckedChanged += new System.EventHandler(this.chkNoEtb_CheckedChanged);
            // 
            // portSelector
            // 
            this.portSelector.FormattingEnabled = true;
            this.portSelector.Items.AddRange(new object[] {
            "Galveston",
            "Freeport"});
            this.portSelector.Location = new System.Drawing.Point(42, 119);
            this.portSelector.Name = "portSelector";
            this.portSelector.Size = new System.Drawing.Size(168, 21);
            this.portSelector.TabIndex = 9;
            this.portSelector.Text = "Select port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Time";
            // 
            // tbEtaTime
            // 
            this.tbEtaTime.Location = new System.Drawing.Point(286, 33);
            this.tbEtaTime.MaxLength = 5;
            this.tbEtaTime.Name = "tbEtaTime";
            this.tbEtaTime.Size = new System.Drawing.Size(100, 20);
            this.tbEtaTime.TabIndex = 12;
            this.tbEtaTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEtaTime_KeyPress);
            // 
            // tbEtbTime
            // 
            this.tbEtbTime.Location = new System.Drawing.Point(286, 60);
            this.tbEtbTime.MaxLength = 5;
            this.tbEtbTime.Name = "tbEtbTime";
            this.tbEtbTime.Size = new System.Drawing.Size(100, 20);
            this.tbEtbTime.TabIndex = 14;
            this.tbEtbTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEtbTime_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Time";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(622, 431);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(166, 13);
            this.lblVersion.TabIndex = 17;
            this.lblVersion.Text = "AmSpec LPG Dispatch tool v. 0.1";
            // 
            // etaSelector
            // 
            this.etaSelector.FormattingEnabled = true;
            this.etaSelector.Items.AddRange(new object[] {
            "ETA",
            "Arrived",
            "Remains"});
            this.etaSelector.Location = new System.Drawing.Point(394, 32);
            this.etaSelector.Name = "etaSelector";
            this.etaSelector.Size = new System.Drawing.Size(121, 21);
            this.etaSelector.TabIndex = 18;
            this.etaSelector.Text = "Select ETA Type";
            this.etaSelector.SelectedIndexChanged += new System.EventHandler(this.etaSelector_SelectedIndexChanged);
            // 
            // cbBerthingArrival
            // 
            this.cbBerthingArrival.AutoSize = true;
            this.cbBerthingArrival.Location = new System.Drawing.Point(394, 66);
            this.cbBerthingArrival.Name = "cbBerthingArrival";
            this.cbBerthingArrival.Size = new System.Drawing.Size(111, 17);
            this.cbBerthingArrival.TabIndex = 19;
            this.cbBerthingArrival.Text = "Berthing on arrival";
            this.cbBerthingArrival.UseVisualStyleBackColor = true;
            this.cbBerthingArrival.CheckedChanged += new System.EventHandler(this.cbBerthingArrival_CheckedChanged);
            // 
            // dailyUpdatePanel
            // 
            this.dailyUpdatePanel.Controls.Add(this.label2);
            this.dailyUpdatePanel.Controls.Add(this.cbBerthingArrival);
            this.dailyUpdatePanel.Controls.Add(this.etaSelector);
            this.dailyUpdatePanel.Controls.Add(this.tbEtbTime);
            this.dailyUpdatePanel.Controls.Add(this.label6);
            this.dailyUpdatePanel.Controls.Add(this.tbEtaTime);
            this.dailyUpdatePanel.Controls.Add(this.label5);
            this.dailyUpdatePanel.Controls.Add(this.label4);
            this.dailyUpdatePanel.Controls.Add(this.portSelector);
            this.dailyUpdatePanel.Controls.Add(this.chkNoEtb);
            this.dailyUpdatePanel.Controls.Add(this.chkNoEta);
            this.dailyUpdatePanel.Controls.Add(this.label3);
            this.dailyUpdatePanel.Controls.Add(this.etbDateTime);
            this.dailyUpdatePanel.Controls.Add(this.label1);
            this.dailyUpdatePanel.Controls.Add(this.etaDateTime);
            this.dailyUpdatePanel.Location = new System.Drawing.Point(6, 6);
            this.dailyUpdatePanel.Name = "dailyUpdatePanel";
            this.dailyUpdatePanel.Size = new System.Drawing.Size(528, 177);
            this.dailyUpdatePanel.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fill out the values below with information received from the agent. ";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.dailyUpdateTab);
            this.tabControl.Controls.Add(this.etcTab);
            this.tabControl.Location = new System.Drawing.Point(12, 49);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 379);
            this.tabControl.TabIndex = 21;
            // 
            // dailyUpdateTab
            // 
            this.dailyUpdateTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dailyUpdateTab.Controls.Add(this.btnCopyEta);
            this.dailyUpdateTab.Controls.Add(this.btnGenerateEta);
            this.dailyUpdateTab.Controls.Add(this.richTextEta);
            this.dailyUpdateTab.Controls.Add(this.btnResetData);
            this.dailyUpdateTab.Controls.Add(this.dailyUpdatePanel);
            this.dailyUpdateTab.Location = new System.Drawing.Point(4, 22);
            this.dailyUpdateTab.Name = "dailyUpdateTab";
            this.dailyUpdateTab.Padding = new System.Windows.Forms.Padding(3);
            this.dailyUpdateTab.Size = new System.Drawing.Size(768, 353);
            this.dailyUpdateTab.TabIndex = 0;
            this.dailyUpdateTab.Text = "Daily Updates";
            // 
            // btnCopyEta
            // 
            this.btnCopyEta.Location = new System.Drawing.Point(130, 216);
            this.btnCopyEta.Name = "btnCopyEta";
            this.btnCopyEta.Size = new System.Drawing.Size(98, 23);
            this.btnCopyEta.TabIndex = 25;
            this.btnCopyEta.Text = "Copy to Clipboard";
            this.btnCopyEta.UseVisualStyleBackColor = true;
            this.btnCopyEta.Click += new System.EventHandler(this.btnCopyEta_Click);
            // 
            // btnGenerateEta
            // 
            this.btnGenerateEta.Location = new System.Drawing.Point(8, 216);
            this.btnGenerateEta.Name = "btnGenerateEta";
            this.btnGenerateEta.Size = new System.Drawing.Size(102, 23);
            this.btnGenerateEta.TabIndex = 24;
            this.btnGenerateEta.Text = "Generate Update";
            this.btnGenerateEta.UseVisualStyleBackColor = true;
            this.btnGenerateEta.Click += new System.EventHandler(this.btnGenerateEta_Click);
            // 
            // richTextEta
            // 
            this.richTextEta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextEta.Location = new System.Drawing.Point(8, 246);
            this.richTextEta.Name = "richTextEta";
            this.richTextEta.ReadOnly = true;
            this.richTextEta.Size = new System.Drawing.Size(754, 96);
            this.richTextEta.TabIndex = 22;
            this.richTextEta.Text = "Generated text will appear here";
            // 
            // btnResetData
            // 
            this.btnResetData.Location = new System.Drawing.Point(666, 14);
            this.btnResetData.Name = "btnResetData";
            this.btnResetData.Size = new System.Drawing.Size(87, 23);
            this.btnResetData.TabIndex = 21;
            this.btnResetData.Text = "Reset Data";
            this.btnResetData.UseVisualStyleBackColor = true;
            this.btnResetData.Click += new System.EventHandler(this.btnResetData_Click);
            // 
            // etcTab
            // 
            this.etcTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.etcTab.Controls.Add(this.btnCopyEtc);
            this.etcTab.Controls.Add(this.btnGenerateEtc);
            this.etcTab.Controls.Add(this.richTextEtc);
            this.etcTab.Controls.Add(this.label12);
            this.etcTab.Controls.Add(this.panelSecondGrade);
            this.etcTab.Controls.Add(this.panelFirstGrade);
            this.etcTab.Controls.Add(this.tbTimeString);
            this.etcTab.Controls.Add(this.rdMetricTons);
            this.etcTab.Controls.Add(this.rdBarrels);
            this.etcTab.Controls.Add(this.ddProduct2);
            this.etcTab.Controls.Add(this.ddProduct1);
            this.etcTab.Controls.Add(this.label13);
            this.etcTab.Controls.Add(this.label10);
            this.etcTab.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.etcTab.Location = new System.Drawing.Point(4, 22);
            this.etcTab.Name = "etcTab";
            this.etcTab.Padding = new System.Windows.Forms.Padding(3);
            this.etcTab.Size = new System.Drawing.Size(768, 353);
            this.etcTab.TabIndex = 1;
            this.etcTab.Text = "ETC Calculator";
            // 
            // btnCopyEtc
            // 
            this.btnCopyEtc.Location = new System.Drawing.Point(130, 216);
            this.btnCopyEtc.Name = "btnCopyEtc";
            this.btnCopyEtc.Size = new System.Drawing.Size(98, 23);
            this.btnCopyEtc.TabIndex = 28;
            this.btnCopyEtc.Text = "Copy to Clipboard";
            this.btnCopyEtc.UseVisualStyleBackColor = true;
            this.btnCopyEtc.Click += new System.EventHandler(this.btnCopyEtc_Click);
            // 
            // btnGenerateEtc
            // 
            this.btnGenerateEtc.Location = new System.Drawing.Point(8, 216);
            this.btnGenerateEtc.Name = "btnGenerateEtc";
            this.btnGenerateEtc.Size = new System.Drawing.Size(102, 23);
            this.btnGenerateEtc.TabIndex = 27;
            this.btnGenerateEtc.Text = "Generate Update";
            this.btnGenerateEtc.UseVisualStyleBackColor = true;
            this.btnGenerateEtc.Click += new System.EventHandler(this.btnGenerateEtc_Click);
            // 
            // richTextEtc
            // 
            this.richTextEtc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextEtc.Location = new System.Drawing.Point(8, 246);
            this.richTextEtc.Name = "richTextEtc";
            this.richTextEtc.ReadOnly = true;
            this.richTextEtc.Size = new System.Drawing.Size(754, 96);
            this.richTextEtc.TabIndex = 26;
            this.richTextEtc.Text = "Generated text will appear here";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(566, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Select a product grade from each box.";
            // 
            // panelSecondGrade
            // 
            this.panelSecondGrade.Controls.Add(this.lblSecondGrade);
            this.panelSecondGrade.Controls.Add(this.label14);
            this.panelSecondGrade.Controls.Add(this.tbIntendedLoad2);
            this.panelSecondGrade.Controls.Add(this.label15);
            this.panelSecondGrade.Controls.Add(this.tbRateOfLoading2);
            this.panelSecondGrade.Controls.Add(this.label16);
            this.panelSecondGrade.Controls.Add(this.tbTotalLoaded2);
            this.panelSecondGrade.Enabled = false;
            this.panelSecondGrade.Location = new System.Drawing.Point(308, 7);
            this.panelSecondGrade.Name = "panelSecondGrade";
            this.panelSecondGrade.Size = new System.Drawing.Size(128, 174);
            this.panelSecondGrade.TabIndex = 19;
            // 
            // lblSecondGrade
            // 
            this.lblSecondGrade.AutoSize = true;
            this.lblSecondGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondGrade.Location = new System.Drawing.Point(11, 5);
            this.lblSecondGrade.Name = "lblSecondGrade";
            this.lblSecondGrade.Size = new System.Drawing.Size(108, 16);
            this.lblSecondGrade.TabIndex = 11;
            this.lblSecondGrade.Text = "Second Grade";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Intended load quantity";
            // 
            // tbIntendedLoad2
            // 
            this.tbIntendedLoad2.Location = new System.Drawing.Point(13, 45);
            this.tbIntendedLoad2.MaxLength = 6;
            this.tbIntendedLoad2.Name = "tbIntendedLoad2";
            this.tbIntendedLoad2.Size = new System.Drawing.Size(100, 20);
            this.tbIntendedLoad2.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Rate of loading";
            // 
            // tbRateOfLoading2
            // 
            this.tbRateOfLoading2.Location = new System.Drawing.Point(13, 143);
            this.tbRateOfLoading2.MaxLength = 6;
            this.tbRateOfLoading2.Name = "tbRateOfLoading2";
            this.tbRateOfLoading2.Size = new System.Drawing.Size(100, 20);
            this.tbRateOfLoading2.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Total Loaded";
            // 
            // tbTotalLoaded2
            // 
            this.tbTotalLoaded2.Location = new System.Drawing.Point(13, 93);
            this.tbTotalLoaded2.MaxLength = 6;
            this.tbTotalLoaded2.Name = "tbTotalLoaded2";
            this.tbTotalLoaded2.Size = new System.Drawing.Size(100, 20);
            this.tbTotalLoaded2.TabIndex = 4;
            // 
            // panelFirstGrade
            // 
            this.panelFirstGrade.Controls.Add(this.lblFirstGrade);
            this.panelFirstGrade.Controls.Add(this.label11);
            this.panelFirstGrade.Controls.Add(this.tbIntendedLoad1);
            this.panelFirstGrade.Controls.Add(this.label9);
            this.panelFirstGrade.Controls.Add(this.tbRateOfLoading1);
            this.panelFirstGrade.Controls.Add(this.label8);
            this.panelFirstGrade.Controls.Add(this.tbTotalLoaded1);
            this.panelFirstGrade.Location = new System.Drawing.Point(0, 7);
            this.panelFirstGrade.Name = "panelFirstGrade";
            this.panelFirstGrade.Size = new System.Drawing.Size(128, 174);
            this.panelFirstGrade.TabIndex = 18;
            // 
            // lblFirstGrade
            // 
            this.lblFirstGrade.AutoSize = true;
            this.lblFirstGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstGrade.Location = new System.Drawing.Point(11, 5);
            this.lblFirstGrade.Name = "lblFirstGrade";
            this.lblFirstGrade.Size = new System.Drawing.Size(85, 16);
            this.lblFirstGrade.TabIndex = 11;
            this.lblFirstGrade.Text = "First Grade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Intended load quantity";
            // 
            // tbIntendedLoad1
            // 
            this.tbIntendedLoad1.Location = new System.Drawing.Point(13, 45);
            this.tbIntendedLoad1.MaxLength = 6;
            this.tbIntendedLoad1.Name = "tbIntendedLoad1";
            this.tbIntendedLoad1.Size = new System.Drawing.Size(100, 20);
            this.tbIntendedLoad1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Rate of loading";
            // 
            // tbRateOfLoading1
            // 
            this.tbRateOfLoading1.Location = new System.Drawing.Point(13, 143);
            this.tbRateOfLoading1.MaxLength = 6;
            this.tbRateOfLoading1.Name = "tbRateOfLoading1";
            this.tbRateOfLoading1.Size = new System.Drawing.Size(100, 20);
            this.tbRateOfLoading1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total Loaded";
            // 
            // tbTotalLoaded1
            // 
            this.tbTotalLoaded1.Location = new System.Drawing.Point(13, 93);
            this.tbTotalLoaded1.MaxLength = 6;
            this.tbTotalLoaded1.Name = "tbTotalLoaded1";
            this.tbTotalLoaded1.Size = new System.Drawing.Size(100, 20);
            this.tbTotalLoaded1.TabIndex = 1;
            // 
            // tbTimeString
            // 
            this.tbTimeString.Location = new System.Drawing.Point(636, 23);
            this.tbTimeString.MaxLength = 5;
            this.tbTimeString.Name = "tbTimeString";
            this.tbTimeString.Size = new System.Drawing.Size(100, 20);
            this.tbTimeString.TabIndex = 6;
            this.tbTimeString.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTimeString_KeyPress);
            // 
            // rdMetricTons
            // 
            this.rdMetricTons.AutoSize = true;
            this.rdMetricTons.Location = new System.Drawing.Point(658, 78);
            this.rdMetricTons.Name = "rdMetricTons";
            this.rdMetricTons.Size = new System.Drawing.Size(41, 17);
            this.rdMetricTons.TabIndex = 8;
            this.rdMetricTons.Text = "MT";
            this.rdMetricTons.UseVisualStyleBackColor = true;
            // 
            // rdBarrels
            // 
            this.rdBarrels.AutoSize = true;
            this.rdBarrels.Checked = true;
            this.rdBarrels.Location = new System.Drawing.Point(658, 55);
            this.rdBarrels.Name = "rdBarrels";
            this.rdBarrels.Size = new System.Drawing.Size(57, 17);
            this.rdBarrels.TabIndex = 7;
            this.rdBarrels.TabStop = true;
            this.rdBarrels.Text = "Barrels";
            this.rdBarrels.UseVisualStyleBackColor = true;
            // 
            // ddProduct2
            // 
            this.ddProduct2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddProduct2.FormattingEnabled = true;
            this.ddProduct2.Items.AddRange(new object[] {
            "None",
            "Propane",
            "Normal Butane",
            "Isobutane",
            "Polymer Grade Propylene",
            "Crude Butadiene",
            "Ethane",
            "Ethylene"});
            this.ddProduct2.Location = new System.Drawing.Point(634, 153);
            this.ddProduct2.Name = "ddProduct2";
            this.ddProduct2.Size = new System.Drawing.Size(121, 21);
            this.ddProduct2.TabIndex = 10;
            this.ddProduct2.SelectedIndexChanged += new System.EventHandler(this.ddProduct2_SelectedIndexChanged);
            // 
            // ddProduct1
            // 
            this.ddProduct1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddProduct1.FormattingEnabled = true;
            this.ddProduct1.Items.AddRange(new object[] {
            "None",
            "Propane",
            "Normal Butane",
            "Isobutane",
            "Polymer Grade Propylene",
            "Crude Butadiene",
            "Ethane",
            "Ethylene"});
            this.ddProduct1.Location = new System.Drawing.Point(634, 126);
            this.ddProduct1.Name = "ddProduct1";
            this.ddProduct1.Size = new System.Drawing.Size(121, 21);
            this.ddProduct1.TabIndex = 9;
            this.ddProduct1.SelectedIndexChanged += new System.EventHandler(this.ddProduct1_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(632, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Product(s)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(633, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Time of update";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(688, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 40);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Generator";
            this.Text = "AmSpec LPG Dispatch tool";
            this.dailyUpdatePanel.ResumeLayout(false);
            this.dailyUpdatePanel.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.dailyUpdateTab.ResumeLayout(false);
            this.etcTab.ResumeLayout(false);
            this.etcTab.PerformLayout();
            this.panelSecondGrade.ResumeLayout(false);
            this.panelSecondGrade.PerformLayout();
            this.panelFirstGrade.ResumeLayout(false);
            this.panelFirstGrade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker etaDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker etbDateTime;
        private System.Windows.Forms.CheckBox chkNoEta;
        private System.Windows.Forms.CheckBox chkNoEtb;
        private System.Windows.Forms.ComboBox portSelector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEtaTime;
        private System.Windows.Forms.TextBox tbEtbTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.ComboBox etaSelector;
        private System.Windows.Forms.CheckBox cbBerthingArrival;
        private System.Windows.Forms.Panel dailyUpdatePanel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage dailyUpdateTab;
        private System.Windows.Forms.TabPage etcTab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTotalLoaded1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbRateOfLoading1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbIntendedLoad1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblFirstGrade;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ddProduct1;
        private System.Windows.Forms.ComboBox ddProduct2;
        private System.Windows.Forms.RadioButton rdMetricTons;
        private System.Windows.Forms.RadioButton rdBarrels;
        private System.Windows.Forms.TextBox tbTimeString;
        private System.Windows.Forms.Panel panelFirstGrade;
        private System.Windows.Forms.Panel panelSecondGrade;
        private System.Windows.Forms.Label lblSecondGrade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbIntendedLoad2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbRateOfLoading2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbTotalLoaded2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnResetData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextEta;
        private System.Windows.Forms.Button btnCopyEta;
        private System.Windows.Forms.Button btnGenerateEta;
        private System.Windows.Forms.Button btnCopyEtc;
        private System.Windows.Forms.Button btnGenerateEtc;
        private System.Windows.Forms.RichTextBox richTextEtc;
    }
}