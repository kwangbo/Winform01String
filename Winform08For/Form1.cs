using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform08For
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tboxResult.Text = string.Empty;
            StringBuilder sb = new StringBuilder();

            int iResult = 0;
            for (int i = 1; i < 10; i++)
            {
                iResult = iResult + i;
                sb.Append(string.Format("1에서 {0}까지 더하면 {1} \r\n", i, iResult));

            }
            tboxResult.Text = sb.ToString();

            //sb = sb.Clear();

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int a = 1; a <= 3; a++)
            //    {
            //        sb.Append(string.Format("{0}회차 {1} 스테이지 진행 중 ... \r\n", i, a));
            //    }
            //}
            //tboxResult.Text = sb.ToString();

        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            tboxResult.Text = string.Empty;
            string[] strArrary = { "나연", "정연", "모모", "사나", "지효"};

            StringBuilder sb = new StringBuilder();

            int i = 1;
            foreach (var oValue in strArrary)
            {
                sb.Append(string.Format("{0} 선생님은 {1}몇반입니다. \r\n", oValue, i++ ));

            }
            tboxResult.Text = sb.ToString();
            
        }
    }
}
