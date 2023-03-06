using System;
using System.Threading.Channels;
using Newtonsoft.Json.Linq;

namespace OpenWeatherAppApi
{
    public class WeatherAppAPI
    {

        public static void GetWeather()

        {
            var client = new HttpClient();
            var apiKey = "3673be0a7d751d0c6723f3cac50d107d";

            Console.WriteLine("What city would you like to know the weather for?");
            var cityName = Console.ReadLine();
            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";

            var weatherResponse = client.GetStringAsync(weatherURL).Result;
            var weatherObject = JObject.Parse(weatherResponse);

            Console.WriteLine($"{weatherObject["main"]["temp"]} degrees Fahrenheit for {cityName}");

            


        }
         
    }
}

