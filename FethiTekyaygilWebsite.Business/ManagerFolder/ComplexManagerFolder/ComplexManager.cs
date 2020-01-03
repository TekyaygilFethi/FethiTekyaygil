using FethiTekyaygilWebsite.Business.ManagerFolder.BasicManagerFolder.AboutMeManagerFolder;
using FethiTekyaygilWebsite.Business.ManagerFolder.BasicManagerFolder.DeveloperManagerFolder;
using FethiTekyaygilWebsite.Business.ManagerFolder.BasicManagerFolder.EducationManagerFolder;
using FethiTekyaygilWebsite.Business.ManagerFolder.BasicManagerFolder.ExperienceManagerFolder;
using FethiTekyaygilWebsite.Business.ManagerFolder.BasicManagerFolder.PersonalTalentManagerFolder;
using FethiTekyaygilWebsite.Business.ManagerFolder.BasicManagerFolder.ProjectManagerFolder;
using FethiTekyaygilWebsite.Business.ManagerFolder.BasicManagerFolder.WorkTalentManagerFolder;
using FethiTekyaygilWebsite.Business.ManagerFolder.IManagerFolder;
using FethiTekyaygilWebsite.Data.GlobalDatas;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.DeveloperModels;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.GenericModels;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.HobbyModels;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.IndexModels;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.PersonalTalentModels;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.ProjectModels;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.TimelineModels;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.WorkTalentModels;
using FethiTekyaygilWebsite.Data.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FethiTekyaygilWebsite.Business.ManagerFolder.ComplexManagerFolder
{
    public class ComplexManager : BaseManager
    {

        private EducationManager educationManager;
        private ExperienceManager experienceManager;
        private ProjectManager projectManager;
        private PersonalTalentManager personalTalentManager;
        private DeveloperManager developerManager;
        private WorkTalentManager workTalentManager;
        private AboutMeManager aboutMeManager;

        public ComplexManager()
        {
            educationManager = new EducationManager();
            experienceManager = new ExperienceManager();
            projectManager = new ProjectManager();
            personalTalentManager = new PersonalTalentManager();
            developerManager = new DeveloperManager();
            workTalentManager = new WorkTalentManager();
            aboutMeManager = new AboutMeManager();
        }

        public ResponseObject<List<TimelineResponseModel>> GetTimelines()
        {
            var response = new ResponseObject<List<TimelineResponseModel>>();
            var timelineList = new List<TimelineResponseModel>();

            try
            {
                var educationTimelineList = educationManager.GetEducationsForDisplay();
                var experienceTimelineList = experienceManager.GetExperiencesForDisplay();

                timelineList.AddRange(educationTimelineList);
                timelineList.AddRange(experienceTimelineList);

                //timelineList.ForEach(each => each.Image = ImageHelper.ConvertToBase64(each.ImageBlob, each.ImageExt));
                timelineList.ForEach(each => each.ImageName = (Globals.MediaFolder + each.ImageName).Replace("\\", "/"));

                response = GetFilledResponse(response, ResponseType.Success, timelineList.OrderBy(o => o.StartDate).ToList());
            }
            catch (Exception ex)
            {
                response = GetFilledResponse(response, ResponseType.Error, null, ex);
            }

            return response;
        }

        public ResponseObject<List<GetProjectsModel>> GetProjects()
        {
            ResponseObject<List<GetProjectsModel>> response = new ResponseObject<List<GetProjectsModel>>();
            try
            {
                response = GetFilledResponse(response, ResponseType.Success, projectManager.GetProjectsForDisplay());
            }
            catch (Exception ex)
            {
                response = GetFilledResponse(response, ResponseType.Error, null, ex);
            }
            return response;
        }

        public ResponseObject<GetPersonalTalentModel> GetPersonalTalents()
        {
            ResponseObject<GetPersonalTalentModel> response = new ResponseObject<GetPersonalTalentModel>();
            try
            {
                response = GetFilledResponse(response, ResponseType.Success, personalTalentManager.GetPersonalTalentsForDisplay());
            }
            catch (Exception ex)
            {
                response = GetFilledResponse(response, ResponseType.Error, null, ex);
            }
            return response;
        }

        public ResponseObject<DeveloperResponseModel> GetDeveloper()
        {
            ResponseObject<DeveloperResponseModel> response = new ResponseObject<DeveloperResponseModel>();
            try
            {
                response = GetFilledResponse(response, ResponseType.Success, developerManager.GetDeveloper());
            }
            catch (Exception ex)
            {
                response = GetFilledResponse(response, ResponseType.Error, null, ex);
            }
            return response;
        }

        public ResponseObject<IndexResponseModel> GetDatas()
        {
            ResponseObject<IndexResponseModel> response = new ResponseObject<IndexResponseModel>();
            IndexResponseModel responseObject = new IndexResponseModel();

            try
            {
                //responseObject.ProjectsModels = GetProjects();
                //responseObject.TimelineModels = GetTimelines();
                //responseObject.PersonalTalentModel = GetPersonalTalents();

                response = GetFilledResponse(response, ResponseType.Success, responseObject);
            }
            catch (Exception ex)
            {
                response = GetFilledResponse(response, ResponseType.Error, null, ex);
            }
            return response;
        }

        public ResponseObject<List<TempWorkTalent>> GetWorkTalents()
        {
            ResponseObject<List<TempWorkTalent>> response = new ResponseObject<List<TempWorkTalent>>();
            try
            {
                response = GetFilledResponse(response, ResponseType.Success, workTalentManager.GetWorkTalentsForDisplay());
            }
            catch (Exception ex)
            {
                response = GetFilledResponse(response, ResponseType.Error, null, ex);
            }
            return response;
        }

        public ResponseObject<List<HobbyResponseModel>> GetHobbies()
        {
            ResponseObject<List<HobbyResponseModel>> response = new ResponseObject<List<HobbyResponseModel>>();
            try
            {
                response = GetFilledResponse(response, ResponseType.Success, aboutMeManager.GetHobbies());
            }
            catch (Exception ex)
            {
                response = GetFilledResponse(response, ResponseType.Error, null, ex);
            }
            return response;
        }

    }
}
