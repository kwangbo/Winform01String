namespace Winform27LayOut2
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lboxLog = new System.Windows.Forms.ListBox();
            this.ucCMenu = new Winform27LayOut2.ucColorMenu();
            this.ucPanelTop = new Winform27LayOut2.ucPanel();
            this.ucPanelCenter1 = new Winform27LayOut2.ucPanel();
            this.ucPanelCenter2 = new Winform27LayOut2.ucPanel();
            this.ucPanelRight = new Winform27LayOut2.ucPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ucCMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.tableLayoutPanel1.Controls.Add(this.ucPanelTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucPanelCenter1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ucPanelCenter2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ucPanelRight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lboxLog, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(39, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.38866F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.61134F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(525, 355);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lboxLog
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.lboxLog, 2);
            this.lboxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxLog.FormattingEnabled = true;
            this.lboxLog.ItemHeight = 12;
            this.lboxLog.Location = new System.Drawing.Point(3, 277);
            this.lboxLog.Name = "lboxLog";
            this.lboxLog.Size = new System.Drawing.Size(519, 75);
            this.lboxLog.TabIndex = 4;
            // 
            // ucCMenu
            // 
            this.ucCMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCMenu.Location = new System.Drawing.Point(0, 0);
            this.ucCMenu.Name = "ucCMenu";
            this.ucCMenu.Size = new System.Drawing.Size(150, 450);
            this.ucCMenu.TabIndex = 0;
            // 
            // ucPanelTop
            // 
            this.ucPanelTop.BackColor = System.Drawing.Color.Transparent;
            this.ucPanelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.ucPanelTop, 2);
            this.ucPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanelTop.Location = new System.Drawing.Point(3, 3);
            this.ucPanelTop.Name = "ucPanelTop";
            this.ucPanelTop.Size = new System.Drawing.Size(519, 62);
            this.ucPanelTop.TabIndex = 0;
            // 
            // ucPanelCenter1
            // 
            this.ucPanelCenter1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanelCenter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucPanelCenter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanelCenter1.Location = new System.Drawing.Point(3, 71);
            this.ucPanelCenter1.Name = "ucPanelCenter1";
            this.ucPanelCenter1.Size = new System.Drawing.Size(300, 135);
            this.ucPanelCenter1.TabIndex = 1;
            // 
            // ucPanelCenter2
            // 
            this.ucPanelCenter2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanelCenter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucPanelCenter2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanelCenter2.Location = new System.Drawing.Point(3, 212);
            this.ucPanelCenter2.Name = "ucPanelCenter2";
            this.ucPanelCenter2.Size = new System.Drawing.Size(300, 59);
            this.ucPanelCenter2.TabIndex = 2;
            // 
            // ucPanelRight
            // 
            this.ucPanelRight.BackColor = System.Drawing.Color.Transparent;
            this.ucPanelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanelRight.Location = new System.Drawing.Point(309, 71);
            this.ucPanelRight.Name = "ucPanelRight";
            this.tableLayoutPanel1.SetRowSpan(this.ucPanelRight, 2);
            this.ucPanelRight.Size = new System.Drawing.Size(213, 200);
            this.ucPanelRight.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ucColorMenu ucCMenu;
        private Winform27LayOut2.ucPanel ucPanelTop;
        private Winform27LayOut2.ucPanel ucPanelCenter1;
        private Winform27LayOut2.ucPanel ucPanelCenter2;
        private Winform27LayOut2.ucPanel ucPanelRight;
        private System.Windows.Forms.ListBox lboxLog;
    }
}

