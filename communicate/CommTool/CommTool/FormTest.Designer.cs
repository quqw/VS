namespace CommTool
{
    partial class FormTest
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
            this.btnSocketConnect = new System.Windows.Forms.Button();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.textIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numConnectCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.labelConnectCount = new System.Windows.Forms.Label();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.btnSocketDisconnect = new System.Windows.Forms.Button();
            this.timerSend = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConnectCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSocketConnect
            // 
            this.btnSocketConnect.Location = new System.Drawing.Point(383, 38);
            this.btnSocketConnect.Name = "btnSocketConnect";
            this.btnSocketConnect.Size = new System.Drawing.Size(43, 23);
            this.btnSocketConnect.TabIndex = 0;
            this.btnSocketConnect.Text = "连接";
            this.btnSocketConnect.UseVisualStyleBackColor = true;
            this.btnSocketConnect.Click += new System.EventHandler(this.btnSocketConnect_Click);
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(211, 38);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(48, 21);
            this.numPort.TabIndex = 1;
            this.numPort.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(34, 38);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(132, 21);
            this.textIP.TabIndex = 2;
            this.textIP.Text = "192.168.1.185";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "端口：";
            // 
            // numConnectCount
            // 
            this.numConnectCount.Location = new System.Drawing.Point(320, 39);
            this.numConnectCount.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numConnectCount.Name = "numConnectCount";
            this.numConnectCount.Size = new System.Drawing.Size(48, 21);
            this.numConnectCount.TabIndex = 5;
            this.numConnectCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "连接数：";
            // 
            // labelConnectCount
            // 
            this.labelConnectCount.AutoSize = true;
            this.labelConnectCount.Location = new System.Drawing.Point(12, 9);
            this.labelConnectCount.Name = "labelConnectCount";
            this.labelConnectCount.Size = new System.Drawing.Size(11, 12);
            this.labelConnectCount.TabIndex = 7;
            this.labelConnectCount.Text = "0";
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // btnSocketDisconnect
            // 
            this.btnSocketDisconnect.Location = new System.Drawing.Point(432, 38);
            this.btnSocketDisconnect.Name = "btnSocketDisconnect";
            this.btnSocketDisconnect.Size = new System.Drawing.Size(43, 23);
            this.btnSocketDisconnect.TabIndex = 8;
            this.btnSocketDisconnect.Text = "断开";
            this.btnSocketDisconnect.UseVisualStyleBackColor = true;
            this.btnSocketDisconnect.Click += new System.EventHandler(this.btnSocketDisconnect_Click);
            // 
            // timerSend
            // 
            this.timerSend.Enabled = true;
            this.timerSend.Interval = 30000;
            this.timerSend.Tick += new System.EventHandler(this.timerSend_Tick);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 261);
            this.Controls.Add(this.btnSocketDisconnect);
            this.Controls.Add(this.labelConnectCount);
            this.Controls.Add(this.numConnectCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numPort);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSocketConnect);
            this.Name = "FormTest";
            this.Text = "SocketTest";
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConnectCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSocketConnect;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numConnectCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelConnectCount;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Button btnSocketDisconnect;
        private System.Windows.Forms.Timer timerSend;
    }
}

