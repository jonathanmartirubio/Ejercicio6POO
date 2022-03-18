
namespace Ejercicio6
{
    partial class fProfesor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bMostrarDatosProfesor = new System.Windows.Forms.Button();
            this.bOrdenAlfabetico = new System.Windows.Forms.Button();
            this.bMostrarProfesores = new System.Windows.Forms.Button();
            this.bEliminarProfesor = new System.Windows.Forms.Button();
            this.bAnyadirProfesor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bMostrarDatosProfesor);
            this.groupBox1.Controls.Add(this.bOrdenAlfabetico);
            this.groupBox1.Controls.Add(this.bMostrarProfesores);
            this.groupBox1.Controls.Add(this.bEliminarProfesor);
            this.groupBox1.Controls.Add(this.bAnyadirProfesor);
            this.groupBox1.Location = new System.Drawing.Point(52, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profesores";
            // 
            // bMostrarDatosProfesor
            // 
            this.bMostrarDatosProfesor.Location = new System.Drawing.Point(350, 107);
            this.bMostrarDatosProfesor.Name = "bMostrarDatosProfesor";
            this.bMostrarDatosProfesor.Size = new System.Drawing.Size(184, 46);
            this.bMostrarDatosProfesor.TabIndex = 4;
            this.bMostrarDatosProfesor.Text = "Mostrar datos de un Profesor";
            this.bMostrarDatosProfesor.UseVisualStyleBackColor = true;
            this.bMostrarDatosProfesor.Click += new System.EventHandler(this.bMostrarDatosProfesor_Click);
            // 
            // bOrdenAlfabetico
            // 
            this.bOrdenAlfabetico.Location = new System.Drawing.Point(148, 107);
            this.bOrdenAlfabetico.Name = "bOrdenAlfabetico";
            this.bOrdenAlfabetico.Size = new System.Drawing.Size(184, 46);
            this.bOrdenAlfabetico.TabIndex = 3;
            this.bOrdenAlfabetico.Text = "Ordenar Profesores por orden alfabético";
            this.bOrdenAlfabetico.UseVisualStyleBackColor = true;
            this.bOrdenAlfabetico.Click += new System.EventHandler(this.bOrdenAlfabetico_Click);
            // 
            // bMostrarProfesores
            // 
            this.bMostrarProfesores.Location = new System.Drawing.Point(462, 35);
            this.bMostrarProfesores.Name = "bMostrarProfesores";
            this.bMostrarProfesores.Size = new System.Drawing.Size(184, 46);
            this.bMostrarProfesores.TabIndex = 2;
            this.bMostrarProfesores.Text = "Mostrar lista de Profesores";
            this.bMostrarProfesores.UseVisualStyleBackColor = true;
            this.bMostrarProfesores.Click += new System.EventHandler(this.bMostrarProfesores_Click);
            // 
            // bEliminarProfesor
            // 
            this.bEliminarProfesor.Location = new System.Drawing.Point(246, 35);
            this.bEliminarProfesor.Name = "bEliminarProfesor";
            this.bEliminarProfesor.Size = new System.Drawing.Size(184, 46);
            this.bEliminarProfesor.TabIndex = 1;
            this.bEliminarProfesor.Text = "Eliminar Profesor";
            this.bEliminarProfesor.UseVisualStyleBackColor = true;
            this.bEliminarProfesor.Click += new System.EventHandler(this.bEliminarProfesor_Click);
            // 
            // bAnyadirProfesor
            // 
            this.bAnyadirProfesor.Location = new System.Drawing.Point(40, 35);
            this.bAnyadirProfesor.Name = "bAnyadirProfesor";
            this.bAnyadirProfesor.Size = new System.Drawing.Size(184, 46);
            this.bAnyadirProfesor.TabIndex = 0;
            this.bAnyadirProfesor.Text = "Añadir Profesor";
            this.bAnyadirProfesor.UseVisualStyleBackColor = true;
            this.bAnyadirProfesor.Click += new System.EventHandler(this.bAnyadirProfesor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(52, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignaturas";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(214, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(253, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(393, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Eliminar las asignaturas de un profesor";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Añadir Asignatura a un profesor";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fProfesor";
            this.Text = "Ejercicio 6 - Gestión de profesores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bMostrarDatosProfesor;
        private System.Windows.Forms.Button bOrdenAlfabetico;
        private System.Windows.Forms.Button bMostrarProfesores;
        private System.Windows.Forms.Button bEliminarProfesor;
        private System.Windows.Forms.Button bAnyadirProfesor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}