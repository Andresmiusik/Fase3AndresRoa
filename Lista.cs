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
    public partial class Lista : Form
    {
        public Lista()
        {
            InitializeComponent();
            this.item_Eliminar.Enabled = false;
            this.item_Consultar.Enabled = false;
        }

        //VARIABLES
        private string strIdentificacion;
        private string strNombre;
        private string strEdad;
        private string strEstrato;
        private string strFecha;

        //Almacenamiento de datos
        List<ListaCliente> listacliente = new List<ListaCliente>();

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

        private void txt_Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                MessageBox.Show("Solo se aceptar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void cmb_Estrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                MessageBox.Show("Solo se aceptar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void item_Registrar_Click(object sender, EventArgs e)
        {
            if (ValidarCaompos())
            {
                ListaCliente milista = new ListaCliente();
                milista.Identificacion = this.strIdentificacion;
                milista.Nombre = this.strNombre;
                milista.Estrato = this.strEstrato;
                milista.Edad = this.strEdad;
                milista.Fecha = this.strFecha;

                if (VerificarIdentificacion(milista.Identificacion) != null)
                {
                    MessageBox.Show("La identificación  '" + milista.Identificacion + "' ya existe.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Identificacion.Focus();
                }
                else
                {
                    listacliente.Add(milista);
                    dg_Lista.DataSource = null;
                    dg_Lista.DataSource = listacliente.ToArray();

                    MessageBox.Show("Su registro se ha agregado correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    this.item_Consultar.Enabled = true;
                    this.item_Eliminar.Enabled = true;
                }


            }
        }

        private void item_Consultar_Click(object sender, EventArgs e)
        {
            if(listacliente.Count > 0)
            {
                string strbusqueda = this.txt_Identificacion.Text.Trim();
                if (strbusqueda != "")
                {
                    ListaCliente milista = VerificarIdentificacion(strbusqueda);
                    {
                        if (milista != null)
                        {
                            txt_Identificacion.Text = milista.Identificacion;
                            txt_Nombre.Text = milista.Nombre;
                            txt_Edad.Text = milista.Edad;
                            cmb_Estrato.Text = milista.Estrato;
                            dtp_Fecha.Value = Convert.ToDateTime(milista.Fecha);
                            MessageBox.Show("Se ha cargado la información correctamente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("La identificación '" + strbusqueda + "' no existe en la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_Identificacion.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El campo de identificación no puede estar vacio para consultar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("No se encontraron más registros.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.item_Eliminar.Enabled = false;
                this.item_Consultar.Enabled = false;
            }

        }

        private void item_Eliminar_Click(object sender, EventArgs e)
        {
            if (listacliente.Count > 0)
            {
                string streliminar = this.txt_Identificacion.Text.Trim();
                if (streliminar != "")
                {
                    ListaCliente milista = VerificarIdentificacion(streliminar);
                    {
                        if (milista != null)
                        {
                            DialogResult r;
                            r = MessageBox.Show("¿Está seguro que desea elimiar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (r == DialogResult.Yes)
                            {
                                this.listacliente.Remove(milista);
                                dg_Lista.DataSource = listacliente.ToArray();
                                MessageBox.Show("Se a eliminado correctamente: ID: '" + streliminar +"'", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarCampos();
                            }
                        }
                        else
                        {
                            MessageBox.Show("La identificación '" + streliminar + "' no existe en la lista.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_Identificacion.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El campo de identificación no puede estar vacio para eliminar.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_Identificacion.Focus();
                }
            }
        }

        private void item_Salir_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Validar campos

        private Boolean ValidarCaompos()
        {
            String strMensaje = "";

            this.strIdentificacion = this.txt_Identificacion.Text.Trim();
            if (strIdentificacion == "")
            {
                strMensaje = strMensaje + "- Falta el número de Identificación. \n";
                this.txt_Identificacion.Focus();
            }
            this.strNombre = txt_Nombre.Text.Trim();
            if (strNombre == "")
            {
                strMensaje = strMensaje + "- Falta el nombre. \n";
                this.txt_Nombre.Focus();
            }
            this.strEdad = txt_Edad.Text.Trim();
            if (strEdad == "")
            {
                strMensaje = strMensaje + "- Falta la edad. \n";
                this.txt_Edad.Focus();
            }
            this.strEstrato = cmb_Estrato.Text.Trim();
            if (strEstrato == "")
            {
                strMensaje = strMensaje + "- Falta la el estrato. \n";
                this.cmb_Estrato.Focus();
            }
            if (strMensaje != "")
            {
                strMensaje = "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\nFALTA INGRESAR LOS SIGUIENTES CAMPOS\n!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! \n" + strMensaje;
                MessageBox.Show(strMensaje, "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                strFecha = dtp_Fecha.Text;
                return true;
            }
        }
        private void LimpiarCampos()
        {
            txt_Identificacion.Text = "";
            txt_Nombre.Text = "";
            txt_Edad.Text = "";
            cmb_Estrato.Text = "";
            dtp_Fecha.Value = DateTime.Now;
        }

        private ListaCliente VerificarIdentificacion(String strIdentificacionR)
        {
            foreach(ListaCliente milista in this.listacliente)
            {
                if (milista.Identificacion == strIdentificacionR)
                {
                    return milista;
                }
            }

            return null;
        }
    }
}
