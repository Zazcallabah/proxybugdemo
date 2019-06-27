using System.Net;
using Microsoft.AspNetCore.Mvc;

public static async Task<IActionResult> Run(HttpRequest req, string name, ILogger log)
{
    return new OkObjectResult($"Hello: {name}");
}
