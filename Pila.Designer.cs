
namespace Fase3AndresRoa
{
    partial class Pila
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pila));
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Estrato = new System.Windows.Forms.ComboBox();
            this.txt_NoFactura = new System.Windows.Forms.TextBox();
            this.cmb_MesFacturado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NoMatricula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_Tvivienda = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Consumo = new System.Windows.Forms.TextBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_TotalPagar = new System.Windows.Forms.TextBox();
            this.dg_Datos = new System.Windows.Forms.DataGridView();
            this.txt_TotalRecaudo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.item_Registrar = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Reporte = new System.Windows.Forms.ToolStripMenuItem();
            this.Item_Salir = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Datos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(190, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Factura:";
            // 
            // cmb_Estrato
            // 
            this.cmb_Estrato.FormattingEnabled = true;
            this.cmb_Estrato.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmb_Estrato.Location = new System.Drawing.Point(673, 194);
            this.cmb_Estrato.Name = "cmb_Estrato";
            this.cmb_Estrato.Size = new System.Drawing.Size(92, 23);
            this.cmb_Estrato.TabIndex = 1;
            // 
            // txt_NoFactura
            // 
            this.txt_NoFactura.Location = new System.Drawing.Point(290, 93);
            this.txt_NoFactura.Name = "txt_NoFactura";
            this.txt_NoFactura.Size = new System.Drawing.Size(157, 23);
            this.txt_NoFactura.TabIndex = 2;
            // 
            // cmb_MesFacturado
            // 
            this.cmb_MesFacturado.FormattingEnabled = true;
            this.cmb_MesFacturado.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmb_MesFacturado.Location = new System.Drawing.Point(673, 87);
            this.cmb_MesFacturado.Name = "cmb_MesFacturado";
            this.cmb_MesFacturado.Size = new System.Drawing.Size(157, 23);
            this.cmb_MesFacturado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(173, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "N° Matricula:";
            // 
            // txt_NoMatricula
            // 
            this.txt_NoMatricula.Location = new System.Drawing.Point(290, 134);
            this.txt_NoMatricula.Name = "txt_NoMatricula";
            this.txt_NoMatricula.Size = new System.Drawing.Size(157, 23);
            this.txt_NoMatricula.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(542, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mes Facturado:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(290, 200);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(157, 23);
            this.txt_Nombre.TabIndex = 8;
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(150, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(196, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dirección:";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(290, 240);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(157, 23);
            this.txt_Direccion.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(600, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Estrato:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(526, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tipo de vivienda:";
            // 
            // cmb_Tvivienda
            // 
            this.cmb_Tvivienda.FormattingEnabled = true;
            this.cmb_Tvivienda.Items.AddRange(new object[] {
            "Residencial",
            "Comercial",
            "Urbano"});
            this.cmb_Tvivienda.Location = new System.Drawing.Point(673, 240);
            this.cmb_Tvivienda.Name = "cmb_Tvivienda";
            this.cmb_Tvivienda.Size = new System.Drawing.Size(157, 23);
            this.cmb_Tvivienda.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(518, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Consumo del mes:";
            // 
            // txt_Consumo
            // 
            this.txt_Consumo.Location = new System.Drawing.Point(674, 128);
            this.txt_Consumo.Name = "txt_Consumo";
            this.txt_Consumo.Size = new System.Drawing.Size(157, 23);
            this.txt_Consumo.TabIndex = 16;
            this.txt_Consumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Consumo_KeyPress);
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(290, 286);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(157, 23);
            this.dtp_fecha.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(159, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Fecha de pago:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(553, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 21);
            this.label10.TabIndex = 19;
            this.label10.Text = "Total a pagar:";
            // 
            // txt_TotalPagar
            // 
            this.txt_TotalPagar.Enabled = false;
            this.txt_TotalPagar.Location = new System.Drawing.Point(673, 286);
            this.txt_TotalPagar.Name = "txt_TotalPagar";
            this.txt_TotalPagar.Size = new System.Drawing.Size(157, 23);
            this.txt_TotalPagar.TabIndex = 20;
            // 
            // dg_Datos
            // 
            this.dg_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Datos.Location = new System.Drawing.Point(12, 373);
            this.dg_Datos.Name = "dg_Datos";
            this.dg_Datos.RowTemplate.Height = 25;
            this.dg_Datos.Size = new System.Drawing.Size(984, 150);
            this.dg_Datos.TabIndex = 21;
            // 
            // txt_TotalRecaudo
            // 
            this.txt_TotalRecaudo.Enabled = false;
            this.txt_TotalRecaudo.ForeColor = System.Drawing.Color.Green;
            this.txt_TotalRecaudo.Location = new System.Drawing.Point(485, 344);
            this.txt_TotalRecaudo.Name = "txt_TotalRecaudo";
            this.txt_TotalRecaudo.Size = new System.Drawing.Size(157, 23);
            this.txt_TotalRecaudo.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(359, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "Recaudo total:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_Registrar,
            this.item_Eliminar,
            this.item_Reporte,
            this.Item_Salir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // item_Registrar
            // 
            this.item_Registrar.Name = "item_Registrar";
            this.item_Registrar.Size = new System.Drawing.Size(65, 20);
            this.item_Registrar.Text = "Registrar";
            this.item_Registrar.Click += new System.EventHandler(this.item_Registrar_Click);
            // 
            // item_Eliminar
            // 
            this.item_Eliminar.ForeColor = System.Drawing.Color.Maroon;
            this.item_Eliminar.Name = "item_Eliminar";
            this.item_Eliminar.Size = new System.Drawing.Size(62, 20);
            this.item_Eliminar.Text = "Eliminar";
            this.item_Eliminar.Click += new System.EventHandler(this.item_Eliminar_Click);
            // 
            // item_Reporte
            // 
            this.item_Reporte.Name = "item_Reporte";
            this.item_Reporte.Size = new System.Drawing.Size(64, 20);
            this.item_Reporte.Text = "Reportar";
            this.item_Reporte.Click += new System.EventHandler(this.item_Reporte_Click);
            // 
            // Item_Salir
            // 
            this.Item_Salir.Name = "Item_Salir";
            this.Item_Salir.Size = new System.Drawing.Size(41, 20);
            this.Item_Salir.Text = "Salir";
            this.Item_Salir.Click += new System.EventHandler(this.Item_Salir_Click_1);
            // 
            // Pila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.BackgroundImage = global::Fase3AndresRoa.Properties.Resources.Fondo_Bombilla;
            this.ClientSize = new System.Drawing.Size(1024, 536);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_TotalRecaudo);
            this.Controls.Add(this.dg_Datos);
            this.Controls.Add(this.txt_TotalPagar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.txt_Consumo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_Tvivienda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NoMatricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_MesFacturado);
            this.Controls.Add(this.txt_NoFactura);
            this.Controls.Add(this.cmb_Estrato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1040, 575);
            this.MinimumSize = new System.Drawing.Size(1040, 575);
            this.Name = "Pila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electrohuila";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Datos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Estrato;
        private System.Windows.Forms.TextBox txt_NoFactura;
        private System.Windows.Forms.ComboBox cmb_MesFacturado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NoMatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_Tvivienda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Consumo;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_TotalPagar;
        private System.Windows.Forms.DataGridView dg_Datos;
        private System.Windows.Forms.TextBox txt_TotalRecaudo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem item_Registrar;
        private System.Windows.Forms.ToolStripMenuItem item_Eliminar;
        private System.Windows.Forms.ToolStripMenuItem item_Reporte;
        private System.Windows.Forms.ToolStripMenuItem Item_Salir;
    }
}