using System;

namespace FethiTekyaygilWebsite.Data.Models.ResponseModels.DeveloperModels
{
    public class DeveloperResponseModel
    {
        public string Name { get; set; }

        public string ImageName { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public DateTime Birthday { get; set; }

        public string Title { get; set; }

        public string AboutMe { get; set; }

        public string NameSurname => Name + " " + Surname;

    }
}
