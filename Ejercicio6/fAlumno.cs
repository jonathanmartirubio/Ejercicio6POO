using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio6
{
    public partial class fAlumno : Form
    {
        public fAlumno()
        {
            InitializeComponent();
        }

        public tListaAlumnos Alumnos;

        private void bAnyadirAlumno_Click(object sender, EventArgs e)
        {
            string nombre, dni, telf;
            int codigo;

            nombre = Interaction.InputBox("Introduce el nombre:", "Añadir Alumno");
            dni = Interaction.InputBox("Introduce el DNI:", "Añadir Alumno");
            telf = Interaction.InputBox("Introduce el teléfono:", "Añadir Alumno");
            codigo = int.Parse(Interaction.InputBox("Introduce el código del curso:", "Añadir Alumno"));

            Alumnos.AnyadirAlumno(nombre, dni, telf, codigo);
        }

        private void bEliminarAlumno_Click(object sender, EventArgs e)
        {
            string nombre;
            bool correcto;

            nombre = Interaction.InputBox("Introduzca el nombre", "Eliminar Alumno");
            correcto = Alumnos.EliminarAlumno(nombre);

            if (correcto)
            {
                MessageBox.Show("Alumno eliminado correctamente");
            }
            else
            {
                MessageBox.Show("No se ha encontrado el alumno.");
            }
        }

        private void bMostrarAlumnos_Click(object sender, EventArgs e)
        {
            string texto;

            texto = Alumnos.MostrarAlumnos();

            MessageBox.Show(texto);
        }

        private void bOrdenAlfabetico_Click(object sender, EventArgs e)
        {
            Alumnos.OrdenAlfabetico();
        }

        private void bMostrarAlumno_Click(object sender, EventArgs e)
        {
            string texto, nombre;
            bool correcto;
            correcto = false;
            nombre = Interaction.InputBox("Nombre del Alumno:", "Mostrar datos del alumno");
            texto = Alumnos.MostrarAlumno(nombre, ref correcto);

            if (correcto)
            {
                MessageBox.Show(texto);
            }
            else
            {
                texto = "No se ha encontrado el Alumno.";
                MessageBox.Show(texto);
            }
        }

        private void bMostrarPorCurso_Click(object sender, EventArgs e)
        {

        }

        private void bAnyadirNota_Click(object sender, EventArgs e)
        {
            string nombre;
            double nota;
            bool correcto;

            nombre = Interaction.InputBox("Introduzca el nombre.");
            nota = double.Parse(Interaction.InputBox("Introduzca la Nota."));

            correcto = Alumnos.AnyadirNota(nombre, nota);
            if (correcto)
                MessageBox.Show("Se ha añadido correctamente la nota.");
            else
                MessageBox.Show("No se ha encontrado el Alumno.");
        }

        private void bEliminarNotas_Click(object sender, EventArgs e)
        {
            string nombre;
            bool correcto;

            nombre = Interaction.InputBox("Introduce el nombre", "Eliminar Notas");
            correcto = Alumnos.EliminarNotas(nombre);

            if (correcto)
            {
                MessageBox.Show("Notas eliminadas correctamente.");
            }
            else
            {
                MessageBox.Show("No se ha encontrado el Alumno.");
            }
        }

        private void bAlumnosMediaAprobado_Click(object sender, EventArgs e)
        {
            string texto;

            texto = Alumnos.MostrarAlumnosMediaAprobado();

            MessageBox.Show(texto);
        }

        private void bMostrarAlumnosSuspensos_Click(object sender, EventArgs e)
        {
            string texto;

            texto = Alumnos.MostrarAlumnosMediaSuspenso();

            MessageBox.Show(texto);
        }
    }
}
