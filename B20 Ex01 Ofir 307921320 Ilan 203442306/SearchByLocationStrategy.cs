using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B20_Ex01_Ofir_307921320_Ilan_203442306
{
    public class SearchByLocationStrategy : ISearchPostStrategy
    {
        public List<Post> search(FacebookObjectCollection<Post> userPosts, string searchedValue)
        {
            List<Post> values = new List<Post>();
            PostsWithLocationCollection postsWithLocationCollection = new PostsWithLocationCollection(userPosts);
            PostsWithLocationIterator postsIterator = postsWithLocationCollection.GetIterator();

            while (postsIterator.MoveNext())
            {
                Post post = postsIterator.Current();
                string location = post.Place.Location.City.ToLower();
                if (searchedValue.Equals(location))
                {
                    values.Add(post);
                }
            }

            /*
            foreach (Post post in userPosts)
            {
                if (post.Place != null && post.Place.Location != null && post.Place.Location.City != null)
                {
                    string location = post.Place.Location.City.ToLower();
                    if (searchedValue.Equals(location))
                    {
                        values.Add(post);
                    }
                }
            }
            */
            return values;
        }
    }
}
