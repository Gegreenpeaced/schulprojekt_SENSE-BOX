using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherDll;

namespace Wetterstation
{
    public partial class frmWetterstation : Form
    {
        // Variablen Initialisierung
        public string apiIP;
        public string pictureIP;

        // Formularkonstruktor
        public frmWetterstation()
        {
            InitializeComponent();
            lblInfo.Text = "Keine Fehler!";
            cbDataSource.SelectedIndex = 0;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

        }

        // Methode für Comboboxindexänderung
        private void cbDataSourceIndexChange(object sender, EventArgs e)
        {
            if(cbDataSource.SelectedIndex == 0)
            {
                tbapiIP.Visible = false;
                lblIP.Visible = false;
                apiIP = "http://api.norku.de/api/v1/senseBox/weather";
                pictureIP = "http://api.norku.de/api/v1/senseBox/liveview";
            }
            if(cbDataSource.SelectedIndex == 1)
            {
                tbapiIP.Visible = true;
                lblIP.Visible = true;
                apiIP = tbapiIP.Text;
            }
        }

        // Button abfrage Daten
        private void btnGetData_Click(object sender, EventArgs e)
        {
            // Abfrage: Ist IP Feld leer?
            if (string.IsNullOrEmpty(apiIP))
            {
                string message = "Bitte füge eine gültige IP-Adresse im Formular ein.";
                string title = "Feld leer!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
            else
            {
                // try-catch für Debugging
                try
                {
                    // Letzte Abfrage schreiben
                    lblInfo.Text = "Letzte Abfrage um: " + DateTime.Now.ToString("HH:mm");


                    // Klasse von eingebundener DLL erstellen
                    mainPrgDll wetterdatenAPI = new mainPrgDll();

                    // Wettedaten holen - Methode aufrufen, in Objekt schreiben

                    WeatherData weatherData = wetterdatenAPI.GetData(apiIP);

                    // geholte Daten in Textbox schreiben.

                    tbFrmHum.Text = weatherData.Luftfeuchtigkeit.ToString() + " %";
                    tbFrmLight.Text = weatherData.Beleuchtungsstaerke.ToString() + " lx";
                    tbFrmPress.Text = weatherData.Luftdruck.ToString() + " hPa";
                    tbFrmTemp.Text = weatherData.Temperatur.ToString() + " °C";
                    tbFrmUV.Text = weatherData.UVStrahlung.ToString() + " µW/cm";

                    // Daten in PictureBox schreiben
                    pbLivePicture.Image = wetterdatenAPI.GetPicture(pictureIP);

                }
                // Catch für geworfene DLL Fehler usw.
                catch (Exception ex)
                {
                    string message = "Ein Fehler ist aufgetreten!\n\nBeim Fehler handelt es sich um:\n" + ex;
                    string title = "Fehler!";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                }
            }
        }



        // Button für Formular schließen
        private void btnClose_Click(object sender, EventArgs e)
        {
            // Messagebox Abfrage zum Fenster schliessen
            string message = "Möchtest du die Anwendung schliessen?";
            string title = "Anwendung schliessen?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
