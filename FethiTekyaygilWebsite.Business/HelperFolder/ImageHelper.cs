using System;
using System.IO;

namespace FethiTekyaygilWebsite.Business.HelperFolder
{
    public class ImageHelper
    {
        public static string ConvertToBase64(byte[] image,string extension)
        {
            return "data:image/"+extension+";base64," + Convert.ToBase64String(image);
        }

        public static byte[] ConvertToBLOB(string path)
        {
            return File.ReadAllBytes(path);
        }

    }
}
