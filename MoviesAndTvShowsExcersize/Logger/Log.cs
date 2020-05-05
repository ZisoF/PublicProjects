using MoviesAndTvShowsExcersize.Utilities;
using System;

namespace MoviesAndTvShowsExcersize.Logger
{
    public static class Log
    {
        public static void WriteEx(Exception ex)
        {
            Utills.WriteStream(Config.LogFileDir, string.Format("date: {0}; Msg: {1}; ExMsg: {2}; Source: {3}", DateTime.Now, ex.Message, ex.InnerException, ex.Source));
        }
    }
}