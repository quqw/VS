using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace 实时曲线绘制
{
    class draw
    {


        public Bitmap mybitmap;//用于双缓冲的位图，和画布等大

        Random rm = new Random();//随机数产生器


        public void DrawLineS(int dotno, PictureBox picbox, Point[] ptxlist, Point[] ptylist, Point[] ptzlist)
        {
            mybitmap = new Bitmap(picbox.Width, picbox.Height);//设定位图大小
            Graphics doublebufferg = Graphics.FromImage(mybitmap);//从位图上获取“画布”
            doublebufferg.Clear(Color.White);//用背景色刷新

            //pictureBox1填充为白色，便于显示图像  500*300
            Rectangle rect = new Rectangle(0, 0, picbox.Width, picbox.Height);
            doublebufferg.FillRectangle(new SolidBrush(Color.White), rect);


            //画X和Y轴
            DrawXY(ref doublebufferg, picbox);
            //X轴上的刻度
            SetYAxis(ref doublebufferg, picbox);
            //Y轴上的刻度
            SetXAxis(ref doublebufferg, picbox);
            if (ptxlist!=null)
                doublebufferg.DrawLines(new Pen(Color.Blue, 1), ptxlist);
            if (ptylist != null)
                doublebufferg.DrawLines(new Pen(Color.Red, 1), ptylist);
            if (ptzlist != null)
                doublebufferg.DrawLines(new Pen(Color.Black, 1), ptzlist);
            //将缓冲中的位图绘制到我们的窗体上
            Graphics g1 = picbox.CreateGraphics();//创建 PictureBox窗体的画布

            g1.Clear(Color.White);
            g1.DrawImage(mybitmap, 0, 0);

        }

        public void DrawLineS(Color linecolor, int dotno, PictureBox picbox, Point[] ptlist)
        {
            mybitmap = new Bitmap(picbox.Width, picbox.Height);//设定位图大小
            Graphics doublebufferg = Graphics.FromImage(mybitmap);//从位图上获取“画布”
            doublebufferg.Clear(Color.White);//用背景色刷新

            //pictureBox1填充为白色，便于显示图像  500*300
            Rectangle rect = new Rectangle(0, 0, picbox.Width, picbox.Height);
            doublebufferg.FillRectangle(new SolidBrush(Color.White), rect);


            //画X和Y轴
            DrawXY(ref doublebufferg, picbox);
            //X轴上的刻度
            SetYAxis(ref doublebufferg, picbox);
            //Y轴上的刻度
            SetXAxis(ref doublebufferg, picbox);

            doublebufferg.DrawLines(new Pen(linecolor, 1), ptlist);
            //将缓冲中的位图绘制到我们的窗体上
            Graphics g1 = picbox.CreateGraphics();//创建 PictureBox窗体的画布

            g1.Clear(Color.White);
            g1.DrawImage(mybitmap, 0, 0);

        }

        //完成X轴和Y轴的基本部分
        public void DrawXY(ref Graphics g, PictureBox picbox)
        {
            Pen pen = new Pen(Color.Black, 2);//画笔
            SolidBrush sb = new SolidBrush(Color.Black);//话刷

            //X轴的箭头，实际上是绘制了一个三角形
            //g.DrawLine(pen, 30, picbox.Height - 30, picbox.Width - 30, picbox.Height - 30);

            //g.DrawLine(pen, 100, picbox.Height, 100, 0);//y


        }


        //绘制Y轴上的刻度
        public void SetYAxis(ref Graphics g, PictureBox picbox)
        {
            Pen p1 = new Pen(Color.Goldenrod, 1);
            Pen p2 = new Pen(Color.Black, 2);
            SolidBrush sb = new SolidBrush(Color.Black);

            for (int i = 0; i < picbox.Height; i += 10)//10个像素一个小点
            {
                if ((i % 50) == 0)
                {
                    g.DrawLine(p2, 27, i, 33, i);//刻度线
                    string tempy = i.ToString();
                    g.DrawString(tempy, new Font("宋体", 8), sb, 7, i - 5);
                }
                else
                    g.DrawLine(p1, 27, i, 33, i);//小刻度，金黄色，10像素一个

            }
            g.DrawLine(p2, 27, picbox.Height, 33, picbox.Height);//刻度线
            g.DrawString(picbox.Height.ToString(), new Font("宋体", 8), sb, 7, picbox.Height - 5);
        }



        //绘制y轴上的刻度
        public void SetXAxis(ref Graphics g, PictureBox picbox)
        {
            Pen p1 = new Pen(Color.Goldenrod, 1);
            Pen p2 = new Pen(Color.Black, 2);
            SolidBrush sb = new SolidBrush(Color.Black);

            float xt = 30, yt = picbox.Height - 33, xb = 30, yb = picbox.Height - 27;

            for (int i = 0; i < picbox.Width - 60; i += 10)
            {
                if (i % 50 == 0)
                {
                    g.DrawLine(p2, 30 + i, yt, 30 + i, yb);
                    string tempx = (i).ToString();
                    g.DrawString(tempx, new Font("宋体", 8), sb, 30 + i - 7, picbox.Height - 25);
                }
                else { g.DrawLine(p1, xt + i, yt, xb + i, yb); }
            }
            g.DrawLine(p2, 27, picbox.Width - 60, 33, picbox.Width - 60);//刻度线
            g.DrawString((picbox.Width - 60).ToString(), new Font("宋体", 8), sb, 7, picbox.Width - 60 - 5);
        }
    }
}

