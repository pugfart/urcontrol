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
                sendtask.connect(IPaddress.ToString());//send task connection
                getinfo.ConnectRobot(IPaddress.ToString(), 30003);//get info connection
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


        private void disconnect_bt_Click(object sender, EventArgs e)
        {
            if (sendtask.conn.Connected)
            {
                sendtask.conn.Close();
                getinfo.DisconnectRobot();
            }
        }

        private void J1plus_MouseDown(object sender, MouseEventArgs e)
        {
           // sendtask.movejoint(1, a, v);
        }

        private void J1plus_MouseUp(object sender, MouseEventArgs e)
        {
           // sendtask.stopj(a);
        }

        private void Speed_Scroll(object sender, EventArgs e)
        {
            showspeedpercent.Text = Speed.Value.ToString();
            
            a = System.Convert.ToDouble(Speed.Value) * 0.033 + 0.27;
            v = System.Convert.ToDouble(Speed.Value) * 0.011 + 0.088;                     
        }
    }
}
