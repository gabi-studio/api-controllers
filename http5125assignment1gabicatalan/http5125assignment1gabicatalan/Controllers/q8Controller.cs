using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Security.Principal;

namespace http5125assignment1gabicatalan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q8Controller : ControllerBase
    {
        /// <summary>
        /// Receives 2 numbers representing the number of orders for the small and for the large and uses them to create a checkout summary with the total 
        /// </summary>
        /// <param name="small">the number of small items</param>
        /// <param name="large">the number of large items</param>
        /// <returns>
        /// returns a string summarizing the the orders and total amount at checkout
        /// </returns>
        /// <example>
        /// POST : https://localhost:7181/api/q8/squashfellows?small=1&large=1 -> 1 Small @ $25.50 = $25.50; 1 Large @ $45.50 = $45.50;  Subtotal = $71.00; Tax = $9.23; Total = $80.23
        /// POST : https://localhost:7181/api/q8/squashfellows?small=2&large=1 -> 2 Small @ $25.50 = $51.00; 1 Large @ $45.50 = $45.50;  Subtotal = $96.50; Tax = $12.54; Total = $109.04
        /// POST : curl -H "Content-Type: application/x-www-form-urlencoded" -d "small=100&large=100" "https://localhost:7181/api/q8/squashfellows" -> 100 Small @ $25.50 = $2,550.00; 100 Large @ $45.50 = $4,550.00;  Subtotal = $7,100.00; Tax = $923.00; Total = $8,023.00
        /// </example>
        [HttpPost(template: "squashfellows")]
        [Consumes("application/x-www-form-urlencoded")]
        public string checkoutSummary([FromForm]int small, [FromForm]int large)
        {
            double smallPrice = 25.50;
            double largePrice = 45.50;
            double taxRate = 0.13;
            smallPrice = Math.Round(smallPrice, 2);
            largePrice = Math.Round(largePrice, 2);
            taxRate = Math.Round(taxRate, 2);

           

            /// calculate the subtotal:
            
            double smallTotal = smallPrice * small;
            double largeTotal = largePrice * large;
            double subtotal = smallTotal + largeTotal;
            smallTotal = Math.Round(smallTotal, 2);
            largeTotal = Math.Round(largeTotal, 2);
            subtotal = Math.Round(subtotal, 2);

            /// calculate the tax and total
            double tax = subtotal * taxRate;
            double total = subtotal + tax;
            tax = Math.Round(tax, 2);
            total = Math.Round(total, 2);

            // currency values


            // checkout summary 

            /* string checkoutSummary = $"{small} Small @ ${smallPrice} = ${smallTotal}; " +
                           $"{large} Large @ ${largePrice} = ${largeTotal}; " +
                           $"Subtotal = ${subtotal}; Tax = ${tax} HST; " +
                           $"Total = ${total}";*/


            return small + " Small @ " + (smallPrice.ToString("C2")) + " = " + (smallTotal.ToString("C2")) + "; " + large + " Large @ " + (largePrice.ToString("C2")) + " = " + (largeTotal.ToString("C2")) + ";  Subtotal = " + (subtotal.ToString("C2")) + "; Tax = " + (tax.ToString("C2")) + "; Total = " + (total.ToString("C2"));
 
        }

    }
}
