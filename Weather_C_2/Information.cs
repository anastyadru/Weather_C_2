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
            var cityName = Console.ReadLine();
            var apiKey = "your_api_key_here"; // 1a5442d5206cd9ef2bfc21e5ca523b75
            var url = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=metric&lang=ru";
            
            var client = new HttpClient(); // создала объект для отправки HTTP-запросов к серверу
            HttpResponseMessage response = await client.GetAsync(url);
            
            // отправила GET-запрос на сервер по URL с помощью HttpClient и сохранила ответ response типа HttpResponseMessage
            // для получения ответа использовала GetAsync(), вернул HttpResponseMessage с информацией
            
            string responseBody = await response.Content.ReadAsStringAsync();
            
            // программа считала тело ответа сервера в виде строки из объекта HttpResponseMessage с
            // помощью метода ReadAsStringAsync() и сохранила его в переменную responseBody типа string
            
            WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(responseBody);
            
            // программа преобразовала responseBody в объект OpenWeather с помощью метода JsonConvert.DeserializeObject()
            // из библиотеки Newtonsoft.Json и сохранила его в переменную openWeather
            
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}


// HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url); // отправила запрос и получила ответ
// HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
// string response;
// using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
//
// response = streamReader.ReadToEnd(); // считала текст с response
// }
// WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);