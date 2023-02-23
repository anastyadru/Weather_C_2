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
        private int Pressure { get; set; }
        private int Humidity { get; set; }
        public double TempMin { get; set; }
        public double TempMax { get; set; }
    }

        // public Weather(double temp, int pressure, int humidity)
        // {
        // Temp = temp;
        // Pressure = pressure;
        // Humidity = humidity;
        // }
        
        // protected virtual void Print()
        // {
        // Console.WriteLine("Температура: {0}\nДавление: {1}\nВлажность: {2}%");
        // }
    }
}