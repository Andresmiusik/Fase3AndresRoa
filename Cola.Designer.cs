
namespace Fase3AndresRoa
{
    partial class Cola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cola));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.item_Registrar = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Reporte = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_NoViaje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Identificacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.cmb_Empresa = new System.Windows.Forms.ComboBox();
            this.cmb_Destino = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_TotalViajes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dg_Cola = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Cola)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_Registrar,
            this.item_Eliminar,
            this.item_Reporte,
            this.item_Salir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(689, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // item_Registrar
            // 
            this.item_Registrar.Name = "item_Registrar";
            this.item_Registrar.Size = new System.Drawing.Size(63, 20);
            this.item_Registrar.Text = "Registar";
            this.item_Registrar.Click += new System.EventHandler(this.item_Registrar_Click);
            // 
            // item_Eliminar
            // 
            this.item_Eliminar.ForeColor = System.Drawing.Color.Maroon;
            this.item_Eliminar.Name = "item_Eliminar";
            this.item_Eliminar.Size = new System.Drawing.Size(63, 20);
            this.item_Eliminar.Text = "Eliminar";
            this.item_Eliminar.Click += new System.EventHandler(this.item_Eliminar_Click);
            // 
            // item_Reporte
            // 
            this.item_Reporte.Name = "item_Reporte";
            this.item_Reporte.Size = new System.Drawing.Size(68, 20);
            this.item_Reporte.Text = "Reportar";
            this.item_Reporte.Click += new System.EventHandler(this.item_Reporte_Click);
            // 
            // item_Salir
            // 
            this.item_Salir.Name = "item_Salir";
            this.item_Salir.Size = new System.Drawing.Size(42, 20);
            this.item_Salir.Text = "Salir";
            this.item_Salir.Click += new System.EventHandler(this.item_Salir_Click);
            // 
            // txt_NoViaje
            // 
            this.txt_NoViaje.Location = new System.Drawing.Point(166, 172);
            this.txt_NoViaje.Name = "txt_NoViaje";
            this.txt_NoViaje.Size = new System.Drawing.Size(158, 23);
            this.txt_NoViaje.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(63, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "N° de Viaje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(29, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "N° Identificación: ";
            // 
            // txt_Identificacion
            // 
            this.txt_Identificacion.Location = new System.Drawing.Point(166, 94);
            this.txt_Identificacion.Name = "txt_Identificacion";
            this.txt_Identificacion.Size = new System.Drawing.Size(158, 23);
            this.txt_Identificacion.TabIndex = 4;
            this.txt_Identificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Identificacion_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(22, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre Completo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(418, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Empresa:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(166, 131);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(158, 23);
            this.txt_Nombre.TabIndex = 8;
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // cmb_Empresa
            // 
            this.cmb_Empresa.FormattingEnabled = true;
            this.cmb_Empresa.Items.AddRange(new object[] {
            "MAGDALENA",
            "MACARENA",
            "LIBERTADORES",
            "VALLE DE TENZA",
            "COOMOTOR"});
            this.cmb_Empresa.Location = new System.Drawing.Point(499, 91);
            this.cmb_Empresa.Name = "cmb_Empresa";
            this.cmb_Empresa.Size = new System.Drawing.Size(158, 23);
            this.cmb_Empresa.TabIndex = 9;
            // 
            // cmb_Destino
            // 
            this.cmb_Destino.FormattingEnabled = true;
            this.cmb_Destino.Items.AddRange(new object[] {
            "Bogotá",
            "Medellín",
            "Cali",
            "Cartagena",
            "Florencia"});
            this.cmb_Destino.Location = new System.Drawing.Point(499, 128);
            this.cmb_Destino.Name = "cmb_Destino";
            this.cmb_Destino.Size = new System.Drawing.Size(158, 23);
            this.cmb_Destino.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(424, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Destino:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(380, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha de viaje:";
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fecha.Location = new System.Drawing.Point(499, 169);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(114, 23);
            this.dtp_Fecha.TabIndex = 13;
            // 
            // txt_TotalViajes
            // 
            this.txt_TotalViajes.Enabled = false;
            this.txt_TotalViajes.Location = new System.Drawing.Point(363, 423);
            this.txt_TotalViajes.Name = "txt_TotalViajes";
            this.txt_TotalViajes.Size = new System.Drawing.Size(115, 23);
            this.txt_TotalViajes.TabIndex = 14;
            this.txt_TotalViajes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(247, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total de viajes:";
            // 
            // dg_Cola
            // 
            this.dg_Cola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Cola.Location = new System.Drawing.Point(29, 267);
            this.dg_Cola.Name = "dg_Cola";
            this.dg_Cola.RowTemplate.Height = 25;
            this.dg_Cola.Size = new System.Drawing.Size(632, 150);
            this.dg_Cola.TabIndex = 16;
            // 
            // Cola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.BackgroundImage = global::Fase3AndresRoa.Properties.Resources.Fondo_Via;
            this.ClientSize = new System.Drawing.Size(689, 451);
            this.Controls.Add(this.dg_Cola);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_TotalViajes);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_Destino);
            this.Controls.Add(this.cmb_Empresa);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Identificacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NoViaje);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(705, 490);
            this.MinimumSize = new System.Drawing.Size(705, 490);
            this.Name = "Cola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terminal de Transportes de Neiva";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Cola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem item_Registrar;
        private System.Windows.Forms.ToolStripMenuItem item_Eliminar;
        private System.Windows.Forms.ToolStripMenuItem item_Reporte;
        private System.Windows.Forms.ToolStripMenuItem item_Salir;
        private System.Windows.Forms.TextBox txt_NoViaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Identificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.ComboBox cmb_Empresa;
        private System.Windows.Forms.ComboBox cmb_Destino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.TextBox txt_TotalViajes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dg_Cola;
    }
}