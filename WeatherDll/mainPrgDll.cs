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
        float Temp;
        float Press;
        float Hum;
        int UV;
        int Light;
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

                    if()

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
                
            }
        }
    }
}
