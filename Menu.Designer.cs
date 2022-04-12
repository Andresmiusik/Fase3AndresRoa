
namespace Fase3AndresRoa
{
    partial class frm_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_pila = new System.Windows.Forms.Button();
            this.btn_cola = new System.Windows.Forms.Button();
            this.btn_lista = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú Principal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(122, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elija una opción:";
            // 
            // btn_pila
            // 
            this.btn_pila.Location = new System.Drawing.Point(82, 98);
            this.btn_pila.Name = "btn_pila";
            this.btn_pila.Size = new System.Drawing.Size(237, 30);
            this.btn_pila.TabIndex = 2;
            this.btn_pila.Text = "Empresa Electrohuila (Pila)";
            this.btn_pila.UseVisualStyleBackColor = true;
            this.btn_pila.Click += new System.EventHandler(this.btn_pila_Click);
            // 
            // btn_cola
            // 
            this.btn_cola.Location = new System.Drawing.Point(82, 147);
            this.btn_cola.Name = "btn_cola";
            this.btn_cola.Size = new System.Drawing.Size(237, 30);
            this.btn_cola.TabIndex = 3;
            this.btn_cola.Text = "Terminal de transportes de Neiva (Cola)";
            this.btn_cola.UseVisualStyleBackColor = true;
            this.btn_cola.Click += new System.EventHandler(this.btn_cola_Click);
            // 
            // btn_lista
            // 
            this.btn_lista.Location = new System.Drawing.Point(82, 193);
            this.btn_lista.Name = "btn_lista";
            this.btn_lista.Size = new System.Drawing.Size(237, 30);
            this.btn_lista.TabIndex = 4;
            this.btn_lista.Text = "Gimnasio Olimpiacos (Lista)";
            this.btn_lista.UseVisualStyleBackColor = true;
            this.btn_lista.Click += new System.EventHandler(this.btn_lista_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(166, 245);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fase3AndresRoa.Properties.Resources.Degradado_menu;
            this.ClientSize = new System.Drawing.Size(406, 287);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_lista);
            this.Controls.Add(this.btn_cola);
            this.Controls.Add(this.btn_pila);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(422, 326);
            this.MinimumSize = new System.Drawing.Size(422, 326);
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_pila;
        private System.Windows.Forms.Button btn_cola;
        private System.Windows.Forms.Button btn_lista;
        private System.Windows.Forms.Button btn_salir;
    }
}