using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WeatherDll
{
    // WeatherData Objekt für das Parsen an das Formular
    public class WeatherData
    {
        float Temp;
        float Press;
        float Hum;
        int UV;
        int Light;
    }

    public class mainPrgDll
    {
        public WeatherData GetData()
        { }
    }
}
