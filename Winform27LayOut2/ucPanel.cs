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
    public partial class ucPanel : UserControl
    {
        public event EventHandler eLableDolubleClickHander;
        public ucPanel()
        {
            InitializeComponent();
            lblSize.BackColor = Color.Transparent;            
            panel1.BackColor = Color.Transparent;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }    

        private void PanelSizeChanged(object sender, EventArgs e)
        {
            lblSize.Text = string.Format("({0},{1})", panel1.Width, panel1.Height);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSize_DoubleClick(object sender, EventArgs e)
        {
            eLableDolubleClickHander(this, e);
        }
    }
}
