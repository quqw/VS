using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
//using System.Math;

namespace 实时曲线绘制
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Point[] ptxlist, ptzlist, ptylist,ptlistcomb;//存放点的数组
        Random rm = new Random();//随机数产生器
        Timer mytimer = new Timer();//定时器

        //窗口加载时调用
        private void Form1_Load(object sender, EventArgs e)
        {
            //设置控件的样式和行为，以减少图像的闪烁
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.UpdateStyles();


          
       }
        draw drawtest = new draw();//创建类 draw 的实例
        private byte[] dataBuff;
        private int dotno;//点的个数
        private int startdot;
        private int interval=1;
        private void button1_Click(object sender, EventArgs e)
        {
            //读取文件
            if(this.txtBox_FileName.Text.Trim().Length==0)
                return;
            FileStream fs = File.OpenRead(this.txtBox_FileName.Text.Trim());
            dataBuff = new byte[65536];
            int offset = 0;
            int remaining = (int)fs.Length;
            dotno = remaining / 3;
            // 只要有剩余的字节就不停的读
            while (remaining > 0)
            {
                int read = fs.Read(dataBuff, offset, remaining);
                if (read <= 0)
                    throw new EndOfStreamException("文件读取到" + read.ToString() + "失败！");
                remaining -= read;// 减少剩余的字节数      
                offset += read;// 增加偏移量
            }
            drawpic(0);
            hScrollBar.Enabled = true;
        }

        private void drawpic(int startdot)
        {
            int datano;

            Point pt;
            pt = new Point();
            if (dotno > pictureBoxX.Width)
            {
                //interval =2;
                datano = pictureBoxX.Width;
                ptxlist = new Point[pictureBoxX.Width];//每4字节为一组
                ptylist = new Point[pictureBoxX.Width];//每4字节为一组
                ptzlist = new Point[pictureBoxX.Width];//每4字节为一组
                ptlistcomb = new Point[pictureBoxX.Width];
            }
            else
            {
                ptxlist = new Point[dotno];//每4字节为一组
                ptylist = new Point[dotno];//每4字节为一组
                ptzlist = new Point[dotno];//每4字节为一组
                ptlistcomb = new Point[dotno];
                //interval = pictureBoxX.Width / dotno;
                datano = dotno;
            }

            for (int i = 0; i < datano; i++)//添加点阵数据
            {

                pt.X = interval * i;
                pt.Y = (sbyte)dataBuff[3 * i + startdot] + this.pictureBoxX.Height / 2;
                ptxlist[i] = pt;

                pt.X = interval * i;
                pt.Y = (sbyte)dataBuff[3 * i + 1 + startdot] + this.pictureBoxX.Height / 2;
                ptylist[i] = pt;

                pt.X = interval * i;
                pt.Y = (sbyte)dataBuff[3 * i + 2 + startdot] + this.pictureBoxX.Height / 2;
                ptzlist[i] = pt;

                pt.X = interval * i;
                /*合加速度*/
                 int lastY;
                 pt.Y = ((int)Math.Sqrt((sbyte)dataBuff[3 * i + startdot] * (sbyte)dataBuff[3 * i + startdot] +
                    ((sbyte)dataBuff[3 * i + 1 + startdot]) * ((sbyte)dataBuff[3 * i + 1 + startdot]) +
                    (sbyte)dataBuff[3 * i + 2 + startdot] * (sbyte)dataBuff[3 * i + 2 + startdot]))-(1000/18);// (int)this.pictureBoxY.Height / 2; //和加速度
                //pt.Y = ((int)Math.Sqrt((sbyte)dataBuff[3 * (i+1) + startdot] * (sbyte)dataBuff[3 * (i+1) + startdot] +
                //     ((sbyte)dataBuff[3 * (i+1) + 1 + startdot]) * ((sbyte)dataBuff[3 * (i+1) + 1 + startdot]) +
                //     (sbyte)dataBuff[3 * (i+1) + 2 + startdot] * (sbyte)dataBuff[3 * (i+1) + 2 + startdot])) - lastY+100;

                
                /*变化率*/
                //pt.Y = ((sbyte)dataBuff[3 * (i + 1) + startdot] - (sbyte)dataBuff[3 * i + startdot]);
                //if (pt.Y < 10 && pt.Y > -10) pt.Y = 0;
                //pt.Y += 100;

               // pt.Y = Math.Abs((sbyte)dataBuff[3 * i + startdot]) +Math.Abs((sbyte)dataBuff[3 * i + 2 + startdot]) + 150;



                ptlistcomb[i] = pt;

            }

            drawtest.DrawLineS(datano, pictureBoxX, ptxlist, null, null);
            drawtest.DrawLineS(Color.Blue, dotno, pictureBoxY, ptlistcomb);
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {  
            //调用绘图函数,这里的参数可以根据不同的测量给定不同的实参
            //drawtest.DrawLineS(Color.Blue, 1200, 600, pictureBox1, ptlist);
            
        }

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            
            startdot = dotno / hScrollBar.Maximum * hScrollBar.Value;
            startdot -= startdot % 3;
            drawpic(startdot);

        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            interval = trackBar.Value+1;
            drawpic(startdot);
        }
    }
}