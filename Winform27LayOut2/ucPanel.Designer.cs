﻿namespace Winform27LayOut2
{
    partial class ucPanel
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSize = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Fuchsia;
            this.panel1.Controls.Add(this.lblSize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 209);
            this.panel1.TabIndex = 1;
            // 
            // lblSize
            // 
            this.lblSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSize.Location = new System.Drawing.Point(0, 0);
            this.lblSize.Margin = new System.Windows.Forms.Padding(0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(234, 209);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "(0,0)";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSize.Click += new System.EventHandler(this.label1_Click);
            this.lblSize.DoubleClick += new System.EventHandler(this.lblSize_DoubleClick);
            // 
            // ucPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.panel1);
            this.Name = "ucPanel";
            this.Size = new System.Drawing.Size(234, 209);
            this.SizeChanged += new System.EventHandler(this.PanelSizeChanged);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSize;
    }
}
