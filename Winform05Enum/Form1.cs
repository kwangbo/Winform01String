using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform05Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //string strName = "0";

         enum enumDay
        {

            Monday = 0,
            Tuesday = 12,
            Wendsday = 24,
            Thusday,
            Friday,
            Saturday,
            Sunday,
        }

        enum enumTime
        {
            Morning = 0,
            Afternoon = 1,
            Evening = 2 ,
        }
        private void btnResult_Click(object sender, EventArgs e)
        {
            //준화와 월요일  점심때 보기로 했습니다. 
            string strResult = tboxName.Text + "와 " + lboxDay.SelectedItem.ToString() + "(요일) " + lboxTime.SelectedItem.ToString() + "에 보기로 했습니다. " ;

            tboxResult.Text = strResult;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lboxDay.Items.Add(enumDay.Monday.ToString());
            lboxDay.Items.Add(enumDay.Tuesday);
            lboxDay.Items.Add(enumDay.Wendsday);
            lboxDay.Items.Add(enumDay.Thusday);
            lboxDay.Items.Add(enumDay.Friday);
            lboxDay.Items.Add(enumDay.Saturday);
            lboxDay.Items.Add(enumDay.Sunday);

            lboxTime.Items.Add(enumTime.Morning);
            lboxTime.Items.Add(enumTime.Afternoon);
            lboxTime.Items.Add(enumTime.Evening);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResult2_Click(object sender, EventArgs e)
        {

            string strResult = TextLoad(tboxName.Text, lboxDay.SelectedItem.ToString(), lboxTime.SelectedItem.ToString()); //String.Format("{0}와 {1}(요일) {2}에 보기로 했습니다. ", tboxName.Text, lboxDay.SelectedItem.ToString(), lboxTime.SelectedItem.ToString())
                ;
            tboxResult.Text = strResult;
        }

        /// <summary>
        /// 준화와 월요일  점심때 보기로 했습니다.  같은 문자열을 만들어 줍니다.
        /// </summary>
        /// <param name="strname">이름</param>
        /// <param name="strday">날짜</param>
        /// <param name="strTime">시간</param>
        /// <returns></returns>
        private string TextLoad(string strname, string strday, string strTime)
        {
            string strText = String.Format("{0}와 {1}(요일) {2}에 보기로 했습니다. ", strname, strday, strTime);

            return strText;
        }
    }
}
