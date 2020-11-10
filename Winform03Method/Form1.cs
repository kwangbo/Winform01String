using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform03Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // + 
        private void button1_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNum1.Text);
            int iNumB = int.Parse(tboxNum2.Text);
            int iResult = iNumA + iNumB;

            //tboxResult.Text = iResult.ToString();
            tboxResult.Text = fPlus(iNumA, iNumB).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNum1.Text);
            int iNumB = int.Parse(tboxNum2.Text);
            int iResult = iNumA  - iNumB;

            //tboxResult.Text = iResult.ToString();
            tboxResult.Text = fMinus(iNumA, iNumB).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNum1.Text);
            int iNumB = int.Parse(tboxNum2.Text);
            int iResult = iNumA * iNumB;

            //tboxResult.Text = iResult.ToString();
            tboxResult.Text = fMulti(iNumA, iNumB).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNum1.Text);
            int iNumB = int.Parse(tboxNum2.Text);
            int iResult = iNumA / iNumB;
            int iResultb = iNumA % iNumB;//몫 

            //tboxResult.Text = iResult.ToString();
            tboxResult.Text = fDivision(iNumA, iNumB).ToString();

        }


        //접근제어자 반환형 ( ) 

        private int fPlus(int iA, int iB)
        {
            int iResult = 0;
            iResult = iA + iB;
            return iResult;
        }



        private int fMinus(int iA, int iB)
        {
            int iResult = 0;
            iResult = iA - iB;
            return iResult;
        }

        private int fMulti(int iA, int iB)
        {
            int iResult = 0;
            iResult = iA * iB;
            return iResult;
        }


        private int fDivision(int iA, int iB)
        {
            int iResult = 0;
            iResult = iA / iB;
            return iResult;
        }


    }
}
