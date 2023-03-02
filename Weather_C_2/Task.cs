using System;
using System.IO;
using System.Net;
using System.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Weather_C_2
{
    class Task
    {
        public static async Task GetWeatherDataAsync(string city)
        {
            Console.WriteLine("Прогноз погоды на 5 дней для города: ");
            var city_name = Console.ReadLine().ToLower();
            var api_key = "1a5442d5206cd9ef2bfc21e5ca523b75";


            var client = new HttpClient(); // создала экземпляра HTTP-клиента

            var url =
                $"https://api.openweathermap.org/data/2.5/weather?q={city_name}&appid={api_key}&units=metric&lang=ru";



            Console.WriteLine();
            Console.ReadLine();
        }
    }
}