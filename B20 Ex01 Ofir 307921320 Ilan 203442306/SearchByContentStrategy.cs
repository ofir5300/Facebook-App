using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B20_Ex01_Ofir_307921320_Ilan_203442306
{
    public class SearchByContentStrategy : ISearchPostStrategy
    {
        public List<Post> search(FacebookObjectCollection<Post> userPosts, string searchedValue)
        {
            List<Post> values = new List<Post>();
            foreach (Post post in userPosts)
            {
                if (post.Message != null)
                {
                    String message = post.Message.ToLower();
                    if (message.Contains(searchedValue))
                    {
                        values.Add(post);
                    }
                }
            }

            return values;
        }
    }
}
