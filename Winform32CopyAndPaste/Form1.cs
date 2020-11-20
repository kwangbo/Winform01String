using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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
                "Copy & Paste", oVersion.Major, oVersion.Minor, GetBuildDataTime(oVersion), "상태");

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
                if (lboxTextSave.SelectedItems.Count > 0)
                {
                    lboxTextSave.Items.RemoveAt(lboxTextSave.SelectedIndex);
                }

            }
        }

        #region Menu Strip
        private void 저장하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fFileSave();
        }
        private void 불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAllLoad();
        }

        private void 공백제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fEmptyDelete();
        }

        private void 모두제거ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAllDelete();
        }

        private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fProgramInfo();
        }

        #endregion
        #region Context Menu Strip

        private void 저장하기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fFileSave();
        }

        private void 불러오기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fAllLoad();
        }

        private void 공백제거ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fEmptyDelete();
        }

        private void 모두저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fFileSave();
        }

        private void 프로그램정보ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fProgramInfo();
        }


        #endregion
        /// <summary>
        /// 공백제거
        /// </summary>
        #region Event Function

        private void fEmptyDelete()
        {
            try
            {
                int iCount = lboxTextSave.Items.Count;
                for (int i = 0; i < iCount; i++)
                {
                    lboxTextSave.Items[i] = lboxTextSave.Items[i].ToString().Trim();
                }
            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// 모두삭제 
        /// </summary>
        private void fAllDelete()
        {
            if (DialogResult.Yes == MessageBox.Show("등록되어 있는 Data를 초기화 합니다.",
                "ListBox Item Cleare", MessageBoxButtons.YesNo))
            {
                lboxTextSave.Items.Clear();
            }
        }

        /// <summary>
        /// 저장하기용 함수 
        /// </summary>
        private void fFileSave()
        {
            SaveFileDialog SFDialog = new SaveFileDialog();

            int ilbCount = lboxTextSave.Items.Count;
            string strFilePath = string.Empty;

            SFDialog.InitialDirectory = Application.StartupPath;
            SFDialog.FileName = "*.txt";
            SFDialog.Filter = "txt files(*.txt) | *.txt | All Files (*.*) | *.*";

            try
            {
                if (SFDialog.ShowDialog() == DialogResult.OK)
                {
                    strFilePath = SFDialog.FileName;
                    StreamWriter swSFDialog = new StreamWriter(strFilePath);

                    for (int i = 0; i < ilbCount; i++)
                    {
                        swSFDialog.WriteLine(lboxTextSave.Items[i].ToString());
                    }
                    swSFDialog.Close();

                    MessageBox.Show("저장이 완료 되었습니다.");

                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// 불러오기용 함수 
        /// </summary>
        private void fAllLoad()
        {
            OpenFileDialog OFDialog = new OpenFileDialog();
            string strFilePath = string.Empty;

            OFDialog.InitialDirectory = Application.StartupPath;
            OFDialog.FileName = "*.txt";
            OFDialog.Filter = "txt files (*.txt)|*.txt|All Files(*.*)|*.*";
            try
            {
                if (OFDialog.ShowDialog() == DialogResult.OK)
                {
                    strFilePath = OFDialog.FileName;
                    StreamReader srOFDialoog = new StreamReader(strFilePath,
                                                                Encoding.UTF8,
                                                                true);
                    while (srOFDialoog.EndOfStream == false)
                    {
                        lboxTextSave.Items.Add(srOFDialoog.ReadLine());
                    }
                }
            }
            catch (Exception)
            {

            }
        }


        /// <summary>
        /// 프로그램 정보 함수 
        /// </summary>
        private void fProgramInfo()
        {
            string strPrograminfo = "반복작업을 조금이나마 수월하게!!!";
            MessageBox.Show(strPrograminfo);
        }


        #endregion
    }
}
