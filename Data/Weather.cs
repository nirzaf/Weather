using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weather.Data
{
    public class Weather
    {
        public int Humidity { get; set; }
        public int Temperature { get; set; }
        public int Min_Temperature { get; set; }
        public int Max_Temperature { get; set; }
    }
}