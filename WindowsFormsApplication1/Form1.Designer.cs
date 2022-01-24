namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.lblPrimire = new System.Windows.Forms.Label();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.DateTimeUpdate = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSetPresMax = new System.Windows.Forms.Label();
            this.txtSetPresMin = new System.Windows.Forms.TextBox();
            this.txtSetPresMax = new System.Windows.Forms.TextBox();
            this.btnPresMin = new System.Windows.Forms.Button();
            this.btnPresMax = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.chkADC = new System.Windows.Forms.CheckBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReceive = new System.Windows.Forms.Button();
            this.lblSetPresMin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrimire
            // 
            this.lblPrimire.AutoSize = true;
            this.lblPrimire.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimire.Location = new System.Drawing.Point(30, 208);
            this.lblPrimire.Name = "lblPrimire";
            this.lblPrimire.Size = new System.Drawing.Size(131, 25);
            this.lblPrimire.TabIndex = 1;
            this.lblPrimire.Text = "Stare sistem";
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateTime.ForeColor = System.Drawing.Color.Black;
            this.lbDateTime.Location = new System.Drawing.Point(60, 238);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(72, 18);
            this.lbDateTime.TabIndex = 6;
            this.lbDateTime.Text = "DateTime";
            // 
            // DateTimeUpdate
            // 
            this.DateTimeUpdate.Enabled = true;
            this.DateTimeUpdate.Interval = 1000;
            this.DateTimeUpdate.Tick += new System.EventHandler(this.DateTimeUpdate_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(248, 208);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSetPresMax
            // 
            this.lblSetPresMax.AutoSize = true;
            this.lblSetPresMax.Location = new System.Drawing.Point(30, 171);
            this.lblSetPresMax.Name = "lblSetPresMax";
            this.lblSetPresMax.Size = new System.Drawing.Size(119, 13);
            this.lblSetPresMax.TabIndex = 17;
            this.lblSetPresMax.Text = "Setare presiune maxima";
            // 
            // txtSetPresMin
            // 
            this.txtSetPresMin.Location = new System.Drawing.Point(185, 148);
            this.txtSetPresMin.Name = "txtSetPresMin";
            this.txtSetPresMin.Size = new System.Drawing.Size(134, 20);
            this.txtSetPresMin.TabIndex = 18;
            // 
            // txtSetPresMax
            // 
            this.txtSetPresMax.Location = new System.Drawing.Point(181, 175);
            this.txtSetPresMax.Name = "txtSetPresMax";
            this.txtSetPresMax.Size = new System.Drawing.Size(137, 20);
            this.txtSetPresMax.TabIndex = 19;
            // 
            // btnPresMin
            // 
            this.btnPresMin.Location = new System.Drawing.Point(332, 145);
            this.btnPresMin.Name = "btnPresMin";
            this.btnPresMin.Size = new System.Drawing.Size(80, 25);
            this.btnPresMin.TabIndex = 20;
            this.btnPresMin.Text = "Modifica presiunea minima";
            this.btnPresMin.UseVisualStyleBackColor = true;
            this.btnPresMin.Click += new System.EventHandler(this.btnPresMin_Click);
            // 
            // btnPresMax
            // 
            this.btnPresMax.Location = new System.Drawing.Point(332, 176);
            this.btnPresMax.Name = "btnPresMax";
            this.btnPresMax.Size = new System.Drawing.Size(78, 20);
            this.btnPresMax.TabIndex = 21;
            this.btnPresMax.Text = "Modifica presiunea maxima";
            this.btnPresMax.UseVisualStyleBackColor = true;
            this.btnPresMax.Click += new System.EventHandler(this.btnPresMax_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(24, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "LED1";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(23, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 20);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "LED2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkADC
            // 
            this.chkADC.AutoSize = true;
            this.chkADC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkADC.Location = new System.Drawing.Point(22, 72);
            this.chkADC.Name = "chkADC";
            this.chkADC.Size = new System.Drawing.Size(95, 20);
            this.chkADC.TabIndex = 5;
            this.chkADC.Text = "Read ADC ";
            this.chkADC.UseVisualStyleBackColor = true;
            this.chkADC.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(235, 12);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(177, 20);
            this.txtText.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Transmit Data";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(261, 42);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(121, 23);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(235, 71);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(177, 20);
            this.txtReceive.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Receive Data";
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(261, 97);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(121, 23);
            this.btnReceive.TabIndex = 14;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // lblSetPresMin
            // 
            this.lblSetPresMin.AutoSize = true;
            this.lblSetPresMin.Location = new System.Drawing.Point(32, 143);
            this.lblSetPresMin.Name = "lblSetPresMin";
            this.lblSetPresMin.Size = new System.Drawing.Size(116, 13);
            this.lblSetPresMin.TabIndex = 16;
            this.lblSetPresMin.Text = "Setare presiune minima";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 385);
            this.Controls.Add(this.btnPresMax);
            this.Controls.Add(this.btnPresMin);
            this.Controls.Add(this.txtSetPresMax);
            this.Controls.Add(this.txtSetPresMin);
            this.Controls.Add(this.lblSetPresMax);
            this.Controls.Add(this.lblSetPresMin);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lbDateTime);
            this.Controls.Add(this.chkADC);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblPrimire);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Udatoare - POO";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimire;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Timer DateTimeUpdate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSetPresMax;
        private System.Windows.Forms.TextBox txtSetPresMin;
        private System.Windows.Forms.TextBox txtSetPresMax;
        private System.Windows.Forms.Button btnPresMin;
        private System.Windows.Forms.Button btnPresMax;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox chkADC;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Label lblSetPresMin;
    }
}

