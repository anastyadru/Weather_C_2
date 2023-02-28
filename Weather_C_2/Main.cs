using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_C_2
{
    public class Main
    {
        private double Temp { get; set; }
        private double FeelsLike { get; set; }
        public double TempMin { get; set; }
        public double TempMax { get; set; }
        private int Pressure { get; set; }
        private int Humidity { get; set; } 
        private int SeaLevel { get; set; }
        private int GrandLevel { get; set; }
    }

        // public Weather(double temp, int pressure, int humidity, double tempMin, double tempMax)
        // {
        // Temp = temp;
        // Pressure = pressure;
        // Humidity = humidity;
        // TempMin = tempMin;
        // TempMax = tempMax;
        // }
        
        // protected virtual void Print()
        // {
        // Console.WriteLine("Температура: {0}\nДавление: {1}\nВлажность: {2}%\nТемпература Min: {3}\nТемпература Max: {4}");
        // }
}