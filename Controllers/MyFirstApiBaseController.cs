using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers;
[Route("myfirstapi/[controller]")]
[ApiController]
public class MyFirstApiBaseController : ControllerBase
{
    public string Author => "Lucas de Lima";

    protected string GetCustomKey()
    {
        return Request.Headers["CustomKey"].ToString();
    }
    
    [HttpGet("healthy")]
    public IActionResult Get()
    {
        return Ok("It's working!");
    }
    
    

}
