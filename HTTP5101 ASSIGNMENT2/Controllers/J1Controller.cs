using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_ASSIGNMENT2.Controllers
{
    public class J1Controller : ApiController
    {

        /// <summary>
        /// Calculate total calories based on menu choices.
        /// </summary>
        /// <param name="burger">Integer representing the choice of burger.</param>
        /// <param name="drink">Integer representing the choice of drink.</param>
        /// <param name="side">Integer representing the choice of side order.</param>
        /// <param name="dessert">Integer representing the choice of dessert.</param>
        /// <returns>String message with the total calories of the meal.</returns>
        /// <example>
        ///     Get: /api/J1/Menu/4/4/4/ => Your total calorie count is 0.
        ///     GET: /api/J1/Menu/1/2/3/4 => Your total calorie count is 691.
        /// </example>


        // Calculate total calories based on menu choices
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]
        public string CalculateTotalCalories(int burger, int drink, int side, int dessert)
        {

            // Calorie information for menu items
            int[] burgerCalories = { 461, 431, 420, 0 };
            int[] drinkCalories = { 130, 160, 118, 0 };
            int[] sideCalories = { 100, 57, 70, 0 };
            int[] dessertCalories = { 167, 266, 75, 0 };


            // Calculate total calories based on menu choices
            int totalCalories = burgerCalories[burger - 1] +
                               drinkCalories[drink - 1] +
                               sideCalories[side - 1] +
                               dessertCalories[dessert - 1];


            // Response message
            return $"Your total calorie count is {totalCalories}";
        }
    }
}
