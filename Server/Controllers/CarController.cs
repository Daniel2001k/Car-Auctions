using CarAuctions.Server.Data;
using CarAuctions.Shared;
using CarAuctions.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarAuctions.Server.Controllers;

[ApiController]
[AllowAnonymous]
[Route($"api/{Routes.CarApi}/[action]")]
public class CarController(ILogger<ChatMessageController> logger) : ControllerBase
{
    private readonly ILogger<ChatMessageController> _logger = logger;

    [HttpGet]
    public ActionResult<IEnumerable<Car>> Get()
    {
		try
        {
            var cars = ExampleCars.GetAllCars();
            return Ok(cars);
        }
		catch (Exception ex)
        {
            _logger.LogError("Exception - \n\tType: {type}\n\tMessage: {message}", ex.GetType(), ex.Message);
            return BadRequest(ex.Message);
        }
    }
}
