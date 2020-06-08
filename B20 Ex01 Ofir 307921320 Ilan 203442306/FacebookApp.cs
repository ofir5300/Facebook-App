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
        public AppSettings m_AppSettings;
        public User m_LoggedInUser;
        private string m_accessToken; 

        public FacebookApp()
        {
            this.m_AppSettings = AppSettings.Load();
        }

        public void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(this));
        }

        public void LoginUser()
        {
            LoginResult result = FacebookService.Login("209512230370639", "user_friends", "user_posts", "user_birthday", "user_gender", "user_likes");
            this.m_LoggedInUser = result.LoggedInUser;
            this.m_accessToken = result.AccessToken;
        }

        public bool ConnectUser()
        {
            if (m_AppSettings.RemmemberUser && !string.IsNullOrEmpty(m_AppSettings.AccessToken))
            {
                LoginResult result = FacebookService.Connect(m_AppSettings.AccessToken);
                this.m_LoggedInUser = result.LoggedInUser;
                this.m_accessToken = result.AccessToken;
                return true;
            }

            return false;
        }

        public void ShutDown(bool i_remmemberMe)
        {
            m_AppSettings.RemmemberUser = i_remmemberMe;
            m_AppSettings.AccessToken = i_remmemberMe ? this.m_accessToken : null;
            m_AppSettings.SaveToFile();
        }

        public List<KeyValuePair<string, int>> GetTopCities()
        {
            Dictionary<string, int> topCitiesMap = new Dictionary<string, int>();
            FacebookObjectCollection<Post> userPosts = this.GetPosts();
            foreach (Post post in userPosts)
            {
                if (post.Place != null && post.Place.Location != null && post.Place.Location.City != null)
                {
                    string location = post.Place.Location.City;
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

            List<KeyValuePair<string, int>> o_citiesList = topCitiesMap.ToList<KeyValuePair<string, int>>();
            o_citiesList.Sort((locationA, locationB) => locationB.Value.CompareTo(locationA.Value));

            return o_citiesList.GetRange(0, 3);
        }

        public FacebookObjectCollection<Post> GetPosts()
        {
            return this.m_LoggedInUser.Posts;
        }

        public FacebookObjectCollection<Status> GetStatuses()
        {
            FacebookObjectCollection<Status> nonEmptyStatuses = new FacebookObjectCollection<Status>();
            FacebookObjectCollection<Status> statuses = this.m_LoggedInUser.Statuses;

            foreach(Status status in statuses)
            {
                if (status.Message != null)
                {
                    nonEmptyStatuses.Add(status);
                }
            }

            return nonEmptyStatuses;
        }

        public FacebookObjectCollection<User> GetFriends()
        {
            return this.m_LoggedInUser.Friends;
        }

        public User GetLoggedInUser()
        {
            return this.m_LoggedInUser;
        }

        public AppSettings GetAppSettings()
        {
            return this.m_AppSettings;
        }
    }
}
