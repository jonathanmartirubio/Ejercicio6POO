﻿
namespace Ejercicio6
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bGestionCursos = new System.Windows.Forms.Button();
            this.bGestionAlumnos = new System.Windows.Forms.Button();
            this.bGestionProfesores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bGestionCursos
            // 
            this.bGestionCursos.Location = new System.Drawing.Point(103, 65);
            this.bGestionCursos.Name = "bGestionCursos";
            this.bGestionCursos.Size = new System.Drawing.Size(229, 65);
            this.bGestionCursos.TabIndex = 0;
            this.bGestionCursos.Text = "Gestión Cursos";
            this.bGestionCursos.UseVisualStyleBackColor = true;
            this.bGestionCursos.Click += new System.EventHandler(this.bGestionCursos_Click);
            // 
            // bGestionAlumnos
            // 
            this.bGestionAlumnos.Location = new System.Drawing.Point(103, 182);
            this.bGestionAlumnos.Name = "bGestionAlumnos";
            this.bGestionAlumnos.Size = new System.Drawing.Size(229, 65);
            this.bGestionAlumnos.TabIndex = 1;
            this.bGestionAlumnos.Text = "Gestión Alumnos";
            this.bGestionAlumnos.UseVisualStyleBackColor = true;
            this.bGestionAlumnos.Click += new System.EventHandler(this.bGestionAlumnos_Click);
            // 
            // bGestionProfesores
            // 
            this.bGestionProfesores.Location = new System.Drawing.Point(103, 300);
            this.bGestionProfesores.Name = "bGestionProfesores";
            this.bGestionProfesores.Size = new System.Drawing.Size(229, 65);
            this.bGestionProfesores.TabIndex = 2;
            this.bGestionProfesores.Text = "Gestión Profesores";
            this.bGestionProfesores.UseVisualStyleBackColor = true;
            this.bGestionProfesores.Click += new System.EventHandler(this.bGestionProfesores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 445);
            this.Controls.Add(this.bGestionProfesores);
            this.Controls.Add(this.bGestionAlumnos);
            this.Controls.Add(this.bGestionCursos);
            this.Name = "Form1";
            this.Text = "Ejercicio 6 - Gestión de instituto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bGestionCursos;
        private System.Windows.Forms.Button bGestionAlumnos;
        private System.Windows.Forms.Button bGestionProfesores;
    }
}

