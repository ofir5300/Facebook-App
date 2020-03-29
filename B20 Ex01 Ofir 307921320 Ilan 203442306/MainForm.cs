﻿using System;
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
        FacebookApp facebookApp;
        //User loggedInUser;

        public MainForm(FacebookApp facebookApp)
        {
            this.facebookApp = facebookApp;
            InitializeComponent();
        }


        private void buttonGetAccessToken_Click(object sender, EventArgs e)
        {
            facebookApp.loginUser();
            initUserUIData();
            fetchUserPosts();
        }

        private void fetchUserPosts()
        {
            FacebookObjectCollection<Post> userPosts = facebookApp.getPosts();
            foreach(Post post in userPosts)
            {
                addPostToListView(listViewPosts, post);
            }
        }

        private void initUserUIData()
        {
            User loggedInUser = facebookApp.getLoggedInUser();
            labelConnectionStatus.Text = "Connected";
            pictureBoxProfilePicture.Load(loggedInUser.PictureNormalURL);
            labelFullName.Text = loggedInUser.FirstName + " " + loggedInUser.LastName;
            labelBirthday.Text = loggedInUser.Birthday;
            labelGender.Text = loggedInUser.Gender.Value.ToString();
            //labelRelationsipStatus.Text = loggedInUser.RelationshipStatus.Value.ToString();
        }

        private void buttonGetTopCities_Click(object sender, EventArgs e)
        {
            //facebookApp.getTopCities();
            Dictionary<String, int> i_topCitiesMap = new Dictionary<string, int>();
            FacebookObjectCollection<Post> userPosts = facebookApp.getPosts();
            foreach (Post post in userPosts)
            {
                if (post.Place != null && post.Place.Location != null && post.Place.Location.City != null)
                {
                    String location = post.Place.Location.City;
                    int value = 1;
                    if (i_topCitiesMap.ContainsKey(location))
                    {
                        value = i_topCitiesMap[location];
                        i_topCitiesMap[location] = ++value;
                    }
                    else
                    {
                        i_topCitiesMap.Add(location, value);
                    }
                    listBoxTopCities.Items.Add(location);
                }
            }
            i_topCitiesMap["Taba"] = 4;
            i_topCitiesMap.OrderBy(record => record.Value);
            IOrderedEnumerable< KeyValuePair<String, int>> ordered = i_topCitiesMap.OrderBy(record => record.Value);
            /////////////////////////// find 3 or 5 highest values adn add them to listBoxTopCities
            var iterator = ordered.GetEnumerator();

            //listBoxTopCities.Items.Add(i_toCitiesMap....);
        }


        private void buttonSearchPostByCity_Click(object sender, EventArgs e)
        {
            String searchedValue = textBoxSearchPostByCity.Text;
            FacebookObjectCollection<Post> userPosts = facebookApp.getPosts();
            foreach (Post post in userPosts)
            {
                if (post.Place != null && post.Place.Location != null && post.Place.Location.City != null)
                {
                    String location = post.Place.Location.City;
                    if (searchedValue.Equals(location))
                    {
                        addPostToListView(listViewPostByCity, post);
                    }
                }
            }
        }

        private void addPostToListView(ListView listView, Post post)
        {
            if (post.Type == Post.eType.photo)
            {
                Bitmap bitmap;
                using (WebClient client = new WebClient())
                {
                    Stream stream = client.OpenRead(post.PictureURL);
                    bitmap = new Bitmap(stream);
                }
                imageListPosts.Images.Add(post.PictureURL, bitmap);

                imageListPosts.ImageSize = new Size(64, 64);
                imageListPosts.ColorDepth = ColorDepth.Depth32Bit;
                listView.View = View.LargeIcon;

                listView.LargeImageList = imageListPosts;
                String postMessage = post.Message != null ? post.Message : String.Empty;
                listView.Items.Add(postMessage, post.PictureURL);
            }
            else
            {
                listView.Items.Add(post.Message);
            }
        }

        //////////////////////////////////////////////
        ///
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxTopCities_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void pictureBoxProfilePicture_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void listBoxPostsByCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBoxSearchPostByCity_TextChanged(object sender, EventArgs e)
        {

        }
        private void listViewPostByCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void label8_Click_1(object sender, EventArgs e)
        {

        }
        private void listViewPosts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}