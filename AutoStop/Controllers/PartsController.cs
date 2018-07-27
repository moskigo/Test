using System.Web.Http;
using System.Web.Http.Cors;
using AutoStop.Models;

namespace AutoStop.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PartsController : ApiController
    {

        
        public IHttpActionResult Get()
        {
            return Ok(new { results = TestData.GetParts() });
        }

       
        public IHttpActionResult Get(int id)
        {
            return Ok(new { results = TestData.GetAnalog(id) });
        }

        public IHttpActionResult Get(string str)
        {
            return Ok(new { results = TestData.GetByString(str) });
        }
    }
}
