using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform11Inheritance
{
    public partial class Form1 : Form
    {
        COneCycle _cOC;
        CCycle _cC;
        CCar _cCar;

        public Form1()
        {
            InitializeComponent();
           
        }



        private void btnOneCycle_Click(object sender, EventArgs e)
        {
            fClearPanel();
            OneCycleDraw();
         
        }

        /// <summary>
        /// Onecycle에 대한 위치 그림을 그려준다
        /// </summary>
        private void OneCycleDraw()
        {
            lblName.Text = _cOC.strName;

            Graphics g = pMain.CreateGraphics();
            Pen p = _cOC.fPenInfo(Color.Bisque, 10);
            g.DrawRectangle(p, _cOC._rtSqare1);
            g.DrawEllipse(p, _cOC._rtCicle1);

            //CBase cb = new CBase();

            //Graphics g = pMain.CreateGraphics();
            //Pen p = new Pen(Color.Aqua);
            //g.DrawRectangle(p, 50, 50, 100,150);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _cOC = new COneCycle("외발 자전거");
            _cC = new CCycle("자전거");
            _cCar = new CCar("자동차");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                fMoving(-5);
            }
            else if(e.KeyCode == Keys.W)
            {
                fMoving(5);
            }
        }


        private void btnCycle_Click(object sender, EventArgs e)
        {
            fClearPanel();
            fCycleDraw();
        }

        private void fCycleDraw()
        {
            lblName.Text = _cC.strName;

            Graphics g = pMain.CreateGraphics();
            Pen p = _cC.fPenInfo(Color.Cyan,20);
            g.DrawRectangle(p, _cC._rtSqare1);
            g.DrawEllipse(p, _cC._rtCicle1);
            g.DrawEllipse(p, _cC._rtCicle2);

        }

        private void fClearPanel()
        {
            pMain.Invalidate();
            Refresh();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            fClearPanel();
            fCarDraw();
        }

        private void fCarDraw()
        {
            lblName.Text = _cCar.strName;

            Graphics g = pMain.CreateGraphics();
            Pen p = _cCar.fPenInfo(Color.Gold, 30);
            g.DrawRectangle(p, _cCar._rtSqare1);
            g.DrawRectangle(p, _cCar._rtSqare2);
            g.DrawEllipse(p, _cCar._rtCicle1);
            g.DrawEllipse(p, _cCar._rtCicle2);


        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            fMoving(5);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            fMoving(-5);
        }
        private void fMoving(int iMove )
        {
            fClearPanel();

            switch (lblName.Text)
            {
                case "외발 자전거":
                    _cOC.fMove(iMove);
                    OneCycleDraw();
                    break;
                case "자전거":
                    _cC.fMove(iMove);
                    fCycleDraw();
                    break;
                case "자동차":
                    _cCar.fMove(iMove);
                    fCarDraw();
                    break;
                default:
                    break;
            }
        }

}
}
