using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B20_Ex01_Ofir_307921320_Ilan_203442306
{
    public class PostsWithLocationCollection : FacebookObjectCollection<Post>
    {
        private FacebookObjectCollection<Post> m_postsCollection = null;
        private PostsWithLocationIterator m_iterator;

        public PostsWithLocationCollection(FacebookObjectCollection<Post> i_postsCollection)
        {
            this.m_postsCollection = i_postsCollection;
            this.m_iterator = new PostsWithLocationIterator(this.m_postsCollection);
        }

        public PostsWithLocationIterator GetIterator()
        {
            return this.m_iterator;
        }
    }
}
