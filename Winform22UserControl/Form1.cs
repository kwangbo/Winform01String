using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform22UserControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        //    ucInfo1.eventdelSender += UcInfo1_eventdelSender;

        }

        //private int UcInfo1_eventdelSender(object Sender, string strText)
        //{
        //    lboxList.Items.Add(string.Format("{0} {1} ", ucInfo1.UserNo, strText));
        //    return 0;
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var oControl in pMain.Controls)
            {
                if (oControl is UCInfo)
                {
                    UCInfo oInfo = oControl as UCInfo;
                    oInfo.eventdelSender += OInfo_eventdelSender;
                }
            }
        }

        private int OInfo_eventdelSender(object Sender, string strText)
        {
            UCInfo oInfo = Sender as UCInfo;
            lboxList.Items.Add(string.Format("{0} {1} ", oInfo.UserNo, strText));
            return 0;
        }
    }
}
