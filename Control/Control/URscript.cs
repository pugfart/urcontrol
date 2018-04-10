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
            sendtask = conn.GetStream();
            startline = asc.GetBytes("def myProg(): \n");//定義開頭
            endline = asc.GetBytes("end \n");//定義結尾
        }

        public void movejoint(int jointnum,int a,int v)
        {
            sendtask.Write(startline, 0, startline.Length);

            switch(jointnum)//選擇軸1~6 選擇正反+-
            {
                case 1:
       /*             task =asc.GetBytes( "movej([6.2831852,"
                        + m_dbJ2Radian.ToString() + ","
                        + m_dbJ3Radian.ToString() + "," 
                        + m_dbJ4Radian.ToString() + "," 
                        + m_dbJ5Radian.ToString() + "," 
                        + m_dbJ6Radian.ToString() + "], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");*/
                    sendtask.Write(task, 0, task.Length);
                    break;

                case 2:

                case 3:

                case 4:

                case 5:

                case 6:

                case -1:

                case -2:

                case -3:

                case -4:

                case -5:

                case -6:

                default:
                    break;
            }

            sendtask.Write(endline, 0, endline.Length);
        }

        public void stopj(int a)
        {
            sendtask.Write(startline, 0, startline.Length);

         //   task = asc.GetBytes("stopj(" + a.Tostring() + ")\n");
            sendtask.Write(task, 0, task.Length);

            sendtask.Write(endline, 0, endline.Length);
        }
    }
}

            