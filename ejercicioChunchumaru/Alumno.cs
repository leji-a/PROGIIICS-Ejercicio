using ejercicioChunchumaru;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioChunchumaru
{
    internal class Alumno : Persona
    {
        private int curso;
        private int nivelAcademico;

        public int Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        public int NivelAcademico
        {
            get { return nivelAcademico; }
            set { nivelAcademico = value; }
        }

        public Alumno(string pDomicilio, int pEdad, string pMail, string pNombre, string pTelefono, int pCurso, int pNivelAcademico) : base(pDomicilio, pEdad, pMail, pNombre, pTelefono)
        {
            Curso = pCurso;
            NivelAcademico = pNivelAcademico;
        }

        public void SetCurso(int pCurso)
        {
            Curso = pCurso;
        }
        public override string ToString()
        {
            return base.ToString() + "\nCurso: " + Curso + "\nNivel academico: " + NivelAcademico;
        }
    }
}