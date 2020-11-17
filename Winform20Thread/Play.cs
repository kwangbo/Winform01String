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

namespace Winform20Thread
{
    public partial class Play : Form
    {
        public delegate int delMesage(object sender, string strResult); //delegate 선언
        public event delMesage eventdelMessagte;

        string _strPlayerName = string.Empty;
        Thread _thread = null;

        bool _bThreadStop = false;

        public string StrPlayerName { get => _strPlayerName; set => _strPlayerName = value; }

        public Play()
        {
            InitializeComponent();
        }

        public Play(string strPlayerName)
        {
            InitializeComponent();
            lblPlayerName.Text = StrPlayerName =  strPlayerName;
        }

        public void fThreadStart()
        {
            //_thread = new Thread(new ThreadStart(Run)); // ThreadStart 델리게이트 타입 객체를 생성 후 함수를 넘김 

            _thread = new Thread(Run); //컴파일러엣 데리게이트 객체를 추론해서 생성 후 함수를 넘김 ( new ThreadSart 생략)
            //_thread = new Thread(delegate () { Run(); }); //익명메소드 사용 


            _thread.Start();
        }
        private void Run()
        {
            // ui control 자신이 만들어진  thread 가 아닌 다른 thread 에서 접근할 경우 Cross Thread 발생 
            //CheckForIllegalCrossThreadCalls = false; // 충돌 예외 무시 


            try
            {
                int ivar = 0;
                Random rd = new Random();
                while (pbarPlayer.Value < 100 && !_bThreadStop )
                {
                    if (this.InvokeRequired)
                    {
                        this.Invoke(new Action(delegate ()
                        {
                            //함수값
                            ivar = rd.Next(1, 11);
                            if (pbarPlayer.Value + ivar > 100)
                            {
                                pbarPlayer.Value = 100;
                            }
                            else
                            {
                                pbarPlayer.Value = pbarPlayer.Value + ivar;

                            }
                            lblProcess.Text = string.Format("진행 상황 표시 : {0}%", pbarPlayer.Value);
                            this.Refresh();
                        }));

                        Thread.Sleep(100);

                    }// if 

                }//while 

                if (_bThreadStop)
                {
                    eventdelMessagte(this, "중도 포기 ... (Thread Stop)");
                }
                else
                {
                    eventdelMessagte(this, "완주!! (Thread Complete)");
                }
                

            }
            catch (ThreadInterruptedException exInterrupt)
            {
                exInterrupt.ToString();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }


        public void ThreadAbort()
        {
            if (_thread.IsAlive) //동작중
            {
                _thread.Abort(); // 강제 종료 
            }
            

        }
        public void ThereadJoin()
        {
            if (_thread.IsAlive)
            {
                bool bThreadEnd = _thread.Join(3000);
            }           

        }

        public void ThreadInterrupt()
        {
            if (_thread.IsAlive)
            {
                _thread.Interrupt();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //ThreadAbort();
            //ThereadJoin();
            //ThreadInterrupt();

            if (_thread.IsAlive)
            {
                _bThreadStop = true;

            }
        }


    }



}
