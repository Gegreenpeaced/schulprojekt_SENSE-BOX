using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Drawing;
using System.IO;

namespace WeatherDll
{
    // WeatherData Objekt für das Parsen an das Formular
    public class WeatherData
    {
        public float Temperatur;
        public float Luftdruck;
        public float Luftfeuchtigkeit;
        public int UVStrahlung;
        public float Beleuchtungsstaerke;
    }
    
    public class weatherDll
    {

        public Bitmap GetPicture(string PictureURL)
        {
            try
            {
                // Datei herunterladen
                using(WebClient pictureClient = new WebClient())
                {
                    // Abfrage der URL und erstellen der Bitmap
                    pictureClient.DownloadFile(PictureURL, "liveview.bmp");

                    // Erstellen einer ReturnBitmap und Laden aus Datei
                    Bitmap returnBMP = new Bitmap("liveview.bmp");

                    // Datei zurücksenden
                    return returnBMP;
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


        public WeatherData GetData(string DataURL)
        {
            try
            {
                using(WebClient webClient = new WebClient())
                {
                    // Abfrage der URL
                    string weatherResponse = webClient.DownloadString(DataURL);

                    // JSON-Response Deserialize
                    WeatherData apiresponse = JsonConvert.DeserializeObject<WeatherData>(weatherResponse);

                    // Light Sensor auf Gültigkeit prüfen.
                    if (apiresponse.Temperatur < -40 && apiresponse.Temperatur > 100)
                    {
                        throw new SensorException($"Humidity Sensor gibt falschen Wert!\nWert ist:{apiresponse.Temperatur}");
                    }

                    // Light Sensor auf Gültigkeit prüfen.
                    if (apiresponse.Luftdruck < 100 && apiresponse.Luftdruck > 1500)
                    {
                        throw new SensorException($"Humidity Sensor gibt falschen Wert!\nWert ist:{apiresponse.Luftdruck}");
                    }

                    // Hum Sensor auf Gültigkeit prüfen(Unter 0 und ü. 100)
                    if (apiresponse.Luftfeuchtigkeit < 0 && apiresponse.Luftfeuchtigkeit >= 100)
                    {
                        throw new SensorException($"Humidity Sensor gibt falschen Wert!\nWert ist:{apiresponse.Luftfeuchtigkeit}");
                    }

                    // UV Sensor auf Gültigkeit prüfen. (Unter 0 und ü. 100)
                    if (apiresponse.UVStrahlung < 0 && apiresponse.UVStrahlung >= 100)
                    {
                        throw new SensorException($"UV Sensor gibt falschen Wert!\nWert ist:{apiresponse.UVStrahlung}");
                    }

                    // Light Sensor auf Gültigkeit prüfen.
                    if (apiresponse.Beleuchtungsstaerke < 0 && apiresponse.Beleuchtungsstaerke > 500000)
                    {
                        throw new SensorException($"Humidity Sensor gibt falschen Wert!\nWert ist:{apiresponse.Beleuchtungsstaerke}");
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
