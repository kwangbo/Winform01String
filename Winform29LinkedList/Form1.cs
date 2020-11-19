using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform29LinkedList
{
    public partial class Form1 : Form
    {
        SortedList<DateTime, string> slScheduler = new SortedList<DateTime, string>();
        Dictionary<DateTime, string> dScheduler = new Dictionary<DateTime, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnScheduler_Click(object sender, EventArgs e)
        {
            //LinkedList<string> sLinkTest = new LinkedList<string>();
            //for (int i = 0; i < 10; i++)
            //{
            //    sLinkTest.AddLast(i.ToString());
            //}

            //var findnode = sLinkTest.Find("5");
            //sLinkTest.AddAfter(findnode, "newValue");


            
            // sorted list

            DateTime dSetDate = mcScheduler.SelectionStart;

            if (!slScheduler.ContainsKey(dSetDate))
            {
                slScheduler.Add(dSetDate, tboxScheduleer.Text);
                mcScheduler.UpdateBoldedDates();
                mcScheduler.AddBoldedDate(dSetDate);
                //lboxScheduler.Items.Add(string.Format(
                //    "{0} : {1}", dSetDate.ToString(), tboxScheduleer.Text));
            }

            lboxScheduler.Items.Clear();
            foreach (KeyValuePair<DateTime, string>  oitem in slScheduler)
            {
                lboxScheduler.Items.Add(string.Format( "{0} : {1}", oitem.Key.ToString(), oitem.Value));

            }


        }

        private void mcScheduler_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dSetdate = mcScheduler.SelectionStart;

            if (slScheduler.ContainsKey(dSetdate))
            {
                tboxScheduleer.Text = slScheduler[dSetdate];

            }
        }
    }
}
