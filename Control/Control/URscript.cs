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

        public void movejoint(int jointnum)
        {
            sendtask.Write(startline, 0, startline.Length);

            switch(jointnum)
            {
                case 1:
                    
                    break;
                case 2:

                case 3:

                case 4:

                case 5:

                case 6:
                default:
                    break;
            }

            sendtask.Write(endline, 0, endline.Length);
        }
    }
}

            