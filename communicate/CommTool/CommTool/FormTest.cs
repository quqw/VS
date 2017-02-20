using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace CommTool
{
    public partial class FormTest : Form
    {
        private List<Socket> client_list;
        private bool connect;
        private int send_count;
        public FormTest()
        {
            InitializeComponent();
            client_list = new List<Socket>();
            timerRefresh.Start();
            connect = false;
            send_count = 0;
        }


        private void btnSocketConnect_Click(object sender, EventArgs e)
        {
            if (textIP.Text.Trim().Length < 5)
                return;
            int i, client_count;
            connect = true;
            client_count = Convert.ToInt16(numConnectCount.Value);
            IPAddress ip = IPAddress.Parse(textIP.Text.Trim());
            IPEndPoint iep = new IPEndPoint(ip, Convert.ToInt16(numPort.Value));
            for (i = 0; i < client_count; i++)
            {
                
                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                client.BeginConnect(iep, new AsyncCallback(Connect), client);
            }
        }
        private void Connect(IAsyncResult asy)
        {
            Socket client = (Socket)asy.AsyncState;
            try
            {
                client.EndConnect(asy);
                client.Send(Encoding.ASCII.GetBytes("hello"));
                client_list.Add(client);
            }
            catch (Exception ee)
            {
                
            }
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            labelConnectCount.Text = client_list.Count.ToString();
        }
        private void SendCallback(IAsyncResult asy)
        {
            Socket handler = (Socket)asy.AsyncState;
            //try
            //{
                // Complete sending the data to the remote device.     
                int bytesSent = handler.EndSend(asy);
            send_count++;
            if(send_count%100==0)
                Console.WriteLine("{0} ", send_count);
            //}
            //catch (Exception ee)
            //{
            //    handler.Shutdown(SocketShutdown.Both);
            //    handler.Close();
            //    client_list.Remove(handler);
            //}
        }

        private void btnSocketDisconnect_Click(object sender, EventArgs e)
        {
            btnSocketConnect.Enabled = false;
            btnSocketDisconnect.Text = "Wait";
            btnSocketDisconnect.Enabled = false;
            connect = false;
            timerSend.Interval = 100;
        }

        private void timerSend_Tick(object sender, EventArgs e)
        {
            if (!connect)
            {
                timerSend.Interval = 30000;
                foreach (Socket client in client_list)
                {
                    client.Shutdown(SocketShutdown.Both);
                    client.Close();
                }
                client_list.Clear();
                btnSocketConnect.Enabled = true;
                btnSocketDisconnect.Enabled = true;
                btnSocketDisconnect.Text = "断开";
                send_count = 0;
            }
            else
            {
                timerSend.Stop();
                Console.WriteLine("start send");
                foreach (Socket client in client_list)
                {
                    if(client!=null)
                        client.BeginSend(Encoding.ASCII.GetBytes("hello"), 0, 5, SocketFlags.None, new AsyncCallback(SendCallback), client);
                }
                timerSend.Start();
            }
        }
    }
}
