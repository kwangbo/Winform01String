using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sync_Ansync
{
    /// <summary>
    /// CBase를 상속 받은 Robot 클래스
    /// </summary>
    class CRobot : CBase
    {
        public Rectangle _rtCircle_Robot;  // Robot 몸통
        public Rectangle _rtSquare_Arm;  // Robot 팔
        public Rectangle _rtSquare_Object;  // Robot이 가지고 움직 일 물건

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="sName"></param>
        public CRobot(string sName)
        {
            strName = sName;  // 클래스를 생성 할 때 이름을 가져와서 strName에 넣어 줌
            _Pen = new Pen(Color.WhiteSmoke, 3);  // 펜에 대한 색상과 굵기를 설정
            _Brush = new SolidBrush(Color.WhiteSmoke);  // 내부를 채울 색상

            _rtCircle_Robot = new Rectangle(50, 50, 100, 100);  // 몸통에 대한 위치 및 크기를 설정
            _rtSquare_Arm = new Rectangle(40, 90, 80, 20);  // 팔에 대한 위치 및 크기를 설정
            _rtSquare_Object = new Rectangle(20, 80, 20, 40);

        }

        /// <summary>
        /// 설정 되어 있는 Pen에 대한 정보를 반환
        /// </summary>
        /// <returns></returns>
        public Pen fPenInfo()
        {
            return _Pen;
        }

        public SolidBrush fBrushInfo()
        {
            return _Brush;
        }


        #region Robot 몸통은 회전, 팔을 회전 이동 필요


        /// <summary>
        /// 외부에서 그림의 위치를 이동시키는 함수를 호출
        /// </summary>
        /// <param name="iMove"></param>
        public void fMove(int iMove)
        {
            fSquare1Move(iMove);
        }


        /// <summary>
        /// 몸통1의 위치를 가져와서 X 위치값을 이동 시키고 다시 바퀴1에 위치 정보를 넣어줌
        /// </summary>
        /// <param name="iMove"></param>
        protected void fSquare1Move(int iMove)
        {
            // Robot Arm을 움직임
            Point oPoint = _rtSquare_Arm.Location;
            oPoint.X = oPoint.X + iMove;
            _rtSquare_Arm.Location = oPoint;

            // Robot Object도 Arm과 함께 움직임 (필요 시 화면에 표시 할지 말지만 정함)
            oPoint = _rtSquare_Object.Location;
            oPoint.X = oPoint.X + iMove;
            _rtSquare_Object.Location = oPoint;
        }


        #endregion
    }
}

