namespace ejercicioChunchumaru
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
            this.btnPersona = new System.Windows.Forms.Button();
            this.btnAlumno = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnViajante = new System.Windows.Forms.Button();
            this.btnMayorista = new System.Windows.Forms.Button();
            this.btnMinorista = new System.Windows.Forms.Button();
            this.btnAdministrativo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersona
            // 
            this.btnPersona.Location = new System.Drawing.Point(205, 22);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(384, 23);
            this.btnPersona.TabIndex = 0;
            this.btnPersona.Text = "Persona";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // btnAlumno
            // 
            this.btnAlumno.Location = new System.Drawing.Point(205, 51);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(384, 23);
            this.btnAlumno.TabIndex = 1;
            this.btnAlumno.Text = "Alumno";
            this.btnAlumno.UseVisualStyleBackColor = true;
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Location = new System.Drawing.Point(205, 80);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(384, 23);
            this.btnEmpleado.TabIndex = 2;
            this.btnEmpleado.Text = "Empleado";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(205, 109);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(384, 23);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnViajante
            // 
            this.btnViajante.Location = new System.Drawing.Point(205, 138);
            this.btnViajante.Name = "btnViajante";
            this.btnViajante.Size = new System.Drawing.Size(384, 23);
            this.btnViajante.TabIndex = 4;
            this.btnViajante.Text = "Viajante";
            this.btnViajante.UseVisualStyleBackColor = true;
            this.btnViajante.Click += new System.EventHandler(this.btnViajante_Click);
            // 
            // btnMayorista
            // 
            this.btnMayorista.Location = new System.Drawing.Point(205, 196);
            this.btnMayorista.Name = "btnMayorista";
            this.btnMayorista.Size = new System.Drawing.Size(384, 23);
            this.btnMayorista.TabIndex = 5;
            this.btnMayorista.Text = "Mayorista";
            this.btnMayorista.UseVisualStyleBackColor = true;
            this.btnMayorista.Click += new System.EventHandler(this.btnMayorista_Click);
            // 
            // btnMinorista
            // 
            this.btnMinorista.Location = new System.Drawing.Point(205, 226);
            this.btnMinorista.Name = "btnMinorista";
            this.btnMinorista.Size = new System.Drawing.Size(384, 23);
            this.btnMinorista.TabIndex = 7;
            this.btnMinorista.Text = "Minorista";
            this.btnMinorista.UseVisualStyleBackColor = true;
            this.btnMinorista.Click += new System.EventHandler(this.btnMinorista_Click);
            // 
            // btnAdministrativo
            // 
            this.btnAdministrativo.Location = new System.Drawing.Point(205, 167);
            this.btnAdministrativo.Name = "btnAdministrativo";
            this.btnAdministrativo.Size = new System.Drawing.Size(384, 23);
            this.btnAdministrativo.TabIndex = 8;
            this.btnAdministrativo.Text = "Administrativo";
            this.btnAdministrativo.UseVisualStyleBackColor = true;
            this.btnAdministrativo.Click += new System.EventHandler(this.btnAdministrativo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdministrativo);
            this.Controls.Add(this.btnMinorista);
            this.Controls.Add(this.btnMayorista);
            this.Controls.Add(this.btnViajante);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.btnAlumno);
            this.Controls.Add(this.btnPersona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersona;
        private System.Windows.Forms.Button btnAlumno;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnViajante;
        private System.Windows.Forms.Button btnMayorista;
        private System.Windows.Forms.Button btnMinorista;
        private System.Windows.Forms.Button btnAdministrativo;
    }
}

