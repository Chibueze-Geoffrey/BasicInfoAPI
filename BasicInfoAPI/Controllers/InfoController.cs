using BasicInfoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicInfoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InfoController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetBasicInfo()
        {
            var response = new InfoResponse
            {
                Email = "chibuezegeoffrey@gmail.com",
                Datetime = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"),
                GithubUrl = "https://github.com/Chibueze-Geoffrey/BasicInfoAPI"
            };

            return await Task.FromResult(Ok(response));
        }

    }
}
