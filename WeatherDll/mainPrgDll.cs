using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace WeatherDll
{
    // WeatherData Objekt für das Parsen an das Formular
    public class WeatherData
    {
        public float Temp;
        public float Press;
        public float Hum;
        public int UV;
        public float Light;
    }
    

    public class mainPrgDll
    {

        public WeatherData GetData(string DataURL)
        {
            try
            {
                using(WebClient webClient = new WebClient())
                {
                    // URI für die Webclient Baseadress
                    Uri weatherURI = new Uri(DataURL);

                    // Spezifizierung der Abfrage
                    HttpRequestMessage weatherAPIRequest = new HttpRequestMessage(HttpMethod.Get, weatherURI);

                    // Abfrage der URL
                    string weatherResponse = webClient.DownloadString(weatherURI);

                    // JSON-Response Deserialize
                    WeatherData apiresponse = JsonConvert.DeserializeObject<WeatherData>(weatherResponse);

                    // Light Sensor auf Gültigkeit prüfen.
                    if (apiresponse.Temp < -40 && apiresponse.Temp > 100)
                    {
                        throw new SensorException($"Humidity Sensor gibt falschen Wert!\nWert ist:{apiresponse.Temp}");
                    }

                    // Light Sensor auf Gültigkeit prüfen.
                    if (apiresponse.Press < 100 && apiresponse.Press > 1500)
                    {
                        throw new SensorException($"Humidity Sensor gibt falschen Wert!\nWert ist:{apiresponse.Press}");
                    }

                    // Hum Sensor auf Gültigkeit prüfen(Unter 0 und ü. 100)
                    if (apiresponse.Hum < 0 && apiresponse.Hum > 100)
                    {
                        throw new SensorException($"Humidity Sensor gibt falschen Wert!\nWert ist:{apiresponse.Hum}");
                    }

                    // UV Sensor auf Gültigkeit prüfen. (Unter 0 und ü. 100)
                    if (apiresponse.UV < 0 && apiresponse.UV > 100)
                    {
                        throw new SensorException($"UV Sensor gibt falschen Wert!\nWert ist:{apiresponse.UV}");
                    }

                    // Light Sensor auf Gültigkeit prüfen.
                    if (apiresponse.Light < 0 && apiresponse.Light > 500000)
                    {
                        throw new SensorException($"Humidity Sensor gibt falschen Wert!\nWert ist:{apiresponse.Light}");
                    }

                    // Objekt Return
                    return apiresponse;
                }
            }
            catch(WebException ex)
            {
                throw new NetworkParsingException(ex.ToString());
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
