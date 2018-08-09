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
            this.prints = new System.Windows.Forms.NumericUpDown();
            this.prints_l = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.CheckBox();
            this.email = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.exit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.browse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prints)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Black;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(13, 126);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(448, 34);
            this.name.TabIndex = 0;
            this.name.Text = "name";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // order
            // 
            this.order.BackColor = System.Drawing.Color.Black;
            this.order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.order.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.ForeColor = System.Drawing.Color.White;
            this.order.Location = new System.Drawing.Point(240, 166);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(221, 34);
            this.order.TabIndex = 2;
            this.order.Text = "order number";
            this.order.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.Color.Black;
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.ForeColor = System.Drawing.Color.White;
            this.phone.Location = new System.Drawing.Point(13, 166);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(221, 34);
            this.phone.TabIndex = 1;
            this.phone.Text = "phone";
            this.phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prints
            // 
            this.prints.BackColor = System.Drawing.Color.Black;
            this.prints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prints.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.prints.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prints.ForeColor = System.Drawing.Color.White;
            this.prints.Location = new System.Drawing.Point(408, 286);
            this.prints.Name = "prints";
            this.prints.Size = new System.Drawing.Size(53, 37);
            this.prints.TabIndex = 5;
            this.prints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prints_l
            // 
            this.prints_l.AutoSize = true;
            this.prints_l.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prints_l.ForeColor = System.Drawing.Color.White;
            this.prints_l.Location = new System.Drawing.Point(12, 288);
            this.prints_l.Name = "prints_l";
            this.prints_l.Size = new System.Drawing.Size(132, 33);
            this.prints_l.TabIndex = 9;
            this.prints_l.Text = "prints    x";
            // 
            // mail
            // 
            this.mail.Appearance = System.Windows.Forms.Appearance.Button;
            this.mail.AutoSize = true;
            this.mail.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mail.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail.ForeColor = System.Drawing.Color.DimGray;
            this.mail.Location = new System.Drawing.Point(13, 382);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(80, 43);
            this.mail.TabIndex = 7;
            this.mail.Text = "mail";
            this.mail.UseVisualStyleBackColor = true;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.Black;
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.White;
            this.email.Location = new System.Drawing.Point(13, 206);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(448, 34);
            this.email.TabIndex = 3;
            this.email.Text = "email";
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.Black;
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.address.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.Color.White;
            this.address.Location = new System.Drawing.Point(13, 246);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(448, 34);
            this.address.TabIndex = 4;
            this.address.Text = "address";
            this.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.address.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Black;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(239, 382);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(221, 42);
            this.save.TabIndex = 8;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.button2_Click);
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.Color.Snow;
            this.logo.Location = new System.Drawing.Point(111, 42);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(252, 43);
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
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Crimson;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.exit.Location = new System.Drawing.Point(451, 1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 20);
            this.exit.TabIndex = 11;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.Black;
            this.browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.ForeColor = System.Drawing.Color.White;
            this.browse.Location = new System.Drawing.Point(14, 334);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(447, 42);
            this.browse.TabIndex = 6;
            this.browse.Text = "browse";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // PhotoOrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(472, 436);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.save);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.address);
            this.Controls.Add(this.email);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.prints_l);
            this.Controls.Add(this.prints);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.order);
            this.Controls.Add(this.name);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PhotoOrg";
            this.Text = "Elisha.Photo Organizer";
            ((System.ComponentModel.ISupportInitialize)(this.prints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox order;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.NumericUpDown prints;
        private System.Windows.Forms.Label prints_l;
        private System.Windows.Forms.CheckBox mail;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button browse;
    }
}

