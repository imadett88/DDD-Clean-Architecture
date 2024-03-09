using MediatR;
using Application.Students.Model;
using Domain.Students.Repositories;
 

namespace Application.Students
{
    public class GetStudentsQueryHandler 
    {

        private readonly IStudentRepository _studentRepository;

        public GetStudentsQueryHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async List<Student> Handle(GetStudentsQuery query, CancellationToken cancellationToken)
        {
            //validation

            //data
            var resultData = _studentRepository.GetAll(cancellationToken);

            //model
            var students = new List<Student>();
            foreach(var student in resultData)
            {
                students.Add(Student.ToModel(student));
            }

            //response

            return students;
        }

        Task<List<Student>> IRequestHandler<GetStudentsQuery, List<Student>>.Handle(GetStudentsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        
    }
}
