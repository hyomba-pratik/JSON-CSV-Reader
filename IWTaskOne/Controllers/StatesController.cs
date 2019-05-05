
using Repositories.Interfaces;
using Repositories.Models;
using Repositories.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IWTaskOne.Controllers
{
    public class StatesController : ApiController
    {
        
        // GET api/values
        public IEnumerable<States> Get(string type)
        {
            IEnumerable<States> states = Enumerable.Empty<States>();
            if (type.Equals("csv")) {
                StatesCSVServices statesCSVServices = new StatesCSVServices();
                states = statesCSVServices.GetStates();
            } else if (type.Equals("json")) {
                StatesJSONServices statesJSONServices = new StatesJSONServices();
                states = statesJSONServices.GetStates();
            }
            else {
                
            }

            return states;

        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
