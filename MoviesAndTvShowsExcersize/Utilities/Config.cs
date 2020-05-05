using System;
using System.Configuration;

namespace MoviesAndTvShowsExcersize.Utilities
{
    public static class Config
    {
        public static string JsonRepoDir
        {
            get
            {
                return System.Web.HttpContext.Current.Server.MapPath(ConfigurationManager.AppSettings["JsonRepoDirectory"]);
            }
        }

        public static string LogFileDir
        {
            get
            {
                return string.Format(System.Web.HttpContext.Current.Server.MapPath(ConfigurationManager.AppSettings["LogFileDirectory"]), DateTime.Now.ToString("ddMMyyy"));
            }
        }
    }
}