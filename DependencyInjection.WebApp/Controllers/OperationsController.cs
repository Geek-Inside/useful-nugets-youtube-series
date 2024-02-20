using DependencyInjection.WebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.WebApp.Controllers;

[ApiController]
[Route("[controller]")]
public class OperationsController : Controller
{
    private readonly IOperationService _operationService;
    
    public OperationsController()
    {
        Console.WriteLine("Created");

        _operationService = new OperationService();
    }

    [HttpPost]
    public IActionResult PerformOperation()
    {
        return Ok();
    }
}