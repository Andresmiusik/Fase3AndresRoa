
namespace Fase3AndresRoa
{
    partial class Lista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Identificacion = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Estrato = new System.Windows.Forms.ComboBox();
            this.dg_Lista = new System.Windows.Forms.DataGridView();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.item_Registrar = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Consultar = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Salir = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Lista)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(26, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Identificación:";
            // 
            // txt_Identificacion
            // 
            this.txt_Identificacion.Location = new System.Drawing.Point(175, 109);
            this.txt_Identificacion.Name = "txt_Identificacion";
            this.txt_Identificacion.Size = new System.Drawing.Size(140, 23);
            this.txt_Identificacion.TabIndex = 1;
            this.txt_Identificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Identificacion_KeyPress);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(175, 155);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(140, 23);
            this.txt_Nombre.TabIndex = 2;
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Completo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(354, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad:";
            // 
            // txt_Edad
            // 
            this.txt_Edad.Location = new System.Drawing.Point(424, 111);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(56, 23);
            this.txt_Edad.TabIndex = 5;
            this.txt_Edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Edad_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(351, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estrato:";
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
            this.cmb_Estrato.Location = new System.Drawing.Point(424, 150);
            this.cmb_Estrato.Name = "cmb_Estrato";
            this.cmb_Estrato.Size = new System.Drawing.Size(56, 23);
            this.cmb_Estrato.TabIndex = 7;
            this.cmb_Estrato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Estrato_KeyPress);
            // 
            // dg_Lista
            // 
            this.dg_Lista.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dg_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Lista.Location = new System.Drawing.Point(31, 288);
            this.dg_Lista.Name = "dg_Lista";
            this.dg_Lista.RowTemplate.Height = 25;
            this.dg_Lista.Size = new System.Drawing.Size(522, 150);
            this.dg_Lista.TabIndex = 8;
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Fecha.Location = new System.Drawing.Point(283, 210);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(106, 23);
            this.dtp_Fecha.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(219, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_Registrar,
            this.item_Consultar,
            this.item_Eliminar,
            this.item_Salir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(589, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // item_Registrar
            // 
            this.item_Registrar.Name = "item_Registrar";
            this.item_Registrar.Size = new System.Drawing.Size(65, 20);
            this.item_Registrar.Text = "Registrar";
            this.item_Registrar.Click += new System.EventHandler(this.item_Registrar_Click);
            // 
            // item_Consultar
            // 
            this.item_Consultar.Name = "item_Consultar";
            this.item_Consultar.Size = new System.Drawing.Size(70, 20);
            this.item_Consultar.Text = "Consultar";
            this.item_Consultar.Click += new System.EventHandler(this.item_Consultar_Click);
            // 
            // item_Eliminar
            // 
            this.item_Eliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.item_Eliminar.ForeColor = System.Drawing.Color.DarkRed;
            this.item_Eliminar.Name = "item_Eliminar";
            this.item_Eliminar.Size = new System.Drawing.Size(63, 20);
            this.item_Eliminar.Text = "Eliminar";
            this.item_Eliminar.Click += new System.EventHandler(this.item_Eliminar_Click);
            // 
            // item_Salir
            // 
            this.item_Salir.Name = "item_Salir";
            this.item_Salir.Size = new System.Drawing.Size(41, 20);
            this.item_Salir.Text = "Salir";
            this.item_Salir.Click += new System.EventHandler(this.item_Salir_Click);
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::Fase3AndresRoa.Properties.Resources.Fondo_Gym;
            this.ClientSize = new System.Drawing.Size(589, 451);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.dg_Lista);
            this.Controls.Add(this.cmb_Estrato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Identificacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(605, 490);
            this.MinimumSize = new System.Drawing.Size(605, 490);
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gimnasio Olimpiacos";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Lista)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Identificacion;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Estrato;
        private System.Windows.Forms.DataGridView dg_Lista;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem item_Registrar;
        private System.Windows.Forms.ToolStripMenuItem item_Consultar;
        private System.Windows.Forms.ToolStripMenuItem item_Eliminar;
        private System.Windows.Forms.ToolStripMenuItem item_Salir;
    }
}