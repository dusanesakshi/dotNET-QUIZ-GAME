namespace dotNET_QUIZ_GAME
{
    partial class SimpleLevel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.qlblquest = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnD = new System.Windows.Forms.RadioButton();
            this.rBtnC = new System.Windows.Forms.RadioButton();
            this.rBtnB = new System.Windows.Forms.RadioButton();
            this.rBtnA = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblTorF = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(960, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 40);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lblSeconds);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.qlblquest);
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 329);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(907, 54);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(0, 26);
            this.lblSeconds.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(842, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Second(s) left";
            // 
            // qlblquest
            // 
            this.qlblquest.AutoSize = true;
            this.qlblquest.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlblquest.Location = new System.Drawing.Point(115, 151);
            this.qlblquest.Name = "qlblquest";
            this.qlblquest.Size = new System.Drawing.Size(0, 29);
            this.qlblquest.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnD);
            this.groupBox1.Controls.Add(this.rBtnC);
            this.groupBox1.Controls.Add(this.rBtnB);
            this.groupBox1.Controls.Add(this.rBtnA);
            this.groupBox1.Location = new System.Drawing.Point(12, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 221);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // rbtnD
            // 
            this.rbtnD.AutoSize = true;
            this.rbtnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnD.Location = new System.Drawing.Point(515, 139);
            this.rbtnD.Name = "rbtnD";
            this.rbtnD.Size = new System.Drawing.Size(17, 16);
            this.rbtnD.TabIndex = 4;
            this.rbtnD.TabStop = true;
            this.rbtnD.UseVisualStyleBackColor = true;
            this.rbtnD.CheckedChanged += new System.EventHandler(this.rbtnD_CheckedChanged);
            this.rbtnD.Click += new System.EventHandler(this.rbtnD_Click);
            // 
            // rBtnC
            // 
            this.rBtnC.AutoSize = true;
            this.rBtnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnC.Location = new System.Drawing.Point(108, 139);
            this.rBtnC.Name = "rBtnC";
            this.rBtnC.Size = new System.Drawing.Size(17, 16);
            this.rBtnC.TabIndex = 3;
            this.rBtnC.TabStop = true;
            this.rBtnC.UseVisualStyleBackColor = true;
            this.rBtnC.CheckedChanged += new System.EventHandler(this.rBtnC_CheckedChanged);
            this.rBtnC.Click += new System.EventHandler(this.rBtnC_Click);
            // 
            // rBtnB
            // 
            this.rBtnB.AutoSize = true;
            this.rBtnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnB.Location = new System.Drawing.Point(515, 45);
            this.rBtnB.Name = "rBtnB";
            this.rBtnB.Size = new System.Drawing.Size(17, 16);
            this.rBtnB.TabIndex = 2;
            this.rBtnB.TabStop = true;
            this.rBtnB.UseVisualStyleBackColor = true;
            this.rBtnB.CheckedChanged += new System.EventHandler(this.rBtnB_CheckedChanged);
            this.rBtnB.Click += new System.EventHandler(this.rBtnB_Click_1);
            // 
            // rBtnA
            // 
            this.rBtnA.AutoSize = true;
            this.rBtnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnA.Location = new System.Drawing.Point(108, 45);
            this.rBtnA.Name = "rBtnA";
            this.rBtnA.Size = new System.Drawing.Size(17, 16);
            this.rBtnA.TabIndex = 1;
            this.rBtnA.TabStop = true;
            this.rBtnA.UseVisualStyleBackColor = true;
            this.rBtnA.CheckedChanged += new System.EventHandler(this.rBtnA_CheckedChanged);
            this.rBtnA.Click += new System.EventHandler(this.rBtnA_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNext.Location = new System.Drawing.Point(424, 620);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(164, 50);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnNext_MouseClick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Location = new System.Drawing.Point(225, 620);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(164, 50);
            this.btnExit.TabIndex = 100;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(289, 630);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(0, 26);
            this.lblCorrect.TabIndex = 8;
            this.lblCorrect.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTorF
            // 
            this.lblTorF.AutoSize = true;
            this.lblTorF.Location = new System.Drawing.Point(522, 630);
            this.lblTorF.Name = "lblTorF";
            this.lblTorF.Size = new System.Drawing.Size(0, 26);
            this.lblTorF.TabIndex = 9;
            // 
            // SimpleLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.lblTorF);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SimpleLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleLevel";
            this.Load += new System.EventHandler(this.SimpleLevel_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label qlblquest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rBtnA;
        private System.Windows.Forms.RadioButton rbtnD;
        private System.Windows.Forms.RadioButton rBtnC;
        private System.Windows.Forms.RadioButton rBtnB;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblTorF;
    }
}