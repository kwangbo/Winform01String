using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform21Exception2
{
    public partial class Form1 : Form
    {
        Dictionary<string, Color> dColor = new Dictionary<string, Color>();
        Color oSelectColor = new Color();

        public Form1()
        {
            InitializeComponent();
        }

        private void pColor_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dRet = cdialogColor.ShowDialog();
            if (dRet == DialogResult.OK)
            {
                pColor.BackColor = cdialogColor.Color;
            }

            lblColorInfo.Text = pColor.BackColor.ToString();

        }

        private void tbarAlpha_Scroll(object sender, EventArgs e)
        {
            pColor.BackColor = Color.FromArgb(tbarAlpha.Value, pColor.BackColor);
            lblColorInfo.Text = pColor.BackColor.ToString();
        }

        private void btnColorsave_Click(object sender, EventArgs e)
        {
            try
            {
                Color oColor = pColor.BackColor;
                dColor.Add(oColor.ToString(), oColor);
                LBoxRefresh();
            }
            catch (ArgumentException ex )
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LBoxRefresh()
        {
            try
            {
                lboxColor.Items.Clear();
                foreach (string okey in dColor.Keys)
                {
                    lboxColor.Items.Add(okey);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void btnColorDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (lboxColor.SelectedItem != null &&  dColor.ContainsKey(lboxColor.SelectedItem.ToString()))
                {
                    dColor.Remove(lboxColor.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("키가 없습니다.");
                    }
                LBoxRefresh(); //화면 다시 뿌려준다
            }
            catch (NullReferenceException ex )
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lboxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            oSelectColor = dColor[lboxColor.SelectedItem.ToString()];

        }

        private void PanelClickEvent(object sender, EventArgs e)
        {
            try
            {   //형변환 잘못될수 있다. 다른거 느를시 
                //TextBox oTbox1 = sender as TextBox; // null 값  발생
                //TextBox oTbox = (TextBox)sender; //exception 발생 
                if (sender is Panel)
                {

                    Panel oPanel = sender as Panel;//  형변환
                    oPanel.BackColor = oSelectColor;
                }
                else
                {

                }

            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
