using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform09While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            // 1~ 25 6개의 번호 
            // List<int> iList = new List<int>();

            int[] iArray = new int[6];
            int iCount = 0;

            StringBuilder sb = new StringBuilder();
            Random rd = new Random();

            // iArray 다 안차면 계속 진행 
            while (Array.IndexOf(iArray, 0) != -1)
            {
                int iNumber = rd.Next(1, 46); //  1~ 45 까지 
                int i = Array.IndexOf(iArray, 0);
                if (Array.IndexOf(iArray, iNumber) == -1 )
                {
                    iArray[iCount] = iNumber;
                    //sb.Append(string.Format("{0}, ", iNumber));
                    iCount++;
                }
            }

            //배열 sort 
            //배열값을 

            Array.Sort(iArray);
            foreach (int iNum in iArray)
            {
                sb.Append(string.Format("{0}, ", iNum));
            }
            
            lblWhileResult.Text = sb.ToString();
            lboxWhileResult.Items.Add(sb.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int iNumber = int.Parse(tboxNumber.Text);


            if (iNumber < 1 || iNumber > 100)
            {
                MessageBox.Show("1~100 사이의 숫자를 지정해 주세요");
                return;
            }
            int iCheckNumber = 0;
            int iCount = 0;

            do
            {
                iCheckNumber = rd.Next(1, 101);
                iCount++;
            } while (iNumber != iCheckNumber);

            lblWhileend.Text = string.Format("-뽑은 수자 {0}를 {1}회만에 찾았습니다.", iNumber, iCount);
        }
    }
}
