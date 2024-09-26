using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace http5125assignment1gabicatalan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3Controller : ControllerBase
    {
        /// <summary>
        /// Receives a number input from the user and returns that number raised to the power of 3
        /// </summary>
        /// <param name="baseNumber">The base number that will be cubed</param>
        /// <returns>The result of the base number cubed</returns>
        /// <example>
        /// GET : https://localhost:7181/api/q3/cubed/4 -> 64
        /// GET : https://localhost:7181/api/q3/cubed/-4 -> -64
        /// GET : https://localhost:7181/api/q3/cubed/10 -> 1000
        /// </example>
        [HttpGet(template:"cube/{baseNumber}")]
        public int cube(int baseNumber)
        {
            const int CUBE = 3;
            return (int)Math.Pow(baseNumber, CUBE);
            
        }
    }
}
