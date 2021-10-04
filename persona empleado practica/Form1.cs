using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//René Ismael Fuentes Benítez (SMIS047221)
//David Arnoldo Hernandez Gómez (SMIS051821)

namespace persona_empleado_practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.nombre = "Juan";
            empleado.ApPaterno = "Villa";
            empleado.ApMaterno = "Real";
            empleado.edad = 53;
            empleado.NumEmpleado = 123456;
            empleado.Puesto = "gerenete";

            Estudiante estudiante = new Estudiante();
            estudiante.nombre = "Maria";
            estudiante.ApPaterno = "Lisama";
            estudiante.ApMaterno = "Torres";
            estudiante.edad = 19;
            estudiante.Semestre = 5;
            estudiante.NomEscuela = "Escuela Amilta de montiel.";

            MessageBox.Show(empleado.nombre + " " + empleado.ApPaterno + " " + empleado.ApMaterno + ", " + empleado.edad.ToString() + ", " + empleado.NumEmpleado.ToString() + ", " + empleado.Puesto);
            MessageBox.Show(estudiante.nombre + " " + estudiante.ApPaterno + " " + estudiante.ApMaterno + ", " + estudiante.edad.ToString() + ", " + estudiante.Semestre.ToString() + ", " + estudiante.NomEscuela);
        }
    }
}
