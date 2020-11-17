using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform25TitleDisplay
{
    public partial class Form1 : Form
    {
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
                "Title 사용하기",  oVersion.Major, oVersion.Minor, GetBuildDataTime(oVersion),"프로그램 상태");
                      

        }

        public DateTime GetBuildDataTime(Version oVersion)
        {
            string strVersion = oVersion.ToString();

            //날짜 등록
            int iDays = Convert.ToInt32(strVersion.Split('.')[2]);
            DateTime refData = new DateTime(2000,1,1);
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

        // Dictionary 예제

        Dictionary<string, Stack<CSize>> oDic = new Dictionary<string, Stack<CSize>>();
        private void btnSizeCheck_Click(object sender, EventArgs e)
        {
            ControlSizeRead();
            fControlSizeWrite();
        }

        private void ControlSizeRead()
        {
            oDic.Clear();

            //button등록
            Stack<CSize> sButton = new Stack<CSize>();
            foreach (var item in gboxControl.Controls)
            {
                if (item is Button)
                {
                    Button obtn = item as Button;

                    CSize oSize = new CSize();
                    oSize.Name = obtn.Name;
                    oSize.Width = obtn.Width;
                    oSize.Height1 = obtn.Height;

                    sButton.Push(oSize);


                }
            }



            oDic.Add("BUTTON", sButton);

            //Label 등록
            Stack<CSize> sLabel = new Stack<CSize>();
            foreach (var item in gboxControl.Controls)
            {
                if (item is Label)
                {
                    Label oLabel = item as Label;

                    CSize oSize = new CSize();
                    oSize.Name = oLabel.Name;
                    oSize.Width = oLabel.Width;
                    oSize.Height1 = oLabel.Height;

                    sLabel.Push(oSize);

                }

            }

            oDic.Add("LABEL", sLabel);

        }

        private void fControlSizeWrite()
        {
            //dic 에서 button 정보 가져옴
            Stack<CSize> sButton = oDic["BUTTON"];
            foreach (var item in sButton)
            {
                string strResult = string.Format("Control : Button, Name : {0}, Size : ({1}, {2})", 
                    item.Name, item.Width, item.Height1);
                lboxResult.Items.Add(strResult);
            }

            Stack<CSize> sLabel = oDic["LABEL"];
            foreach (var item in sLabel)
            {
                string strResult = string.Format("Control : Lable, Name : {0}, Size : ({1}, {2})",
                    item.Name, item.Width, item.Height1);
                lboxResult.Items.Add(strResult);
            }


        }
    }
}
