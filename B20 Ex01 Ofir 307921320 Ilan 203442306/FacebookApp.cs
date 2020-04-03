using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace B20_Ex01_Ofir_307921320_Ilan_203442306
{
    public class FacebookApp
    {
        private User loggedInUser;
        String accessToken; ///      /// //////////////////////

        public void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(this));
        }

        public void loginUser()
        {
            LoginResult result = FacebookService.Login("209512230370639", "user_photos", "user_friends", "user_posts", "user_birthday", "user_hometown", "user_status", "user_gender");
            this.loggedInUser = result.LoggedInUser;
            this.accessToken = result.AccessToken;  /////// check if neccassary
        }

        public User getLoggedInUser()
        {
            return this.loggedInUser;
        }

        public FacebookObjectCollection<Post> getPosts()
        {
            return this.loggedInUser.Posts;
        }

        public List<KeyValuePair<String, int>> getTopCities()
        {
            Dictionary<String, int> topCitiesMap = new Dictionary<string, int>();
            FacebookObjectCollection<Post> userPosts = this.getPosts();
            foreach (Post post in userPosts)
            {
                if (post.Place != null && post.Place.Location != null && post.Place.Location.City != null)
                {
                    String location = post.Place.Location.City;
                    int value = 1;
                    if (topCitiesMap.ContainsKey(location))
                    {
                        value = topCitiesMap[location];
                        topCitiesMap[location] = ++value;
                    }
                    else
                    {
                        topCitiesMap.Add(location, value);
                    }
                }
            }
            List<KeyValuePair<string, int>> orderedList = topCitiesMap.ToList<KeyValuePair<string, int>>();
            orderedList.Sort((locationA, locationB) => locationB.Value.CompareTo(locationA.Value));

            return orderedList.GetRange(0, 3);
        }

    }
}
