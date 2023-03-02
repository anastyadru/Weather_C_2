﻿using System;
using System.IO;
using System.Net;
using System.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Weather_C_2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Прогноз погоды на 5 дней для города: \n1 - Minsk \n2 - London \n3 - Paris \n4 - NewYork \n5 - Warsaw");
            
            try
            {
                var cityNumber = int.Parse(Console.ReadLine());
                string cityName = Console.ReadLine();
                
                City selectedCity = (City)(cityNumber - 1);
                switch (selectedCity)
                {
                    case City.Minsk:
                        string url = "https://api.openweathermap.org/data/2.5/weather?q=Minsk&units=metric&lang=ru&appid=d6bfd60ae10dc578300a860f105ed749";
                        // GetWeatherAsync(Cities.Minsk).Wait();
                        // Console.WriteLine("Погода в городе Минск:");
                        // Console.WriteLine($"Температура: {GetWeatherAsync(Cities.Minsk).Result.Main.Temp}");
                        // Console.WriteLine($"Давление: {GetWeatherAsync(Cities.Minsk).Result.Main.Pressure}");
                        // Console.WriteLine($"Влажность: {GetWeatherAsync(Cities.Minsk).Result.Main.Humidity}");
                        // Console.WriteLine($"Температура Min: {GetWeatherAsync(Cities.Minsk).Result.Main.TempMin}");
                        // Console.WriteLine($"Температура Max: {GetWeatherAsync(Cities.Minsk).Result.Main.TempMax}");
                        break;
                    
                    case City.London:
                        string url = "https://api.openweathermap.org/data/2.5/weather?q=London&units=metric&lang=ru&appid=f1451f839fdb9f6c9c04a07f128795ec";
                        // GetWeatherAsync(Cities.Vitebsk).Wait();
                        // Console.WriteLine("Погода в городе Витебск:");
                        // Console.WriteLine($"Температура: {GetWeatherAsync(Cities.Vitebsk).Result.Main.Temp}");
                        // Console.WriteLine($"Давление: {GetWeatherAsync(Cities.Vitebsk).Result.Main.Pressure}");
                        // Console.WriteLine($"Влажность: {GetWeatherAsync(Cities.Vitebsk).Result.Main.Humidity}");
                        // Console.WriteLine($"Температура Min: {GetWeatherAsync(Cities.Vitebsk).Result.Main.TempMin}");
                        // Console.WriteLine($"Температура Max: {GetWeatherAsync(Cities.Vitebsk).Result.Main.TempMax}");
                        break;
                    
                    case City.Paris:
                        string url = "https://api.openweathermap.org/data/2.5/weather?q=Paris&units=metric&lang=ru&appid=8eedcba634b7c5a1f7fa0261db5cf635";
                        // GetWeatherAsync(Cities.Novopolotsk).Wait();
                        // Console.WriteLine("Погода в городе Новополоцк:");
                        // Console.WriteLine($"Температура: {GetWeatherAsync(Cities.Novopolotsk).Result.Main.Temp}");
                        // Console.WriteLine($"Давление: {GetWeatherAsync(Cities.Novopolotsk).Result.Main.Pressure}");
                        // Console.WriteLine($"Влажность: {GetWeatherAsync(Cities.Novopolotsk).Result.Main.Humidity}");
                        // Console.WriteLine($"Температура Min: {GetWeatherAsync(Cities.Novopolotsk).Result.Main.TempMin}");
                        // Console.WriteLine($"Температура Max: {GetWeatherAsync(Cities.Novopolotsk).Result.Main.TempMax}");
                        break;
                    
                    case City.NewYork:
                        string url = "https://api.openweathermap.org/data/2.5/weather?q=NewYork&units=metric&lang=ru&appid=55dca5e21670cdbf9b77d287b4965ab6";
                        // GetWeatherAsync(Cities.Brest).Wait();
                        // Console.WriteLine("Погода в городе Брест:");
                        // Console.WriteLine($"Температура: {GetWeatherAsync(Cities.Brest).Result.Main.Temp}");
                        // Console.WriteLine($"Давление: {GetWeatherAsync(Cities.Brest).Result.Main.Pressure}");
                        // Console.WriteLine($"Влажность: {GetWeatherAsync(Cities.Brest).Result.Main.Humidity}");
                        // Console.WriteLine($"Температура Min: {GetWeatherAsync(Cities.Brest).Result.Main.TempMin}");
                        // Console.WriteLine($"Температура Max: {GetWeatherAsync(Cities.Brest).Result.Main.TempMax}");
                        break;
                    
                    case City.Warsaw:
                        string url = "https://api.openweathermap.org/data/2.5/weather?q=Warsaw&units=metric&lang=ru&appid=a7eaf17a7cf263d162e40c802f229cd7";
                        // GetWeatherAsync(Cities.Grodno).Wait();
                        // Console.WriteLine("Погода в городе Гродно:");
                        // Console.WriteLine($"Температура: {GetWeatherAsync(Cities.Grodno).Result.Main.Temp}");
                        // Console.WriteLine($"Давление: {GetWeatherAsync(Cities.Grodno).Result.Main.Pressure}");
                        // Console.WriteLine($"Влажность: {GetWeatherAsync(Cities.Grodno).Result.Main.Humidity}");
                        // Console.WriteLine($"Температура Min: {GetWeatherAsync(Cities.Grodno).Result.Main.TempMin}");
                        // Console.WriteLine($"Температура Max: {GetWeatherAsync(Cities.Grodno).Result.Main.TempMax}");
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