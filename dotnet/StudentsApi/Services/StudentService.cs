using StudentsApi.Models;

namespace StudentsApi.Services
{
    public class StudentService : IStudentService
    {
        public Task<IEnumerable<Student>> GetStudents()
        {
            throw new NotImplementedException();
        }
        public Task<Student> GetStudent(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IEnumerable<Student>> GetStudentByName(string name)
        {
            throw new NotImplementedException();
        }
        public Task CreateStudent(Student student)
        {
            throw new NotImplementedException();
        }
        public Task UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
        public Task DeleteStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}