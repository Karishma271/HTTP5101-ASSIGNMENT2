using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_ASSIGNMENT2.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// Problem J3: Cell-Phone Messaging from 2006
        /// Identify patterns in a sequence of integers based on the provided parameters.
        /// </summary>
        /// <param name="param1">An integer parameter used in the identification process.</param>
        /// <param name="param2">A comma-separated string of integers representing the sequence to analyze.</param>
        /// <returns>A string message indicating the identified pattern or stating that the pattern is not identified.</returns>
        /// <example>
        ///     GET: /api/J3/YourRoute/5/1,3,5,7,9 => There is an arithmetic sequence with a common difference of 2.
        ///     GET: /api/J3/YourRoute/8/2,4,8,16 => The pattern is not identified.
        /// </example>

        [Route("api/J3/YourRoute/{param1}/{param2}")]
        [HttpGet]
        public string IdentifyPattern(int param1, string param2)
        {
            // Convert the string parameter 'param2' to an array of integers.
            int[] sequence = param2.Split(',').Select(int.Parse).ToArray();

            // Identify the pattern.
            bool isArithmeticSequence = IsArithmeticSequence(sequence);

            if (isArithmeticSequence)
            {
                // If the sequence is arithmetic, return information about the common difference.
                return "There is an arithmetic sequence with a common difference of " + (sequence[1] - sequence[0]) + ".";
            }
            else
            {
                // Add logic for other patterns.
                return "The pattern is not identified.";
            }
        }

        /// <summary>
        /// Check if the given sequence is an arithmetic sequence.
        /// </summary>
        /// <param name="sequence">An array of integers representing the sequence to analyze.</param>
        /// <returns>True if the sequence is an arithmetic sequence; otherwise, false.</returns>

        private bool IsArithmeticSequence(int[] sequence)
        {
            int commonDifference = sequence[1] - sequence[0];

            for (int i = 1; i < sequence.Length - 1; i++)
            {
                if (sequence[i + 1] - sequence[i] != commonDifference)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
