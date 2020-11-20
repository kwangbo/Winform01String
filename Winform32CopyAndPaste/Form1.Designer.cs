namespace Winform32CopyAndPaste
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lboxTextSave = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblActivation = new System.Windows.Forms.Label();
            this.cboxActication = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tBar = new System.Windows.Forms.TrackBar();
            this.btnBtextadd = new System.Windows.Forms.Button();
            this.tboxAdd = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lboxTextSave, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lboxTextSave
            // 
            this.lboxTextSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxTextSave.FormattingEnabled = true;
            this.lboxTextSave.ItemHeight = 12;
            this.lboxTextSave.Location = new System.Drawing.Point(3, 43);
            this.lboxTextSave.Name = "lboxTextSave";
            this.lboxTextSave.Size = new System.Drawing.Size(521, 297);
            this.lboxTextSave.TabIndex = 0;
            this.lboxTextSave.SelectedIndexChanged += new System.EventHandler(this.LboxTestSave_SelectedIndexChanged);
            this.lboxTextSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lboxTextSave_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblActivation);
            this.panel1.Controls.Add(this.cboxActication);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 34);
            this.panel1.TabIndex = 1;
            // 
            // lblActivation
            // 
            this.lblActivation.AutoSize = true;
            this.lblActivation.Location = new System.Drawing.Point(247, 10);
            this.lblActivation.Name = "lblActivation";
            this.lblActivation.Size = new System.Drawing.Size(153, 12);
            this.lblActivation.TabIndex = 1;
            this.lblActivation.Text = "활성화 상태(Ctrl + C  가능)";
            // 
            // cboxActication
            // 
            this.cboxActication.AutoSize = true;
            this.cboxActication.Checked = true;
            this.cboxActication.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxActication.Location = new System.Drawing.Point(38, 9);
            this.cboxActication.Name = "cboxActication";
            this.cboxActication.Size = new System.Drawing.Size(78, 16);
            this.cboxActication.TabIndex = 0;
            this.cboxActication.Text = "Activation";
            this.cboxActication.UseVisualStyleBackColor = true;
            this.cboxActication.CheckedChanged += new System.EventHandler(this.cboxActication_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tBar);
            this.panel2.Controls.Add(this.btnBtextadd);
            this.panel2.Controls.Add(this.tboxAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 51);
            this.panel2.TabIndex = 2;
            // 
            // tBar
            // 
            this.tBar.Location = new System.Drawing.Point(389, 3);
            this.tBar.Minimum = 2;
            this.tBar.Name = "tBar";
            this.tBar.Size = new System.Drawing.Size(115, 45);
            this.tBar.TabIndex = 2;
            this.tBar.Value = 10;
            this.tBar.Scroll += new System.EventHandler(this.tBar_Scroll_Change);
            // 
            // btnBtextadd
            // 
            this.btnBtextadd.Location = new System.Drawing.Point(256, 8);
            this.btnBtextadd.Name = "btnBtextadd";
            this.btnBtextadd.Size = new System.Drawing.Size(127, 23);
            this.btnBtextadd.TabIndex = 1;
            this.btnBtextadd.Text = "등록";
            this.btnBtextadd.UseVisualStyleBackColor = true;
            this.btnBtextadd.Click += new System.EventHandler(this.btnBtextadd_Click);
            // 
            // tboxAdd
            // 
            this.tboxAdd.Location = new System.Drawing.Point(10, 10);
            this.tboxAdd.Name = "tboxAdd";
            this.tboxAdd.Size = new System.Drawing.Size(240, 21);
            this.tboxAdd.TabIndex = 0;
            this.tboxAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxAdd_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 400);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.Text = "Copy & Paste";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lboxTextSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblActivation;
        private System.Windows.Forms.CheckBox cboxActication;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar tBar;
        private System.Windows.Forms.Button btnBtextadd;
        private System.Windows.Forms.TextBox tboxAdd;
    }
}

