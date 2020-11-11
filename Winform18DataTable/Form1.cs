using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform18DataTable
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet(); // 반 정보 
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            //table 존재하는지 check
            bool bCheckisTable = false;
            if (ds.Tables.Contains(cboxRegClass.Text))
            {
                bCheckisTable = true;
            }

            //foreach (DataTable item in ds.Tables)
            //{
            //    if (item.TableName.Contains(cboxRegClass.Text))
            //    {
            //        bCheckisTable = true;
            //    }

            //}

            DataTable dt = null;

            if (!bCheckisTable)
            {
                dt = new DataTable(cboxRegClass.Text);
                DataColumn colName = new DataColumn("NAME", typeof(string));
                DataColumn colSex = new DataColumn("SEX", typeof(string));
                DataColumn colRef = new DataColumn("REF", typeof(string));

                dt.Columns.Add(colName);
                dt.Columns.Add(colSex);
                dt.Columns.Add(colRef);
            }
            else 
            { //테이블 있음
                dt = ds.Tables[cboxRegClass.Text];
            }


            //row 자료 등록
            DataRow row = dt.NewRow();

            row["NAME"] = tboxRegName.Text;

            if (rdoRegSexFemale.Checked)
            {
                row["SEX"] = "남자";
            }
            else
            {
                row["SEX"] = "여자";
            }

            row["REF"] = tboxRegRef.Text;

            //생성죈 row를 테이블에 등록 
            //dt.Rows.Add(row);

            //if (bCheckisTable)
            //{
            //    ds.Tables.Remove(cboxRegClass.Text);
            //    ds.Tables.Add(dt);
            //}

            if (bCheckisTable)
            {
                dt.Rows.Add(row);
            }
            else
            {
                dt.Rows.Add(row);
                ds.Tables.Add(dt);
            }
            ViewRefresh();
            //cboxViewClass_SelectedIndexChanged(this, null);

        }

        private void btnViewDataDel_Click(object sender, EventArgs e)
        {
            int iSelectRow = dgViewInfo.SelectedRows[0].Index;
            ds.Tables[cboxViewClass.Text].Rows.RemoveAt(iSelectRow);
            ViewRefresh();
            //cboxViewClass_SelectedIndexChanged(this, null);
        }

        private void cboxViewClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewRefresh();
        }

        private void ViewRefresh()
        {
            dgViewInfo.DataSource = ds.Tables[cboxViewClass.Text];

            foreach (DataGridViewRow oRow in dgViewInfo.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();

            }
            dgViewInfo.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }

    }
}
