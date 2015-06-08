namespace SeriealCommunication
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Serial = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.PortNum = new System.Windows.Forms.TextBox();
            this.Combutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Serialout = new System.Windows.Forms.ListBox();
            this.terminalsender = new System.Windows.Forms.TextBox();
            this.Outputset = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Serial
            // 
            this.Serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 20F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "포트번호";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PortNum
            // 
            this.PortNum.Font = new System.Drawing.Font("나눔고딕코딩", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PortNum.Location = new System.Drawing.Point(120, 30);
            this.PortNum.Name = "PortNum";
            this.PortNum.Size = new System.Drawing.Size(30, 22);
            this.PortNum.TabIndex = 1;
            this.PortNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Portnum_KeyDown);
            // 
            // Combutton
            // 
            this.Combutton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Combutton.Location = new System.Drawing.Point(172, 26);
            this.Combutton.Name = "Combutton";
            this.Combutton.Size = new System.Drawing.Size(147, 31);
            this.Combutton.TabIndex = 2;
            this.Combutton.Text = "통신　はじまるよ～！";
            this.Combutton.UseVisualStyleBackColor = true;
            this.Combutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(2, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "보내는 곳";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(2, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "받는 곳";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(394, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Made By Lee H.S-KudoLayton";
            // 
            // Serialout
            // 
            this.Serialout.FormattingEnabled = true;
            this.Serialout.ItemHeight = 12;
            this.Serialout.Location = new System.Drawing.Point(99, 151);
            this.Serialout.Name = "Serialout";
            this.Serialout.Size = new System.Drawing.Size(480, 304);
            this.Serialout.TabIndex = 8;
            // 
            // terminalsender
            // 
            this.terminalsender.Location = new System.Drawing.Point(99, 115);
            this.terminalsender.Name = "terminalsender";
            this.terminalsender.Size = new System.Drawing.Size(480, 21);
            this.terminalsender.TabIndex = 9;
            this.terminalsender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.terminalsender_KeyDown);
            // 
            // Outputset
            // 
            this.Outputset.FormattingEnabled = true;
            this.Outputset.Items.AddRange(new object[] {
            "ASCII",
            "HEX",
            "DEC"});
            this.Outputset.Location = new System.Drawing.Point(99, 70);
            this.Outputset.Name = "Outputset";
            this.Outputset.Size = new System.Drawing.Size(121, 20);
            this.Outputset.TabIndex = 10;
            this.Outputset.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔바른고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(2, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "출력형태";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 491);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Outputset);
            this.Controls.Add(this.terminalsender);
            this.Controls.Add(this.Serialout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Combutton);
            this.Controls.Add(this.PortNum);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Serieal Communication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort Serial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PortNum;
        private System.Windows.Forms.Button Combutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Serialout;
        private System.Windows.Forms.TextBox terminalsender;
        private System.Windows.Forms.ComboBox Outputset;
        private System.Windows.Forms.Label label5;
    }
}

