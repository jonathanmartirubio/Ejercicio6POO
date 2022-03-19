using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class tCurso
    {
        private string mCodigo;
        private string mNombre;

        public tCurso()
        {
            mNombre = "";
            mCodigo = "";
        }

        public string Codigo
        {
            get { return mCodigo; }
            set { mCodigo = value; }
        }

        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }

        public string MostrarDatos()
        {
            string texto;

            texto = "Datos del curso:\n";
            texto += "Nombre: " + mNombre + "\n";
            texto += "Código: " + mCodigo + "\n";

            return texto;
        }
    }
}
