#Einbindung aller benötigten Bibliotheken
import requests
import time
import os
import os.path
import glob 
from datetime import datetime 
import subprocess

#URL zur API
URL = "http://65.109.108.200/api/v1/senseBox/liveview"

PATH = "capt0000.jpg"

#Sendet das Liveview-Bild an die API
def upload_image():
    files = {'liveview': ('liveview.jpg', open(PATH, 'rb'), 'image/jpeg')}

    res = requests.post(URL, files=files)

    if(res.status_code == 200):
        print(f"[{datetime.now().strftime('%d-%m-%Y %H:%M:%S')}] Bild wurde abgesendet")
    else:
        print(f"[{datetime.now().strftime('%d-%m-%Y %H:%M:%S')}] Bild konnte nicht abgesendet werden")

        
#Generiert Vorschau/Liveview und speichert diesen
def take_picture():
    subprocess.run('gphoto2 --auto-detect', shell=True, stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL) 
    subprocess.run('gphoto2 --capture-image-and-download', shell=True, stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL) 
    

#Beginnt nach Bilder zu suchen
def start_loop():
    #Löscht letztes Liveviewbild um Namenskonflikt zu vermeiden
    if(os.path.exists(PATH)):
        os.remove(PATH)

    #Endlosschleife
    while True:
        try:
            #Macht Foto mit Kamera
            take_picture()

            #Lädt Bild zur API hoch
            upload_image()

            #Löscht Bild von Kamera
            os.remove(PATH)

            time.sleep(9)
        except FileNotFoundError as e: #Kamera wurde nicht gefunden
            print(f"[{datetime.now().strftime('%d-%m-%Y %H:%M:%S')}] Es konnte keine Verbindung zur Kamera hergestellt werden")
            time.sleep(15)

start_loop()
