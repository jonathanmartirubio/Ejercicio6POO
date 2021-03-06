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
    public partial class fProfesor : Form
    {
        public fProfesor()
        {
            InitializeComponent();
        }

        public tListaProfesores Profesores;
        public tListadeCursos Cursos;

        private void bAnyadirProfesor_Click(object sender, EventArgs e)
        {
            string nombre, dni, telf;
            int curso;
            bool existecurso;
            DialogResult estutor;
            bool tutor;

            nombre = Interaction.InputBox("Introduce el nombre: ", "Añadir Profesor");
            dni = Interaction.InputBox("Introduce el dni:", "Añadir Profesor");
            telf = Interaction.InputBox("Introduce el teléfono: ", "Añadir Profesor");
            estutor = MessageBox.Show("¿Es tutor?", "Añadir Profesor", MessageBoxButtons.YesNo);
            if (estutor == DialogResult.Yes)
            {
                tutor = true;
            }
            else
            {
                tutor = false;
            }
            curso = int.Parse(Interaction.InputBox("Introduce el código del curso en el que es tutor:", "Añadir Profesor"));
            existecurso = Cursos.ExisteCurso(curso);
            if (!existecurso)
            {
                MessageBox.Show("El curso introducido no existe.");
            }
            else
            {
                Profesores.AnyadirProfesor(nombre, dni, telf, tutor, curso);
            }
        }

        private void bEliminarProfesor_Click(object sender, EventArgs e)
        {
            string nombre;
            bool correcto;

            nombre = Interaction.InputBox("Introduzca el nombre:", "Eliminar Profesor");
            correcto = Profesores.EliminarProfesor(nombre);

            if (correcto)
            {
                MessageBox.Show("Profesor eliminado correctamente");
            }
            else
            {
                MessageBox.Show("No se ha encontrado el Profesor.");
            }
        }

        private void bMostrarProfesores_Click(object sender, EventArgs e)
        {
            string texto;

            texto = Profesores.MostrarProfesores();

            MessageBox.Show(texto);
        }

        private void bMostrarDatosProfesor_Click(object sender, EventArgs e)
        {
            string nombre, texto;
            bool encontrado;

            encontrado = false;
            nombre = Interaction.InputBox("Introduce el nombre:", "Mostrar datos de un Profesor");

            texto = Profesores.MostrarProfesor(nombre, ref encontrado);

            if (encontrado)
            {
                MessageBox.Show(texto);
            }
            else
            {
                texto = "No se ha encontrado el Profesor.";
                MessageBox.Show(texto);
            }
        }

        private void bOrdenAlfabetico_Click(object sender, EventArgs e)
        {
            Profesores.OrdenAlfabetico();
        }

        private void bAnyadirAsignatura_Click(object sender, EventArgs e)
        {
            string nombre, asignatura;
            bool encontrado;

            nombre = Interaction.InputBox("Introduce el nombre:", "Añadir asignatura a un profesor");
            asignatura = Interaction.InputBox("Introduce la asignatura:", "Añadir asignatura a un profesor");

            encontrado = Profesores.AnyadirAsignatura(nombre, asignatura);
            if (encontrado)
                MessageBox.Show("Se ha añadido correctamente la Asignatura.");
            else
                MessageBox.Show("No se ha encontrado el Profesor.");

        }

        private void bEliminarAsignaturas_Click(object sender, EventArgs e)
        {
            string nombre;
            bool encontrado;

            nombre = Interaction.InputBox("Introduce el nombre", "Eliminar Notas");
            encontrado = Profesores.EliminarAsignaturas(nombre);

            if (encontrado)
            {
                MessageBox.Show("Asignaturas eliminadas correctamente.");
            }
            else
            {
                MessageBox.Show("No se ha encontrado el Profesor.");
            }
        }

        private void bMostrarPorAsignatura_Click(object sender, EventArgs e)
        {
            string texto;
            string asignatura;

            asignatura = Interaction.InputBox("Introduce la asignatura:", "Mostrar Profesores de una Asignatura");

            texto = Profesores.MostrarProfesoresPorAsignatura(asignatura);

            MessageBox.Show(texto);
        }
    }
}
