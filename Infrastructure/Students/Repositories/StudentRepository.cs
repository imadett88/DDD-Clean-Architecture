using Domain.Students.Entities;
using Domain.Students.Repositories;

namespace Infrastructure.Students.Repositories
{
    public class StudentRepository : IStudentRepository
    {

        private List<StudentEntity> _students = new List<StudentEntity>
        {
            new StudentEntity { Id =1, Name = "Hamza", Age =30 },
            new StudentEntity { Id =1, Name = "Imad", Age =22 },
            new StudentEntity { Id =1, Name = "Yasser", Age =22 },
            new StudentEntity { Id =1, Name = "Abdelemalk", Age =23 },


        };


        public List<StudentEntity> GetAll(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
