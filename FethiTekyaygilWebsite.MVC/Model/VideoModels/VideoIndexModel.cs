using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FethiTekyaygilWebsite.MVC.Model.VideoModels
{
    public class VideoIndexModel
    {
        public IEnumerable<ShowcaseVideo> ShowcaseVideos { get; set; }
        public IEnumerable<DropdownCommunity> DropdownCommunities { get; set; }

        public LiveVideo LiveVideo { get; set; }

        public LiveVideo UpcomingLiveVideo { get; set; }
    }

    public class LiveVideo {
        public int ID { get; set; }

        public string Name { get; set; }

        public string VideoUrl { get; set; }

        public string Description { get; set; }

        public int ShowID { get; set; }

        public string ShowName { get; set; }

        public string ShowImageUrl { get; set; }

        public int CommunityID { get; set; }

        public string CommunityName { get; set; }
    }

    public class ShowcaseVideo
    {
        public int VideoID { get; set; }

        public string VideoThumbnail { get; set; }

        public string VideoName { get; set; }

        public string VideoDescription { get; set; }

        public bool IsLive { get; set; }

        public int VideoShowID { get; set; }

        public string VideoShow { get; set; }

        public int VideoCommunityID { get; set; }

        public string VideoCommunity { get; set; }
    }

    public class DropdownCommunity
    {
        public int CommunityID { get; set; }

        public string CommunityName { get; set; }

        public IEnumerable<CommunityShows> Shows { get; set; }
    }

    public class CommunityShows
    {
        public int ShowId { get; set; }

        public string ShowName { get; set; }

        public string ShowImageUrl { get; set; }

        public string VideoDate { get; set; }
    }
}
