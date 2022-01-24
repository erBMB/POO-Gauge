
namespace WindowsFormsApplication1
{
    partial class Inregistrare
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
            this.lblUN = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUN = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.btnAutentificare = new System.Windows.Forms.Button();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.txtConfPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUN.Location = new System.Drawing.Point(25, 61);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(84, 24);
            this.lblUN.TabIndex = 0;
            this.lblUN.Text = "Utilizator:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(29, 99);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(68, 24);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Parola:";
            // 
            // txtUN
            // 
            this.txtUN.Location = new System.Drawing.Point(249, 61);
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(136, 22);
            this.txtUN.TabIndex = 2;
            this.txtUN.TextChanged += new System.EventHandler(this.txtUN_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(249, 99);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(135, 22);
            this.txtPass.TabIndex = 3;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // btnInregistrare
            // 
            this.btnInregistrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInregistrare.Location = new System.Drawing.Point(91, 191);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(217, 51);
            this.btnInregistrare.TabIndex = 4;
            this.btnInregistrare.Text = "Inregistrare";
            this.btnInregistrare.UseVisualStyleBackColor = true;
            this.btnInregistrare.Click += new System.EventHandler(this.btnInregistrare_Click);
            // 
            // btnAutentificare
            // 
            this.btnAutentificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutentificare.Location = new System.Drawing.Point(91, 261);
            this.btnAutentificare.Name = "btnAutentificare";
            this.btnAutentificare.Size = new System.Drawing.Size(217, 49);
            this.btnAutentificare.TabIndex = 5;
            this.btnAutentificare.Text = "Autentificare";
            this.btnAutentificare.UseVisualStyleBackColor = true;
            this.btnAutentificare.Click += new System.EventHandler(this.btnAutentificare_Click);
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPass.Location = new System.Drawing.Point(30, 135);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(159, 24);
            this.lblConfirmPass.TabIndex = 6;
            this.lblConfirmPass.Text = "Confirmare parola";
            // 
            // txtConfPass
            // 
            this.txtConfPass.Location = new System.Drawing.Point(249, 135);
            this.txtConfPass.Name = "txtConfPass";
            this.txtConfPass.Size = new System.Drawing.Size(135, 22);
            this.txtConfPass.TabIndex = 7;
            this.txtConfPass.TextChanged += new System.EventHandler(this.txtConfPass_TextChanged);
            // 
            // Inregistrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 365);
            this.Controls.Add(this.txtConfPass);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.btnAutentificare);
            this.Controls.Add(this.btnInregistrare);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUN);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUN);
            this.Name = "Inregistrare";
            this.Text = "Inregistrare";
            this.Load += new System.EventHandler(this.Inregistrare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUN;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUN;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnInregistrare;
        private System.Windows.Forms.Button btnAutentificare;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.TextBox txtConfPass;
    }
}