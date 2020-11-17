namespace Winform22UserControl
{
    partial class UCInfo
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
            this.lblNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnIdle = new System.Windows.Forms.Button();
            this.btnCatch = new System.Windows.Forms.Button();
            this.pboxFace = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFace)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(19, 31);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(11, 12);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "이름 :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(77, 164);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "아무개";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "금액 :";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(77, 189);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(51, 12);
            this.lblGold.TabIndex = 5;
            this.lblGold.Text = "2천 만원";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(3, 227);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 6;
            this.btnReg.Text = "수배";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnIdle
            // 
            this.btnIdle.Location = new System.Drawing.Point(79, 227);
            this.btnIdle.Name = "btnIdle";
            this.btnIdle.Size = new System.Drawing.Size(75, 23);
            this.btnIdle.TabIndex = 7;
            this.btnIdle.Text = "정지";
            this.btnIdle.UseVisualStyleBackColor = true;
            this.btnIdle.Click += new System.EventHandler(this.btn_Click);

            // 
            // btnCatch
            // 
            this.btnCatch.Location = new System.Drawing.Point(160, 227);
            this.btnCatch.Name = "btnCatch";
            this.btnCatch.Size = new System.Drawing.Size(75, 23);
            this.btnCatch.TabIndex = 8;
            this.btnCatch.Text = "잡힘";
            this.btnCatch.UseVisualStyleBackColor = true;
            this.btnCatch.Click += new System.EventHandler(this.btn_Click);

            // 
            // pboxFace
            // 
            this.pboxFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxFace.Location = new System.Drawing.Point(62, 31);
            this.pboxFace.Name = "pboxFace";
            this.pboxFace.Size = new System.Drawing.Size(100, 120);
            this.pboxFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxFace.TabIndex = 1;
            this.pboxFace.TabStop = false;
            // 
            // UCInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.btnCatch);
            this.Controls.Add(this.btnIdle);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pboxFace);
            this.Controls.Add(this.lblNo);
            this.Name = "UCInfo";
            this.Size = new System.Drawing.Size(239, 272);
            ((System.ComponentModel.ISupportInitialize)(this.pboxFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.PictureBox pboxFace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnIdle;
        private System.Windows.Forms.Button btnCatch;
    }
}
