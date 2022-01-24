using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Inregistrare : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public Inregistrare()
        {
            InitializeComponent();
        }

        private void Inregistrare_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Proteus\Proiect\18f4550\TransmisieUSB\apk\PIC USB C# (1)\PIC USB C#\VC#\WindowsFormsApplication1\BDUdatoare.mdf;Integrated Security=True");
            cn.Open();
        }

        private void btnAutentificare_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autentificare login = new Autentificare();
            login.ShowDialog();
        }

        private void btnInregistrare_Click(object sender, EventArgs e)
        {
            if (txtConfPass.Text != string.Empty || txtPass.Text != string.Empty || txtUN.Text != string.Empty)
            {
                if (txtPass.Text == txtConfPass.Text)
                {
                    cmd = new SqlCommand("select * from tblAutentificare where username='" + txtUN.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Acest nume utilizator exista deja ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into tblAutentificare values(@username,@parola)", cn);
                        cmd.Parameters.AddWithValue("username", txtUN.Text);
                        cmd.Parameters.AddWithValue("parola", txtPass.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Contul a fost creat! Autentificati-va!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Introduceti aceleeasi parola ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Introduceti valori", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
