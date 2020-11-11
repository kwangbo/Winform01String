using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> _strlist = new List<string>();
        List<int> _intList = new List<int>();
        ArrayList _arList = new ArrayList();


        public Form1()
        {
            InitializeComponent();
            //dgViewList.Columns.Add("dgValue", "Value");
        }

        

        

        private void pBox_Click(object sender, EventArgs e)
        {
            PictureBox pbox = sender as PictureBox;
            string strSelectText = string.Empty;

            switch (pbox.Name)
            {
                case "pBox1":
                    strSelectText = "cake";
                    break;

                case "pBox2":
                    strSelectText = "burger";
                    break;

                case "pBox3":
                    strSelectText = "pizza";
                    break;

                case "pBox4":
                    strSelectText = "ice";
                    break;
                default:
                    break;
            }

            _strlist.Add(strSelectText);
            fUiDisplay();
            fDataGridViewDisplay();

            //_arList.Add(strSelectText);
            //_arList.Add(1);


        }

        private void fUiDisplay()
        {
            int iCake = 0;
            int iBurger = 0;
            int iPizza = 0;
            int iIce = 0;

            foreach (string oitem in _strlist)
            {
                switch (oitem)
                {
                    case "cake":
                        iCake++;
                        break;
                    case "burger":
                        iBurger++;
                        break;
                    case "pizza":
                        iPizza++;
                        break;
                    case "ice":
                        iIce++;
                        break;
                    default:
                        break;
                }
            }

            lblPick1.Text = iCake.ToString();
            lblPick2.Text = iBurger.ToString();
            lblPick3.Text = iPizza.ToString();
            lblPick4.Text = iIce.ToString();

            lbltotalCount.Text = _strlist.Count.ToString();



        }

        private void fDataGridViewDisplay()
        {

            dgViewList.DataSource = _strlist.Select(x => new { value = x }).ToList();

            //dgViewList.Rows.Clear();

            //foreach  ( string oitem in _strlist)
            //{
            //    dgViewList.Rows.Add(oitem);
            //}

            foreach (DataGridViewRow oRow in dgViewList.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();

            }
            dgViewList.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
