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
using System.IO;

namespace Control
{
    public partial class Form1 : Form
    {
        URSocketClient getinfo = new URSocketClient();
        URscript sendtask = new URscript();

        bool thread;
        double[] jointpositiondegree, jointpositionradian, tcpposition;//手臂資料
        double a, v;//拉條控制加速度和速度
        Thread info;//執行緒 用來取得即時資料
        FileInfo f = new FileInfo("C:\\task_script.txt");//一串工作順序紀錄

        public Form1()
        {
            InitializeComponent();
            a = 0.3;//加速度初值 最小值
            v = 0.1;//速度初值 最小值
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
                MessageBox.Show("已中斷連線");
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
            try
            { 
                info.Start();//start thread
            }
            catch
            {
                return;
            }
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
            if(movementdata.RowCount>1)//刪除行 但至少1行
                for (int i = this.movementdata.SelectedRows.Count; i > 0; i--)                
                    movementdata.Rows.RemoveAt(movementdata.SelectedRows[i - 1].Index);            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            movementdata.Rows.Clear();//表格清空
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (do0.Checked == true)            
                sendtask.digital_output(0, true);           
            else            
                sendtask.digital_output(0, false);            
        }

        private void startthread_Click(object sender, EventArgs e)
        {
            StreamWriter write;
            try
            {
                write = f.CreateText();
            }
            catch
            {
                return;
            }
            
            for (int i = 0; i <= movementdata.RowCount - 1; i++)
            {
                char m = 'a';
                string move;
                move = movementdata.Rows[i].Cells[0].FormattedValue.ToString();
                if (move == "movej") m = 'j';//動作代號 預設為'a'走default
                else if (move == "movel") m = 'l';
                else if (move == "DO") m = 'd';

                double j1 = Convert.ToDouble(movementdata.Rows[i].Cells[1].Value),//表格各軸單位轉換 度轉徑
                    j2 = Convert.ToDouble(movementdata.Rows[i].Cells[2].Value),
                    j3 = Convert.ToDouble(movementdata.Rows[i].Cells[3].Value),
                    j4 = Convert.ToDouble(movementdata.Rows[i].Cells[4].Value),
                    j5 = Convert.ToDouble(movementdata.Rows[i].Cells[5].Value),
                    j6 = Convert.ToDouble(movementdata.Rows[i].Cells[6].Value),
                    aa = Convert.ToDouble(movementdata.Rows[i].Cells[13].Value),//紀錄上的加速度
                    vv = Convert.ToDouble(movementdata.Rows[i].Cells[14].Value);//紀錄上的速度
                int _do0=0,_do1=0,_do2=0,_do3=0,_do4=0,_do5=0,_do6=0,_do7=0,do_all=0;
                
                if(movementdata.Rows[i].Cells[15].Value!=null)//如果不是DO動作就不執行
                do_all = Convert.ToInt32(movementdata.Rows[i].Cells[15].Value);
                if (do_all != 0)//解讀各DO狀態
                {
                    _do7 = do_all % 10;
                    do_all /= 10;
                    if (do_all != 0)
                    {
                        _do6 = do_all % 10;
                        do_all /= 10;
                        if (do_all != 0)
                        {
                            _do5 = do_all % 10;
                            do_all /= 10;
                            if (do_all != 0)
                            {
                                _do4 = do_all % 10;
                                do_all /= 10;
                                if (do_all != 0)
                                {
                                    _do3 = do_all % 10;
                                    do_all /= 10;
                                    if (do_all != 0)
                                    {
                                        _do2 = do_all % 10;
                                        do_all /= 10;
                                        if (do_all != 0)
                                        {
                                            _do1 = do_all % 10;
                                            do_all /= 10;
                                            if (do_all != 0)
                                            {
                                                _do0 = do_all % 10;
                                                do_all /= 10;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                switch (m)
                {
                    case 'j'://movej寫入
                        write.Write("movej([" + j1.ToString() + "," +
                            j2.ToString() + "," +
                            j3.ToString() + "," +
                            j4.ToString() + "," +
                            j5.ToString() + "," +
                            j6.ToString() + "],a=" +
                            aa.ToString() + ",v=" +
                            vv.ToString() + ")\r\n");
                        break;
                    case 'l'://movel寫入
                        write.Write("movel([" + j1.ToString() + "," +
                            j2.ToString() + "," +
                            j3.ToString() + "," +
                            j4.ToString() + "," +
                            j5.ToString() + "," +
                            j6.ToString() + "],a=" +
                            (2*aa).ToString() + ",v=" +
                            (vv/2).ToString() + ")\r\n");
                        break;
                    case 'd'://每次都會寫入每個DO的指令                        
                        write.Write("set_standard_digital_out(0,"+Convert.ToBoolean(_do0).ToString()+")\r\n"+
                            "set_standard_digital_out(1," + Convert.ToBoolean(_do1).ToString() + ")\r\n"+
                            "set_standard_digital_out(2," + Convert.ToBoolean(_do2).ToString() + ")\r\n" +
                            "set_standard_digital_out(3," + Convert.ToBoolean(_do3).ToString() + ")\r\n" +
                            "set_standard_digital_out(4," + Convert.ToBoolean(_do4).ToString() + ")\r\n" +
                            "set_standard_digital_out(5," + Convert.ToBoolean(_do5).ToString() + ")\r\n" +
                            "set_standard_digital_out(6," + Convert.ToBoolean(_do6).ToString() + ")\r\n" +
                            "set_standard_digital_out(7," + Convert.ToBoolean(_do7).ToString() + ")\r\n" );
                        break;
                    default:
                        break;
                }
            }
            write.Close();//寫入結束

            sendtask.do_work(f);//呼叫讀取.txt中的工作並執行
        }

        private void stopthread_Click(object sender, EventArgs e)
        {
            sendtask.stopj(a);
        }

        private void do1_CheckedChanged(object sender, EventArgs e)
        {
            if (do1.Checked == true)            
                sendtask.digital_output(1, true);            
            else            
                sendtask.digital_output(1, false);           
        }

        private void do2_CheckedChanged(object sender, EventArgs e)
        {
            if (do2.Checked == true)
                sendtask.digital_output(2, true);
            else
                sendtask.digital_output(2, false);
        }

        private void do3_CheckedChanged(object sender, EventArgs e)
        {
            if (do3.Checked == true)
                sendtask.digital_output(3, true);
            else
                sendtask.digital_output(3, false);
        }

        private void do4_CheckedChanged(object sender, EventArgs e)
        {
            if (do4.Checked == true)
                sendtask.digital_output(4, true);
            else
                sendtask.digital_output(4, false);
        }

        private void do5_CheckedChanged(object sender, EventArgs e)
        {
            if (do5.Checked == true)
                sendtask.digital_output(5, true);
            else
                sendtask.digital_output(5, false);
        }

        private void do6_CheckedChanged(object sender, EventArgs e)
        {
            if (do6.Checked == true)
                sendtask.digital_output(6, true);
            else
                sendtask.digital_output(6, false);
        }

        private void do7_CheckedChanged(object sender, EventArgs e)
        {
            if (do7.Checked == true)
                sendtask.digital_output(7, true);
            else
                sendtask.digital_output(7, false);
        }

        private void writeDIO_Click(object sender, EventArgs e)
        {
            int dioinfo=0;//紀錄目前DO狀況 以數字方式記錄 並組合成1個數字寫入 1表on 0表off 例:10000010為DO0與DO6 on
            if (do0.Checked) dioinfo = 1;
            if (do1.Checked) dioinfo = dioinfo * 10 + 1;
            else dioinfo *= 10;
            if (do2.Checked) dioinfo = dioinfo * 10 + 1;
            else dioinfo *= 10;
            if (do3.Checked) dioinfo = dioinfo * 10 + 1;
            else dioinfo *= 10;
            if (do4.Checked) dioinfo = dioinfo * 10 + 1;
            else dioinfo *= 10;
            if (do5.Checked) dioinfo = dioinfo * 10 + 1;
            else dioinfo *= 10;
            if (do6.Checked) dioinfo = dioinfo * 10 + 1;
            else dioinfo *= 10;
            if (do7.Checked) dioinfo = dioinfo * 10 + 1;
            else dioinfo *= 10;
            DataGridViewRowCollection movedata = movementdata.Rows;
            movementdata.Rows.Add(new object[] { "DO","0","0","0","0","0","0","0","0","0","0","0","0","0","0",dioinfo.ToString()});//資料填入表單                
        }

        private void powerdown_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (sendtask.conn.Connected)//有連線才能執行關機
            {
                result = MessageBox.Show("確定要關機?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.OK)
                    sendtask.powerdown();
            }

            else
                MessageBox.Show("尚未連線\r請先連線","",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread = false;//關視窗時會先停止執行緒 才不會崩潰
            info.Abort();
        }

        private void IPaddress_MouseClick(object sender, MouseEventArgs e)
        {
            IPaddress.Text = "";//點IP格會自動清除
        }

        private void Speed_Scroll(object sender, EventArgs e)
        {
            showspeedpercent.Text = Speed.Value.ToString();//顯示在條上面

            a = System.Convert.ToDouble(Speed.Value) * 0.033 + 0.27;//加速度調整公式
            v = System.Convert.ToDouble(Speed.Value) * 0.011 + 0.09;//最大速調整控制
        }
        
        public void showinfo()        
        {
               while (thread)
               {                
                   jointpositiondegree[0] = getinfo.m_jointDegreeInfo.dbBasePosDegree;//取得各軸角度
                   jointpositiondegree[1] = getinfo.m_jointDegreeInfo.dbShoulderPosDegree;
                   jointpositiondegree[2] = getinfo.m_jointDegreeInfo.dbElbowPosDegree;
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
