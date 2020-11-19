using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform28Coding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //StringBuilder sb = new StringBuilder();
            //string[] strList = tboxBefore.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            //string R1 = strList[0].Replace("개똥", "사탕");
            //sb.Append(R1+"\r\n");


            //string R2 = strList[1].Replace("닭", "과자");
            //sb.Append(R2 + "\r\n");

            //string R3 = strList[2].Replace("꿩", "아이스크림");
            //sb.Append(R3 + "\r\n");

            //string R4 = strList[3].Replace("생선", "우유");
            //sb.Append(R4 + "\r\n");

            //string R5 = strList[4].Replace("알", "돈");
            //sb.Append(R5 + "\r\n");

            //tboxAfter.Text = sb.ToString();

            //2 수정

            StringBuilder sb = new StringBuilder();
            string[] strList = tboxBefore.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < strList.Length; i++)
            {
                sb.Append(fReplacreResult(strList[i], i));
            }
            
            tboxAfter.Text = sb.ToString();

        }

        private string fReplacreResult(string strBeforeText, int idgRow )
        {
            string strAfterText = string.Empty;

            strAfterText = strBeforeText.Replace(dgChangedata["CBefore", idgRow].Value.ToString(), dgChangedata["CAfter", idgRow].Value.ToString()) + "\r\n" ;

            return strAfterText;
        }
    }
}
