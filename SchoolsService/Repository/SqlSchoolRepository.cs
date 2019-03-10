using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolsService.Models;

namespace SchoolsService.Repository
{
    public class SqlSchoolRepository : BaseSqlRepository, ISchoolRepository
    {
        public void Create(School school)
        {
            throw new NotImplementedException();
        }

        public School Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<School> GetAll()
        {

        }

        public void Update(School school)
        {
            throw new NotImplementedException();
        }
    }
}