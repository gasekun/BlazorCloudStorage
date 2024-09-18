using BlazorCloudStorage.Context;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCloudStorage.Controlers;

[Route("/api/[controller]")]
[ApiController]
public class Download(CloudDbContext db) : ControllerBase
{
    [HttpGet("/download/{Id}")]
    public IActionResult GetAll(string Id)
    {
        if (Guid.TryParse(Id, out var guid))
        {
            var fileStorage = db.Files.FirstOrDefault(item => item.Id == guid);
            if (fileStorage == null) return BadRequest();
            return File(System.IO.File.OpenRead(fileStorage.Path), "application/octet-stream", fileStorage.Name);
        }

        return NotFound();
    }
}