using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform11Inheritance
{
    class CBase
    {
        public string strName;
        protected Pen _pen;
        public CBase()
        {
            _pen = new Pen(Color.Aqua);
        }

        //public Pen fPenInfo()
        //{

        //    return _pen;
        //}

    }
}
