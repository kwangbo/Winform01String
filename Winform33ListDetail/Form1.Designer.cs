namespace Winform33ListDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxData = new System.Windows.Forms.TextBox();
            this.numPosition = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxChangeOld = new System.Windows.Forms.TextBox();
            this.tboxChangeNew = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lboxNo = new System.Windows.Forms.ListBox();
            this.lboxChangeList = new System.Windows.Forms.ListBox();
            this.appStylistRuntime1 = new Infragistics.Win.AppStyling.Runtime.AppStylistRuntime(this.components);
            this.lboxList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxList = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxChangeList = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Position";
            // 
            // tboxData
            // 
            this.tboxData.Location = new System.Drawing.Point(91, 19);
            this.tboxData.Name = "tboxData";
            this.tboxData.Size = new System.Drawing.Size(100, 21);
            this.tboxData.TabIndex = 2;
            this.tboxData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxData_KeyDown);
            // 
            // numPosition
            // 
            this.numPosition.Location = new System.Drawing.Point(91, 69);
            this.numPosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numPosition.Name = "numPosition";
            this.numPosition.Size = new System.Drawing.Size(100, 21);
            this.numPosition.TabIndex = 3;
            this.numPosition.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 113);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(116, 113);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "삭제";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(273, 113);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(100, 23);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "변경";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "검색";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "수정";
            // 
            // tboxChangeOld
            // 
            this.tboxChangeOld.Location = new System.Drawing.Point(273, 19);
            this.tboxChangeOld.Name = "tboxChangeOld";
            this.tboxChangeOld.Size = new System.Drawing.Size(100, 21);
            this.tboxChangeOld.TabIndex = 9;
            // 
            // tboxChangeNew
            // 
            this.tboxChangeNew.Location = new System.Drawing.Point(273, 71);
            this.tboxChangeNew.Name = "tboxChangeNew";
            this.tboxChangeNew.Size = new System.Drawing.Size(100, 21);
            this.tboxChangeNew.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "List";
            // 
            // lboxNo
            // 
            this.lboxNo.FormattingEnabled = true;
            this.lboxNo.ItemHeight = 12;
            this.lboxNo.Location = new System.Drawing.Point(27, 202);
            this.lboxNo.Name = "lboxNo";
            this.lboxNo.Size = new System.Drawing.Size(47, 304);
            this.lboxNo.TabIndex = 12;
            // 
            // lboxChangeList
            // 
            this.lboxChangeList.FormattingEnabled = true;
            this.lboxChangeList.ItemHeight = 12;
            this.lboxChangeList.Location = new System.Drawing.Point(253, 202);
            this.lboxChangeList.Name = "lboxChangeList";
            this.lboxChangeList.Size = new System.Drawing.Size(120, 304);
            this.lboxChangeList.TabIndex = 13;
            // 
            // lboxList
            // 
            this.lboxList.FormattingEnabled = true;
            this.lboxList.ItemHeight = 12;
            this.lboxList.Location = new System.Drawing.Point(80, 202);
            this.lboxList.Name = "lboxList";
            this.lboxList.Size = new System.Drawing.Size(111, 304);
            this.lboxList.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(396, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 484);
            this.panel1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "List Deail";
            // 
            // tboxList
            // 
            this.tboxList.Enabled = false;
            this.tboxList.Location = new System.Drawing.Point(424, 113);
            this.tboxList.Multiline = true;
            this.tboxList.Name = "tboxList";
            this.tboxList.Size = new System.Drawing.Size(265, 150);
            this.tboxList.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "Change List Detail";
            // 
            // tboxChangeList
            // 
            this.tboxChangeList.Enabled = false;
            this.tboxChangeList.Location = new System.Drawing.Point(424, 331);
            this.tboxChangeList.Multiline = true;
            this.tboxChangeList.Name = "tboxChangeList";
            this.tboxChangeList.Size = new System.Drawing.Size(265, 175);
            this.tboxChangeList.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 555);
            this.Controls.Add(this.tboxChangeList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tboxList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lboxList);
            this.Controls.Add(this.lboxChangeList);
            this.Controls.Add(this.lboxNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tboxChangeNew);
            this.Controls.Add(this.tboxChangeOld);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numPosition);
            this.Controls.Add(this.tboxData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxData;
        private System.Windows.Forms.NumericUpDown numPosition;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxChangeOld;
        private System.Windows.Forms.TextBox tboxChangeNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lboxNo;
        private System.Windows.Forms.ListBox lboxChangeList;
        private Infragistics.Win.AppStyling.Runtime.AppStylistRuntime appStylistRuntime1;
        private System.Windows.Forms.ListBox lboxList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxChangeList;
    }
}

