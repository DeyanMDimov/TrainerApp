using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TrainingApp.Models;

namespace TrainingApp.Controllers
{

    [Authorize]
    public class EntryController : ApiController
    {
        private ApplicationDbContext _context;

        public EntryController()
        {
            _context = new ApplicationDbContext();
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            var Entries = _context.Entries.ToList();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public Entry Get(int id)
        {    
            var selectedEntry = _context.Entries.SingleOrDefault(i => i.EntryID == id);
            
            return selectedEntry;
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
