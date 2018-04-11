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

        bool thread = false;
        double[] jointpositiondegree, jointpositionradian, tcpposition;
        double a, v;//拉條控制加速度和速度

        public Form1()
        {
            InitializeComponent();
            a = 0.3;
            v = 0.1;
        }

        private void stop_thread_Click(object sender, EventArgs e)
        {
            thread = false;
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
            
        }

        private void J1plus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            jointpositiondegree = new double[6];
            jointpositionradian = new double[6];
            tcpposition = new double[6];
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
            sendtask.movejoint(-1, a, v,jointpositionradian[0], jointpositionradian[1], jointpositionradian[2], jointpositionradian[3], jointpositionradian[4], jointpositionradian[5]);
        }

        private void J1minus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J2plus_MouseDown(object sender, MouseEventArgs e)
        {
            //sendtask.movejoint(2, a, v);
        }

        private void J2plus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J2minus_MouseDown(object sender, MouseEventArgs e)
        {
           // sendtask.movejoint(-2, a, v);
        }

        private void J2minus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J3plus_MouseDown(object sender, MouseEventArgs e)
        {
           // sendtask.movejoint(3, a, v);
        }

        private void J3plus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J3minus_MouseDown(object sender, MouseEventArgs e)
        {
           // sendtask.movejoint(-3, a, v);
        }

        private void J3minus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J4plus_MouseDown(object sender, MouseEventArgs e)
        {
          //  sendtask.movejoint(4, a, v);
        }

        private void J4plus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J4minus_MouseDown(object sender, MouseEventArgs e)
        {
          //  sendtask.movejoint(-4, a, v);
        }

        private void J4minus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J5plus_MouseDown(object sender, MouseEventArgs e)
        {
          //  sendtask.movejoint(5, a, v);
        }

        private void J5plus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J5minus_MouseDown(object sender, MouseEventArgs e)
        {
          //  sendtask.movejoint(-5, a, v);
        }

        private void J5minus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J6plus_MouseDown(object sender, MouseEventArgs e)
        {
          //  sendtask.movejoint(6, a, v);
        }

        private void J6plus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J6minus_MouseDown(object sender, MouseEventArgs e)
        {
         //   sendtask.movejoint(-6, a, v);
        }

        private void J6minus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J1plus_MouseDown_1(object sender, MouseEventArgs e)
        {
          //  sendtask.movejoint(1, a, v);
        }

        private void MoveJ_Click(object sender, EventArgs e)
        {
            DataGridViewRowCollection movedata = movementdata.Rows;
            movementdata.Rows.Add(new object[] { "movej", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" });
        }

        private void MoveL_Click(object sender, EventArgs e)
        {
            DataGridViewRowCollection movedata = movementdata.Rows;
            movementdata.Rows.Add(new object[] { "movel", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" });
        }

        private void start_thread_Click(object sender, EventArgs e)
        {
            thread = true;

            showinfo();


        }

        private void IPaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void IPaddress_MouseClick(object sender, MouseEventArgs e)
        {
            IPaddress.Text = "";
        }

        private void Speed_Scroll(object sender, EventArgs e)
        {
            showspeedpercent.Text = Speed.Value.ToString();

            a = System.Convert.ToDouble(Speed.Value) * 0.033 + 0.27;
            v = System.Convert.ToDouble(Speed.Value) * 0.011 + 0.09;

            label1.Text = a.ToString() + "\n" + v.ToString();
        }

        public void showinfo()
        {
            
                jointpositiondegree[0] = getinfo.m_jointDegreeInfo.dbBasePosDegree;//取得各軸角度
                jointpositiondegree[1] = getinfo.m_jointDegreeInfo.dbElbowPosDegree;
                jointpositiondegree[2] = getinfo.m_jointDegreeInfo.dbShoulderPosDegree;
                jointpositiondegree[3] = getinfo.m_jointDegreeInfo.dbWrist1PosDegree;
                jointpositiondegree[4] = getinfo.m_jointDegreeInfo.dbWrist2PosDegree;
                jointpositiondegree[5] = getinfo.m_jointDegreeInfo.dbWrist3PosDegree;

                j1degree.Text = jointpositiondegree[0].ToString();
                j2degree.Text = jointpositiondegree[1].ToString();
                j3degree.Text = jointpositiondegree[2].ToString();
                j4degree.Text = jointpositiondegree[3].ToString();
                j5degree.Text = jointpositiondegree[4].ToString();
                j6degree.Text = jointpositiondegree[5].ToString();


                for (int i = 0; i < 6; i++)//取得各軸徑度
                    jointpositionradian[i] = jointpositiondegree[i] * 3.14 / 180;

                j1radian.Text = jointpositionradian[0].ToString();
                j2radian.Text = jointpositionradian[1].ToString();
                j3radian.Text = jointpositionradian[2].ToString();
                j4radian.Text = jointpositionradian[3].ToString();
                j5radian.Text = jointpositionradian[4].ToString();
                j6radian.Text = jointpositionradian[5].ToString();


                tcpposition[0] = getinfo.m_tcpPosInfo.dbTCP_X;//取得世界座標
                tcpposition[1] = getinfo.m_tcpPosInfo.dbTCP_Y;
                tcpposition[2] = getinfo.m_tcpPosInfo.dbTCP_Z;
                tcpposition[3] = getinfo.m_tcpPosInfo.dbTCP_Rx;
                tcpposition[4] = getinfo.m_tcpPosInfo.dbTCP_Ry;
                tcpposition[5] = getinfo.m_tcpPosInfo.dbTCP_Rz;

                tcpx.Text = tcpposition[0].ToString();
                tcpy.Text = tcpposition[1].ToString();
                tcpz.Text = tcpposition[2].ToString();
                tcprx.Text = tcpposition[3].ToString();
                tcpry.Text = tcpposition[4].ToString();
                tcprz.Text = tcpposition[5].ToString();

                System.Threading.Thread.Sleep(1000);//釋放資源}
            
        }
    }
}
