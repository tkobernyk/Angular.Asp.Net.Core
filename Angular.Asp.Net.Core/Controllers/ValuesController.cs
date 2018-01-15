using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Angular.Asp.Net.Core.Controllers
{
  [Route("api/[controller]")]
  public class ValuesController : Controller
  {

    [HttpGet]
    public IActionResult Get()
    {
      return Json(new [] { "Hello", "World" });
    }

  }
}
