namespace PhotoOrg
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.exitsettings = new System.Windows.Forms.Button();
            this.bannerset = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.themepicker = new System.Windows.Forms.ComboBox();
            this.browseDir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitsettings
            // 
            this.exitsettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitsettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitsettings.ForeColor = System.Drawing.Color.Crimson;
            this.exitsettings.Location = new System.Drawing.Point(424, 12);
            this.exitsettings.Name = "exitsettings";
            this.exitsettings.Size = new System.Drawing.Size(25, 25);
            this.exitsettings.TabIndex = 0;
            this.exitsettings.UseVisualStyleBackColor = false;
            this.exitsettings.Click += new System.EventHandler(this.exitsettings_Click);
            // 
            // bannerset
            // 
            this.bannerset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.bannerset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bannerset.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerset.ForeColor = System.Drawing.Color.Silver;
            this.bannerset.Location = new System.Drawing.Point(14, 103);
            this.bannerset.Name = "bannerset";
            this.bannerset.Size = new System.Drawing.Size(434, 33);
            this.bannerset.TabIndex = 1;
            this.bannerset.Text = "banner";
            this.bannerset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bannerset.TextChanged += new System.EventHandler(this.bannerset_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.button1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(232, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // themepicker
            // 
            this.themepicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.themepicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themepicker.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themepicker.ForeColor = System.Drawing.Color.Silver;
            this.themepicker.FormattingEnabled = true;
            this.themepicker.Location = new System.Drawing.Point(14, 142);
            this.themepicker.Name = "themepicker";
            this.themepicker.Size = new System.Drawing.Size(435, 41);
            this.themepicker.TabIndex = 3;
            this.themepicker.Text = "                      theme";
            // 
            // browseDir
            // 
            this.browseDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.browseDir.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseDir.ForeColor = System.Drawing.Color.Silver;
            this.browseDir.Location = new System.Drawing.Point(14, 213);
            this.browseDir.Name = "browseDir";
            this.browseDir.Size = new System.Drawing.Size(435, 42);
            this.browseDir.TabIndex = 2;
            this.browseDir.Text = "alternate save directory";
            this.browseDir.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 59);
            this.label1.TabIndex = 4;
            this.label1.Text = "Settings";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(461, 317);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.themepicker);
            this.Controls.Add(this.browseDir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bannerset);
            this.Controls.Add(this.exitsettings);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settings";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitsettings;
        private System.Windows.Forms.TextBox bannerset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox themepicker;
        private System.Windows.Forms.Button browseDir;
        private System.Windows.Forms.Label label1;
    }
}