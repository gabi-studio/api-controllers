using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Template;

namespace http5125assignment1gabicatalan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q1Controller : ControllerBase
    {

        /// <summary>
        /// This method returns a welcome message 
        /// </summary>
        /// <returns>Welcome to 5125!</returns>
        /// <example>
        /// GET : https://localhost:7181/api/q1/welcome -> Welcome to 5125!
        /// </example>
        [HttpGet(template:"welcome")]
        public string welcome()
        {
            return "Welcome to 5125!";
        }
    }
}
