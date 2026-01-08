using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoClases;

namespace WinFormsApp1
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Apellidos = "Reyes";
            persona.Edad = 25;
            persona.Genero = (TipoGenero)1;
            persona.Nacionalidad = Paises.Colombia;
            this.listBox1.Items.Add("Nombre: " + persona.Nombre + ", Apellidos: " +
                persona.Apellidos + ", Edad: " + persona.Edad + "Genero: " + persona.Genero);

            this.listBox1.Items.Add(
                persona.GetNombreCompleto(true)
                );

            persona.Domicilio = new Direccion();
            persona.Domicilio.Calle = "Calle Falsa";
            persona.Domicilio.Ciudad = "Springfield";
            persona.Domicilio.CodigoPostal = 12345;

            this.listBox1.Items.Add(
                "Domicilio: " + persona.Domicilio.Calle + ", " +
                persona.Domicilio.Ciudad + ", " +
                persona.Domicilio.CodigoPostal
                );

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.Nombre = "Juan";
            emp.Apellidos = "Perez";
            this.listBox1.Items.Add(
                "Vacaciones Empleado: " + emp.GetDiasVacaciones());

            this.listBox1.Items.Add(
                "Empleado: " + emp.GetNombreCompleto()
                   );
            this.listBox1.Items.Add(
                "Salario Minimo: " + emp.GetSalarioMinimo()
                );
        }

        private void btnDirector_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            director.Nombre = "Ana";
            director.Apellidos = "Gomez";
            this.listBox1.Items.Add(
             "Vacaciones Director: " + director.GetDiasVacaciones());

            this.listBox1.Items.Add(
                "Director: " + director.GetNombreCompleto()
                   );
            this.listBox1.Items.Add(
                "Salario Minimo: " + director.GetSalarioMinimo()
                );
        }
    }
}
