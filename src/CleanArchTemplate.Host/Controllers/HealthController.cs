using CleanArchTemplate.Host.Controllers.Base;

using Microsoft.AspNetCore.Mvc;

namespace CleanArchTemplate.Host.Controllers;

public class HealthController : BaseController
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok("Hello World!");
    }
}