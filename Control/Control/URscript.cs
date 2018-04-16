using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

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

        public void movejoint(int jointnum,double a,double v,double j1,double j2,double j3,double j4,double j5,double j6)//movej
        {
            try
            {
                sendtask.Write(startline, 0, startline.Length);
            }
            catch
            {
                return;
            }
            
            switch (jointnum)//選擇軸 1~6  選擇正反 +-
            {
                case 1:
                    task =asc.GetBytes( "movej([6.2831852,"
                       + j2.ToString() + ","
                       + j3.ToString() + "," 
                       + j4.ToString() + "," 
                       + j5.ToString() + "," 
                       + j6.ToString() + "], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");                    
                    break;

                case 2:
                     task = asc.GetBytes("movej(["+j1.ToString()+",6.28,"
                        + j3.ToString() + ","
                        + j4.ToString() + ","
                        + j5.ToString() + ","
                        + j6.ToString() + "], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");                     
                     break;

                 case 3:
                    task = asc.GetBytes("movej([" + j1.ToString() + ","
                       + j2.ToString() + ",6.28,"
                       + j4.ToString() + ","
                       + j5.ToString() + ","
                       + j6.ToString() + "], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");                   
                     break;

                 case 4:
                    task = asc.GetBytes("movej([" + j1.ToString() + ","
                       + j2.ToString() + ","
                       + j3.ToString() + ",6.28,"
                       + j5.ToString() + ","
                       + j6.ToString() + "], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");                    
                     break;

                 case 5:
                    task = asc.GetBytes("movej([" + j1.ToString() + ","
                       + j2.ToString() + ","
                       + j3.ToString() + ","
                       + j4.ToString() + ",6.28,"
                       + j6.ToString() + "], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");                    
                     break;

                 case 6:
                    task = asc.GetBytes("movej([" + j1.ToString() + ","
                       + j2.ToString() + ","
                       + j3.ToString() + ","
                       + j4.ToString() + ","
                       + j5.ToString() + ",6.28], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");                   
                     break;

                 case -1:
                     task = asc.GetBytes("movej([-6.2831852,"
                         + j2.ToString() + ","
                         + j3.ToString() + ","
                         + j4.ToString() + ","
                         + j5.ToString() + ","
                         + j6.ToString() + "], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");                     
                     break;

                 case -2:
                    task = asc.GetBytes("movej([" + j1.ToString() + ",-6.28,"
                       + j3.ToString() + ","
                       + j4.ToString() + ","
                       + j5.ToString() + ","
                       + j6.ToString() + "], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");                    
                     break;

                 case -3:
                    task = asc.GetBytes("movej([" + j1.ToString() + ","
                       + j2.ToString() + ",-6.28,"
                       + j4.ToString() + ","
                       + j5.ToString() + ","
                       + j6.ToString() + "], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");                    
                     break;

                 case -4:
                    task = asc.GetBytes("movej([" + j1.ToString() + ","
                       + j2.ToString() + ","
                       + j3.ToString() + ",-6.28,"
                       + j5.ToString() + ","
                       + j6.ToString() + "], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");                    
                     break;

                 case -5:
                    task = asc.GetBytes("movej([" + j1.ToString() + ","
                       + j2.ToString() + ","
                       + j3.ToString() + ","
                       + j4.ToString() + ",-6.28,"
                       + j6.ToString() + "], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");                    
                     break;

                 case -6:
                    task = asc.GetBytes("movej([" + j1.ToString() + ","
                       + j2.ToString() + ","
                       + j3.ToString() + ","
                       + j4.ToString() + ","
                       + j5.ToString() + ",-6.28], a=" + a.ToString() + ", v=" + v.ToString() + ")\n");                    
                     break;

                default:
                    break;
            }

            sendtask.Write(task, 0, task.Length);
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

        public void movel(int direction, double a, double v, double X_axis, double Y_axis, double Z_axis, double Rx, double Ry, double Rz)//movel
        {
            try
            {
                sendtask.Write(startline, 0, startline.Length);
            }
            catch
            {
                return;
            }

            switch(direction)//1->x 2->y 3->z 4->rx 5->ry 6->rz   方向選擇+-
            {
                case 1:
                    task = asc.GetBytes("movel(get_inverse_kin(p[" + (X_axis / 1000 + 0.1).ToString() 
                    + "," + (Y_axis / 1000).ToString()
                    + "," + (Z_axis / 1000).ToString()
                    + "," + Rx.ToString() + ","
                    + Ry.ToString() + ","
                    + Rz.ToString() + "]),a=" + (a * 2).ToString() + ",v=" + (v / 2).ToString() + ")\n");
                    break;
                case 2:
                    task = asc.GetBytes("movel(get_inverse_kin(p[" + (X_axis / 1000).ToString()
                    + "," + (Y_axis / 1000+0.1).ToString()
                    + "," + (Z_axis / 1000).ToString()
                    + "," + Rx.ToString() + ","
                    + Ry.ToString() + ","
                    + Rz.ToString() + "]),a=" + (a * 2).ToString() + ",v=" + (v / 2).ToString() + ")\n");
                    break;
                case 3:
                    task = asc.GetBytes("movel(get_inverse_kin(p[" + (X_axis / 1000).ToString()
                    + "," + (Y_axis / 1000).ToString()
                    + "," + (Z_axis / 1000+0.1).ToString()
                    + "," + Rx.ToString() + ","
                    + Ry.ToString() + ","
                    + Rz.ToString() + "]),a=" + (a * 2).ToString() + ",v=" + (v / 2).ToString() + ")\n");
                    break;
                case 4:
                    task = asc.GetBytes("movel(get_inverse_kin(p[" + (X_axis / 1000).ToString()
                    + "," + (Y_axis / 1000).ToString()
                    + "," + (Z_axis / 1000).ToString()
                    + "," + (Rx+1).ToString() + ","
                    + Ry.ToString() + ","
                    + Rz.ToString() + "]),a=" + (a * 2).ToString() + ",v=" + (v / 2).ToString() + ")\n");
                    break;
                case 5:
                    task = asc.GetBytes("movel(get_inverse_kin(p[" + (X_axis / 1000).ToString()
                    + "," + (Y_axis / 1000).ToString()
                    + "," + (Z_axis / 1000).ToString()
                    + "," + Rx.ToString() + "," 
                    + (Ry+1).ToString() + ","
                    + Rz.ToString() + "]),a=" + (a * 2).ToString() + ",v=" + (v / 2).ToString() + ")\n");
                    break;
                case 6:
                    task = asc.GetBytes("movel(get_inverse_kin(p[" + (X_axis / 1000).ToString()
                    + "," + (Y_axis / 1000).ToString()
                    + "," + (Z_axis / 1000).ToString()
                    + "," + Rx.ToString() 
                    + "," + Ry.ToString() 
                    + "," + (Rz+1).ToString() + "]),a=" + (a * 2).ToString() + ",v=" + (v / 2).ToString() + ")\n");
                    break;
                case -1:
                    task = asc.GetBytes("movel(get_inverse_kin(p[" + (X_axis / 1000-0.1).ToString()
                    + "," + (Y_axis / 1000).ToString()
                    + "," + (Z_axis / 1000).ToString()
                    + "," + Rx.ToString() + ","
                    + Ry.ToString() + ","
                    + Rz.ToString() + "]),a=" + (a * 2).ToString() + ",v=" + (v / 2).ToString() + ")\n");
                    break;
                case -2:
                    task = asc.GetBytes("movel(get_inverse_kin(p[" + (X_axis / 1000).ToString()
                    + "," + (Y_axis / 1000-0.1).ToString()
                    + "," + (Z_axis / 1000).ToString()
                    + "," + Rx.ToString() + ","
                    + Ry.ToString() + ","
                    + Rz.ToString() + "]),a=" + (a * 2).ToString() + ",v=" + (v / 2).ToString() + ")\n");
                    break;
                case -3:
                    task = asc.GetBytes("movel(get_inverse_kin(p[" + (X_axis / 1000).ToString()
                    + "," + (Y_axis / 1000).ToString()
                    + "," + (Z_axis / 1000-0.1).ToString()
                    + "," + Rx.ToString() + ","
                    + Ry.ToString() + ","
                    + Rz.ToString() + "]),a=" + (a * 2).ToString() + ",v=" + (v / 2).ToString() + ")\n");
                    break;
                case -4:
                    task = asc.GetBytes("movel(get_inverse_kin(p[" + (X_axis / 1000).ToString()
                    + "," + (Y_axis / 1000).ToString()
                    + "," + (Z_axis / 1000).ToString()
                    + "," + (Rx-1).ToString() 
                    + "," + Ry.ToString() 
                    + "," + Rz.ToString() + "]),a=" + (a * 2).ToString() + ",v=" + (v / 2).ToString() + ")\n");
                    break;
                case -5:
                    task = asc.GetBytes("movel(get_inverse_kin(p[" + (X_axis / 1000).ToString()
                    + "," + (Y_axis / 1000).ToString()
                    + "," + (Z_axis / 1000).ToString()
                    + "," + Rx.ToString() 
                    + "," + (Ry-1).ToString() 
                    + "," + Rz.ToString() + "]),a=" + (a * 2).ToString() + ",v=" + (v / 2).ToString() + ")\n");
                    break;
                case -6:
                    task = asc.GetBytes("movel(get_inverse_kin(p[" + (X_axis / 1000).ToString()
                    + "," + (Y_axis / 1000).ToString()
                    + "," + (Z_axis / 1000).ToString()
                    + "," + Rx.ToString() 
                    + "," + Ry.ToString() 
                    + "," + (Rz-1).ToString() + "]),a=" + (a * 2).ToString() + ",v=" + (v / 2).ToString() + ")\n");
                    break;
                default:
                    break;
            }

            sendtask.Write(task, 0, task.Length);
            sendtask.Write(endline, 0, endline.Length);
        }

        public void stopl(double a)
        {
            try
            {
                sendtask.Write(startline, 0, startline.Length);
            }
            catch
            {
                return;
            }

            task = asc.GetBytes("stopl(a="+(a*2).ToString()+")\n");
            sendtask.Write(task, 0, task.Length);

            sendtask.Write(endline, 0, endline.Length);
        }

        public void digital_output(int point,bool act)//dio控制
        {
            try
            {
                sendtask.Write(startline, 0, startline.Length);
            }
            catch
            {
                return;
            }

            task = asc.GetBytes("set_standard_digital_out("+point.ToString()+","+act.ToString()+")\n");
            sendtask.Write(task, 0, task.Length);

            sendtask.Write(endline, 0, endline.Length);
        }

        public void do_work(FileInfo f)//讀檔執行
        {
            StreamReader read = f.OpenText();//讀檔執行
            string readline;
            sendtask.Write(startline, 0, startline.Length);

            while ((readline = read.ReadLine()) != null)//送各行動作
            {
                task = asc.GetBytes(readline + "\n");
                sendtask.Write(task, 0, task.Length);
            }

            sendtask.Write(endline, 0, endline.Length);
        }
    }
}

            