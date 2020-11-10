using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform10Struct
{

    public partial class Form1 : Form
    {
        struct structPlayer
        {
            public int iCount; //  몇해 진행중인지

            public int iSun;
            public int iMoon;
            public int iStar;
            public int iCardSum;         // 더한 값 해 달 별      
            public int CardSum(int iSum, int iMoon, int iStar)
            {
                return iSun + iMoon + iStar;
            }
            public string ResulText()
            {
                return string.Format("{0}회 ) 해 :{1}, 달:{2},  별:{3} => 합계는 {4} 입니다.",
                 iCount, iSun, iMoon, iStar, iCardSum   );
            }

        }


        class classPlayer
        {
            public int iCount = 0; //  몇해 진행중인지

            public int iSun;
            public int iMoon;
            public int iStar;
            public int iCardSum;         // 더한 값 해 달 별      
            public int CardSum(int iSum, int iMoon, int iStar)
            {
                return iSun + iMoon + iStar;
            }
            public string ResulText(int iCardSum)
            {
                return string.Format("{0}회 ) 해 :{1}, 달:{2},  별:{3} => 합계는 {4} 입니다.",
                 iCount, iSun, iMoon, iStar, iCardSum);
            }

        }

        structPlayer _stPlayer1;
        structPlayer _stPlayer2;


        Random _rd = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        struct Car
        {
            int cycle;
            int window;
            int door;
            string name;
        }

        class cCar
        {
            int cycle;
            int window;
            int door;
            string name;

        }

        private void pboxSun_Click(object sender, EventArgs e)
        {
            
            int iNumber = _rd.Next(1, 21);
            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iSun = iNumber;
            }
            else
            {
                _stPlayer2.iSun = iNumber;
            }

            Result();
            iCheckedChange();
        }

        private void pboxMoon_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);
            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iMoon = iNumber;
            }
            else
            {
                _stPlayer2.iMoon = iNumber;
            }
            Result();
            iCheckedChange();
        }

        private void pboxStar_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);
            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iStar = iNumber;
            }
            else
            {
                _stPlayer2.iStar = iNumber;
            }
            Result();
            iCheckedChange();
        }

        private void iCheckedChange()
        {
            if (rdoPlayer1.Checked)
            {
                rdoPlayer2.Checked = true;
            }
            else
            {
                rdoPlayer1.Checked = true;
            }
        }

        private void Result()
        {
            int iCardSum = 0;
            string strResult = string.Empty;
            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iCount++;
                iCardSum = _stPlayer1.CardSum(_stPlayer1.iSun, _stPlayer1.iMoon, _stPlayer1.iStar);
                _stPlayer1.iCardSum = iCardSum;

                strResult = _stPlayer1.ResulText();
                lboxResult1.Items.Add(strResult);
            }
            else
            {
                _stPlayer2.iCount++;
                iCardSum = _stPlayer2.CardSum(_stPlayer2.iSun, _stPlayer2.iMoon, _stPlayer2.iStar);
                _stPlayer2.iCardSum = iCardSum;

                strResult = _stPlayer2.ResulText();
                lboxResult2.Items.Add(strResult);
            }
           // iCheckedChange();
            if (_stPlayer1.iCount >= 5 && _stPlayer2.iCount >= 5)
            {
                if (_stPlayer1.iCardSum < _stPlayer2.iCardSum)
                {
                    MessageBox.Show("Player1 win ");
                }
                else if (_stPlayer1.iCardSum > _stPlayer2.iCardSum)
                {
                    MessageBox.Show("Player2 win ");
                }
                else
                {
                    MessageBox.Show("비겼습니다. ");
                }

            }
        }
        private void pboxNone_Click(object sender, EventArgs e)
        {
            //  아무것도 안하고 넘김 
            iCheckedChange();
        }
    }
}
