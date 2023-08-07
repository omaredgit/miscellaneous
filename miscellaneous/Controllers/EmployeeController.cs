using Microsoft.AspNetCore.Mvc;
using miscellaneous.Data;
using miscellaneous.Models;
namespace miscellaneous.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {

        private readonly ILogger<EmployeeController>? _logger;
        private OfficeDB _db;
        public EmployeeController(ILogger<EmployeeController> logger, OfficeDB db)
        {
            _logger = logger;
            _db = db;
        }

        public EmployeeController(OfficeDB db)
        {
            _db = db;
        }


        [HttpGet(Name = "GetEmployeEf .net core e")]
        public async Task<IResult> Get(int id)
        {
         return await _db.Employees.FindAsync(id)
                is Employee e
                ? Results.Ok(e)
                : Results.NotFound();
        }

        [HttpPost(Name = "PostEmployee")]
        public async Task<IResult> Post(Employee e)
        {
            _db.Employees.Add(e);
            await _db.SaveChangesAsync();

            return Results.Created($"/employee/{e.Id}", e);
        }


    }

}
