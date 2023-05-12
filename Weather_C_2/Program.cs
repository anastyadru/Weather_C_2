using System;
using Newtonsoft.Json;
using System.Net.Http;

namespace Weather_C_2
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            string url;
            string cityName;

            try
            {
                Console.WriteLine("Введите, для какого города прогноз погоды на 5 дней: Minsk, London, Paris, NewYork, Warsaw");
                cityName = Console.ReadLine();
                url = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid=d6bfd60ae10dc578300a860f105ed749&units=metric&lang=ru";
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine ("Такого города не существует в заготовленном списке. Введите город вручную: ");
                cityName = Console.ReadLine();
                url = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid=1a5442d5206cd9ef2bfc21e5ca523b75&units=metric&lang=ru";
            }
            
            var result = "";
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(url).Result; // выполнен асинхронный HTTP-запрос к URL-адресу, ожидаю ответа от сервера
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = response.Content.ReadAsStringAsync().Result;
                    WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(responseBody);
                    result += $"Погода в городе {cityName}: \n";
                    result += $"Температура: {WeatherData.Data.Temp}°C\n";
                    result += $"Температура ощущается на: {WeatherData.Data.FeelsLike}°C\n";
                    result += $"Давление: {WeatherData.Data.Pressure}Pa\n";
                    result += $"Влажность: {WeatherData.Data.Humidity}%\n";
                }
                
                else
                {
                    result += $"Ошибка получения данных о погоде в городе {cityName}\n";
                }
            }
            
            Console.ReadLine();
            return result;
        }
        
    }
}

