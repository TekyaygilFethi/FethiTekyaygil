using System;

namespace FethiTekyaygilWebsite.Business.HelperFolder
{
    public class ExceptionHelper
    {
        public static Exception GetExceptionMessage(Exception ex)
        {
            Exception tempException = ex;

            while (tempException.InnerException != null) ex = tempException.InnerException;

            return new Exception(tempException.Message);
        }
    }
}
