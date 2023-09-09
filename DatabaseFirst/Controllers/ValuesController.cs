using DatabaseFirst.DBContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Filters;

namespace DatabaseFirst.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly DatabasefirstEntities databasefirstEntities;

        public ValuesController()
        {
            this.databasefirstEntities = new DatabasefirstEntities();
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpPost]
        [ActionName("CreateEmployee")]
        public int CreateEmployee(Employee emp)
        {
            this.databasefirstEntities.Employees.Add(emp);
            this.databasefirstEntities.SaveChanges();
            return emp.Emp_id;
        }

        [HttpPut]
        [ActionName("UpdateEmployee")]
        public int UpdateEmployee(Employee emp) 
        {
            Employee existingrecord = this.databasefirstEntities.Employees.Where(x => x.Emp_id == emp.Emp_id).FirstOrDefault();
            this.databasefirstEntities.Entry(existingrecord).CurrentValues.SetValues(emp);
            this.databasefirstEntities.SaveChanges();
            return emp.Emp_id;
        }

        [Authorize]
        [ActionName("GetEmployees")]
        public IEnumerable<Employee> GetEmployees()
        {
           return this.databasefirstEntities.Employees.ToList();
            
        }

        [ActionName("GetEmployee")]
        public async Task<Employee> GetEmployee(int id)
        {
            return await this.databasefirstEntities.Employees.Where(x => x.Emp_id == id).FirstAsync();

        }

        //public ienumerable<employee> getemployee(int id)
        //{
        //    return this.databasefirstentities.employees.where(x => x.emp_id == id).firstordefault();
        //}

        [HttpDelete]
        [ActionName("DeleteEmployee")]
        public void DeleteEmployee(int id)
        {
            var remove =  this.databasefirstEntities.Employees.Where(x => x.Emp_id == id).FirstOrDefault();
            this.databasefirstEntities.Employees.Remove(remove);
            this.databasefirstEntities.SaveChanges();
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
