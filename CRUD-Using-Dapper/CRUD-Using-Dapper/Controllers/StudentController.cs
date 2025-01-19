namespace CRUD_Using_Dapper.Controllers;
public class StudentController(IStudentRepository _repository) : Controller
{
    public async Task<IActionResult> Index()
    {
        var students = await _repository.GetAllStudentsAsync();
        return View(students);
    } 
    public IActionResult Create() => View();

    [HttpPost]
    public async Task<IActionResult> Create(Student student)
    {
        if (!ModelState.IsValid)
            return View(student);

        await _repository.AddStudentAsync(student);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(int id)
    {
        var student = await _repository.GetStudentByIdAsync(id);
        if (student == null)
            return NotFound();

        return View(student);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(Student student)
    {
        if (!ModelState.IsValid)
            return View(student);

        await _repository.UpdateStudentAsync(student);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Details(int id)
    {
        var student = await _repository.GetStudentByIdAsync(id);
        if (student == null)
            return NotFound();

        return View(student);
    }

    public async Task<IActionResult> Delete(int id)
    {
        await _repository.DeleteStudentAsync(id);
        return RedirectToAction(nameof(Index));
    }
}
