using System.Data;

namespace CRUD_Using_Dapper.Repositories;
public class StudentRepository(DapperContext _context) : IStudentRepository
{
    public async Task<IEnumerable<Student>> GetAllStudentsAsync()
    {
        var paremeters = new { Action = CRUDEnum.Select_Record };
        using var connection = _context.CreateConnection();
        return await connection.QueryAsync<Student>("StudentCRUD", paremeters, commandType: CommandType.StoredProcedure);
    }

    public async Task<Student> GetStudentByIdAsync(int id)
    {
        const string query = "SELECT * FROM StudentsRecords WHERE StudentId = @Id";
        using var connection = _context.CreateConnection();
        return await connection.QueryFirstOrDefaultAsync<Student>(query, new { Id = id });
    }

    public async Task<int> AddStudentAsync(Student student)
    {
        const string query = "INSERT INTO StudentsRecords (StudentName, Age, Course) VALUES (@StudentName, @Age, @Course)";
        using var connection = _context.CreateConnection();
        return await connection.ExecuteAsync(query, student);
    }

    public async Task<int> UpdateStudentAsync(Student student)
    {
        const string query = "UPDATE StudentsRecords SET StudentName = @StudentName, Age = @Age, Course = @Course WHERE StudentId = @StudentId";
        using var connection = _context.CreateConnection();
        return await connection.ExecuteAsync(query, student);
    }

    public async Task<int> DeleteStudentAsync(int id)
    {
        const string query = "DELETE FROM StudentsRecords WHERE StudentId = @Id";
        using var connection = _context.CreateConnection();
        return await connection.ExecuteAsync(query, new { Id = id });
    }
}
