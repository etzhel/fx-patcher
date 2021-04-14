using System.Collections.Generic;

namespace FX.Patcher.Source_files
{
    class Texts
    {
        public enum Keys
        {
            UNKNOWNERROR,
            MISSINGBINARY,
            CANNOTSTART,
            NONETWORK,
            CONNECTING,
            LISTDOWNLOAD,
            CHECKFILE,
            DOWNLOADFILE,
            COMPLETEPROGRESS,
            CURRENTPROGRESS,
            CHECKCOMPLETE,
            DOWNLOADCOMPLETE,
            DOWNLOADSPEED
        }

        private static Dictionary<Keys, string> Text = new Dictionary<Keys, string>
        {
            {Keys.UNKNOWNERROR,                         "Bilinmeyen ancak kritik bir hata oluştu... Sorunu çözmeye yardımcı olabilecek hata mesajı: \n{0}"},
            {Keys.MISSINGBINARY,                        "{0} adlı dosya eksik olduğu için işlem tamamlanamadı."},
            {Keys.CANNOTSTART,                          "{0} adlı dosya erişilebilir olmadığı için işlem tamamlanamadı."},
            {Keys.NONETWORK,                            "Sunucuya bağlanılamıyor, lütfen internet bağlantınızı kontrol edin ve tekrar deneyin."},
            {Keys.CONNECTING,                           "Sunucuya bağlanılıyor..."},
            {Keys.LISTDOWNLOAD,                         "Dosya listesi indiriliyor..."},
            {Keys.CHECKFILE,                            "{0} kontrol ediliyor..."},
            {Keys.DOWNLOADFILE,                         "{0} indiriliyor... {1}/ {2}"},
            {Keys.COMPLETEPROGRESS,                     "İlerleme: {0}%"},
            {Keys.CURRENTPROGRESS,                      "Dosya başına ilerleme: {0}%  |  {1} kb/s"},
            {Keys.CHECKCOMPLETE,                        "Tüm dosyalar düzgün bir şekilde kontrol edildi."},
            {Keys.DOWNLOADCOMPLETE,                     "Tüm dosyalar düzgün bir şekilde indirildi."},
            {Keys.DOWNLOADSPEED,                        "{0} kb/s"}
        };

        public static string GetText(Keys Key, params object[] Arguments)
        {
            foreach (KeyValuePair<Keys, string> currentItem in Text)
            {
                if (currentItem.Key == Key)
                {
                    return string.Format(currentItem.Value, Arguments);
                }
            }

            return null;
        }
    }
}
