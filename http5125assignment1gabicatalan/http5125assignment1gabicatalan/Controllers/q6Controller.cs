using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace http5125assignment1gabicatalan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6Controller : ControllerBase
    {
        ///<summary>Receives a number representing the length of the side of a hexagon, then calculates and returns the area of that hexagon</summary>
        ///<param name="side">The length of the side of the hexagon</param>
        ///<returns>The area of the hexagon</returns>
        ///<example>
        ///GET : https://localhost:7181/api/q6/hexagon?side=1 -> 2.598076211353316
        ///GET : https://localhost:7181/api/q6/hexagon?side=1.5 -> 5.845671475544961
        ///GET :https://localhost:7181/api/q6/hexagon?side=20 -> 1039.2304845413264
        /// </example>

        [HttpGet(template:"hexagon")]
        public double hexagon(double side)
    {
        double S = side;
        double exponent = 2;
        double area = (3 * Math.Sqrt(3) / 2) * Math.Pow(S, exponent);
        return area;
        
    }
    }
}
