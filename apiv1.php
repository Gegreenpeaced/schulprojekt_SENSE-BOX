<?php
#Bestimmen des Endpunktes (/api/v1/class/method)
$class  = filter_input(INPUT_GET, 'class',  FILTER_SANITIZE_STRING);
$method = filter_input(INPUT_GET, 'method', FILTER_SANITIZE_STRING);

#Anweisung für Endpunkt senseBox/weather
if($class == "senseBox" && $method == "weather"){
  if(!empty($_POST)){ # Wenn Daten hochgeladen werden
    #Kodiert erhaltene Daten zu JSON
    $data = json_encode($_POST);
    
    #Öffnen Datei und speichert die neuen Daten
    $cacheFile = fopen("/var/tmp/readout.json", "w");
    fwrite($cacheFile, $data);
    fclose($cacheFile);
    
  } else { #Wenn Daten aufgerufen werden
    #Gibt Daten aus Datei zurück
    echo(file_get_contents("/var/tmp/readout.json"));
  } 
}
?>
