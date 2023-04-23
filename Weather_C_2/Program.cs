using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Weather_C_2
{
    public class Program
    {
        
        public static string Main(string[] args)
        {
            string url;
            var cityName = Console.ReadLine();
            
            try
            {
                Console.WriteLine("Прогноз погоды на 5 дней для города: \n1 - Minsk \n2 - London \n3 - Paris \n4 - NewYork \n5 - Warsaw");
                
                switch (cityName)
                {
                    case "Minsk":
                        url = "https://api.openweathermap.org/data/2.5/weather?q=Minsk&appid=d6bfd60ae10dc578300a860f105ed749&units=metric&lang=ru";
                        break;

                    case "London":
                        url = "https://api.openweathermap.org/data/2.5/weather?q=London&appid=f1451f839fdb9f6c9c04a07f128795ec&units=metric&lang=ru";
                        break;

                    case "Paris":
                        url = "https://api.openweathermap.org/data/2.5/weather?q=Paris&appid=8eedcba634b7c5a1f7fa0261db5cf635&units=metric&lang=ru";
                        break;

                    case "NewYork":
                        url = "https://api.openweathermap.org/data/2.5/weather?q=NewYork&appid=55dca5e21670cdbf9b77d287b4965ab6&units=metric&lang=ru";
                        break;

                    case "Warsaw":
                        url = "https://api.openweathermap.org/data/2.5/weather?q=Warsaw&appid=a7eaf17a7cf263d162e40c802f229cd7&units=metric&lang=ru";
                        break;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine ("Такого города не существует в заготовленном списке. Введите город вручную: ");
                
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

