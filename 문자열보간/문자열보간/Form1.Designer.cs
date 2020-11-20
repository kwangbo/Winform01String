namespace 문자열보간
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbox1Value1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox1Value2 = new System.Windows.Forms.TextBox();
            this.lboxStringFormat = new System.Windows.Forms.ListBox();
            this.lboxStringInterpolation = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.btn3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn4 = new System.Windows.Forms.Button();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.btn2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn6 = new System.Windows.Forms.Button();
            this.tbox6Value = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn7 = new System.Windows.Forms.Button();
            this.tbox7Value = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbox5Value = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. 변수 입력 : He is a Teacher";
            // 
            // tbox1Value1
            // 
            this.tbox1Value1.Location = new System.Drawing.Point(51, 35);
            this.tbox1Value1.Name = "tbox1Value1";
            this.tbox1Value1.Size = new System.Drawing.Size(66, 21);
            this.tbox1Value1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "is";
            // 
            // tbox1Value2
            // 
            this.tbox1Value2.Location = new System.Drawing.Point(144, 35);
            this.tbox1Value2.Name = "tbox1Value2";
            this.tbox1Value2.Size = new System.Drawing.Size(118, 21);
            this.tbox1Value2.TabIndex = 3;
            // 
            // lboxStringFormat
            // 
            this.lboxStringFormat.FormattingEnabled = true;
            this.lboxStringFormat.ItemHeight = 12;
            this.lboxStringFormat.Location = new System.Drawing.Point(12, 262);
            this.lboxStringFormat.Name = "lboxStringFormat";
            this.lboxStringFormat.Size = new System.Drawing.Size(160, 172);
            this.lboxStringFormat.TabIndex = 4;
            // 
            // lboxStringInterpolation
            // 
            this.lboxStringInterpolation.FormattingEnabled = true;
            this.lboxStringInterpolation.ItemHeight = 12;
            this.lboxStringInterpolation.Location = new System.Drawing.Point(178, 262);
            this.lboxStringInterpolation.Name = "lboxStringInterpolation";
            this.lboxStringInterpolation.Size = new System.Drawing.Size(160, 172);
            this.lboxStringInterpolation.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "- String.Format";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(181, 247);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(91, 12);
            this.lblTest.TabIndex = 7;
            this.lblTest.Text = "- 문자열보간($)";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(274, 35);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(54, 21);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "변환";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "2. 현재 시간 표기";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "3. 조건";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(51, 148);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(48, 21);
            this.num1.TabIndex = 11;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(125, 148);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(48, 21);
            this.num2.TabIndex = 12;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(274, 148);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(54, 21);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "변환";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "4. 보간문자 사용 : { }";
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(274, 178);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(54, 21);
            this.btn4.TabIndex = 16;
            this.btn4.Text = "변환";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(51, 93);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(211, 21);
            this.dtPicker.TabIndex = 17;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(274, 93);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(54, 21);
            this.btn2.TabIndex = 18;
            this.btn2.Text = "변환";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(351, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "6. 이스케이프 시퀀스(@)";
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(574, 11);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(54, 21);
            this.btn6.TabIndex = 21;
            this.btn6.Text = "변환";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // tbox6Value
            // 
            this.tbox6Value.Location = new System.Drawing.Point(365, 30);
            this.tbox6Value.Multiline = true;
            this.tbox6Value.Name = "tbox6Value";
            this.tbox6Value.Size = new System.Drawing.Size(269, 103);
            this.tbox6Value.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "7. Query 표현 식($@ 함께 사용)";
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(574, 155);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(54, 21);
            this.btn7.TabIndex = 26;
            this.btn7.Text = "변환";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // tbox7Value
            // 
            this.tbox7Value.Location = new System.Drawing.Point(365, 182);
            this.tbox7Value.Multiline = true;
            this.tbox7Value.Name = "tbox7Value";
            this.tbox7Value.Size = new System.Drawing.Size(269, 252);
            this.tbox7Value.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 12);
            this.label11.TabIndex = 28;
            this.label11.Text = "5. 단항식 사용 :";
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(274, 207);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(54, 21);
            this.btn5.TabIndex = 29;
            this.btn5.Text = "변환";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(105, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 30;
            this.label12.Text = "과";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(179, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 12);
            this.label13.TabIndex = 31;
            this.label13.Text = "중 더 큰 수는?";
            // 
            // tbox5Value
            // 
            this.tbox5Value.Location = new System.Drawing.Point(115, 207);
            this.tbox5Value.Name = "tbox5Value";
            this.tbox5Value.Size = new System.Drawing.Size(147, 21);
            this.tbox5Value.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 442);
            this.Controls.Add(this.tbox5Value);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbox7Value);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbox6Value);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lboxStringInterpolation);
            this.Controls.Add(this.lboxStringFormat);
            this.Controls.Add(this.tbox1Value2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox1Value1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox1Value1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox1Value2;
        private System.Windows.Forms.ListBox lboxStringFormat;
        private System.Windows.Forms.ListBox lboxStringInterpolation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.NumericUpDown num2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.TextBox tbox6Value;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.TextBox tbox7Value;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbox5Value;
    }
}

