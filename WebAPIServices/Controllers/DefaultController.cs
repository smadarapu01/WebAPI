using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIServices.Controllers
{
    public class DefaultController : ApiController
    {

        public static List<string> collection = new List<string>()
        {
            "Value 1",
            "Value 2",
            "Value 3"
        };
        
        public IEnumerable<string> Get()
        {
            return collection;
        }

        public string Get(int Id)
        {
            return collection[Id];
        }

        public void Post([FromBody]string value)
        {
            collection.Add(value);
        }

        public void Put(int Id, [FromBody]string value)
        {
            collection[Id] = value;
        }

        public void Delete(int Id)
        {
            collection.RemoveAt(Id);
        }
    }
}
