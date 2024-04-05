using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioChunchumaru
{
    internal class Minorista : Cliente
    {
        private int documento;

        public int Documento
        {
            get { return documento; } set { documento = value; }
        }
        public Minorista(string pDomicilio, int pEdad, string pMail, string pNombre, string pTelefono, decimal pSaldo, int pDocumento) : base(pDomicilio, pEdad, pMail, pNombre, pTelefono, pSaldo)
        {
            Documento = pDocumento;
        }
        public override string ToString()
        {
            return base.ToString() + "\nDocumento : " + Documento;
        }
    }
}
