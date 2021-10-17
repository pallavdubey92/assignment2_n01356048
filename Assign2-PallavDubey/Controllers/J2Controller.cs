using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign2_PallavDubey.Controllers
{
    [RoutePrefix("api/j2")]
    public class J2Controller : ApiController
    {
        /// <summary>
        /// determines the no of ways we can roll 10
        /// </summary>
        /// <param name="m">no of sides on first dice, should be positive int</param>
        /// <param name="n">no of sides on second dice, should be positive int</param>
        /// <returns>message with total no of ways</returns>
        [HttpGet]
        [Route("DiceGame/{m:int}/{n:int}")]
        public string Get(int m, int n)
        {
            if(m <= 0 || n <= 0)
            {
                return "Invalid input. Please enter a value greater than 0.";
            }

            int noOfWays = 0;

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i + j == 10)
                    {
                        noOfWays += 1;
                    }
                }
            }

            return "There are total " + noOfWays.ToString() + " to get the sum 10.";
        }
    }
}
