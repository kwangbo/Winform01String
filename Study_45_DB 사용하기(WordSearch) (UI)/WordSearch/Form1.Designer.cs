namespace WordSearch
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
            this.tboxPath = new System.Windows.Forms.TextBox();
            this.btnDBLoad = new System.Windows.Forms.Button();
            this.dgData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tboxQuery = new System.Windows.Forms.TextBox();
            this.btnEx1 = new System.Windows.Forms.Button();
            this.btnEx2 = new System.Windows.Forms.Button();
            this.btnEx3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExe = new System.Windows.Forms.Button();
            this.OFDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboxPath
            // 
            this.tboxPath.Enabled = false;
            this.tboxPath.Location = new System.Drawing.Point(15, 20);
            this.tboxPath.Name = "tboxPath";
            this.tboxPath.Size = new System.Drawing.Size(477, 21);
            this.tboxPath.TabIndex = 0;
            // 
            // btnDBLoad
            // 
            this.btnDBLoad.Location = new System.Drawing.Point(498, 19);
            this.btnDBLoad.Name = "btnDBLoad";
            this.btnDBLoad.Size = new System.Drawing.Size(74, 23);
            this.btnDBLoad.TabIndex = 1;
            this.btnDBLoad.Text = "DB Load";
            this.btnDBLoad.UseVisualStyleBackColor = true;
            this.btnDBLoad.Click += new System.EventHandler(this.btnDBLoad_Click);
            // 
            // dgData
            // 
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Location = new System.Drawing.Point(6, 20);
            this.dgData.Name = "dgData";
            this.dgData.RowTemplate.Height = 23;
            this.dgData.Size = new System.Drawing.Size(567, 324);
            this.dgData.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tboxPath);
            this.groupBox1.Controls.Add(this.btnDBLoad);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 55);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "가져오기";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tboxQuery);
            this.groupBox2.Controls.Add(this.btnEx1);
            this.groupBox2.Controls.Add(this.btnEx2);
            this.groupBox2.Controls.Add(this.btnEx3);
            this.groupBox2.Location = new System.Drawing.Point(12, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 179);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "조회";
            // 
            // tboxQuery
            // 
            this.tboxQuery.Location = new System.Drawing.Point(6, 48);
            this.tboxQuery.Multiline = true;
            this.tboxQuery.Name = "tboxQuery";
            this.tboxQuery.Size = new System.Drawing.Size(567, 117);
            this.tboxQuery.TabIndex = 3;
            // 
            // btnEx1
            // 
            this.btnEx1.Location = new System.Drawing.Point(336, 17);
            this.btnEx1.Name = "btnEx1";
            this.btnEx1.Size = new System.Drawing.Size(75, 23);
            this.btnEx1.TabIndex = 2;
            this.btnEx1.Text = "예제1";
            this.btnEx1.UseVisualStyleBackColor = true;
            this.btnEx1.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // btnEx2
            // 
            this.btnEx2.Location = new System.Drawing.Point(417, 17);
            this.btnEx2.Name = "btnEx2";
            this.btnEx2.Size = new System.Drawing.Size(75, 23);
            this.btnEx2.TabIndex = 1;
            this.btnEx2.Text = "예제2";
            this.btnEx2.UseVisualStyleBackColor = true;
            this.btnEx2.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // btnEx3
            // 
            this.btnEx3.Location = new System.Drawing.Point(498, 17);
            this.btnEx3.Name = "btnEx3";
            this.btnEx3.Size = new System.Drawing.Size(75, 23);
            this.btnEx3.TabIndex = 0;
            this.btnEx3.Text = "예제3";
            this.btnEx3.UseVisualStyleBackColor = true;
            this.btnEx3.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgData);
            this.groupBox3.Location = new System.Drawing.Point(12, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(582, 350);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "결과";
            // 
            // btnExe
            // 
            this.btnExe.Location = new System.Drawing.Point(510, 272);
            this.btnExe.Name = "btnExe";
            this.btnExe.Size = new System.Drawing.Size(75, 23);
            this.btnExe.TabIndex = 4;
            this.btnExe.Text = "실행";
            this.btnExe.UseVisualStyleBackColor = true;
            this.btnExe.Click += new System.EventHandler(this.btnExe_Click);
            // 
            // OFDialog
            // 
            this.OFDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 658);
            this.Controls.Add(this.btnExe);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tboxPath;
        private System.Windows.Forms.Button btnDBLoad;
        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tboxQuery;
        private System.Windows.Forms.Button btnEx1;
        private System.Windows.Forms.Button btnEx2;
        private System.Windows.Forms.Button btnEx3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExe;
        private System.Windows.Forms.OpenFileDialog OFDialog;
    }
}

