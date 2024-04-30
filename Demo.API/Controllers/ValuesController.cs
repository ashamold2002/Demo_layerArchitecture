using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Demo.Core;
namespace Demo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IEmpRepository _empRepository;

        public EmployeeController(IEmpRepository empRepository)
        {
            _empRepository = empRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<Employeedetail>> GetEmployees()
        {
            return await _empRepository.Get();
        }
    }
}
