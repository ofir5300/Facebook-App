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
        User loggedInUser;
        String accessToken;

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
            this.accessToken = result.AccessToken;
        }

        public User getLoggedInUser()
        {
            return this.loggedInUser;
        }

        public FacebookObjectCollection<Post> getPosts()
        {
            return this.loggedInUser.Posts;
        }
    }
}
