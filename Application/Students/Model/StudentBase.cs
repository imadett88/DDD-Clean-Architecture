using Domain.Students.Entities;

namespace Application.Students.Model
{
    public class StudentBase
    {
        public int Id { get; set; }
    }

    public class StudentModel1 : StudentBase
    { 
        public string Name { get; set; }
    }

    public class StudentModel2 : StudentBase
    {
        public string Age { get; set; }
    }

    public class Student : StudentBase
    {
        public string Name { get; set; }
        public int Age { get; set; }

     
    }

    public Student ToModel(StudentEntity student)
    {
        return new Student
        {
            Id = student.Id,
            Name = student.Name,
            Age = student.Age
        }
    }
}
