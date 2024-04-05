using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioChunchumaru
{
    internal class Persona
    {
        private string domicilio;
        private int edad;
        private string mail;
        private string nombre;
        private string telefono;

        public string Domicilio
        {
            get { return domicilio; } set { domicilio = value; }
        }
        public int Edad
        {
            get { return edad; } set { edad = value; }
        }
        public string Mail
        {
            get { return mail; } set { mail = value; }
        }
        public string Nombre
        {
            get { return nombre; } set { nombre = value; }
        }
        public string Telefono
        {
            get { return telefono; } set { telefono = value; }
        }
        public Persona(string pDomicilio, int pEdad, string pMail, string pNombre, string pTelefono)
        {
            Domicilio = pDomicilio;
            Edad = pEdad;
            Mail = pMail;
            Nombre = pNombre;
            Telefono = pTelefono;
        }

        public override string ToString()
        {
            return "Domicilio: " + Domicilio 
                + "\nEdad: " + Edad + 
                "\nMail: " + Mail + 
                "\nNombre: " + Nombre + 
                "\nTelefono: " + Telefono;
        }
    }
}
