namespace PhotoOrg
{
    partial class PhotoOrg
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhotoOrg));
            this.name = new System.Windows.Forms.TextBox();
            this.order = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.CheckBox();
            this.email = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.browse = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.settingsOpen = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.AddFiles = new System.Windows.Forms.Button();
            this.notes = new System.Windows.Forms.TextBox();
            this.filesprev = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.LightGray;
            this.name.Location = new System.Drawing.Point(17, 155);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(597, 42);
            this.name.TabIndex = 0;
            this.name.Text = "name";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // order
            // 
            this.order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.order.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.ForeColor = System.Drawing.Color.LightGray;
            this.order.Location = new System.Drawing.Point(320, 204);
            this.order.Margin = new System.Windows.Forms.Padding(4);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(295, 42);
            this.order.TabIndex = 2;
            this.order.Text = "order number";
            this.order.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.ForeColor = System.Drawing.Color.LightGray;
            this.phone.Location = new System.Drawing.Point(17, 204);
            this.phone.Margin = new System.Windows.Forms.Padding(4);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(295, 42);
            this.phone.TabIndex = 1;
            this.phone.Text = "phone";
            this.phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mail
            // 
            this.mail.Appearance = System.Windows.Forms.Appearance.Button;
            this.mail.AutoSize = true;
            this.mail.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mail.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.ForeColor = System.Drawing.Color.LightGray;
            this.mail.Location = new System.Drawing.Point(16, 486);
            this.mail.Margin = new System.Windows.Forms.Padding(4);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(97, 52);
            this.mail.TabIndex = 7;
            this.mail.Text = "jobs";
            this.mail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mail.UseVisualStyleBackColor = true;
            this.mail.CheckedChanged += new System.EventHandler(this.mail_CheckedChanged);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.LightGray;
            this.email.Location = new System.Drawing.Point(17, 254);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(597, 42);
            this.email.TabIndex = 3;
            this.email.Text = "email";
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.address.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.Color.LightGray;
            this.address.Location = new System.Drawing.Point(17, 303);
            this.address.Margin = new System.Windows.Forms.Padding(4);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(597, 42);
            this.address.TabIndex = 4;
            this.address.Text = "address";
            this.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.address.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.save.Enabled = false;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.LightGray;
            this.save.Location = new System.Drawing.Point(320, 487);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(295, 52);
            this.save.TabIndex = 8;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.button2_Click);
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.Color.Snow;
            this.logo.Location = new System.Drawing.Point(124, 64);
            this.logo.Margin = new System.Windows.Forms.Padding(0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(358, 50);
            this.logo.TabIndex = 10;
            this.logo.Text = "Elisha.Photo";
            this.logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.ForeColor = System.Drawing.Color.LightGray;
            this.browse.Location = new System.Drawing.Point(17, 427);
            this.browse.Margin = new System.Windows.Forms.Padding(4);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(597, 52);
            this.browse.TabIndex = 6;
            this.browse.Text = "browse";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.White;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(635, 155);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(588, 320);
            this.checkedListBox1.TabIndex = 12;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // settingsOpen
            // 
            this.settingsOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(117)))), ((int)(((byte)(187)))));
            this.settingsOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsOpen.Location = new System.Drawing.Point(16, 15);
            this.settingsOpen.Margin = new System.Windows.Forms.Padding(4);
            this.settingsOpen.Name = "settingsOpen";
            this.settingsOpen.Size = new System.Drawing.Size(33, 31);
            this.settingsOpen.TabIndex = 13;
            this.settingsOpen.UseVisualStyleBackColor = false;
            this.settingsOpen.Click += new System.EventHandler(this.settingsOpen_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Red;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Location = new System.Drawing.Point(581, 15);
            this.close.Margin = new System.Windows.Forms.Padding(4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(33, 31);
            this.close.TabIndex = 14;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // AddFiles
            // 
            this.AddFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.AddFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFiles.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFiles.ForeColor = System.Drawing.Color.LightGray;
            this.AddFiles.Location = new System.Drawing.Point(635, 488);
            this.AddFiles.Margin = new System.Windows.Forms.Padding(4);
            this.AddFiles.Name = "AddFiles";
            this.AddFiles.Size = new System.Drawing.Size(431, 52);
            this.AddFiles.TabIndex = 15;
            this.AddFiles.Text = "Open Folder";
            this.AddFiles.UseVisualStyleBackColor = false;
            this.AddFiles.Click += new System.EventHandler(this.AddFiles_Click);
            // 
            // notes
            // 
            this.notes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.notes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notes.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes.ForeColor = System.Drawing.Color.LightGray;
            this.notes.Location = new System.Drawing.Point(16, 352);
            this.notes.Margin = new System.Windows.Forms.Padding(4);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(597, 42);
            this.notes.TabIndex = 16;
            this.notes.Text = "notes";
            this.notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.notes.TextChanged += new System.EventHandler(this.notes_TextChanged);
            // 
            // filesprev
            // 
            this.filesprev.AutoSize = true;
            this.filesprev.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesprev.ForeColor = System.Drawing.Color.LightGray;
            this.filesprev.Location = new System.Drawing.Point(148, 495);
            this.filesprev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filesprev.Name = "filesprev";
            this.filesprev.Size = new System.Drawing.Size(0, 39);
            this.filesprev.TabIndex = 17;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.Red;
            this.delete.Location = new System.Drawing.Point(1074, 488);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(149, 52);
            this.delete.TabIndex = 18;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // PhotoOrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(630, 554);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.filesprev);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.AddFiles);
            this.Controls.Add(this.close);
            this.Controls.Add(this.settingsOpen);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.address);
            this.Controls.Add(this.email);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.order);
            this.Controls.Add(this.name);
            this.Controls.Add(this.logo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhotoOrg";
            this.Text = "Elisha.Photo Organizer";
            this.Load += new System.EventHandler(this.PhotoOrg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox order;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.CheckBox mail;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button settingsOpen;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button AddFiles;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.Label filesprev;
        private System.Windows.Forms.Button delete;
    }
}

