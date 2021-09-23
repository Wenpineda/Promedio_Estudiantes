using PromedioEstudiantes.Entidades;
using PromedioEstudiantes.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromedioEstudiantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
           
        }

        private void txtCalcular_Click(object sender, EventArgs e)
        {
            string Materia;

            ClsEstudiante datos = new ClsEstudiante();
            Materia = TxtMateria.Text;
            datos.Nombre = txtNombre.Text;
            datos.Apellido = txtApellido.Text;
            datos.Lab1 = double.Parse(txtLab1.Text);
            datos.Lab2 = double.Parse(txtLab2.Text);
            datos.Lab3 = double.Parse(txtLab3.Text);
            datos.Parcial1 = double.Parse(txtParcial1.Text);
            datos.Parcial2 = double.Parse(txtParcial2.Text);
            datos.Parcial3 = double.Parse(txtParcial3.Text);

            NclsDatosE logic = new NclsDatosE();
            MessageBox.Show("Notas de la Asignatura de:" + Materia + logic.Calculos(datos));
        }

        private void txtVaciar_Click(object sender, EventArgs e)
        {

        }
    }
}
