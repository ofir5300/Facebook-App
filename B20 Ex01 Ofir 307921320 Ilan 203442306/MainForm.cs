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
using System.Threading;
using B20_Ex01_Ofir_307921320_Ilan_203442306;

namespace B20_Ex01_Ofir_307921320_Ilan_203442306
{
    public partial class MainForm : Form
    {
        private FacebookApp m_facebookApp;

        public MainForm(FacebookApp i_facebookApp)
        {
            this.m_facebookApp = i_facebookApp;
            InitializeComponent();

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
                this.listBoxFriends.Invoke(new Action(() => this.listBoxFriends.Items.Add(new UserProxy { User = friend })));
            }
        }

        private void fetchUserPosts()
        {
            FacebookObjectCollection<Post> userPosts = m_facebookApp.GetPosts();
            foreach (Post post in userPosts)
            {
                addPostToListView(listViewPosts, post);
            }
        }

        private void fetchUserStatuses()
        {
            listBoxStatuses.Invoke(new Action(() => statusBindingSource.DataSource = m_facebookApp.GetStatuses()));
        }

        private void initUserUIData()
        {
            new Thread(fetchUserAbout).Start();
            new Thread(fetchUserFriends).Start();
            new Thread(fetchUserPosts).Start();
            new Thread(fetchUserStatuses).Start();
        }

        private void fetchUserAbout()
        {
            User loggedInUser = m_facebookApp.GetLoggedInUser();

            //  invoke UI components actions by the thread created it 
            labelConnectionStatus.Invoke(new Action(() => labelConnectionStatus.Text = "Connected" ));
            pictureBoxProfilePicture.Invoke(new Action(() => pictureBoxProfilePicture.Load(loggedInUser.PictureNormalURL) ));
            labelFullName.Invoke(new Action(() => labelFullName.Text = loggedInUser.FirstName + " " + loggedInUser.LastName ));
            labelBirthday.Invoke(new Action(() => labelBirthday.Text = loggedInUser.Birthday ));
            labelGender.Invoke(new Action(() => labelGender.Text = loggedInUser.Gender.Value.ToString() ));
            this.Invoke(new Action(() => this.Text = "Logged in as " + loggedInUser.FirstName + " " + loggedInUser.LastName ));
        }

        private void buttonGetTopCities_Click(object sender, EventArgs e)
        {
            List<KeyValuePair<string, int>> orderedList = m_facebookApp.GetTopCities();
            listBoxTopCities.Items.Clear();
            foreach (KeyValuePair<string, int> location in orderedList)
            {
                listBoxTopCities.Items.Add(location.Key);
            }
        }

        private void buttonSearchPostByCity_Click(object sender, EventArgs e)
        {
            string searchedValue = textBoxSearchPostByCity.Text.ToLower();
            bool valueFound = false;
            FacebookObjectCollection<Post> userPosts = m_facebookApp.GetPosts();

            listViewPostByCity.Items.Clear();
            foreach (Post post in userPosts)
            {
                if (post.Place != null && post.Place.Location != null && post.Place.Location.City != null)
                {
                    string location = post.Place.Location.City.ToLower();
                    if (searchedValue.Equals(location))
                    {
                        addPostToListView(listViewPostByCity, post);
                        valueFound = true;
                    }
                }
            }

            if (!valueFound)
            {
                listViewPostByCity.Items.Add(String.Format("No post from {0}", searchedValue));
            }
        }

        private void addPostToListView(ListView i_listView, Post i_post)
        {
            FacebookPostsListViewAdapter listViewAdapter = new FacebookPostsListViewAdapter
            {
                ListViewDestination = i_listView,
                ImageListSource = imageListPosts
            };
            listViewAdapter.AddPostToListView(i_post);
        }

        private void listViewPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPosts.SelectedItems.Count > 0 && listViewPosts.SelectedItems[0] != null)
            {
                object selectedItem = listViewPosts.SelectedItems[0];
            }
            // m_facrbookApp.getPosts search reference by photoUrl, not found -> search by post text
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void postBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void statusBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }


    }
    public class UserProxy
    {
        public User User { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}]: {1} {2}", User.Birthday, User.LastName, User.FirstName);
        }
    }


}




