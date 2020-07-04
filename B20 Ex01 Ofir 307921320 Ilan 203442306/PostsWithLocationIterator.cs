using FacebookWrapper.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B20_Ex01_Ofir_307921320_Ilan_203442306
{
    public class PostsWithLocationIterator : IEnumerator
    {
        private IEnumerator<Post> m_curr = null;
        private IEnumerator<Post> m_listCurr;
        object IEnumerator.Current => this.m_curr;

        public PostsWithLocationIterator(ICollection<Post> i_postsList)
        {
            this.m_listCurr = i_postsList.GetEnumerator();
        }

        public Post Current()
        {
            if(this.m_curr == null)
            {
                return null;
            }
            else
            {
                return this.m_curr.Current;
            }
        }

        public bool MoveNext()
        {
            return findNextPostWithLocation();
        }

        private bool findNextPostWithLocation()
        {
            this.m_curr = null;
            while (this.m_listCurr.MoveNext())
            {
                if (isPostWithLocation(this.m_listCurr) && (this.m_listCurr != this.m_curr))
                {
                    this.m_curr = this.m_listCurr;
                    break;
                }
            }
            return this.m_curr != null;
        }

        private bool isPostWithLocation(IEnumerator<Post> itr)
        {
            Post post = itr.Current;
            return (post.Place != null && post.Place.Location != null && post.Place.Location.City != null);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
