using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using FethiTekyaygilWebsite.MVC.Model.VideoModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace FethiTekyaygilWebsite.MVC.Controllers
{
    public class VideosController : Controller
    {
        IConfigurationRoot configuration;
        public VideosController()
        {
            configuration = new ConfigurationBuilder()
           .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
           .AddJsonFile("appsettings.json")
           .Build();
        }

        public IActionResult Index()
        {
            VideoIndexModel vim = new VideoIndexModel();

            using (var connObject = new SqlConnection(configuration.GetConnectionString("MsSQL")))
            {
                string showcaseQuery = @" SELECT TOP 3 v.ID as VideoID,
                                        v.ThumbnailUrl as VideoThumbnail,
                                        v.Name as VideoName,
                                        v.Description as VideoDescription,
                                        v.IsLive,
                                        s.Name as VideoShow,
                                        c.Name as VideoCommunity,
                                        s.ID as VideoShowID,
                                        c.ID as VideoCommunityID
                                        FROM VideoTable as v JOIN ShowTable as s ON v.ShowID=s.ID 
                                        JOIN CommunityTable as c ON s.CommunityID=c.ID
                                        ORDER BY v.Date DESC";

                string dropdownCommunitiesQuery = @"SELECT c.ID as CommunityID, c.Name as CommunityName FROM CommunityTable c";

                string dropdownShowsQueryPrefix = "SELECT TOP 6 ID as ShowID, Name as ShowName,ImageUrl as ShowImageUrl FROM ShowTable WHERE CommunityID=";

                connObject.Open();

                vim.ShowcaseVideos = connObject.Query<ShowcaseVideo>(showcaseQuery);


                IEnumerable<DropdownCommunity> communities = connObject.Query<DropdownCommunity>(dropdownCommunitiesQuery);

                foreach (var c in communities)
                {
                    c.Shows = connObject.Query<CommunityShows>(dropdownShowsQueryPrefix + c.CommunityID);
                }

                vim.DropdownCommunities = communities;

                string baseLiveQuery = @"SELECT TOP 1 v.ID,
                                        v.Name,
                                        v.Description as Description,
                                        l.Url4 as VideoUrl,
                                        s.Name as ShowName,
                                        c.Name as CommunityName,
                                        s.ID as ShowID,
                                        c.ID as CommunityID,
                                        s.ImageUrl as ShowImageUrl
                                        FROM VideoTable as v JOIN ShowTable as s ON v.ShowID=s.ID 
                                        JOIN LinkTable l ON v.LinkID=l.ID
                                        JOIN CommunityTable as c ON s.CommunityID=c.ID";

                string liveVideoQuery = baseLiveQuery+ " WHERE IsLive=1";

                vim.LiveVideo=connObject.Query<LiveVideo>(liveVideoQuery).FirstOrDefault();

                string upcomingLiveVideoQuery = baseLiveQuery + " WHERE IsScheduled=1";

                vim.UpcomingLiveVideo= connObject.Query<LiveVideo>(upcomingLiveVideoQuery).FirstOrDefault();

                connObject.Close();
            }

            return View(vim);
        }

        public IActionResult Episode(int id)
        {
            EpisodeModel em = null;
            using (var connObject = new SqlConnection(configuration.GetConnectionString("MsSQL")))
            {
                string episodeQuery = @"SELECT v.ID,v.Name, l.Url4 as VideoUrl,v.Description,
                                    s.ID as ShowID,s.Name as ShowName,s.ImageUrl as ShowImageUrl,
                                    c.ID as CommunityID, c.Name as CommunityName
                                    FROM VideoTable v JOIN LinkTable l ON v.LinkID=l.ID 
                                    JOIN ShowTable s ON v.ShowID=s.ID
                                    JOIN CommunityTable c ON s.CommunityID=c.ID
                                    WHERE v.ID=" + id;

                connObject.Open();

                em = connObject.Query<EpisodeModel>(episodeQuery).FirstOrDefault();



                string otherEpisodesQuery = @"SELECT ID as EpisodeID,Name as EpisodeName FROM VideoTable WHERE ShowID=" + em.ShowID + " AND ID !=" + em.ID + " ORDER BY Date DESC";


                em.OtherEpisodes = connObject.Query<OtherEpisode>(otherEpisodesQuery);


                connObject.Close();

            }

            return View(em);
        }

        public IActionResult AllVideos(AllVideosFilter filter)
        {
            AllVideosModel avm = new AllVideosModel();
            using (var connObject = new SqlConnection(configuration.GetConnectionString("MsSQL")))
            {
                string allEpisodesQuery = CreateAllVideosScript(filter);

                connObject.Open();

                avm.Episodes = connObject.Query<AllEpisodesModel>(allEpisodesQuery);

                avm.Communities = connObject.Query<AllCommunityModel>("SELECT ID,Name FROM CommunityTable");

                avm.Shows = connObject.Query<AllShowModel>("SELECT ID,Name FROM ShowTable");
                connObject.Close();
            }

            avm.Page = filter.Page;
            return View(avm);
        }

        private string CreateAllVideosScript(AllVideosFilter filter)
        {
            if (filter.ShowID != null)
            {
                filter.CommunityID = null;
            }
            string qry = @"SELECT v.ID,v.Name,v.ThumbnailUrl,
                           s.ID as ShowID, c.ID as CommunityID,
                           s.Name as ShowName, c.Name as CommunityName
                           FROM VideoTable v 
                           JOIN ShowTable s ON v.ShowID = s.ID
                           JOIN CommunityTable c ON s.CommunityID=c.ID
                            WHERE v.IsLive=0 AND v.IsScheduled=0";

            if (filter.Name != null)
            {
                qry += @" AND (v.Name LIKE '%" + filter.Name + "%' OR s.Name LIKE '%" + filter.Name + "%' " +
                    "OR c.Name LIKE '%" + filter.Name + "%')";
            }
            else if (filter.CommunityID.HasValue)
            {
                qry += " AND c.ID=" + filter.CommunityID.Value;
            }
            else if (filter.ShowID.HasValue)
            {
                qry += " AND s.ID=" + filter.ShowID.Value;
            }

            qry += @" ORDER BY v.Date 
                           OFFSET " + 20 * filter.Page + " ROWS FETCH NEXT 20 ROWS ONLY";
            return qry;
        }
    }
}