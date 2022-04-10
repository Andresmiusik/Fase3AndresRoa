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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (txt_clave.Text == "123")
            {
                frm_menu menu = new frm_menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                DialogResult r;
                r = MessageBox.Show("La contraseña es incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
