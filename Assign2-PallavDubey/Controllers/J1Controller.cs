using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign2_PallavDubey.Controllers
{
    [RoutePrefix("api/j1")]
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Get total calorie count for the order
        /// </summary>
        /// <param name="burger">int between 1 to 4</param>
        /// <param name="drink">int between 1 to 4</param>
        /// <param name="side">int between 1 to 4</param>
        /// <param name="dessert">int between 1 to 4</param>
        /// <returns>message with total calories</returns>
        /// GET: /api/j1/calories/4/4/4/4
        [HttpGet]
        [Route("menu/{burger:int}/{drink:int}/{side:int}/{dessert:int}")]
        public string GetCalories(int burger, int drink, int side, int dessert)
        {
            int totalCalories = 0;

            // add calories for burger
            if (burger == 1)
            {
                totalCalories += 461;
            }
            else if (burger == 2)
            {
                totalCalories += 431;
            }
            else if (burger == 3)
            {
                totalCalories += 420;
            }
            else if (burger != 4)
            {
                return "Invalid input for burger.";
            }

            // add calories for drink
            if (drink == 1)
            {
                totalCalories += 130;
            }
            else if (drink == 2)
            {
                totalCalories += 160;
            }
            else if (drink == 3)
            {
                totalCalories += 118;
            }
            else if (drink != 4)
            {
                return "Invalid input for drink.";
            }

            // add calories for sides
            if (side == 1)
            {
                totalCalories += 100;
            }
            else if (side == 2)
            {
                totalCalories += 57;
            }
            else if (side == 3)
            {
                totalCalories += 70;
            }
            else if (side != 4)
            {
                return "Invalid input for side.";
            }

            // add calories for dessert
            if (dessert == 1)
            {
                totalCalories += 167;
            }
            else if (dessert == 2)
            {
                totalCalories += 266;
            }
            else if (dessert == 3)
            {
                totalCalories += 75;
            }
            else if (dessert != 4)
            {
                return "Invalid input for dessert.";
            }

            return "Your total calorie count is " + totalCalories.ToString();
        }
    }
}
