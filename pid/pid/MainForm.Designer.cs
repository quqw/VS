namespace Pid
{
    partial class FormMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxPid = new System.Windows.Forms.PictureBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.comboBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonPidStart = new System.Windows.Forms.Button();
            this.timerSimulatePid = new System.Windows.Forms.Timer(this.components);
            this.numPidTarget = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numKp = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numKi = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numKd = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPidTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKd)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPid
            // 
            this.pictureBoxPid.Location = new System.Drawing.Point(12, 53);
            this.pictureBoxPid.Name = "pictureBoxPid";
            this.pictureBoxPid.Size = new System.Drawing.Size(1003, 529);
            this.pictureBoxPid.TabIndex = 1;
            this.pictureBoxPid.TabStop = false;
            // 
            // trackBar
            // 
            this.trackBar.LargeChange = 1;
            this.trackBar.Location = new System.Drawing.Point(759, -1);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(256, 45);
            this.trackBar.TabIndex = 6;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // hScrollBar
            // 
            this.hScrollBar.Enabled = false;
            this.hScrollBar.Location = new System.Drawing.Point(12, 585);
            this.hScrollBar.Maximum = 1000;
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(1003, 17);
            this.hScrollBar.TabIndex = 7;
            this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Scroll);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(122, 4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(49, 23);
            this.buttonRefresh.TabIndex = 40;
            this.buttonRefresh.Text = "刷新";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // comboBoxBaudrate
            // 
            this.comboBoxBaudrate.FormattingEnabled = true;
            this.comboBoxBaudrate.Items.AddRange(new object[] {
            "9600",
            "57600",
            "115200"});
            this.comboBoxBaudrate.Location = new System.Drawing.Point(56, 29);
            this.comboBoxBaudrate.Name = "comboBoxBaudrate";
            this.comboBoxBaudrate.Size = new System.Drawing.Size(77, 20);
            this.comboBoxBaudrate.TabIndex = 36;
            this.comboBoxBaudrate.Text = "9600";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(177, 4);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(59, 23);
            this.buttonOpen.TabIndex = 39;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(56, 6);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(59, 20);
            this.comboBoxComPort.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 38;
            this.label8.Text = "波特率";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 37;
            this.label7.Text = "串口";
            // 
            // buttonPidStart
            // 
            this.buttonPidStart.Location = new System.Drawing.Point(281, 6);
            this.buttonPidStart.Name = "buttonPidStart";
            this.buttonPidStart.Size = new System.Drawing.Size(75, 23);
            this.buttonPidStart.TabIndex = 41;
            this.buttonPidStart.Text = "模拟PID开始";
            this.buttonPidStart.UseVisualStyleBackColor = true;
            this.buttonPidStart.Click += new System.EventHandler(this.buttonPidStart_Click);
            // 
            // timerSimulatePid
            // 
            this.timerSimulatePid.Tick += new System.EventHandler(this.timerSimulatePid_Tick);
            // 
            // numPidTarget
            // 
            this.numPidTarget.Location = new System.Drawing.Point(418, 7);
            this.numPidTarget.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPidTarget.Name = "numPidTarget";
            this.numPidTarget.Size = new System.Drawing.Size(62, 21);
            this.numPidTarget.TabIndex = 42;
            this.numPidTarget.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(370, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 43;
            this.label1.Text = "目标值";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 45;
            this.label2.Text = "P";
            // 
            // numKp
            // 
            this.numKp.DecimalPlaces = 2;
            this.numKp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numKp.Location = new System.Drawing.Point(511, 8);
            this.numKp.Name = "numKp";
            this.numKp.Size = new System.Drawing.Size(49, 21);
            this.numKp.TabIndex = 44;
            this.numKp.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 47;
            this.label3.Text = "I";
            // 
            // numKi
            // 
            this.numKi.DecimalPlaces = 2;
            this.numKi.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numKi.Location = new System.Drawing.Point(591, 8);
            this.numKi.Name = "numKi";
            this.numKi.Size = new System.Drawing.Size(47, 21);
            this.numKi.TabIndex = 46;
            this.numKi.Value = new decimal(new int[] {
            8,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 49;
            this.label4.Text = "D";
            // 
            // numKd
            // 
            this.numKd.DecimalPlaces = 2;
            this.numKd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numKd.Location = new System.Drawing.Point(666, 9);
            this.numKd.Name = "numKd";
            this.numKd.Size = new System.Drawing.Size(47, 21);
            this.numKd.TabIndex = 48;
            this.numKd.Value = new decimal(new int[] {
            7,
            0,
            0,
            131072});
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 611);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numKd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numKi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numKp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numPidTarget);
            this.Controls.Add(this.buttonPidStart);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.comboBoxBaudrate);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.comboBoxComPort);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hScrollBar);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.pictureBoxPid);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPidTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxPid;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ComboBox comboBoxBaudrate;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonPidStart;
        private System.Windows.Forms.Timer timerSimulatePid;
        private System.Windows.Forms.NumericUpDown numPidTarget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numKp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numKi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numKd;
    }
}

