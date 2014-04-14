using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using WebApiSample.Models;

namespace WebApiSample.Controllers
{
    [RoutePrefix("api/program")]
    public class ProgramController : ApiController
    {
        [Route("getbycriteria")]
        [HttpGet]
        public HttpResponseMessage GetByCriteria([ModelBinder(typeof(CriteriaModelBinder))]CriteriaModel criteria)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}