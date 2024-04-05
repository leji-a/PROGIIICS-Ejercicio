using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioChunchumaru
{
    internal class Administrativo : Empleado
    {
        private Tiempo horaIngreso;

        public Tiempo HoraIngreso
        {
            get { return horaIngreso; } set { horaIngreso = value; }
        }
        public Administrativo(string pDomicilio, int pEdad, string pMail, string pNombre, string pTelefono, int pAñoIngreso, string pSector, decimal pSueldo, Tiempo pHoraIngreso) : base(pDomicilio, pEdad, pMail, pNombre, pTelefono, pAñoIngreso, pSector, pSueldo)
        {
            HoraIngreso = pHoraIngreso;
        }
        public override string ToString()
        {
            return base.ToString() + "\nHora de ingreso: " + HoraIngreso;
        }


    }
}
