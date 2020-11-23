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
    class CDoor : CBase
    {
        public Rectangle _rtDoorSide;  // Door 테두리
        public Rectangle _rtDoor;  // Door

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="sName"></param>
        public CDoor(string sName)
        {
            strName = sName;  // 클래스를 생성 할 때 이름을 가져와서 strName에 넣어 줌
            _Pen = new Pen(Color.WhiteSmoke, 3);  // 펜에 대한 색상과 굵기를 설정
            _Brush = new SolidBrush(Color.WhiteSmoke);  // 내부를 채울 색상

            _rtDoorSide = new Rectangle(10, 70, 20, 60);  // 시작은 같은 위치여도 상관 없을 듯
            _rtDoor = new Rectangle(10, 70, 20, 60);
            
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


        #region Door 만 위아래로 이동 필요


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
            Point oPoint = _rtDoor.Location;
            oPoint.Y = oPoint.Y + iMove;
            _rtDoor.Location = oPoint;
        }




        #endregion
    }
}

