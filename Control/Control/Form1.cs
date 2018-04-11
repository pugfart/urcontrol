using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Control
{
    public partial class Form1 : Form
    {
        
        URSocketClient getinfo = new URSocketClient();
        URscript sendtask = new URscript();
        double a, v;//拉條控制加速度和速度

        public Form1()
        {
            InitializeComponent();
        }

        private void stop_thread_Click(object sender, EventArgs e)
        {

        }

        private void connect_bt_Click(object sender, EventArgs e)
        {
            try
            {
                sendtask.connect(IPaddress.Text.ToString());//send task connection
                getinfo.ConnectRobot(IPaddress.Text.ToString(), 30003);//get info connection
            }

            catch { }

            if (sendtask.conn.Connected)
                MessageBox.Show("已連線");
            else
                MessageBox.Show("未連線");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a = 0.3;
            v = 0.1;
        }

        private void J1plus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void disconnect_bt_Click_1(object sender, EventArgs e)
        {
            if (sendtask.conn.Connected)
            {
                sendtask.conn.Close();
                getinfo.DisconnectRobot();
                MessageBox.Show("已離線");
            }
            else
            MessageBox.Show("請先連線才能中斷連線");
        }

        private void J1minus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movejoint(-1, a, v);
        }

        private void J1minus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J2plus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movejoint(2, a, v);
        }

        private void J2plus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J2minus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movejoint(-2, a, v);
        }

        private void J2minus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J3plus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movejoint(3, a, v);
        }

        private void J3plus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J3minus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movejoint(-3, a, v);
        }

        private void J3minus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J4plus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movejoint(4, a, v);
        }

        private void J4plus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J4minus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movejoint(-4, a, v);
        }

        private void J4minus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J5plus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movejoint(5, a, v);
        }

        private void J5plus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J5minus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movejoint(-5, a, v);
        }

        private void J5minus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J6plus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movejoint(6, a, v);
        }

        private void J6plus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J6minus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movejoint(-6, a, v);
        }

        private void J6minus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J1plus_MouseDown_1(object sender, MouseEventArgs e)
        {
            sendtask.movejoint(1, a, v);
        }

        private void Speed_Scroll(object sender, EventArgs e)
        {
            showspeedpercent.Text = Speed.Value.ToString();
            
            a = System.Convert.ToDouble(Speed.Value) * 0.033 + 0.27;
            v = System.Convert.ToDouble(Speed.Value) * 0.011 + 0.088;
            label1.Text = a.ToString() + "\n" + v.ToString();                    
        }
    }
}
