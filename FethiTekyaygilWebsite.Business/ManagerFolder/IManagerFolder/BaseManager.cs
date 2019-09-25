using FethiTekyaygilWebsite.Business.HelperFolder;
using FethiTekyaygilWebsite.Data.Language;
using FethiTekyaygilWebsite.Data.Models.ResponseModels.GenericModels;
using System;

namespace FethiTekyaygilWebsite.Business.ManagerFolder.IManagerFolder
{
    public enum ResponseType
    {
        Error,
        Success
    }

    public class BaseManager : IManager
    {
        public ResponseObject<T> GetFilledResponse<T>(ResponseObject<T> response, ResponseType responseType, T obj, Exception ex = null)
        {
            if (responseType == ResponseType.Error)
            {
                response.IsSuccess = false;
                response.Message = LanguageDictionary.GetString("ErrorMessage");
            }
            else
            {
                response.IsSuccess = true;
                response.Message = LanguageDictionary.GetString("SuccessMessage");
                response.Object = obj;
            }

            return response;
        }
        
        public Exception GetExceptionDetail(Exception ex)
        {
            return ExceptionHelper.GetExceptionMessage(ex);
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
