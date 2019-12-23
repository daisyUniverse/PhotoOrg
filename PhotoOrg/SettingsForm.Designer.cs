namespace PhotoOrg
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.exitButton = new System.Windows.Forms.Button();
            this.bannerInput = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.themeInput = new System.Windows.Forms.ComboBox();
            this.alternateButton = new System.Windows.Forms.Button();
            this.settingsFormTitle = new System.Windows.Forms.Label();
            this.settingsFolderBrowserDialogue = new System.Windows.Forms.FolderBrowserDialog();
            this.bannerLabel = new System.Windows.Forms.Label();
            this.themeLabel = new System.Windows.Forms.Label();
            this.saveToLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.Crimson;
            this.exitButton.Location = new System.Drawing.Point(486, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(25, 25);
            this.exitButton.TabIndex = 0;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitsettings_Click);
            // 
            // bannerInput
            // 
            this.bannerInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.bannerInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bannerInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerInput.ForeColor = System.Drawing.Color.Silver;
            this.bannerInput.Location = new System.Drawing.Point(251, 120);
            this.bannerInput.Multiline = true;
            this.bannerInput.Name = "bannerInput";
            this.bannerInput.Size = new System.Drawing.Size(184, 41);
            this.bannerInput.TabIndex = 1;
            this.bannerInput.Text = "banner";
            this.bannerInput.TextChanged += new System.EventHandler(this.bannerset_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.saveButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.Silver;
            this.saveButton.Location = new System.Drawing.Point(102, 418);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(337, 42);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // themeInput
            // 
            this.themeInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.themeInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themeInput.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeInput.ForeColor = System.Drawing.Color.Silver;
            this.themeInput.FormattingEnabled = true;
            this.themeInput.Location = new System.Drawing.Point(251, 202);
            this.themeInput.Name = "themeInput";
            this.themeInput.Size = new System.Drawing.Size(184, 41);
            this.themeInput.TabIndex = 3;
            this.themeInput.Text = "theme";
            // 
            // alternateButton
            // 
            this.alternateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.alternateButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alternateButton.ForeColor = System.Drawing.Color.Silver;
            this.alternateButton.Location = new System.Drawing.Point(253, 293);
            this.alternateButton.Name = "alternateButton";
            this.alternateButton.Size = new System.Drawing.Size(180, 42);
            this.alternateButton.TabIndex = 2;
            this.alternateButton.Text = "alternate save directory";
            this.alternateButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.alternateButton.UseVisualStyleBackColor = false;
            this.alternateButton.Click += new System.EventHandler(this.browseDir_Click);
            // 
            // settingsFormTitle
            // 
            this.settingsFormTitle.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsFormTitle.ForeColor = System.Drawing.Color.White;
            this.settingsFormTitle.Location = new System.Drawing.Point(136, 38);
            this.settingsFormTitle.Name = "settingsFormTitle";
            this.settingsFormTitle.Size = new System.Drawing.Size(262, 59);
            this.settingsFormTitle.TabIndex = 4;
            this.settingsFormTitle.Text = "Settings";
            // 
            // settingsFolderBrowserDialogue
            // 
            this.settingsFolderBrowserDialogue.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // bannerLabel
            // 
            this.bannerLabel.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerLabel.ForeColor = System.Drawing.Color.White;
            this.bannerLabel.Location = new System.Drawing.Point(108, 124);
            this.bannerLabel.Name = "bannerLabel";
            this.bannerLabel.Size = new System.Drawing.Size(130, 41);
            this.bannerLabel.TabIndex = 5;
            this.bannerLabel.Text = "Banner:";
            // 
            // themeLabel
            // 
            this.themeLabel.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeLabel.ForeColor = System.Drawing.Color.White;
            this.themeLabel.Location = new System.Drawing.Point(124, 209);
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new System.Drawing.Size(130, 41);
            this.themeLabel.TabIndex = 6;
            this.themeLabel.Text = "Theme:";
            // 
            // saveToLabel
            // 
            this.saveToLabel.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToLabel.ForeColor = System.Drawing.Color.White;
            this.saveToLabel.Location = new System.Drawing.Point(94, 302);
            this.saveToLabel.Name = "saveToLabel";
            this.saveToLabel.Size = new System.Drawing.Size(160, 33);
            this.saveToLabel.TabIndex = 7;
            this.saveToLabel.Text = "Save to:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(523, 472);
            this.Controls.Add(this.alternateButton);
            this.Controls.Add(this.bannerInput);
            this.Controls.Add(this.themeInput);
            this.Controls.Add(this.saveToLabel);
            this.Controls.Add(this.themeLabel);
            this.Controls.Add(this.bannerLabel);
            this.Controls.Add(this.settingsFormTitle);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.exitButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox bannerInput;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox themeInput;
        private System.Windows.Forms.Button alternateButton;
        private System.Windows.Forms.Label settingsFormTitle;
        private System.Windows.Forms.FolderBrowserDialog settingsFolderBrowserDialogue;
        private System.Windows.Forms.Label bannerLabel;
        private System.Windows.Forms.Label themeLabel;
        private System.Windows.Forms.Label saveToLabel;
    }
}