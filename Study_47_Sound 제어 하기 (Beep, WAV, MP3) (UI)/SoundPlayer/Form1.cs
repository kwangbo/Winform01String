using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using SM = System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region SystemSound
        private void btnBeep_Click(object sender, EventArgs e)
        {
            if (rdoBeep1.Checked)
            {
                SM.SystemSounds.Asterisk.Play();
            }
            else if (rdoBeep2.Checked)
            {
                SM.SystemSounds.Beep.Play();
            }
            else if (rdoBeep3.Checked)
            {
                SM.SystemSounds.Exclamation.Play();
            }
            else if (rdoBeep4.Checked)
            {
                SM.SystemSounds.Hand.Play();
            }

            else if (rdoBeep5.Checked)
            {
                SM.SystemSounds.Question.Play();
            }

        }
        #endregion


        #region WAV 

        SM.SoundPlayer _soundPlay;

        private void btnWAV_Click_1(object sender, EventArgs ex)
        {
            string strFilePath = string.Empty;

            OFDialog.InitialDirectory = Application.StartupPath;
            OFDialog.FileName = "*.wav";
            OFDialog.Filter = "wav files(*.wav)|*.wav|All files(*.*)|*.*";
            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                PlayWaverFile(OFDialog.FileName, true);

            }
        }

        private void PlayWaverFile(string filePath, bool playLooping)
        {
            if (_soundPlay != null )
            {
                _soundPlay.Stop();
                _soundPlay.Dispose();
                _soundPlay = null;

            }

            if (string.IsNullOrEmpty(filePath))
            {
                return;
            }

            _soundPlay = new SM.SoundPlayer(filePath);

            if (playLooping)
            {
                _soundPlay.PlayLooping();
            }
            else
            {
                _soundPlay.Play();
            }
        }
        #endregion

       
    }
}
