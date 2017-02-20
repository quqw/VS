using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Timers;
using System.IO.Ports;
//using System.Math;

namespace Pid
{
    public partial class FormMain : Form
    {
        private int startdot;
        private int interval = 1;
        Thread refreshThread;
        Thread serialThread;
        private delegate void FlushClient();//代理
        bool refreshRunning = true;
        Int32[] pidData,outputData;
        DateTime[] pidTime;
        Int32 drawPointsCount=0;
        public Point[] pidPoints;
        Random randomVal = new Random();//随机数产生器
        Graphics graphic;
        private SerialPort comPort;
        private bool serialRunning = false;
        PID pid_calc;
        public FormMain()
        {
            InitializeComponent();
        }


        //窗口加载时调用
        private void FormMain_Load(object sender, EventArgs e)
        {
            //设置控件的样式和行为，以减少图像的闪烁
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.UpdateStyles();
            graphic = pictureBoxPid.CreateGraphics(); //创建画板,这里的画板是由Form提供的.
            pidData = new Int32[] { };
            outputData= new Int32[] { }; 
            pidTime = new DateTime[] { };
            refreshThread = new Thread(refreshPicTask);
            refreshThread.Start();
            hScrollBar.Enabled = true;
            buttonRefresh.PerformClick();
        }



        #region 串口
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (comPort == null)
            {
                if (SerialPort.GetPortNames().Length == 0)
                    return;
                try
                {
                    comPort = new SerialPort();
                    comPort.PortName = comboBoxComPort.Text.Trim();
                    comPort.BaudRate = int.Parse(comboBoxBaudrate.Text.Trim());
                    comPort.ReadTimeout = 50;
                    comPort.Open();
                    serialThread = new Thread(serialReceiveTask);
                    serialRunning = true;
                    serialThread.Start();
                    buttonOpen.Text = "close";
                }
                catch
                {
                    serialRunning = false;
                    Thread.Sleep(200);
                    comPort = null;
                }
            }
            else
            {
                buttonOpen.Enabled = false;
                serialRunning = false;
                Thread.Sleep(200);
                comPort.Close();
                comPort = null;
                buttonOpen.Text = "open";
                buttonOpen.Enabled = true;
            }
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {

            string[] serialNames = SerialPort.GetPortNames(); // 获取所有可用串口的名字
            comboBoxComPort.Items.Clear();
            if (serialNames.Length == 0)
            {
                return;
            }
            comboBoxComPort.Text = serialNames[0];
            for (int i = 0; i < serialNames.Length; i++)
                comboBoxComPort.Items.Add(serialNames[i]);
    }


        private void serialReceiveTask()
        {
            while (serialRunning)
            {
                serialReceiveTick();
                Thread.Sleep(1);
            }
        }
        private void serialReceiveTick()
        {
            int len = 0;
            byte[] receive_buf = new byte[8];
            if (comPort != null && comPort.IsOpen && comPort.BytesToRead > 0)
            {
                try
                {
                    len = comPort.Read(receive_buf, 0, 8);
                    if (len > 0)
                    {
                    }
                }
                catch
                {

                }
            }

        }
        #endregion


        #region 绘图
        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            // startdot = dataBuff.Length / hScrollBar.Maximum * hScrollBar.Value;
            startdot = 50 * hScrollBar.Value / hScrollBar.Maximum;
            Point start = new Point(0, pictureBoxPid.Height);
            graphic.Clear(Color.LightGray);
            SetXAxis(graphic, start, pictureBoxPid.Width, startdot);
            SetYAxis(graphic, start, pictureBoxPid.Height, 0);
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            interval = trackBar.Value+1;
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            refreshRunning = false;
            while (refreshThread.IsAlive)
            {
                Application.DoEvents();
            }
        }
        /// <summary>
        /// 画Y轴
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="start"></param>
        /// <param name="height"></param>
        private void SetYAxis(Graphics g, Point startPoint,int height,int startNum)
        {
           // 注意：Y轴应该是从下往上表数字的，而graphic认为上面是0点
            Pen p1 = new Pen(Color.Goldenrod, 1);
            Pen p2 = new Pen(Color.Black, 2);
            SolidBrush sb = new SolidBrush(Color.Black);

            for (int i = 0; i < height; i ++)//10个像素一个小点
            {
                if (((startNum + i) % 50) == 0)//画粗长线，写数字
                {
                    g.DrawLine(p2,startPoint.X, startPoint.Y - i, startPoint.X+5, startPoint.Y -i);//刻度线
                    g.DrawString((startNum+i).ToString(), new Font("宋体", 8), sb, startPoint.X+7, startPoint.Y - i );
                }
                else if(((startNum + i) % 10) == 0)
                    g.DrawLine(p1, startPoint.X, startPoint.Y  -i, startPoint.X+5, startPoint.Y -i);//小刻度，金黄色，10像素一个

            }
            g.DrawLine(p2, startPoint.X, startPoint.Y , startPoint.X, startPoint.Y - height);//刻度线
        }



        //绘制y轴上的刻度
        private void SetXAxis(Graphics g, Point startPoint,int width,int startNum)
        {
            Pen p1 = new Pen(Color.Goldenrod, 1);
            Pen p2 = new Pen(Color.Black, 2);
            SolidBrush sb = new SolidBrush(Color.Black);
            for (int i = 0; i < width; i ++)
            {
                if ((startNum + i) % 50 == 0)
                {
                    g.DrawLine(p2, startPoint.X + i, startPoint.Y, startPoint.X + i, startPoint.Y - 5);
                    g.DrawString((startNum + i).ToString(), new Font("宋体", 8), sb, startPoint.X + i - 7, startPoint.Y - 17);
                }
                else if ((startNum + i) % 10 == 0)
                {
                    g.DrawLine(p1, startPoint.X + i, startPoint.Y, startPoint.X + i, startPoint.Y - 5);
                }
            }
            g.DrawLine(p2,  startPoint.X, startPoint.Y, startPoint.X+width, startPoint.Y);//刻度线
        }
        private void drawLines(Point[] points)
        {
            Pen pen = new Pen(Color.Navy, 1);//画笔
            for(int i=1;i<points.Length;i++)
                graphic.DrawLine(pen, points[i-1].X, pictureBoxPid.Height - points[i-1].Y, points[i].X, pictureBoxPid.Height - points[i].Y);//y
        }


        private void pushDots(UInt32 val)
        {

        }

        private void apandDots()
        {
            if (pidData.Length <= drawPointsCount || pidData.Length<=1)
                return;
            int endIndex;
            Point[] points;
            lock (pidData)
            {
                endIndex = pidData.Length;
                int pointIndex = 0;
                
                TimeSpan timeSpan;
                if (drawPointsCount == 0)
                {
                    points = new Point[endIndex - drawPointsCount];
                }
                else
                {
                    points = new Point[endIndex - drawPointsCount + 1];
                    timeSpan = pidTime[drawPointsCount - 1] - pidTime[0];
                    points[pointIndex].X = (int)timeSpan.TotalMilliseconds / 100;
                    points[pointIndex].Y = pidData[drawPointsCount - 1];
                    pointIndex++;
                }
                for (int i = drawPointsCount; i < endIndex; i++)
                {
                    timeSpan = pidTime[i] - pidTime[0];
                    points[pointIndex].X = (int)timeSpan.TotalMilliseconds / 100;
                    points[pointIndex].Y = pidData[i];
                    pointIndex++;
                }
                drawPointsCount += endIndex - drawPointsCount;
            }
            drawLines(points);
        }
        private void refreshPicTask()
        {
            while(refreshRunning)
            {
                if (pictureBoxPid.InvokeRequired)//等待异步
                {
                    FlushClient fc = new FlushClient(apandDots);
                    pictureBoxPid.Invoke(fc);//通过代理调用刷新方法
                    Thread.Sleep(100);
                }
                else
                    apandDots();
            }
        }
        #endregion

        private void buttonPidStart_Click(object sender, EventArgs e)
        {
            Point start = new Point(0, pictureBoxPid.Height);
            graphic.Clear(Color.LightGray);
            SetXAxis(graphic, start, pictureBoxPid.Width, startdot);
            SetYAxis(graphic, start, pictureBoxPid.Height, 0);
            Pen pen = new Pen(Color.Crimson, 1);//画笔
            graphic.DrawLine(pen,0, pictureBoxPid.Height- Convert.ToInt32(numPidTarget.Value),
                pictureBoxPid.Width, pictureBoxPid.Height - Convert.ToInt32(numPidTarget.Value));//刻度线
            timerSimulatePid.Stop();
            lock(pidData)
            {
                Array.Resize(ref pidData, 0);
                Array.Resize(ref pidTime, 0);
                drawPointsCount = 0;
            }
            pid_calc = new PID(0,Convert.ToDouble( numPidTarget.Value),
                Convert.ToDouble(numKp.Value), Convert.ToDouble(numKi.Value),
                Convert.ToDouble(numKd.Value), PID.DIRECT);
            pid_calc.SetMode(PID.AUTOMATIC);
            timerSimulatePid.Start();
        }

        private void timerSimulatePid_Tick(object sender, EventArgs e)
        {
            simulatePid();
        }
        private DateTime last_time = DateTime.FromBinary(0);
        private void simulatePid()
        {
            if (last_time.Equals(DateTime.FromBinary(0)))
                last_time = DateTime.Now;
            TimeSpan span = DateTime.Now - last_time;
            last_time = DateTime.Now;
            
            lock (pidData)
            {
                int index = pidData.Length;
                Array.Resize(ref pidData, index + 1);
                Array.Resize(ref pidTime, index + 1);
                Array.Resize(ref outputData, index + 1);

                if (index == 0)
                {
                    pidData[index] = 0;
                    outputData[index] = (int)pid_calc.Compute(0, 100);
                }
                else
                {
                    pidData[index] = (int)outputData[index - 1] * 2;
                    outputData[index] = (int)pid_calc.Compute(pidData[index], 100);
                }
                pidTime[index] = DateTime.Now;
            }
        }
    }
}