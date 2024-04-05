using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioChunchumaru
{
    internal class Cliente : Persona
    {
        private decimal saldo;

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public Cliente(string pDomicilio, int pEdad, string pMail, string pNombre, string pTelefono, decimal pSaldo) : base(pDomicilio, pEdad, pMail, pNombre, pTelefono)
        {
            Saldo = pSaldo;
        }

        public override string ToString()
        {
            return base.ToString() + "\nSaldo: " + Saldo;
        }
    }
}