using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace B20_Ex01_Ofir_307921320_Ilan_203442306
{
    public class UserProxy
    {
        public User User { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}]: {1} {2}", User.Birthday, User.LastName, User.FirstName);
        }
    }
}
