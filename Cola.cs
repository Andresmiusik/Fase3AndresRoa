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
    public partial class Cola : Form
    {
        public Cola()
        {
            InitializeComponent();
            txt_Identificacion.Focus();
            this.item_Eliminar.Enabled = false;
            this.item_Reporte.Enabled = false;
        }

        //Generar método de almacenamiento
        Queue<ColaViaje> colaviaje = new Queue<ColaViaje>();

        private void txt_Identificacion_KeyPress(object sender, KeyPressEventArgs e)
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

        //VARIABLES
        private string strNoViaje;
        private string strIdentificacion;
        private string strNombre;
        private string strEmpresa;
        private string strDestino;
        private string strFecha;
        private int intTotalViajes;

        private void item_Registrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                ColaViaje micola = new ColaViaje();
                micola.NoViaje = this.strNoViaje;
                micola.Identificacion = this.strIdentificacion;
                micola.Nombre = this.strNombre;
                micola.Empresa = this.strEmpresa;
                micola.Destino = this.strDestino;
                micola.Fecha = this.strFecha;           
                colaviaje.Enqueue(micola);
                intTotalViajes = intTotalViajes + 1;

                dg_Cola.DataSource = null;
                dg_Cola.DataSource = this.colaviaje.ToArray();
                MessageBox.Show("Su registro se ha agregado correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();

                this.item_Eliminar.Enabled = true;
                this.item_Reporte.Enabled = true;
            }
        }

        private void item_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Va a eliminar el primer registro \n ¿Desea continuar?", "Alerta",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                if (this.colaviaje.Count() > 0)
                {
                    ColaViaje micola = new ColaViaje();
                    micola = this.colaviaje.Dequeue();
                    this.intTotalViajes = intTotalViajes - 1;
                    txt_TotalViajes.Text = intTotalViajes.ToString();
                    MessageBox.Show("El último dato ingresado ha sido eliminado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dg_Cola.DataSource = this.colaviaje.ToArray();
                }
                else
                {
                    MessageBox.Show("No hay ningún registro.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.item_Eliminar.Enabled = false;
                    this.item_Reporte.Enabled = false;
                }
            }
        }

        private void item_Reporte_Click(object sender, EventArgs e)
        {
            txt_TotalViajes.Text = intTotalViajes.ToString();
        }

        private void item_Salir_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private Boolean ValidarCampos()
        {
            string strMensaje = "";

            //Valida la identificación.
            this.strIdentificacion = this.txt_Identificacion.Text.Trim();
            if (strIdentificacion == "")
            {
                strMensaje = "-Falta el número de identificación \n";
                txt_Identificacion.Focus();
            }
            //Valida el Nombre
            this.strNombre = this.txt_Nombre.Text.Trim();
            if (strNombre == "")
            {
                strMensaje = strMensaje + "-Falta el nombre. \n";
                txt_Nombre.Focus();
            }
            //Valida el número de viaje
            this.strNoViaje = this.txt_NoViaje.Text.Trim();
            if (strNoViaje == "")
            {
                strMensaje = strMensaje + "-Falta el número de viaje. \n";
                txt_NoViaje.Focus();
            }
            //Valida la empresa de viaje
            this.strEmpresa = this.cmb_Empresa.Text.Trim();
            if (strEmpresa == "")
            {
                strMensaje = strMensaje + "-Falta la empresa de viaje. \n";
                cmb_Empresa.Focus();
            }
            //Valida el destino
            this.strDestino = this.cmb_Destino.Text.Trim();
            if (strDestino == "")
            {
                strMensaje = strMensaje + "-Falta el destino. \n";
                cmb_Destino.Focus();
            }
            if(strMensaje != "")
            {
                strMensaje = "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\nFALTA INGRESAR LOS SIGUIENTES CAMPOS\n!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! \n" + strMensaje;
                MessageBox.Show(strMensaje, "Datos Faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                strFecha = dtp_Fecha.Text;
                return true;
            }
        }

        //Metodo para limpiar los campos
        private void LimpiarCampos()
        {
            txt_Identificacion.Text = "";
            txt_Nombre.Text = "";
            txt_NoViaje.Text = "";
            cmb_Destino.Text = "";
            cmb_Empresa.Text = "";
            dtp_Fecha.Value = DateTime.Now;
            txt_Identificacion.Focus();
        }
    }
}
