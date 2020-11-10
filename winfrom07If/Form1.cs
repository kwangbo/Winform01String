using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winfrom07If
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iNumber1 = (int)nNumber1.Value;
            int iNumber2 = (int)nNumber2.Value;

            if (iNumber1 > iNumber2)
            {
                lblResultIf.Text = string.Format(" - Number1이 Number2보다 {0} 더 큽니다.", iNumber1 - iNumber2);

            }
            else if (iNumber1 < iNumber2)
            {
                lblResultIf.Text = string.Format(" - Number2가 Number1보다 {0} 더 큽니다.", iNumber2 - iNumber1);
            }
            else
            {
                lblResultIf.Text = string.Format("- 두 숫자는 같습니다.: {0}", iNumber1.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strSelect = cboxDay.Text;
            switch (strSelect)
            {
                case "월":
                    lblswitchResult.Text = "- 선택 날짜는 월요일 입니다.";
                    break;
                case "화":
                    lblswitchResult.Text = "- 선택 날짜는 화요일 입니다.";
                    break;
                case "수":
                    lblswitchResult.Text = "- 선택 날짜는 수요일 입니다.";
                    break;
                case "목":
                case "금":
                    lblswitchResult.Text = "- 선택 날짜는 목 금 요일 입니다.";
                    break;
                default:
                    break;
            }
        }
    }
}
