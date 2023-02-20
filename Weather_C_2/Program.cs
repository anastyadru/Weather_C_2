using System;
using System.IO;
using System.Net;
using System.Linq;
using Newtonsoft.Json;

namespace Weather_C_2
{
    class Program
    {
        async static Task Main(string[] args)
        {
            do
            {
                Console.WriteLine("Введите название города: \n1) Minsk \n2) Vitebsk \n3) Novopolotsk \n4) Brest \n5) Grodno");
                var i = int.Parse(Console.ReadLine());
                
                string city = Console.ReadLine();
            
                string url = "https://api.openweathermap.org/data/2.5/weather?q=" + city + "&units=metric&appid=1a5442d5206cd9ef2bfc21e5ca523b75";
            
                WebRequest request = WebRequest.Create(url); // Отправила запрос и получила ответ
                WebResponse response = request.GetResponse();
            
                Stream dataStream = response.GetResponseStream(); // Считала данные из ответа
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();

            
            
            
                // WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
            
                // {
                // try
                // {
                // GetForecastAsync(Cities.Minsk).Wait();
                // Console.WriteLine("Погода в городе Минск:");
                // Console.WriteLine($"Температура: {GetForecastAsync(Cities.Minsk).Result.Main.Temp}");
                // Console.WriteLine($"Давление: {GetForecastAsync(Cities.Minsk).Result.Main.Pressure}");
                // Console.WriteLine($"Влажность: {GetForecastAsync(Cities.Minsk).Result.Main.Humidity}");
                // Console.WriteLine($"Минимальная температура: {GetForecastAsync(Cities.Minsk).Result.Main.TempMin}");
                // Console.WriteLine($"Максимальная температура: {GetForecastAsync(Cities.Minsk).Result.Main.TempMax}");
                // }

                // catch (Exception ex)
                // {
                // Console.WriteLine(ex.Message);
                // }
                // Console.ReadKey();
                //}

            } 
            while (true);
        }
    }
}

// units=metric - температура в Цельсиях

// string url = "https://api.openweathermap.org/data/2.5/weather?q=Minsk&units=metric&appid=d6bfd60ae10dc578300a860f105ed749";
// string url = "https://api.openweathermap.org/data/2.5/weather?q=Vitebsk&units=metric&appid=f1451f839fdb9f6c9c04a07f128795ec";
// string url = "https://api.openweathermap.org/data/2.5/weather?q=Novopolotsk&units=metric&appid=8eedcba634b7c5a1f7fa0261db5cf635";
// string url = "https://api.openweathermap.org/data/2.5/weather?q=Brest&units=metric&appid=55dca5e21670cdbf9b77d287b4965ab6";
// string url = "https://api.openweathermap.org/data/2.5/weather?q=Grodno&units=metric&appid=a7eaf17a7cf263d162e40c802f229cd7";

// GetForecastAsync(Cities.Vitebsk).Wait();
// Console.WriteLine("Погода в городе Витебск:");
// Console.WriteLine($"Температура: {GetForecastAsync(Cities.Vitebsk).Result.Main.Temp}");
// Console.WriteLine($"Давление: {GetForecastAsync(Cities.Vitebsk).Result.Main.Pressure}");
// Console.WriteLine($"Влажность: {GetForecastAsync(Cities.Vitebsk).Result.Main.Humidity}");
// Console.WriteLine($"Минимальная температура: {GetForecastAsync(Cities.Vitebsk).Result.Main.TempMin}");
// Console.WriteLine($"Максимальная температура: {GetForecastAsync(Cities.Vitebsk).Result.Main.TempMax}");

// GetForecastAsync(Cities.Novopolotsk).Wait();
// Console.WriteLine("Погода в городе Новополоцк:");
// Console.WriteLine($"Температура: {GetForecastAsync(Cities.Novopolotsk).Result.Main.Temp}");
// Console.WriteLine($"Давление: {GetForecastAsync(Cities.Novopolotsk).Result.Main.Pressure}");
// Console.WriteLine($"Влажность: {GetForecastAsync(Cities.Novopolotsk).Result.Main.Humidity}");
// Console.WriteLine($"Минимальная температура: {GetForecastAsync(Cities.Novopolotsk).Result.Main.TempMin}");
// Console.WriteLine($"Максимальная температура: {GetForecastAsync(Cities.Novopolotsk).Result.Main.TempMax}");

// GetForecastAsync(Cities.Brest).Wait();
// Console.WriteLine("Погода в городе Брест:");
// Console.WriteLine($"Температура: {GetForecastAsync(Cities.Brest).Result.Main.Temp}");
// Console.WriteLine($"Давление: {GetForecastAsync(Cities.Brest).Result.Main.Pressure}");
// Console.WriteLine($"Влажность: {GetForecastAsync(Cities.Brest).Result.Main.Humidity}");
// Console.WriteLine($"Минимальная температура: {GetForecastAsync(Cities.Brest).Result.Main.TempMin}");
// Console.WriteLine($"Максимальная температура: {GetForecastAsync(Cities.Brest).Result.Main.TempMax}");

// GetForecastAsync(Cities.Grodno).Wait();
// Console.WriteLine("Погода в городе Гродно:");
// Console.WriteLine($"Температура: {GetForecastAsync(Cities.Grodno).Result.Main.Temp}");
// Console.WriteLine($"Давление: {GetForecastAsync(Cities.Grodno).Result.Main.Pressure}");
// Console.WriteLine($"Влажность: {GetForecastAsync(Cities.Grodno).Result.Main.Humidity}");
// Console.WriteLine($"Минимальная температура: {GetForecastAsync(Cities.Grodno).Result.Main.TempMin}");
// Console.WriteLine($"Максимальная температура: {GetForecastAsync(Cities.Grodno).Result.Main.TempMax}");
