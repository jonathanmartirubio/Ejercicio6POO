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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        tListaAlumnos Alumnos = new tListaAlumnos();
        tListadeCursos Cursos = new tListadeCursos();
        tListaProfesores Profesores = new tListaProfesores();

        private void bGestionCursos_Click(object sender, EventArgs e)
        {
            fCurso fCur = new fCurso();

            fCur.Cursos = Cursos;
            fCur.ShowDialog();
        }

        private void bGestionAlumnos_Click(object sender, EventArgs e)
        {
            fAlumno fAlu = new fAlumno();

            fAlu.Alumnos = Alumnos;
            fAlu.ShowDialog();
        }

        private void bGestionProfesores_Click(object sender, EventArgs e)
        {
            fProfesor fProf = new fProfesor();

            fProf.Profesores = Profesores;
            fProf.ShowDialog();
        }
    }
}
