using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform27LayOut2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ucCMenu.eColorSender += UcCMenu_eColorSender;
            ucCMenu.eColorAction += UcCMenu_eColorAction;
            ucPanelTop.eLableDolubleClickHander += UcPanelTop_eLableDolubleClickHander;
            ucPanelCenter1.eLableDolubleClickHander += UcPanelTop_eLableDolubleClickHander;
            ucPanelCenter2.eLableDolubleClickHander += UcPanelTop_eLableDolubleClickHander;
            ucPanelRight.eLableDolubleClickHander += UcPanelTop_eLableDolubleClickHander;

        }

        private void UcPanelTop_eLableDolubleClickHander(object sender, EventArgs e)
        {
            string strResult = ucCMenu.fButtonColorChange((ucPanel)sender);
            lboxLog.Items.Add(strResult);
        }

        private void UcCMenu_eColorAction(Button arg1, Color arg2)
        {
            string strPanelName = string.Empty;

            switch (arg1.Name)
            {
                case "btn0":
                    ucPanelTop.BackColor = arg2;
                    strPanelName = "panel top";
                    break;
                case "btn1":
                    ucPanelCenter1.BackColor = arg2;
                    strPanelName = "panel center 1";
                    break;
                case "btn2":
                    ucPanelCenter2.BackColor = arg2;
                    strPanelName = "panel center 2 ";
                    break;
                case "btn3":
                    ucPanelRight.BackColor = arg2;
                    strPanelName = "panel  ritght";
                    break;
                default:
                    break;
            }

            string strResult = string.Format("선택: {0}, {1}의 색상을 {2}로 변경",
               arg1.Name, strPanelName, arg2.ToString());
            lboxLog.Items.Add(strResult);

        }

        private void UcCMenu_eColorSender(object oSender, Color oColor)
        {
            
        }
    }
}
