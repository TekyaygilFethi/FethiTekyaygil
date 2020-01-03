using FethiTekyaygilWebsite.Data.POCOs;
using FethiTekyaygilWebsite.Database.DatabaseContextFolder;

namespace FethiTekyaygilWebsite.Console
{
    class Program
    {
        //private static readonly string imageFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "\\FethiTekyaygilWebsite.Data\\Media";

        static void Main(string[] args)
        {
            AddEducations();
            AddExperiences();
            AddProjects();
            AddLanguages();
            AddDeveloper();
            AddHobbies();
        }

        #region CREATE
        static void AddEducations()
        {
            using (var context = new GenericDatabaseContext())
            {
                Education edu1 = new Education()
                {
                    EnglishSchool = "Nilüfer Hatun Primary School",
                    TurkishSchool = "Nilüfer Hatun İlköğretim Okulu",
                    EnglishDepartment = "Primary School Student",
                    TurkishDepartment = "İlköğretim Öğrencisi",
                    StartDate = new System.DateTime(2000, 08, 01),
                    EndDate = new System.DateTime(2010, 02, 01),
                    ImageName = "\\Education\\NH.jpg",
                    //Image = ImageHelper.ConvertToBLOB(imageFolder + "\\Education\\NH.jpg"),
                    //ImageExt = "jpg",
                    IsPresent = false,
                    TurkishAddress = "Teşvikiye, Vali Konağı Caddesi Şakayık Sokak No:50, 34365 Şişli/İstanbul",
                    EnglishAddress = "Teşvikiye, Vali Konağı Distinct Şakayık Street No:50, 34365 Şişli/İstanbul",
                    WebSite = "http://niluferhatunilkokulu.meb.k12.tr/",

                    TurkishExplanation = $"Anaokulu dahil ilk 8.sınıfın ilk yarısı da dahil Nilüfer Hatun İlköğretim okulunda eğitim hayatıma başladım." +
                    $"<br/>" +
                    $"<b>Aldığım Belgeler:</b>" +
                    $"<font color=\"red\"><i>" +
                    $"<br/> " +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i> 23 Nisan Ulusal Egemenlik ve Çocuk Bayramı Etkinliğine Katılım Belgesi." +
                    $"<br/> " +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i> Okulun sosyal, eğitsel ve sportif etkinliklerinde gösterilen başarı ve sağlanılan katılım belgesi." +
                    $"<br/> " +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>\"10 Güzel Eser\" isimli kitap okuma yarışmasına katılım belgesi." +
                    $"</i>" +
                    $"</font>",

                    EnglishExplanation = $"I started my education life at Nilüfer Hatun Primary School until first semester of 8th grade including the kidergarten." +
                    $"<br/>" +
                    $"<b>Gained Certificates:</b>" +
                    $"<font color=\"red\"><i>" +
                    $"<br/> " +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i> Participation certificate for attending 23th April National Sovereignty and Children's Day Event." +
                    $"<br/> " +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i> Succession and participation certificate for school's social, educational and sportive events." +
                    $"<br/> " +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>)Participation certificate for reading contest named \"10 Beautiful Piece\"." +
                    $"</i>" +
                    $"</font>",

                };

                Education edu2 = new Education()
                {
                    EnglishSchool = "Esenkent Atatürk Primary School",
                    TurkishSchool = "Esenkent Atatürk İlköğretim Okulu",
                    EnglishDepartment = "Primary School Student",
                    TurkishDepartment = "İlköğretim Öğrencisi",
                    StartDate = new System.DateTime(2010, 02, 01),
                    EndDate = new System.DateTime(2010, 06, 01),
                    ImageName = "\\Education\\EA.jpg",
                    //ImageExt = "jpg",
                    IsPresent = false,
                    TurkishAddress = "Esenkent, Enver Paşa Caddesi Onur Güvener Sokak No:1, 34510 Esenyurt/İstanbul",
                    EnglishAddress = "Esenkent, Enver Paşa District Onur Güvener Street No:1, 34510 Esenyurt/İstanbul",
                    WebSite = "http://esenkentataturkilkokulu.meb.k12.tr/",

                    TurkishExplanation = $"8.sınıfın ilk yarısının sonlarına doğru geçtiğim Esenkent Atatürk İlköğretim okulundan başarıyla mezun olup lise hayatının temellerini sağlam attım." +
                    $"<br/>" +
                    $"<b>Aldığım Belgeler:</b>" +
                    $"<font color=\"red\"><i>" +
                    $"<br/> " +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i> İki dönemde de Onur Belgesi." +
                    $"</i>" +
                    $"</font>",

                    EnglishExplanation = $"I successfully graduated from Esenkent Atatürk Primary School which I transferred at the end of the first semester." +
                    $"<br/>" +
                    $"<b>Gained Certificates:</b>" +
                    $"<font color=\"red\"><i>" +
                    $"<br/> " +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i> Honour Certificate at both of the semesters." +
                    $"</i>" +
                    $"</font>",

                };

                Education edu3 = new Education()
                {
                    EnglishSchool = "Okyanus College",
                    TurkishSchool = "Okyanus Koleji",
                    EnglishDepartment = "High School Student",
                    TurkishDepartment = "Lise Öğrencisi",
                    StartDate = new System.DateTime(2010, 08, 01),
                    EndDate = new System.DateTime(2014, 02, 01),//BURADA KALDIN
                    ImageName = "\\Education\\OK.jpg",
                    //ImageExt = "jpg",
                    IsPresent = false,
                    TurkishAddress = "Esenkent, Talat Paşa Caddesi Yeşil Irmak Sokak No:1, 34510 Esenyurt/İstanbul",
                    EnglishAddress = "Esenkent, Talat Paşa District Yeşil Irmak Street No:1, 34510 Esenyurt/İstanbul",
                    WebSite = "https://www.okyanuskoleji.k12.tr",

                    TurkishExplanation = $"Lise hayatım başladığım Okyanus Koleji bana hem kendimi yazılım ve donanım alanında geliştirebilme fırsatı hem de yeni ve temeli sağlam arkadaşlıklar kazandırdı." +
                    $"<br/>" +
                    $"<b>Aldığım Belgeler:</b>" +
                    $"" +
                    $"<br /><i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>2 adet Başarı Belgesi." +
                    $"<br/><i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>26 Mayıs 2012 tarihli Ora Arena'da gerçekleştirilen <b>\"En Fazla Model İle Podyuma Çıkma Guiness Rekoru\"</b> etkinliğine katılım Belgesi." +
                    $"<br/><i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>İngilizce Drama Kulübü Katılım Belgesi." +
                    $"<br/><i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>Bilgisayar Kulübü Katılım Belgesi.",

                    EnglishExplanation = $"Okyanus College gave me the chance of improve myself at software and hardware areas and also give me friendships that is durable forever as the first school of my high school education" +
                    $"<br/>" +
                    $"<b>Gained Certificates:</b>" +
                    $"<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>2 Success Certificates.<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>Participation certificate to the event of \"Walking on the podium with the most model.\" which takes place at 26th May 2012 at Ora Arena.<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>Participation certificate to English Drama Club<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>Participation certificate to Computer Club<br/>",
                };

                Education edu4 = new Education()
                {
                    EnglishSchool = "Bahcesehir Ataturk Anatolian High School",
                    TurkishSchool = "Bahçeşehir Atatürk Anadolu Lisesi",
                    EnglishDepartment = "High School Student",
                    TurkishDepartment = "Lise Öğrencisi",
                    StartDate = new System.DateTime(2014, 02, 01),
                    EndDate = new System.DateTime(2014, 08, 01),//BURADA KALDIN
                    ImageName = "\\Education\\BAAL.JPG",
                    //ImageExt = "JPG",
                    IsPresent = false,
                    TurkishAddress = "Bahçeşehir 2. Kısım, Şelale Caddesi, Ata Sokağı No 3/2, 34538 Başakşehir/İstanbul",
                    EnglishAddress = "Bahçeşehir 2. Section, Şelale District, Ata Street No 3/2, 34538 Başakşehir/İstanbul",
                    WebSite = "http://bahata.meb.k12.tr/",

                    TurkishExplanation = $"12.sınıfta eğitim hayatıma Bahçeşehir Atatürk Anadolu Lisesi'nde devam ettim.",


                    EnglishExplanation = $"Ath 12th grade, I continued my education life at Bahçeşehir Atatürk Anatolian High School"
                };

                Education edu5 = new Education()
                {
                    EnglishSchool = "Kemerburgaz / Altınbaş University",
                    TurkishSchool = "Kemerburgaz / Altınbaş Üniversitesi",
                    EnglishDepartment = "Computer Engineering Department Bachelor Student",
                    TurkishDepartment = "Bilgisayar Mühendisliği Departmanı Lisans Öğrencisi",
                    StartDate = new System.DateTime(2014, 08, 01),
                    EndDate = new System.DateTime(2018, 06, 01),//BURADA KALDIN
                    ImageName = "\\Education\\AU.jpg",
                    //ImageExt = "jpg",
                    IsPresent = false,
                    TurkishAddress = "Mahmutbey, Mahmutbey Dilmenler Caddesi Mahmutbey Yerleşkesi No:26, 34218 Bağcılar/İstanbul",
                    EnglishAddress = "Mahmutbey, Mahmutbey Dilmenler District Mahmutbey Campus No:26, 34218 Bağcılar/İstanbul",
                    WebSite = "http://www.altinbas.edu.tr/tr",

                    TurkishExplanation = $"2014 yılında %75 bursla kazandığım Kemerburgaz Üniversitesi Bilgisayar Mühendisliği bölümüyle beraber üniversite hayatına giriş yaptım. Eğitim hayatım süresince ismini Altınbaş Üniversitesi olarak değiştiren okulumda kendimi mesleki ve sosyal alanlarda geliştirme fırsatına eriştim." +
                    $"<br/>" +
                   $"<i class=\"fas fa-arrow-right\"></i>Mesleki Dersler:" +
                    $"<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>İlişkisel Veritabanı Dersi<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>Yazılım Mühendisliği Dersi<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>C Dersi<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>Java OOP Dersi<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>Algoritmalar Dersi<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>İşletim Sistemleri Dersi<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>Yapay Zeka Dersi<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>Web Servisleri Dersi<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>Web Teknolojileri Dersi<br/>" +
                    $"<br/>" +
                   $"<i class=\"fas fa-arrow-right\"></i>Projeler:" +
                    $"<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>DFS Algoritması kullanılarak çözülen NQueens Winforms uygulaması.(Yapay Zeka Dersi)<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>Min - Max Algoritması kullanılarak oluşturulan TicTacToe Winforms uygulaması.(Yapay Zeka Dersi)<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>Last Man Standing C# konsol uygulaması.(Yapay Zeka Dersi)</br>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>ASP.NET MVC ile geliştirilmiş Alışveriş Sitesi.(Web Teknolojileri Dersi)<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i> Bitirme Projesi için, Forum, Canlı Chat, Ekran Paylaşımı ve Not Hesaplama özelliklerini içeren uygulama:" +
                    $"<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:10em\"></i>Veritabanı için Entity Framework Code First teknolojisi kullanılırken, Generic Repository ve Unit Of Work Tasarımm Kalıpları kullanılmıştır.<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:10em\"></i>Front - end geliştirme için Bootstrap, jQuery ve AJAX teknolojileri kullanıldı.",


                    EnglishExplanation = $"I started my university life with Kemerburgaz University Computer Engineering Department which I've won with 75% scholarship at 2014. During my education life at university which renamed as \"Altınbaş\" University, I've seen and experienced many vocatinal, social areas and had the chance of improving myself and my skills." +
                    $"<br/>" +
                   $"<i class=\"fas fa-arrow-right\"></i>Vocational Lessons:" +
                    $"<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i> Relational Database Management Systems Course<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>Software Engineering Course<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>C Course<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>Java OOP Course<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>Algorithms Course<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>Operationg Systems Course<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>Artificial Intelligence Course<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>Web Services Course<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i>Web Technologies Course<br/>" +
                    $"<br/>" +
                    $"Projects:" +
                    $"<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i> NQueens Winforms Puzzle via using DFS Algorithm for Artificial Intelligence Course<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i> TicTacToe Winforms game via using Min-Max Algorithm for Artificial Intelligence Course<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i> Last Man Standing C# Console game for Artifical Intelligence Course<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i> Shopping Site via using ASP.NET MVC and Entity Framework for Web Technologies Course<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:5em\"></i> - For Design Project, A Student System that contains Forum, Grade Calculation and Screen Sharing features developed as ASP.NET MVC, WCF Service ans Winform Projects:" +
                    $"<br>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:10em\"></i>Entity Framework Code First, Generic Repository and Unit Of Work Patterns are used for database management operations.<br/>" +
                    $"<i class=\"fas fa-arrow-right\" style=\"padding-left:10em\"></i>Bootstrap, JQuery, AJAX is used for front-end solutions <br/>"
                };

                context.Educations.Add(edu1);
                context.Educations.Add(edu2);
                context.Educations.Add(edu3);
                context.Educations.Add(edu4);
                context.Educations.Add(edu5);

                context.SaveChanges();
            }
        }

        static void AddExperiences()
        {
            using (var context = new GenericDatabaseContext())
            {
                WorkExperience exp1 = new WorkExperience()
                {
                    TurkishPosition = ".NET Geliştirici Stajyeri",
                    EnglishPosition = ".NET Developer Intern",
                    Company = "Bahçelievler Belediyesi",
                    StartDate = new System.DateTime(2016, 06, 1),
                    EndDate = new System.DateTime(2016, 07, 1),
                    IsPresent = false,
                    WebSite = "http://www.bahcelievler.istanbul/",
                    TurkishExplanation = $"Bahçelievler Belediyesi Bilgi-İşlem bölümünde yaptığım staj boyunca Entity Framework, DevExpress ve SQL teknolojilerini kullanarak Yakıt Takip Winforms projesi ve Sayı Tahmin oyunu geliştirme fırsatına eriştim." +
                    $"<br/>" +
                   $"<i class=\"fas fa-arrow-right\"></i>C# Console Application projesiyle sayı tahmin oyunu yapımı.<br/>" +
                   $"<i class=\"fas fa-arrow-right\"></i>ASP.NET MVC projelerinde bulunuldu.<br/>" +
                   $"<i class=\"fas fa-arrow-right\"></i>Entity Framework ve WinForms kullanılarak Yakıt Takip uygulaması geliştirildi.<br/>",

                    EnglishExplanation = $"During my intern at IT Department of Bahçelievler Municipality, I had the chance of developing Fuel Track Winforms and Number Guess projects using Entity Framework, DevExpress and SQL technologies." +
                    $"<br/>" +
                   $"<i class=\"fas fa-arrow-right\"></i>Developing Number Guess Project using C# Console Application.<br/>" +
                   $"<i class=\"fas fa-arrow-right\"></i>Patricipated ASP.NET MVC projects.<br/>" +
                   $"<i class=\"fas fa-arrow-right\"></i>Developed Fuel Tracking projects using Entity Framework ve WinForms.",

                    EnglishAddress = "Çobançeşme District Sanayi Street No: 48",
                    TurkishAddress = "Çobançeşme Mahallesi Sanayi Caddesi No: 48",
                    ImageName = "\\Experience\\BBLogo.png"
                    //ImageExt = "png"
                };

                WorkExperience exp2 = new WorkExperience()
                {
                    TurkishPosition = ".NET Geliştirici Stajyeri",
                    EnglishPosition = ".NET Developer Intern",
                    Company = "PragmaSoft",
                    StartDate = new System.DateTime(2017, 8, 1),
                    EndDate = new System.DateTime(2017, 9, 1),
                    IsPresent = false,
                    WebSite = "https://www.pragmasoft.com.tr/",
                    TurkishExplanation = $"Pragmasoft şirketinde yaptığım staj boyunca Samsung şirketine ASP.NET MVC Web Api projesi yapma şansını elde ettim." +
                    $"<br/>" +
                   $"<i class=\"fas fa-arrow-right\"></i>Samsung için ASP.NET MVC WebApi ve Entity Framework kullanarak yarışma uygulaması geliştirildi. Uygulamada Samsung ürünleri alan kullanıcılar faturalarının resmini aldıkları cihaz veya herhangi bir Samsung cihazı üzerinden gönderdiklerinde çekilişe katılıyorlar. Çekiliş sonucunda ise hediyeler verilmektedir.",

                    EnglishExplanation = "During my intern at Pragmasoft company, I had the chance of developing ASP.NET MVC WebApi project to Samsung company." +
                    $"<br/>" +
                   $"<i class=\"fas fa-arrow-right\"></i>Developed a contest application using ASP.NET MVC WebApi and Entity Framework. In that application, users gains participation chance to the contest when they upload the photo of Samsung products' invoices they bought from that new Samsung product or another Samsung product. After draw, gifts and promotions are given to the contestants.",

                    TurkishAddress = "İçerenköy, Karaman Çiftliği Caddesi Göksuyu İş Merkezi No:64 Kat:3 Daire:3, 34752 Ataşehir/İstanbul",
                    EnglishAddress = "İçerenköy, Karaman Çiftliği Street Göksuyu Business Center No:64 Floor:3 Apartment:3, 34752 Ataşehir/İstanbul",



                    ImageName = "\\Experience\\PragmaLogo.png"
                };

                WorkExperience exp3 = new WorkExperience()
                {
                    TurkishPosition = ".NET Geliştirici",
                    EnglishPosition = ".NET Developer",
                    Company = "GGSoft",
                    StartDate = new System.DateTime(2018, 6, 1),
                    EndDate = new System.DateTime(2018, 11, 1),
                    IsPresent = false,
                    WebSite = "http://www.g-gsoft.com.tr/tr/",
                    TurkishExplanation = $".NET teknolojileri ile yazılım geliştiren şirkette ASP.NET MVC projeleri ve kendi yazılımları olan Paperwork ürününün geliştirmesinde bulundum." +
                    $"<br/>" +
                   $"<i class=\"fas fa-arrow-right\"></i>Paperwork ürününün geliştirilmesi.<br/>" +
                   $"<i class=\"fas fa-arrow-right\"></i>Font görüntüleyici ASP.NET MVC uygulaması.<br/>" +
                   $"<i class=\"fas fa-arrow-right\"></i>Paperwork ürününün Silverlight'tan MVC'ye çevrilmesinde katıda bulunuldu.<br/>",

                    EnglishExplanation = "Participated development of Paperwork product and ASP.NET MVC projects in that company which develops software with .NET technologies" +
                    $"<br/>" +
                   $"<i class=\"fas fa-arrow-right\"></i>Development of Paperwork product.<br/>" +
                   $"<i class=\"fas fa-arrow-right\"></i>Font Viewer ASP.NET MVC projects.<br/>" +
                   $"<i class=\"fas fa-arrow-right\"></i>Participated Paperwork product's conversion to Silverlight tp ASP.NET MVC.<br/>",


                    TurkishAddress = "İçerenköy, Kartal Sokak No:19, 34752 Ataşehir/İstanbul",
                    EnglishAddress = "İçerenköy, Kartal Street No:19, 34752 Ataşehir/İstanbul",
                    ImageName = "\\Experience\\GGSoftLogo.jpg"
                };

                WorkExperience exp4 = new WorkExperience()
                {
                    TurkishPosition = "Teknoloji Danışmanı",
                    EnglishPosition = "Technology Consultant",
                    Company = "IDECON Danışmanlık Hizmetleri A.Ş.",
                    StartDate = new System.DateTime(2018, 11, 1),
                    IsPresent = true,
                    WebSite = "https://www.idecon.com.tr/",
                    TurkishExplanation = $"Elektronik Dönüşüm Süreçlerinde çözüm ortağı olan IDECON firmasında kurulumlar ve bir çok teknolojiyi harmanlayarak yazılım geliştirmeleri yapmaktayım." +
                    $"<br/>" +
                   $"<i class=\"fas fa-arrow-right\"></i>ASP.NET MVC Web API CORE ve Dapper kullanılarak Nakit Akışı projesinin geliştirilmesi.<br/>" +
                   $"<i class=\"fas fa-arrow-right\"></i>Pyhton Flask Framework, Google OCR ve Spacy kütüphanesi kullanılarak makine öğrenmesi içeren OCR okumalı \"Masraf\" uygulaması geliştirilmesi<br/>" +
                   $"<i class=\"fas fa-arrow-right\"></i>Emutabakat ve Elektronik Hesap Özeti uygulamalarının müşteri sunuuclarında kurulumlarının ve bakımlarının yapılması.<br/>",

                    EnglishExplanation = "I am currently developing softwares by combining different technologies and set ups to servers at IDECON company which is a solution partner at Electronic Conversion Processes." +
                    $"<br/>" +
                   $"<i class=\"fas fa-arrow-right\"></i>Developed Cashflow project using ASP.NET MVC Web API CORE and Dapper<br/>" +
                   $"<i class=\"fas fa-arrow-right\"></i>Developing \"Expense\" project that contains OCR reading and maching learning using Python Flask Framework, Google OCR and Spacy library.<br/>" +
                   $"<i class=\"fas fa-arrow-right\"></i>Setting up and maintaining the eReconciliation and eStatement applications to our client companies' servers..<br/>",

                    TurkishAddress = "Oruç Reis Mahallesi Tekstilkent Caddesi No: 12 Koza Plaza A Blok Kat:14 Daire: 51, 34235 Esenler",
                    EnglishAddress = "Oruç Reis District Tekstilkent Street No: 12 Koza Plaza A Blok Floor:14 Apartment: 51, 34235 Esenler",
                    ImageName = "\\Experience\\IdeconLogo.png"
                };

                context.WorkExperiences.Add(exp1);
                context.WorkExperiences.Add(exp2);
                context.WorkExperiences.Add(exp3);
                context.WorkExperiences.Add(exp4);
                context.SaveChanges();
            }
        }

        static void AddProjects()
        {
            using (var context = new GenericDatabaseContext())
            {
                Project project1 = new Project
                {
                    EnglishName = "Aydın University Student Portal",
                    TurkishName = "Aydın Üniversitesi Öğrenci Portalı",
                    TurkishExplanation = "Aydın Universitesi Öğrenci portalı Aydın Üniversitesi öğrenclierine not hesaplama, forum ve ekran paylaşımı ile ders çalışma özelliklerini sunan bir uygulamadır. " +
                    "Uygulama ASP.NET MVC ile yapılmış olup Veritabanı olarak MSSQL, Veriye erişim katmanı olarak Entity Framework ORM, Ekran Paylaşımı içinse RDP sınıfı kullanılmıştır.",

                    EnglishExplanation = "Aydın University Student Portal is an application that provides Grade Calculation, Forum and studying via screen sharing functions to Aydın University Students. " +
                    "Applicaion is developed using ASP.NET MVC and MSSQL is used for database, Entity Framework is used for data access layer, RDP class is used for Screen Sharing",

                    Link = "https://github.com/TekyaygilFethi/AydinUniversityProject",
                    Sira = 5
                };

                Project project2 = new Project
                {
                    EnglishName = "NQueens Problem",
                    TurkishName = "NQueen Problemi",
                    EnglishExplanation = "NQueens Problem application is Winforms application that solves NQueens problem with DFS algorithm and takes Queen count from user as input.",
                    TurkishExplanation = "NQueens Problemi uygulaması, Yapay Zeka problemlerinden biri olan NQueens problemini DFS algoritmasıyla çözen ve kullanıcıdan belli bir vezir sayısı alarak bunu gerçekleştiren Winforms uygulamasıdır. ",
                    Link = "https://bitbucket.org/TekyaygilFethi/n-queens-problem-by-dfs/src/master/",
                    Sira = 7

                };

                Project project3 = new Project()
                {
                    EnglishName = "Guess Game",
                    TurkishName = "Tahmin Oyunu",
                    EnglishExplanation = "Guess Game is a console application that expect a prediction of pre-defined number by a system from user and give feedbacks about these predictions to increase prediction accuracy.",
                    TurkishExplanation = "Tahmin oyunu önceden sistem tarafından belirlenmiş bir sayıyı kullanıcıya tahmin ettirme ve bu tahminler sonucu geri dönütler vererek tahmin doğruluğunu arttırarak tahmmin ettiren bir konsol uygulamasıdır.",
                    Link = "https://github.com/TekyaygilFethi/GuessGame",
                    Sira = 9
                };

                Project project4 = new Project()
                {
                    EnglishName = "Tic Tac Toe",
                    TurkishName = "X O X",
                    TurkishExplanation = "Zorluk derecesi ayarlanabilen, 3x3 lük bir düzlemde oynanan klasik X O X oyununun Min-Max algoritması ile Winforms için geliştirildiği uygulama.",
                    EnglishExplanation = "Winforms aplication of classic Tic Tac Toe game that plays on 3x3 plane which contains Min-Max Algorithm and which's difficulty can be set.",
                    Link = "https://github.com/TekyaygilFethi/TicTacToe",
                    Sira = 8
                };

                Project project5 = new Project()
                {
                    EnglishName = "Cashflow Project",
                    TurkishName = "Nakit Akışı Projesi",
                    TurkishExplanation = "Firmaların Nakit Akışı kontrollerini gerçekleştirmek, isteğe göre simülasyon yapabilecekleri ve ileriki tarihler için tahminleri görebilecekleri bir Nakit Akışı ASP.NET MVC CORE Web API web uygulaması. " +
                    "Veritabanı için MySQL ve Veriye erişim katmanı için Dapper ORM kullanılmıştır.",

                    EnglishExplanation = "This application is a Cashflow web application developed via using ASP.NET MVC CORE WebAPI technology that allows companies and firms to track their Cashflow, making simulations as desired and preview the future predictions for next dates. " +
                    "For the database, MySQL is used and Dapper ORM is used for Data Access Layer.",
                    Link = "https://github.com/TekyaygilFethi/IdeconCashFlow",
                    Sira = 6

                };

                Project project6 = new Project()
                {
                    EnglishName = "Expense Project",
                    TurkishName = "Masraf Projesi",
                    TurkishExplanation = "Firmaların personellerinin masraf işlemleri için Python Flask Framework ve Makine Öğrenmesi amacıyla Spacy Kütüphanesi kullanılarak geliştirilen web servis. " +
                    "Uygulama resmi çekilen fişlerin içinden gerekli bilgileri ayıklayıp bu bilgileri veritabanına kaydetmektedir. " +
                    "Resim okumak için Google OCR apisi, bu verilerin öğrenimi için de Spacy NeR teknolojisi kullanılmaktadır. Veritabanı için MySQL, veriye erişim katmanı için de SQLAlchemy kullanılmaktadır.",

                    EnglishExplanation = "A web service for companies' and firms' personels' expense processes developed via using Python Flask Framework and Spacy library with the purpose of Machine Learning. " +
                    "Application parses the info from an image of invoices and record it to database. " +
                    "Google OCR Api is used for reading the content of the image, Spacy NeR technology is used for these data's learning. MySQL is used for the database, SQLAlchemy is used for Data Access Layer.",
                    Link = "https://github.com/TekyaygilFethi/IdeconExpense",
                    Sira = 4
                };

                Project project7 = new Project()
                {
                    EnglishName = "Fethi Tekyaygil Website",
                    TurkishName = "Fethi Tekyaygil websitesi",
                    TurkishExplanation = "Bu websitesi",

                    EnglishExplanation = "This website.",
                    Link = "https://github.com/TekyaygilFethi/FethiTekyaygilWebsite",
                    Sira = 1
                };

                Project project8 = new Project()
                {
                    EnglishName = "Catch Craze",
                    TurkishName = "Catch Craze",
                    EnglishExplanation = "An Android and iOs game that based on timing and reflexes developed via using Unity and C#.",
                    TurkishExplanation = "Unity ve C# kullanılarak geliştirilmiş reflekslere ve zamanlamaya dayalı Android ve iOs oyunu",
                    Sira = 3,
                    Link = "https://play.google.com/store/apps/details?id=com.PREGAMES.CatchCraze"
                };

                Project project9 = new Project()
                {
                    EnglishName = "SpinNToss",
                    TurkishName = "SpinNToss",
                    EnglishExplanation = "An Android and iOs game that based on timing and reflexes developed via using Unity and C#.",
                    TurkishExplanation = "Unity ve C# kullanılarak geliştirilmiş reflekslere ve zamanlamaya dayalı Android ve iOs oyunu",
                    Sira = 2,
                    Link = "https://play.google.com/store/apps/details?id=com.PreGames.SpinNToss"
                };

                context.Projects.Add(project1);
                context.Projects.Add(project2);
                context.Projects.Add(project3);
                context.Projects.Add(project4);
                context.Projects.Add(project5);
                context.Projects.Add(project6);
                context.Projects.Add(project7);
                context.Projects.Add(project8);
                context.Projects.Add(project9);

                context.SaveChanges();
            }
        }

        static void AddLanguages()
        {
            using (var context = new GenericDatabaseContext())
            {
                #region Add Language Degrees
                LanguageDegree ldA1 = new LanguageDegree()
                {
                    Degree = "A1"
                };
                LanguageDegree ldA2 = new LanguageDegree()
                {
                    Degree = "A2"
                };
                LanguageDegree ldB1 = new LanguageDegree()
                {
                    Degree = "B1"
                };
                LanguageDegree ldB2 = new LanguageDegree()
                {
                    Degree = "B2"
                };
                LanguageDegree ldC1 = new LanguageDegree()
                {
                    Degree = "C1"
                };
                LanguageDegree ldC2 = new LanguageDegree()
                {
                    Degree = "C2"
                };

                context.LanguageDegrees.Add(ldA1);
                context.LanguageDegrees.Add(ldA2);
                context.LanguageDegrees.Add(ldB1);
                context.LanguageDegrees.Add(ldB2);
                context.LanguageDegrees.Add(ldC1);
                context.LanguageDegrees.Add(ldC2);
                #endregion

                #region Add Language
                Language lang = new Language()
                {
                    EnglishName = "English",
                    TurkishName = "İngilizce"
                };

                context.Languages.Add(lang);
                #endregion

                #region Add Language Category
                LanguageCategory speaking = new LanguageCategory()
                {
                    EnglishCategory = "Speaking",
                    TurkishCategory = "Konuşma",
                    LanguageDegree = ldC2
                };


                LanguageCategory listening = new LanguageCategory()
                {
                    EnglishCategory = "Listening",
                    TurkishCategory = "Dinleme",
                    LanguageDegree = ldC2
                };


                LanguageCategory reading = new LanguageCategory()
                {
                    EnglishCategory = "Reading",
                    TurkishCategory = "Okuma",
                    LanguageDegree = ldC2
                };


                LanguageLanguageCategory speakingLangCat = new LanguageLanguageCategory()
                {
                    Language = lang,
                    LanguageCategory = speaking
                };

                LanguageLanguageCategory listeningLangCat = new LanguageLanguageCategory()
                {
                    Language = lang,
                    LanguageCategory = listening
                };

                LanguageLanguageCategory readingLangCat = new LanguageLanguageCategory()
                {
                    Language = lang,
                    LanguageCategory = reading
                };



                listening.Languages.Add(listeningLangCat);
                reading.Languages.Add(readingLangCat);
                speaking.Languages.Add(speakingLangCat);


                context.LanguageCategories.Add(speaking);
                context.LanguageCategories.Add(reading);
                context.LanguageCategories.Add(listening);


                context.LanguageLanguageCategories.Add(speakingLangCat);
                context.LanguageLanguageCategories.Add(readingLangCat);
                context.LanguageLanguageCategories.Add(listeningLangCat);

                #endregion


                #region Communication Talent


                CommunicationTalent ct1 = new CommunicationTalent()
                {
                    TurkishCommunicationTalent = "İyi derecede yazılı ve sözlü iletişim",
                    EnglishCommunicationTalent = "Good written and verbal communication skills",
                    ImagePath = "\\Communication\\VerbalNonVerbalCommunication.jpg"
                };
                CommunicationTalent ct2 = new CommunicationTalent()
                {
                    TurkishCommunicationTalent = "Kendine güvenen, açık ve profesyonel konuşma yetenekleri",
                    EnglishCommunicationTalent = "Confident, articulate, and professional speaking abilities",
                    ImagePath = "\\Communication\\Speecher.jpg"
                };
                CommunicationTalent ct3 = new CommunicationTalent()
                {
                    TurkishCommunicationTalent = "Empatik dinleyici ve ikna edici konuşmacı",
                    EnglishCommunicationTalent = "Empathic listener and persuasive speaker",
                    ImagePath = "\\Communication\\Listening.jpg"
                };
                CommunicationTalent ct4 = new CommunicationTalent()
                {
                    TurkishCommunicationTalent = "İyi derecede sunum ve müzakere becerileri",
                    EnglishCommunicationTalent = "Good presentation and negotiation skills",
                    ImagePath = "\\Communication\\Presentation.jpg"
                };
                #endregion


                #region Personal Talent
                PersonalTalent pt = new PersonalTalent();
                pt.Languages.Add(lang);
                pt.CommunicationTalents.Add(ct1);
                pt.CommunicationTalents.Add(ct2);
                pt.CommunicationTalents.Add(ct3);
                pt.CommunicationTalents.Add(ct4);


                ct1.PersonalTalent = pt;
                ct2.PersonalTalent = pt;
                ct3.PersonalTalent = pt;
                ct4.PersonalTalent = pt;

                lang.PersonalTalent = pt;


                context.CommunicationTalents.Add(ct1);
                context.CommunicationTalents.Add(ct2);
                context.CommunicationTalents.Add(ct3);
                context.CommunicationTalents.Add(ct4);


                #region Work Talents
                WorkTalent wt1 = new WorkTalent()
                {
                    Name = "C#",
                    Rate = 90,
                    PersonalTalent = pt,
                    CategoryNumber = 1
                };

                WorkTalent wt2 = new WorkTalent()
                {
                    Name = ".NET CORE",
                    Rate = 90,
                    PersonalTalent = pt,
                    CategoryNumber = 1
                };

                WorkTalent wt3 = new WorkTalent()
                {
                    Name = "TFS",
                    Rate = 90,
                    PersonalTalent = pt,
                    CategoryNumber = 1
                };

                WorkTalent wt4 = new WorkTalent()
                {
                    Name = "Entity Framework",
                    Rate = 85,
                    PersonalTalent = pt,
                    CategoryNumber = 1
                };

                WorkTalent wt5 = new WorkTalent()
                {
                    Name = "Rest Services",
                    Rate = 85,
                    PersonalTalent = pt,
                    CategoryNumber = 1
                };

                WorkTalent wt6 = new WorkTalent()
                {
                    Name = "ASP.NET MVC CORE Web API",
                    Rate = 90,
                    PersonalTalent = pt,
                    CategoryNumber = 1
                };

                WorkTalent wt7 = new WorkTalent()
                {
                    Name = "ASP.NET MVC CORE",
                    Rate = 90,
                    PersonalTalent = pt,
                    CategoryNumber = 1
                };


                WorkTalent wt8 = new WorkTalent()
                {
                    Name = "MSSQL",
                    Rate = 79,
                    PersonalTalent = pt,
                    CategoryNumber = 2
                };

                WorkTalent wt9 = new WorkTalent()
                {
                    Name = "MySQL",
                    Rate = 81,
                    PersonalTalent = pt,
                    CategoryNumber = 2
                };


                WorkTalent wt10 = new WorkTalent()
                {
                    Name = "IIS",
                    Rate = 70,
                    PersonalTalent = pt,
                    CategoryNumber = 3
                };

                WorkTalent wt11 = new WorkTalent()
                {
                    Name = "JQuery",
                    Rate = 75,
                    PersonalTalent = pt,
                    CategoryNumber = 4
                };

                WorkTalent wt12 = new WorkTalent()
                {
                    Name = "JavaScript",
                    Rate = 75,
                    PersonalTalent = pt,
                    CategoryNumber = 4
                };


                WorkTalent wt13 = new WorkTalent()
                {
                    Name = "HTML",
                    Rate = 80,
                    PersonalTalent = pt,
                    CategoryNumber = 4
                };
                WorkTalent wt14 = new WorkTalent()
                {
                    Name = "CSS",
                    Rate = 80,
                    PersonalTalent = pt,
                    CategoryNumber = 4
                };
                WorkTalent wt15 = new WorkTalent()
                {
                    Name = "AJAX",
                    Rate = 80,
                    PersonalTalent = pt,
                    CategoryNumber = 4
                };
                WorkTalent wt16 = new WorkTalent()
                {
                    Name = "Python",
                    Rate = 70,
                    PersonalTalent = pt,
                    CategoryNumber = 5
                };
                WorkTalent wt17 = new WorkTalent()
                {
                    Name = "DevExpress",
                    Rate = 90,
                    PersonalTalent = pt,
                    CategoryNumber = 4
                };
                WorkTalent wt18 = new WorkTalent()
                {
                    Name = "Photoshop",
                    Rate = 70,
                    PersonalTalent = pt,
                    CategoryNumber = 6
                };
                WorkTalent wt19 = new WorkTalent()
                {
                    Name = "Unity",
                    Rate = 70,
                    PersonalTalent = pt,
                    CategoryNumber = 7
                };
                WorkTalent wt20 = new WorkTalent()
                {
                    Name = "Dapper",
                    Rate = 80,
                    PersonalTalent = pt,
                    CategoryNumber = 1
                };
                WorkTalent wt21 = new WorkTalent()
                {
                    Name = "Bootstrap",
                    Rate = 77,
                    PersonalTalent = pt,
                    CategoryNumber = 4
                };

                WorkTalent wt22 = new WorkTalent()
                {
                    Name = "Python Flask",
                    Rate = 60,
                    PersonalTalent = pt,
                    CategoryNumber = 5
                };

                WorkTalent wt23 = new WorkTalent()
                {
                    Name = "Java",
                    Rate = 70,
                    PersonalTalent = pt,
                    CategoryNumber = 1
                };

                WorkTalent wt24 = new WorkTalent()
                {
                    Name = "Microsoft Office",
                    Rate = 100,
                    PersonalTalent = pt,
                    CategoryNumber = 5
                };

                pt.WorkTalents.Add(wt1);
                pt.WorkTalents.Add(wt2);
                pt.WorkTalents.Add(wt3);
                pt.WorkTalents.Add(wt4);
                pt.WorkTalents.Add(wt5);
                pt.WorkTalents.Add(wt6);
                pt.WorkTalents.Add(wt7);
                pt.WorkTalents.Add(wt8);
                pt.WorkTalents.Add(wt9);
                pt.WorkTalents.Add(wt10);
                pt.WorkTalents.Add(wt11);
                pt.WorkTalents.Add(wt12);
                pt.WorkTalents.Add(wt13);
                pt.WorkTalents.Add(wt14);
                pt.WorkTalents.Add(wt15);
                pt.WorkTalents.Add(wt16);
                pt.WorkTalents.Add(wt17);
                pt.WorkTalents.Add(wt18);
                pt.WorkTalents.Add(wt19);
                pt.WorkTalents.Add(wt20);
                pt.WorkTalents.Add(wt21);
                pt.WorkTalents.Add(wt22);
                pt.WorkTalents.Add(wt23);
                pt.WorkTalents.Add(wt24);


                context.WorkTalents.Add(wt1);
                context.WorkTalents.Add(wt2);
                context.WorkTalents.Add(wt3);
                context.WorkTalents.Add(wt4);
                context.WorkTalents.Add(wt5);
                context.WorkTalents.Add(wt6);
                context.WorkTalents.Add(wt7);
                context.WorkTalents.Add(wt8);
                context.WorkTalents.Add(wt9);
                context.WorkTalents.Add(wt10);
                context.WorkTalents.Add(wt11);
                context.WorkTalents.Add(wt12);
                context.WorkTalents.Add(wt13);
                context.WorkTalents.Add(wt14);
                context.WorkTalents.Add(wt15);
                context.WorkTalents.Add(wt16);
                context.WorkTalents.Add(wt17);
                context.WorkTalents.Add(wt18);
                context.WorkTalents.Add(wt19);
                context.WorkTalents.Add(wt20);
                context.WorkTalents.Add(wt21);
                context.WorkTalents.Add(wt22);
                context.WorkTalents.Add(wt23);
                context.WorkTalents.Add(wt24);
                #endregion

                context.PersonalTalents.Add(pt);
                #endregion

                context.SaveChanges();
            }
        }

        static void AddDeveloper()
        {
            using (var context = new GenericDatabaseContext())
            {
                Developer dev = new Developer()
                {
                    Birthday = new System.DateTime(1996, 06, 07),
                    ImageName = "\\Developer\\fethi.JPG",
                    Email = "tekyaygil.fethi@gmail.com",
                    Name = "Fethi",
                    Surname = "Tekyaygil",
                    TurkishTitle = "Bilgisayar Mühendisi",
                    EnglishTitle = "Computer Engineer",
                    TurkishNativeLanguage = "Türkçe",
                    EnglishNativeLanguage = "Turkish",
                    EnglishAboutMe = "During my education life, I've accomplished 3 interns that improved my skills and knowledge in Computer Engineering area. " +
                    "I've developed .NET, C# and database projects using MSSQL during my internships. After graduation, I started to work immediately as .NET Software Developer. " +
                    "During this time, I participated many .NET projects, one and the biggest of them was conversion of Silverlight project to ASP.NET MVC Core. " +
                    "In addition to them, I was responsible from developing and improving a system named \"Paperwork\" which is written in C# and was still written. 6 months later of my first job, " +
                    "I've changed my company and still I'm working at that company as Technology Consultant. As Technology Consultant, I am responsible of Setting Up previosuly written projects to " +
                    "IIS and maintain them, developing .NET projects via using different technologies in a harmony such as MySQL, MSSQL, DevExpress, Entity Framework, Dapper. " +
                    "I've also developed a Python Flask project in order to develop a web service for our \"Expense\" project for my current company. This ignited my desire to learn Python and now, " +
                    "I'm trying to learn Python at deep levels with Machine Learning and Data Science subjects.",

                    TurkishAboutMe = "Eğitim hayatım boyunca yaptığım 3 stajda Bilgisayar Mühendisliği alanında yeteneklerimi ve bilgimi geliştirme imkanına sahip oldum. " +
                    "Staj sürelerim boyunca .NET, C# ve MSSQL ile veritabanı projeleri geliştirdim. Mezuniyetimden sonra .NET Yazılım Geliştirici olarak anında işe başladım. " +
                    "Bu süre zarfında .NET projelerine katıldım, bunlardan biri ve en büyüğü de Silverlight projesinin ASP.NET MVC Core projesine çevrilmesiydi. " +
                    "Bunlara ek olarak C# ile yazılmış ve hala yazılmakta olan \"Paperwork\" isimli ürünün geliştirilmesinden ve iyileştirilmesinden sorumluydum. İlk işimden 6 ay sonra şirketimi değiştirdim ve halen " +
                    "Teknoloji Danışmanı olarak o şirkette çalışmaktayım. Teknoloji Danışmanı olarak önceden yazılmış projeleri IIS'e kurup bakımlarını yapmaktan ve MySQL, MSSQL, DevExpress, Entity Framework, Dapper " +
                    "gibi farklı teknolojileri kullanarak .NET projeleri geliştirmekten sorumluyum. Aynı zamanda mevcut şirketimin \"Masraf\" projesi için Python Flask projesi geliştirdim. Bu geliştirme sürexi benim Python öğrenme " +
                    "arzumu tetikledi ve şimdi Makine Öğrenmesi ve Veri Bilimi konuları seviyelerinde Python öğrenmeye çalışıyorum."


                };
                context.Developers.Add(dev);
                context.SaveChanges();
            }
        }

        static void AddHobbies()
        {
            using (var context = new GenericDatabaseContext())
            {
                Hobby hb1 = new Hobby()
                {
                    TurkishExplanation = "Video Oyunları oynamak bir tutkudur!",
                    EnglishExplanation = "Playing video games is a passion!",
                    TurkishName = "Video Oyunları",
                    EnglishName = "Video Games",
                    VideoName= "\\AboutMe\\dmc5.mp4",
                    ImageName= "\\AboutMe\\dmc3-alt.jpg"
                };
                Hobby hb2 = new Hobby()
                {
                    TurkishExplanation = "Ruhun gıdası olarak Mary Elizabeth McGlynn, Donna Burke ve Oyun-Film Soundtracklerini tercih etsem de, Şevval Sam da dinlerim!",
                    EnglishExplanation = "Even I prefer Mary Elizabeth McGlynn, Donna Burke and Game-Movie Soundtracks as healer of my soul, I also listen to Şevval Sam.",
                    TurkishName = "Müzik",
                    EnglishName = "Musics",
                    VideoName = "\\AboutMe\\music.mp4",
                    ImageName = "\\AboutMe\\music-alt.jpg"
                };
                Hobby hb3 = new Hobby()
                {
                    TurkishExplanation = "Fantastik, Biyografi, Tarihi, Bilimkurgu film aşığı! E tabi bir de Star Wars!",
                    EnglishExplanation = "Huge fan of Fantasy, Biography, Historical, Science Ficton movies. And of course Star Wars!",
                    TurkishName = "Film",
                    EnglishName = "Movies",
                    VideoName = "\\AboutMe\\movie.mp4",
                    ImageName = "\\AboutMe\\movie.jpg"
                };
                Hobby hb4 = new Hobby()
                {
                    TurkishExplanation = "Bilim ve Tarih kitapları kurdu!",
                    EnglishExplanation = "Science and History book worm!",
                    TurkishName = "Kitap Okumak",
                    EnglishName = "Reading Books",
                    VideoName = "\\AboutMe\\book.mp4",
                    ImageName = "\\AboutMe\\book.jpeg"
                };
                Hobby hb5 = new Hobby()
                {
                    TurkishExplanation = "Tiyatro insanı insana insanla anlatma sanatıdır.",
                    EnglishExplanation = "Theater is the art of telling people to people by using people.",
                    TurkishName = "Tiyatro",
                    EnglishName = "Theater",
                    VideoName = "\\AboutMe\\tiyatro.mp4",
                    ImageName = "\\AboutMe\\tiyatro.jpg"
                };
                Hobby hb6 = new Hobby()
                {
                    TurkishExplanation = "Herkese Behzat gibi amir, Mecnun gibi seven lazım.",
                    EnglishExplanation = "Everyone needs chief like Behzat, lover like Mecnun.",
                    TurkishName = "Dizi",
                    EnglishName = "Series",
                    VideoName = "\\AboutMe\\dizi.mp4",
                    ImageName = "\\AboutMe\\dizi.jpg"
                };

                context.Hobbies.Add(hb1);
                context.Hobbies.Add(hb2);
                context.Hobbies.Add(hb3);
                context.Hobbies.Add(hb4);
                context.Hobbies.Add(hb5);
                context.Hobbies.Add(hb6);

                context.SaveChanges();


            }
        }
        #endregion
    }
}
