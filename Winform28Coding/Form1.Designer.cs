namespace Winform28Coding
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
            this.dgChangedata = new System.Windows.Forms.DataGridView();
            this.CBefore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAfter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tboxBefore = new System.Windows.Forms.TextBox();
            this.tboxAfter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgChangedata)).BeginInit();
            this.SuspendLayout();
            // 
            // dgChangedata
            // 
            this.dgChangedata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChangedata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CBefore,
            this.CAfter});
            this.dgChangedata.Location = new System.Drawing.Point(281, 155);
            this.dgChangedata.Name = "dgChangedata";
            this.dgChangedata.RowTemplate.Height = 23;
            this.dgChangedata.Size = new System.Drawing.Size(240, 248);
            this.dgChangedata.TabIndex = 0;
            // 
            // CBefore
            // 
            this.CBefore.HeaderText = "Before";
            this.CBefore.Name = "CBefore";
            // 
            // CAfter
            // 
            this.CAfter.HeaderText = "After";
            this.CAfter.Name = "CAfter";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "변환";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tboxBefore
            // 
            this.tboxBefore.Location = new System.Drawing.Point(25, 155);
            this.tboxBefore.Multiline = true;
            this.tboxBefore.Name = "tboxBefore";
            this.tboxBefore.Size = new System.Drawing.Size(250, 248);
            this.tboxBefore.TabIndex = 4;
            this.tboxBefore.Text = "1. 개동도 약에 쓸려면 없다\r\n2. 닭 쫓던 개 지붕 쳐다 본다\r\n3. 꿩 대신 닭\r\n4. 고양이 한테 생선을 맡긴다\r\n5. 꿩 먹고 알 먹기";
            // 
            // tboxAfter
            // 
            this.tboxAfter.Location = new System.Drawing.Point(527, 155);
            this.tboxAfter.Multiline = true;
            this.tboxAfter.Name = "tboxAfter";
            this.tboxAfter.Size = new System.Drawing.Size(250, 248);
            this.tboxAfter.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tboxAfter);
            this.Controls.Add(this.tboxBefore);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgChangedata);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgChangedata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgChangedata;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBefore;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAfter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tboxBefore;
        private System.Windows.Forms.TextBox tboxAfter;
    }
}

