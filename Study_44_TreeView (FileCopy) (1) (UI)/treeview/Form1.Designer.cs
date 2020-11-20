namespace treeview
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
            this.tviewLocation = new System.Windows.Forms.TreeView();
            this.lboxCommand = new System.Windows.Forms.ListBox();
            this.tboxFile = new System.Windows.Forms.TextBox();
            this.btnExtend = new System.Windows.Forms.Button();
            this.btnCoolapse = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTreeLoad = new System.Windows.Forms.Button();
            this.tboxDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Command = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lboxLog = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tviewLocation
            // 
            this.tviewLocation.Location = new System.Drawing.Point(7, 45);
            this.tviewLocation.Name = "tviewLocation";
            this.tviewLocation.Size = new System.Drawing.Size(228, 219);
            this.tviewLocation.TabIndex = 0;
            this.tviewLocation.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tviewLocation_AfterSelect);
            this.tviewLocation.DoubleClick += new System.EventHandler(this.tviewLocation_DoubleClick);
            // 
            // lboxCommand
            // 
            this.lboxCommand.FormattingEnabled = true;
            this.lboxCommand.ItemHeight = 12;
            this.lboxCommand.Location = new System.Drawing.Point(252, 45);
            this.lboxCommand.Name = "lboxCommand";
            this.lboxCommand.Size = new System.Drawing.Size(302, 76);
            this.lboxCommand.TabIndex = 1;
            this.lboxCommand.Click += new System.EventHandler(this.lboxCommand_Click);
            this.lboxCommand.DoubleClick += new System.EventHandler(this.lboxCommand_DoubleClick);
            // 
            // tboxFile
            // 
            this.tboxFile.Location = new System.Drawing.Point(252, 145);
            this.tboxFile.Multiline = true;
            this.tboxFile.Name = "tboxFile";
            this.tboxFile.Size = new System.Drawing.Size(302, 119);
            this.tboxFile.TabIndex = 2;
            // 
            // btnExtend
            // 
            this.btnExtend.Location = new System.Drawing.Point(79, 17);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(75, 23);
            this.btnExtend.TabIndex = 3;
            this.btnExtend.Text = "Extend";
            this.btnExtend.UseVisualStyleBackColor = true;
            this.btnExtend.Click += new System.EventHandler(this.btnExtend_Click);
            // 
            // btnCoolapse
            // 
            this.btnCoolapse.Location = new System.Drawing.Point(160, 17);
            this.btnCoolapse.Name = "btnCoolapse";
            this.btnCoolapse.Size = new System.Drawing.Size(75, 23);
            this.btnCoolapse.TabIndex = 4;
            this.btnCoolapse.Text = "Collapse";
            this.btnCoolapse.UseVisualStyleBackColor = true;
            this.btnCoolapse.Click += new System.EventHandler(this.btnCoolapse_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(488, 337);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTreeLoad);
            this.groupBox1.Controls.Add(this.tboxDestination);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tboxSource);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 46);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // btnTreeLoad
            // 
            this.btnTreeLoad.Location = new System.Drawing.Point(238, 15);
            this.btnTreeLoad.Name = "btnTreeLoad";
            this.btnTreeLoad.Size = new System.Drawing.Size(24, 23);
            this.btnTreeLoad.TabIndex = 9;
            this.btnTreeLoad.Text = "T";
            this.btnTreeLoad.UseVisualStyleBackColor = true;
            this.btnTreeLoad.Click += new System.EventHandler(this.btnTreeLoad_Click);
            // 
            // tboxDestination
            // 
            this.tboxDestination.Location = new System.Drawing.Point(359, 16);
            this.tboxDestination.Name = "tboxDestination";
            this.tboxDestination.Size = new System.Drawing.Size(195, 21);
            this.tboxDestination.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination";
            // 
            // tboxSource
            // 
            this.tboxSource.Location = new System.Drawing.Point(63, 16);
            this.tboxSource.Name = "tboxSource";
            this.tboxSource.Size = new System.Drawing.Size(172, 21);
            this.tboxSource.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lboxCommand);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Command);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tviewLocation);
            this.groupBox2.Controls.Add(this.btnExtend);
            this.groupBox2.Controls.Add(this.btnCoolapse);
            this.groupBox2.Controls.Add(this.tboxFile);
            this.groupBox2.Location = new System.Drawing.Point(9, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 272);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "▼";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "▶";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "File";
            // 
            // Command
            // 
            this.Command.AutoSize = true;
            this.Command.Location = new System.Drawing.Point(252, 25);
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(64, 12);
            this.Command.TabIndex = 5;
            this.Command.Text = "Command";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "TreeNode";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lboxLog);
            this.groupBox3.Location = new System.Drawing.Point(9, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 90);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // lboxLog
            // 
            this.lboxLog.FormattingEnabled = true;
            this.lboxLog.ItemHeight = 12;
            this.lboxLog.Location = new System.Drawing.Point(7, 17);
            this.lboxLog.Name = "lboxLog";
            this.lboxLog.Size = new System.Drawing.Size(547, 64);
            this.lboxLog.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 456);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tviewLocation;
        private System.Windows.Forms.ListBox lboxCommand;
        private System.Windows.Forms.TextBox tboxFile;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.Button btnCoolapse;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tboxDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Command;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lboxLog;
        private System.Windows.Forms.Button btnTreeLoad;
    }
}

