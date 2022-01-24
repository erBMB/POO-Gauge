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
    public partial class Autentificare : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public Autentificare()
        {
            InitializeComponent();
        }

        private void Autentificare_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Proteus\Proiect\18f4550\TransmisieUSB\apk\PIC USB C# (1)\PIC USB C#\VC#\WindowsFormsApplication1\BDUdatoare.mdf;Integrated Security=True");
            cn.Open();
        }

        private void btnCreareCont_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inregistrare registration = new Inregistrare();
            registration.ShowDialog();
        }

        private void btnAutentificare_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != string.Empty || txtUN.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from tblAutentificare where username='" + txtUN.Text + "' and parola='" + txtPass.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Form1 home = new Form1();
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Nici un cont nu este asociat valorilor introduse ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Introduceti valori.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
