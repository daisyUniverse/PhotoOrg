namespace PhotoOrg
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.nameInput = new System.Windows.Forms.TextBox();
            this.orderNumberInput = new System.Windows.Forms.TextBox();
            this.phoneNumberInput = new System.Windows.Forms.TextBox();
            this.jobsToggleCheckbox = new System.Windows.Forms.CheckBox();
            this.emailButton = new System.Windows.Forms.TextBox();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.formTitleLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.jobsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.openJobFolderButton = new System.Windows.Forms.Button();
            this.notesInput = new System.Windows.Forms.TextBox();
            this.fileCountLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.imagePreviewPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addFilesOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameInput.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.ForeColor = System.Drawing.Color.LightGray;
            this.nameInput.Location = new System.Drawing.Point(13, 126);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(448, 34);
            this.nameInput.TabIndex = 0;
            this.nameInput.Text = "name";
            this.nameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // orderNumberInput
            // 
            this.orderNumberInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.orderNumberInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderNumberInput.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNumberInput.ForeColor = System.Drawing.Color.LightGray;
            this.orderNumberInput.Location = new System.Drawing.Point(240, 166);
            this.orderNumberInput.Name = "orderNumberInput";
            this.orderNumberInput.Size = new System.Drawing.Size(221, 34);
            this.orderNumberInput.TabIndex = 2;
            this.orderNumberInput.Text = "order number";
            this.orderNumberInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phoneNumberInput
            // 
            this.phoneNumberInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.phoneNumberInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumberInput.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberInput.ForeColor = System.Drawing.Color.LightGray;
            this.phoneNumberInput.Location = new System.Drawing.Point(13, 166);
            this.phoneNumberInput.Name = "phoneNumberInput";
            this.phoneNumberInput.Size = new System.Drawing.Size(221, 34);
            this.phoneNumberInput.TabIndex = 1;
            this.phoneNumberInput.Text = "phone";
            this.phoneNumberInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // jobsToggleCheckbox
            // 
            this.jobsToggleCheckbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.jobsToggleCheckbox.AutoSize = true;
            this.jobsToggleCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.jobsToggleCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jobsToggleCheckbox.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobsToggleCheckbox.ForeColor = System.Drawing.Color.LightGray;
            this.jobsToggleCheckbox.Location = new System.Drawing.Point(12, 395);
            this.jobsToggleCheckbox.Name = "jobsToggleCheckbox";
            this.jobsToggleCheckbox.Size = new System.Drawing.Size(79, 43);
            this.jobsToggleCheckbox.TabIndex = 7;
            this.jobsToggleCheckbox.Text = "jobs";
            this.jobsToggleCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.jobsToggleCheckbox.UseVisualStyleBackColor = true;
            this.jobsToggleCheckbox.CheckedChanged += new System.EventHandler(this.mail_CheckedChanged);
            // 
            // emailButton
            // 
            this.emailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.emailButton.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailButton.ForeColor = System.Drawing.Color.LightGray;
            this.emailButton.Location = new System.Drawing.Point(13, 206);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(448, 34);
            this.emailButton.TabIndex = 3;
            this.emailButton.Text = "email";
            this.emailButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addressInput
            // 
            this.addressInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.addressInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressInput.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressInput.ForeColor = System.Drawing.Color.LightGray;
            this.addressInput.Location = new System.Drawing.Point(13, 246);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(448, 34);
            this.addressInput.TabIndex = 4;
            this.addressInput.Text = "address";
            this.addressInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addressInput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.saveButton.Enabled = false;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.LightGray;
            this.saveButton.Location = new System.Drawing.Point(240, 396);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(221, 42);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // formTitleLabel
            // 
            this.formTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.formTitleLabel.AutoSize = true;
            this.formTitleLabel.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitleLabel.ForeColor = System.Drawing.Color.Snow;
            this.formTitleLabel.Location = new System.Drawing.Point(580, 52);
            this.formTitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.formTitleLabel.Name = "formTitleLabel";
            this.formTitleLabel.Size = new System.Drawing.Size(281, 39);
            this.formTitleLabel.TabIndex = 10;
            this.formTitleLabel.Text = "Elisha.Photo";
            this.formTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.formTitleLabel.Click += new System.EventHandler(this.logo_Click);
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.ForeColor = System.Drawing.Color.LightGray;
            this.browseButton.Location = new System.Drawing.Point(13, 347);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(448, 42);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browse_Click);
            // 
            // jobsCheckedListBox
            // 
            this.jobsCheckedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.jobsCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jobsCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobsCheckedListBox.ForeColor = System.Drawing.Color.White;
            this.jobsCheckedListBox.FormattingEnabled = true;
            this.jobsCheckedListBox.Location = new System.Drawing.Point(476, 126);
            this.jobsCheckedListBox.Name = "jobsCheckedListBox";
            this.jobsCheckedListBox.Size = new System.Drawing.Size(441, 260);
            this.jobsCheckedListBox.TabIndex = 12;
            this.jobsCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(117)))), ((int)(((byte)(187)))));
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Location = new System.Drawing.Point(12, 12);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(25, 25);
            this.settingsButton.TabIndex = 13;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsOpen_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(1410, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 14;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // openJobFolderButton
            // 
            this.openJobFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.openJobFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openJobFolderButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openJobFolderButton.ForeColor = System.Drawing.Color.LightGray;
            this.openJobFolderButton.Location = new System.Drawing.Point(476, 396);
            this.openJobFolderButton.Name = "openJobFolderButton";
            this.openJobFolderButton.Size = new System.Drawing.Size(323, 42);
            this.openJobFolderButton.TabIndex = 15;
            this.openJobFolderButton.Text = "Open Folder";
            this.openJobFolderButton.UseVisualStyleBackColor = false;
            this.openJobFolderButton.Click += new System.EventHandler(this.OpenJobFolderButton_Click);
            // 
            // notesInput
            // 
            this.notesInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.notesInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notesInput.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesInput.ForeColor = System.Drawing.Color.LightGray;
            this.notesInput.Location = new System.Drawing.Point(12, 286);
            this.notesInput.Name = "notesInput";
            this.notesInput.Size = new System.Drawing.Size(448, 34);
            this.notesInput.TabIndex = 16;
            this.notesInput.Text = "notes";
            this.notesInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.notesInput.TextChanged += new System.EventHandler(this.notes_TextChanged);
            // 
            // fileCountLabel
            // 
            this.fileCountLabel.AutoSize = true;
            this.fileCountLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileCountLabel.ForeColor = System.Drawing.Color.LightGray;
            this.fileCountLabel.Location = new System.Drawing.Point(111, 402);
            this.fileCountLabel.Name = "fileCountLabel";
            this.fileCountLabel.Size = new System.Drawing.Size(0, 32);
            this.fileCountLabel.TabIndex = 17;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(49)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(806, 396);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(112, 42);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.delete_Click);
            // 
            // imagePreviewPanel
            // 
            this.imagePreviewPanel.AutoScroll = true;
            this.imagePreviewPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.imagePreviewPanel.Location = new System.Drawing.Point(925, 153);
            this.imagePreviewPanel.Name = "imagePreviewPanel";
            this.imagePreviewPanel.Size = new System.Drawing.Size(441, 233);
            this.imagePreviewPanel.TabIndex = 19;
            this.imagePreviewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // addFilesOpenFileDialog
            // 
            this.addFilesOpenFileDialog.FileName = "addPhotosOpenFileDialog";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1446, 450);
            this.Controls.Add(this.imagePreviewPanel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.fileCountLabel);
            this.Controls.Add(this.notesInput);
            this.Controls.Add(this.openJobFolderButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.jobsCheckedListBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.emailButton);
            this.Controls.Add(this.jobsToggleCheckbox);
            this.Controls.Add(this.phoneNumberInput);
            this.Controls.Add(this.orderNumberInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.formTitleLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Elisha.Photo Organizer";
            this.Load += new System.EventHandler(this.PhotoOrg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox orderNumberInput;
        private System.Windows.Forms.TextBox phoneNumberInput;
        private System.Windows.Forms.CheckBox jobsToggleCheckbox;
        private System.Windows.Forms.TextBox emailButton;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label formTitleLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.CheckedListBox jobsCheckedListBox;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button openJobFolderButton;
        private System.Windows.Forms.TextBox notesInput;
        private System.Windows.Forms.Label fileCountLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.FlowLayoutPanel imagePreviewPanel;
        private System.Windows.Forms.OpenFileDialog addFilesOpenFileDialog;
    }
}

