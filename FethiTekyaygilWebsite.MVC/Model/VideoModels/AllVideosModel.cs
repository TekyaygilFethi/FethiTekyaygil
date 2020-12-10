using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FethiTekyaygilWebsite.MVC.Model.VideoModels
{
    public class AllVideosModel
    {
        public IEnumerable<AllEpisodesModel> Episodes{get;set;}

        public IEnumerable<AllCommunityModel> Communities { get; set; }

        public IEnumerable<AllShowModel> Shows { get; set; }

        public int Page { get; set; }
    }
    public class AllEpisodesModel {
        public int ID { get; set; }

        public string Name { get; set; }

        public string ThumbnailUrl { get; set; }

        public string CommunityName { get; set; }

        public string ShowName { get; set; }

        public int CommunityID { get; set; }

        public int ShowID { get; set; }

        public bool IsLive { get; set; }

        public bool IsScheduled { get; set; }

    }
    public class AllCommunityModel
    {
        public int ID { get; set; }
        
        public string Name{ get; set; }
    }

    public class AllShowModel
    {
        public int ID { get; set; }

        public string Name { get; set; }
    }
}
