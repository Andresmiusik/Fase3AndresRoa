using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase3AndresRoa
{
    public partial class Pila : Form
    {
        public Pila()
        {
            InitializeComponent();
        }
        //Varibales utilizadas
        private string strNoFactura;
        private string strMes;
        private string strNoMatricula;
        private string strConsumo;
        private string strNombre;
        private string strDireccion;
        private string strEstrato;
        private string strTipoVivienda;
        private string strFechaPago;
        private int intTotalpagar;
        private int intTotalRecaudo;

        private void txt_Consumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                MessageBox.Show("Solo se aceptar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && e.KeyChar != 32 && e.KeyChar != 8 && e.KeyChar != 164)
            {
                MessageBox.Show("Solo se aceptar letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void Item_Salir_Click_1(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
