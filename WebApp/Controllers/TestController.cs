using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

[Route("")]
public class TestController : ControllerBase
{
    [HttpGet("")]
    public ActionResult Get()
    {
        return Ok(new
        {
            Foo = "bar",
        });
    }

    [HttpGet("error")]
    public ActionResult GetError()
    {
        return Problem("An error occurred");
    }
}