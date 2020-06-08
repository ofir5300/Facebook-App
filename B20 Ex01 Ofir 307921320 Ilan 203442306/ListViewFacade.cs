using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace B20_Ex01_Ofir_307921320_Ilan_203442306
{
    public class ListViewFacade //  Legacy Component
    {
        public ListView ListViewDestination { get; set; }
        public ImageList ImageListSource { get; set; }

        public void AddMessageToListView(string i_message)
        {
            if (!string.IsNullOrEmpty(i_message) && ListViewDestination != null)
            {
                ListViewDestination.Invoke(new Action(() => ListViewDestination.Items.Add(i_message)));
            }
            else if (ListViewDestination == null)
            {
                throw new Exception("There is no ListView to design. Please assign ListView");
            }
        }

        public void AddPictureToListView(string i_pictureURL)
        {
            AddPictureAndMessageToListView(i_pictureURL, "");
        }

        public void AddPictureAndMessageToListView(string i_pictureURL, string i_message)
        {
            if (ListViewDestination != null && ImageListSource != null)
            {
                Bitmap bitmap;
                using (WebClient client = new WebClient())
                {
                    Stream stream = client.OpenRead(i_pictureURL);
                    bitmap = new Bitmap(stream);
                }

                ListViewDestination.Invoke(new Action(() =>
                {
                    ImageListSource.Images.Add(i_pictureURL, bitmap);

                    ListViewDestination.View = View.LargeIcon;
                    ListViewDestination.LargeImageList = ImageListSource;       // imageList as pictures data source
                    ListViewDestination.Items.Add(i_message, i_pictureURL);     //  load message and picture to listView
                }));
            }
            else if (ListViewDestination == null)
            {
                throw new Exception("There is no ListView to design. Please assign ListView");
            }
            else if (ImageListSource == null)
            {
                throw new Exception("Cannot add Pictures to ListView without using ImageList. Please Assign ImageListSource");
            }
        }
    }
}
