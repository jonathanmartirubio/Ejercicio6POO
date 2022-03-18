
namespace Ejercicio6
{
    partial class fAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bAnyadirAlumno = new System.Windows.Forms.Button();
            this.bEliminarAlumno = new System.Windows.Forms.Button();
            this.bMostrarAlumnos = new System.Windows.Forms.Button();
            this.bOrdenAlfabetico = new System.Windows.Forms.Button();
            this.bMostrarAlumno = new System.Windows.Forms.Button();
            this.bMostrarPorCurso = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bAnyadirNota = new System.Windows.Forms.Button();
            this.bAlumnosMediaAprobado = new System.Windows.Forms.Button();
            this.bEliminarNotas = new System.Windows.Forms.Button();
            this.bMostrarAlumnosSuspensos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAnyadirAlumno
            // 
            this.bAnyadirAlumno.Location = new System.Drawing.Point(59, 41);
            this.bAnyadirAlumno.Name = "bAnyadirAlumno";
            this.bAnyadirAlumno.Size = new System.Drawing.Size(185, 44);
            this.bAnyadirAlumno.TabIndex = 0;
            this.bAnyadirAlumno.Text = "Añadir Alumno";
            this.bAnyadirAlumno.UseVisualStyleBackColor = true;
            this.bAnyadirAlumno.Click += new System.EventHandler(this.bAnyadirAlumno_Click);
            // 
            // bEliminarAlumno
            // 
            this.bEliminarAlumno.Location = new System.Drawing.Point(261, 41);
            this.bEliminarAlumno.Name = "bEliminarAlumno";
            this.bEliminarAlumno.Size = new System.Drawing.Size(185, 44);
            this.bEliminarAlumno.TabIndex = 1;
            this.bEliminarAlumno.Text = "Eliminar Alumno";
            this.bEliminarAlumno.UseVisualStyleBackColor = true;
            this.bEliminarAlumno.Click += new System.EventHandler(this.bEliminarAlumno_Click);
            // 
            // bMostrarAlumnos
            // 
            this.bMostrarAlumnos.Location = new System.Drawing.Point(463, 41);
            this.bMostrarAlumnos.Name = "bMostrarAlumnos";
            this.bMostrarAlumnos.Size = new System.Drawing.Size(185, 44);
            this.bMostrarAlumnos.TabIndex = 2;
            this.bMostrarAlumnos.Text = "Mostrar Alumnos";
            this.bMostrarAlumnos.UseVisualStyleBackColor = true;
            this.bMostrarAlumnos.Click += new System.EventHandler(this.bMostrarAlumnos_Click);
            // 
            // bOrdenAlfabetico
            // 
            this.bOrdenAlfabetico.Location = new System.Drawing.Point(59, 117);
            this.bOrdenAlfabetico.Name = "bOrdenAlfabetico";
            this.bOrdenAlfabetico.Size = new System.Drawing.Size(185, 44);
            this.bOrdenAlfabetico.TabIndex = 3;
            this.bOrdenAlfabetico.Text = "Ordenar Alumnos por orden alfabético";
            this.bOrdenAlfabetico.UseVisualStyleBackColor = true;
            this.bOrdenAlfabetico.Click += new System.EventHandler(this.bOrdenAlfabetico_Click);
            // 
            // bMostrarAlumno
            // 
            this.bMostrarAlumno.Location = new System.Drawing.Point(261, 117);
            this.bMostrarAlumno.Name = "bMostrarAlumno";
            this.bMostrarAlumno.Size = new System.Drawing.Size(185, 44);
            this.bMostrarAlumno.TabIndex = 4;
            this.bMostrarAlumno.Text = "Mostrar Alumno (por nombre)";
            this.bMostrarAlumno.UseVisualStyleBackColor = true;
            this.bMostrarAlumno.Click += new System.EventHandler(this.bMostrarAlumno_Click);
            // 
            // bMostrarPorCurso
            // 
            this.bMostrarPorCurso.Location = new System.Drawing.Point(463, 117);
            this.bMostrarPorCurso.Name = "bMostrarPorCurso";
            this.bMostrarPorCurso.Size = new System.Drawing.Size(185, 44);
            this.bMostrarPorCurso.TabIndex = 5;
            this.bMostrarPorCurso.Text = "Mostrar Alumnos de un Curso";
            this.bMostrarPorCurso.UseVisualStyleBackColor = true;
            this.bMostrarPorCurso.Click += new System.EventHandler(this.bMostrarPorCurso_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bMostrarPorCurso);
            this.groupBox1.Controls.Add(this.bOrdenAlfabetico);
            this.groupBox1.Controls.Add(this.bAnyadirAlumno);
            this.groupBox1.Controls.Add(this.bMostrarAlumno);
            this.groupBox1.Controls.Add(this.bEliminarAlumno);
            this.groupBox1.Controls.Add(this.bMostrarAlumnos);
            this.groupBox1.Location = new System.Drawing.Point(46, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 196);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumnos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bMostrarAlumnosSuspensos);
            this.groupBox2.Controls.Add(this.bEliminarNotas);
            this.groupBox2.Controls.Add(this.bAlumnosMediaAprobado);
            this.groupBox2.Controls.Add(this.bAnyadirNota);
            this.groupBox2.Location = new System.Drawing.Point(46, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 191);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notas";
            // 
            // bAnyadirNota
            // 
            this.bAnyadirNota.Location = new System.Drawing.Point(59, 39);
            this.bAnyadirNota.Name = "bAnyadirNota";
            this.bAnyadirNota.Size = new System.Drawing.Size(263, 49);
            this.bAnyadirNota.TabIndex = 0;
            this.bAnyadirNota.Text = "Añadir Notas a Alumno";
            this.bAnyadirNota.UseVisualStyleBackColor = true;
            this.bAnyadirNota.Click += new System.EventHandler(this.bAnyadirNota_Click);
            // 
            // bAlumnosMediaAprobado
            // 
            this.bAlumnosMediaAprobado.Location = new System.Drawing.Point(385, 39);
            this.bAlumnosMediaAprobado.Name = "bAlumnosMediaAprobado";
            this.bAlumnosMediaAprobado.Size = new System.Drawing.Size(263, 49);
            this.bAlumnosMediaAprobado.TabIndex = 1;
            this.bAlumnosMediaAprobado.Text = "Mostrar Alumnos con nota media mayor o igual a 5";
            this.bAlumnosMediaAprobado.UseVisualStyleBackColor = true;
            this.bAlumnosMediaAprobado.Click += new System.EventHandler(this.bAlumnosMediaAprobado_Click);
            // 
            // bEliminarNotas
            // 
            this.bEliminarNotas.Location = new System.Drawing.Point(59, 115);
            this.bEliminarNotas.Name = "bEliminarNotas";
            this.bEliminarNotas.Size = new System.Drawing.Size(263, 49);
            this.bEliminarNotas.TabIndex = 2;
            this.bEliminarNotas.Text = "Eliminar Notas a Alumno";
            this.bEliminarNotas.UseVisualStyleBackColor = true;
            this.bEliminarNotas.Click += new System.EventHandler(this.bEliminarNotas_Click);
            // 
            // bMostrarAlumnosSuspensos
            // 
            this.bMostrarAlumnosSuspensos.Location = new System.Drawing.Point(385, 115);
            this.bMostrarAlumnosSuspensos.Name = "bMostrarAlumnosSuspensos";
            this.bMostrarAlumnosSuspensos.Size = new System.Drawing.Size(263, 49);
            this.bMostrarAlumnosSuspensos.TabIndex = 3;
            this.bMostrarAlumnosSuspensos.Text = "Mostrar Alumnos con nota media menor a 5";
            this.bMostrarAlumnosSuspensos.UseVisualStyleBackColor = true;
            this.bMostrarAlumnosSuspensos.Click += new System.EventHandler(this.bMostrarAlumnosSuspensos_Click);
            // 
            // fAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fAlumno";
            this.Text = "Ejercicio 6 - Gestión Alumnos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAnyadirAlumno;
        private System.Windows.Forms.Button bEliminarAlumno;
        private System.Windows.Forms.Button bMostrarAlumnos;
        private System.Windows.Forms.Button bOrdenAlfabetico;
        private System.Windows.Forms.Button bMostrarAlumno;
        private System.Windows.Forms.Button bMostrarPorCurso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bMostrarAlumnosSuspensos;
        private System.Windows.Forms.Button bEliminarNotas;
        private System.Windows.Forms.Button bAlumnosMediaAprobado;
        private System.Windows.Forms.Button bAnyadirNota;
    }
}