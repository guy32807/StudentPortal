using StudentPortal.API.Models;

namespace StudentPortal.API.Repositories
{
    public interface IStudentRepository
    {
       Task<List<Student>> GetStudentsAsync();
    }
}
