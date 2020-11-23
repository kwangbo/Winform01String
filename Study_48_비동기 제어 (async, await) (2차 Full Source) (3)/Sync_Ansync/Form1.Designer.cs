namespace Sync_Ansync
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
            this.pDoor2 = new System.Windows.Forms.Panel();
            this.pDoor1 = new System.Windows.Forms.Panel();
            this.pRobot = new System.Windows.Forms.Panel();
            this.lboxLog = new System.Windows.Forms.ListBox();
            this.btnRobotRotate = new System.Windows.Forms.Button();
            this.btnRobotR = new System.Windows.Forms.Button();
            this.btnRobotE = new System.Windows.Forms.Button();
            this.btnD1Open = new System.Windows.Forms.Button();
            this.btnD1Close = new System.Windows.Forms.Button();
            this.btnD2Close = new System.Windows.Forms.Button();
            this.btnD2Open = new System.Windows.Forms.Button();
            this.btnSimulation = new System.Windows.Forms.Button();
            this.btnSimulationAsync = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pDoor2
            // 
            this.pDoor2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pDoor2.Location = new System.Drawing.Point(255, 20);
            this.pDoor2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pDoor2.Name = "pDoor2";
            this.pDoor2.Size = new System.Drawing.Size(40, 200);
            this.pDoor2.TabIndex = 3;
            // 
            // pDoor1
            // 
            this.pDoor1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pDoor1.Location = new System.Drawing.Point(11, 20);
            this.pDoor1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pDoor1.Name = "pDoor1";
            this.pDoor1.Size = new System.Drawing.Size(40, 200);
            this.pDoor1.TabIndex = 2;
            // 
            // pRobot
            // 
            this.pRobot.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pRobot.Location = new System.Drawing.Point(53, 20);
            this.pRobot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pRobot.Name = "pRobot";
            this.pRobot.Size = new System.Drawing.Size(200, 200);
            this.pRobot.TabIndex = 1;
            // 
            // lboxLog
            // 
            this.lboxLog.FormattingEnabled = true;
            this.lboxLog.ItemHeight = 12;
            this.lboxLog.Location = new System.Drawing.Point(6, 19);
            this.lboxLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lboxLog.Name = "lboxLog";
            this.lboxLog.Size = new System.Drawing.Size(736, 292);
            this.lboxLog.TabIndex = 1;
            // 
            // btnRobotRotate
            // 
            this.btnRobotRotate.Location = new System.Drawing.Point(6, 185);
            this.btnRobotRotate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRobotRotate.Name = "btnRobotRotate";
            this.btnRobotRotate.Size = new System.Drawing.Size(248, 35);
            this.btnRobotRotate.TabIndex = 2;
            this.btnRobotRotate.Text = "Robot Rotate";
            this.btnRobotRotate.UseVisualStyleBackColor = true;
            this.btnRobotRotate.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRobotR
            // 
            this.btnRobotR.Location = new System.Drawing.Point(6, 147);
            this.btnRobotR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRobotR.Name = "btnRobotR";
            this.btnRobotR.Size = new System.Drawing.Size(248, 35);
            this.btnRobotR.TabIndex = 3;
            this.btnRobotR.Text = "Robot Arm Retract";
            this.btnRobotR.UseVisualStyleBackColor = true;
            this.btnRobotR.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRobotE
            // 
            this.btnRobotE.Location = new System.Drawing.Point(6, 109);
            this.btnRobotE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRobotE.Name = "btnRobotE";
            this.btnRobotE.Size = new System.Drawing.Size(248, 35);
            this.btnRobotE.TabIndex = 4;
            this.btnRobotE.Text = "Robot Arm Extend";
            this.btnRobotE.UseVisualStyleBackColor = true;
            this.btnRobotE.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnD1Open
            // 
            this.btnD1Open.Location = new System.Drawing.Point(6, 20);
            this.btnD1Open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnD1Open.Name = "btnD1Open";
            this.btnD1Open.Size = new System.Drawing.Size(121, 40);
            this.btnD1Open.TabIndex = 5;
            this.btnD1Open.Text = "Door1 Open";
            this.btnD1Open.UseVisualStyleBackColor = true;
            this.btnD1Open.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnD1Close
            // 
            this.btnD1Close.Location = new System.Drawing.Point(6, 64);
            this.btnD1Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnD1Close.Name = "btnD1Close";
            this.btnD1Close.Size = new System.Drawing.Size(121, 40);
            this.btnD1Close.TabIndex = 6;
            this.btnD1Close.Text = "Door1 Close";
            this.btnD1Close.UseVisualStyleBackColor = true;
            this.btnD1Close.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnD2Close
            // 
            this.btnD2Close.Location = new System.Drawing.Point(133, 64);
            this.btnD2Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnD2Close.Name = "btnD2Close";
            this.btnD2Close.Size = new System.Drawing.Size(121, 40);
            this.btnD2Close.TabIndex = 8;
            this.btnD2Close.Text = "Door2 Close";
            this.btnD2Close.UseVisualStyleBackColor = true;
            this.btnD2Close.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnD2Open
            // 
            this.btnD2Open.Location = new System.Drawing.Point(133, 20);
            this.btnD2Open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnD2Open.Name = "btnD2Open";
            this.btnD2Open.Size = new System.Drawing.Size(121, 40);
            this.btnD2Open.TabIndex = 7;
            this.btnD2Open.Text = "Door2 Open";
            this.btnD2Open.UseVisualStyleBackColor = true;
            this.btnD2Open.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSimulation
            // 
            this.btnSimulation.Location = new System.Drawing.Point(6, 96);
            this.btnSimulation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSimulation.Name = "btnSimulation";
            this.btnSimulation.Size = new System.Drawing.Size(156, 60);
            this.btnSimulation.TabIndex = 9;
            this.btnSimulation.Text = "동기 동작 진행";
            this.btnSimulation.UseVisualStyleBackColor = true;
            this.btnSimulation.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSimulationAsync
            // 
            this.btnSimulationAsync.Location = new System.Drawing.Point(6, 160);
            this.btnSimulationAsync.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSimulationAsync.Name = "btnSimulationAsync";
            this.btnSimulationAsync.Size = new System.Drawing.Size(156, 60);
            this.btnSimulationAsync.TabIndex = 9;
            this.btnSimulationAsync.Text = "비동기 동작 진행";
            this.btnSimulationAsync.UseVisualStyleBackColor = true;
            this.btnSimulationAsync.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(6, 20);
            this.btnInit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(156, 40);
            this.btnInit.TabIndex = 10;
            this.btnInit.Text = "초기 화면 표시";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pDoor2);
            this.groupBox1.Controls.Add(this.pDoor1);
            this.groupBox1.Controls.Add(this.pRobot);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 231);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnInit);
            this.groupBox2.Controls.Add(this.btnSimulation);
            this.groupBox2.Controls.Add(this.btnSimulationAsync);
            this.groupBox2.Location = new System.Drawing.Point(324, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 231);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "전체 동작";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "m/s";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 21);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "100";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "동작 Delay : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnD1Open);
            this.groupBox3.Controls.Add(this.btnD1Close);
            this.groupBox3.Controls.Add(this.btnD2Open);
            this.groupBox3.Controls.Add(this.btnRobotE);
            this.groupBox3.Controls.Add(this.btnRobotR);
            this.groupBox3.Controls.Add(this.btnD2Close);
            this.groupBox3.Controls.Add(this.btnRobotRotate);
            this.groupBox3.Location = new System.Drawing.Point(500, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 231);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "단위 동작";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lboxLog);
            this.groupBox4.Location = new System.Drawing.Point(12, 249);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(750, 326);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "log View";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(773, 584);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "자동화 Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lboxLog;
        private System.Windows.Forms.Button btnRobotRotate;
        private System.Windows.Forms.Panel pRobot;
        private System.Windows.Forms.Button btnRobotR;
        private System.Windows.Forms.Button btnRobotE;
        private System.Windows.Forms.Panel pDoor2;
        private System.Windows.Forms.Panel pDoor1;
        private System.Windows.Forms.Button btnD1Open;
        private System.Windows.Forms.Button btnD1Close;
        private System.Windows.Forms.Button btnD2Close;
        private System.Windows.Forms.Button btnD2Open;
        private System.Windows.Forms.Button btnSimulation;
        private System.Windows.Forms.Button btnSimulationAsync;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

