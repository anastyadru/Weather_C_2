using System;
using System.IO;
using System.Net;
using System.Linq;
using Newtonsoft.Json;

namespace Weather_C_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите название города: ");
            string city = Console.ReadLine();
            
            string url = "https://api.openweathermap.org/data/2.5/weather?q=" + city + "&units=metric&appid=1a5442d5206cd9ef2bfc21e5ca523b75";
            
            WebRequest request = WebRequest.Create(url); // Отправила запрос и получила ответ
            WebResponse response = request.GetResponse();
            
            Stream dataStream = response.GetResponseStream(); // Считала данные из ответа
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();

            
            
            
            // WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
        }
    }
}

// units=metric - температура в Цельсиях

// string url = "https://api.openweathermap.org/data/2.5/weather?q=Minsk&units=metric&appid=d6bfd60ae10dc578300a860f105ed749";
// string url = "https://api.openweathermap.org/data/2.5/weather?q=Vitebsk&units=metric&appid=f1451f839fdb9f6c9c04a07f128795ec";
// string url = "https://api.openweathermap.org/data/2.5/weather?q=Novopolotsk&units=metric&appid=8eedcba634b7c5a1f7fa0261db5cf635";
// string url = "https://api.openweathermap.org/data/2.5/weather?q=Brest&units=metric&appid=55dca5e21670cdbf9b77d287b4965ab6";
// string url = "https://api.openweathermap.org/data/2.5/weather?q=Grodno&units=metric&appid=a7eaf17a7cf263d162e40c802f229cd7";
