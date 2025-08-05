using Microsoft.AspNetCore.Mvc;

namespace GiftWizard.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthCheckController : ControllerBase
{
    // Bu, mümkün olan en basit endpoint'tir.
    // Hiçbir parametre almaz, sadece bir yazı döner.
    [HttpGet]
    public string Get()
    {
        return "API is working!";
    }
}