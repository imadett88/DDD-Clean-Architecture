using Domain.Students.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Students.Repositories
{
    public interface IStudentRepository
    {
        List<StudentEntity> GetAll(CancellationToken cancellationToken);
    }
}
