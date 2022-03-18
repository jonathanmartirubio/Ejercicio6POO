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

        private void bAnyadirProfesor_Click(object sender, EventArgs e)
        {
            string nombre, dni, telf;
            string asignatura;
            DialogResult estutor;
            bool tutor;

            asignatura = "";

            nombre = Interaction.InputBox("Introduce el nombre: ", "Añadir Profesor");
            dni = Interaction.InputBox("Introduce el dni:", "Añadir Profesor");
            telf = Interaction.InputBox("Introduce el teléfono: ", "Añadir Profesor");
            estutor = MessageBox.Show("¿Es tutor?", "Añadir Profesor", MessageBoxButtons.YesNo);
            if (estutor == DialogResult.Yes)
            {
                tutor = true;
                asignatura = Interaction.InputBox("Introduce el código de la Asignatura en la que es tutor:", "Añadir Profesor");
            }
            else
            {
                tutor = false;
            }
            

            Profesores.AnyadirProfesor(nombre, dni, telf, tutor, asignatura);
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
    }
}
