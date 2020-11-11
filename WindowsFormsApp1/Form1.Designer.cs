namespace WindowsFormsApp1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPick4 = new System.Windows.Forms.Label();
            this.lblPick3 = new System.Windows.Forms.Label();
            this.lblPick2 = new System.Windows.Forms.Label();
            this.pBox3 = new System.Windows.Forms.PictureBox();
            this.pBox2 = new System.Windows.Forms.PictureBox();
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.pBox4 = new System.Windows.Forms.PictureBox();
            this.lblPick1 = new System.Windows.Forms.Label();
            this.dgViewList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltotalCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "선호하는 항목을 선택해 주세요.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblPick4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPick3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPick2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pBox3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pBox4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPick1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(57, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(634, 184);
            this.tableLayoutPanel1.TabIndex = 1;
            
            // 
            // lblPick4
            // 
            this.lblPick4.AutoSize = true;
            this.lblPick4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPick4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPick4.Location = new System.Drawing.Point(477, 159);
            this.lblPick4.Name = "lblPick4";
            this.lblPick4.Size = new System.Drawing.Size(154, 25);
            this.lblPick4.TabIndex = 7;
            this.lblPick4.Text = "0";
            this.lblPick4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPick3
            // 
            this.lblPick3.AutoSize = true;
            this.lblPick3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPick3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPick3.Location = new System.Drawing.Point(319, 159);
            this.lblPick3.Name = "lblPick3";
            this.lblPick3.Size = new System.Drawing.Size(152, 25);
            this.lblPick3.TabIndex = 6;
            this.lblPick3.Text = "0";
            this.lblPick3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPick2
            // 
            this.lblPick2.AutoSize = true;
            this.lblPick2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPick2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPick2.Location = new System.Drawing.Point(161, 159);
            this.lblPick2.Name = "lblPick2";
            this.lblPick2.Size = new System.Drawing.Size(152, 25);
            this.lblPick2.TabIndex = 5;
            this.lblPick2.Text = "0";
            this.lblPick2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pBox3
            // 
            this.pBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox3.Image = global::WindowsFormsApp1.Properties.Resources._3;
            this.pBox3.Location = new System.Drawing.Point(319, 3);
            this.pBox3.Name = "pBox3";
            this.pBox3.Size = new System.Drawing.Size(152, 153);
            this.pBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox3.TabIndex = 3;
            this.pBox3.TabStop = false;
            this.pBox3.Click += new System.EventHandler(this.pBox_Click);
            // 
            // pBox2
            // 
            this.pBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox2.Image = global::WindowsFormsApp1.Properties.Resources._2;
            this.pBox2.Location = new System.Drawing.Point(161, 3);
            this.pBox2.Name = "pBox2";
            this.pBox2.Size = new System.Drawing.Size(152, 153);
            this.pBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox2.TabIndex = 2;
            this.pBox2.TabStop = false;
            this.pBox2.Click += new System.EventHandler(this.pBox_Click);
            // 
            // pBox1
            // 
            this.pBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox1.Image = global::WindowsFormsApp1.Properties.Resources._1;
            this.pBox1.Location = new System.Drawing.Point(3, 3);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(152, 153);
            this.pBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox1.TabIndex = 1;
            this.pBox1.TabStop = false;
            this.pBox1.Click += new System.EventHandler(this.pBox_Click);
            // 
            // pBox4
            // 
            this.pBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox4.Image = global::WindowsFormsApp1.Properties.Resources._2;
            this.pBox4.Location = new System.Drawing.Point(477, 3);
            this.pBox4.Name = "pBox4";
            this.pBox4.Size = new System.Drawing.Size(154, 153);
            this.pBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox4.TabIndex = 0;
            this.pBox4.TabStop = false;
            this.pBox4.Click += new System.EventHandler(this.pBox_Click);
            // 
            // lblPick1
            // 
            this.lblPick1.AutoSize = true;
            this.lblPick1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPick1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPick1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPick1.Location = new System.Drawing.Point(3, 159);
            this.lblPick1.Name = "lblPick1";
            this.lblPick1.Size = new System.Drawing.Size(152, 25);
            this.lblPick1.TabIndex = 4;
            this.lblPick1.Text = "0";
            this.lblPick1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgViewList
            // 
            this.dgViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewList.Location = new System.Drawing.Point(90, 346);
            this.dgViewList.Name = "dgViewList";
            this.dgViewList.RowTemplate.Height = 23;
            this.dgViewList.Size = new System.Drawing.Size(460, 311);
            this.dgViewList.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Count :";
            // 
            // lbltotalCount
            // 
            this.lbltotalCount.AutoSize = true;
            this.lbltotalCount.Location = new System.Drawing.Point(113, 261);
            this.lbltotalCount.Name = "lbltotalCount";
            this.lbltotalCount.Size = new System.Drawing.Size(11, 12);
            this.lbltotalCount.TabIndex = 4;
            this.lbltotalCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "※ List의 Data를 화면에 보여줍니다.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 681);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltotalCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgViewList);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgViewList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltotalCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pBox4;
        private System.Windows.Forms.PictureBox pBox3;
        private System.Windows.Forms.PictureBox pBox2;
        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.Label lblPick4;
        private System.Windows.Forms.Label lblPick3;
        private System.Windows.Forms.Label lblPick2;
        private System.Windows.Forms.Label lblPick1;
    }
}

