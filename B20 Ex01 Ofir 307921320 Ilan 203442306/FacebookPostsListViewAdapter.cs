using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace B20_Ex01_Ofir_307921320_Ilan_203442306
{
    public class FacebookPostsListViewAdapter //  use of adapter pattern
    {

        private ListView m_listView;
        public ListView ListViewDestination
        {
            get { return this.m_listView; }
            set
            {
                m_listView = value;
                this.m_listViewAdoptee.ListViewDestination = m_listView;
            }
        }
        private ImageList m_imageList;
        public ImageList ImageListSource
        {
            get { return this.m_imageList; }
            set
            {
                m_imageList = value;
                this.m_listViewAdoptee.ImageListSource = m_imageList;
            }
        }
        private ListViewFacade m_listViewAdoptee;

        public FacebookPostsListViewAdapter()
        {
            this.m_listViewAdoptee = new ListViewFacade();
        }

        public void AddPostToListView(Post i_post)
        {
            if (ListViewDestination != null)
            {
                if (i_post.Type == Post.eType.photo && ImageListSource != null)
                {
                    m_listViewAdoptee.AddPictureAndMessageToListView(i_post.PictureURL, i_post.Message);
                }
                else if (!string.IsNullOrEmpty(i_post.Message))
                {
                    m_listViewAdoptee.AddMessageToListView(i_post.Message);
                }
            }
        }
    }
}
