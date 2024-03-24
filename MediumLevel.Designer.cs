namespace dotNET_QUIZ_GAME
{
    partial class MediumLevel
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
            this.pnl1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSeconds2 = new System.Windows.Forms.Label();
            this.lblsecondm = new System.Windows.Forms.Label();
            this.qlblquestM = new System.Windows.Forms.Label();
            this.btnExit1 = new System.Windows.Forms.Button();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnD1 = new System.Windows.Forms.RadioButton();
            this.rBtnC1 = new System.Windows.Forms.RadioButton();
            this.rBtnB1 = new System.Windows.Forms.RadioButton();
            this.rBtnA1 = new System.Windows.Forms.RadioButton();
            this.timerm = new System.Windows.Forms.Timer(this.components);
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.Color.Silver;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(963, 40);
            this.pnl1.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(963, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // pnl2
            // 
            this.pnl2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl2.Controls.Add(this.pictureBox1);
            this.pnl2.Controls.Add(this.lblSeconds2);
            this.pnl2.Controls.Add(this.lblsecondm);
            this.pnl2.Controls.Add(this.qlblquestM);
            this.pnl2.Location = new System.Drawing.Point(0, 40);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(1000, 329);
            this.pnl2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(48, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblSeconds2
            // 
            this.lblSeconds2.AutoSize = true;
            this.lblSeconds2.Location = new System.Drawing.Point(907, 54);
            this.lblSeconds2.Name = "lblSeconds2";
            this.lblSeconds2.Size = new System.Drawing.Size(0, 26);
            this.lblSeconds2.TabIndex = 2;
            // 
            // lblsecondm
            // 
            this.lblsecondm.AutoSize = true;
            this.lblsecondm.Location = new System.Drawing.Point(842, 80);
            this.lblsecondm.Name = "lblsecondm";
            this.lblsecondm.Size = new System.Drawing.Size(146, 26);
            this.lblsecondm.TabIndex = 1;
            this.lblsecondm.Text = "Second(s) left";
            // 
            // qlblquestM
            // 
            this.qlblquestM.AutoSize = true;
            this.qlblquestM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlblquestM.Location = new System.Drawing.Point(340, 154);
            this.qlblquestM.Name = "qlblquestM";
            this.qlblquestM.Size = new System.Drawing.Size(0, 29);
            this.qlblquestM.TabIndex = 0;
            // 
            // btnExit1
            // 
            this.btnExit1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit1.Location = new System.Drawing.Point(225, 620);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Size = new System.Drawing.Size(164, 50);
            this.btnExit1.TabIndex = 105;
            this.btnExit1.Text = "Exit";
            this.btnExit1.UseVisualStyleBackColor = false;
            this.btnExit1.Click += new System.EventHandler(this.btnExit1_Click);
            // 
            // btnNext1
            // 
            this.btnNext1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNext1.Location = new System.Drawing.Point(424, 620);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(164, 50);
            this.btnNext1.TabIndex = 101;
            this.btnNext1.Text = "Next";
            this.btnNext1.UseVisualStyleBackColor = false;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnD1);
            this.groupBox1.Controls.Add(this.rBtnC1);
            this.groupBox1.Controls.Add(this.rBtnB1);
            this.groupBox1.Controls.Add(this.rBtnA1);
            this.groupBox1.Location = new System.Drawing.Point(12, 391);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 221);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            // 
            // rbtnD1
            // 
            this.rbtnD1.AutoSize = true;
            this.rbtnD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnD1.Location = new System.Drawing.Point(515, 139);
            this.rbtnD1.Name = "rbtnD1";
            this.rbtnD1.Size = new System.Drawing.Size(17, 16);
            this.rbtnD1.TabIndex = 4;
            this.rbtnD1.TabStop = true;
            this.rbtnD1.UseVisualStyleBackColor = true;
            this.rbtnD1.Click += new System.EventHandler(this.rbtnD1_Click);
            // 
            // rBtnC1
            // 
            this.rBtnC1.AutoSize = true;
            this.rBtnC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnC1.Location = new System.Drawing.Point(108, 139);
            this.rBtnC1.Name = "rBtnC1";
            this.rBtnC1.Size = new System.Drawing.Size(17, 16);
            this.rBtnC1.TabIndex = 3;
            this.rBtnC1.TabStop = true;
            this.rBtnC1.UseVisualStyleBackColor = true;
            this.rBtnC1.Click += new System.EventHandler(this.rBtnC1_Click);
            // 
            // rBtnB1
            // 
            this.rBtnB1.AutoSize = true;
            this.rBtnB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnB1.Location = new System.Drawing.Point(515, 45);
            this.rBtnB1.Name = "rBtnB1";
            this.rBtnB1.Size = new System.Drawing.Size(17, 16);
            this.rBtnB1.TabIndex = 2;
            this.rBtnB1.TabStop = true;
            this.rBtnB1.UseVisualStyleBackColor = true;
            this.rBtnB1.Click += new System.EventHandler(this.rBtnB1_Click);
            // 
            // rBtnA1
            // 
            this.rBtnA1.AutoSize = true;
            this.rBtnA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnA1.Location = new System.Drawing.Point(108, 45);
            this.rBtnA1.Name = "rBtnA1";
            this.rBtnA1.Size = new System.Drawing.Size(17, 16);
            this.rBtnA1.TabIndex = 1;
            this.rBtnA1.TabStop = true;
            this.rBtnA1.UseVisualStyleBackColor = true;
            this.rBtnA1.CheckedChanged += new System.EventHandler(this.rBtnA1_CheckedChanged);
            this.rBtnA1.Click += new System.EventHandler(this.rBtnA1_Click);
            // 
            // timerm
            // 
            this.timerm.Enabled = true;
            this.timerm.Interval = 1000;
            this.timerm.Tick += new System.EventHandler(this.timerm_Tick);
            // 
            // MediumLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 680);
            this.Controls.Add(this.btnExit1);
            this.Controls.Add(this.btnNext1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MediumLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediumLevel";
            this.Load += new System.EventHandler(this.MediumLevel_Load);
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Label lblSeconds2;
        private System.Windows.Forms.Label lblsecondm;
        private System.Windows.Forms.Label qlblquestM;
        private System.Windows.Forms.Button btnExit1;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnD1;
        private System.Windows.Forms.RadioButton rBtnC1;
        private System.Windows.Forms.RadioButton rBtnB1;
        private System.Windows.Forms.RadioButton rBtnA1;
        private System.Windows.Forms.Timer timerm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}