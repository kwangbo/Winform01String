namespace Winform09While
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
            this.lblWhileResult = new System.Windows.Forms.Label();
            this.btnWhile = new System.Windows.Forms.Button();
            this.lboxWhileResult = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWhileend = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWhileResult
            // 
            this.lblWhileResult.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWhileResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWhileResult.Location = new System.Drawing.Point(49, 28);
            this.lblWhileResult.Name = "lblWhileResult";
            this.lblWhileResult.Size = new System.Drawing.Size(530, 44);
            this.lblWhileResult.TabIndex = 0;
            this.lblWhileResult.Text = "0,0,0,0,0,0";
            this.lblWhileResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(613, 28);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(162, 34);
            this.btnWhile.TabIndex = 1;
            this.btnWhile.Text = "로도번호";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // lboxWhileResult
            // 
            this.lboxWhileResult.FormattingEnabled = true;
            this.lboxWhileResult.ItemHeight = 12;
            this.lboxWhileResult.Location = new System.Drawing.Point(51, 98);
            this.lboxWhileResult.Name = "lboxWhileResult";
            this.lboxWhileResult.Size = new System.Drawing.Size(528, 220);
            this.lboxWhileResult.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(51, 325);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 20);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "선택번호";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "1 ~ 100 안의 숫자를 선택하세요";
            // 
            // tboxNumber
            // 
            this.tboxNumber.Location = new System.Drawing.Point(62, 385);
            this.tboxNumber.Name = "tboxNumber";
            this.tboxNumber.Size = new System.Drawing.Size(100, 21);
            this.tboxNumber.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "-";
            // 
            // lblWhileend
            // 
            this.lblWhileend.AutoSize = true;
            this.lblWhileend.Location = new System.Drawing.Point(49, 453);
            this.lblWhileend.Name = "lblWhileend";
            this.lblWhileend.Size = new System.Drawing.Size(178, 12);
            this.lblWhileend.TabIndex = 5;
            this.lblWhileend.Text = "1 ~ 100 안의 숫자를 선택하세요";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 499);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxNumber);
            this.Controls.Add(this.lblWhileend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lboxWhileResult);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.lblWhileResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWhileResult;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.ListBox lboxWhileResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWhileend;
    }
}

