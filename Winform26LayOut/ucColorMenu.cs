using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform26LayOut
{
    public partial class ucColorMenu : UserControl
    {

        //1 delegate event  선언

        public delegate void delColorSender(object oSender, Color oColor);
        public event delColorSender eColorSender;
        public ucColorMenu()
        {
            InitializeComponent();
        }
    

        private void ucColorMenu_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {

                Button obtn = new Button();
                obtn.Name = "btn" + i ;
                obtn.Text = string.Format("P{0} 색상 변경",i.ToString());
                obtn.BackColor = Color.Gray;
                obtn.Margin = new Padding(10, 20, 0, 0);
                obtn.Size = new Size(100, 30);
                obtn.Click += Obtn_Click;

                flpMenu.Controls.Add(obtn);
            }
            //pColor.Controls.Add(obtn);


        }

        private void Obtn_Click(object sender, EventArgs e)
        {
            eColorSender(sender, pColor.BackColor );
        }

        private void pColor_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult dRet = cDiallogColor.ShowDialog();
            if (dRet == DialogResult.OK)
            {
                pColor.BackColor = cDiallogColor.Color;
            }
        }
    }
}
