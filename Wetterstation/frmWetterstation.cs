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
        public frmWetterstation()
        {
            InitializeComponent();
            lblInfo.Text = "Keine Fehler!";
        }

        // Button abfrage Daten
        private void btnGetData_Click(object sender, EventArgs e)
        {
            // try-catch für Debugging
            try
            {
                // Letzte Abfrage schreiben
                lblInfo.Text = "Letzte Abfrage um: " + DateTime.Now.ToString("hh:mm");


                // Klasse von eingebundener DLL erstellen
                mainPrgDll wetterdatenAPI = new mainPrgDll();

                // Wettedaten holen - Methode aufrufen, in Objekt schreiben

                WeatherData weatherData = wetterdatenAPI.GetData("https://example.example");

                // geholte Daten in Textbox schreiben.

                tbFrmHum.Text = weatherData.Luftfeuchtigkeit.ToString() + " %";
                tbFrmLight.Text = weatherData.Beleuchtungsstaerke.ToString() + " lx";
                tbFrmPress.Text = weatherData.Luftdruck.ToString() + " hPa";
                tbFrmTemp.Text = weatherData.Temperatur.ToString() + " °C";
                tbFrmUV.Text = weatherData.UVStrahlung.ToString() + " µW/cm";

            }
            // Catch für geworfene DLL Fehler usw.
            catch(Exception ex)
            {
                string message = "Ein Fehler ist aufgetreten!\n\nBeim Fehler handelt es sich um:\n" + ex;
                string title = "Fehler!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
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
