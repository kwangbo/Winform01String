namespace Winform21Exception2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblColorInfo = new System.Windows.Forms.Label();
            this.tbarAlpha = new System.Windows.Forms.TrackBar();
            this.pColor = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lboxColor = new System.Windows.Forms.ListBox();
            this.btnColorsave = new System.Windows.Forms.Button();
            this.btnColorDel = new System.Windows.Forms.Button();
            this.cdialogColor = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAlpha)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblColorInfo);
            this.groupBox1.Controls.Add(this.tbarAlpha);
            this.groupBox1.Controls.Add(this.pColor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Select";
            // 
            // lblColorInfo
            // 
            this.lblColorInfo.AutoSize = true;
            this.lblColorInfo.Location = new System.Drawing.Point(86, 126);
            this.lblColorInfo.Name = "lblColorInfo";
            this.lblColorInfo.Size = new System.Drawing.Size(42, 12);
            this.lblColorInfo.TabIndex = 6;
            this.lblColorInfo.Text = "Text : ";
            // 
            // tbarAlpha
            // 
            this.tbarAlpha.Location = new System.Drawing.Point(88, 66);
            this.tbarAlpha.Maximum = 255;
            this.tbarAlpha.Name = "tbarAlpha";
            this.tbarAlpha.Size = new System.Drawing.Size(104, 45);
            this.tbarAlpha.TabIndex = 5;
            this.tbarAlpha.Value = 255;
            this.tbarAlpha.Scroll += new System.EventHandler(this.tbarAlpha_Scroll);
            // 
            // pColor
            // 
            this.pColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColor.Location = new System.Drawing.Point(88, 35);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(20, 20);
            this.pColor.TabIndex = 4;
            this.pColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pColor_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Text : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Alpha : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color : ";
            // 
            // lboxColor
            // 
            this.lboxColor.FormattingEnabled = true;
            this.lboxColor.ItemHeight = 12;
            this.lboxColor.Location = new System.Drawing.Point(29, 308);
            this.lboxColor.Name = "lboxColor";
            this.lboxColor.Size = new System.Drawing.Size(420, 208);
            this.lboxColor.TabIndex = 1;
            this.lboxColor.SelectedIndexChanged += new System.EventHandler(this.lboxColor_SelectedIndexChanged);
            // 
            // btnColorsave
            // 
            this.btnColorsave.Location = new System.Drawing.Point(179, 261);
            this.btnColorsave.Name = "btnColorsave";
            this.btnColorsave.Size = new System.Drawing.Size(75, 23);
            this.btnColorsave.TabIndex = 2;
            this.btnColorsave.Text = "저장";
            this.btnColorsave.UseVisualStyleBackColor = true;
            this.btnColorsave.Click += new System.EventHandler(this.btnColorsave_Click);
            // 
            // btnColorDel
            // 
            this.btnColorDel.Location = new System.Drawing.Point(314, 261);
            this.btnColorDel.Name = "btnColorDel";
            this.btnColorDel.Size = new System.Drawing.Size(75, 23);
            this.btnColorDel.TabIndex = 3;
            this.btnColorDel.Text = "삭제";
            this.btnColorDel.UseVisualStyleBackColor = true;
            this.btnColorDel.Click += new System.EventHandler(this.btnColorDel_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Winform21Exception2.Properties.Resources.python;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(509, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 479);
            this.panel1.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(37, 352);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 100);
            this.panel6.TabIndex = 4;
            this.panel6.Click += new System.EventHandler(this.PanelClickEvent);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(240, 284);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 100);
            this.panel5.TabIndex = 3;
            this.panel5.Click += new System.EventHandler(this.PanelClickEvent);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Location = new System.Drawing.Point(37, 206);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 100);
            this.panel4.TabIndex = 2;
            this.panel4.Click += new System.EventHandler(this.PanelClickEvent);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(155, 81);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(197, 100);
            this.panel7.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(216, 167);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 100);
            this.panel3.TabIndex = 1;
            this.panel3.Click += new System.EventHandler(this.PanelClickEvent);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(51, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 100);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.PanelClickEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnColorDel);
            this.Controls.Add(this.btnColorsave);
            this.Controls.Add(this.lboxColor);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.Text = "-";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAlpha)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblColorInfo;
        private System.Windows.Forms.TrackBar tbarAlpha;
        private System.Windows.Forms.Panel pColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lboxColor;
        private System.Windows.Forms.Button btnColorsave;
        private System.Windows.Forms.Button btnColorDel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColorDialog cdialogColor;
    }
}

