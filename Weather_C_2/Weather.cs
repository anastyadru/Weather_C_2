using System;

namespace Weather_C_2
{
    public class Weather
    {
        public double Temp { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }

        public Weather(double temp, int pressure, int humidity)
        {
            Temp = temp;
            Pressure = pressure;
            Humidity = humidity;
        }
        
        protected virtual void Print()
        {
            Console.WriteLine("Температура: {0}\nДавление: {1}\nВлажность: {2}");
        }
    }
}