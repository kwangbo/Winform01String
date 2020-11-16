using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform20Thread
{
    

    public partial class Form1 : Form
    {
        

        private enum enumPlayer
        {
            아이린,
            슬기,
            웬디,
            조이,
            예리,
        }

        int _locationX = 0;
        int _locationY = 0;

        public Form1()
        {
            InitializeComponent();
            _locationX = this.Location.X;
            _locationY = this.Location.Y;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _locationX = this.Location.X + this.Size.Width;
            _locationY = this.Location.Y;

            for (int i = 0; i < numPlayerCount.Value; i++)
            {
                Play pl = new Play(((enumPlayer)i).ToString() );
                pl.Location = new Point(_locationX, _locationY + pl.Height * i);
                pl.eventdelMessagte += Pl_eventdelMessagte;

                pl.Show();

                //pl.test();
                pl.fThreadStart();
            }

        }

        private int Pl_eventdelMessagte(object sender, string strResult)
        {

            if (this.InvokeRequired)
            {
                this.Invoke(new Action(delegate ()
                {
                    //함수값
                    Play oPlayerForm = sender as Play;
                    lboxResult.Items.Add(string.Format("Player : {0}, Text : {1}", oPlayerForm.StrPlayerName, strResult));

                }));
            }
            return 0;
        }
    }
}
