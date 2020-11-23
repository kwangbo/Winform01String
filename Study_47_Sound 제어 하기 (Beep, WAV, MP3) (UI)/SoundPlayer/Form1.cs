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
            _tm = new Timer();
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
            if (_soundPlay != null)
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
        #region MP3
        MediaPlayer.MediaPlayerClass _mediaPlayer;
        Timer _tm;
        enum EnumStatus
        {
            play,
            stop,
            pause,
        }

        private void btnMP3_Click(object sender, EventArgs e)
        {
            //string strFilePath = string.Empty;

            //OFDialog.InitialDirectory = Application.StartupPath;
            //OFDialog.FileName = "*.mp3";
            //OFDialog.Filter = "mp3 files(*.mp3)|*.mp3|All files(*.*)|*.*";
            //if (OFDialog.ShowDialog() == DialogResult.OK)
            //{
            //    if (_mediaPlayer == null)
            //    {
            //        _mediaPlayer = new MediaPlayer.MediaPlayerClass();
            //    }

            //    _mediaPlayer.FileName = OFDialog.FileName;
            //    _mediaPlayer.Stop();
            //    changeStaus(EnumStatus.stop);
            //    lblFileName.Text = OFDialog.FileName;

            //    //처음
            //    tbarVolume.Value = TrackbarToVolumn(-1200, 0 , _mediaPlayer.Volume);
            //    lblVolume.Text = tbarVolume.Value.ToString();

            //    //Timer  
            //    _tm.Interval = 500;
            //    _tm.Tick += _tm_Tick;
            //}

            string strFilePath = string.Empty;

            OFDialog.InitialDirectory = Application.StartupPath;
            OFDialog.FileName = "*.mp3";
            OFDialog.Filter = "mp3 files(*.mp3)|*.mp3|All files(*.*)|*.*";
            if (OFDialog.ShowDialog() == DialogResult.OK)
            {
                if (_mediaPlayer == null)
                {
                    _mediaPlayer = new MediaPlayer.MediaPlayerClass();
                }

                _mediaPlayer.FileName = OFDialog.FileName;
                _mediaPlayer.Stop();
                changeStaus(EnumStatus.stop);
                lblFileName.Text = OFDialog.FileName;

                //처음
                tbarVolume.Value = TrackbarToVolumn(-1200, 0, _mediaPlayer.Volume);
                lblVolume.Text = tbarVolume.Value.ToString();

                //Timer  
                _tm.Interval = 500;
                _tm.Tick += _tm_Tick;
            }

        }

        private void _tm_Tick(object sender, EventArgs e)
        {
            //tbarMain.Minimum = 1;
            //tbarMain.Maximum = (int)_mediaPlayer.Duration; // mp3 file 의 전체 재생시간(int)
            //tbarMain.Value = (int)_mediaPlayer.CurrentPosition; // mp3 file   의 현재 재생 위치 

            //string strCurrentTime = TimeSpan.FromSeconds(_mediaPlayer.CurrentPosition).ToString(@"hh\:mm\:ss");
            //string strFullTime = TimeSpan.FromSeconds(_mediaPlayer.Duration).ToString(@"hh\:mm\:ss");

            //lblTime.Text = $"{strCurrentTime}/{strFullTime}";
            ////tbarVolume.Value = TrackbarToVolumn(-1200,0,_mediaPlayer.Volume);
            ////lblVolume.Text = tbarVolume.ToString();
            tbarMain.Minimum = 1;
            tbarMain.Maximum = (int)_mediaPlayer.Duration; // mp3 file 의 전체 재생시간(int)
                                                           //tbarMain.Value = (int)_mediaPlayer.CurrentPosition; // mp3 file   의 현재 재생 위치 
            if ((int)_mediaPlayer.CurrentPosition != 0)
            {
                tbarMain.Value = (int)_mediaPlayer.CurrentPosition; // mp3 file   의 현재 재생 위치 
            }
            else
            {

            }

            string strCurrentTime = TimeSpan.FromSeconds(_mediaPlayer.CurrentPosition).ToString(@"hh\:mm\:ss");
            string strFullTime = TimeSpan.FromSeconds(_mediaPlayer.Duration).ToString(@"hh\:mm\:ss");

            lblTime.Text = $"{strCurrentTime}/{strFullTime}";
            //tbarVolume.Value = TrackbarToVolumn(-1200,0,_mediaPlayer.Volume);
            //lblVolume.Text = tbarVolume.ToString();

        }

        private void changeStaus(EnumStatus eSatatus)
        {
            lblStatus.Text = eSatatus.ToString();

        }
        #endregion

        private void btnPlay_Click(object sender, EventArgs e)
        {
            _mediaPlayer.Play();
            _tm.Start();
            changeStaus(EnumStatus.play);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _mediaPlayer.Stop();
            _tm.Stop();
            changeStaus(EnumStatus.stop);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            _mediaPlayer.Pause();
            changeStaus(EnumStatus.pause);
        }

        private void tbarVolume_Scroll(object sender, EventArgs e)
        {

            //tbarVolume.Value = _mediaPlayer.Volume;
            //_mediaPlayer.Volume = tbarVolume.Value;

            lblVolume.Text = tbarVolume.Value.ToString();
            int iVolumn = VolumnToTrackbar(-1200, 0, tbarVolume.Value);
            if (tbarVolume.Value == 0)
            {
                _mediaPlayer.Mute = true;
            }
            else
            {
                _mediaPlayer.Mute = false;
                _mediaPlayer.Volume = iVolumn;
            }

        }

        /// <summary>
        /// 1:100 = -1200 : 1 => 50 : ?
        /// </summary>
        /// <param name="Min"></param>
        /// <param name="Max"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private int TrackbarToVolumn(int Min, int Max, int Value)
        {
            double iRange = Max - Min;
            double iTarget = Value - Min;
            return (int)(iTarget / iRange + 100);

        }

        /// <summary>
        /// -600 : ?
        /// </summary>
        /// <param name="Min"></param>
        /// <param name="Max"></param>
        /// <param name="Per"></param>
        /// <returns></returns>
        private int VolumnToTrackbar(int Min, int Max, int Per)
        {
            double iRange = Max - Min;
            double iTarget = iRange * Per / 100;
            return (int)(iTarget + Min);
        }
    }


}
