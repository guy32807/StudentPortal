using Microsoft.EntityFrameworkCore;
using StudentPortal.API.Models;

namespace StudentPortal.API.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentContext context;

        public StudentRepository(StudentContext context)
        {
            this.context = context;
        }
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await context.Student.ToListAsync();
        }
    }
}
