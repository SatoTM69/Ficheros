namespace Ficheros
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
            this.btnCrearFichero = new System.Windows.Forms.Button();
            this.btnForma2Crear = new System.Windows.Forms.Button();
            this.btnLeerArchivos2 = new System.Windows.Forms.Button();
            this.btnLeerArchivo = new System.Windows.Forms.Button();
            this.btnLeerArchivos3 = new System.Windows.Forms.Button();
            this.btnLeerArchivos4 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearFichero
            // 
            this.btnCrearFichero.Location = new System.Drawing.Point(13, 13);
            this.btnCrearFichero.Name = "btnCrearFichero";
            this.btnCrearFichero.Size = new System.Drawing.Size(134, 71);
            this.btnCrearFichero.TabIndex = 0;
            this.btnCrearFichero.Text = "Crear Fichero";
            this.btnCrearFichero.UseVisualStyleBackColor = true;
            this.btnCrearFichero.Click += new System.EventHandler(this.btnCrearFichero_Click);
            // 
            // btnForma2Crear
            // 
            this.btnForma2Crear.Location = new System.Drawing.Point(153, 13);
            this.btnForma2Crear.Name = "btnForma2Crear";
            this.btnForma2Crear.Size = new System.Drawing.Size(134, 71);
            this.btnForma2Crear.TabIndex = 1;
            this.btnForma2Crear.Text = "Forma 2 de Crear";
            this.btnForma2Crear.UseVisualStyleBackColor = true;
            this.btnForma2Crear.Click += new System.EventHandler(this.btnForma2Crear_Click);
            // 
            // btnLeerArchivos2
            // 
            this.btnLeerArchivos2.Location = new System.Drawing.Point(433, 13);
            this.btnLeerArchivos2.Name = "btnLeerArchivos2";
            this.btnLeerArchivos2.Size = new System.Drawing.Size(134, 71);
            this.btnLeerArchivos2.TabIndex = 2;
            this.btnLeerArchivos2.Text = "Leer Archivos";
            this.btnLeerArchivos2.UseVisualStyleBackColor = true;
            this.btnLeerArchivos2.Click += new System.EventHandler(this.btnLeerArchivos2_Click);
            // 
            // btnLeerArchivo
            // 
            this.btnLeerArchivo.Location = new System.Drawing.Point(293, 13);
            this.btnLeerArchivo.Name = "btnLeerArchivo";
            this.btnLeerArchivo.Size = new System.Drawing.Size(134, 71);
            this.btnLeerArchivo.TabIndex = 3;
            this.btnLeerArchivo.Text = "Leer Archivos";
            this.btnLeerArchivo.UseVisualStyleBackColor = true;
            this.btnLeerArchivo.Click += new System.EventHandler(this.btnLeerArchivo_Click);
            // 
            // btnLeerArchivos3
            // 
            this.btnLeerArchivos3.Location = new System.Drawing.Point(573, 13);
            this.btnLeerArchivos3.Name = "btnLeerArchivos3";
            this.btnLeerArchivos3.Size = new System.Drawing.Size(134, 71);
            this.btnLeerArchivos3.TabIndex = 4;
            this.btnLeerArchivos3.Text = "Leer Archivos";
            this.btnLeerArchivos3.UseVisualStyleBackColor = true;
            this.btnLeerArchivos3.Click += new System.EventHandler(this.btnLeerArchivos3_Click);
            // 
            // btnLeerArchivos4
            // 
            this.btnLeerArchivos4.Location = new System.Drawing.Point(13, 90);
            this.btnLeerArchivos4.Name = "btnLeerArchivos4";
            this.btnLeerArchivos4.Size = new System.Drawing.Size(134, 71);
            this.btnLeerArchivos4.TabIndex = 5;
            this.btnLeerArchivos4.Text = "Leer Archivos";
            this.btnLeerArchivos4.UseVisualStyleBackColor = true;
            this.btnLeerArchivos4.Click += new System.EventHandler(this.btnLeerArchivos4_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(153, 90);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(134, 71);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnLeerArchivos4);
            this.Controls.Add(this.btnLeerArchivos3);
            this.Controls.Add(this.btnLeerArchivo);
            this.Controls.Add(this.btnLeerArchivos2);
            this.Controls.Add(this.btnForma2Crear);
            this.Controls.Add(this.btnCrearFichero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearFichero;
        private System.Windows.Forms.Button btnForma2Crear;
        private System.Windows.Forms.Button btnLeerArchivos2;
        private System.Windows.Forms.Button btnLeerArchivo;
        private System.Windows.Forms.Button btnLeerArchivos3;
        private System.Windows.Forms.Button btnLeerArchivos4;
        private System.Windows.Forms.Button btnModificar;
    }
}

