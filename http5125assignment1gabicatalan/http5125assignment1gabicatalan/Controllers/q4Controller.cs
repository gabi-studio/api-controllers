using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace http5125assignment1gabicatalan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q4Controller : ControllerBase
    {
        [HttpPost("knockknock")]
        ///<summary>
        ///Receives a POST request for the start of a knock knock joke
        /// </summary>
        /// <returns>
        /// A start to a knock knock joke
        /// </returns>
        /// <example>
        /// POST : https://localhost:7181/api/q4/knockknock
        /// REQUEST HEADERS : (NONE)
        /// REQUEST BODY : (NONE)
        /// -> Who's there?
        /// </example>
        public string knockknockJoke()
        {
            return "Who's there?";
        }
        
    }
}
