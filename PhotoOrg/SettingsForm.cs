﻿using System;
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

            int count = 0;

            // Parsing the settings folder for themes

            if (Directory.Exists("settings"))
            {
               string[] themes = Directory.GetFiles("settings","*.ini");
                
               foreach (string settings in themes)
               {
                   string tidy = themes[count].Replace(@"settings\","");
                   string tidier = tidy.Replace(".ini", "");
                   themeInput.Items.Add(tidier);
                   count++;
               };

                string[] Settings = File.ReadAllLines(@"settings/settings.cfg");
                bannerInput.Text = Settings[1];
                themeInput.Text = Settings[3];
                alternateDirButton.Text = Settings[5];
            }

            
        }

        // Stuff for replacing settings lines in the settings.cfg

        static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Saving and exiting. Not perfect.

        private void saveButton_Click(object sender, EventArgs e)
        {
            string theme = themeInput.Text;
            string banner = bannerInput.Text;


            if (banner != "banner")
            {
                lineChanger(banner, @"settings/settings.cfg", 2);
            }
            else
            {
                lineChanger("Elisha.Photo", @"settings/settings.cfg", 2);
            }


            if (theme != "                      theme")
            {
                lineChanger(theme, @"settings/settings.cfg", 4);
            }
            else
            {
                lineChanger("default", @"settings/settings.cfg", 4);
            }


            if (alternateDirButton.Text != "alternate save directory")
            {
                lineChanger(alternateDirButton.Text, @"settings/settings.cfg", 6);
            }
            else
            {
                lineChanger("default", @"settings/settings.cfg", 6);
            }

            if (alternateDirButton.Text == "")
            {
                lineChanger("default", @"settings/settings.cfg", 6);
            }

            this.Close();
        }

        // Getting the Alternate Save directory

        private void alternateDirButton_Click(object sender, EventArgs e)
        {
            settingsFolderBrowserDialogue.ShowDialog();
            string SaveDir = settingsFolderBrowserDialogue.SelectedPath;
            alternateDirButton.Text = SaveDir;
        }
    }
}
