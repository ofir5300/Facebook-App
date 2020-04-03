using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace B20_Ex01_Ofir_307921320_Ilan_203442306
{
    public partial class MainForm : Form
    {
        private FacebookApp m_facebookApp;

        public MainForm(FacebookApp i_facebookApp)
        {
            this.m_facebookApp = i_facebookApp;
            InitializeComponent();

            // this.StartPosition = FormStartPosition.Manual;
            AppSettings appSettings = m_facebookApp.GetAppSettings();
            this.checkBoxRemmemberMe.Checked = appSettings.RemmemberUser;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            bool isConnected = m_facebookApp.ConnectUser();
            if (isConnected)
            {
                initUserUIData();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            bool remmemberMe = this.checkBoxRemmemberMe.Checked;
            m_facebookApp.ShutDown(remmemberMe);
        }

        private void buttonGetAccessToken_Click(object sender, EventArgs e)
        {
            m_facebookApp.LoginUser();
            initUserUIData();
        }

        private void fetchUserFriends()
        {
            FacebookObjectCollection<User> userFriends = m_facebookApp.GetFriends();
            foreach (User friend in userFriends)
            {
                this.listBoxFriends.Items.Add(friend.FirstName + " " + friend.LastName);
            }
        }

        private void fetchUserPosts()
        {
            FacebookObjectCollection<Post> userPosts = m_facebookApp.GetPosts();
            foreach(Post post in userPosts)
            {
                addPostToListView(listViewPosts, post);
            }
        }

        private void initUserUIData()
        {
            fetchUserAbout();
            fetchUserFriends();
            fetchUserPosts();
        }

        private void fetchUserAbout()
        {
            User loggedInUser = m_facebookApp.GetLoggedInUser();
            labelConnectionStatus.Text = "Connected";
            pictureBoxProfilePicture.Load(loggedInUser.PictureNormalURL);
            labelFullName.Text = loggedInUser.FirstName + " " + loggedInUser.LastName;
            labelBirthday.Text = loggedInUser.Birthday;
            labelGender.Text = loggedInUser.Gender.Value.ToString();
            this.Text = "Logged in as " + loggedInUser.FirstName + " " + loggedInUser.LastName;
        }

        private void buttonGetTopCities_Click(object sender, EventArgs e)
        {
            List<KeyValuePair<string, int>> orderedList = m_facebookApp.GetTopCities();
            foreach (KeyValuePair<string, int> location in orderedList)
            {
                listBoxTopCities.Items.Add(location.Key);
            }
        }

        private void buttonSearchPostByCity_Click(object sender, EventArgs e)
        {
            string searchedValue = textBoxSearchPostByCity.Text.ToLower();
            FacebookObjectCollection<Post> userPosts = m_facebookApp.GetPosts();
            foreach (Post post in userPosts)
            {
                if (post.Place != null && post.Place.Location != null && post.Place.Location.City != null)
                {
                    string location = post.Place.Location.City.ToLower();
                    if (searchedValue.Equals(location))
                    {
                        addPostToListView(listViewPostByCity, post);
                    }
                }
            }
        }

        private void addPostToListView(ListView i_listView, Post i_post)
        {
            if (i_post.Type == Post.eType.photo)
            {
                Bitmap bitmap;
                using (WebClient client = new WebClient())
                {
                    Stream stream = client.OpenRead(i_post.PictureURL);
                    bitmap = new Bitmap(stream);
                }

                imageListPosts.Images.Add(i_post.PictureURL, bitmap);

                imageListPosts.ImageSize = new Size(64, 64);
                imageListPosts.ColorDepth = ColorDepth.Depth32Bit;
                i_listView.View = View.LargeIcon;

                i_listView.LargeImageList = imageListPosts;
                string postMessage = i_post.Message != null ? i_post.Message : string.Empty;
                i_listView.Items.Add(postMessage, i_post.PictureURL);
            }
            else if(!string.IsNullOrEmpty(i_post.Message))
            {
                i_listView.Items.Add(i_post.Message);
            }
        }
    }
}