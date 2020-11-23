namespace SoundPlayer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBeep = new System.Windows.Forms.Button();
            this.rdoBeep1 = new System.Windows.Forms.RadioButton();
            this.rdoBeep2 = new System.Windows.Forms.RadioButton();
            this.rdoBeep3 = new System.Windows.Forms.RadioButton();
            this.rdoBeep4 = new System.Windows.Forms.RadioButton();
            this.rdoBeep5 = new System.Windows.Forms.RadioButton();
            this.btnWAV = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.tbarVolume = new System.Windows.Forms.TrackBar();
            this.tbarMain = new System.Windows.Forms.TrackBar();
            this.btnMP3 = new System.Windows.Forms.Button();
            this.OFDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBeep
            // 
            this.btnBeep.Location = new System.Drawing.Point(346, 19);
            this.btnBeep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBeep.Name = "btnBeep";
            this.btnBeep.Size = new System.Drawing.Size(128, 26);
            this.btnBeep.TabIndex = 0;
            this.btnBeep.Text = "SystemSound";
            this.btnBeep.UseVisualStyleBackColor = true;
            this.btnBeep.Click += new System.EventHandler(this.btnBeep_Click);
            // 
            // rdoBeep1
            // 
            this.rdoBeep1.AutoSize = true;
            this.rdoBeep1.Location = new System.Drawing.Point(13, 26);
            this.rdoBeep1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoBeep1.Name = "rdoBeep1";
            this.rdoBeep1.Size = new System.Drawing.Size(58, 16);
            this.rdoBeep1.TabIndex = 1;
            this.rdoBeep1.TabStop = true;
            this.rdoBeep1.Text = "Beep1";
            this.rdoBeep1.UseVisualStyleBackColor = true;
            // 
            // rdoBeep2
            // 
            this.rdoBeep2.AutoSize = true;
            this.rdoBeep2.Location = new System.Drawing.Point(80, 26);
            this.rdoBeep2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoBeep2.Name = "rdoBeep2";
            this.rdoBeep2.Size = new System.Drawing.Size(58, 16);
            this.rdoBeep2.TabIndex = 1;
            this.rdoBeep2.TabStop = true;
            this.rdoBeep2.Text = "Beep2";
            this.rdoBeep2.UseVisualStyleBackColor = true;
            // 
            // rdoBeep3
            // 
            this.rdoBeep3.AutoSize = true;
            this.rdoBeep3.Location = new System.Drawing.Point(146, 26);
            this.rdoBeep3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoBeep3.Name = "rdoBeep3";
            this.rdoBeep3.Size = new System.Drawing.Size(58, 16);
            this.rdoBeep3.TabIndex = 2;
            this.rdoBeep3.TabStop = true;
            this.rdoBeep3.Text = "Beep3";
            this.rdoBeep3.UseVisualStyleBackColor = true;
            // 
            // rdoBeep4
            // 
            this.rdoBeep4.AutoSize = true;
            this.rdoBeep4.Location = new System.Drawing.Point(213, 26);
            this.rdoBeep4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoBeep4.Name = "rdoBeep4";
            this.rdoBeep4.Size = new System.Drawing.Size(58, 16);
            this.rdoBeep4.TabIndex = 3;
            this.rdoBeep4.TabStop = true;
            this.rdoBeep4.Text = "Beep4";
            this.rdoBeep4.UseVisualStyleBackColor = true;
            // 
            // rdoBeep5
            // 
            this.rdoBeep5.AutoSize = true;
            this.rdoBeep5.Location = new System.Drawing.Point(279, 26);
            this.rdoBeep5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoBeep5.Name = "rdoBeep5";
            this.rdoBeep5.Size = new System.Drawing.Size(58, 16);
            this.rdoBeep5.TabIndex = 4;
            this.rdoBeep5.TabStop = true;
            this.rdoBeep5.Text = "Beep5";
            this.rdoBeep5.UseVisualStyleBackColor = true;
            // 
            // btnWAV
            // 
            this.btnWAV.Location = new System.Drawing.Point(15, 20);
            this.btnWAV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWAV.Name = "btnWAV";
            this.btnWAV.Size = new System.Drawing.Size(128, 26);
            this.btnWAV.TabIndex = 5;
            this.btnWAV.Text = "WAV Open";
            this.btnWAV.UseVisualStyleBackColor = true;
            this.btnWAV.Click += new System.EventHandler(this.btnWAV_Click_1);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(382, 60);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(33, 26);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "▶";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(426, 60);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(33, 26);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "■";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(470, 60);
            this.btnPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(33, 26);
            this.btnPause.TabIndex = 8;
            this.btnPause.Text = "∥";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // tbarVolume
            // 
            this.tbarVolume.Location = new System.Drawing.Point(508, 57);
            this.tbarVolume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbarVolume.Maximum = 100;
            this.tbarVolume.Name = "tbarVolume";
            this.tbarVolume.Size = new System.Drawing.Size(128, 45);
            this.tbarVolume.TabIndex = 9;
            // 
            // tbarMain
            // 
            this.tbarMain.Enabled = false;
            this.tbarMain.Location = new System.Drawing.Point(19, 57);
            this.tbarMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbarMain.Name = "tbarMain";
            this.tbarMain.Size = new System.Drawing.Size(358, 45);
            this.tbarMain.TabIndex = 10;
            // 
            // btnMP3
            // 
            this.btnMP3.Location = new System.Drawing.Point(508, 26);
            this.btnMP3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMP3.Name = "btnMP3";
            this.btnMP3.Size = new System.Drawing.Size(128, 26);
            this.btnMP3.TabIndex = 11;
            this.btnMP3.Text = "MP3 Open";
            this.btnMP3.UseVisualStyleBackColor = true;
            // 
            // OFDialog
            // 
            this.OFDialog.FileName = "OFDialog";
            // 
            // lblFileName
            // 
            this.lblFileName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFileName.Location = new System.Drawing.Point(19, 26);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(358, 26);
            this.lblFileName.TabIndex = 12;
            this.lblFileName.Text = "-";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.SystemColors.Control;
            this.lblTime.Location = new System.Drawing.Point(191, 86);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(181, 24);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "0 / 0";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Location = new System.Drawing.Point(382, 26);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(121, 26);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "-";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVolume
            // 
            this.lblVolume.Location = new System.Drawing.Point(518, 86);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(118, 24);
            this.lblVolume.TabIndex = 15;
            this.lblVolume.Text = "0";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBeep1);
            this.groupBox1.Controls.Add(this.btnBeep);
            this.groupBox1.Controls.Add(this.rdoBeep2);
            this.groupBox1.Controls.Add(this.rdoBeep3);
            this.groupBox1.Controls.Add(this.rdoBeep4);
            this.groupBox1.Controls.Add(this.rdoBeep5);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(488, 58);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SystemSound";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnWAV);
            this.groupBox2.Location = new System.Drawing.Point(504, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(160, 58);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "WAV Player";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblFileName);
            this.groupBox3.Controls.Add(this.lblStatus);
            this.groupBox3.Controls.Add(this.btnMP3);
            this.groupBox3.Controls.Add(this.lblVolume);
            this.groupBox3.Controls.Add(this.lblTime);
            this.groupBox3.Controls.Add(this.tbarVolume);
            this.groupBox3.Controls.Add(this.tbarMain);
            this.groupBox3.Controls.Add(this.btnPause);
            this.groupBox3.Controls.Add(this.btnPlay);
            this.groupBox3.Controls.Add(this.btnStop);
            this.groupBox3.Location = new System.Drawing.Point(10, 73);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(654, 120);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MP3 Player";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 203);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Sound Player";
            ((System.ComponentModel.ISupportInitialize)(this.tbarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBeep;
        private System.Windows.Forms.RadioButton rdoBeep1;
        private System.Windows.Forms.RadioButton rdoBeep2;
        private System.Windows.Forms.RadioButton rdoBeep3;
        private System.Windows.Forms.RadioButton rdoBeep4;
        private System.Windows.Forms.RadioButton rdoBeep5;
        private System.Windows.Forms.Button btnWAV;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.TrackBar tbarVolume;
        private System.Windows.Forms.TrackBar tbarMain;
        private System.Windows.Forms.Button btnMP3;
        private System.Windows.Forms.OpenFileDialog OFDialog;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

