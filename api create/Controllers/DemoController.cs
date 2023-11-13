using api_create.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace api_create.Controllers
{
    public class DemoController : ApiController
    {
        [HttpGet]
        [Route("api/names")]
        public HttpResponseMessage Get()
        {
            var names = new string[] { "Asgor", "Reaj" };
            return Request.CreateResponse(HttpStatusCode.OK, names);
        }
        [HttpGet]
        [Route("api/name/")]
        public HttpResponseMessage GetName() 
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Ajgor");
        }
        [HttpGet]
        [Route("api/name/{st_id}")]
        public HttpResponseMessage GetName(int st_id)
        {
            string name = st_id == 1 ? "Asgor" : "not recognize";
            return Request.CreateResponse(HttpStatusCode.OK, name);
        }
        [HttpPost]
        [Route("api/test/post")]
        public HttpResponseMessage TestPost(Models.Login u)
        {
            return Request.CreateResponse(HttpStatusCode.OK,u.Uname);
        }

    }
}
