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
using System.Threading;

namespace Control
{
    public partial class Form1 : Form
    {
        URSocketClient getinfo = new URSocketClient();
        URscript sendtask = new URscript();

        bool thread;
        double[] jointpositiondegree, jointpositionradian, tcpposition;
        double a, v;//拉條控制加速度和速度
        Thread info;
        
        public Form1()
        {
            InitializeComponent();
            a = 0.3;//加速度初值 最小值
            v = 0.1;//最大速初值 最小值
            thread = false;
            info = new Thread(new ThreadStart(showinfo));//宣告執行續
            info.IsBackground = true;//背景執行     
        }

        private void stop_thread_Click(object sender, EventArgs e)
        {
            thread = false;
            info.Abort();//stop thread
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
            sendtask.movejoint(2, a, v, jointpositionradian[0], jointpositionradian[1], jointpositionradian[2], jointpositionradian[3], jointpositionradian[4], jointpositionradian[5]);
        }

        private void J2plus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J2minus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movejoint(-2, a, v,jointpositionradian[0], jointpositionradian[1], jointpositionradian[2], jointpositionradian[3], jointpositionradian[4], jointpositionradian[5]);
        }

        private void J2minus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J3plus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movejoint(3, a, v,jointpositionradian[0], jointpositionradian[1], jointpositionradian[2], jointpositionradian[3], jointpositionradian[4], jointpositionradian[5]);
        }

        private void J3plus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J3minus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movejoint(-3, a, v,jointpositionradian[0], jointpositionradian[1], jointpositionradian[2], jointpositionradian[3], jointpositionradian[4], jointpositionradian[5]);
        }

        private void J3minus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J4plus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movejoint(4, a, v,jointpositionradian[0], jointpositionradian[1], jointpositionradian[2], jointpositionradian[3], jointpositionradian[4], jointpositionradian[5]);
        }

        private void J4plus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J4minus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movejoint(-4, a, v,jointpositionradian[0], jointpositionradian[1], jointpositionradian[2], jointpositionradian[3], jointpositionradian[4], jointpositionradian[5]);
        }

        private void J4minus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J5plus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movejoint(5, a, v,jointpositionradian[0], jointpositionradian[1], jointpositionradian[2], jointpositionradian[3], jointpositionradian[4], jointpositionradian[5]);
        }

        private void J5plus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J5minus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movejoint(-5, a, v,jointpositionradian[0], jointpositionradian[1], jointpositionradian[2], jointpositionradian[3], jointpositionradian[4], jointpositionradian[5]);
        }

        private void J5minus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J6plus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movejoint(6, a, v,jointpositionradian[0], jointpositionradian[1], jointpositionradian[2], jointpositionradian[3], jointpositionradian[4], jointpositionradian[5]);
        }

        private void J6plus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J6minus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movejoint(-6, a, v,jointpositionradian[0], jointpositionradian[1], jointpositionradian[2], jointpositionradian[3], jointpositionradian[4], jointpositionradian[5]);
        }

        private void J6minus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopj(a);
        }

        private void J1plus_MouseDown_1(object sender, MouseEventArgs e)
        {
            sendtask.movejoint(1, a, v,jointpositionradian[0], jointpositionradian[1], jointpositionradian[2], jointpositionradian[3], jointpositionradian[4], jointpositionradian[5]);
        }

        private void MoveJ_Click(object sender, EventArgs e)
        {
            DataGridViewRowCollection movedata = movementdata.Rows;
            movementdata.Rows.Add(new object[] { "movej",//資料填入表單
                jointpositionradian[0],
                jointpositionradian[1],
                jointpositionradian[2],
                jointpositionradian[3],
                jointpositionradian[4],
                jointpositionradian[5],
                tcpposition[0],
                tcpposition[1],
                tcpposition[2],
                tcpposition[3],
                tcpposition[4],
                tcpposition[5],
                a,v});
        }

        private void MoveL_Click(object sender, EventArgs e)
        {
            DataGridViewRowCollection movedata = movementdata.Rows;
            movementdata.Rows.Add(new object[] { "movel",//資料填入表單
                jointpositionradian[0],
                jointpositionradian[1],
                jointpositionradian[2],
                jointpositionradian[3],
                jointpositionradian[4],
                jointpositionradian[5],
                tcpposition[0],
                tcpposition[1],
                tcpposition[2],
                tcpposition[3],
                tcpposition[4],
                tcpposition[5],
                a,v});
        }

        private void start_thread_Click(object sender, EventArgs e)
        {
            thread = true;
            info.Start();//start thread
        }

        private void IPaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void Xplus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movel(1, a, v, tcpposition[0], tcpposition[1], tcpposition[2], tcpposition[3], tcpposition[4], tcpposition[5]);
        }

        private void Xplus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopl(a);
        }

        private void Xminus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movel(-1, a, v, tcpposition[0], tcpposition[1], tcpposition[2], tcpposition[3], tcpposition[4], tcpposition[5]);
        }

        private void Xminus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopl(a);
        }

        private void Yplus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movel(2, a, v, tcpposition[0], tcpposition[1], tcpposition[2], tcpposition[3], tcpposition[4], tcpposition[5]);
        }

        private void Yplus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopl(a);
        }

        private void Yminus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movel(-2, a, v, tcpposition[0], tcpposition[1], tcpposition[2], tcpposition[3], tcpposition[4], tcpposition[5]);
        }

        private void Yminus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopl(a);
        }

        private void Zplus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movel(3, a, v, tcpposition[0], tcpposition[1], tcpposition[2], tcpposition[3], tcpposition[4], tcpposition[5]);
        }

        private void Zplus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopl(a);
        }

        private void Zminus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movel(-3, a, v, tcpposition[0], tcpposition[1], tcpposition[2], tcpposition[3], tcpposition[4], tcpposition[5]);
        }

        private void Zminus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopl(a);
        }

        private void RXplus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movel(4, a, v, tcpposition[0], tcpposition[1], tcpposition[2], tcpposition[3], tcpposition[4], tcpposition[5]);
        }

        private void RXplus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopl(a);
        }

        private void RXminus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movel(-4, a, v, tcpposition[0], tcpposition[1], tcpposition[2], tcpposition[3], tcpposition[4], tcpposition[5]);
        }

        private void RXminus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopl(a);
        }

        private void RYplus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movel(5, a, v, tcpposition[0], tcpposition[1], tcpposition[2], tcpposition[3], tcpposition[4], tcpposition[5]);
        }

        private void RYplus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopl(a);
        }

        private void RYminus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movel(-5, a, v, tcpposition[0], tcpposition[1], tcpposition[2], tcpposition[3], tcpposition[4], tcpposition[5]);
        }

        private void RYminus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopl(a);
        }

        private void RZplus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movel(6, a, v, tcpposition[0], tcpposition[1], tcpposition[2], tcpposition[3], tcpposition[4], tcpposition[5]);
        }

        private void RZplus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopl(a);
        }

        private void RZminus_MouseDown(object sender, MouseEventArgs e)
        {
            sendtask.movel(-6, a, v, tcpposition[0], tcpposition[1], tcpposition[2], tcpposition[3], tcpposition[4], tcpposition[5]);
        }

        private void RZminus_MouseUp(object sender, MouseEventArgs e)
        {
            sendtask.stopl(a);
        }

        private void deleterow_Click(object sender, EventArgs e)
        {
            for (int i = this.movementdata.SelectedRows.Count; i > 0; i--)       //刪除行         
                movementdata.Rows.RemoveAt(movementdata.SelectedRows[i - 1].Index);            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            movementdata.Rows.Clear();//表格清空
        }

        private void IPaddress_MouseClick(object sender, MouseEventArgs e)
        {
            IPaddress.Text = "";//點IP格會自動清除
        }

        private void Speed_Scroll(object sender, EventArgs e)
        {
            showspeedpercent.Text = Speed.Value.ToString();

            a = System.Convert.ToDouble(Speed.Value) * 0.033 + 0.27;//加速度調整公式
            v = System.Convert.ToDouble(Speed.Value) * 0.011 + 0.09;//最大速調整控制
        }
        
        public void showinfo()        
        {
               while (thread)
               {                
                   jointpositiondegree[0] = getinfo.m_jointDegreeInfo.dbBasePosDegree;//取得各軸角度
                   jointpositiondegree[1] = getinfo.m_jointDegreeInfo.dbElbowPosDegree;
                   jointpositiondegree[2] = getinfo.m_jointDegreeInfo.dbShoulderPosDegree;
                   jointpositiondegree[3] = getinfo.m_jointDegreeInfo.dbWrist1PosDegree;
                   jointpositiondegree[4] = getinfo.m_jointDegreeInfo.dbWrist2PosDegree;
                   jointpositiondegree[5] = getinfo.m_jointDegreeInfo.dbWrist3PosDegree;

                   this.Invoke(new Action(() => j1degree.Text = jointpositiondegree[0].ToString()));//顯示
                   this.Invoke(new Action(() => j2degree.Text = jointpositiondegree[1].ToString()));
                   this.Invoke(new Action(() => j3degree.Text = jointpositiondegree[2].ToString()));
                   this.Invoke(new Action(() => j4degree.Text = jointpositiondegree[3].ToString()));
                   this.Invoke(new Action(() => j5degree.Text = jointpositiondegree[4].ToString()));
                   this.Invoke(new Action(() => j6degree.Text = jointpositiondegree[5].ToString()));


                   for (int i = 0; i < 6; i++)//取得各軸徑度
                       jointpositionradian[i] = jointpositiondegree[i] * 3.14 / 180;

                   this.Invoke(new Action(() => j1radian.Text = jointpositionradian[0].ToString()));//顯示
                   this.Invoke(new Action(() => j2radian.Text = jointpositionradian[1].ToString()));
                   this.Invoke(new Action(() => j3radian.Text = jointpositionradian[2].ToString()));
                   this.Invoke(new Action(() => j4radian.Text = jointpositionradian[3].ToString()));
                   this.Invoke(new Action(() => j5radian.Text = jointpositionradian[4].ToString()));
                   this.Invoke(new Action(() => j6radian.Text = jointpositionradian[5].ToString()));


                   tcpposition[0] = getinfo.m_tcpPosInfo.dbTCP_X;//取得世界座標
                   tcpposition[1] = getinfo.m_tcpPosInfo.dbTCP_Y;
                   tcpposition[2] = getinfo.m_tcpPosInfo.dbTCP_Z;
                   tcpposition[3] = getinfo.m_tcpPosInfo.dbTCP_Rx;
                   tcpposition[4] = getinfo.m_tcpPosInfo.dbTCP_Ry;
                   tcpposition[5] = getinfo.m_tcpPosInfo.dbTCP_Rz;

                   this.Invoke(new Action(() => tcpx.Text = tcpposition[0].ToString()));//顯示
                   this.Invoke(new Action(() => tcpy.Text = tcpposition[1].ToString()));
                   this.Invoke(new Action(() => tcpz.Text = tcpposition[2].ToString()));
                   this.Invoke(new Action(() => tcprx.Text = tcpposition[3].ToString()));
                   this.Invoke(new Action(() => tcpry.Text = tcpposition[4].ToString()));
                   this.Invoke(new Action(() => tcprz.Text = tcpposition[5].ToString()));
                  
                   System.Threading.Thread.Sleep(50);//釋放資源
                }
        }
    }
}
