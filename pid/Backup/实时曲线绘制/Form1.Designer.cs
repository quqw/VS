namespace 实时曲线绘制
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxX = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtBox_FileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxY = new System.Windows.Forms.PictureBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.percent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "实时曲线";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxX
            // 
            this.pictureBoxX.Location = new System.Drawing.Point(12, 53);
            this.pictureBoxX.Name = "pictureBoxX";
            this.pictureBoxX.Size = new System.Drawing.Size(1000, 200);
            this.pictureBoxX.TabIndex = 1;
            this.pictureBoxX.TabStop = false;
            // 
            // txtBox_FileName
            // 
            this.txtBox_FileName.Location = new System.Drawing.Point(190, 10);
            this.txtBox_FileName.Name = "txtBox_FileName";
            this.txtBox_FileName.Size = new System.Drawing.Size(122, 21);
            this.txtBox_FileName.TabIndex = 2;
            this.txtBox_FileName.Text = "q";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "文件名：";
            // 
            // pictureBoxY
            // 
            this.pictureBoxY.Location = new System.Drawing.Point(12, 259);
            this.pictureBoxY.Name = "pictureBoxY";
            this.pictureBoxY.Size = new System.Drawing.Size(1000, 200);
            this.pictureBoxY.TabIndex = 4;
            this.pictureBoxY.TabStop = false;
            // 
            // trackBar
            // 
            this.trackBar.LargeChange = 1;
            this.trackBar.Location = new System.Drawing.Point(352, 4);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(133, 45);
            this.trackBar.TabIndex = 6;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // hScrollBar
            // 
            this.hScrollBar.Enabled = false;
            this.hScrollBar.Location = new System.Drawing.Point(488, 9);
            this.hScrollBar.Maximum = 1000;
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(463, 17);
            this.hScrollBar.TabIndex = 7;
            this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Scroll);
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.Location = new System.Drawing.Point(971, 12);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(11, 12);
            this.percent.TabIndex = 8;
            this.percent.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "X：蓝（正→负←） Y：红（正↓负↑） Z：黑（正前负后）";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 473);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.hScrollBar);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.pictureBoxY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_FileName);
            this.Controls.Add(this.pictureBoxX);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxX;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtBox_FileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxY;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.Label percent;
        private System.Windows.Forms.Label label2;
    }
}

