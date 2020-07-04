namespace B20_Ex01_Ofir_307921320_Ilan_203442306
{
    public partial class MainForm
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
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label messageLabel;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label9;
            this.buttonGetAccessToken = new System.Windows.Forms.Button();
            this.buttonGetTopCities = new System.Windows.Forms.Button();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.listBoxTopCities = new System.Windows.Forms.ListBox();
            this.labelStaticStatus = new System.Windows.Forms.Label();
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearchPostByCity = new System.Windows.Forms.TextBox();
            this.buttonSearchPostByCity = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewPostByCity = new System.Windows.Forms.ListView();
            this.imageListPosts = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.listViewPosts = new System.Windows.Forms.ListView();
            this.checkBoxRemmemberMe = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idLabel1 = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.listBoxStatuses = new System.Windows.Forms.ListBox();
            this.radioButtonLocation = new System.Windows.Forms.RadioButton();
            this.radioButtonContent = new System.Windows.Forms.RadioButton();
            this.radioButtonDate = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(202, 34);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(73, 13);
            createdTimeLabel.TabIndex = 4;
            createdTimeLabel.Text = "Created Time:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(202, 57);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 6;
            idLabel.Text = "Id:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(202, 82);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(53, 13);
            messageLabel.TabIndex = 8;
            messageLabel.Text = "Message:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(201, 8);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(90, 13);
            label7.TabIndex = 10;
            label7.Text = "Status Details:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.Location = new System.Drawing.Point(3, 8);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(60, 13);
            label9.TabIndex = 11;
            label9.Text = "Statuses:";
            // 
            // buttonGetAccessToken
            // 
            this.buttonGetAccessToken.Location = new System.Drawing.Point(12, 115);
            this.buttonGetAccessToken.Name = "buttonGetAccessToken";
            this.buttonGetAccessToken.Size = new System.Drawing.Size(59, 23);
            this.buttonGetAccessToken.TabIndex = 0;
            this.buttonGetAccessToken.Text = "Connect";
            this.buttonGetAccessToken.UseVisualStyleBackColor = true;
            this.buttonGetAccessToken.Click += new System.EventHandler(this.buttonGetAccessToken_Click);
            // 
            // buttonGetTopCities
            // 
            this.buttonGetTopCities.Location = new System.Drawing.Point(352, 242);
            this.buttonGetTopCities.Name = "buttonGetTopCities";
            this.buttonGetTopCities.Size = new System.Drawing.Size(188, 23);
            this.buttonGetTopCities.TabIndex = 2;
            this.buttonGetTopCities.Text = "Get Top Cities";
            this.buttonGetTopCities.UseVisualStyleBackColor = true;
            this.buttonGetTopCities.Click += new System.EventHandler(this.buttonGetTopCities_Click);
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(12, 17);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(183, 92);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePicture.TabIndex = 3;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // listBoxTopCities
            // 
            this.listBoxTopCities.FormattingEnabled = true;
            this.listBoxTopCities.Location = new System.Drawing.Point(352, 274);
            this.listBoxTopCities.Name = "listBoxTopCities";
            this.listBoxTopCities.Size = new System.Drawing.Size(188, 121);
            this.listBoxTopCities.TabIndex = 4;
            // 
            // labelStaticStatus
            // 
            this.labelStaticStatus.AutoSize = true;
            this.labelStaticStatus.Location = new System.Drawing.Point(9, 141);
            this.labelStaticStatus.Name = "labelStaticStatus";
            this.labelStaticStatus.Size = new System.Drawing.Size(43, 13);
            this.labelStaticStatus.TabIndex = 5;
            this.labelStaticStatus.Text = "Status: ";
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Location = new System.Drawing.Point(48, 141);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(79, 13);
            this.labelConnectionStatus.TabIndex = 6;
            this.labelConnectionStatus.Text = "Not Connected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "The cities you had posted from \r\nthe most, by descending order";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSearchPostByCity
            // 
            this.textBoxSearchPostByCity.Location = new System.Drawing.Point(352, 28);
            this.textBoxSearchPostByCity.Name = "textBoxSearchPostByCity";
            this.textBoxSearchPostByCity.Size = new System.Drawing.Size(127, 20);
            this.textBoxSearchPostByCity.TabIndex = 9;
            // 
            // buttonSearchPostByCity
            // 
            this.buttonSearchPostByCity.Location = new System.Drawing.Point(485, 28);
            this.buttonSearchPostByCity.Name = "buttonSearchPostByCity";
            this.buttonSearchPostByCity.Size = new System.Drawing.Size(55, 21);
            this.buttonSearchPostByCity.TabIndex = 10;
            this.buttonSearchPostByCity.Text = "Search";
            this.buttonSearchPostByCity.UseVisualStyleBackColor = true;
            this.buttonSearchPostByCity.Click += new System.EventHandler(this.buttonSearchPostByCity_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Search posts:";
            // 
            // listViewPostByCity
            // 
            this.listViewPostByCity.HideSelection = false;
            this.listViewPostByCity.Location = new System.Drawing.Point(352, 94);
            this.listViewPostByCity.Name = "listViewPostByCity";
            this.listViewPostByCity.Size = new System.Drawing.Size(188, 102);
            this.listViewPostByCity.TabIndex = 13;
            this.listViewPostByCity.UseCompatibleStateImageBehavior = false;
            // 
            // imageListPosts
            // 
            this.imageListPosts.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListPosts.ImageSize = new System.Drawing.Size(64, 64);
            this.imageListPosts.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Birthday: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Gender: ";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(76, 227);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(67, 13);
            this.labelGender.TabIndex = 20;
            this.labelGender.Text = "__________";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(76, 205);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(67, 13);
            this.labelBirthday.TabIndex = 19;
            this.labelBirthday.Text = "__________";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(76, 183);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(67, 13);
            this.labelFullName.TabIndex = 18;
            this.labelFullName.Text = "__________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Friends";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(16, 274);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(180, 121);
            this.listBoxFriends.TabIndex = 23;
            // 
            // listViewPosts
            // 
            this.listViewPosts.HideSelection = false;
            this.listViewPosts.Location = new System.Drawing.Point(202, 17);
            this.listViewPosts.MultiSelect = false;
            this.listViewPosts.Name = "listViewPosts";
            this.listViewPosts.Size = new System.Drawing.Size(144, 378);
            this.listViewPosts.TabIndex = 24;
            this.listViewPosts.UseCompatibleStateImageBehavior = false;
            // 
            // checkBoxRemmemberMe
            // 
            this.checkBoxRemmemberMe.AutoSize = true;
            this.checkBoxRemmemberMe.Location = new System.Drawing.Point(77, 119);
            this.checkBoxRemmemberMe.Name = "checkBoxRemmemberMe";
            this.checkBoxRemmemberMe.Size = new System.Drawing.Size(103, 17);
            this.checkBoxRemmemberMe.TabIndex = 25;
            this.checkBoxRemmemberMe.Text = "Remmember Me";
            this.checkBoxRemmemberMe.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(label9);
            this.panel1.Controls.Add(label7);
            this.panel1.Controls.Add(createdTimeLabel);
            this.panel1.Controls.Add(this.createdTimeDateTimePicker);
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idLabel1);
            this.panel1.Controls.Add(messageLabel);
            this.panel1.Controls.Add(this.messageTextBox);
            this.panel1.Controls.Add(this.listBoxStatuses);
            this.panel1.Location = new System.Drawing.Point(16, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 157);
            this.panel1.TabIndex = 26;
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.statusBindingSource, "CreatedTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(281, 30);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(238, 20);
            this.createdTimeDateTimePicker.TabIndex = 5;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Status);
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "No ID"));
            this.idLabel1.Location = new System.Drawing.Point(281, 57);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(238, 23);
            this.idLabel1.TabIndex = 7;
            this.idLabel1.Text = "label7";
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "Message", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "No Message"));
            this.messageTextBox.Location = new System.Drawing.Point(281, 79);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(238, 72);
            this.messageTextBox.TabIndex = 9;
            // 
            // listBoxStatuses
            // 
            this.listBoxStatuses.DataSource = this.statusBindingSource;
            this.listBoxStatuses.DisplayMember = "CreatedTime";
            this.listBoxStatuses.FormattingEnabled = true;
            this.listBoxStatuses.Location = new System.Drawing.Point(4, 30);
            this.listBoxStatuses.Name = "listBoxStatuses";
            this.listBoxStatuses.Size = new System.Drawing.Size(176, 121);
            this.listBoxStatuses.TabIndex = 4;
            // 
            // radioButtonLocation
            // 
            this.radioButtonLocation.AutoSize = true;
            this.radioButtonLocation.Checked = true;
            this.radioButtonLocation.Location = new System.Drawing.Point(352, 71);
            this.radioButtonLocation.Name = "radioButtonLocation";
            this.radioButtonLocation.Size = new System.Drawing.Size(66, 17);
            this.radioButtonLocation.TabIndex = 27;
            this.radioButtonLocation.TabStop = true;
            this.radioButtonLocation.Text = "Location";
            this.radioButtonLocation.UseVisualStyleBackColor = true;
            // 
            // radioButtonContent
            // 
            this.radioButtonContent.AutoSize = true;
            this.radioButtonContent.Location = new System.Drawing.Point(424, 71);
            this.radioButtonContent.Name = "radioButtonContent";
            this.radioButtonContent.Size = new System.Drawing.Size(62, 17);
            this.radioButtonContent.TabIndex = 28;
            this.radioButtonContent.Text = "Content";
            this.radioButtonContent.UseVisualStyleBackColor = true;
            // 
            // radioButtonDate
            // 
            this.radioButtonDate.AutoSize = true;
            this.radioButtonDate.Location = new System.Drawing.Point(492, 71);
            this.radioButtonDate.Name = "radioButtonDate";
            this.radioButtonDate.Size = new System.Drawing.Size(48, 17);
            this.radioButtonDate.TabIndex = 29;
            this.radioButtonDate.Text = "Date";
            this.radioButtonDate.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(350, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Search by:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 575);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radioButtonDate);
            this.Controls.Add(this.radioButtonContent);
            this.Controls.Add(this.radioButtonLocation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxRemmemberMe);
            this.Controls.Add(this.listViewPosts);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewPostByCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSearchPostByCity);
            this.Controls.Add(this.textBoxSearchPostByCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelConnectionStatus);
            this.Controls.Add(this.labelStaticStatus);
            this.Controls.Add(this.listBoxTopCities);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Controls.Add(this.buttonGetTopCities);
            this.Controls.Add(this.buttonGetAccessToken);
            this.Name = "MainForm";
            this.Text = "Not Logged In";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetAccessToken;
        private System.Windows.Forms.Button buttonGetTopCities;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.ListBox listBoxTopCities;
        private System.Windows.Forms.Label labelStaticStatus;
        private System.Windows.Forms.Label labelConnectionStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearchPostByCity;
        private System.Windows.Forms.Button buttonSearchPostByCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewPostByCity;
        private System.Windows.Forms.ImageList imageListPosts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.ListView listViewPosts;
        private System.Windows.Forms.CheckBox checkBoxRemmemberMe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxStatuses;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private System.Windows.Forms.RadioButton radioButtonLocation;
        private System.Windows.Forms.RadioButton radioButtonContent;
        private System.Windows.Forms.RadioButton radioButtonDate;
        private System.Windows.Forms.Label label10;
    }
}