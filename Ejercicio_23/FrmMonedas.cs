using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_23
{
    public partial class FrmMonedas : Form
    {
        public FrmMonedas()
        {
            InitializeComponent();
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            if (btnLockCotizacion.ImageIndex == 0)
            {
                btnLockCotizacion.ImageIndex = 1;
                txtCotizacionDolar.Enabled = false;
                txtCotizacionPeso.Enabled = false;  
                txtCotizacionEuro.Enabled = false;
            }   
            else if (btnLockCotizacion.ImageIndex == 1)
            {
                btnLockCotizacion.ImageIndex = 0;
                txtCotizacionDolar.Enabled = true;
                txtCotizacionPeso.Enabled = true;
                txtCotizacionEuro.Enabled = true;
            }
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {

        }

    }
}
