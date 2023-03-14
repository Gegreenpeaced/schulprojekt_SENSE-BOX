using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wetterstation
{
    public partial class frmWetterstation : Form
    {
        public frmWetterstation()
        {
            InitializeComponent();
        }




        private void btnClose_Click(object sender, EventArgs e)
        {
            // Message Box Abfrage adden
            Application.Exit();
        }
    }
}
