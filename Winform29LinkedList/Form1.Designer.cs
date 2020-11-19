namespace Winform29LinkedList
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
            this.mcScheduler = new System.Windows.Forms.MonthCalendar();
            this.tboxScheduleer = new System.Windows.Forms.TextBox();
            this.btnScheduler = new System.Windows.Forms.Button();
            this.lboxScheduler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // mcScheduler
            // 
            this.mcScheduler.Location = new System.Drawing.Point(18, 35);
            this.mcScheduler.Name = "mcScheduler";
            this.mcScheduler.TabIndex = 0;
            this.mcScheduler.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcScheduler_DateChanged);
            // 
            // tboxScheduleer
            // 
            this.tboxScheduleer.Location = new System.Drawing.Point(18, 209);
            this.tboxScheduleer.Multiline = true;
            this.tboxScheduleer.Name = "tboxScheduleer";
            this.tboxScheduleer.Size = new System.Drawing.Size(222, 118);
            this.tboxScheduleer.TabIndex = 2;
            // 
            // btnScheduler
            // 
            this.btnScheduler.Location = new System.Drawing.Point(18, 353);
            this.btnScheduler.Name = "btnScheduler";
            this.btnScheduler.Size = new System.Drawing.Size(222, 19);
            this.btnScheduler.TabIndex = 3;
            this.btnScheduler.Text = "button1";
            this.btnScheduler.UseVisualStyleBackColor = true;
            this.btnScheduler.Click += new System.EventHandler(this.btnScheduler_Click);
            // 
            // lboxScheduler
            // 
            this.lboxScheduler.FormattingEnabled = true;
            this.lboxScheduler.ItemHeight = 12;
            this.lboxScheduler.Location = new System.Drawing.Point(264, 45);
            this.lboxScheduler.Name = "lboxScheduler";
            this.lboxScheduler.Size = new System.Drawing.Size(305, 268);
            this.lboxScheduler.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 450);
            this.Controls.Add(this.lboxScheduler);
            this.Controls.Add(this.btnScheduler);
            this.Controls.Add(this.tboxScheduleer);
            this.Controls.Add(this.mcScheduler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcScheduler;
        private System.Windows.Forms.TextBox tboxScheduleer;
        private System.Windows.Forms.Button btnScheduler;
        private System.Windows.Forms.ListBox lboxScheduler;
    }
}

