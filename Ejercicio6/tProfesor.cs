using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class tProfesor
    {
        private string mNombre;
        private string mDni;
        private string mTelf;
        private List<string> mAsignaturas;
        private bool mTutor;
        private string mCodigoAsignatura;

        public string Nombre
        {
            set { mNombre = value; }
            get { return mNombre; }
        }

        public string Dni
        {
            set { mDni = value; }
            get { return mDni; }
        }

        public string Telf
        {
            set { mTelf = value; }
            get { return mTelf; }
        }

        public bool Tutor
        {
            set { mTutor = value; }
            get { return mTutor; }
        }

        public string CodigoAsignatura
        {
            set { mCodigoAsignatura = value; }
            get { return mCodigoAsignatura; }
        }

        public void AnyadirAsignatura(string asignatura)
        {
            mAsignaturas.Add(asignatura);
        }

        private string MostrarAsignaturas()
        {
            string texto;

            if (mAsignaturas.Count > 0)
            {
                texto = "";
                for (int i = 0; i < mAsignaturas.Count; i++)
                {
                    texto += mAsignaturas[i] + ", ";
                }
            }
            else
            {
                texto = "Profesor sin asignaturas.\n";
            }
            return texto;
        }

        public void EliminarAsignaturas()
        {
            mAsignaturas.Clear();
        }

        public string MostrarDatos()
        {
            string texto;

            texto = "Datos del Profesor:\n";
            texto += "Nombre: " + mNombre + "\n";
            texto += "Dni: " + mDni + "\n";
            texto += "Asignaturas: " + MostrarAsignaturas() + "\n";
            if (mTutor)
            {
                texto += "Tutor de: " + mCodigoAsignatura + "\n";
            }
            else
            {
                texto += "No es tutor de ninguna asignatura.";
            }

            return texto;
        }
    }
}
