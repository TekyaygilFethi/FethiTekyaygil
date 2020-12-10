using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FethiTekyaygilWebsite.MVC.Model.VideoModels
{
    public class EpisodeModel
    {
        public int ID { get; set; }

        public string  Name { get; set; }

        public string VideoUrl { get; set; }

        public bool WasLive { get; set; }

        public string Description { get; set; }

        public int ShowID { get; set; }

        public string ShowName { get; set; }

        public string ShowImageUrl { get; set; }

        public int CommunityID { get; set; }

        public string CommunityName { get; set; }

        public IEnumerable<OtherEpisode> OtherEpisodes { get; set; }
    }

    public class OtherEpisode
    {
        public int EpisodeID { get; set; }

        public string EpisodeName { get; set; }
    }
}
