using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FethiTekyaygilWebsite.MVC.Model.VideoModels
{
    public class AllVideosFilter
    {

        public int Page { get; set; } = 0;
        public string Name { get; set; }

        public int? CommunityID { get; set; }

        public int? ShowID{ get; set; }
    }
}
