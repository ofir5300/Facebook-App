using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B20_Ex01_Ofir_307921320_Ilan_203442306
{
    interface ISearchPostStrategy
    {
        List<Post> search(FacebookObjectCollection<Post> userPosts, string searchedValue);
    }
}
