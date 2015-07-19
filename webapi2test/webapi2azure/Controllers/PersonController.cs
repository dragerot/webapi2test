using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using webapi2azure.Models;

namespace webapi2azure.Controllers
{
    
    public class PersonController : ApiController
    {
        static Dictionary<string, Person> dictionary = new Dictionary<string, Person>();

        // GET: api/Person/5
        [ResponseType(typeof(Person))]
        public IHttpActionResult GetPerson(string pnr)
        {
            if (dictionary.ContainsKey(pnr))
            {
                Person person = dictionary[pnr];
                return Ok(person);
            }
            return NotFound();
        }

       
        public IHttpActionResult GetPersons()
        {
            Person[] list = dictionary.Values.ToArray();
            return Ok(list);
        }

        // POST: api/Person
        //[HttpPost]
        public IHttpActionResult PostPerson([FromBody]Person person)
        {
            if (!dictionary.ContainsKey(person.Pnr))
            {
                dictionary.Add(person.Pnr, person);
                return Ok();
            }
            else return Conflict();
        }

        // DELETE: api/Person/5
        public IHttpActionResult DeletePerson(string pnr)
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
