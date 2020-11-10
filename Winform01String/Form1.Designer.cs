namespace Winform01String
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
            this.lblText = new Infragistics.Win.Misc.UltraLabel();
            this.ultraButton1 = new Infragistics.Win.Misc.UltraButton();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel3 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel5 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel6 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel7 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel8 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel9 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel10 = new Infragistics.Win.Misc.UltraLabel();
            this.lblContail = new Infragistics.Win.Misc.UltraLabel();
            this.lblEquals = new Infragistics.Win.Misc.UltraLabel();
            this.lblLength = new Infragistics.Win.Misc.UltraLabel();
            this.lblReplace = new Infragistics.Win.Misc.UltraLabel();
            this.lblSplit1 = new Infragistics.Win.Misc.UltraLabel();
            this.lblSplit2 = new Infragistics.Win.Misc.UltraLabel();
            this.lblSplit3 = new Infragistics.Win.Misc.UltraLabel();
            this.lblSubstring = new Infragistics.Win.Misc.UltraLabel();
            this.lblTrim = new Infragistics.Win.Misc.UltraLabel();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.Location = new System.Drawing.Point(69, 28);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(100, 23);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Sample,Test,Text";
            // 
            // ultraButton1
            // 
            this.ultraButton1.Location = new System.Drawing.Point(522, 28);
            this.ultraButton1.Name = "ultraButton1";
            this.ultraButton1.Size = new System.Drawing.Size(75, 23);
            this.ultraButton1.TabIndex = 1;
            this.ultraButton1.Text = "실행";
            this.ultraButton1.Click += new System.EventHandler(this.ultraButton1_Click);
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Location = new System.Drawing.Point(69, 112);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(100, 23);
            this.ultraLabel2.TabIndex = 2;
            this.ultraLabel2.Text = "Contail";
            // 
            // ultraLabel3
            // 
            this.ultraLabel3.Location = new System.Drawing.Point(69, 169);
            this.ultraLabel3.Name = "ultraLabel3";
            this.ultraLabel3.Size = new System.Drawing.Size(100, 23);
            this.ultraLabel3.TabIndex = 3;
            this.ultraLabel3.Text = "Equals";
            // 
            // ultraLabel4
            // 
            this.ultraLabel4.Location = new System.Drawing.Point(69, 214);
            this.ultraLabel4.Name = "ultraLabel4";
            this.ultraLabel4.Size = new System.Drawing.Size(100, 23);
            this.ultraLabel4.TabIndex = 4;
            this.ultraLabel4.Text = "Lenfth";
            // 
            // ultraLabel5
            // 
            this.ultraLabel5.Location = new System.Drawing.Point(69, 256);
            this.ultraLabel5.Name = "ultraLabel5";
            this.ultraLabel5.Size = new System.Drawing.Size(100, 23);
            this.ultraLabel5.TabIndex = 5;
            this.ultraLabel5.Text = "Replace";
            // 
            // ultraLabel6
            // 
            this.ultraLabel6.Location = new System.Drawing.Point(69, 309);
            this.ultraLabel6.Name = "ultraLabel6";
            this.ultraLabel6.Size = new System.Drawing.Size(100, 23);
            this.ultraLabel6.TabIndex = 6;
            this.ultraLabel6.Text = "Split";
            // 
            // ultraLabel7
            // 
            this.ultraLabel7.Location = new System.Drawing.Point(381, 112);
            this.ultraLabel7.Name = "ultraLabel7";
            this.ultraLabel7.Size = new System.Drawing.Size(100, 23);
            this.ultraLabel7.TabIndex = 7;
            this.ultraLabel7.Text = "Substring";
            // 
            // ultraLabel8
            // 
            this.ultraLabel8.Location = new System.Drawing.Point(381, 150);
            this.ultraLabel8.Name = "ultraLabel8";
            this.ultraLabel8.Size = new System.Drawing.Size(100, 23);
            this.ultraLabel8.TabIndex = 8;
            this.ultraLabel8.Text = "Sample, Test, Text";
            // 
            // ultraLabel9
            // 
            this.ultraLabel9.Location = new System.Drawing.Point(381, 197);
            this.ultraLabel9.Name = "ultraLabel9";
            this.ultraLabel9.Size = new System.Drawing.Size(100, 23);
            this.ultraLabel9.TabIndex = 9;
            this.ultraLabel9.Text = "Sample, Test, Text";
            // 
            // ultraLabel10
            // 
            this.ultraLabel10.Location = new System.Drawing.Point(381, 235);
            this.ultraLabel10.Name = "ultraLabel10";
            this.ultraLabel10.Size = new System.Drawing.Size(100, 23);
            this.ultraLabel10.TabIndex = 10;
            this.ultraLabel10.Text = "Trim";
            // 
            // lblContail
            // 
            this.lblContail.Location = new System.Drawing.Point(188, 112);
            this.lblContail.Name = "lblContail";
            this.lblContail.Size = new System.Drawing.Size(100, 23);
            this.lblContail.TabIndex = 11;
            this.lblContail.Text = "-";
            // 
            // lblEquals
            // 
            this.lblEquals.Location = new System.Drawing.Point(175, 169);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(100, 23);
            this.lblEquals.TabIndex = 12;
            this.lblEquals.Text = "-";
            // 
            // lblLength
            // 
            this.lblLength.Location = new System.Drawing.Point(175, 214);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(100, 23);
            this.lblLength.TabIndex = 13;
            this.lblLength.Text = "-";
            // 
            // lblReplace
            // 
            this.lblReplace.Location = new System.Drawing.Point(161, 256);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(100, 23);
            this.lblReplace.TabIndex = 14;
            this.lblReplace.Text = "-";
            // 
            // lblSplit1
            // 
            this.lblSplit1.Location = new System.Drawing.Point(150, 309);
            this.lblSplit1.Name = "lblSplit1";
            this.lblSplit1.Size = new System.Drawing.Size(100, 23);
            this.lblSplit1.TabIndex = 15;
            this.lblSplit1.Text = "-";
            // 
            // lblSplit2
            // 
            this.lblSplit2.Location = new System.Drawing.Point(150, 338);
            this.lblSplit2.Name = "lblSplit2";
            this.lblSplit2.Size = new System.Drawing.Size(100, 23);
            this.lblSplit2.TabIndex = 16;
            this.lblSplit2.Text = "-";
            // 
            // lblSplit3
            // 
            this.lblSplit3.Location = new System.Drawing.Point(150, 378);
            this.lblSplit3.Name = "lblSplit3";
            this.lblSplit3.Size = new System.Drawing.Size(100, 23);
            this.lblSplit3.TabIndex = 17;
            this.lblSplit3.Text = "-";
            // 
            // lblSubstring
            // 
            this.lblSubstring.Location = new System.Drawing.Point(522, 112);
            this.lblSubstring.Name = "lblSubstring";
            this.lblSubstring.Size = new System.Drawing.Size(100, 23);
            this.lblSubstring.TabIndex = 18;
            this.lblSubstring.Text = "-";
            // 
            // lblTrim
            // 
            this.lblTrim.Location = new System.Drawing.Point(497, 235);
            this.lblTrim.Name = "lblTrim";
            this.lblTrim.Size = new System.Drawing.Size(100, 23);
            this.lblTrim.TabIndex = 19;
            this.lblTrim.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTrim);
            this.Controls.Add(this.lblSubstring);
            this.Controls.Add(this.lblSplit3);
            this.Controls.Add(this.lblSplit2);
            this.Controls.Add(this.lblSplit1);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.lblContail);
            this.Controls.Add(this.ultraLabel10);
            this.Controls.Add(this.ultraLabel9);
            this.Controls.Add(this.ultraLabel8);
            this.Controls.Add(this.ultraLabel7);
            this.Controls.Add(this.ultraLabel6);
            this.Controls.Add(this.ultraLabel5);
            this.Controls.Add(this.ultraLabel4);
            this.Controls.Add(this.ultraLabel3);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.ultraButton1);
            this.Controls.Add(this.lblText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraLabel lblText;
        private Infragistics.Win.Misc.UltraButton ultraButton1;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel3;
        private Infragistics.Win.Misc.UltraLabel ultraLabel4;
        private Infragistics.Win.Misc.UltraLabel ultraLabel5;
        private Infragistics.Win.Misc.UltraLabel ultraLabel6;
        private Infragistics.Win.Misc.UltraLabel ultraLabel7;
        private Infragistics.Win.Misc.UltraLabel ultraLabel8;
        private Infragistics.Win.Misc.UltraLabel ultraLabel9;
        private Infragistics.Win.Misc.UltraLabel ultraLabel10;
        private Infragistics.Win.Misc.UltraLabel lblContail;
        private Infragistics.Win.Misc.UltraLabel lblEquals;
        private Infragistics.Win.Misc.UltraLabel lblLength;
        private Infragistics.Win.Misc.UltraLabel lblReplace;
        private Infragistics.Win.Misc.UltraLabel lblSplit1;
        private Infragistics.Win.Misc.UltraLabel lblSplit2;
        private Infragistics.Win.Misc.UltraLabel lblSplit3;
        private Infragistics.Win.Misc.UltraLabel lblSubstring;
        private Infragistics.Win.Misc.UltraLabel lblTrim;
    }
}

