using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Winform11Inheritance
{
    class CCar : CCycle
    {
        public Rectangle _rtSqare2; //몸통


        public CCar(string sName) : base(sName)
        {
            strName = sName;
            _pen = new Pen(Color.Blue, 3);

            _rtCicle1 = new Rectangle(60, 180, 90, 90);
            _rtCicle2 = new Rectangle(210, 180, 90, 90);
            _rtSqare1 = new Rectangle(90, 30, 180, 90);
            _rtSqare2 = new Rectangle(30, 120, 300, 60);

        }

        /// <summary>
        /// 외부에서 호출가능하도록
        /// </summary>
        /// <param name="iMove"></param>
        public override void fMove(int iMove)
        {
            base.fMove(iMove);
            //fCircle1Move(iMove);
            //fCircle2Move(iMove);
            //fSquer1Move(iMove);
            fSquer2Move(iMove);
        }
        protected void fSquer2Move(int iMove)
        {
            Point oPoint = _rtSqare2.Location;
            oPoint.X = oPoint.X + iMove;
            _rtSqare2.Location = oPoint;

        }


    }
}
