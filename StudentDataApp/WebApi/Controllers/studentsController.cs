using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccessLibrary;

namespace WebApi.Controllers
{
    //[Authorize]
    public class StudentsController : ApiController
    {
        // GET api/values
        public IEnumerable<Students> Get()
        {
            using (dbStudentsEntities studData = new dbStudentsEntities())
            {
                return studData.Students.ToList();
            }
        }

        // GET api/values/5
        public Students Get(string studentName)
        {
            using (dbStudentsEntities studData = new dbStudentsEntities())
            {
                return studData.Students.FirstOrDefault(s => s.sName.Contains(studentName));
            }
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
