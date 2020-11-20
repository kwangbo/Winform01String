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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lboxTextSave = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblActivation = new System.Windows.Forms.Label();
            this.cboxActication = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tBar = new System.Windows.Forms.TrackBar();
            this.btnBtextadd = new System.Windows.Forms.Button();
            this.tboxAdd = new System.Windows.Forms.TextBox();
            this.msMenuStrip = new System.Windows.Forms.MenuStrip();
            this.파ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.공백제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모두제거ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmComtextMenuScrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.공백제거ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.클립보드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모두저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램정보ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.저장하기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.불러오기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBar)).BeginInit();
            this.msMenuStrip.SuspendLayout();
            this.cmComtextMenuScrip.SuspendLayout();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 376);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lboxTextSave
            // 
            this.lboxTextSave.ContextMenuStrip = this.cmComtextMenuScrip;
            this.lboxTextSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxTextSave.FormattingEnabled = true;
            this.lboxTextSave.ItemHeight = 12;
            this.lboxTextSave.Location = new System.Drawing.Point(3, 43);
            this.lboxTextSave.Name = "lboxTextSave";
            this.lboxTextSave.Size = new System.Drawing.Size(521, 273);
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
            this.panel2.Location = new System.Drawing.Point(3, 322);
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
            this.btnBtextadd.Location = new System.Drawing.Point(256, 16);
            this.btnBtextadd.Name = "btnBtextadd";
            this.btnBtextadd.Size = new System.Drawing.Size(127, 26);
            this.btnBtextadd.TabIndex = 1;
            this.btnBtextadd.Text = "등록";
            this.btnBtextadd.UseVisualStyleBackColor = true;
            this.btnBtextadd.Click += new System.EventHandler(this.btnBtextadd_Click);
            // 
            // tboxAdd
            // 
            this.tboxAdd.Location = new System.Drawing.Point(10, 16);
            this.tboxAdd.Name = "tboxAdd";
            this.tboxAdd.Size = new System.Drawing.Size(240, 21);
            this.tboxAdd.TabIndex = 0;
            this.tboxAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxAdd_KeyDown);
            // 
            // msMenuStrip
            // 
            this.msMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.프로그램정보ToolStripMenuItem});
            this.msMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.msMenuStrip.Name = "msMenuStrip";
            this.msMenuStrip.Size = new System.Drawing.Size(527, 24);
            this.msMenuStrip.TabIndex = 1;
            this.msMenuStrip.Text = "menuStrip1";
            // 
            // 파ToolStripMenuItem
            // 
            this.파ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장하기ToolStripMenuItem,
            this.불러오기ToolStripMenuItem});
            this.파ToolStripMenuItem.Name = "파ToolStripMenuItem";
            this.파ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파ToolStripMenuItem.Text = "파일";
            // 
            // 저장하기ToolStripMenuItem
            // 
            this.저장하기ToolStripMenuItem.Name = "저장하기ToolStripMenuItem";
            this.저장하기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.저장하기ToolStripMenuItem.Text = "저장하기";
            this.저장하기ToolStripMenuItem.Click += new System.EventHandler(this.저장하기ToolStripMenuItem_Click);
            // 
            // 불러오기ToolStripMenuItem
            // 
            this.불러오기ToolStripMenuItem.Name = "불러오기ToolStripMenuItem";
            this.불러오기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.불러오기ToolStripMenuItem.Text = "불러오기";
            this.불러오기ToolStripMenuItem.Click += new System.EventHandler(this.불러오기ToolStripMenuItem_Click);
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.공백제ToolStripMenuItem,
            this.모두제거ToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // 공백제ToolStripMenuItem
            // 
            this.공백제ToolStripMenuItem.Name = "공백제ToolStripMenuItem";
            this.공백제ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.공백제ToolStripMenuItem.Text = "공백제거";
            this.공백제ToolStripMenuItem.Click += new System.EventHandler(this.공백제ToolStripMenuItem_Click);
            // 
            // 모두제거ToolStripMenuItem
            // 
            this.모두제거ToolStripMenuItem.Name = "모두제거ToolStripMenuItem";
            this.모두제거ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.모두제거ToolStripMenuItem.Text = "모두제거";
            this.모두제거ToolStripMenuItem.Click += new System.EventHandler(this.모두제거ToolStripMenuItem_Click);
            // 
            // 프로그램정보ToolStripMenuItem
            // 
            this.프로그램정보ToolStripMenuItem.Name = "프로그램정보ToolStripMenuItem";
            this.프로그램정보ToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.프로그램정보ToolStripMenuItem.Text = "프로그램정보";
            this.프로그램정보ToolStripMenuItem.Click += new System.EventHandler(this.프로그램정보ToolStripMenuItem_Click);
            // 
            // cmComtextMenuScrip
            // 
            this.cmComtextMenuScrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.공백제거ToolStripMenuItem,
            this.클립보드ToolStripMenuItem,
            this.모두저장ToolStripMenuItem,
            this.프로그램정보ToolStripMenuItem1});
            this.cmComtextMenuScrip.Name = "cmComtextMenuScrip";
            this.cmComtextMenuScrip.Size = new System.Drawing.Size(181, 114);
            // 
            // 공백제거ToolStripMenuItem
            // 
            this.공백제거ToolStripMenuItem.Name = "공백제거ToolStripMenuItem";
            this.공백제거ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.공백제거ToolStripMenuItem.Text = "공백제거";
            this.공백제거ToolStripMenuItem.Click += new System.EventHandler(this.공백제거ToolStripMenuItem_Click);
            // 
            // 클립보드ToolStripMenuItem
            // 
            this.클립보드ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장하기ToolStripMenuItem1,
            this.불러오기ToolStripMenuItem1});
            this.클립보드ToolStripMenuItem.Name = "클립보드ToolStripMenuItem";
            this.클립보드ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.클립보드ToolStripMenuItem.Text = "클립보드";
            // 
            // 모두저장ToolStripMenuItem
            // 
            this.모두저장ToolStripMenuItem.Name = "모두저장ToolStripMenuItem";
            this.모두저장ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.모두저장ToolStripMenuItem.Text = "모두저장";
            this.모두저장ToolStripMenuItem.Click += new System.EventHandler(this.모두저장ToolStripMenuItem_Click);
            // 
            // 프로그램정보ToolStripMenuItem1
            // 
            this.프로그램정보ToolStripMenuItem1.Name = "프로그램정보ToolStripMenuItem1";
            this.프로그램정보ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.프로그램정보ToolStripMenuItem1.Text = "프로그램정보";
            this.프로그램정보ToolStripMenuItem1.Click += new System.EventHandler(this.프로그램정보ToolStripMenuItem1_Click);
            // 
            // 저장하기ToolStripMenuItem1
            // 
            this.저장하기ToolStripMenuItem1.Name = "저장하기ToolStripMenuItem1";
            this.저장하기ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.저장하기ToolStripMenuItem1.Text = "저장하기";
            this.저장하기ToolStripMenuItem1.Click += new System.EventHandler(this.저장하기ToolStripMenuItem1_Click);
            // 
            // 불러오기ToolStripMenuItem1
            // 
            this.불러오기ToolStripMenuItem1.Name = "불러오기ToolStripMenuItem1";
            this.불러오기ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.불러오기ToolStripMenuItem1.Text = "불러오기";
            this.불러오기ToolStripMenuItem1.Click += new System.EventHandler(this.불러오기ToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 400);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.msMenuStrip);
            this.MainMenuStrip = this.msMenuStrip;
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
            this.msMenuStrip.ResumeLayout(false);
            this.msMenuStrip.PerformLayout();
            this.cmComtextMenuScrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MenuStrip msMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 파ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 공백제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모두제거ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그램정보ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmComtextMenuScrip;
        private System.Windows.Forms.ToolStripMenuItem 공백제거ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 클립보드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장하기ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 불러오기ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 모두저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그램정보ToolStripMenuItem1;
    }
}

