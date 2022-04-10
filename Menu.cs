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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_pila_Click(object sender, EventArgs e)
        {
            Pila pila = new Pila();
            pila.Show();
        }

        private void btn_cola_Click(object sender, EventArgs e)
        {
            Cola cola = new Cola();
            cola.Show();
        }

        private void btn_lista_Click(object sender, EventArgs e)
        {
            Lista lista = new Lista();
            lista.Show();
        }
    }
}
