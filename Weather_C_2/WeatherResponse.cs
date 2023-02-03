using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Weather_C_2
{
    public class WeatherResponse
    {
        public TemperatureInfo Main { get; set; }
        
        public string Name { get; set; }
    }
}