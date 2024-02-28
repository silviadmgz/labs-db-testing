using Microsoft.AspNetCore.Mvc;

namespace labs_db_testing.Controllers;

[ApiController]
[Route("/[controller]")]
public class ItemsController : Controller
{
    private readonly DbConnection _context;
    public ItemsController(DbConnection context)
    {
        _context = context;
    }
}