using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assign2_PallavDubey.Controllers
{
    [RoutePrefix("api/j3")]
    public class J3Controller : ApiController
    {
        /// <summary>
        /// https://cemc.math.uwaterloo.ca/contests/computing/2021/ccc/juniorEF.pdf
        /// J3 problem on page 9
        /// </summary>
        /// <param name="input">takes series of 5 digit instruction separated by comma</param>
        /// <returns>decoded directions in array</returns>
        /// Sample Input
        /// localhost:53023/api/j3/biofuel/57234,00907,34100,99999
        /// 
        /// Output for Sample Input
        /// right 234
        /// right 907
        /// left 100
        [Route("BioFuel/{input}")]
        public string[] Get(string input)
        {
            string[] instructions = input.Split(',');

            // first instruction cannot start with 00
            // input should have at least two instructions
            if (input.StartsWith("00") && instructions.Length < 2)
            {
                return new string[] { "Invalid input." };
            }

            string[] directions = new string[instructions.Length - 1];

            // run loop from 0 to length-1 because last no does not represent direction
            for (int i = 0; i < instructions.Length - 1; i++)
            {
                // get first digit as int
                char firstChar = instructions[i][0];
                int first = int.Parse(firstChar.ToString());

                // get second digit as int
                char secondChar = instructions[i][1];
                int second = int.Parse(secondChar.ToString());

                int sum = first + second;
                int remainder = sum % 2;

                string direction = "left";
                if (first + second == 0)
                {
                    // assign previous direction if sun is 0
                    direction = directions[i - 1].Split(' ')[0];
                }
                else if (remainder == 0)
                {
                    direction = "right";
                }

                // get last 3 digits as no of steps
                int steps = int.Parse(instructions[i].Substring(2));

                directions[i] = direction + " " + steps.ToString();
            }

            return directions;
        }
    }
}
