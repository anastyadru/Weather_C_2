using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Weather_C_2
{
    
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Прогноз погоды на 5 дней для города: \n1 - Minsk \n2 - London \n3 - Paris \n4 - NewYork \n5 - Warsaw");

            try
            {
                var cityNumber = int.Parse(Console.ReadLine());
                var cityName = Console.ReadLine();
                var apiKey = "your_api_key_here"; // 1a5442d5206cd9ef2bfc21e5ca523b75

                var url = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=metric&lang=ru";
                var newUrl;
                
                City selectedCity = (City)(cityNumber - 1);
                switch (selectedCity)
                {
                    case City.Minsk:
                        var newUrl = "https://api.openweathermap.org/data/2.5/weather?q=Minsk&units=metric&lang=ru&appid=d6bfd60ae10dc578300a860f105ed749";
                        // WeatherData.Data.(City.Minsk).Wait(); // cтрока ожидала завершения асинхронной операции получения данных о погоде
                        Console.WriteLine("Погода в городе Минск: ");
                        Console.WriteLine($"Температура: {WeatherData.Data.Temp}°C");
                        Console.WriteLine($"Температура как ощущается: {WeatherData.Data.FeelsLike}°C");
                        Console.WriteLine($"Давление: {WeatherData.Data.Pressure}Pa");
                        Console.WriteLine($"Влажность: {WeatherData.Data.Humidity}%");
                        break;

                    case City.London:
                        var newUrl = "https://api.openweathermap.org/data/2.5/weather?q=London&units=metric&lang=ru&appid=f1451f839fdb9f6c9c04a07f128795ec";
                        // WeatherData.Data.(City.London).Wait();
                        Console.WriteLine("Погода в городе Лондон: ");
                        Console.WriteLine($"Температура: {WeatherData.Data.Temp}°C");
                        Console.WriteLine($"Температура как ощущается: {WeatherData.Data.FeelsLike}°C");
                        Console.WriteLine($"Давление: {WeatherData.Data.Pressure}Pa");
                        Console.WriteLine($"Влажность: {WeatherData.Data.Humidity}%");
                        break;

                    case City.Paris:
                        var newUrl = "https://api.openweathermap.org/data/2.5/weather?q=Paris&units=metric&lang=ru&appid=8eedcba634b7c5a1f7fa0261db5cf635";
                        // WeatherData.Data.(City.Paris).Wait();
                        Console.WriteLine("Погода в городе Париж: ");
                        Console.WriteLine($"Температура: {WeatherData.Data.Temp}°C");
                        Console.WriteLine($"Температура как ощущается: {WeatherData.Data.FeelsLike}°C");
                        Console.WriteLine($"Давление: {WeatherData.Data.Pressure}Pa");
                        Console.WriteLine($"Влажность: {WeatherData.Data.Humidity}%");
                        break;

                    case City.NewYork:
                        var newUrl = "https://api.openweathermap.org/data/2.5/weather?q=NewYork&units=metric&lang=ru&appid=55dca5e21670cdbf9b77d287b4965ab6";
                        // WeatherData.Data.(City.NewYork).Wait();
                        Console.WriteLine("Погода в городе Нью-Йорк: ");
                        Console.WriteLine($"Температура: {WeatherData.Data.Temp}°C");
                        Console.WriteLine($"Температура как ощущается: {WeatherData.Data.FeelsLike}°C");
                        Console.WriteLine($"Давление: {WeatherData.Data.Pressure}Pa");
                        Console.WriteLine($"Влажность: {WeatherData.Data.Humidity}%");
                        break;

                    case City.Warsaw:
                        var newUrl = "https://api.openweathermap.org/data/2.5/weather?q=Warsaw&units=metric&lang=ru&appid=a7eaf17a7cf263d162e40c802f229cd7";
                        // WeatherData.Data.(City.Warsaw).Wait();
                        Console.WriteLine("Погода в городе Варшава: ");
                        Console.WriteLine($"Температура: {WeatherData.Data.Temp}°C");
                        Console.WriteLine($"Температура как ощущается: {WeatherData.Data.FeelsLike}°C");
                        Console.WriteLine($"Давление: {WeatherData.Data.Pressure}Pa");
                        Console.WriteLine($"Влажность: {WeatherData.Data.Humidity}%");
                        break;
                }
            }

            catch ( ex)
            {
                Console.WriteLine ("Такого города не существует в заготовленном списке. Введите город вручную: ");
                
                Console.WriteLine("Погода в городе: ");
                Console.WriteLine($"Температура: {WeatherData.Data.Temp}°C");
                Console.WriteLine($"Температура как ощущается: {WeatherData.Data.FeelsLike}°C");
                Console.WriteLine($"Давление: {WeatherData.Data.Pressure}Pa");
                Console.WriteLine($"Влажность: {WeatherData.Data.Humidity}%");
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