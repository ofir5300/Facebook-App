namespace B20_Ex01_Ofir_307921320_Ilan_203442306
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
            this.components = new System.ComponentModel.Container();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            this.SuspendLayout();
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
            this.buttonGetTopCities.Location = new System.Drawing.Point(624, 248);
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
            this.pictureBoxProfilePicture.Click += new System.EventHandler(this.pictureBoxProfilePicture_Click);
            // 
            // listBoxTopCities
            // 
            this.listBoxTopCities.FormattingEnabled = true;
            this.listBoxTopCities.Location = new System.Drawing.Point(624, 277);
            this.listBoxTopCities.Name = "listBoxTopCities";
            this.listBoxTopCities.Size = new System.Drawing.Size(188, 121);
            this.listBoxTopCities.TabIndex = 4;
            this.listBoxTopCities.SelectedIndexChanged += new System.EventHandler(this.listBoxTopCities_SelectedIndexChanged);
            // 
            // labelStaticStatus
            // 
            this.labelStaticStatus.AutoSize = true;
            this.labelStaticStatus.Location = new System.Drawing.Point(9, 141);
            this.labelStaticStatus.Name = "labelStaticStatus";
            this.labelStaticStatus.Size = new System.Drawing.Size(43, 13);
            this.labelStaticStatus.TabIndex = 5;
            this.labelStaticStatus.Text = "Status: ";
            this.labelStaticStatus.Click += new System.EventHandler(this.label1_Click);
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
            this.label3.Location = new System.Drawing.Point(621, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "The cities you had posted from \r\nthe most, by descending order";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSearchPostByCity
            // 
            this.textBoxSearchPostByCity.Location = new System.Drawing.Point(624, 28);
            this.textBoxSearchPostByCity.Name = "textBoxSearchPostByCity";
            this.textBoxSearchPostByCity.Size = new System.Drawing.Size(127, 20);
            this.textBoxSearchPostByCity.TabIndex = 9;
            this.textBoxSearchPostByCity.TextChanged += new System.EventHandler(this.textBoxSearchPostByCity_TextChanged);
            // 
            // buttonSearchPostByCity
            // 
            this.buttonSearchPostByCity.Location = new System.Drawing.Point(757, 28);
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
            this.label4.Location = new System.Drawing.Point(621, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Find posts from specific city";
            // 
            // listViewPostByCity
            // 
            this.listViewPostByCity.HideSelection = false;
            this.listViewPostByCity.Location = new System.Drawing.Point(624, 55);
            this.listViewPostByCity.Name = "listViewPostByCity";
            this.listViewPostByCity.Size = new System.Drawing.Size(188, 141);
            this.listViewPostByCity.TabIndex = 13;
            this.listViewPostByCity.UseCompatibleStateImageBehavior = false;
            this.listViewPostByCity.SelectedIndexChanged += new System.EventHandler(this.listViewPostByCity_SelectedIndexChanged);
            // 
            // imageListPosts
            // 
            this.imageListPosts.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListPosts.ImageSize = new System.Drawing.Size(16, 16);
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
            this.label6.Location = new System.Drawing.Point(12, 226);
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
            this.labelGender.Click += new System.EventHandler(this.label9_Click);
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(76, 205);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(67, 13);
            this.labelBirthday.TabIndex = 19;
            this.labelBirthday.Text = "__________";
            this.labelBirthday.Click += new System.EventHandler(this.label10_Click);
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(76, 183);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(67, 13);
            this.labelFullName.TabIndex = 18;
            this.labelFullName.Text = "__________";
            this.labelFullName.Click += new System.EventHandler(this.label11_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Friends";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
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
            this.listViewPosts.Location = new System.Drawing.Point(222, 17);
            this.listViewPosts.Name = "listViewPosts";
            this.listViewPosts.Size = new System.Drawing.Size(378, 378);
            this.listViewPosts.TabIndex = 24;
            this.listViewPosts.UseCompatibleStateImageBehavior = false;
            this.listViewPosts.SelectedIndexChanged += new System.EventHandler(this.listViewPosts_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 410);
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
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
    }
}

