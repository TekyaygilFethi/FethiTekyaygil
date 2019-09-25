using FethiTekyaygilWebsite.Data.GlobalDatas;
using System.Collections.Generic;

namespace FethiTekyaygilWebsite.Data.Language
{
    public class LanguageDictionary
    {
        private static readonly Dictionary<string, string> EnglishLanguage = new Dictionary<string, string>()
        {
            { "SuccessMessage","Success!" },
            { "ErrorMessage","An error occured! Please try again!"},
            { "HeaderTitle","Technology Consultant - Computer Engineer - .NET ~ Web Developer" },
            { "DeveloperSeperator","About Me" },
            { "TimelineSeperator","Timeline"},
            { "ProjectsSeperator","Projects"},
            { "HobbiesSeperator","Hobbies"},
            { "ProjectsSourceCodes","View Source Codes"},
            { "ProjectsAppStore","See on App Store"},
            { "ProjectsPlayStore","See on Play Store"},
            { "LanguagesSeperator","Languages"},
            { "CommunicationSkillsSeperator","Communication Skills"},
            { "WorkSkillsSeperator","Work Skills"},
            { "ContactMeSeperator","Contact Me"},
            { "ContactFormName","Name"},
            { "ContactFormMail","Mail"},
            { "ContactFormMessage","Message"},
            { "ContactFormSend","Send"},
            { "FollowMeSeperator","Follow Me"},
            { "LanguageChangeError","You already vieweing this page at this language!"},
            {"HobbyNavigator","Use <b> The Tiny Arrows That Takes Place At Left and Right</b> to navigate." },
            {"HobbySwipeNavigator","Or touch <b>left or right corner</b> of the screen to navigate." },
            { "SupportSeperator","Support"}
        };


        private static readonly Dictionary<string, string> TurkishLanguage = new Dictionary<string, string>()
        {
            { "SuccessMessage","Başarılı!" },
            { "ErrorMessage","Hata oluştu! Lütfen tekrar deneyin!!"},
            { "HeaderTitle","Teknoloji Danışmanı- Bilgisayar Mühendisi - .NET ~ Web Geliştirici" },
            { "DeveloperSeperator","Hakkımda" },
            { "TimelineSeperator","Zaman Çizelgesi"},
            { "ProjectsSeperator","Projeler"},
            { "HobbiesSeperator","Hobilerim"},
            { "ProjectsSourceCodes","Kaynak Kodlarını Görüntüle"},
            { "ProjectsAppStore","App Store'da Görüntüle"},
            { "ProjectsPlayStore","Play Store'da Görüntüle"},
            { "LanguagesSeperator","Diller"},
            { "CommunicationSkillsSeperator","İletişim Yetenekleri"},
            { "WorkSkillsSeperator","İş Yetenekleri"},
            { "ContactMeSeperator","Bana Ulaşın"},
            { "ContactFormName","İsim"},
            { "ContactFormMail","Mail"},
            { "ContactFormMessage","Mesaj"},
            { "ContactFormSend","Gönder"},
            { "FollowMeSeperator","Beni Takip Edin"},
            { "LanguageChangeError","Sayfayı zaten bu dilde görüntülüyorsunuz!"},
            {"HobbyNavigator","Navigasyon için <b>Sağda ve Solda Yer Alan Küçük Ok Tuşlarını</b> kullanınız." },
            {"HobbySwipeNavigator","Veya ekranın <b>sağ ve sol kısmına</b> dokunun." },
            { "SupportSeperator","Destek"}
        };

        public static string GetString(string key)
        {
            return Globals.Language == "EN" ? EnglishLanguage[key] : TurkishLanguage[key];
        }
    }
}
