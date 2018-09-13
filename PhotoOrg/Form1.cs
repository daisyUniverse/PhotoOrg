using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text.RegularExpressions;



namespace PhotoOrg
{


    public partial class PhotoOrg : Form
    {
        public PhotoOrg()
        {

            InitializeComponent();

            // Check for the jobs file, if it's there, add all the recorded jobs to the tracker.

            int count = 0;
            if (File.Exists("jobs.txt"))
            {
                string[] log = File.ReadAllLines("jobs.txt");
                foreach (string file in log)
                {
                    checkedListBox1.Items.Add(log[count]);
                    count++;
                }
            }

            // Themes. Because that's what this needed. This checks for a settings file, and checks what the current theme set is,
            // and reads the specified filename for color data. I spent an hour on this. Why.

            if (File.Exists("settings/settings.cfg"))
            {

                string[] settingsFile = File.ReadAllLines("settings/settings.cfg");
                string theme = settingsFile[3];
                string themepath = "settings/" + theme + ".ini";

                if (File.Exists(themepath))
                {
                    string[] settings = File.ReadAllLines(themepath);
                    logo.Text = settingsFile[1];

                    Color logoCol = Color.FromArgb(Convert.ToInt32(settings[2]), Convert.ToInt32(settings[3]), Convert.ToInt32(settings[4]));
                    Color bgCol = Color.FromArgb(Convert.ToInt32(settings[6]), Convert.ToInt32(settings[7]), Convert.ToInt32(settings[8]));
                    Color boxTextCol = Color.FromArgb(Convert.ToInt32(settings[10]), Convert.ToInt32(settings[11]), Convert.ToInt32(settings[12]));
                    Color boxCol = Color.FromArgb(Convert.ToInt32(settings[14]), Convert.ToInt32(settings[15]), Convert.ToInt32(settings[16]));

                    logo.ForeColor = logoCol;

                    this.BackColor = bgCol;

                    if (settings[18] != "none")
                    {
                        Image BG = new Bitmap(@"settings/img/" + settings[18] + ".jpg");
                        this.BackgroundImage = BG;
                    }

                    name.ForeColor = boxTextCol;
                    phone.ForeColor = boxTextCol;
                    order.ForeColor = boxTextCol;
                    address.ForeColor = boxTextCol;
                    email.ForeColor = boxTextCol;
                    browse.ForeColor = boxTextCol;
                    mail.ForeColor = boxTextCol;
                    save.ForeColor = boxTextCol;
                    checkedListBox1.ForeColor = boxTextCol;

                    name.BackColor = boxCol;
                    phone.BackColor = boxCol;
                    order.BackColor = boxCol;
                    address.BackColor = boxCol;
                    email.BackColor = boxCol;
                    browse.BackColor = boxCol;
                    mail.BackColor = boxCol;
                    save.BackColor = boxCol;
                    checkedListBox1.BackColor = boxCol;
                    
                }
            }
        }

        // Magic 'grab the window anywhere to drag' code I nabbed. Don't know how it works, but it does. 

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        // Pressing the 'Save' button

        private void button2_Click(object sender, EventArgs e)
        {
            int files = 0;
            string savedir = "";

            // Looking to see if an alternate save directory was chosen

            if (File.Exists("settings/settings.cfg") && File.ReadAllLines("settings/settings.cfg")[5] != "default") {
                string[] SettingsFile = File.ReadAllLines("settings/settings.cfg");
                savedir = @SettingsFile[5];
                savedir = savedir + @"\";
            }

            // Check to see if the Job # + Name matches any existing folder. If it doesn't proceed to copy
            // and rename based on user input

            foreach (string file in openFileDialog1.FileNames)
            {
                if (!Directory.Exists(savedir + order.Text + " - " + name.Text))
                    Directory.CreateDirectory(savedir + order.Text + " - " + name.Text);
                    int filesexist = Directory.GetFiles(savedir + order.Text + " - " + name.Text).Length;

                if (!File.Exists(savedir + order.Text + " - " + name.Text + "/" + order.Text + " - " + name.Text + " - " + (filesexist + 1) + ".jpg"))
                    File.Copy(openFileDialog1.FileNames[files], savedir + order.Text + " - " + name.Text + "/" + name.Text + " - " + (filesexist + 1) + ".jpg");
                files++;
            }

            // The retarded amount of effort involved in saving all of that info to a text file / adding it to the job tracker

            string job = order.Text + " - " + name.Text;
            List<string> jobs = new List<string>();

            if (!checkedListBox1.Items.Contains(job))
            {
                jobs.Add(job);
                string[] info = { name.Text, phone.Text, order.Text, email.Text, address.Text };
                File.WriteAllLines(savedir + order.Text + " - " + name.Text + "/" + "Order info for " + " " + name.Text + ".txt", info);
                jobs.ToArray();
                checkedListBox1.Items.Add(job);
                File.AppendAllLines("jobs.txt", jobs);
            }
            // Copying finished, show confirmation, and reset all parameters to get ready for the next job

            MessageBox.Show("Done!");
            openFileDialog1.Reset();
            openFileDialog1.Multiselect = true;
            browse.Text = "browse";
            name.Text = "name";
            address.Text = "address";
            email.Text = "email";
            phone.Text = "phone";

            if (Regex.IsMatch(order.Text, @"^\d+$"))
            {

                int orderNum = int.Parse(order.Text);
                orderNum++;
                order.Text = orderNum.ToString();
            }
            else { order.Text = "order number"; }
            save.Enabled = false;
        }

        // Apply theme settings when you click the logo. Because I was too dumb to figure out a real way.

        private void logo_Click(object sender, EventArgs e)
        {
            if (File.Exists("settings/settings.cfg"))
            {

                string[] settingsFile = File.ReadAllLines("settings/settings.cfg");
                string theme = settingsFile[3];
                string themepath = "settings/" + theme + ".ini";

                if (File.Exists(themepath))
                {
                    string[] settings = File.ReadAllLines(themepath);
                    logo.Text = settingsFile[1];

                    Color logoCol = Color.FromArgb(Convert.ToInt32(settings[2]), Convert.ToInt32(settings[3]), Convert.ToInt32(settings[4]));
                    Color bgCol = Color.FromArgb(Convert.ToInt32(settings[6]), Convert.ToInt32(settings[7]), Convert.ToInt32(settings[8]));
                    Color boxTextCol = Color.FromArgb(Convert.ToInt32(settings[10]), Convert.ToInt32(settings[11]), Convert.ToInt32(settings[12]));
                    Color boxCol = Color.FromArgb(Convert.ToInt32(settings[14]), Convert.ToInt32(settings[15]), Convert.ToInt32(settings[16]));

                    logo.ForeColor = logoCol;

                    this.BackColor = bgCol;

                    if (settings[18] != "none")
                    {
                        Image BG = new Bitmap(@"settings/img/" + settings[18] + ".jpg");
                        this.BackgroundImage = BG;
                    }
                    else {
                        this.BackgroundImage = null;
                    }

                    name.ForeColor = boxTextCol;
                    phone.ForeColor = boxTextCol;
                    order.ForeColor = boxTextCol;
                    address.ForeColor = boxTextCol;
                    email.ForeColor = boxTextCol;
                    browse.ForeColor = boxTextCol;
                    mail.ForeColor = boxTextCol;
                    save.ForeColor = boxTextCol;
                    checkedListBox1.ForeColor = boxTextCol;

                    name.BackColor = boxCol;
                    phone.BackColor = boxCol;
                    order.BackColor = boxCol;
                    address.BackColor = boxCol;
                    email.BackColor = boxCol;
                    browse.BackColor = boxCol;
                    mail.BackColor = boxCol;
                    save.BackColor = boxCol;
                    checkedListBox1.BackColor = boxCol;
                }
            }
        }

        // Stuff to show the 'X Files Loaded!' message based on how many files are loaded

        private void browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int files = 0;
                foreach (string file in openFileDialog1.FileNames) { files++; }
                if (files == 1) { browse.Text = files + " file loaded!"; }
                else { browse.Text = files + " files loaded!"; }
                save.Enabled = true;
            }
        }

        // I'll make my own exit button, with blackjack, and overused jokes

        private void exit_Click(object sender, EventArgs e) { System.Windows.Forms.Application.Exit(); }

        // Gay Code Jail

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        // For showing / hiding the job list

        private void mail_CheckedChanged(object sender, EventArgs e)
        {
            if (mail.Checked) { PhotoOrg.ActiveForm.Width = 930; } else { PhotoOrg.ActiveForm.Width = 472; }

        }

        // oopsie whoopsie looks like you cant remove these

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void openFileDialog1_FileOk(object sender, EventArgs e) { }

        private void settingsOpen_Click(object sender, EventArgs e)
        {
            if (File.Exists("settings/settings.cfg"))
            {
                settings settings = new settings();
                settings.Show();
            }
            else
            {
                MessageBox.Show("Settings file missing!");
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void PhotoOrg_Load(object sender, EventArgs e)
        {

        }

        // Reset all parameters to the info for a previous job if clicked on in the list

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string savedir = "";

            if (File.Exists("settings/settings.cfg") && File.ReadAllLines("settings/settings.cfg")[5] != "default")
            {
                string[] SettingsFile = File.ReadAllLines("settings/settings.cfg");
                savedir = @SettingsFile[5];
                savedir = savedir + @"\";
                string Select = (sender as CheckedListBox).SelectedItem.ToString();
                string cwd = savedir + Select;
                MessageBox.Show(cwd);
                Process.Start("explorer.exe", cwd);
            }
           else
            {
                string Select = (sender as CheckedListBox).SelectedItem.ToString();
                string[] chop = Select.Split('-');
                string dice = chop[chop.Length - 1];
                string Fname = dice.Remove(0, 1);

                string cwinfo = Directory.GetCurrentDirectory() + @"\" + Select + @"\Order info for  " + Fname + ".txt";
                if (File.Exists(cwinfo))
                {
                    string[] info = File.ReadAllLines(cwinfo);

                    openFileDialog1.Reset();
                    openFileDialog1.Multiselect = true;
                    name.Text = info[0];
                    address.Text = info[4];
                    email.Text = info[3];
                    order.Text = info[2];
                    phone.Text = info[1];
                }
                else {
                    MessageBox.Show(cwinfo + Fname);
                }
            }
        }

        // Open up the folder for the job you have clicked

        private void AddFiles_Click(object sender, EventArgs e)
        {
            string savedir = "";

            if (File.Exists("settings/settings.cfg") && File.ReadAllLines("settings/settings.cfg")[5] != "default")
            {
                // Handle some custom save directory stuff for opening jobs

                string[] SettingsFile = File.ReadAllLines("settings/settings.cfg");
                savedir = @SettingsFile[5];
                savedir = savedir + @"\";
                string Select = (sender as CheckedListBox).SelectedItem.ToString();
                string cwd = savedir + Select;
                MessageBox.Show(cwd);
                Process.Start("explorer.exe", cwd);
            }
            else
            {
                string Select = checkedListBox1.SelectedItem.ToString();
                string cwd = Directory.GetCurrentDirectory() + @"\" + Select;
                Process.Start("explorer.exe", cwd);
            }
        }
    }
}
