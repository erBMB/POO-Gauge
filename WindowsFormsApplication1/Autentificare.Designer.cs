
namespace WindowsFormsApplication1
{
    partial class Autentificare
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
            this.btnAutentificare = new System.Windows.Forms.Button();
            this.btnCreareCont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUN.Location = new System.Drawing.Point(40, 53);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(134, 24);
            this.lblUN.TabIndex = 0;
            this.lblUN.Text = "Nume utilizator";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(40, 93);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(68, 24);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Parola:";
            // 
            // txtUN
            // 
            this.txtUN.Location = new System.Drawing.Point(214, 56);
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(168, 22);
            this.txtUN.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(212, 99);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(169, 22);
            this.txtPass.TabIndex = 3;
            // 
            // btnAutentificare
            // 
            this.btnAutentificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutentificare.Location = new System.Drawing.Point(81, 172);
            this.btnAutentificare.Name = "btnAutentificare";
            this.btnAutentificare.Size = new System.Drawing.Size(230, 45);
            this.btnAutentificare.TabIndex = 4;
            this.btnAutentificare.Text = "Autentificare";
            this.btnAutentificare.UseVisualStyleBackColor = true;
            this.btnAutentificare.Click += new System.EventHandler(this.btnAutentificare_Click);
            // 
            // btnCreareCont
            // 
            this.btnCreareCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreareCont.Location = new System.Drawing.Point(79, 245);
            this.btnCreareCont.Name = "btnCreareCont";
            this.btnCreareCont.Size = new System.Drawing.Size(251, 43);
            this.btnCreareCont.TabIndex = 5;
            this.btnCreareCont.Text = "Creare cont";
            this.btnCreareCont.UseVisualStyleBackColor = true;
            this.btnCreareCont.Click += new System.EventHandler(this.btnCreareCont_Click);
            // 
            // Autentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 384);
            this.Controls.Add(this.btnCreareCont);
            this.Controls.Add(this.btnAutentificare);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUN);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUN);
            this.Name = "Autentificare";
            this.Text = "Autentificare";
            this.Load += new System.EventHandler(this.Autentificare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUN;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUN;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnAutentificare;
        private System.Windows.Forms.Button btnCreareCont;
    }
}