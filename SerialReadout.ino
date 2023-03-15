#include <Wire.h>
#include <HDC100X.h>
#include <BMP280.h>
#include <Makerblog_TSL45315.h>
#include <VEML6070.h>

#define I2C_ADDR 0x38
#define IT_1   0x1 //1T

HDC100X HDC(0x43);
BMP280 BMP;
VEML6070 VEML;
Makerblog_TSL45315 TSL = Makerblog_TSL45315(TSL45315_TIME_M4);

//Einmalige Methode, wird beim Start der senseBox:home ausgeführt
void setup()
{
  //Initialisiere Serielle Verbindung
  Serial.begin(9600);
  delay(1000);
  //Suche nach Sensoren
  scan();
  delay(1000);
  
  //Initialisiere alle Sensoren
  HDC.begin(HDC100X_TEMP_HUMI, HDC100X_14BIT, HDC100X_14BIT, DISABLE);
  VEML.begin();
  TSL.begin();
  BMP.begin();
  BMP.setOversampling(4);

  delay(5000);
}

//Endlosschleife
void loop()
{
  //Initialisierung und Definierung der Variablen, welche die Sensordaten speichern
  char result;
  double T1=0, H=0;
  double T2=0, P=0;
  uint32_t lux;
  //byte msb=0, lsb=0;
  uint16_t uv;

  //HDC1080 (Luftfeuchtigkeit- und Temperatursensor) auslesen
  H = HDC.getHumi();
  T1 = HDC.getTemp();

  //BMP280 (Luftdruck- und Temperatursensor) auslesen
  result = BMP.startMeasurment();
  delay(result);
  BMP.getTemperatureAndPressure(T2, P);
  

  //TSL45315 (Beleuchtungsstaerkesensor) auslesen
  lux = TSL.readLux();

  //VEML6070 (UV-Strahlungssensor) auslesen
  uv = VEML.getUV();
  
  //Serielles senden der Daten (an Raspberry Pi 4B)
  Serial.print("Temperatur:"); 
  Serial.println((T1 + T2)/2, 1);
  Serial.print("Luftfeuchtigkeit:"); 
  Serial.println(H,1);
  Serial.print("Luftdruck:"); 
  Serial.println(P, 2);
  Serial.print("UVStrahlung:"); 
  Serial.println(uv, DEC);
  Serial.print("Beleuchtungsstaerke:");
  Serial.println(lux, DEC);	
	  
  //Warte 10'000ms (10s) und starte Methode von vorn
  delay(10000);
}

void scan(void)
{
  byte error, address;

  Wire.begin();
  for(address = 1; address < 127; address++ )
  {
    Wire.beginTransmission(address);
    error = Wire.endTransmission();
 
    if(error == 0)
    {
      if(address<16)
        Serial.print("0");
    }
    else if(error==4)
    {
      Serial.print("Fehler: 0x");
      if(address<16)
        Serial.print("0");
      Serial.println(address,HEX);
    }
  }
  Serial.println("");
}
