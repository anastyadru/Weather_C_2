using System;
using System.IO;
using System.Net;
using System.Linq;
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
                string cityName = Console.ReadLine();

                City selectedCity = (City)(cityNumber - 1);
                switch (selectedCity)
                {
                    case City.Minsk:
                        string url =
                            "https://api.openweathermap.org/data/2.5/weather?q=Minsk&units=metric&lang=ru&appid=d6bfd60ae10dc578300a860f105ed749";
                        GetWeatherAsync(City.Minsk).Wait();
                        Console.WriteLine("Погода в городе Минск:");
                        Console.WriteLine($"Температура: {WeatherData.Main.Temp}");
                        Console.WriteLine($"Температура Min: {WeatherData.Main.FeelsLike}");
                        Console.WriteLine($"Давление: {WeatherData.Main.Pressure}");
                        Console.WriteLine($"Влажность: {WeatherData.Main.Humidity}");
                        break;

                    case City.London:
                        string url =
                            "https://api.openweathermap.org/data/2.5/weather?q=London&units=metric&lang=ru&appid=f1451f839fdb9f6c9c04a07f128795ec";
                        GetWeatherAsync(City.London).Wait();
                        Console.WriteLine("Погода в городе Лондон:");
                        Console.WriteLine($"Температура: {WeatherData.Main.Temp}");
                        Console.WriteLine($"Температура Min: {WeatherData.Main.FeelsLike}");
                        Console.WriteLine($"Давление: {WeatherData.Main.Pressure}");
                        Console.WriteLine($"Влажность: {WeatherData.Main.Humidity}");
                        break;

                    case City.Paris:
                        string url =
                            "https://api.openweathermap.org/data/2.5/weather?q=Paris&units=metric&lang=ru&appid=8eedcba634b7c5a1f7fa0261db5cf635";
                        GetWeatherAsync(City.Paris).Wait();
                        Console.WriteLine("Погода в городе Париж:");
                        Console.WriteLine($"Температура: {WeatherData.Main.Temp}");
                        Console.WriteLine($"Температура Min: {WeatherData.Main.FeelsLike}");
                        Console.WriteLine($"Давление: {WeatherData.Main.Pressure}");
                        Console.WriteLine($"Влажность: {WeatherData.Main.Humidity}");
                        break;

                    case City.NewYork:
                        string url =
                            "https://api.openweathermap.org/data/2.5/weather?q=NewYork&units=metric&lang=ru&appid=55dca5e21670cdbf9b77d287b4965ab6";
                        GetWeatherAsync(City.NewYork).Wait();
                        Console.WriteLine("Погода в городе Нью-Йорк:");
                        Console.WriteLine($"Температура: {WeatherData.Main.Temp}");
                        Console.WriteLine($"Температура Min: {WeatherData.Main.FeelsLike}");
                        Console.WriteLine($"Давление: {WeatherData.Main.Pressure}");
                        Console.WriteLine($"Влажность: {WeatherData.Main.Humidity}");
                        break;

                    case City.Warsaw:
                        string url =
                            "https://api.openweathermap.org/data/2.5/weather?q=Warsaw&units=metric&lang=ru&appid=a7eaf17a7cf263d162e40c802f229cd7";
                        GetWeatherAsync(City.Warsaw).Wait();
                        Console.WriteLine("Погода в городе Варшава:");
                        Console.WriteLine($"Температура: {WeatherData.Main.Temp}");
                        Console.WriteLine($"Температура Min: {WeatherData.Main.FeelsLike}");
                        Console.WriteLine($"Давление: {WeatherData.Main.Pressure}");
                        Console.WriteLine($"Влажность: {WeatherData.Main.Humidity}");
                        break;
                }
            }

            catch ( ex)
            {
           
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