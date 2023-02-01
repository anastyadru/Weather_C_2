using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Linq;

namespace Weather_C_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?id=2172797&appid={API key}";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse httpWebResponse = (HttpWebResponse)HttpWebRequest.GetResponse();
        }
    }
}