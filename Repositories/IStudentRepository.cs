using KTI.Models;

namespace KTI.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        Student GetById(int id);
    }
}