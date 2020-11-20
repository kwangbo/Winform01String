using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 문자열보간
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string S1 = tbox1Value1.Text;
            string S2 = tbox1Value2.Text;


            string strValue0 = S1 + S2; //제일빠름 

            string strValue = string.Format("{0} is {1}", S1, S2);
            lboxStringFormat.Items.Add(strValue);

            string strValue2 = $"{S1} is {S2}";
            lboxStringInterpolation.Items.Add(strValue2);



        }

        private void btn2_Click(object sender, EventArgs e)
        {
            DateTime dt = dtPicker.Value;
            lboxStringFormat.Items.Add(string.Format("오늘은 {0:yyyy-MM-dd} 입니다. ",dt));
            lboxStringInterpolation.Items.Add($"오늘은 {dt:yyyy-MM-dd} 입니다.");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int i1 = (int)num1.Value;
            int i2 = (int)num2.Value;

            int iBigCount = (i1 > i2) ? i1 : i2;
            lboxStringFormat.Items.Add(string.Format("{0} {1} {2}", i1, i2, iBigCount));

            lboxStringInterpolation.Items.Add($"{i1} {i2} { ((i1 > i2) ? i1 : i2)} ");

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string strValue = "str";
            lboxStringFormat.Items.Add(string.Format("{{{0}}}", strValue));
            lboxStringInterpolation.Items.Add($" {{{strValue}}}");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string strValue = tbox5Value.Text;

            lboxStringFormat.Items.Add(string.Format(" {0} ", strValue.ToUpper()));
            lboxStringInterpolation.Items.Add($"{strValue.ToUpper()}");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string strValue = "D:\\prepare\\11.c#\vs2013\\Winform12\\Winform32CopyAndPaste\\bin\\Debug";
            tbox6Value.Text = strValue;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string strR1 = "Test1";
            string strR2 = "Test2";

            //string strQuery = "Select " +
            //                  "Row_1, " +
            //                  "Row_2";

            string strQuery = $@"
                                 select 
                                        row_1,
                                        row_2
                                 from tb_table
                                 where 
                                        row1 ={strR2}";
            tbox7Value.Text = strQuery;
        }
    }
}
