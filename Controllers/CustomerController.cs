using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APICrudServer.Data;
using Microsoft.EntityFrameworkCore;




namespace APICrudServer.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ApiDbContext _context;

        public CustomerController(ApiDbContext context)
        {
            _context = context;
        }


        [HttpGet]

        public async Task<ActionResult<List<Customer>>> GetCustomer()
        {
            return Ok(await _context.Customers.ToListAsync());
        }

    }
}
