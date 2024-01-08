using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class DoctorController: ControllerBase
{
    private static readonly string[] Doctors = new[]
    {
       "Jackson", "Abigail", "Jennifer", "John", "Chuck", "Bryan", "Lily"
    };

    private readonly ILogger<DoctorController> _logger;

    public DoctorController(ILogger<DoctorController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "doctors")]
    public IEnumerable<Doctor> Get()
    {
        return Enumerable.Range(0, Doctors.Length).Select(index => new Doctor() 
            {
                name = Doctors[index],
            })
            .ToArray();
    }
}