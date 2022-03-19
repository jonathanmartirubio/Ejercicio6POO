using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    public class tListadeCursos
    {
        private List<tCurso> mLista;

        public tListadeCursos()
        {
            mLista = new List<tCurso>();
        }

        public void AnyadirCurso(string nombre, string codigo)
        {
            tCurso curso;

            curso = new tCurso();

            curso.Codigo = codigo;
            curso.Nombre = nombre;

            mLista.Add(curso);
        }

        public bool EliminarCurso(string codigo)
        {
            int pos;
            bool encontrado = false;

            pos = BuscarCurso(codigo);

            if (pos >= 0)
            {
                mLista.RemoveAt(pos);
                encontrado = true;
            }

            return encontrado;
        }

        public string MostrarCursos()
        {
            string texto;

            texto = "Listado de Cursos: \n";

            foreach (tCurso curso in mLista)
            {
                texto += curso.MostrarDatos();
            }

            return texto;
        }

        private int BuscarCurso(string codigo)
        {
            int pos = -1, i;
            bool encontrado = false;
            tCurso curso;

            i = 0;
            while (i < mLista.Count && !encontrado)
            {
                curso = mLista[i];
                if (curso.Codigo == codigo)
                {
                    pos = i;
                    encontrado = true;
                }
                else
                    i++;
            }

            return pos;
        }
    }
}
