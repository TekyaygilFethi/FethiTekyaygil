using FethiTekyaygilWebsite.Data.Models.ResponseModels.DeveloperModels;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.PersonalTalentModels;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.ProjectModels;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.TimelineModels;
using System.Collections.Generic;

namespace FethiTekyaygilWebsite.Data.Models.ResponseModels.IndexModels
{
    public class IndexResponseModel
    {
        public List<TimelineResponseModel> TimelineModels { get; set; }

        public List<GetProjectsModel> ProjectsModels { get; set; }

        public GetPersonalTalentModel PersonalTalentModel { get; set; }

        public DeveloperResponseModel GetDeveloperModel { get; set; }
    }
}
