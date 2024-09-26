using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace http5125assignment1gabicatalan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5Controller : ControllerBase
    {
        [HttpPost(template:"secret")]
        [Consumes("application/json")]
        ///<summary>
        ///Receives a number and returns a message confirming it as the secret number
        /// </summary>
        /// <param name="number">The secret number inputted</param>
        /// <return>
        /// Returns a message acknowledging the secret number
        /// </return>
        /// <example>
        /// POST : https://localhost:7181/api/q5/secret?number=5 -> 5
        /// Content-Type: application/json
        /// REQUEST BODY: 5
        /// POST : https://localhost:7181/api/q5/secret?number=-200 -> -200
        /// Content-Type: application/json
        /// REQUEST BODY: -200
        /// </example>
        public string secret(int number)
        {
            return ("Shh.. the secret is " + number);
        }
    }
}
