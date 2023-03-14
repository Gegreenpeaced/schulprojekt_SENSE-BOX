using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDll
{
    // SensorException für falsche Sensorwerte
    class SensorException : Exception
    {
        public SensorException()
        { }

        public SensorException(string ExMsg) : base(ExMsg)
        { }
        public SensorException(string ExMsg, Exception inner) : base(ExMsg, inner)
        { }
        public override string HelpLink
        {
            get
            {
                return "Für mehr Informationen bitte Markus oder Julius fragen oder die Sensoren der Wetterstation überprüfen.";
            }
        }
    }

    class NetworkParsingException : Exception
    {
        public NetworkParsingException()
        { }

        public NetworkParsingException(string ExMsg) : base(ExMsg)
        { }
        public NetworkParsingException(string ExMsg, Exception inner) : base(ExMsg, inner)
        { }
        public override string HelpLink
        {
            get
            {
                return "Für mehr Informationen bitte Markus oder Julius fragen oder die Verbindung zur Wetterstation überprüfen.";
            }
        }
    }
}
