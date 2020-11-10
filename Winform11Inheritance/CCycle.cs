using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Winform11Inheritance
{
    class CCycle : COneCycle
    {
        
        public Rectangle _rtCicle2; //바퀴 두번째 
        
        public CCycle(string sName) : base(sName)
        {
            strName = sName;
            _pen = new Pen(Color.Black, 3);

            _rtCicle1 = new Rectangle(30, 150, 120, 120);
            _rtCicle2 = new Rectangle(210, 150, 120, 120);
            _rtSqare1 = new Rectangle(60, 90, 240, 60);

        }

        /// <summary>
        /// 외부에서 호출가능하도록
        /// </summary>
        /// <param name="iMove"></param>
        public override void fMove(int iMove)
        {
            base.fMove(iMove);
            //fCircle1Move(iMove);
            fCircle2Move(iMove);
            //fSquer1Move(iMove);
        }

        
        /// <summary>
        /// 내부에서만 움직인다
        /// </summary>
        /// <param name="iMove"></param>
        protected void fCircle2Move(int iMove)
        {
            Point oPoint = _rtCicle2.Location;
            oPoint.X = oPoint.X + iMove;
            _rtCicle2.Location = oPoint;

        }



    }
}
