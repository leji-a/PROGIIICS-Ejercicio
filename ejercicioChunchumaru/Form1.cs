using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioChunchumaru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona persona1 = new Persona("Que", 21, "no@thankyou.com", "So", "123123123");
            MessageBox.Show(persona1.ToString());
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumno1 = new Alumno("QueSo", 22, "no@basta.com", "que", "123123123", 2, 4);
            MessageBox.Show(alumno1.ToString());
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado1 = new Empleado("QueSo", 22, "no@basta.com", "que", "12312313333", 2020, "Limpieza", 2E5m);
            MessageBox.Show(empleado1.ToString());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente1 = new Cliente("QueSo", 22, "no@basta.com", "que", "12312313333", 2);
            MessageBox.Show(cliente1.ToString());
        }

        private void btnViajante_Click(object sender, EventArgs e)
        {
            Viajante viajante1 = new Viajante("QueSo", 22, "no@basta.com", "que", "12312313333", 2020, "Limpieza", 2E5m, "Cabezona");
            MessageBox.Show(viajante1.ToString());
        }

        private void btnMayorista_Click(object sender, EventArgs e)
        {
            Mayorista mayorista1 = new Mayorista("QueSo", 22, "no@basta.com", "que", "12312313333", 420, "20-1231231232-2");
            MessageBox.Show(mayorista1.ToString());
        }

        private void btnMinorista_Click(object sender, EventArgs e)
        {
            Minorista minorista1 = new Minorista("QueSo", 22, "no@basta.com", "que", "12312313333", 32, 32876123);
            MessageBox.Show(minorista1.ToString());
        }

        private void btnAdministrativo_Click(object sender, EventArgs e)
        {
            Tiempo horaIngresada = new Tiempo(20);
            Administrativo administrativo1 = new Administrativo("QueSo", 22, "no@basta.com", "que", "12312313333", 2020, "Si", 2E5m, horaIngresada);
            MessageBox.Show(administrativo1.ToString());
        }
    }
}
