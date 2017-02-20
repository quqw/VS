namespace SerialComm
{
    partial class SerialComm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonInsertZero = new System.Windows.Forms.Button();
            this.buttonRemoveZero = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.radioButtonHex = new System.Windows.Forms.RadioButton();
            this.radioButtonBit = new System.Windows.Forms.RadioButton();
            this.radioButtonAscii = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxGap = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonBitMsb = new System.Windows.Forms.RadioButton();
            this.radioButtonBitLsb = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBoxHdlcFcs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCcittCrc8 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCcittCrc16 = new System.Windows.Forms.TextBox();
            this.buttonCalcCrc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDec = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxHex = new System.Windows.Forms.TextBox();
            this.buttonCformatOut = new System.Windows.Forms.Button();
            this.buttonHdlcEncode = new System.Windows.Forms.Button();
            this.buttonHdlcAnalize = new System.Windows.Forms.Button();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMiddle = new System.Windows.Forms.TableLayoutPanel();
            this.panelMiddlwLeft = new System.Windows.Forms.Panel();
            this.groupBoxCom = new System.Windows.Forms.GroupBox();
            this.numericUpDownComSendGap = new System.Windows.Forms.NumericUpDown();
            this.checkBoxComSendContinous = new System.Windows.Forms.CheckBox();
            this.buttonClearReceive = new System.Windows.Forms.Button();
            this.buttonClearSend = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonComSend = new System.Windows.Forms.Button();
            this.comboBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanelMiddleRight = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxReceive = new System.Windows.Forms.TextBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.timerSerialSend = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelSendCount = new System.Windows.Forms.Label();
            this.labelReceiveCount = new System.Windows.Forms.Label();
            this.checkBoxAutoClear = new System.Windows.Forms.CheckBox();
            this.tabControlSend = new System.Windows.Forms.TabControl();
            this.tabPageSendOne = new System.Windows.Forms.TabPage();
            this.tabPageMultiSend = new System.Windows.Forms.TabPage();
            this.textBoxMultisend1 = new System.Windows.Forms.TextBox();
            this.checkBoxSend1 = new System.Windows.Forms.CheckBox();
            this.buttonMultiSend1 = new System.Windows.Forms.Button();
            this.buttonMultiSend2 = new System.Windows.Forms.Button();
            this.checkBoxSend2 = new System.Windows.Forms.CheckBox();
            this.textBoxMultisend2 = new System.Windows.Forms.TextBox();
            this.buttonMultiSend3 = new System.Windows.Forms.Button();
            this.checkBoxSend3 = new System.Windows.Forms.CheckBox();
            this.textBoxMultisend3 = new System.Windows.Forms.TextBox();
            this.buttonMultiSend4 = new System.Windows.Forms.Button();
            this.checkBoxSend4 = new System.Windows.Forms.CheckBox();
            this.textBoxMultisend4 = new System.Windows.Forms.TextBox();
            this.buttonMultiSend5 = new System.Windows.Forms.Button();
            this.checkBoxSend5 = new System.Windows.Forms.CheckBox();
            this.textBoxMultisend5 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.tableLayoutPanelMiddle.SuspendLayout();
            this.panelMiddlwLeft.SuspendLayout();
            this.groupBoxCom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownComSendGap)).BeginInit();
            this.tableLayoutPanelMiddleRight.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.tabControlSend.SuspendLayout();
            this.tabPageSendOne.SuspendLayout();
            this.tabPageMultiSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInsertZero
            // 
            this.buttonInsertZero.Location = new System.Drawing.Point(10, 3);
            this.buttonInsertZero.Name = "buttonInsertZero";
            this.buttonInsertZero.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertZero.TabIndex = 0;
            this.buttonInsertZero.Text = "HDLC插0";
            this.buttonInsertZero.UseVisualStyleBackColor = true;
            this.buttonInsertZero.Click += new System.EventHandler(this.buttonInsertZero_Click);
            // 
            // buttonRemoveZero
            // 
            this.buttonRemoveZero.Location = new System.Drawing.Point(93, 3);
            this.buttonRemoveZero.Name = "buttonRemoveZero";
            this.buttonRemoveZero.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveZero.TabIndex = 3;
            this.buttonRemoveZero.Text = "HDLC去0";
            this.buttonRemoveZero.UseVisualStyleBackColor = true;
            this.buttonRemoveZero.Click += new System.EventHandler(this.buttonRemoveZero_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(0, 3);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(701, 155);
            this.textBoxInput.TabIndex = 4;
            this.textBoxInput.DoubleClick += new System.EventHandler(this.textBoxData_DoubleClick);
            this.textBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxData_KeyDown);
            // 
            // radioButtonHex
            // 
            this.radioButtonHex.AutoSize = true;
            this.radioButtonHex.Checked = true;
            this.radioButtonHex.Location = new System.Drawing.Point(12, 20);
            this.radioButtonHex.Name = "radioButtonHex";
            this.radioButtonHex.Size = new System.Drawing.Size(41, 16);
            this.radioButtonHex.TabIndex = 6;
            this.radioButtonHex.TabStop = true;
            this.radioButtonHex.Text = "Hex";
            this.radioButtonHex.UseVisualStyleBackColor = true;
            this.radioButtonHex.CheckedChanged += new System.EventHandler(this.radioButtonHex_CheckedChanged);
            // 
            // radioButtonBit
            // 
            this.radioButtonBit.AutoSize = true;
            this.radioButtonBit.Location = new System.Drawing.Point(121, 20);
            this.radioButtonBit.Name = "radioButtonBit";
            this.radioButtonBit.Size = new System.Drawing.Size(41, 16);
            this.radioButtonBit.TabIndex = 7;
            this.radioButtonBit.Text = "Bit";
            this.radioButtonBit.UseVisualStyleBackColor = true;
            this.radioButtonBit.CheckedChanged += new System.EventHandler(this.radioButtonBit_CheckedChanged);
            // 
            // radioButtonAscii
            // 
            this.radioButtonAscii.AutoSize = true;
            this.radioButtonAscii.Location = new System.Drawing.Point(61, 20);
            this.radioButtonAscii.Name = "radioButtonAscii";
            this.radioButtonAscii.Size = new System.Drawing.Size(53, 16);
            this.radioButtonAscii.TabIndex = 8;
            this.radioButtonAscii.Text = "Ascii";
            this.radioButtonAscii.UseVisualStyleBackColor = true;
            this.radioButtonAscii.CheckedChanged += new System.EventHandler(this.radioButtonAscii_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxGap);
            this.groupBox1.Controls.Add(this.radioButtonBit);
            this.groupBox1.Controls.Add(this.radioButtonAscii);
            this.groupBox1.Controls.Add(this.radioButtonHex);
            this.groupBox1.Location = new System.Drawing.Point(3, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 48);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据显示格式";
            // 
            // checkBoxGap
            // 
            this.checkBoxGap.AutoSize = true;
            this.checkBoxGap.Checked = true;
            this.checkBoxGap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGap.Location = new System.Drawing.Point(167, 21);
            this.checkBoxGap.Name = "checkBoxGap";
            this.checkBoxGap.Size = new System.Drawing.Size(48, 16);
            this.checkBoxGap.TabIndex = 13;
            this.checkBoxGap.Text = "分隔";
            this.checkBoxGap.UseVisualStyleBackColor = true;
            this.checkBoxGap.CheckedChanged += new System.EventHandler(this.checkBoxGap_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonBitMsb);
            this.groupBox2.Controls.Add(this.radioButtonBitLsb);
            this.groupBox2.Location = new System.Drawing.Point(230, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 48);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "单字节内位模式";
            // 
            // radioButtonBitMsb
            // 
            this.radioButtonBitMsb.AutoSize = true;
            this.radioButtonBitMsb.Checked = true;
            this.radioButtonBitMsb.Location = new System.Drawing.Point(61, 20);
            this.radioButtonBitMsb.Name = "radioButtonBitMsb";
            this.radioButtonBitMsb.Size = new System.Drawing.Size(41, 16);
            this.radioButtonBitMsb.TabIndex = 8;
            this.radioButtonBitMsb.TabStop = true;
            this.radioButtonBitMsb.Text = "MSB";
            this.radioButtonBitMsb.UseVisualStyleBackColor = true;
            this.radioButtonBitMsb.CheckedChanged += new System.EventHandler(this.radioButtonBitMsb_CheckedChanged);
            // 
            // radioButtonBitLsb
            // 
            this.radioButtonBitLsb.AutoSize = true;
            this.radioButtonBitLsb.Location = new System.Drawing.Point(12, 20);
            this.radioButtonBitLsb.Name = "radioButtonBitLsb";
            this.radioButtonBitLsb.Size = new System.Drawing.Size(41, 16);
            this.radioButtonBitLsb.TabIndex = 6;
            this.radioButtonBitLsb.Text = "LSB";
            this.radioButtonBitLsb.UseVisualStyleBackColor = true;
            this.radioButtonBitLsb.CheckedChanged += new System.EventHandler(this.radioButtonBitLsb_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Location = new System.Drawing.Point(348, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(112, 48);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "字符串模式";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(61, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 16);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "MSB";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(41, 16);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "LSB";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBoxHdlcFcs
            // 
            this.textBoxHdlcFcs.Location = new System.Drawing.Point(57, 63);
            this.textBoxHdlcFcs.Name = "textBoxHdlcFcs";
            this.textBoxHdlcFcs.ReadOnly = true;
            this.textBoxHdlcFcs.Size = new System.Drawing.Size(45, 21);
            this.textBoxHdlcFcs.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "HDLC-FCS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "CCITT-CRC8";
            // 
            // textBoxCcittCrc8
            // 
            this.textBoxCcittCrc8.Location = new System.Drawing.Point(188, 63);
            this.textBoxCcittCrc8.Name = "textBoxCcittCrc8";
            this.textBoxCcittCrc8.ReadOnly = true;
            this.textBoxCcittCrc8.Size = new System.Drawing.Size(45, 21);
            this.textBoxCcittCrc8.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "CCITT-CRC16";
            // 
            // textBoxCcittCrc16
            // 
            this.textBoxCcittCrc16.Location = new System.Drawing.Point(328, 63);
            this.textBoxCcittCrc16.Name = "textBoxCcittCrc16";
            this.textBoxCcittCrc16.ReadOnly = true;
            this.textBoxCcittCrc16.Size = new System.Drawing.Size(45, 21);
            this.textBoxCcittCrc16.TabIndex = 17;
            // 
            // buttonCalcCrc
            // 
            this.buttonCalcCrc.Location = new System.Drawing.Point(385, 63);
            this.buttonCalcCrc.Name = "buttonCalcCrc";
            this.buttonCalcCrc.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcCrc.TabIndex = 19;
            this.buttonCalcCrc.Text = "计算CRC";
            this.buttonCalcCrc.UseVisualStyleBackColor = true;
            this.buttonCalcCrc.Click += new System.EventHandler(this.buttonCalcCrc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "BIN";
            // 
            // textBoxBin
            // 
            this.textBoxBin.Location = new System.Drawing.Point(292, 8);
            this.textBoxBin.Name = "textBoxBin";
            this.textBoxBin.Size = new System.Drawing.Size(230, 21);
            this.textBoxBin.TabIndex = 24;
            this.textBoxBin.TextChanged += new System.EventHandler(this.textBoxBin_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "DEC";
            // 
            // textBoxDec
            // 
            this.textBoxDec.Location = new System.Drawing.Point(41, 8);
            this.textBoxDec.MaxLength = 10;
            this.textBoxDec.Name = "textBoxDec";
            this.textBoxDec.Size = new System.Drawing.Size(66, 21);
            this.textBoxDec.TabIndex = 22;
            this.textBoxDec.TextChanged += new System.EventHandler(this.textBoxDec_TextChanged);
            this.textBoxDec.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxDec_MouseDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "HEX";
            // 
            // textBoxHex
            // 
            this.textBoxHex.Location = new System.Drawing.Point(161, 8);
            this.textBoxHex.Name = "textBoxHex";
            this.textBoxHex.Size = new System.Drawing.Size(69, 21);
            this.textBoxHex.TabIndex = 20;
            this.textBoxHex.TextChanged += new System.EventHandler(this.textBoxHex_TextChanged);
            // 
            // buttonCformatOut
            // 
            this.buttonCformatOut.Location = new System.Drawing.Point(11, 61);
            this.buttonCformatOut.Name = "buttonCformatOut";
            this.buttonCformatOut.Size = new System.Drawing.Size(75, 23);
            this.buttonCformatOut.TabIndex = 26;
            this.buttonCformatOut.Text = "C格式";
            this.buttonCformatOut.UseVisualStyleBackColor = true;
            this.buttonCformatOut.Click += new System.EventHandler(this.buttonCformatOut_Click);
            // 
            // buttonHdlcEncode
            // 
            this.buttonHdlcEncode.Location = new System.Drawing.Point(10, 32);
            this.buttonHdlcEncode.Name = "buttonHdlcEncode";
            this.buttonHdlcEncode.Size = new System.Drawing.Size(75, 23);
            this.buttonHdlcEncode.TabIndex = 27;
            this.buttonHdlcEncode.Text = "HDLC编码";
            this.buttonHdlcEncode.UseVisualStyleBackColor = true;
            this.buttonHdlcEncode.Click += new System.EventHandler(this.buttonHdlcEncode_Click);
            // 
            // buttonHdlcAnalize
            // 
            this.buttonHdlcAnalize.Location = new System.Drawing.Point(91, 32);
            this.buttonHdlcAnalize.Name = "buttonHdlcAnalize";
            this.buttonHdlcAnalize.Size = new System.Drawing.Size(75, 23);
            this.buttonHdlcAnalize.TabIndex = 28;
            this.buttonHdlcAnalize.Text = "HDLC分析";
            this.buttonHdlcAnalize.UseVisualStyleBackColor = true;
            this.buttonHdlcAnalize.Click += new System.EventHandler(this.buttonHdlcAnalize_Click);
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(48, 18);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(59, 20);
            this.comboBoxComPort.TabIndex = 29;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.Controls.Add(this.panelTop, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelMiddle, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.panelBottom, 0, 2);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.61789F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.38211F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(914, 520);
            this.tableLayoutPanelMain.TabIndex = 30;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.groupBox1);
            this.panelTop.Controls.Add(this.groupBox2);
            this.panelTop.Controls.Add(this.groupBox3);
            this.panelTop.Controls.Add(this.textBoxHdlcFcs);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.textBoxCcittCrc8);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.textBoxCcittCrc16);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.buttonCalcCrc);
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(898, 88);
            this.panelTop.TabIndex = 0;
            // 
            // tableLayoutPanelMiddle
            // 
            this.tableLayoutPanelMiddle.ColumnCount = 2;
            this.tableLayoutPanelMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.75851F));
            this.tableLayoutPanelMiddle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.24149F));
            this.tableLayoutPanelMiddle.Controls.Add(this.panelMiddlwLeft, 0, 0);
            this.tableLayoutPanelMiddle.Controls.Add(this.tableLayoutPanelMiddleRight, 1, 0);
            this.tableLayoutPanelMiddle.Location = new System.Drawing.Point(3, 99);
            this.tableLayoutPanelMiddle.Name = "tableLayoutPanelMiddle";
            this.tableLayoutPanelMiddle.RowCount = 1;
            this.tableLayoutPanelMiddle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMiddle.Size = new System.Drawing.Size(911, 369);
            this.tableLayoutPanelMiddle.TabIndex = 1;
            // 
            // panelMiddlwLeft
            // 
            this.panelMiddlwLeft.Controls.Add(this.labelReceiveCount);
            this.panelMiddlwLeft.Controls.Add(this.labelSendCount);
            this.panelMiddlwLeft.Controls.Add(this.label10);
            this.panelMiddlwLeft.Controls.Add(this.label9);
            this.panelMiddlwLeft.Controls.Add(this.groupBoxCom);
            this.panelMiddlwLeft.Controls.Add(this.buttonInsertZero);
            this.panelMiddlwLeft.Controls.Add(this.buttonHdlcAnalize);
            this.panelMiddlwLeft.Controls.Add(this.buttonRemoveZero);
            this.panelMiddlwLeft.Controls.Add(this.buttonHdlcEncode);
            this.panelMiddlwLeft.Controls.Add(this.buttonCformatOut);
            this.panelMiddlwLeft.Location = new System.Drawing.Point(3, 3);
            this.panelMiddlwLeft.Name = "panelMiddlwLeft";
            this.panelMiddlwLeft.Size = new System.Drawing.Size(173, 308);
            this.panelMiddlwLeft.TabIndex = 5;
            // 
            // groupBoxCom
            // 
            this.groupBoxCom.Controls.Add(this.checkBoxAutoClear);
            this.groupBoxCom.Controls.Add(this.numericUpDownComSendGap);
            this.groupBoxCom.Controls.Add(this.checkBoxComSendContinous);
            this.groupBoxCom.Controls.Add(this.buttonClearReceive);
            this.groupBoxCom.Controls.Add(this.buttonClearSend);
            this.groupBoxCom.Controls.Add(this.buttonRefresh);
            this.groupBoxCom.Controls.Add(this.buttonComSend);
            this.groupBoxCom.Controls.Add(this.comboBoxBaudrate);
            this.groupBoxCom.Controls.Add(this.buttonOpen);
            this.groupBoxCom.Controls.Add(this.comboBoxComPort);
            this.groupBoxCom.Controls.Add(this.label8);
            this.groupBoxCom.Controls.Add(this.label7);
            this.groupBoxCom.Location = new System.Drawing.Point(5, 85);
            this.groupBoxCom.Name = "groupBoxCom";
            this.groupBoxCom.Size = new System.Drawing.Size(164, 171);
            this.groupBoxCom.TabIndex = 34;
            this.groupBoxCom.TabStop = false;
            // 
            // numericUpDownComSendGap
            // 
            this.numericUpDownComSendGap.Location = new System.Drawing.Point(99, 143);
            this.numericUpDownComSendGap.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownComSendGap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownComSendGap.Name = "numericUpDownComSendGap";
            this.numericUpDownComSendGap.Size = new System.Drawing.Size(55, 21);
            this.numericUpDownComSendGap.TabIndex = 38;
            this.numericUpDownComSendGap.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // checkBoxComSendContinous
            // 
            this.checkBoxComSendContinous.AutoSize = true;
            this.checkBoxComSendContinous.Location = new System.Drawing.Point(100, 125);
            this.checkBoxComSendContinous.Name = "checkBoxComSendContinous";
            this.checkBoxComSendContinous.Size = new System.Drawing.Size(48, 16);
            this.checkBoxComSendContinous.TabIndex = 37;
            this.checkBoxComSendContinous.Text = "连续";
            this.checkBoxComSendContinous.UseVisualStyleBackColor = true;
            this.checkBoxComSendContinous.CheckedChanged += new System.EventHandler(this.checkBoxComSendContinous_CheckedChanged);
            // 
            // buttonClearReceive
            // 
            this.buttonClearReceive.Location = new System.Drawing.Point(7, 96);
            this.buttonClearReceive.Name = "buttonClearReceive";
            this.buttonClearReceive.Size = new System.Drawing.Size(58, 23);
            this.buttonClearReceive.TabIndex = 36;
            this.buttonClearReceive.Text = "清接收";
            this.buttonClearReceive.UseVisualStyleBackColor = true;
            this.buttonClearReceive.Click += new System.EventHandler(this.buttonClearReceive_Click);
            // 
            // buttonClearSend
            // 
            this.buttonClearSend.Location = new System.Drawing.Point(90, 96);
            this.buttonClearSend.Name = "buttonClearSend";
            this.buttonClearSend.Size = new System.Drawing.Size(58, 23);
            this.buttonClearSend.TabIndex = 35;
            this.buttonClearSend.Text = "清发送";
            this.buttonClearSend.UseVisualStyleBackColor = true;
            this.buttonClearSend.Click += new System.EventHandler(this.buttonClearSend_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(114, 16);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(49, 23);
            this.buttonRefresh.TabIndex = 34;
            this.buttonRefresh.Text = "刷新";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonComSend
            // 
            this.buttonComSend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonComSend.Location = new System.Drawing.Point(6, 126);
            this.buttonComSend.Name = "buttonComSend";
            this.buttonComSend.Size = new System.Drawing.Size(66, 37);
            this.buttonComSend.TabIndex = 29;
            this.buttonComSend.Text = "发送";
            this.buttonComSend.UseVisualStyleBackColor = false;
            this.buttonComSend.Click += new System.EventHandler(this.buttonComSend_Click);
            // 
            // comboBoxBaudrate
            // 
            this.comboBoxBaudrate.FormattingEnabled = true;
            this.comboBoxBaudrate.Items.AddRange(new object[] {
            "9600",
            "57600",
            "115200"});
            this.comboBoxBaudrate.Location = new System.Drawing.Point(48, 41);
            this.comboBoxBaudrate.Name = "comboBoxBaudrate";
            this.comboBoxBaudrate.Size = new System.Drawing.Size(77, 20);
            this.comboBoxBaudrate.TabIndex = 30;
            this.comboBoxBaudrate.Text = "9600";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(6, 67);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(59, 23);
            this.buttonOpen.TabIndex = 33;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 32;
            this.label8.Text = "波特率";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 31;
            this.label7.Text = "串口";
            // 
            // tableLayoutPanelMiddleRight
            // 
            this.tableLayoutPanelMiddleRight.ColumnCount = 1;
            this.tableLayoutPanelMiddleRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMiddleRight.Controls.Add(this.textBoxReceive, 0, 0);
            this.tableLayoutPanelMiddleRight.Controls.Add(this.tabControlSend, 0, 1);
            this.tableLayoutPanelMiddleRight.Location = new System.Drawing.Point(183, 3);
            this.tableLayoutPanelMiddleRight.Name = "tableLayoutPanelMiddleRight";
            this.tableLayoutPanelMiddleRight.RowCount = 2;
            this.tableLayoutPanelMiddleRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.93388F));
            this.tableLayoutPanelMiddleRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.06612F));
            this.tableLayoutPanelMiddleRight.Size = new System.Drawing.Size(725, 363);
            this.tableLayoutPanelMiddleRight.TabIndex = 6;
            // 
            // textBoxReceive
            // 
            this.textBoxReceive.Location = new System.Drawing.Point(3, 3);
            this.textBoxReceive.Multiline = true;
            this.textBoxReceive.Name = "textBoxReceive";
            this.textBoxReceive.ReadOnly = true;
            this.textBoxReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceive.Size = new System.Drawing.Size(713, 167);
            this.textBoxReceive.TabIndex = 5;
            this.textBoxReceive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxReceive_KeyDown);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.label5);
            this.panelBottom.Controls.Add(this.label4);
            this.panelBottom.Controls.Add(this.textBoxHex);
            this.panelBottom.Controls.Add(this.textBoxBin);
            this.panelBottom.Controls.Add(this.label6);
            this.panelBottom.Controls.Add(this.textBoxDec);
            this.panelBottom.Location = new System.Drawing.Point(3, 474);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(819, 36);
            this.panelBottom.TabIndex = 2;
            // 
            // timerSerialSend
            // 
            this.timerSerialSend.Tick += new System.EventHandler(this.timerSerialSend_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 35;
            this.label9.Text = "发送：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 36;
            this.label10.Text = "接收：";
            // 
            // labelSendCount
            // 
            this.labelSendCount.AutoSize = true;
            this.labelSendCount.Location = new System.Drawing.Point(51, 263);
            this.labelSendCount.Name = "labelSendCount";
            this.labelSendCount.Size = new System.Drawing.Size(11, 12);
            this.labelSendCount.TabIndex = 37;
            this.labelSendCount.Text = "0";
            // 
            // labelReceiveCount
            // 
            this.labelReceiveCount.AutoSize = true;
            this.labelReceiveCount.Location = new System.Drawing.Point(51, 286);
            this.labelReceiveCount.Name = "labelReceiveCount";
            this.labelReceiveCount.Size = new System.Drawing.Size(11, 12);
            this.labelReceiveCount.TabIndex = 38;
            this.labelReceiveCount.Text = "0";
            // 
            // checkBoxAutoClear
            // 
            this.checkBoxAutoClear.AutoSize = true;
            this.checkBoxAutoClear.Checked = true;
            this.checkBoxAutoClear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoClear.Location = new System.Drawing.Point(90, 71);
            this.checkBoxAutoClear.Name = "checkBoxAutoClear";
            this.checkBoxAutoClear.Size = new System.Drawing.Size(72, 16);
            this.checkBoxAutoClear.TabIndex = 39;
            this.checkBoxAutoClear.Text = "自动清空";
            this.checkBoxAutoClear.UseVisualStyleBackColor = true;
            // 
            // tabControlSend
            // 
            this.tabControlSend.Controls.Add(this.tabPageSendOne);
            this.tabControlSend.Controls.Add(this.tabPageMultiSend);
            this.tabControlSend.Location = new System.Drawing.Point(3, 176);
            this.tabControlSend.Name = "tabControlSend";
            this.tabControlSend.SelectedIndex = 0;
            this.tabControlSend.Size = new System.Drawing.Size(712, 184);
            this.tabControlSend.TabIndex = 6;
            // 
            // tabPageSendOne
            // 
            this.tabPageSendOne.Controls.Add(this.textBoxInput);
            this.tabPageSendOne.Location = new System.Drawing.Point(4, 22);
            this.tabPageSendOne.Name = "tabPageSendOne";
            this.tabPageSendOne.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSendOne.Size = new System.Drawing.Size(704, 158);
            this.tabPageSendOne.TabIndex = 0;
            this.tabPageSendOne.Text = "主发送框";
            this.tabPageSendOne.UseVisualStyleBackColor = true;
            // 
            // tabPageMultiSend
            // 
            this.tabPageMultiSend.Controls.Add(this.buttonMultiSend5);
            this.tabPageMultiSend.Controls.Add(this.checkBoxSend5);
            this.tabPageMultiSend.Controls.Add(this.textBoxMultisend5);
            this.tabPageMultiSend.Controls.Add(this.buttonMultiSend4);
            this.tabPageMultiSend.Controls.Add(this.checkBoxSend4);
            this.tabPageMultiSend.Controls.Add(this.textBoxMultisend4);
            this.tabPageMultiSend.Controls.Add(this.buttonMultiSend3);
            this.tabPageMultiSend.Controls.Add(this.checkBoxSend3);
            this.tabPageMultiSend.Controls.Add(this.textBoxMultisend3);
            this.tabPageMultiSend.Controls.Add(this.buttonMultiSend2);
            this.tabPageMultiSend.Controls.Add(this.checkBoxSend2);
            this.tabPageMultiSend.Controls.Add(this.textBoxMultisend2);
            this.tabPageMultiSend.Controls.Add(this.buttonMultiSend1);
            this.tabPageMultiSend.Controls.Add(this.checkBoxSend1);
            this.tabPageMultiSend.Controls.Add(this.textBoxMultisend1);
            this.tabPageMultiSend.Location = new System.Drawing.Point(4, 22);
            this.tabPageMultiSend.Name = "tabPageMultiSend";
            this.tabPageMultiSend.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMultiSend.Size = new System.Drawing.Size(704, 158);
            this.tabPageMultiSend.TabIndex = 1;
            this.tabPageMultiSend.Text = "多条发送";
            this.tabPageMultiSend.UseVisualStyleBackColor = true;
            // 
            // textBoxMultisend1
            // 
            this.textBoxMultisend1.Location = new System.Drawing.Point(29, 13);
            this.textBoxMultisend1.Name = "textBoxMultisend1";
            this.textBoxMultisend1.Size = new System.Drawing.Size(617, 21);
            this.textBoxMultisend1.TabIndex = 0;
            // 
            // checkBoxSend1
            // 
            this.checkBoxSend1.AutoSize = true;
            this.checkBoxSend1.Location = new System.Drawing.Point(9, 16);
            this.checkBoxSend1.Name = "checkBoxSend1";
            this.checkBoxSend1.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSend1.TabIndex = 1;
            this.checkBoxSend1.UseVisualStyleBackColor = true;
            // 
            // buttonMultiSend1
            // 
            this.buttonMultiSend1.Location = new System.Drawing.Point(654, 13);
            this.buttonMultiSend1.Name = "buttonMultiSend1";
            this.buttonMultiSend1.Size = new System.Drawing.Size(44, 23);
            this.buttonMultiSend1.TabIndex = 2;
            this.buttonMultiSend1.Text = "Send";
            this.buttonMultiSend1.UseVisualStyleBackColor = true;
            this.buttonMultiSend1.Click += new System.EventHandler(this.buttonMultiSend1_Click);
            // 
            // buttonMultiSend2
            // 
            this.buttonMultiSend2.Location = new System.Drawing.Point(654, 40);
            this.buttonMultiSend2.Name = "buttonMultiSend2";
            this.buttonMultiSend2.Size = new System.Drawing.Size(44, 23);
            this.buttonMultiSend2.TabIndex = 5;
            this.buttonMultiSend2.Text = "Send";
            this.buttonMultiSend2.UseVisualStyleBackColor = true;
            this.buttonMultiSend2.Click += new System.EventHandler(this.buttonMultiSend2_Click);
            // 
            // checkBoxSend2
            // 
            this.checkBoxSend2.AutoSize = true;
            this.checkBoxSend2.Location = new System.Drawing.Point(9, 43);
            this.checkBoxSend2.Name = "checkBoxSend2";
            this.checkBoxSend2.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSend2.TabIndex = 4;
            this.checkBoxSend2.UseVisualStyleBackColor = true;
            // 
            // textBoxMultisend2
            // 
            this.textBoxMultisend2.Location = new System.Drawing.Point(29, 40);
            this.textBoxMultisend2.Name = "textBoxMultisend2";
            this.textBoxMultisend2.Size = new System.Drawing.Size(617, 21);
            this.textBoxMultisend2.TabIndex = 3;
            // 
            // buttonMultiSend3
            // 
            this.buttonMultiSend3.Location = new System.Drawing.Point(653, 68);
            this.buttonMultiSend3.Name = "buttonMultiSend3";
            this.buttonMultiSend3.Size = new System.Drawing.Size(44, 23);
            this.buttonMultiSend3.TabIndex = 8;
            this.buttonMultiSend3.Text = "Send";
            this.buttonMultiSend3.UseVisualStyleBackColor = true;
            this.buttonMultiSend3.Click += new System.EventHandler(this.buttonMultiSend3_Click);
            // 
            // checkBoxSend3
            // 
            this.checkBoxSend3.AutoSize = true;
            this.checkBoxSend3.Location = new System.Drawing.Point(8, 71);
            this.checkBoxSend3.Name = "checkBoxSend3";
            this.checkBoxSend3.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSend3.TabIndex = 7;
            this.checkBoxSend3.UseVisualStyleBackColor = true;
            // 
            // textBoxMultisend3
            // 
            this.textBoxMultisend3.Location = new System.Drawing.Point(28, 68);
            this.textBoxMultisend3.Name = "textBoxMultisend3";
            this.textBoxMultisend3.Size = new System.Drawing.Size(617, 21);
            this.textBoxMultisend3.TabIndex = 6;
            // 
            // buttonMultiSend4
            // 
            this.buttonMultiSend4.Location = new System.Drawing.Point(654, 95);
            this.buttonMultiSend4.Name = "buttonMultiSend4";
            this.buttonMultiSend4.Size = new System.Drawing.Size(44, 23);
            this.buttonMultiSend4.TabIndex = 11;
            this.buttonMultiSend4.Text = "Send";
            this.buttonMultiSend4.UseVisualStyleBackColor = true;
            this.buttonMultiSend4.Click += new System.EventHandler(this.buttonMultiSend4_Click);
            // 
            // checkBoxSend4
            // 
            this.checkBoxSend4.AutoSize = true;
            this.checkBoxSend4.Location = new System.Drawing.Point(9, 98);
            this.checkBoxSend4.Name = "checkBoxSend4";
            this.checkBoxSend4.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSend4.TabIndex = 10;
            this.checkBoxSend4.UseVisualStyleBackColor = true;
            // 
            // textBoxMultisend4
            // 
            this.textBoxMultisend4.Location = new System.Drawing.Point(29, 95);
            this.textBoxMultisend4.Name = "textBoxMultisend4";
            this.textBoxMultisend4.Size = new System.Drawing.Size(617, 21);
            this.textBoxMultisend4.TabIndex = 9;
            // 
            // buttonMultiSend5
            // 
            this.buttonMultiSend5.Location = new System.Drawing.Point(653, 122);
            this.buttonMultiSend5.Name = "buttonMultiSend5";
            this.buttonMultiSend5.Size = new System.Drawing.Size(44, 23);
            this.buttonMultiSend5.TabIndex = 14;
            this.buttonMultiSend5.Text = "Send";
            this.buttonMultiSend5.UseVisualStyleBackColor = true;
            this.buttonMultiSend5.Click += new System.EventHandler(this.buttonMultiSend5_Click);
            // 
            // checkBoxSend5
            // 
            this.checkBoxSend5.AutoSize = true;
            this.checkBoxSend5.Location = new System.Drawing.Point(8, 125);
            this.checkBoxSend5.Name = "checkBoxSend5";
            this.checkBoxSend5.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSend5.TabIndex = 13;
            this.checkBoxSend5.UseVisualStyleBackColor = true;
            // 
            // textBoxMultisend5
            // 
            this.textBoxMultisend5.Location = new System.Drawing.Point(28, 122);
            this.textBoxMultisend5.Name = "textBoxMultisend5";
            this.textBoxMultisend5.Size = new System.Drawing.Size(617, 21);
            this.textBoxMultisend5.TabIndex = 12;
            // 
            // SerialComm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 526);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "SerialComm";
            this.Text = "SerialComm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CodeConvert_FormClosing);
            this.Load += new System.EventHandler(this.CodeConvert_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tableLayoutPanelMiddle.ResumeLayout(false);
            this.panelMiddlwLeft.ResumeLayout(false);
            this.panelMiddlwLeft.PerformLayout();
            this.groupBoxCom.ResumeLayout(false);
            this.groupBoxCom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownComSendGap)).EndInit();
            this.tableLayoutPanelMiddleRight.ResumeLayout(false);
            this.tableLayoutPanelMiddleRight.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.tabControlSend.ResumeLayout(false);
            this.tabPageSendOne.ResumeLayout(false);
            this.tabPageSendOne.PerformLayout();
            this.tabPageMultiSend.ResumeLayout(false);
            this.tabPageMultiSend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInsertZero;
        private System.Windows.Forms.Button buttonRemoveZero;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.RadioButton radioButtonHex;
        private System.Windows.Forms.RadioButton radioButtonBit;
        private System.Windows.Forms.RadioButton radioButtonAscii;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonBitMsb;
        private System.Windows.Forms.RadioButton radioButtonBitLsb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.CheckBox checkBoxGap;
        private System.Windows.Forms.TextBox textBoxHdlcFcs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCcittCrc8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCcittCrc16;
        private System.Windows.Forms.Button buttonCalcCrc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxHex;
        private System.Windows.Forms.Button buttonCformatOut;
        private System.Windows.Forms.Button buttonHdlcEncode;
        private System.Windows.Forms.Button buttonHdlcAnalize;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMiddle;
        private System.Windows.Forms.Panel panelMiddlwLeft;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMiddleRight;
        private System.Windows.Forms.TextBox textBoxReceive;
        private System.Windows.Forms.GroupBox groupBoxCom;
        private System.Windows.Forms.ComboBox comboBoxBaudrate;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonComSend;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.NumericUpDown numericUpDownComSendGap;
        private System.Windows.Forms.CheckBox checkBoxComSendContinous;
        private System.Windows.Forms.Button buttonClearReceive;
        private System.Windows.Forms.Button buttonClearSend;
        private System.Windows.Forms.Timer timerSerialSend;
        private System.Windows.Forms.Label labelReceiveCount;
        private System.Windows.Forms.Label labelSendCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxAutoClear;
        private System.Windows.Forms.TabControl tabControlSend;
        private System.Windows.Forms.TabPage tabPageSendOne;
        private System.Windows.Forms.TabPage tabPageMultiSend;
        private System.Windows.Forms.Button buttonMultiSend5;
        private System.Windows.Forms.CheckBox checkBoxSend5;
        private System.Windows.Forms.TextBox textBoxMultisend5;
        private System.Windows.Forms.Button buttonMultiSend4;
        private System.Windows.Forms.CheckBox checkBoxSend4;
        private System.Windows.Forms.TextBox textBoxMultisend4;
        private System.Windows.Forms.Button buttonMultiSend3;
        private System.Windows.Forms.CheckBox checkBoxSend3;
        private System.Windows.Forms.TextBox textBoxMultisend3;
        private System.Windows.Forms.Button buttonMultiSend2;
        private System.Windows.Forms.CheckBox checkBoxSend2;
        private System.Windows.Forms.TextBox textBoxMultisend2;
        private System.Windows.Forms.Button buttonMultiSend1;
        private System.Windows.Forms.CheckBox checkBoxSend1;
        private System.Windows.Forms.TextBox textBoxMultisend1;
    }
}

