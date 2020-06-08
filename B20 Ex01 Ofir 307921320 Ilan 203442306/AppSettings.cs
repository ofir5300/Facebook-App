using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace B20_Ex01_Ofir_307921320_Ilan_203442306
{
    public sealed class AppSettings
    {
        public static AppSettings Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new AppSettings();
                }

                return s_instance;
            }
        }

        public bool RemmemberUser { get; set; }

        public string AccessToken { get; set; }

        private static AppSettings s_instance = null;

        private AppSettings()
        {
            this.AccessToken = string.Empty;
            this.RemmemberUser = false;
        }

        public static AppSettings Load()
        {
            AppSettings o_appSettings = AppSettings.Instance;
            if (File.Exists(@"./AppSettings.xml"))
            {
                using (Stream stream = new FileStream(@"./AppSettings.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    o_appSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }

            s_instance = o_appSettings;

            return o_appSettings;
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(@"./AppSettings.xml", FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                serializer.Serialize(stream, this);
            }
        }
    }
}
