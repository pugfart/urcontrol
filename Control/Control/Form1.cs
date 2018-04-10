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
            
        }

        private void J1plus_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
    }
}
