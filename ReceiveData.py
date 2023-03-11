#Einbindung aller benötigten Bibliotheken
import serial 
from serial.tools import list_ports 
import json 
from datetime import datetime 

#Pfad zur Datei in der Wetter-Daten zwischengespeichert werden
PATH = "readout.json"

#Sucht seriellen Port mit welchem die senseBox verbunden ist
def find_com_port():
    #Liste aller aktuell am Computer verfügbaren seriellen Ports
    serial_ports = list_ports.comports()

    for port in serial_ports:
        #Abgleich ob es sich um serieller Port mit senseBox handelt
        try:
            if(port.pid == 24597 and port.vid == 1027):
                return port.device
        except NameError as e:
            pass
    
    return None


#Speichert die Wetter-Daten in Datei zwischen für Abrufen der API 
def save_data(data_set):
    #Umwandeln des Dictionaries zu JSON
    content = json.dumps(data_set)        

    #Öffnen der Datei im Schreibmodus, Beschreiben mit neuen Daten, Schließen des Dateizugriffs
    file = open(PATH,"w")
    file.write(content)
    file.close()

    print(f"[{datetime.now().strftime('%d-%m-%Y %H:%M:%S')}] Daten wurden aktualisiert")


#Beginnt auf Daten der senseBox zu warten
def start_listening():
    print(f"[{datetime.now().strftime('%d-%m-%Y %H:%M:%S')}] Suche nach senseBox")
    port = find_com_port()

    if(port == None):
        print(f"[{datetime.now().strftime('%d-%m-%Y %H:%M:%S')}] Fehler: senseBox konnte nicht gefunden werden")
        return

    #Startet serielle Kommunikation mit senseBox
    sense_box = serial.Serial(port, 9600)
    print(f"[{datetime.now().strftime('%d-%m-%Y %H:%M:%S')}] Verbinde mit senseBox")

    data_set = {}

    #Start der Dauerschleife zum auslesen der Daten
    while True:
        #Lesen einer Zeile vom seriellen Port 
        data = sense_box.readline().decode().replace("\r\n", "")

        #Anhängen der Zeile zum aktuellen Datensatz
        if(data != ""):
            value_type = data.split(":")[0]
            value = data.split(":")[1]
            
            data_set[value_type] = value

        #Wenn letzte Zeile des Datensatzes erreicht:
        if(data.startswith("Beleuchtungsstaerke:")):
            save_data(data_set)

            #Zurücksetzen der zwischengespeicherten Daten
            data_set = {}



start_listening()