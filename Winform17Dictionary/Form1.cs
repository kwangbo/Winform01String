using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform17Dictionary
{
    public partial class Form1 : Form
    {

        enum enBossName
        {
            보검,
            신혜,
            해인,
            보영,
        }

        enum enClassName
        {
           진,
           정국, 
           RM,
           지민,
           제이홈,
           뷔,
           슈가,
           은비,
           사쿠라,
           혜원,
           예나,
           체연,
           채원,
           민주,
           히토미,
           유리,
           유진,
           원영,
           나코,
        }

        Hashtable _ht = new Hashtable();

        Dictionary<string, string> _dic = new Dictionary<string, string>();

        int iPlayercount = 0;
        
        
        List<string> _strlist = new List<string>();

        //List<int> _intList = new List<int>();
        //ArrayList _arList = new ArrayList();


        public Form1()
        {
            InitializeComponent();

            //dgViewList.Columns.Add("dgKey", "Key");
            //dgViewList.Columns.Add("dgValue", "Value");
        }





        private void pBox_Click(object sender, EventArgs e)
        {
            PictureBox pbox = sender as PictureBox;
            string strSelectText = string.Empty;

            switch (pbox.Name)
            {
                case "pBox1":
                    strSelectText = enBossName.보검.ToString();
                    break;

                case "pBox2":
                    strSelectText = enBossName.신혜.ToString();
                    break;

                case "pBox3":
                    strSelectText = enBossName.해인.ToString();
                    break;

                case "pBox4":
                    strSelectText = enBossName.보영.ToString();
                    break;
                default:
                    break;
            }


            int iTotalCount = Enum.GetValues(typeof(enClassName)).Length;
            if (iTotalCount > iPlayercount)
            {
                enClassName enName = (enClassName)iPlayercount;
                
                _dic.Add(enName.ToString(), strSelectText);

                fUiDisplay(iTotalCount, enName.ToString());
                fDataGridViewDisplay();

                iPlayercount++;
            }
            else
            {
                // 끝났습니다.
                lblPlayerName.Text = "투표를 완료하였습니다.";

            }

            //pBox1.Image = Winform17Dictionary.Properties.Resources._1;

            //_dic.Add("", strSelectText);





            //_strlist.Add(strSelectText);
            //fUiDisplay();
            //fDataGridViewDisplay();

            //_arList.Add(strSelectText);
            //_arList.Add(1);


        }

        private void fUiDisplay(int iTotalCount, string strPlayerName)
        {
            int i보검 = 0;
            int i신혜 = 0;
            int i해인 = 0;
            int i보영 = 0;

            foreach (string oitem in _strlist)
            {
                switch (oitem)
                {
                    case "보검":
                        i보검++;
                        break;
                    case "신혜":
                        i신혜++;
                        break;
                    case "해인":
                        i해인++;
                        break;
                    case "보영":
                        i보영++;
                        break;
                    default:
                        break;
                }
            }

            lblPick1.Text = i보검.ToString();
            lblPick2.Text = i신혜.ToString();
            lblPick3.Text = i해인.ToString();
            lblPick4.Text = i보영.ToString();

            //0/ 0 
            lblTotalCount.Text = string.Format("{0} / {1}", iPlayercount + 1 ,iTotalCount );
            lblPlayerName.Text = strPlayerName;
            
        }

        private void fDataGridViewDisplay()
        {

            //dgViewList.DataSource = _strlist.Select(x => new { value = x }).ToList();

            dgViewList.DataSource = _dic.ToArray();

            //dgViewList.Rows.Clear();

            //foreach  ( string oitem in _strlist)
            //{
            //    dgViewList.Rows.Add(oitem);
            //}

            //foreach (KeyValuePair<string, string> oitem in _dic)
            //{
            //    dgViewList.Rows.Add(oitem.Key, oitem.Value);
            //}

            foreach (DataGridViewRow oRow in dgViewList.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();

            }
            dgViewList.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
