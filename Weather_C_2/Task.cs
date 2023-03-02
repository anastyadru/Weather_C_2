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

// WebRequest request = WebRequest.Create(url);
// request.Method = "POST";
// WebResponse response = await request.GetResponseAsync();
// string answer = string.Empty;
// using (Stream s = response.GetResponseStream())
// {
// using (StreamReader reader = new StreamReader(response.GetResponseStream()))
// {
// answer = await reader.ReadToEndAsync();
// }
// }
// response.Close();

// WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(answer);


// HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url); // отправила запрос и получила ответ
// HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
// string response;
// using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
//
// response = streamReader.ReadToEnd(); // считала текст с response
// }
// WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);