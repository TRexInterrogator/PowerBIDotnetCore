using System;
using System.Collections.Generic;


namespace src
{
    public class WeatherForecast
    {
        public DateTime date { get; set; }
        public int temp_deg { get; set; } = 0;


        public WeatherForecast() { }



        /// <summary>
        /// Generates random weather data
        /// </summary>
        /// <param name="month">Month</param>
        /// <param name="year">Year</param>
        /// <returns>List of WeatherForecast items</returns>
        public static List<WeatherForecast> RequestMonthAsync(int month, int year) {
            
            var month_data = new List<WeatherForecast>();

            try {
                var selected_date = new DateTime(year, month, 1);
                var rand = new Random();

                while (selected_date.Month == month) {

                    month_data.Add(new WeatherForecast() { date = selected_date, temp_deg = rand.Next(10, 40) });
                    selected_date = selected_date.AddDays(1);
                }
            }
            catch (Exception ex) {
                Console.WriteLine($"!** Error while generating weather data: {ex.Message} **!");
            }

            return month_data;
        }
    }
}
