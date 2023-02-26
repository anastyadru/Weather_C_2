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
        public static async Task ConnectAsync()
        {
            WebRequest request = WebRequest.Create(url);
            string url = "https://api.openweathermap.org/data/2.5/weather?q={cityName}&units=metric&lang=ru&appid=1a5442d5206cd9ef2bfc21e5ca523b75";
            request.Method = "POST";
            WebResponse response = await request.GetResponseAsync();
            string answer = string.Empty;
            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    answer = await reader.ReadToEndAsync();
                }
            }
            response.Close();
            
            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(answer);
            // WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
            
            // using (var client = new HttpClient()) // создала экземпляра HTTP-клиента
            // {
            // var response = await client.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={cityName}&units=metric&lang=ru&appid=1a5442d5206cd9ef2bfc21e5ca523b75");
            // }

            // WebRequest request = WebRequest.Create(url); // отправила запрос и получила ответ
            // WebResponse response = request.GetResponse();
            
            // Stream dataStream = response.GetResponseStream(); // считала данные из ответа
            // StreamReader reader = new StreamReader(dataStream);
            // string responseFromServer = reader.ReadToEnd();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите название города: \n1) Minsk \n2) Vitebsk \n3) Novopolotsk \n4) Brest \n5) Grodno");
            var cityNumber = int.Parse(Console.ReadLine());
                
            var cityName = Console.ReadLine();

            try
            {
                switch (cityNumber)
                {
                    case 1: 
                        cityName = "Minsk";
                        string url = "https://api.openweathermap.org/data/2.5/weather?q=Minsk&units=metric&lang=ru&appid=d6bfd60ae10dc578300a860f105ed749";
                        GetForecastAsync(Cities.Minsk).Wait();
                        Console.WriteLine("Погода в городе Минск:");
                        Console.WriteLine($"Температура: {GetForecastAsync(Cities.Minsk).Result.Main.Temp}");
                        Console.WriteLine($"Давление: {GetForecastAsync(Cities.Minsk).Result.Main.Pressure}");
                        Console.WriteLine($"Влажность: {GetForecastAsync(Cities.Minsk).Result.Main.Humidity}");
                        break;
                    
                    case 2: 
                        cityName = "Vitebsk";
                        string url = "https://api.openweathermap.org/data/2.5/weather?q=Vitebsk&units=metric&lang=ru&appid=f1451f839fdb9f6c9c04a07f128795ec";
                        GetForecastAsync(Cities.Vitebsk).Wait();
                        Console.WriteLine("Погода в городе Витебск:");
                        Console.WriteLine($"Температура: {GetForecastAsync(Cities.Vitebsk).Result.Main.Temp}");
                        Console.WriteLine($"Давление: {GetForecastAsync(Cities.Vitebsk).Result.Main.Pressure}");
                        Console.WriteLine($"Влажность: {GetForecastAsync(Cities.Vitebsk).Result.Main.Humidity}");
                        break;
                    
                    case 3: 
                        cityName = "Novopolotsk";
                        string url = "https://api.openweathermap.org/data/2.5/weather?q=Novopolotsk&units=metric&lang=ru&appid=8eedcba634b7c5a1f7fa0261db5cf635";
                        GetForecastAsync(Cities.Novopolotsk).Wait();
                        Console.WriteLine("Погода в городе Новополоцк:");
                        Console.WriteLine($"Температура: {GetForecastAsync(Cities.Novopolotsk).Result.Main.Temp}");
                        Console.WriteLine($"Давление: {GetForecastAsync(Cities.Novopolotsk).Result.Main.Pressure}");
                        Console.WriteLine($"Влажность: {GetForecastAsync(Cities.Novopolotsk).Result.Main.Humidity}");
                        break;
                    
                    case 4: 
                        cityName = "Brest";
                        string url = "https://api.openweathermap.org/data/2.5/weather?q=Brest&units=metric&lang=ru&appid=55dca5e21670cdbf9b77d287b4965ab6";
                        GetForecastAsync(Cities.Brest).Wait();
                        Console.WriteLine("Погода в городе Брест:");
                        Console.WriteLine($"Температура: {GetForecastAsync(Cities.Brest).Result.Main.Temp}");
                        Console.WriteLine($"Давление: {GetForecastAsync(Cities.Brest).Result.Main.Pressure}");
                        Console.WriteLine($"Влажность: {GetForecastAsync(Cities.Brest).Result.Main.Humidity}");
                        break;
                    
                    case 5:
                        cityName = "Grodno";
                        string url = "https://api.openweathermap.org/data/2.5/weather?q=Grodno&units=metric&lang=ru&appid=a7eaf17a7cf263d162e40c802f229cd7";
                        GetForecastAsync(Cities.Grodno).Wait();
                        Console.WriteLine("Погода в городе Гродно:");
                        Console.WriteLine($"Температура: {GetForecastAsync(Cities.Grodno).Result.Main.Temp}");
                        Console.WriteLine($"Давление: {GetForecastAsync(Cities.Grodno).Result.Main.Pressure}");
                        Console.WriteLine($"Влажность: {GetForecastAsync(Cities.Grodno).Result.Main.Humidity}");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.Write("Город не найден или что-то пошло не так");
            }
            Console.ReadKey();
        }
    }
}