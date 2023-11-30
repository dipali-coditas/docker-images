using Microsoft.AspNetCore.Mvc;
using System.IO;

public class HomeController : ControllerBase
{
    [HttpGet("login")]
    public IActionResult GetLogin()
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "login.html");
        var content = System.IO.File.ReadAllText(path);
        return Content(content, "text/html");
    }

    [HttpGet("register")]
    public IActionResult GetRegister()
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "register.html");
        var content = System.IO.File.ReadAllText(path);
        return Content(content, "text/html");
    }
}
