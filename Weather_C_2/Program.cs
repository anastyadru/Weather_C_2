using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Net;
using System.Linq;
using Newtonsoft.Json;

namespace Weather_C_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите название города: ");
            
            
            string url = "https://api.openweathermap.org/data/2.5/weather?q=Minsk&units=metric&appid=d6bfd60ae10dc578300a860f105ed749"; // d6bfd60ae10dc578300a860f105ed749 - API-ключ

            // string url = "https://api.openweathermap.org/data/2.5/weather?q=Vitebsk&units=metric&appid=";
            // string url = "https://api.openweathermap.org/data/2.5/weather?q=Novopolotsk&units=metric&appid=";
            // string url = "https://api.openweathermap.org/data/2.5/weather?q=Brestk&units=metric&appid=";
            // string url = "https://api.openweathermap.org/data/2.5/weather?q=Grodnok&units=metric&appid=";
            
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url); // создала объект Request, чтобы сделать запрос

            HttpWebResponse httpWebResponse = (HttpWebResponse)HttpWebRequest.GetResponse(); // создала объект Response, чтобы считать данные с Request (get - возвращает)

            string response;
            
            using (StreamReader streamReader = new StreamReader(HttpWebResponse.GetResponseStream)) // считала все данные с httpWebResponse
            {
                response = streamReader.ReadToEnd();
            }

            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
            
            Console.WriteLine("Temperature in {0}: {1} °C, weatherResponse.Name, weatherResponse.Main.Temp");

            Console.ReadLine();
        }
    }
}

// units=metric - температура в Цельсиях

// enum Cities
// {
    // Minsk,
    // Vitebsk,
    // Novopolotsk,    
    // Brest,
    // Grodno
// }