using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PhotoOrg
{

    public partial class PhotoOrg : Form
    {

        public PhotoOrg()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

    private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int files = 0;

            foreach (string file in openFileDialog1.FileNames)
            {
                if (!Directory.Exists(order.Text + " - " + name.Text))
                    Directory.CreateDirectory(order.Text + " - " + name.Text);
                if (!File.Exists(order.Text + " - " + name.Text + "/" + order.Text + " - " + name.Text + " " + files + ".jpg"))
                    File.Copy(openFileDialog1.FileNames[files], order.Text + " - " + name.Text + "/" + order.Text + " - " + name.Text + " " + files + ".jpg");
                files++;
            }

            string[] info = { "Name: " + name.Text, "Phone: " + phone.Text, "Order #: " + order.Text, "E-Mail: " + email.Text, "Address: " + address.Text, "Prints: " + prints.Text };
            File.WriteAllLines(order.Text + " - " + name.Text + "/" + order.Text + " - " + name.Text + ".txt", info);

            MessageBox.Show("Done!");
        }

        private void logo_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }



        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int files = 0;
                 foreach (string file in openFileDialog1.FileNames)
                {
                    files++;
                }
                browse.Text = files + " file(s) loaded!";
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(100, 200);
            int R = rand.Next(100, 200);
            int G = rand.Next(100, 200);
            int B = rand.Next(100, 200);
            logo.ForeColor = Color.FromArgb(A, R, G, B);
            timer1.Start();
        }
    }
}
