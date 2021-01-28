using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace Youtube_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void YTDL ()
        {
            string all = "youtube-dl.exe" + textBox1.Text + maskedTextBox1.Text + " -o " + maskedTextBox2.Text + "%(title)s.%(ext)s" + textBox1.Text;
            var proc1 = new ProcessStartInfo();
            proc1.UseShellExecute = true;
            proc1.WorkingDirectory = @"C:\YT-DL\";
            proc1.FileName = @"C:\Windows\System32\cmd.exe";
            /// as admin = proc1.Verb = "runas";
            proc1.Arguments = "/c " + all;
            proc1.WindowStyle = ProcessWindowStyle.Minimized;
            Process.Start(proc1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YTDL();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
