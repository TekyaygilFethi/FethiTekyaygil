using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FethiTekyaygilWebsite.Data.GlobalDatas
{
    public class Globals
    {
        public static string Language { get; set; } = "TR"; //TR-EN

        public static string MediaFolder { get; } = "~\\Content\\Media";

        public static string LanguageWithExt { get { return Language + ".png"; } }
    }
}
