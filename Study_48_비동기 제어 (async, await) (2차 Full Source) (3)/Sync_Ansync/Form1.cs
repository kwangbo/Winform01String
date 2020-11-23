using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sync_Ansync
{
    public partial class Form1 : Form
    {

        #region 전역

        CRobot _cRobot;  // Robot Class
        CDoor _cDoor1, _cDoor2;  // Door Class
        int _iRobot_Rotate = 0;  // Robot Rotate
        int _iSpeed = 100;  // Thread Sleep Time
        bool _bObjectExist = false;   // Robot이 Object를 가지고 있는지 여부

        #endregion


        public Form1()
        {
            InitializeComponent();
        }


        #region Event

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form Load 시점에 Class 생성
            _cRobot = new CRobot("Robot");
            _cDoor1 = new CDoor("DoorLeft");
            _cDoor2 = new CDoor("DoorRight");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "btnInit":
                    //fRobotDraw(_iRobot_Rotate, 0, false);
                    //fDoor1Draw(0);
                    //fDoor2Draw(0);
                    initDraw();
                    break;
                case "btnD1Open":
                    Door1Open();
                    break;
                case "btnD1Close":
                    Door1Close();
                    break;
                case "btnD2Open":
                    Door2Open();
                    break;
                case "btnD2Close":
                    Door2Close();
                    break;
                case "btnRobotE":
                    RobotArmExtend();
                    break;
                case "btnRobotR":
                    RobotArmRetract();
                    break;
                case "btnRobotRotate":
                    RobotRotate();
                    break;
                case "btnSimulation":
                    Start_Move();
                    break;
                case "btnSimulationAsync":
                    Start_Move_Async();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 동작 속도 값 변경 시 바로 적용
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int iRet))
            {
                //_iSpeed = int.Parse(textBox1.Text);
                _iSpeed = iRet;
            }
        }
        #endregion



        #region function

        /// <summary>
        /// 상태가 틀어 졌을 경우 초기 상태를 맞춰 주기 위해 추가
        /// </summary>
        private void initDraw()
        {
            _cRobot = null;
            _cDoor1 = null;
            _cDoor2 = null;
            _iRobot_Rotate = 0;

            _cRobot = new CRobot("Robot");
            _cDoor1 = new CDoor("DoorLeft");
            _cDoor2 = new CDoor("DoorRight");

            fRobotDraw(_iRobot_Rotate, 0, false);
            fDoor1Draw(0);
            fDoor2Draw(0);
        }

        /// <summary>
        /// Panel에 Robot을 Draw
        /// </summary>
        /// <param name="iRotate"></param>
        /// <param name="iRobot_Arm_Move"></param>
        /// <param name="isObject"></param>
        private void fRobotDraw(int iRotate, int iRobot_Arm_Move, bool isObject)
        {
            this.Invoke(new Action(delegate ()
            {
                pRobot.Refresh();

                Graphics g = pRobot.CreateGraphics();
            
                g.FillEllipse(_cRobot.fBrushInfo(), _cRobot._rtCircle_Robot);

                _cRobot.fMove(iRobot_Arm_Move);

                Point center = new Point(100, 100);
                g.Transform = GetMatrix(center, iRotate);

                g.DrawRectangle(_cRobot.fPenInfo(), _cRobot._rtSquare_Arm);

                // Object가 있을 경우 표시 하고 없을 경우 표시 하지 않음
                if (isObject)
                {
                    g.FillRectangle(_cRobot.fBrushInfo(), _cRobot._rtSquare_Object);
                }
            }));
        }

        /// <summary>
        /// Panel에 Door 1을 Draw
        /// </summary>
        /// <param name="Move"></param>
        private void fDoor1Draw(int Move)
        {
            this.Invoke(new Action(delegate ()
            {
                pDoor1.Refresh();

                _cDoor1.fMove(Move);

                Graphics g = pDoor1.CreateGraphics();

                g.FillRectangle(_cDoor1.fBrushInfo(), _cDoor1._rtDoor);
                g.DrawRectangle(_cDoor1.fPenInfo(), _cDoor1._rtDoorSide);
            }));
        }

        /// <summary>
        /// Panel에 Door 2를 Draw
        /// </summary>
        /// <param name="Move"></param>
        private void fDoor2Draw(int Move)
        {
            this.Invoke(new Action(delegate ()
            {
                pDoor2.Refresh();

                _cDoor2.fMove(Move);

                Graphics g = pDoor2.CreateGraphics();

                g.FillRectangle(_cDoor2.fBrushInfo(), _cDoor2._rtDoor);
                g.DrawRectangle(_cDoor2.fPenInfo(), _cDoor2._rtDoorSide);
            }));
        }


        // Robot 회전 시 사용 하는 함수 (실제 Robot이 회전하는게 아니고 Robot Arm을 Robot 중심 기준으로 회전 시킴)
        private Matrix GetMatrix(Point centerPoint, float rotateAngle)
        {
            Matrix matrix = new Matrix();

            matrix.RotateAt(rotateAngle, centerPoint);

            return matrix;
        }

        #endregion



        #region Task

        /// <summary>
        /// 함수가 종료 되고 난 뒤에 다음 함수를 호출 (전체 동작을 감싸는 Task를 하나 생성 후 Task 내에서 동기 동작)
        /// </summary>
        private void Start_Move()
        {
            Task.Run(() =>
            {
                Log(enLogLevel.Info_L2, "Move Sequence Start");

                Door1Open();
                RobotArmExtend();
                Thread.Sleep(500);
                _bObjectExist = true;  // 팔을 뻗고 물건을 가지고 나오고
                RobotArmRetract();
                Door1Close();
                RobotRotate();
                Door2Open();
                RobotArmExtend();
                Thread.Sleep(500);
                _bObjectExist = false;  // 팔을 뻗고 물건을 놔두고 나옴
                RobotArmRetract();
                Door2Close();
                RobotRotate();

                Log(enLogLevel.Info_L2, "Move Sequence Complete");
            });
        }


        /// <summary>
        /// 비동기 제어 : 함수 호출 시 Task를 생성 해서 비동기로 진행 하나 필요에 따라 await를 가지고 함수의 종료를 대기
        /// </summary>
        private async void Start_Move_Async()
        {
            Log(enLogLevel.Info_L2, "Move Async Sequence Start");

            // 동시 동작 하는 부분의 경우 긴 시간 기준으로 대기 하도록 함
            Task vTask;

            vTask = Task.Run(() => RobotArmExtend());
            await Task.Run(() => Door1Open());

            Thread.Sleep(500);
            _bObjectExist = true;  // 팔을 뻗고 물건을 가지고 나오고
            await Task.Run(() => RobotArmRetract());

            vTask = Task.Run(() => Door1Close());
            await Task.Run(() => Call_RobotRotate());

            vTask = Task.Run(() => RobotArmExtend());
            await Task.Run(() => Call_Door2Open());

            Thread.Sleep(500);
            _bObjectExist = false;  // 팔을 뻗고 물건을 가지고 나오고
            await Task.Run(() => RobotArmRetract());

            vTask = Task.Run(() => Door2Close());
            await Task.Run(() => Call_RobotRotate());

            Log(enLogLevel.Info_L2, "Move Async Sequence Complete");


            /*
            //Call_RobotArmExtend();
            //await Call_Door1Open();

            Thread.Sleep(500);
            _bObjectExist = true;  // 팔을 뻗고 물건을 가지고 나오고
            await Call_RobotArmRetract();

            Call_Door1Close();
            await Call_RobotRotate();

            Call_RobotArmExtend();
            await Call_Door2Open();

            Thread.Sleep(500);
            _bObjectExist = false;  // 팔을 뻗고 물건을 놔두고 나옴
            await Call_RobotArmRetract();

            Call_Door2Close();
            await Call_RobotRotate();
            */
        }
        #endregion



        #region 단위 동작


        private int Door1Open()
        {
            Log(enLogLevel.Info_L1, "Door1 Open Start");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(_iSpeed);
                //_iDoor1Move = -5;
                fDoor1Draw(-5);
            }

            Log(enLogLevel.Info_L1, "Door1 Open Complete");

            return 0;
        }


        private int Door1Close()
        {
            Log(enLogLevel.Info_L1, "Door1 Close Start");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(_iSpeed);
                //_iDoor1Move = 5;
                fDoor1Draw(5);
            }

            Log(enLogLevel.Info_L1, "Door1 Close Complete");

            return 0;
        }

        /*
        // 1번 문 Open
        private async Task<int> Door1OpenAsync()
        {
            var vTask = Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(_iSpeed);
                    //_iDoor1Move = -5;
                    fDoor1Draw(-5);
                }
            });

            await vTask;

            return 0;
        }
       

        // 1번 문 Close
        private async Task<int> Door1CloseAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(_iSpeed);
                //_iDoor1Move = 5;
                fDoor2Draw(5);
            }

            return 0;
        }
        */

        // 2번 문 Open
        private int Door2Open()
        {
            Log(enLogLevel.Info_L1, "Door2 Open Start");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(_iSpeed);
                fDoor2Draw(-5);
            }

            Log(enLogLevel.Info_L1, "Door2 Open Complete");

            return 0;
        }


        // 2번 문 Close
        private int Door2Close()
        {
            Log(enLogLevel.Info_L1, "Door2 Close Start");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(_iSpeed);
                fDoor2Draw(5);
            }

            Log(enLogLevel.Info_L1, "Door2 Close Complete");

            return 0;
        }


        // Robot Arm Extend (Robot의 팔을 뻗는다)
        private int RobotArmExtend()
        {
            Log(enLogLevel.Info_L1, "Robot Arm Extend Start");

            // Robot Arm Extend
            for (int i = 0; i < 8; i++)
            {
                Thread.Sleep(_iSpeed);
                fRobotDraw(_iRobot_Rotate, -5, _bObjectExist);
            }

            Log(enLogLevel.Info_L1, "Robot Arm Extend Complete");

            return 0;
        }


        // Robot Arm Retract (Robot의 팔을 접는다)
        private int RobotArmRetract()
        {
            Log(enLogLevel.Info_L1, "Robot Arm Retract Start");

            // Robot Arm Retract
            for (int i = 0; i < 8; i++)
            {
                Thread.Sleep(_iSpeed);
                fRobotDraw(_iRobot_Rotate, 5, _bObjectExist);
            }

            Log(enLogLevel.Info_L1, "Robot Arm Retract Complete");

            return 0;
        }



        // Robot Rotate (Robot을 회전 시킴)
        private int RobotRotate()
        {
            Log(enLogLevel.Info_L1, "Robot Rotate Start");

            for (int i = 0; i < 12; i++)
            {
                Thread.Sleep(_iSpeed);
                _iRobot_Rotate = _iRobot_Rotate + 15;

                fRobotDraw(_iRobot_Rotate, 0, _bObjectExist);
            }

            // 회전을 완료 한 뒤 회전각이 360을 넘어 가면 360 만큼 빼줌
            if (_iRobot_Rotate > 360) _iRobot_Rotate -= 360;

            Log(enLogLevel.Info_L1, "Robot Rotate Complete");

            return 0;
        }



        #endregion



        #region 비동기 호출 Call 함수 (필요 없지만 참고용으로 사용)

        private Task<int> Call_Door1Open()
        {
            var vTask = Task.Run(() => Door1Open());

            return vTask;
        }


        private Task<int> Call_Door1Close()
        {
            var vTask = Task.Run(() => Door1Close());

            return vTask;
        }

        private Task<int> Call_Door2Open()
        {
            var vTask = Task.Run(() => Door2Open());

            return vTask;
        }


        private Task<int> Call_Door2Close()
        {
            var vTask = Task.Run(() => Door2Close());

            return vTask;
        }

        private Task<int> Call_RobotArmExtend()
        {
            var vTask = Task.Run(() => RobotArmExtend());

            return vTask;
        }


        private Task<int> Call_RobotArmRetract()
        {
            var vTask = Task.Run(() => RobotArmRetract());

            return vTask;
        }

        private Task<int> Call_RobotRotate()
        {
            var vTask = Task.Run(() => RobotRotate());

            return vTask;
        }
        #endregion



        #region Log Viewer 

        // Log Level을 지정 할 Enum (44강 Tree View 참조)
        enum enLogLevel
        {
            Info_L1,
            Info_L2,
            Info_L3,
            Warning,
            Error,
        }

        private void Log(enLogLevel eLevel, string LogDesc)
        {
            this.Invoke(new Action(delegate ()
            {
                DateTime dTime = DateTime.Now;
                string LogInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{eLevel.ToString()}] {LogDesc}";
                lboxLog.Items.Insert(0, LogInfo);
            }));
        }

        private void Log(DateTime dTime, enLogLevel eLevel, string LogDesc)
        {
            this.Invoke(new Action(delegate ()
            {
                string LogInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{eLevel.ToString()}] {LogDesc}";
                lboxLog.Items.Insert(0, LogInfo);
            }));
        }

        #endregion

    }
}
