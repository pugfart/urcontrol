using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Control
{
    class URscript
    {    
        ASCIIEncoding asc = new ASCIIEncoding();
        private static byte[] startline;
        private static byte[] endline;
        private byte[] task;

        public TcpClient conn = new TcpClient();
        NetworkStream sendtask;


        public void connect(string urip)
        {
            conn.Connect(urip, 30002);//連線
            sendtask = conn.GetStream();//傳資料用
            startline = asc.GetBytes("def myProg(): \n");//定義開頭
            endline = asc.GetBytes("end \n");//定義結尾
        }

        public void movejoint(int jointnum,double a,double v)
        {
            try
            {
                sendtask.Write(startline, 0, startline.Length);
            }
            catch
            {
                return;
            }
            task = asc.GetBytes("movej([-1.6007, -1.7271, -2.203, -0.808, 1.5951, -0.031], a=0.1, v=0.1)\n");//test
            sendtask.Write(task, 0, task.Length);

            switch (jointnum)//選擇軸 1~6  選擇正反 +-
            {
               // case 1:
                    /*             task =asc.GetBytes( "movej([6.2831852,"
                                     + m_dbJ2Radian.ToString() + ","
                                     + m_dbJ3Radian.ToString() + "," 
                                     + m_dbJ4Radian.ToString() + "," 
                                     + m_dbJ5Radian.ToString() + "," 
                                     + m_dbJ6Radian.ToString() + "], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");*/
                    
                   // sendtask.Write(task, 0, task.Length);
                   // break;

                /*case 2:能接收資料後再加入調整
                     task = asc.GetBytes("movej([6.2831852,"
                        + m_dbJ2Radian.ToString() + ","
                        + m_dbJ3Radian.ToString() + ","
                        + m_dbJ4Radian.ToString() + ","
                        + m_dbJ5Radian.ToString() + ","
                        + m_dbJ6Radian.ToString() + "], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");
                     sendtask.Write(task, 0, task.Length);
                     break;

                 case 3:
                     task = asc.GetBytes("movej([6.2831852,"
                         + m_dbJ2Radian.ToString() + ","
                         + m_dbJ3Radian.ToString() + ","
                         + m_dbJ4Radian.ToString() + ","
                         + m_dbJ5Radian.ToString() + ","
                         + m_dbJ6Radian.ToString() + "], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");
                     sendtask.Write(task, 0, task.Length);
                     break;

                 case 4:
                     task = asc.GetBytes("movej([6.2831852,"
                         + m_dbJ2Radian.ToString() + ","
                         + m_dbJ3Radian.ToString() + ","
                         + m_dbJ4Radian.ToString() + ","
                         + m_dbJ5Radian.ToString() + ","
                         + m_dbJ6Radian.ToString() + "], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");
                     sendtask.Write(task, 0, task.Length);
                     break;

                 case 5:
                     task = asc.GetBytes("movej([6.2831852,"
                         + m_dbJ2Radian.ToString() + ","
                         + m_dbJ3Radian.ToString() + ","
                         + m_dbJ4Radian.ToString() + ","
                         + m_dbJ5Radian.ToString() + ","
                         + m_dbJ6Radian.ToString() + "], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");
                     sendtask.Write(task, 0, task.Length);
                     break;

                 case 6:
                     task = asc.GetBytes("movej([6.2831852,"
                         + m_dbJ2Radian.ToString() + ","
                         + m_dbJ3Radian.ToString() + ","
                         + m_dbJ4Radian.ToString() + ","
                         + m_dbJ5Radian.ToString() + ","
                         + m_dbJ6Radian.ToString() + "], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");
                     sendtask.Write(task, 0, task.Length);
                     break;

                 case -1:
                     task = asc.GetBytes("movej([6.2831852,"
                         + m_dbJ2Radian.ToString() + ","
                         + m_dbJ3Radian.ToString() + ","
                         + m_dbJ4Radian.ToString() + ","
                         + m_dbJ5Radian.ToString() + ","
                         + m_dbJ6Radian.ToString() + "], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");
                     sendtask.Write(task, 0, task.Length);
                     break;

                 case -2:
                     task = asc.GetBytes("movej([6.2831852,"
                         + m_dbJ2Radian.ToString() + ","
                         + m_dbJ3Radian.ToString() + ","
                         + m_dbJ4Radian.ToString() + ","
                         + m_dbJ5Radian.ToString() + ","
                         + m_dbJ6Radian.ToString() + "], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");
                     sendtask.Write(task, 0, task.Length);
                     break;

                 case -3:
                     task = asc.GetBytes("movej([6.2831852,"
                         + m_dbJ2Radian.ToString() + ","
                         + m_dbJ3Radian.ToString() + ","
                         + m_dbJ4Radian.ToString() + ","
                         + m_dbJ5Radian.ToString() + ","
                         + m_dbJ6Radian.ToString() + "], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");
                     sendtask.Write(task, 0, task.Length);
                     break;

                 case -4:
                     task = asc.GetBytes("movej([6.2831852,"
                         + m_dbJ2Radian.ToString() + ","
                         + m_dbJ3Radian.ToString() + ","
                         + m_dbJ4Radian.ToString() + ","
                         + m_dbJ5Radian.ToString() + ","
                         + m_dbJ6Radian.ToString() + "], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");
                     sendtask.Write(task, 0, task.Length);
                     break;

                 case -5:
                     task = asc.GetBytes("movej([6.2831852,"
                         + m_dbJ2Radian.ToString() + ","
                         + m_dbJ3Radian.ToString() + ","
                         + m_dbJ4Radian.ToString() + ","
                         + m_dbJ5Radian.ToString() + ","
                         + m_dbJ6Radian.ToString() + "], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");
                     sendtask.Write(task, 0, task.Length);
                     break;

                 case -6:
                     task = asc.GetBytes("movej([6.2831852,"
                         + m_dbJ2Radian.ToString() + ","
                         + m_dbJ3Radian.ToString() + ","
                         + m_dbJ4Radian.ToString() + ","
                         + m_dbJ5Radian.ToString() + ","
                         + m_dbJ6Radian.ToString() + "], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");
                     sendtask.Write(task, 0, task.Length);
                     break;
*/
                default:
                    break;
            }

            sendtask.Write(endline, 0, endline.Length);
        }

        public void stopj(double a)
        {
            try
            {
                sendtask.Write(startline, 0, startline.Length);
            }
            catch { return; }
            task = asc.GetBytes("stopj(" + a.ToString() + ")\n");//movej停止 減速同速度條
            sendtask.Write(task, 0, task.Length);

            sendtask.Write(endline, 0, endline.Length);
        }
    }
}

            