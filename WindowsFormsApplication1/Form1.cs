using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIDLib;
namespace WindowsFormsApplication1
{    public partial class Form1 : Form
    {   HIDDevice dev = new HIDDevice();
        
        public Form1()
        {   
            InitializeComponent();

            dev.vid = 0x2DBC;
            dev.pid = 0x0001;

            dev.in_size = 64;
            dev.out_size = 64;
            dev.Initialize(); 
        }
        private void DateTimeUpdate_Tick(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy  hh:mm:ss");
        }
    /// <summary>
    /// Phan code sau day co muc dich la nhap gia tri PID va VID tu dong
    /// nham de nhan biet thiet bi USB mot cach linh hoat. Ngoai ra cung de tim hieu cach 
    /// truyen gia tri tu mot o Textbox. Nhung van chua lam duoc --- dtn89
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

       //Phan them vao --- Ham chuyen tu kieu "string" sang "byte" va nguoc lai 
       static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            int iLength = str.Length;
            //string strNull = null;
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            //System.Buffer.BlockCopy(strNull.ToCharArray(), 64-str.Length, bytes, 64-str.Length, 64);
            //System.Buffer.BlockCopy( null, 64 - str.Length, bytes, 64 - str.Length, 64);
            return bytes;
        }

        static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
       //Ket thuc phan ham them vao ---dtn89
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            byte[] data = new byte [64];
            if (checkBox1.Checked) 
                data[0]=1;
            else data[0] = 0;
            if (!dev.Transmit(data)) MessageBox.Show("Device not ready");
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            byte[] data = new byte [64];
            if (checkBox2.Checked) data[1] = 1;
            else data[1] = 0;
            if (!dev.Transmit(data)) MessageBox.Show("Thiet bi chua san sang", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            byte[] data = new byte [64];
            if (chkADC.Checked) data[2] = 1; else data[2] = 0;
            if (!dev.Transmit(data)) MessageBox.Show("Thiet bi chua san sang", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            string stContent = txtText.Text;
            byte[] data = new byte [stContent.Length];    
            data = System.Text.Encoding.ASCII.GetBytes(stContent);
            dev.Transmit(data);
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            int i=0, j=0, k=0;
            byte[] data = new byte [64];
            byte[] str = new byte [64];
            data = dev.Receive();
            if (data != null)
            {
                txtReceive.Text = System.Text.Encoding.ASCII.GetString(data);
            }
            
        }        
        protected override void WndProc(ref Message m)
           {
               dev.DeviceChange(ref m);
               base.WndProc(ref m);
               if (!dev.AttachedState) { lblPrimire.Text = "Disconnected!"; lblPrimire.ForeColor = Color.Red; }
               else { lblPrimire.Text = "Connected!"; lblPrimire.ForeColor = Color.Green; }
           }

        private void timer1_Tick(object sender, EventArgs e)
        {
            byte[] data = new byte[64];
            byte[] str = new byte[64];
            data = dev.Receive();
            if (data != null)
            {
                lblDate.Text = data[6].ToString();
            }
        }

        private void btnPresMin_Click(object sender, EventArgs e)
        {
            int valCaseta1 = int.Parse(txtSetPresMin.Text.ToString());
            byte valCaseta = Convert.ToByte(valCaseta1);
            byte[] data = new byte[64];
            data[5] = valCaseta;
            if (!dev.Transmit(data)) MessageBox.Show("Device not ready");
        }

        private void btnPresMax_Click(object sender, EventArgs e)
        {
            int valCaseta1 = int.Parse(txtSetPresMax.Text.ToString());
            byte valCaseta = Convert.ToByte(valCaseta1);
            byte[] data = new byte[64];
            data[6] = valCaseta;
            if (!dev.Transmit(data)) MessageBox.Show("Device not ready");
        }
    }
}
