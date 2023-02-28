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
        public static async Task GetWeatherDataAsync(string city)
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q={cityName}&units=metric&lang=ru&appid=1a5442d5206cd9ef2bfc21e5ca523b75";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url); // отправила запрос и получила ответ
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd(); // считала текст с response
            }

            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);

            Console.WriteLine();
            Console.ReadLine();
        }

            // Stream dataStream = response.GetResponseStream(); // считала данные из ответа
            // StreamReader reader = new StreamReader(dataStream);
            // string responseFromServer = reader.ReadToEnd();

            static void Main(string[] args)
        {
            Console.WriteLine("Прогноз погоды на 5 дней для города: \n1) Minsk \n2) Vitebsk \n3) Novopolotsk \n4) Brest \n5) Grodno");
            var cityNumber = int.Parse(Console.ReadLine());

            string cityName = Console.ReadLine();

            try
            {

                using (var client = new HttpClient()) // создала экземпляра HTTP-клиента
                {
                    
                }
                
                switch (cityNumber)
                {
                    case 1: 
                        cityName = "Minsk";
                        string url = "https://api.openweathermap.org/data/2.5/weather?q=Minsk&units=metric&lang=ru&appid=d6bfd60ae10dc578300a860f105ed749";
                        // GetWeatherAsync(Cities.Minsk).Wait();
                        // Console.WriteLine("Погода в городе Минск:");
                        // Console.WriteLine($"Температура: {GetWeatherAsync(Cities.Minsk).Result.Main.Temp}");
                        // Console.WriteLine($"Давление: {GetWeatherAsync(Cities.Minsk).Result.Main.Pressure}");
                        // Console.WriteLine($"Влажность: {GetWeatherAsync(Cities.Minsk).Result.Main.Humidity}");
                        // Console.WriteLine($"Температура Min: {GetWeatherAsync(Cities.Minsk).Result.Main.TempMin}");
                        // Console.WriteLine($"Температура Max: {GetWeatherAsync(Cities.Minsk).Result.Main.TempMax}");
                        break;
                    
                    case 2: 
                        cityName = "Vitebsk";
                        string url = "https://api.openweathermap.org/data/2.5/weather?q=Vitebsk&units=metric&lang=ru&appid=f1451f839fdb9f6c9c04a07f128795ec";
                        // GetWeatherAsync(Cities.Vitebsk).Wait();
                        // Console.WriteLine("Погода в городе Витебск:");
                        // Console.WriteLine($"Температура: {GetWeatherAsync(Cities.Vitebsk).Result.Main.Temp}");
                        // Console.WriteLine($"Давление: {GetWeatherAsync(Cities.Vitebsk).Result.Main.Pressure}");
                        // Console.WriteLine($"Влажность: {GetWeatherAsync(Cities.Vitebsk).Result.Main.Humidity}");
                        // Console.WriteLine($"Температура Min: {GetWeatherAsync(Cities.Vitebsk).Result.Main.TempMin}");
                        // Console.WriteLine($"Температура Max: {GetWeatherAsync(Cities.Vitebsk).Result.Main.TempMax}");
                        break;
                    
                    case 3: 
                        cityName = "Novopolotsk";
                        string url = "https://api.openweathermap.org/data/2.5/weather?q=Novopolotsk&units=metric&lang=ru&appid=8eedcba634b7c5a1f7fa0261db5cf635";
                        // GetWeatherAsync(Cities.Novopolotsk).Wait();
                        // Console.WriteLine("Погода в городе Новополоцк:");
                        // Console.WriteLine($"Температура: {GetWeatherAsync(Cities.Novopolotsk).Result.Main.Temp}");
                        // Console.WriteLine($"Давление: {GetWeatherAsync(Cities.Novopolotsk).Result.Main.Pressure}");
                        // Console.WriteLine($"Влажность: {GetWeatherAsync(Cities.Novopolotsk).Result.Main.Humidity}");
                        // Console.WriteLine($"Температура Min: {GetWeatherAsync(Cities.Novopolotsk).Result.Main.TempMin}");
                        // Console.WriteLine($"Температура Max: {GetWeatherAsync(Cities.Novopolotsk).Result.Main.TempMax}");
                        break;
                    
                    case 4: 
                        cityName = "Brest";
                        string url = "https://api.openweathermap.org/data/2.5/weather?q=Brest&units=metric&lang=ru&appid=55dca5e21670cdbf9b77d287b4965ab6";
                        // GetWeatherAsync(Cities.Brest).Wait();
                        // Console.WriteLine("Погода в городе Брест:");
                        // Console.WriteLine($"Температура: {GetWeatherAsync(Cities.Brest).Result.Main.Temp}");
                        // Console.WriteLine($"Давление: {GetWeatherAsync(Cities.Brest).Result.Main.Pressure}");
                        // Console.WriteLine($"Влажность: {GetWeatherAsync(Cities.Brest).Result.Main.Humidity}");
                        // Console.WriteLine($"Температура Min: {GetWeatherAsync(Cities.Brest).Result.Main.TempMin}");
                        // Console.WriteLine($"Температура Max: {GetWeatherAsync(Cities.Brest).Result.Main.TempMax}");
                        break;
                    
                    case 5:
                        cityName = "Grodno";
                        string url = "https://api.openweathermap.org/data/2.5/weather?q=Grodno&units=metric&lang=ru&appid=a7eaf17a7cf263d162e40c802f229cd7";
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