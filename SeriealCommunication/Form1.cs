using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeriealCommunication
{
    public partial class Form1 : Form
    {
        public bool comover;//true: connect, false disconnect
        public Form1()
        {
            InitializeComponent();
            comover = false;
            Outputset.SelectedIndex = 0;
        }

        private void terminalsender_KeyDown(object sender, KeyEventArgs e)
        {
            if (comover&&e.KeyCode == Keys.Enter) {
                try
                {
                    int index;
                    Encoding ascii = Encoding.ASCII;
                    byte[] bPacket;
                    bPacket = ascii.GetBytes(terminalsender.Text);
                    Serial.Write(bPacket, 0, 1);
                    Serialout.Items.Add("사용자曰: " + terminalsender.Text);
                    index = Serialout.Items.Count;
                    Serialout.SelectedIndex = index-1;
                }
                catch (InvalidOperationException exp)
                {
                    Serialout.Items.Add("ANG?: InvalidOperationException");
                }
                catch (TimeoutException exp) {
                    Serialout.Items.Add("ANG?: TimeoutException");
                }
                terminalsender.Clear();
            }
        }

        private void Portnum_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                button1_Click(sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int portnum;
            if (comover)
            {
                Serial.Close();
                comover = false;
                Serialout.Items.Add("통신님이 당했습니다");
                Combutton.Text = "통신　はじまるよ～！";
            }
            else {
                
                try {
                    portnum = int.Parse(PortNum.Text);
                    Serial.PortName = "COM" + portnum;
                    comover = true;
                }catch(FormatException exp){
                    if (PortNum.Text == "")
                    {
                        System.Windows.Forms.MessageBox.Show("Serial번호를 순순히 적지 않으면 통신사태는 벌어지지 않을 것 입니다");
                        Serialout.Items.Add("Serial번호를 순순히 적지 않으면 통신사태는 벌어지지 않을 것 입니다");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("난 숫자를 원한다고 User♂");
                        Serialout.Items.Add("난 숫자를 원한다고 User♂");
                    }
                }
                if(comover) {
                    Serialout.Items.Add(Serial.PortName+"장비와 통신합니다.");
                    try
                    {
                        Serial.Open();
                        Serialout.Items.Add("아...아니, 잘되잖아...");
                        terminalsender.Focus();
                    }
                    catch (UnauthorizedAccessException exp)
                    {
                        System.Windows.Forms.MessageBox.Show("ANG?: UnauthuthorizedAccessException");
                        Serialout.Items.Add("ANG?: UnauthuthorizedAccessException");
                        comover = false;
                    }
                    catch (System.IO.IOException exp) {
                        System.Windows.Forms.MessageBox.Show("ANG?: IO Exception");
                        Serialout.Items.Add("ANG?: IO Exception");
                        comover = false;
                    }

                }

                if (comover)
                {
                    Combutton.Text = "통신에 칼빵";
                }
            }
        }
        private void SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(SerialReceived));
        }

        private void SerialReceived(object s, EventArgs e)
        {
            int index;
            String strReceive = "";
            byte[] inputBytes;
            switch(Outputset.SelectedIndex){
                case 0:
                    strReceive = Serial.ReadExisting();
                    break;
                case 1:
                    inputBytes = Encoding.ASCII.GetBytes(Serial.ReadExisting());
                    strReceive = BitConverter.ToString(inputBytes);
                    break;
                case 2:
                    int a;
                    inputBytes = Encoding.ASCII.GetBytes(Serial.ReadExisting());
                    a = inputBytes[0];
                    strReceive = a.ToString();
                    break;
            }
            Serialout.Items.Add("장치曰: "+strReceive);
            index = Serialout.Items.Count;
            Serialout.SelectedIndex = index - 1;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
