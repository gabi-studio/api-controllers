using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace http5125assignment1gabicatalan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2Controller : ControllerBase
    {
        /// <summary>
        /// Receives a string input from the user and returns a welcome message using the inputted name
        /// </summary>
        /// <returns>A greeting with the named inputted!</returns>
        /// <example>
        /// GET : https://localhost:7181/api/q2/greeting/Gary -> Hi Gary!
        /// GET : https://localhost:7181/api/q2/Greeting/Ren%C3%A9e -> Hi Renée!
        /// </example>
        [HttpGet(template:"greeting/{name}")]
        public string greeting(string name)
        {
            string nameGreeting = "Hi " + name + "!";
            return nameGreeting;
        }
    }
}
