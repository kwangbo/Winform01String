using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Winform27LayOut2
{
    public partial class ucColorMenu : UserControl
    {
        //1 delegate event  선언

        //public delegate void delColorSender(object oSender, Color oColor);
        //public event delColorSender eColorSender;

        //2  기본  EventHandler
       // public event EventHandler oColorHander;

        //3 제네릭 형태
        public event Action<Button, Color> eColorAction;

        public ucColorMenu()
        {
            InitializeComponent();
        }

        private void PColor_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            DialogResult dRet = cDialogColor.ShowDialog();
            if (dRet == DialogResult.OK)
            {
                pColor.BackColor = cDialogColor.Color;
            }

        }

        private void ucColorMenu_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 5; i++)
            {

                Button obtn = new Button();
                obtn.Name = "btn" + i;
                obtn.Text = string.Format("P{0} 색상 변경", i.ToString());
                obtn.BackColor = Color.Gray;
                obtn.Margin = new Padding(10, 20, 0, 0);
                obtn.Size = new Size(100, 30);
                obtn.Click += Obtn_Click;

                flpMenu.Controls.Add(obtn);
            }

        }
        private void Obtn_Click(object sender, EventArgs e)
        { 
            //eColorSender(sender, pColor.BackColor);
           // oColorHander(sender, e);
            eColorAction((Button)sender, pColor.BackColor);
        }

        public string fButtonColorChange(ucPanel oPanel) 
        {
            string strResult = string.Empty;
            string strbtnName = string.Empty;

            switch (oPanel.Name)                
            {
                case "ucPanelTop":
                    strbtnName = "btn0";
                    break;
                case "ucPanelCenter1":
                    strbtnName = "btn1";
                    break;
                case "ucPanelCenter2":
                    strbtnName = "btn2";
                    break;
                case "ucPanelRight":
                    strbtnName = "btn3";
                    break;

                default:
                    break;
            }
            strResult = fBtnSearch(strbtnName, oPanel.BackColor, oPanel.Name);
            return "";
        }

        private string fBtnSearch(string strButtonName, Color oColor, string strPanelName)
        {
            string strResult = string.Empty;
            foreach (var oitem in flpMenu.Controls)
            {
                if (oitem is Button)
                {
                    Button obtn = oitem as Button;
                    if (obtn.Name.Equals(strButtonName))
                    {
                        obtn.BackColor = oColor;
                        strResult = string.Format("{0} Panel DoubleClick {1} 의 색상을 {2}로 변경", 
                            strPanelName, strButtonName, oColor.ToString());
                        return strResult;
                    }

                }
                
            }
            return strResult;
        }
    }
}
