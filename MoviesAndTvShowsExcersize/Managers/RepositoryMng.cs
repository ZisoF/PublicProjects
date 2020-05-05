using MoviesAndTvShowsExcersize.Data;
using MoviesAndTvShowsExcersize.Services;

namespace MoviesAndTvShowsExcersize.Managers
{
    public static class RepositoryMng
    {
        public static ResponseObject GetAll()
        {
            return RepositorySrvc.GetAll();
        }
    }
}