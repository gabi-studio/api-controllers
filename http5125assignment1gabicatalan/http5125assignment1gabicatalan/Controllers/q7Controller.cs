using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace http5125assignment1gabicatalan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q7Controller : ControllerBase
    {
        ///<summary>
        ///Receives a number, and returns a date that is that many days adjusted before or after today's date
        ///</summary>
        ///<param name="days">The number of days from which to adjust today's date</param>
        ///<return>
        ///Returns a date adjusted from today's date
        /// </return>
        /// <example>
        /// GET : https://localhost:7181/api/q7/timemachine?days=1 -> 2024-09-23
        /// GET : https://localhost:7181/api/q7/timemachine?days=-2 -> 2024-09-21
        /// </example>

        [HttpGet(template:"timemachine")]
        public string adjustedDate(double days)
        {
            DateTime adjustedDate = DateTime.Today.AddDays(days);
            string formattedDate = adjustedDate.ToString("yyyy-MM-dd");
            return formattedDate;
        }
    }
}
