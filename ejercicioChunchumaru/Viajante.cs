using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioChunchumaru
{
    internal class Viajante : Empleado
    {
        private string zona;

        public string Zona
        {
            get { return zona; } set { zona = value; }
        }

        public Viajante(string pDomicilio, int pEdad, string pMail, string pNombre, string pTelefono, int pAñoIngreso, string pSector, decimal pSueldo, string pZona) : base(pDomicilio, pEdad, pMail, pNombre, pTelefono, pAñoIngreso, pSector, pSueldo)
        {
            Zona = pZona;
        }
        public override string ToString()
        {
            return base.ToString() + "\nZona: " + Zona;
        }
    }
}
