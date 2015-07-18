using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi2azure.Models;

namespace webapi2azure.Controllers
{
    
    public class PersonController : ApiController
    {
        static Dictionary<string, Person> dictionary = new Dictionary<string, Person>();

        // GET: api/Person/5
        public IHttpActionResult Get(string pnr)
        {
            if (dictionary.ContainsKey(pnr))
            {
                Person person = dictionary[pnr];
                return Ok(person);
            }
            return NotFound();
        }

        public IHttpActionResult Get()
        {
            Person[] list = dictionary.Values.ToArray();
            return Ok(list);
        }

        // POST: api/Person
       
        public IHttpActionResult Post([FromBody]Person person)
        {
            if (!dictionary.ContainsKey(person.Pnr))
            {
                dictionary.Add(person.Pnr, person);
                return Ok();
            }
            else return Conflict();
        }

        // DELETE: api/Person/5
        public IHttpActionResult Delete(string pnr)
        {
            if (dictionary.Remove(pnr))
            {
                return Ok();
            } else
            {
                return NotFound();
            }
           
        }
    }
}
