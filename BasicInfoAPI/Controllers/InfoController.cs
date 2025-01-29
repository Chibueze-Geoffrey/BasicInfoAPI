using BasicInfoAPI.Models;
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
            var response = new InfoResponse
            {
                Email = "chibuezegeoffrey@gmail.com",
                CurrentDatetime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"),
                GithubUrl = "https://github.com/Chibueze-Geoffrey/BasicInfoAPI"
            };

            return Ok(response);
        }
      
    }
}
