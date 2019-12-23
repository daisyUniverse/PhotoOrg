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

namespace PhotoOrg
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            // Parsing the settings folder for themes

            if (!Directory.Exists("settings"))
                return;

            string[] themes = Directory.GetFiles("settings","*.ini");

            for (var lineNumber = 0; lineNumber < themes.Length; lineNumber++)
            {
                var tidy = themes[lineNumber].Replace(@"settings\","");
                var tidier = tidy.Replace(".ini", "");
                themeInput.Items.Add(tidier);
            }

            string[] settings = File.ReadAllLines(@"settings/settings.cfg");
            bannerInput.Text = settings[1];
            themeInput.Text = settings[3];
            alternateDirButton.Text = settings[5];
        }

        // Stuff for replacing settings lines in the settings.cfg

        static void LineChanger(string newText, string fileName, int line_to_edit)
        {
            var arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        // Magic drag window around code

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        // Come on. You can figure this out.
        // You did it! <3

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Saving and exiting. Not perfect.

        private void saveButton_Click(object sender, EventArgs e)
        {
            var theme = themeInput.Text;
            var banner = bannerInput.Text;


            if (banner != "banner")
            {
                LineChanger(banner, @"settings/settings.cfg", 2);
            }
            else
            {
                LineChanger("Elisha.Photo", @"settings/settings.cfg", 2);
            }


            if (theme != "                      theme")
            {
                LineChanger(theme, @"settings/settings.cfg", 4);
            }
            else
            {
                LineChanger("default", @"settings/settings.cfg", 4);
            }


            if (alternateDirButton.Text != "alternate save directory")
            {
                LineChanger(alternateDirButton.Text, @"settings/settings.cfg", 6);
            }
            else
            {
                LineChanger("default", @"settings/settings.cfg", 6);
            }

            if (alternateDirButton.Text == "")
            {
                LineChanger("default", @"settings/settings.cfg", 6);
            }

            Close();
        }

        // Getting the Alternate Save directory

        private void alternateDirButton_Click(object sender, EventArgs e)
        {
            settingsFolderBrowserDialogue.ShowDialog();
            var saveDir = settingsFolderBrowserDialogue.SelectedPath;
            alternateDirButton.Text = saveDir;
        }
    }
}
