using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioChunchumaru
{
    internal class Mayorista : Cliente
    {
        private string cuit;

        public string Cuit
        {
            get { return cuit; } set { cuit = value; }
        }
        public Mayorista(string pDomicilio, int pEdad, string pMail, string pNombre, string pTelefono, decimal pSaldo, string pCuit) : base(pDomicilio, pEdad, pMail, pNombre, pTelefono, pSaldo)
        {
            Cuit = pCuit;
        }
        public override string ToString()
        {
            return base.ToString() + "\nCuit: " + Cuit;
        }
    }
}
