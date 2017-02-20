using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace SerialComm
{

    public partial class SerialComm : Form
    {
        const Byte CODE_HEX = 0;
        const Byte CODE_ASCII = 1;
        const Byte CODE_BIT = 2;

        const Byte BIT_LSB_FIRST = 0;
        const Byte BIT_MSB_FIRST = 1;
        private Byte currentCode;
        private Byte currentBitOrder;
        private SerialPort comPort;
        private byte[] receiveBytes;
        private int receiveShowCount = 0;
        Thread serialThread;
        private bool serialRunning=false;
        private delegate void FlushClient();//代理
        DateTime laseTime;
        private int sendCount,receiveCount;

        public SerialComm()
        {
            currentCode = CODE_HEX;
            currentBitOrder = BIT_MSB_FIRST;
            InitializeComponent();
            radioButtonBitMsb.Checked = true;
            radioButtonHex.Checked = true;
            comPort = null;
            receiveBytes = new byte[] { };
            
        }
        private void CodeConvert_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            laseTime = DateTime.Now;
            string[] serialNames = SerialPort.GetPortNames(); // 获取所有可用串口的名字
            if (serialNames.Length == 0)
                return;
            comboBoxComPort.Text = serialNames[0];
            for (int i = 0; i < serialNames.Length; i++)
                comboBoxComPort.Items.Add(serialNames[i]);
            sendCount = 0;
            receiveCount = 0;
        }

        private void radioButtonHex_CheckedChanged(object sender, EventArgs e)
        {
            string gap;
            if (checkBoxGap.Checked)
                gap = " ";
            else gap = "";
            if (radioButtonHex.Checked != true || currentCode == CODE_HEX)
                return;
            Byte[] data = getInputBytes();
            currentCode = CODE_HEX;
            if (data == null)
                return;
            textBoxInput.Text = Assist.ToHexString(data, gap);

        }

        private void radioButtonAscii_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAscii.Checked != true || CODE_ASCII == currentCode)
                return;
            Byte[] data = getInputBytes();
            currentCode = CODE_ASCII;
            if (data == null)
                return;
            textBoxInput.Text = System.Text.Encoding.Default.GetString(data);

        }

        private void radioButtonBit_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBit.Checked != true || currentCode == CODE_BIT)
                return;
            Byte[] data = getInputBytes();
            currentCode = CODE_BIT;
            if (data == null)
                return;
            string gap;
            if (checkBoxGap.Checked)
                gap = " ";
            else gap = "";
            if (radioButtonBitLsb.Checked)
                textBoxInput.Text = Assist.BytesToBitsLsbString(data, gap);
            else
                textBoxInput.Text = Assist.BytesToBitsMsbString(data, gap);

        }
        byte[] getInputBytes()
        {
            string str = textBoxInput.Text.Trim();
            return getBytes(str);
        }

        byte[] getBytes(string str)
        {
            Byte[] data;
            if (str.Length > 0)
            {
                switch (currentCode)
                {
                    case CODE_BIT:
                        {
                            foreach (char c in str)
                            {
                                if (c != '1' && c != '0' && c != ' ' && c != '\r' && c != '\n')
                                {
                                    return null;
                                }
                            }
                            if (currentBitOrder == BIT_LSB_FIRST)
                                data = Assist.BitsLsbToBytes(str);
                            else
                                data = Assist.BitsMsbToBytes(str);
                        }
                        break;
                    case CODE_HEX:
                        {
                            foreach (char c in str)
                            {
                                if ((c < '0' || c > '9') && (c < 'a' || c > 'f') && (c < 'A' || c > 'F') && c != ' ' && c != '\r' && c != '\n')
                                {

                                    return null;
                                }
                            }
                            data = Assist.HexToBytes(str);
                        }
                        break;
                    case CODE_ASCII:
                    default:
                        data = System.Text.Encoding.ASCII.GetBytes(textBoxInput.Text.Trim());
                        break;
                }
                return data;
            }
            return null;
        }


        private void buttonInsertZero_Click(object sender, EventArgs e)
        {
            string gap;
            if (checkBoxGap.Checked)
                gap = " ";
            else gap = "";
            byte[] data = getInputBytes();
            if (data == null)
                return;
            BitArray new_bits = Assist.HdlcInsertZeroEncode(data);
            byte[] new_data = Assist.BitsLsbToBytes(new_bits);
            textBoxInput.Text = Assist.BytesToBitsLsbString(new_data, gap);
            currentCode = CODE_BIT;
            currentBitOrder = BIT_LSB_FIRST;
            radioButtonBitLsb.Checked = true;//注意这里引起bit显示触发
            radioButtonBit.Checked = true;
        }

        private void buttonRemoveZero_Click(object sender, EventArgs e)
        {


        }

        private void radioButtonBitLsb_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBitLsb.Checked == false && radioButtonBit.Checked == true)
                return;
            byte[] data = getInputBytes();
            currentBitOrder = BIT_LSB_FIRST;
            if (data == null)
                return;
            string gap;
            if (checkBoxGap.Checked)
                gap = " ";
            else gap = "";
            textBoxInput.Text = Assist.BytesToBitsLsbString(data, gap);
            currentCode = CODE_BIT;
            radioButtonBit.Checked = true;//注意这里会引起bit显示事件
        }

        private void radioButtonBitMsb_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBitMsb.Checked == false && radioButtonBit.Checked == true)
                return;
            byte[] data = getInputBytes();
            currentBitOrder = BIT_MSB_FIRST;
            if (data == null)
                return;
            string gap;
            if (checkBoxGap.Checked)
                gap = " ";
            else gap = "";
            textBoxInput.Text = Assist.BytesToBitsMsbString(data, gap);
            currentCode = CODE_BIT;
            radioButtonBit.Checked = true; ;

        }

        private void checkBoxGap_CheckedChanged(object sender, EventArgs e)
        {

        }
        void showCrc(byte[] data)
        {
            ushort hdlc_crc = Assist.HdlcFcs16(data);
            byte crc8 = Assist.Crc8Ccitt(data);
            textBoxHdlcFcs.Text = hdlc_crc.ToString("X04");
            textBoxCcittCrc8.Text = crc8.ToString("X02");
        }
        void clearCrc()
        {
            textBoxHdlcFcs.Text = "";
        }
        private void buttonCalcCrc_Click(object sender, EventArgs e)
        {
            byte[] data = getInputBytes();
            if (data == null)
                clearCrc();
            else
                showCrc(data);
        }

        private void textBoxDec_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDec.Focused != true)
                return;
            string dec_str = textBoxDec.Text.Trim();
            if (dec_str.Length == 0)
            {
                textBoxHex.Text = "";
                textBoxBin.Text = "";
                return;
            }
            foreach (char c in dec_str)
            {
                if (c < '0' || c > '9')
                {
                    textBoxHex.Text = "";
                    textBoxBin.Text = "";
                    return;
                }
            }
            long val = Convert.ToInt64(dec_str);
            textBoxHex.Text = val.ToString("X");
            textBoxBin.Text = Convert.ToString(val, 2);
        }

        private void textBoxDec_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxHex.Text = "";
            textBoxBin.Text = "";
            textBoxDec.Text = "";
        }

        private void textBoxHex_TextChanged(object sender, EventArgs e)
        {
            if (textBoxHex.Focused != true)
                return;
            string dec_str = textBoxHex.Text.Trim();
            if (dec_str.Length == 0)
            {
                textBoxDec.Text = "";
                textBoxBin.Text = "";
                return;
            }
            foreach (char c in dec_str)
            {
                if ((c < '0' || c > '9') && (c < 'a' || c > 'f') && (c < 'A' || c > 'F'))
                {
                    textBoxDec.Text = "";
                    textBoxBin.Text = "";
                    return;
                }
            }
            long val = Convert.ToInt64(dec_str, 16);
            textBoxBin.Text = Convert.ToString(val, 2);
            textBoxDec.Text = Convert.ToString(val, 10);
        }

        private void textBoxBin_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBin.Focused != true)
                return;
            string bin_str = textBoxBin.Text.Trim();
            if (bin_str.Length == 0)
            {
                textBoxDec.Text = "";
                textBoxHex.Text = "";
                return;
            }
            foreach (char c in bin_str)
            {
                if (c != '1' && c != '0')
                {
                    textBoxHex.Text = "";
                    textBoxDec.Text = "";
                    return;
                }
            }
            long val = Convert.ToInt64(bin_str, 2);
            textBoxHex.Text = String.Format("{0:X}", val);
            textBoxDec.Text = Convert.ToString(val, 10);
        }

        private void buttonCformatOut_Click(object sender, EventArgs e)
        {
            byte[] data = getInputBytes();
            if (data == null)
                return;
            StringBuilder strB = new StringBuilder();
            strB.Append('{');
            foreach (byte b in data)
            {
                strB.Append(String.Format("0x{0:X02},", b));
            }
            strB.Remove(strB.Length - 1, 1);
            strB.Append('}');
            textBoxInput.Text = strB.ToString();
        }

        private void buttonHdlcEncode_Click(object sender, EventArgs e)
        {
            string gap;
            if (checkBoxGap.Checked)
                gap = " ";
            else gap = "";
            byte[] data;
            data = getInputBytes();
            if (data == null)
                return;
            byte[] hdlc = Assist.HdlcEncode(data);
            textBoxInput.Text = Assist.ToHexString(hdlc, gap);
            currentCode = CODE_HEX;
            radioButtonHex.Checked = true;

        }

        string parse_hdlc_bytes(byte[] hdlc_bytes)
        {
            const byte CTRL_U_FRAME_SNRM = 0x10;	//置正常响应模式
            const byte CTRL_U_FRAME_SARM_DM = 0x03;	//置异步响应模式/断开方式
            const byte CTRL_U_FRAME_SABM = 0x07;	//置异步平衡模式
            const byte CTRL_U_FRAME_SNRME = 0x1B;	//置扩充正常响应模式
            const byte CTRL_U_FRAME_SARME = 0x0b;	//置扩充异步响应模式
            const byte CTRL_U_FRAME_SABME = 0x0f;	//置扩充异步平衡模式
            const byte CTRL_U_FRAME_DISC_RD = 0x08;	//断链/请求断链
            const byte CTRL_U_FRAME_SIM_RIM = 0x01;	//置初始化方式/请求初始化方式
            const byte CTRL_U_FRAME_UP = 0x04;	//无编号探询
            const byte CTRL_U_FRAME_UI = 0x00;	//无编号信息
            const byte CTRL_U_FRAME_XID = 0x17;	//交换识别
            const byte CTRL_U_FRAME_RESET = 0x13;	//复位
            const byte CTRL_U_FRAME_FRMR = 0x11;	//帧拒绝
            const byte CTRL_U_FRAME_UA = 0x0C;	//无编号确认
            string show_info = "地址:0x{0:X02}\r\n" +
                "类型:{1}帧   CTRL:0x{2:X02}   {3}";
            byte[] hdlc = Assist.HdlcDecode(hdlc_bytes);
            if (hdlc == null)
                return string.Empty;
            byte ctrl = hdlc[1];
            string frame_type;
            string frame_ctrl_info;
            if ((ctrl & 0x01) == 0)
            {
                int ns = (ctrl & 0x0e) >> 1;
                int nr = (ctrl & 0xe0) >> 5;
                frame_type = "I";
                frame_ctrl_info = string.Format("N(S)={0},N(R)={1}", ns, nr);
            }
            else if ((ctrl & 0x03) == 1)
            {
                byte s = (byte)((ctrl & 0x0C) >> 2);
                frame_type = "S";
                string type;
                switch (s)
                {
                    case 0:
                        type = "RR";
                        break;
                    case 1:
                        type = "RNR";
                        break;
                    case 2:
                        type = "REJ";
                        break;
                    case 3:
                    default:
                        type = "SREJ";
                        break;
                }
                frame_ctrl_info = string.Format("S={0}({1}),N(R)={2}", s, type, (ctrl & 0xe0) >> 5);
            }
            else
            {
                frame_type = "U";
                byte cmd = (byte)((((ctrl) & 0xE0) >> 3) | (((ctrl) & 0x0c) >> 2));
                frame_ctrl_info = string.Format("CMD=0x{0:X02} ", cmd);
                switch (cmd)

                {
                    case CTRL_U_FRAME_SNRM:
                        frame_ctrl_info += "SNRM";
                        break;
                    case CTRL_U_FRAME_SARM_DM:
                        frame_ctrl_info += "SARM_DM";
                        break;
                    case CTRL_U_FRAME_SABM:
                        frame_ctrl_info += "SABM";
                        break;
                    case CTRL_U_FRAME_SNRME:
                        frame_ctrl_info += "SNRME";
                        break;
                    case CTRL_U_FRAME_SARME:
                        frame_ctrl_info += "SARME";
                        break;
                    case CTRL_U_FRAME_SABME:
                        frame_ctrl_info += "SAME";
                        break;
                    case CTRL_U_FRAME_DISC_RD:
                        frame_ctrl_info += "DISC_RD";
                        break;
                    case CTRL_U_FRAME_SIM_RIM:
                        frame_ctrl_info += "SIM_RIM";
                        break;
                    case CTRL_U_FRAME_UP:
                        frame_ctrl_info += "UP";
                        break;
                    case CTRL_U_FRAME_UI:
                        frame_ctrl_info += "UI";
                        break;
                    case CTRL_U_FRAME_XID:
                        frame_ctrl_info += "XID";
                        break;
                    case CTRL_U_FRAME_RESET:
                        frame_ctrl_info += "RESET";
                        break;
                    case CTRL_U_FRAME_FRMR:
                        frame_ctrl_info += "FRMR";
                        break;
                    case CTRL_U_FRAME_UA:
                        frame_ctrl_info += "UA";
                        break;
                    default:
                        frame_ctrl_info += "未知指令";
                        break;

                }

            }
            string gap;
            if (checkBoxGap.Checked)
                gap = " ";
            else gap = "";
            return Assist.ToHexString(hdlc, gap) + "\r\n" + String.Format(show_info, hdlc[0], frame_type, ctrl, frame_ctrl_info);
        }
        private string getHdlcInfoString(byte[] hdlc)
        {
            int index;
            string gap;
            if (checkBoxGap.Checked)
                gap = " ";
            else gap = "";
            string hdlc_info = string.Empty;
            if (hdlc == null || hdlc.Length < 4)
                return string.Empty;
            index = Array.IndexOf(hdlc, (byte)0x7E, 1);//寻找7E
            while (index > 1)
            {
                byte[] hdlc_item = hdlc.Take(index + 1).ToArray();
                hdlc_info += Assist.ToHexString(hdlc_item, gap) + "\r\n[ \r\n";
                hdlc_info += parse_hdlc_bytes(hdlc_item) + " \r\n]\r\n\r\n";
                hdlc = hdlc.Skip(index + 1).ToArray();
                if (hdlc.Length > 0)
                    index = Array.IndexOf(hdlc, (byte)0x7e, 1);
                else
                    break;
            }
            return hdlc_info;
        }
        private void buttonHdlcAnalize_Click(object sender, EventArgs e)
        {
            byte[] dataInput;
            dataInput = getBytes(this.textBoxInput.Text);
            textBoxReceive.Text = getHdlcInfoString(receiveBytes);
            if (dataInput != null)
            {
                textBoxInput.Text = getHdlcInfoString(dataInput); ;
            }
        }

        private void textBoxData_DoubleClick(object sender, EventArgs e)
        {
            int current_index, start = 0, end = 0;
            string str = textBoxInput.Text;
            if (str.Length == 0)
                return;
            current_index = textBoxInput.SelectionStart;
            end = str.IndexOf('\r', current_index);
            if (end < 0)
            {
                end = str.IndexOf('\n', current_index);
                if (end < 0)
                {
                    end = str.IndexOf(' ', current_index);
                    if (end < 0)
                        end = str.Length - 1;
                }
            }
            start = str.LastIndexOf('\r', current_index);
            if (start < 0)
            {
                start = str.LastIndexOf('\n', current_index);
                if (start < 0)
                {
                    start = str.LastIndexOf(' ', current_index);
                    if (start < 0)
                        start = 0;
                }
            }
            if (start < 0)
                start = 0;
            textBoxInput.Select(start, end - start);//在文本双击事件里重新选择文本 
        }

        private void textBoxData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                textBoxInput.SelectAll();
            }
        }

        private void textBoxReceive_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                textBoxReceive.SelectAll();
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

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if(comPort==null)
            {
                if (SerialPort.GetPortNames().Length == 0)
                    return;
                try {
                    comPort = new SerialPort();
                    comPort.PortName = comboBoxComPort.Text.Trim();
                    comPort.BaudRate = int.Parse(comboBoxBaudrate.Text.Trim());
                    comPort.ReadTimeout = 50;
                    comPort.Open();
                    serialThread = new Thread(serialReceiveTask);
                    serialRunning = true;
                    serialThread.Start();
                    buttonOpen.Text = "close";
                    Array.Resize(ref receiveBytes, 0);
                    sendCount = 0;
                    receiveCount = 0;

                }
                catch
                {
                    serialRunning=false;
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
        /// <summary>
        /// 刷新界面函数
        /// </summary>
        private void refreshReceive()
        {
            if (this.textBoxReceive.InvokeRequired)//等待异步
            {
                FlushClient fc = new FlushClient(refreshReceive);
                this.Invoke(fc);//通过代理调用刷新方法
            }
            else
            {
                if (receiveBytes == null || receiveBytes.Length == 0 || receiveShowCount >= receiveBytes.Length)
                {
                    return;
                }
                if (checkBoxAutoClear.Checked && textBoxReceive.Text.Length > 50000)
                    textBoxReceive.Clear();
                DateTime now_time = DateTime.Now;
                TimeSpan span = now_time.Subtract(laseTime);
                laseTime = now_time;
                if (span.TotalMilliseconds > 50)
                    textBoxReceive.Text += "\r\n[" + now_time.ToString("HH:mm:ss.fff") + "] ";
                int need_show_count = receiveBytes.Length - receiveShowCount;
                byte[] need_show = new byte[need_show_count];
                Array.Copy(receiveBytes, receiveShowCount, need_show, 0, need_show_count);
                appendReceiveBytes(need_show, need_show_count);
            }
        }
        private void appendReceiveBytes(byte[] receive, int len)
        {
            string gap;
            if (checkBoxGap.Checked)
                gap = " ";
            else gap = "";
            if (receive == null)
                return;
            len = len > receive.Length ? receive.Length : len;
            if (len == 0)
                return;
            byte[] data = new byte[len];
            Array.Copy(receive, data, len);
            receiveShowCount += len;
            switch (currentCode)
            {
                case CODE_BIT:
                    {
                        if (currentBitOrder == BIT_LSB_FIRST)
                            textBoxReceive.Text += Assist.BytesToBitsLsbString(data, gap)+gap;
                        else
                            textBoxReceive.Text += Assist.BytesToBitsMsbString(data, gap) + gap;
                    }
                    break;
                case CODE_HEX:
                    {
                        textBoxReceive.Text +=  Assist.ToHexString(data, gap) + gap;
                    }
                    break;
                case CODE_ASCII:
                default:
                    textBoxReceive.Text += System.Text.Encoding.Default.GetString(data);
                    break;
            }
            textBoxReceive.ScrollToCaret();
            labelReceiveCount.Text = receiveCount.ToString();
        }
        private void serialReceiveTick()
        {
            int len = 0, index;
            byte[] receive_buf = new byte[8];
            if (comPort != null && comPort.IsOpen && comPort.BytesToRead > 0)
            {
                //DateTime now_time = DateTime.Now;
                //TimeSpan span = now_time.Subtract(laseTime);
                //laseTime = now_time;
                //if (span.TotalMilliseconds > 10 )
                //    textBoxReceive.Text +="\r\n["+ now_time.ToString("HH:mm:ss.ffff") +"] ";
                try
                {
                    len = comPort.Read(receive_buf, 0, 8);
                    receiveCount +=len;
                    if (len > 0)
                    {
                        index = receiveBytes.Length;
                        lock (receiveBytes)
                        {
                            Array.Resize(ref receiveBytes, receiveBytes.Length + len);
                            Array.Copy(receive_buf, 0, receiveBytes, index, len);
                        }
                        //appendReceiveBytes(receive_buf, len);
                    }
                }
                catch
                {

                }
            }
            refreshReceive();
        }
        /// <summary>
        /// 串口接收线程函数
        /// </summary>
        private void serialReceiveTask()
        {
            while (serialRunning)
            {
                serialReceiveTick();
                Thread.Sleep(1);
            }
        }

        private void buttonClearSend_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
        }

        private void buttonClearReceive_Click(object sender, EventArgs e)
        {
            textBoxReceive.Clear();
            lock (receiveBytes)
            {
                Array.Resize(ref receiveBytes, 0);
                receiveShowCount = 0;
                receiveCount = 0;
                labelReceiveCount.Text = "0";
            }
        }

        private void serialSend(byte[] data)
        {
            if (comPort!=null&&data != null && data.Length > 0)
            {
                comPort.Write(data, 0, data.Length);
                sendCount += data.Length;
                labelSendCount.Text = sendCount.ToString();
            }
        }
        private void sendInputData()
        {
            byte[] data;
            if (tabControlSend.SelectedIndex == 0)
            {
                //if (textBoxInput.SelectedText.Length > 0)
                //    data = getBytes(textBoxInput.SelectedText);
                //else
                data = getBytes(this.textBoxInput.Text);
                serialSend(data);
            }
            else if(tabControlSend.SelectedIndex == 1)
            {

            }
            
        }
        private void buttonComSend_Click(object sender, EventArgs e)
        {
            if (timerSerialSend.Enabled == false)
            {
                if (comPort != null && comPort.IsOpen)
                {
                    sendInputData();
                    if (checkBoxComSendContinous.Checked)
                    {
                        timerSerialSend.Interval = Convert.ToInt32(numericUpDownComSendGap.Value);
                        timerSerialSend.Start();
                    }
                }
            }

        }

        private void CodeConvert_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialRunning = false;
            if (serialThread != null)
            {
                while (serialThread.IsAlive)
                {
                    Application.DoEvents();
                    Thread.Sleep(200);
                }
            }
        }

        private void timerSerialSend_Tick(object sender, EventArgs e)
        {
            if (comPort != null && comPort.IsOpen && checkBoxComSendContinous.Checked)
            {
                timerSerialSend.Stop();
                sendInputData();
                timerSerialSend.Start();
            }
        }

        private void buttonMultiSend1_Click(object sender, EventArgs e)
        {
            byte[] data;
            data = getBytes(this.textBoxMultisend1.Text.Trim());
            serialSend(data);
        }

        private void buttonMultiSend2_Click(object sender, EventArgs e)
        {
            byte[] data;
            data = getBytes(this.textBoxMultisend2.Text.Trim());
            serialSend(data);
        }

        private void buttonMultiSend3_Click(object sender, EventArgs e)
        {
            byte[] data;
            data = getBytes(this.textBoxMultisend3.Text.Trim());
            serialSend(data);
        }

        private void buttonMultiSend4_Click(object sender, EventArgs e)
        {
            byte[] data;
            data = getBytes(this.textBoxMultisend4.Text.Trim());
            serialSend(data);
        }

        private void buttonMultiSend5_Click(object sender, EventArgs e)
        {
            byte[] data;
            data = getBytes(this.textBoxMultisend5.Text.Trim());
            serialSend(data);
        }

        private void checkBoxComSendContinous_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxComSendContinous.Checked==false)
                timerSerialSend.Enabled = false;
        }
    }

}
