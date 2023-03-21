using System;
using System.Windows.Forms;

namespace Wetterstation
{
    public partial class frmWetterstation : Form
    {
        // Variablen Initialisierung

        // Formularkonstruktor
        public frmWetterstation()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

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
