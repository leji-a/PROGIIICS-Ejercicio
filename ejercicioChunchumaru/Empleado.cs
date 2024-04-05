using ejercicioChunchumaru;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioChunchumaru
{
    internal class Empleado : Persona
    {
        private int añoIngreso;
        private string sector;
        private decimal sueldo;

        public int AñoIngreso
        {
            get { return añoIngreso; }
            set { añoIngreso = value; }
        }
        public string Sector
        {
            get { return sector; }
            set { sector = value; }
        }
        public decimal Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        public Empleado(string pDomicilio, int pEdad, string pMail, string pNombre, string pTelefono, int pAñoIngreso, string pSector, decimal pSueldo) : base(pDomicilio, pEdad, pMail, pNombre, pTelefono)
        {
            AñoIngreso = pAñoIngreso;
            Sector = pSector;
            Sueldo = pSueldo;
        }
        public int Antiguedad()
        {
            return DateTime.Now.Year - AñoIngreso;
        }
        public override string ToString()
        {
            return base.ToString() + "\nAño de ingreso: " + AñoIngreso + "\nSector: " + Sector + "\nSueldo: " + Sueldo + "\nAntiguedad: " + Antiguedad();
        }
    }
}