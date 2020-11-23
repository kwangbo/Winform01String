using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace winformCrawling
{
    public partial class Form1 : Form
    {

        private ChromeDriverService _driverService = null;
        private ChromeOptions _options = null;
        private ChromeDriver _driver = null;

        List<string> Lsrc = null; // IMG URL (Loading 할 Image URL을 넣어 둘 배열)
        int i = 0; // 현재 배열 위치

        public Form1()
        {
            InitializeComponent();

            _driverService = ChromeDriverService.CreateDefaultService();
            _driverService.HideCommandPromptWindow = true;

            _options = new ChromeOptions();
            _options.AddArgument("disable-gpu");
        }


        #region Login

        /// <summary>
        /// Login 관련 Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {

            string id = tboxID.Text;
            string pw = tboxPW.Text;

            _driver = new ChromeDriver(_driverService, _options);
            _driver.Navigate().GoToUrl("https://www.daum.net");  // 웹 사이트에 접속합니다.
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
            var element = _driver.FindElementByXPath("//*[@id='inner_login']/a[1]");   // Main 로그인 버튼
            element.Click();

            Thread.Sleep(3000);

            element = _driver.FindElementByXPath("//*[@id='id']");    // ID 입력창
            element.SendKeys(id);

            element = _driver.FindElementByXPath("//*[@id='inputPwd']");   // PW 입력창 

            element.SendKeys(pw);

            element = _driver.FindElementByXPath("//*[@id='loginBtn']");  // 로그인 버튼
            element.Click();
        }
        
        #endregion


        #region Image 검색

        /// <summary>
        /// Image 검색 관련 Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strURL = "https://www.google.com/search?q=" + tboxSearch.Text + "&source=lnms&tbm=isch";

            _driver = new ChromeDriver(_driverService, _options);
            _driver.Navigate().GoToUrl(strURL); // 웹 사이트에 접속합니다.
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            _driver.ExecuteScript("window.scrollBy(0, 10000)");  // 창을 띄우고 스크롤 진행

            Lsrc = new List<string>();

            foreach (IWebElement item in _driver.FindElementsByClassName("rg_i"))
            {
                if (item.GetAttribute("src") != null)
                    Lsrc.Add(item.GetAttribute("src"));
            }

            lblTotal.Text = "/ " + Lsrc.Count.ToString();

            this.Invoke(new Action(delegate ()
            {
                try
                {
                    foreach (string strsrc in Lsrc)
                    {
                        i++;

                        GetMapImage(Lsrc[i]);
                        tboxNow.Text = i.ToString();
                        Refresh();
                        Thread.Sleep(50);
                    }
                }
                catch (Exception)
                {
                }
            }));
        }


        /// <summary>
        /// 다음 검색 Image 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPre_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(delegate ()
            {
                i--;

                GetMapImage(Lsrc[i]);
                tboxNow.Text = i.ToString();
            }));
        }


        /// <summary>
        /// 이전 검색 Image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(delegate ()
            {
                i++;

                GetMapImage(Lsrc[i]);
                tboxNow.Text = i.ToString();
            }));
        }


        /// <summary>
        /// 선택 검색 Image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(delegate ()
            {
                i = int.Parse(tboxNow.Text);

                GetMapImage(Lsrc[i]);
                tboxNow.Text = i.ToString();
            }));
        }



        /// <summary>
        /// IMAGE URL 정규식 변환 후 PicutreBox에 IMAGE Loading
        /// </summary>
        /// <param name="base64String"></param>
        private void GetMapImage(string base64String)
        {
            try
            {
                var base64Data = Regex.Match(base64String, @"data:image/(?<type>.+?),(?<data>.+)").Groups["data"].Value;  // 정규식 검색
                var binData = Convert.FromBase64String(base64Data);

                using (var stream = new MemoryStream(binData))
                {
                    if (stream.Length == 0)
                    {
                        pboxMain.Load(base64String);
                        tboxNow.Text = i.ToString();
                        tboxUrl.Text = base64String;
                    }
                    else
                    {
                        var image = Image.FromStream(stream);
                        pboxMain.Image = image;
                        tboxUrl.Text = base64String;
                    }
                }
            }
            catch
            {

            }
        }


        #endregion



    }
}
