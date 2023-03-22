using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStore.Controllers;

public class HomeController : AbpController
{
    private readonly BookService _bookService;
    public HomeController(BookService bookService)
    {
        _bookService = bookService;
    }
    public ActionResult Index()
    {
        return Redirect("~/swagger");
    }
    [HttpGet("test")]

    public  async Task<IActionResult> IndexTest()
    {
       var data= await _bookService.GetAll();

        return  Ok(data);
    }

}
