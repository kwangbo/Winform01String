using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordSearch
{
    public partial class Form1 : Form
    {
        OleDbConnection _conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDBLoad_Click(object sender, EventArgs e)
        {
            string strFilePath = string.Empty;

            OFDialog.InitialDirectory = Application.StartupPath;
            OFDialog.FileName = "*.mdb";
            OFDialog.Filter = "db files(*.mdb)|*.mdb|All files(*.*)|*.*";
            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                tboxPath.Text = OFDialog.FileName;
                DBConnect(tboxPath.Text);
            }

            
        }

        #region Db Conn
        private void DBConnect(string strDBPath)
        {
            //string connStr = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={strDBPath} "Provider=Microsoft.JET.OLEDB.4.0;data source=d:\\Nwind.mdb";";
            //string connStr = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\English.mdb; Persist Security Info = False";
            //  test  ok 
            //string connStr = "Provider=Microsoft.JET.OLEDB.4.0;data source=d:\\English.mdb";

            string connStr = $"Provider=Microsoft.JET.OLEDB.4.0;data source={strDBPath}";

            _conn = new OleDbConnection(connStr);
            //OleDbConnection conn = new OleDbConnection(connStr);
            string Query = $@"Select * 
                               From Voca";
            QueryExecCute(Query);
        }

        private void QueryExecCute(string Query)
        {
            DataSet ds = new DataSet();
            OleDbDataAdapter adp = new OleDbDataAdapter(Query, _conn);
            adp.Fill(ds);

            dgData.DataSource = ds.Tables[0];
        }

        #endregion

        private void btnEx_Click(object sender, EventArgs e)
        {
            Button obtn = sender as Button;
            string strQuery = string.Empty;
            switch (obtn.Name)
            {
                case "btnEx1":
                    strQuery = $@"select * 
from Voca";
                    break;
                case "btnEx2":
                    strQuery = $@"select * 
from Voca
where 단어 Like ""%a%""";
                    break;
                case "btnEx3":
                    strQuery = $@"select * 
from Voca
where 단어 
order by ID Desc";
                    break;
                default:
                    break;
            }
            tboxQuery.Text = strQuery;
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            QueryExecCute(tboxQuery.Text);
        }

        
    }
}
