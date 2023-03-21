# Schulprojekt OPENSENSE

## Nutzung von Bibliotheken in IDE Visual Studio 2019 Community [OOP + DLL]

## Ziel

In diese Unterrichtseinheit werden die Lehrplaninhalte [LB 13.6 und 13.7](https://www.schulportal.sachsen.de/lplandb/index.php?lplanid=207&lplansc=RsQZwe8OPkpHBsQONmot&token=cc0766485c53239aace2750645fd4362) mithilfe der OPENSENSE Wetterstation, dabei auch der Umgang mit DLLs und OPP in der Praxis umgesetzt.

Der Ziel dabei ist diese Lerninhalte zu wiederholen und dabei für die Prüfung zu üben.

## Aufbau

Das Projekt besteht aus 3 Komponenten, die in den folgenden Absätzen näher erläutert werden.
Im Prinzip funktioniert es so, dass eine Wetterstation Temperatur, Luftdruck, Luftfeuchtigkeit, Beleuchtungsstärke und Strahlungsintensität eines Raums abmessen. Diese  Daten werden in einem Programm gespeichert, das man mittels eine IP aufrufen kann und an unsere Formular anzeigen kann.

## Wetterstation 

Benötigt Hardware: 

- 1x senseBox MCU
- 4x Sensoren 
    - HDC1080 für die Temperatur in  °C
    - BMP280 für die Luftdruck in pa
    - TSL45315 für die Beleichungsstärke in lx
    - VEML6070 für Intensität der ultravioletten Strahlung in μW/cm2
- 1x Outdoor-Gehäuse
- 4x Verbindungskabel 
- 1x USB-Kabel für den Anschluss des Mikrocontrollers an den Computers // Serial Port
- Netzteil und USB Kabel

Benötigt Software: 

- Arduino IDE
- ein Linux Betriebssystem
- NgNix 
- Python Bibliotheken
    - serial 
    - list_ports
    - json 
    - datetime 
    - requests


Die Sensoren und Steckplätze auf der Basisstation werden mittels der Verbindungskabel vernetzt. Als nächste werden diese Teile in der Outdoor-Gehäuse eingebaut.

Um die Wetterstation zu bedienen wird die Linux integrierte Entwicklungsumgebung von Arduino, kurz *Arduino IDE,* benötigt. Ein paar Python Bibliotheken, die bei Software aufgelistet sind, müssen installiert werden, um das Programm für die [API](https://github.com/Gegreenpeaced/schulprojekt_OPENSENSE-BOX/tree/api) zu programmieren. 

Um den genaueren Aufbau durchzulesen finden Sie die Einleitung von [senseBox:home v1](https://docs.sensebox.de/misc/senseboxv1/) auf sensebox.de.

Ein Serieller Port verbindet die Wetterstation mit dem Pi physische. Durch NgNix wird eine Website(http://65.109.108.200/api/v1/senseBox/weather) gehostet, wo man die Daten der Wetterstation in Echtzeit abfragen kann.

Diese Daten können dann in der Form als ‘requests’ abgefragt werden, und die Website wird ein Jason String zurückgeben. In dem Formular werden die Daten gespeichert und im Ausgabefenster wiedergegeben. Der genaue Ablauf ist unter  [‘schulprojekt_OPENSENSE-BOX/UploadData.py’](https://github.com/Gegreenpeaced/schulprojekt_SENSE-BOX/tree/api) zu finden. Folgendes finden sie einen Netzwerkdiagramm um den Ablauf zu veranschaulichen.

** Netzplan **

??? Tip "API"
    Eine API(The PI Web API is a RESTful interface to the PI system) besteht aus Protokollen und anderen Code Bausteinen zur Entwicklung und Integration von Anwendungssoftware. In einer PI für unseren Wetterdienst kann man beispielsweise die Datenquelle auswählen(die von Markus oder deine eigenen AP-Adresse), wo die entsprechende Daten herkommen.


## Formular

Benötigt Software: 

- VS Studio 2019
- WeatherDll
- .NETFramework 4.7.2

Das Formular besteht aus eine GUI, wo man entsprechende Daten in Echtzeit abfragen kann, dem der Knopf “Daten Abfragen” gedrückt wird. 

An der ersten Stelle der Methode X wird  überprüft, ob eine IP ausgewählt würde, falls nicht ´if (string.IsNullOrEmpty(apiIP))´ wird eine Warnung zurückgegeben mit der Anweisung eine IP auszuwählen. Wenn eine gültige IP ausgewählt wurde, werden die ensprechende Daten in die Textfelder zurückgegeben und ein Infotext mit der Uhrzeit der letzten Abfrage angezeigt.

Falls irgendein Fehler aufkommt, der in die DLL definiert wurde, wird eine Warnung angezeigt mit der Anweisung sich bei einem unserer Experten zu melden.

Das Programm kann unterbrochen werden, wenn man den “X” Knopf drückt, oder geschlossen, wenn man den Knopf “Close” auswählt. Dabei wird ein neues Fenster geöffnet, wo der Benutzer beständigen muss, dass er die Anwendung schließen möchte.

Die Struktur ist im folgende Struktogramm zusammengefasst:

** Struktugramm **

## WeatherDll

Benötigt Software: 

- VS Studio 2019
- Newtonsoft.Json Bibliothek
- .NETFramework 4.7.2

** Klassendiagramm **

Eine Dynamic Link library (DLL) beinhaltet Funktionen und Code Bausteine, die man in mehreren Programmen gleichzeitig verwenden kann.

Bei Weatherdll werden die Daten Temperatur, Luftdruck, Luftfeuchtigkeit, Beleuchungsstärke und Strahlungsintensität als Variablen und der Konstruktor ´WeatherData()´ in die Klasse WeatherData eingespeichert.

Die Klasse mainPrgDll hat eine Methode ´GetData()´, um den Konstruktor von weatherdll aufzurufen.

Die vom System Exeption vererbte SensorExeption und NetworkParsing sind mit den mainPrgDll indirekt verbunden. Die Sensoren werden beim Aufrufen  von ´GetData()´ auf ihre Gültigkeit überprüft, falls ein Fehler auftritt wird die entsprechende Error Message auftreten, sonst werden die entsprechende Daten an dasFormular von ein JSON String zu Text umgewandelt.

---

[Impressum](legal/imprint.md){ .md-button }
​

