<?php
# Bestimmen des Endpunktes (/api/v1/class/method)
$class  = filter_input(INPUT_GET, 'class',  FILTER_SANITIZE_STRING);
$method = filter_input(INPUT_GET, 'method', FILTER_SANITIZE_STRING);

# Anweisung für Endpunkt senseBox/weather
if ($class == "senseBox" && $method == "weather"){
  if(!empty($_POST)){ # Wenn Daten hochgeladen werden
    # Kodiert erhaltene Daten zu JSON
    $data = json_encode($_POST);
    
    # Öffnen Datei und speichert die neuen Daten
    $cacheFile = fopen("/var/tmp/readout.json", "w");
    fwrite($cacheFile, $data);
    fclose($cacheFile);
    
  } else { # Wenn Daten aufgerufen werden
    # Gibt Daten aus Datei zurück
    echo(file_get_contents("/var/tmp/readout.json"));
  } 
} else if ($class == "senseBox" && $method == "liveview") {
  if(!empty($_FILES)){ # Wenn Dateien hochgeladen werden
    $fileName = $_FILES['liveview']['name'];
    $fileSize = $_FILES['liveview']['size'];
    $fileTmp = $_FILES['liveview']['tmp_name'];
    $fileType = $_FILES['liveview']['type'];
    $fileExt = strtolower(pathinfo($fileName, PATHINFO_EXTENSION));

    # Zulässige Dateiendungen für Liveview
    $allowedExt = array('jpg', 'jpeg');

    # Überprüfe ob Dateiendung zulässig ist
    if(in_array($fileExt, $allowedExt) && getimagesize($fileTmp)) {
        # Lädt Datei unter uploads/liveview.jpg hoch
        echo(move_uploaded_file($fileTmp, '/var/www/html/uploads/liveview.jpg'));
        echo("MOVED TO /var/www/html/uploads/liveview.jpg");
    } else {
        # Gibt Fehlermeldung zurück
        echo "Fehler: Unzulässiger Datei-Typ!";
        http_response_code(400);
    }
  
  } else { # Wenn Bild aufgerufen wird
    # Setzt Header für senden eines Bildes
    header('Content-Type: image/jpeg');
    header('Content-Disposition: attachment; filename="liveview.jpg"');

    # Lädt Liveview Bild
    $liveview = file_get_contents('/var/www/html/uploads/liveview.jpg');

    # Gibt Liveview Bild zurück
    echo $liveview;
  }
} 
?>
