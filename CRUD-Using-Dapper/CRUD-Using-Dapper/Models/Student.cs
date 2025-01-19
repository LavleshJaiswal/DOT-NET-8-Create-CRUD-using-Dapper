namespace CRUD_Using_Dapper.Models;
[Table("StudentsRecords")]
public class Student
{
    [DisplayName("Student Id")]
    public int StudentId { get; set; }
    [DisplayName("Enter Student Name"), Required(ErrorMessage = "Student Name is Required", AllowEmptyStrings = true), StringLength(50, ErrorMessage = "Student Name cane exceed 50 chanracters")]
    public string StudentName { get; set; }
    [DisplayName("Enter Cource Name"), StringLength(50, ErrorMessage = "Course can not be exceed than 50 characters")]
    public string Course { get; set; }
    [Required(ErrorMessage = "Enter Student Age"),Range(4,30,ErrorMessage ="Age must be between 5 and 30")]
    public int Age { get; set; }
    [NotMapped]
    public string? Description { get; set; }
    [DisplayName("Enter Father's Name"), Column("FatherName")]
    public string? FatherName { get; set; }
}
