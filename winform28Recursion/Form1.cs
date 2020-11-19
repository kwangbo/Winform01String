using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform28Recursion
{
    public partial class Form1 : Form
    {
        enum enControlType
        {
            Unkown,
            Label,
            Textbox,
            Button,
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            //Control level, control type, control text
            int iLevel = (int)numLevel.Value;

            enControlType eControlType = enControlType.Label;
            if (rdoLabel.Checked) eControlType = enControlType.Label;
            else if (rdoTextbox.Checked) eControlType = enControlType.Textbox;
            else if (rdoButton.Checked) eControlType = enControlType.Button;

            string strChangeText = tboxChangeText.Text;

            ControlSearch(gboxCheckList, iLevel, eControlType, strChangeText);
        }

        private void ControlSearch(GroupBox CheckList, int iLevel, enControlType eType, string strChangeText)
        {

            foreach (var item in CheckList.Controls)
            {

                if (CheckList.Text.Equals("Level " + iLevel))
                {
                    switch (eType)
                    {

                        case enControlType.Label:
                            if (item is Label)
                            {
                                ((Label)item).Text = strChangeText;
                                lboxResult.Items.Add(string.Format("현재  GroupBox : {0}, Label Text : {1} 로 변경",
                                    CheckList.Text, strChangeText));
                            }
                            break;
                        case enControlType.Textbox:
                            if (item is TextBox)
                            {

                                ((TextBox)item).Text = strChangeText;
                            }
                            lboxResult.Items.Add(string.Format("현재  GroupBox : {0}, TextBox Text : {1} 로 변경",
                                CheckList.Text, strChangeText));
                            break;
                        case enControlType.Button:
                            if (item is Button)
                            {
                                ((Button)item).Text = strChangeText;
                            }
                            lboxResult.Items.Add(string.Format("현재  GroupBox : {0}, Button Text : {1} 로 변경",
                                    CheckList.Text, strChangeText));

                            break;
                        default:
                            break;
                    }

                }

                if (item is GroupBox)
                {
                    lboxResult.Items.Add(string.Format("현재  GroupBox : {0}, 다음 GroupBox : {1} 로 이동",
                            CheckList.Text, ((GroupBox)item).Text));

                    ControlSearch((GroupBox)item, iLevel, eType, strChangeText);
                }

            }

            if (CheckList == gboxCheckList)
            {
                lboxResult.Items.Add(string.Format("END"));
            }
        }
    }
}
