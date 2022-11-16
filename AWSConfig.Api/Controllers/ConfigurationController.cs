using AWSConfig.Api.Models.Config;
using Microsoft.AspNetCore.Mvc;

namespace AWSConfig.Api.Controllers;

[ApiController]
public class ConfigurationController : ControllerBase
{
    private readonly WebApiConfig config;

    public ConfigurationController(WebApiConfig config)
    {
        this.config = config;
    }

    [HttpGet("config")]
    public IActionResult GetConfig()
    {
        return Ok(this.config);
    }
}