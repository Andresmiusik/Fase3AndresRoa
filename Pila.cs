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
            this.item_Eliminar.Enabled = false;
            this.item_Reporte.Enabled = false;
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
        private int intCosto = 500;

        //Generar método de almacenamiento.
        Stack<PilaElectricidad> pilaelectricidad = new Stack<PilaElectricidad>();

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

        private void item_Registrar_Click(object sender, EventArgs e)
        {
            if (Validarcampos())
            {
                PilaElectricidad mipila = new PilaElectricidad();
                mipila.NoFactura = this.strNoFactura;
                mipila.NoMatricula = this.strNoMatricula;
                mipila.Mes = this.strMes;
                mipila.Consumo = this.strConsumo;
                mipila.Nombre = this.strNombre;
                mipila.Direccion = this.strDireccion;
                mipila.Estrato = this.strEstrato;
                mipila.TipoVivienda = this.strTipoVivienda;
                mipila.FechaPago = this.strFechaPago;
                mipila.Totalpagar = this.intTotalpagar;
                mipila.FechaPago = this.strFechaPago;
                
                pilaelectricidad.Push(mipila);
                dg_Datos.DataSource = null;
                dg_Datos.DataSource = pilaelectricidad.ToArray();

                this.intTotalRecaudo = this.intTotalRecaudo + this.intTotalpagar;
                

                MessageBox.Show("Su registro se ha agregado correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                this.item_Reporte.Enabled = true;
                this.item_Eliminar.Enabled = true;
            }
        }

        private void item_Reporte_Click(object sender, EventArgs e)
        {
            txt_TotalRecaudo.Text = "$ " + intTotalRecaudo.ToString();
        }
        private void item_Eliminar_Click(object sender, EventArgs e)
        {
            if (this.pilaelectricidad.Count() > 0)
            {
                DialogResult r;
                r = MessageBox.Show("Va a eliminar el último registro \n ¿Desea continuar?", "Elimiar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                {
                    if (r == DialogResult.Yes)
                    {
                        PilaElectricidad pilaElectricidad = new PilaElectricidad();
                        pilaElectricidad = this.pilaelectricidad.Pop();
                        this.intTotalRecaudo = this.intTotalRecaudo - pilaElectricidad.Totalpagar;
                        txt_TotalRecaudo.Text = "$ " + intTotalRecaudo.ToString();
                        if (pilaelectricidad.Count <= 0)
                        {
                            this.item_Reporte.Enabled = false;
                            this.item_Eliminar.Enabled = false;
                        }

                        dg_Datos.DataSource = this.pilaelectricidad.ToArray();
                        MessageBox.Show("El último dato ingresado ha sido eliminado", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
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

        //Validar campos vacios
        private Boolean Validarcampos()
        {
            String strMensaje = "";
            //Valida el campo N° Factura
            this.strNoFactura = this.txt_NoFactura.Text.Trim();
            if(strNoFactura == "")
            {
                strMensaje = strMensaje + "- Falta el número de la factura. \n";
                this.txt_NoFactura.Focus();
            }
            //Valida el campo N° Matrícula
            this.strNoMatricula = this.txt_NoMatricula.Text.Trim();
            if (strNoMatricula == "")
            {
                strMensaje = strMensaje + "- Falta el número de la matrícula. \n";
                this.txt_NoMatricula.Focus();
            }
            //Valida el campo Mes Facturado
            this.strMes = this.cmb_MesFacturado.Text.Trim();
            if (strMes == "")
            {
                strMensaje = strMensaje + "- Falta el mes facturado. \n";
                this.cmb_MesFacturado.Focus();
            }
            //Valida el consumo del mes
            this.strConsumo = this.txt_Consumo.Text.Trim();
            if (strConsumo == "")
            {
                strMensaje = strMensaje + "- Falta el consumo del mes. \n";
                this.txt_Consumo.Focus();
            }
            else
            {
                intTotalpagar = Int32.Parse(strConsumo) * intCosto;
                txt_TotalPagar.Text = "$ " + intTotalpagar.ToString();
            }

            //Valida el Nombre del cliente
            this.strNombre = this.txt_Nombre.Text.Trim();
            if (strNombre == "")
            {
                strMensaje = strMensaje + "- Falta el nombre. \n";
                this.txt_Nombre.Focus();
            }
            //Valida la Dirección
            this.strDireccion = this.txt_Direccion.Text.Trim();
            if (strDireccion == "")
            {
                strMensaje = strMensaje + "- Falta la dirección. \n";
                this.txt_Direccion.Focus();
            }
            //Valida el Estrato
            this.strEstrato = this.cmb_Estrato.Text.Trim();
            if (strEstrato == "")
            {
                strMensaje = strMensaje + "- Falta el estrato. \n";
                this.txt_Direccion.Focus();
            }
            //Valida el Tipo de vivienda
            this.strTipoVivienda = this.cmb_Tvivienda.Text.Trim();
            if (strTipoVivienda== "")
            {
                strMensaje = strMensaje + "- Falta el tipo de vivienda. \n";
                this.cmb_Tvivienda.Focus();
            }
            if(strMensaje != ""){
                strMensaje = "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\nFALTA INGRESAR LOS SIGUIENTES CAMPOS\n!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! \n" + strMensaje;
                MessageBox.Show(strMensaje, "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                strFechaPago = dtp_fecha.Text;
                return true;
            }
        }

        //Metodo para limpiar los campos
        private void LimpiarCampos()
        {
            txt_NoFactura.Text = "";
            txt_NoMatricula.Text = "";
            cmb_MesFacturado.Text = "";
            txt_Consumo.Text = "";

            txt_Nombre.Text = "";
            cmb_Estrato.Text = "";
            txt_Direccion.Text = "";
            cmb_Tvivienda.Text = "";
            txt_TotalPagar.Text = "";
            dtp_fecha.Value = DateTime.Now;
            txt_NoFactura.Focus();
        }

        
    }
}
