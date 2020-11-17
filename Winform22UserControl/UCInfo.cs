using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform22UserControl
{
    public partial class UCInfo : UserControl
    {
        public delegate int delEvent(object Sender, string strText);
        public event delEvent eventdelSender; //delegate event  선언

        [Category("UserProperty"), Description("Image")]
        public Image UserFace
        {
            get { return this.pboxFace.BackgroundImage; }
            set { this.pboxFace.BackgroundImage = value; }

        }

        [Category("UserProperty"), Description("No")]
        public string UserNo
        {
            get { return this.lblNo.Text; }
            set { this.lblNo.Text = value; }

        }

        [Category("UserProperty"), Description("대상의 이름")]
        public string UserText
        {
            get { return this.lblName.Text; }
            set { this.lblName.Text = value; }

        }
        [Category("UserProperty"), Description("대상의 금액")]
        public string UserGold
        {
            get { return this.lblGold.Text; }
            set { this.lblGold.Text = value; }

        }

        public UCInfo()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string strText = string.Empty;

            Button oBtn = sender as Button;
            switch (oBtn.Name)
            {
                case "btnReg":
                    this.BackColor = Color.Red;
                    strText = string.Format("{0}은 금액 {1}으로 찾는중입니다. ", lblName.Text, lblGold.Text);
                    break;
                case "btnIdle":
                    this.BackColor = Color.Yellow;
                    strText = string.Format("{0}은 찾기중지입니다. ", lblName.Text);
                    break;
                case "btnCatch":
                    this.BackColor = Color.Green;
                    strText = string.Format("{0}은 찾았습니다. ", lblName.Text);
                    break;
                default:
                    break;
            }

            if (eventdelSender != null)
            {
                eventdelSender(this, strText);
            }
            



        }
    }
}
