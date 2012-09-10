using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CampBox.Data.Implementations;
using CampBox.Data.Models;

namespace CampBox.Controllers
{
    public class CampingController : ApiController
    {
        // GET api/camping
        public IEnumerable<Camp> Get()
        {
            var repo = new CampRepository();
            return repo.Get();
        }

        // GET api/camping/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/camping
        public void Post([FromUri]string value)
        {
            var repo = new CampRepository();
            repo.Insert(new Camp { Title = value });
        }

        // PUT api/camping/5
        public void Put(int id, [FromUri]string value)
        {
        }

        // DELETE api/camping/5
        public void Delete(int id)
        {
        }
    }
}
