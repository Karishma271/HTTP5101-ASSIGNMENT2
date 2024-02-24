using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_ASSIGNMENT2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Receives two input m and n representing sides of 2 dice to determine the number of ways to obtain the value 10 by rolling the dice.
        /// </summary>
        /// <param name="m">Integer representing the number of sides on the first die</param>
        /// <param name="n">Integer representing the number of sides on the second die</param>
        /// <returns>String message with the total number of ways the sum 10 can be obtained when both dice are rolled</returns>
        /// <example>
        ///     GET: /api/J2/DiceGame/6/8 => There are 5 total ways to get the sum 10.
        ///     GET: /api/J2/DiceGame/12/4 => There are 4 ways to get the sum 10.
        ///     GET: /api/J2/DiceGame/3/3 => There are 0 ways to get the sum 10.
        ///     GET: /api/J2/DiceGame/5/5 => There is 1 way to get the sum 10.
        /// </example>
        [Route("api/J2/DiceGame/{m}/{n}")]
        [HttpGet]
        public string CalculateWaysToRollTen(int m, int n)
        {
            // Initialize a variable to count the ways to get the sum 10.
            int count = 0;

            // Loop through possible outcomes of the first die.
            for (int i = 1; i <= m; i++)
            {
                // Calculate the value needed on the second die.
                int j = 10 - i;

                // Check if the value 'j' is within the valid range for the second die.
                if (j >= 1 && j <= n)
                {
                    // Increment the count if the sum is valid.
                    count++;
                }
            }

            // Return a total number of ways to get the sum 10.
            return $"There are " + count + " total ways to get the sum 10.";
        }
    }
}

