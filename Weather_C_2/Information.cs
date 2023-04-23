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
            
            var client = new HttpClient(); // создан объект для отправки HTTP-запросов к серверу
            HttpResponseMessage response = await client.GetAsync(url);
            
            // отправлен GET-запрос на сервер по URL с помощью HttpClient и сохранен ответ response типа HttpResponseMessage
            // для получения ответа использован GetAsync(), вернул HttpResponseMessage с информацией
            
            string responseBody = await response.Content.ReadAsStringAsync();
            
            // программой считано тело ответа сервера в виде строки из объекта HttpResponseMessage с
            // помощью метода ReadAsStringAsync() и сохранено в переменную responseBody типа string
            
            WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(responseBody);
            
            // программой преобразовано responseBody в объект WeatherData с помощью метода JsonConvert.DeserializeObject()
            // из библиотеки Newtonsoft.Json и сохранено в переменную WeatherData
            
            Console.WriteLine();
            Console.ReadLine();
        }
        
    }
}