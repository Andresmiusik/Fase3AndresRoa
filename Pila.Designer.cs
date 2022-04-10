
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_TotalRecaudo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Item_Salir = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Factura:";
            // 
            // cmb_Estrato
            // 
            this.cmb_Estrato.FormattingEnabled = true;
            this.cmb_Estrato.Location = new System.Drawing.Point(543, 179);
            this.cmb_Estrato.Name = "cmb_Estrato";
            this.cmb_Estrato.Size = new System.Drawing.Size(157, 23);
            this.cmb_Estrato.TabIndex = 1;
            // 
            // txt_NoFactura
            // 
            this.txt_NoFactura.Location = new System.Drawing.Point(160, 78);
            this.txt_NoFactura.Name = "txt_NoFactura";
            this.txt_NoFactura.Size = new System.Drawing.Size(157, 23);
            this.txt_NoFactura.TabIndex = 2;
            // 
            // cmb_MesFacturado
            // 
            this.cmb_MesFacturado.FormattingEnabled = true;
            this.cmb_MesFacturado.Location = new System.Drawing.Point(543, 72);
            this.cmb_MesFacturado.Name = "cmb_MesFacturado";
            this.cmb_MesFacturado.Size = new System.Drawing.Size(157, 23);
            this.cmb_MesFacturado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(75, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "N° Matricula:";
            // 
            // txt_NoMatricula
            // 
            this.txt_NoMatricula.Location = new System.Drawing.Point(160, 119);
            this.txt_NoMatricula.Name = "txt_NoMatricula";
            this.txt_NoMatricula.Size = new System.Drawing.Size(157, 23);
            this.txt_NoMatricula.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(449, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mes Facturado:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(160, 185);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(157, 23);
            this.txt_Nombre.TabIndex = 8;
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(60, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(88, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dirección:";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(160, 225);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(157, 23);
            this.txt_Direccion.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(491, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Estrato:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(431, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tipo de vivienda:";
            // 
            // cmb_Tvivienda
            // 
            this.cmb_Tvivienda.FormattingEnabled = true;
            this.cmb_Tvivienda.Location = new System.Drawing.Point(543, 225);
            this.cmb_Tvivienda.Name = "cmb_Tvivienda";
            this.cmb_Tvivienda.Size = new System.Drawing.Size(157, 23);
            this.cmb_Tvivienda.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(431, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Consumo del mes:";
            // 
            // txt_Consumo
            // 
            this.txt_Consumo.Location = new System.Drawing.Point(543, 113);
            this.txt_Consumo.Name = "txt_Consumo";
            this.txt_Consumo.Size = new System.Drawing.Size(157, 23);
            this.txt_Consumo.TabIndex = 16;
            this.txt_Consumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Consumo_KeyPress);
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(160, 271);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(157, 23);
            this.dtp_fecha.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(61, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Fecha de pago:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(460, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Total a pagar:";
            // 
            // txt_TotalPagar
            // 
            this.txt_TotalPagar.Enabled = false;
            this.txt_TotalPagar.Location = new System.Drawing.Point(543, 271);
            this.txt_TotalPagar.Name = "txt_TotalPagar";
            this.txt_TotalPagar.Size = new System.Drawing.Size(157, 23);
            this.txt_TotalPagar.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 357);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(749, 150);
            this.dataGridView1.TabIndex = 21;
            // 
            // txt_TotalRecaudo
            // 
            this.txt_TotalRecaudo.Enabled = false;
            this.txt_TotalRecaudo.Location = new System.Drawing.Point(369, 325);
            this.txt_TotalRecaudo.Name = "txt_TotalRecaudo";
            this.txt_TotalRecaudo.Size = new System.Drawing.Size(157, 23);
            this.txt_TotalRecaudo.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(276, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Recaudo total:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.reportarToolStripMenuItem,
            this.Item_Salir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.registrarToolStripMenuItem.Text = "Registrar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // reportarToolStripMenuItem
            // 
            this.reportarToolStripMenuItem.Name = "reportarToolStripMenuItem";
            this.reportarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.reportarToolStripMenuItem.Text = "Reportar";
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
            this.ClientSize = new System.Drawing.Size(797, 535);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_TotalRecaudo);
            this.Controls.Add(this.dataGridView1);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electrohuila";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_TotalRecaudo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Item_Salir;
    }
}