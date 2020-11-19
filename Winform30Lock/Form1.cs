using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform30Lock
{
    public partial class Form1 : Form
    {
        Thread _T1;
        Thread _T2;

        Object RoomLock = new object();
        Object RoomLock2 = new object();

        int _iRoomCount = 1;
        int _iRoomCount2 = 1;
        public Form1()
        {
            InitializeComponent();
        }



        private void btnRoom1_Click(object sender, EventArgs e)
        {
            lboxRoom1.Items.Add(string.Format("Room 1 : {0} 예약", _iRoomCount));
            _T1 = new Thread(new ParameterizedThreadStart(Run));
            _T1.Start(_iRoomCount);
            _iRoomCount++;
        }

        private void Run(object obj)
        {
            lock (RoomLock)
            {
                invokeFunction(lblLockStatus, string.Format("Room 1 : Player {0} 사용 중 ", obj));

                for (int i = 1; i <= 3; i++)
                {
                    if (InvokeRequired)
                    {
                        Invoke(new Action(delegate ()
                        {
                            //lboxRoom1.Items.Add("1번 예약" + i);
                            lboxResult.Items.Add(string.Format("Room 1 : Player {0} 진행 중 ... {1}", obj, i));
                        }));
                    }
                    Thread.Sleep(1000);
                }
                invokeFunction(lblLockStatus, string.Format("Room 1 : Player {0} 사용 완료 ", obj));
            }// lock

        }


        private void invokeFunction(Label objlable, string str)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(delegate ()
                {
                    objlable.Text = str;
                }));
            }

        }

        private void btnRoom2_Click(object sender, EventArgs e)
        {
            lboxRoom2.Items.Add(string.Format("Room 2 : {0} 예약", _iRoomCount2));
            _T2 = new Thread(new ParameterizedThreadStart(Run2));
            _T2.Start(_iRoomCount);_iRoomCount2++;

        }

        private void Run2(object obj)
        {
            lock (RoomLock)
            {
                invokeFunction(lblLockStatus, string.Format("Room 2 : Player {0} 사용 중 ", obj));

                for (int i = 1; i <= 3; i++)
                {
                    if (InvokeRequired)
                    {
                        Invoke(new Action(delegate ()
                        {
                            //lboxRoom1.Items.Add("1번 예약" + i);
                            lboxResult.Items.Add(string.Format("Room 2 : Player {0} 진행 중 ... {1}", obj, i));
                        }));
                    }
                    Thread.Sleep(1000);
                }
                invokeFunction(lblLockStatus, string.Format("Room 2 : Player {0} 사용 완료 ", obj));
            }// lock


        }
    }
}
