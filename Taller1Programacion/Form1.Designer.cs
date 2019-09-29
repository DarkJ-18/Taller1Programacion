namespace Taller1Programacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnmasa = new System.Windows.Forms.Button();
            this.btnllamadas = new System.Windows.Forms.Button();
            this.btnnotas = new System.Windows.Forms.Button();
            this.btnvolumen = new System.Windows.Forms.Button();
            this.btnraiz = new System.Windows.Forms.Button();
            this.btnsegundos = new System.Windows.Forms.Button();
            this.btndescuento = new System.Windows.Forms.Button();
            this.btnedad = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmasa
            // 
            this.btnmasa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmasa.Location = new System.Drawing.Point(11, 77);
            this.btnmasa.Name = "btnmasa";
            this.btnmasa.Size = new System.Drawing.Size(135, 48);
            this.btnmasa.TabIndex = 0;
            this.btnmasa.Text = "Masa Corporal.";
            this.btnmasa.UseVisualStyleBackColor = true;
            this.btnmasa.Click += new System.EventHandler(this.Btnmasa_Click);
            // 
            // btnllamadas
            // 
            this.btnllamadas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnllamadas.Location = new System.Drawing.Point(161, 77);
            this.btnllamadas.Name = "btnllamadas";
            this.btnllamadas.Size = new System.Drawing.Size(135, 48);
            this.btnllamadas.TabIndex = 1;
            this.btnllamadas.Text = "Llamadas al \r\nExterior";
            this.btnllamadas.UseVisualStyleBackColor = true;
            this.btnllamadas.Click += new System.EventHandler(this.Btnllamadas_Click);
            // 
            // btnnotas
            // 
            this.btnnotas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnotas.Location = new System.Drawing.Point(312, 77);
            this.btnnotas.Name = "btnnotas";
            this.btnnotas.Size = new System.Drawing.Size(135, 48);
            this.btnnotas.TabIndex = 2;
            this.btnnotas.Text = "Promedio de notas";
            this.btnnotas.UseVisualStyleBackColor = true;
            this.btnnotas.Click += new System.EventHandler(this.Btnnotas_Click);
            // 
            // btnvolumen
            // 
            this.btnvolumen.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolumen.Location = new System.Drawing.Point(462, 77);
            this.btnvolumen.Name = "btnvolumen";
            this.btnvolumen.Size = new System.Drawing.Size(135, 48);
            this.btnvolumen.TabIndex = 3;
            this.btnvolumen.Text = "Volumen";
            this.btnvolumen.UseVisualStyleBackColor = true;
            this.btnvolumen.Click += new System.EventHandler(this.Btnvolumen_Click);
            // 
            // btnraiz
            // 
            this.btnraiz.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnraiz.Location = new System.Drawing.Point(613, 77);
            this.btnraiz.Name = "btnraiz";
            this.btnraiz.Size = new System.Drawing.Size(135, 48);
            this.btnraiz.TabIndex = 4;
            this.btnraiz.Text = "Raiz cuadrada";
            this.btnraiz.UseVisualStyleBackColor = true;
            this.btnraiz.Click += new System.EventHandler(this.Btnraiz_Click);
            // 
            // btnsegundos
            // 
            this.btnsegundos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsegundos.Location = new System.Drawing.Point(135, 162);
            this.btnsegundos.Name = "btnsegundos";
            this.btnsegundos.Size = new System.Drawing.Size(135, 48);
            this.btnsegundos.TabIndex = 5;
            this.btnsegundos.Text = "Edad en segundos";
            this.btnsegundos.UseVisualStyleBackColor = true;
            this.btnsegundos.Click += new System.EventHandler(this.Btnsegundos_Click);
            // 
            // btndescuento
            // 
            this.btndescuento.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndescuento.Location = new System.Drawing.Point(312, 162);
            this.btndescuento.Name = "btndescuento";
            this.btndescuento.Size = new System.Drawing.Size(135, 48);
            this.btndescuento.TabIndex = 6;
            this.btndescuento.Text = "Descuento-IVA";
            this.btndescuento.UseVisualStyleBackColor = true;
            this.btndescuento.Click += new System.EventHandler(this.Btndescuento_Click);
            // 
            // btnedad
            // 
            this.btnedad.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedad.Location = new System.Drawing.Point(489, 162);
            this.btnedad.Name = "btnedad";
            this.btnedad.Size = new System.Drawing.Size(135, 48);
            this.btnedad.TabIndex = 9;
            this.btnedad.Text = "Edad";
            this.btnedad.UseVisualStyleBackColor = true;
            this.btnedad.Click += new System.EventHandler(this.Btnedad_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(312, 254);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(135, 36);
            this.btncerrar.TabIndex = 10;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 315);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnedad);
            this.Controls.Add(this.btndescuento);
            this.Controls.Add(this.btnsegundos);
            this.Controls.Add(this.btnraiz);
            this.Controls.Add(this.btnvolumen);
            this.Controls.Add(this.btnnotas);
            this.Controls.Add(this.btnllamadas);
            this.Controls.Add(this.btnmasa);
            this.Name = "Form1";
            this.Text = "<";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmasa;
        private System.Windows.Forms.Button btnllamadas;
        private System.Windows.Forms.Button btnnotas;
        private System.Windows.Forms.Button btnvolumen;
        private System.Windows.Forms.Button btnraiz;
        private System.Windows.Forms.Button btnsegundos;
        private System.Windows.Forms.Button btndescuento;
        private System.Windows.Forms.Button btnedad;
        private System.Windows.Forms.Button btncerrar;
    }
}

