using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIAssignment1.Models;
using APIAssignment1.Repositories;

namespace APIAssignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly bookrepo repo;
        public BookController()
        {
            repo = new bookrepo();
        }
        [HttpGet,Route("GetALLBoooks")]
        public IActionResult GetAllBOooks()
        {
            List<Books> bo = repo.GetAllBooks();
            return StatusCode(200,bo);
        }
    }
}
