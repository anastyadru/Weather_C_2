using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Weather_C_2
{
    public class Information
    {
        
        public async Task<WeatherData> PrintAsync(string city)
        {
            using (var client = new HttpClient())
            {
                var cityName = Console.ReadLine();
                var apiKey = "your_api_key_here";
                var url =
                    $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=metric&lang=ru";
                
                HttpResponseMessage response = await client.GetAsync(url);

                string responseBody = await response.Content.ReadAsStringAsync();

                WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(responseBody);

                Console.WriteLine();
                Console.ReadLine();
            }
        }
        
    }
}