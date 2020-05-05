using MoviesAndTvShowsExcersize.Data;
using MoviesAndTvShowsExcersize.Data.ReponseObject;
using MoviesAndTvShowsExcersize.Logger;
using MoviesAndTvShowsExcersize.Utilities;
using System;

namespace MoviesAndTvShowsExcersize.Services
{
    public static class RepositorySrvc
    {
        public static ResponseObject GetAll()
        {
            ResponseObject responseObj = new ResponseObject();
            try
            {
                responseObj.Data = Convert.ToString(Utills.ReadStream(Config.JsonRepoDir));
            }
            catch (Exception ex)
            {
                Log.WriteEx(ex);
                responseObj.ErrObj = new ErrorObject()
                {
                    IsError = true,
                    ErrMessage = "Error Occured!"
                };
            }

            return responseObj;
        }
    }
}