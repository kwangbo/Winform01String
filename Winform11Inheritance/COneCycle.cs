using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Winform11Inheritance
{
    class COneCycle : CBase
    {
        public Rectangle _rtCicle1; //바퀴
        public Rectangle _rtSqare1; //몸통


        public COneCycle(string sName)
        {
            strName = sName;
            _pen = new Pen(Color.WhiteSmoke, 3);

            _rtCicle1 = new Rectangle(120, 150, 120, 120);
            _rtSqare1 = new Rectangle(150, 30, 60, 120);

        }
        public Pen fPenInfo()
        {
            return _pen;
        }

        public Pen fPenInfo(Color oColor)
        {
            _pen = new Pen(oColor);
            return _pen;
        }

        public Pen fPenInfo(Color oColor, int iWidth)
        {
            _pen = new Pen(oColor, iWidth);
            return _pen;

        }
        /// <summary>
        /// 외부에서 호출가능하도록
        /// </summary>
        /// <param name="iMove"></param>
        public virtual void fMove(int iMove)
        {
            fCircle1Move(iMove);
            fSquer1Move(iMove);
        }

        /// <summary>
        /// 내부에서만 움직인다
        /// </summary>
        /// <param name="iMove"></param>
        protected void fCircle1Move(int iMove)
        {
            Point oPoint = _rtCicle1.Location;
            oPoint.X = oPoint.X + iMove;
            _rtCicle1.Location = oPoint;

        }

        protected void fSquer1Move(int iMove)
        {
            Point oPoint = _rtSqare1.Location;
            oPoint.X = oPoint.X + iMove;
            _rtSqare1.Location = oPoint;

        }


}
}
