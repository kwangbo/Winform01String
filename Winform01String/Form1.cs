using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform01String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            string strText = lblText.Text;
            lblContail.Text = strText.Contains("Test").ToString();
            string[] strSplit = strText.Split(',');
            lblSplit1.Text = strSplit[0].ToString();
            lblSplit2.Text = strSplit[1].ToString();
            lblSplit3.Text = strSplit[2].ToString();


            lblReplace.Text = strText.Replace("Test", "I Can").ToString();

            lblSubstring.Text = strText.Substring(3, 5).ToString();
            lblTrim.Text = strText.Trim().ToString();





        }
    }
}
