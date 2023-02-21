using System;
using System.IO;
using System.Net;
using System.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Weather_C_2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите название города: \n1) Minsk \n2) Vitebsk \n3) Novopolotsk \n4) Brest \n5) Grodno");
                // var i = int.Parse(Console.ReadLine());
                
                string cityName = Console.ReadLine();

                using (HttpClient client = new HttpClient()) // создала экземпляра HTTP-клиента
                {
                    string url = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&units=metric&lang=ru&appid=1a5442d5206cd9ef2bfc21e5ca523b75";
                }

                WebRequest request = WebRequest.Create(url); // отправила запрос и получила ответ
                WebResponse response = request.GetResponse();
            
                Stream dataStream = response.GetResponseStream(); // считала данные из ответа
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("Error:"+ex.Message); 
            }

            Console.ReadKey();
        }
    }
}

// WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);

// GetForecastAsync(Cities.Minsk).Wait();
// Console.WriteLine("Погода в городе Минск:");
// Console.WriteLine($"Температура: {GetForecastAsync(Cities.Minsk).Result.Main.Temp}");
// Console.WriteLine($"Давление: {GetForecastAsync(Cities.Minsk).Result.Main.Pressure}");
// Console.WriteLine($"Влажность: {GetForecastAsync(Cities.Minsk).Result.Main.Humidity}");

// units=metric - температура в Цельсиях

// string url = "https://api.openweathermap.org/data/2.5/weather?q=Minsk&units=metric&lang=ru&appid=d6bfd60ae10dc578300a860f105ed749";
// string url = "https://api.openweathermap.org/data/2.5/weather?q=Vitebsk&units=metric&lang=ru&appid=f1451f839fdb9f6c9c04a07f128795ec";
// string url = "https://api.openweathermap.org/data/2.5/weather?q=Novopolotsk&units=metric&lang=ru&appid=8eedcba634b7c5a1f7fa0261db5cf635";
// string url = "https://api.openweathermap.org/data/2.5/weather?q=Brest&units=metric&lang=ru&appid=55dca5e21670cdbf9b77d287b4965ab6";
// string url = "https://api.openweathermap.org/data/2.5/weather?q=Grodno&units=metric&lang=ru&appid=a7eaf17a7cf263d162e40c802f229cd7";

// GetForecastAsync(Cities.Vitebsk).Wait();
// Console.WriteLine("Погода в городе Витебск:");
// Console.WriteLine($"Температура: {GetForecastAsync(Cities.Vitebsk).Result.Main.Temp}");
// Console.WriteLine($"Давление: {GetForecastAsync(Cities.Vitebsk).Result.Main.Pressure}");
// Console.WriteLine($"Влажность: {GetForecastAsync(Cities.Vitebsk).Result.Main.Humidity}");

// GetForecastAsync(Cities.Novopolotsk).Wait();
// Console.WriteLine("Погода в городе Новополоцк:");
// Console.WriteLine($"Температура: {GetForecastAsync(Cities.Novopolotsk).Result.Main.Temp}");
// Console.WriteLine($"Давление: {GetForecastAsync(Cities.Novopolotsk).Result.Main.Pressure}");
// Console.WriteLine($"Влажность: {GetForecastAsync(Cities.Novopolotsk).Result.Main.Humidity}");

// GetForecastAsync(Cities.Brest).Wait();
// Console.WriteLine("Погода в городе Брест:");
// Console.WriteLine($"Температура: {GetForecastAsync(Cities.Brest).Result.Main.Temp}");
// Console.WriteLine($"Давление: {GetForecastAsync(Cities.Brest).Result.Main.Pressure}");
// Console.WriteLine($"Влажность: {GetForecastAsync(Cities.Brest).Result.Main.Humidity}");

// GetForecastAsync(Cities.Grodno).Wait();
// Console.WriteLine("Погода в городе Гродно:");
// Console.WriteLine($"Температура: {GetForecastAsync(Cities.Grodno).Result.Main.Temp}");
// Console.WriteLine($"Давление: {GetForecastAsync(Cities.Grodno).Result.Main.Pressure}");
// Console.WriteLine($"Влажность: {GetForecastAsync(Cities.Grodno).Result.Main.Humidity}");