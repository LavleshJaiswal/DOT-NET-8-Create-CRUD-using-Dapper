namespace CRUD_Using_Dapper.Repositories;
public interface IStudentRepository
{
    Task<IEnumerable<Student>> GetAllStudentsAsync();
    Task<Student> GetStudentByIdAsync(int id);
    Task<int> AddStudentAsync(Student student);
    Task<int> UpdateStudentAsync(Student student);
    Task<int> DeleteStudentAsync(int id);
}
