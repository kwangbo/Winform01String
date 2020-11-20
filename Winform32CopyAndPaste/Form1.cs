using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform32CopyAndPaste
{
    public partial class Form1 : Form
    {
        CGlobalKeyboardHook2 _kbdHook = new CGlobalKeyboardHook2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Version oVersion = Assembly.GetEntryAssembly().GetName().Version;

            string dd = Assembly.GetExecutingAssembly().GetName().Name;

            //            this.Text = "Title " + oVersion + " " + dd ;
            this.Text = string.Format("{0} Ver.{1}.{2} /Build Time ({3} - {4}) ",
                "문자복사", oVersion.Major, oVersion.Minor, GetBuildDataTime(oVersion), "상태");

            _kbdHook.hook();
            _kbdHook.KeyDown += _kbdHook_KeyDown;
        }

        private void _kbdHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C && cboxActication.Checked)
            {
                Thread.Sleep(400);

                lboxTextSave.Items.Add(Clipboard.GetData(System.Windows.Forms.DataFormats.UnicodeText).ToString());
            }

        }


        private void LboxTestSave_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lboxTextSave.SelectedIndex != -1)
            {
                Clipboard.SetData(System.Windows.Forms.DataFormats.UnicodeText, lboxTextSave.SelectedItem.ToString());
            }
        }



        public DateTime GetBuildDataTime(Version oVersion)
        {
            string strVersion = oVersion.ToString();

            //날짜 등록
            int iDays = Convert.ToInt32(strVersion.Split('.')[2]);
            DateTime refData = new DateTime(2000, 1, 1);
            DateTime dtBuildDate = refData.AddDays(iDays);

            //초 등록
            int iSeconds = Convert.ToInt32(strVersion.Split('.')[3]);
            iSeconds = iSeconds * 2;
            dtBuildDate = dtBuildDate.AddSeconds(iSeconds);

            //시차 조정 
            DaylightTime daylighttime = TimeZone.CurrentTimeZone.GetDaylightChanges(dtBuildDate.Year);

            if (TimeZone.IsDaylightSavingTime(dtBuildDate, daylighttime))
            {
                dtBuildDate = dtBuildDate.Add(daylighttime.Delta);

            }
            return dtBuildDate;


        }

        

        private void tBar_Scroll_Change(object sender, EventArgs e)
        {
            this.Opacity = tBar.Value / 10.0;
        }

        private void btnBtextadd_Click(object sender, EventArgs e)
        {
            DataSave();
        }

        private void tboxAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataSave();
            }
        }

        private void DataSave()
        {
            string strText = tboxAdd.Text;
            if (!string.IsNullOrEmpty(strText) && !lboxTextSave.Items.Contains(strText))
            {
                lboxTextSave.Items.Add(strText);
                tboxAdd.Text = "";
            }
        }

        private void cboxActivation(object sender, EventArgs e)
        {

        }

        private void cboxActication_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxActication.Checked)
            {
                lblActivation.Text = "활성화 상태(Ctrl + C 키 가능)";
                lblActivation.Enabled = true;
                tboxAdd.Enabled = true;
                btnBtextadd.Enabled = true;

            }
            else
            {
                lblActivation.Text = "비 활성화 상태(붙여넣기만 가능)";
                lblActivation.Enabled = false;
                tboxAdd.Enabled = false;
                btnBtextadd.Enabled = false;
            }
        }

        private void lboxTextSave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (lboxTextSave.SelectedItems.Count > 0 )
                {
                    lboxTextSave.Items.RemoveAt(lboxTextSave.SelectedIndex);
                }
                
            }
        }
    }
}
