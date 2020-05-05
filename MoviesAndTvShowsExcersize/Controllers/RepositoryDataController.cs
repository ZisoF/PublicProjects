using MoviesAndTvShowsExcersize.Data;
using MoviesAndTvShowsExcersize.Managers;
using System.Web.Http;

namespace MoviesAndTvShowsExcersize.Controllers
{
    [RoutePrefix("api/getAllCtrl")]
    public class RepositoryDataController : ApiController
    {
        [Route("getall")]
        [HttpGet]
        public ResponseObject GetAll()
        {
            return RepositoryMng.GetAll();
        }
    }
}
