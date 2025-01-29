using Microsoft.AspNetCore.Mvc;

namespace BasicInfoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InfoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetBasicInfo()
        {
            var response = new Dictionary<string, string>
            {
                { "email", "chibuezegeoffrey@gmail.com" },
                { "current_datetime", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ") },
                { "github_url", "https://github.com/Chibueze-Geoffrey/BasicInfoAPI" }
            };

            return Ok(response);
        }
    }
}
