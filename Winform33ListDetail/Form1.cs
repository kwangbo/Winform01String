using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform33ListDetail
{
    public partial class Form1 : Form
    {
        //List<string>
        List<object> oList = new List<object>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataAdd();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (numPosition.Value == -1)
            {
                oList.Remove(tboxData.Text);
            }
            else
            {
                oList.RemoveAt((int)numPosition.Value);
            
            }
            lboxList.DataSource = oList.ToList<object>();
            LboxNoCreate();
            oList_DataDetil();

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            List<object> ListChange = new List<object>();
            ListChange = oList.ConvertAll<object>
                (s => s.ToString().Replace(tboxChangeOld.Text, tboxChangeNew.Text));

            lboxChangeList.DataSource = ListChange.ToList();
            oChangeList_DataDetil(ListChange);
        }

        private void tboxData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataAdd();
            }
            
        }

        private void LboxNoCreate()
        {
            List<int> iList = (Enumerable.Repeat(0, oList.Count)).ToList<int>();
            for (int i = 0; i < iList.Count; i++)
            {
                iList[i] = i + 1;
            }
            lboxNo.DataSource = iList.ToList();

        }

        private void oList_DataDetil()
        {
            tboxList.Text = null;
            int iListCount = oList.Count;
            int iListCapacity = oList.Capacity;
            string strListData = string.Join(", ", oList);

            //StringBuilder sb = new StringBuilder();
            //sb.Append("icount: " + iListCount + "\r\n");

            //string strDe = string.Format("icount : {0}", iListCount);

            string strListDetail = $@"
Capacity : {iListCapacity}

Count : {iListCount}

Data : {strListData}

";
            tboxList.Text = strListDetail;




        }

        private void DataAdd()
        {
            if (numPosition.Value == -1)
            {
                oList.Add(tboxData.Text);
            }
            else
            {
                oList.Insert((int)numPosition.Value, tboxData.Text);
            }

            lboxList.DataSource = oList.ToList<object>();
            LboxNoCreate();
            oList_DataDetil();

            tboxData.Text = "";
        }


        private void oChangeList_DataDetil(List<object> oChangeList)
        {
            tboxChangeList.Text = null;

            int iListCount = oList.Count;
            int iListCapacity = oList.Capacity;
            string strListData = string.Join(", ", oChangeList);

            //List<object> lTest = oChangeList.GetRange(3, 2);
            //oChangeList.Sort();

            string strListDetail = $@"
Capacity : {iListCapacity}

Count : {iListCount}

Data : {strListData}

";
            tboxChangeList.Text = strListDetail;




        }

    }
}
