using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Net;
using System.Linq;

namespace Weather_C_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?id=2172797&units=metric&appid=d6bfd60ae10dc578300a860f105ed749"; // d6bfd60ae10dc578300a860f105ed749 - API-ключ

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url); // создала объект Request, чтобы сделать запрос

            HttpWebResponse httpWebResponse = (HttpWebResponse)HttpWebRequest.GetResponse(); // создала объект Response, чтобы считать данные с Request (get - возвращает)

            string response;
            
            using (StreamReader streamReader = new StreamReader(HttpWebResponse.GetResponseStream)) // считала все данные с httpWebResponse
            {
                response = streamReader.ReadToEnd();
            }

            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
        }
    }
}

// units=metric - температура в Цельсиях