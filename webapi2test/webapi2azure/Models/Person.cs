using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/**
Dette er en test
 */
namespace webapi2azure.Models
{
    public class Person
    {
        public string Pnr { get; set; }
        public string ForName { get; set; }
        public string SureName { get; set; }

        static public bool PnrStartWithD(Person person)
        {
            return person.Pnr.ToUpper().StartsWith("D");
        }
    }
}