using SchoolsService.Models;
using System.Collections.Generic;

namespace SchoolsService.Repository
{
    public interface ISchoolRepository
    {
        IEnumerable<School> GetAll();
        School Get(int id);
        void Create(School school);
        void Update(School school);
    }
}