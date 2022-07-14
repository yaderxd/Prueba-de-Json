using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Prueba_de_Json
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Edad = int.Parse(txtEdad.Text),
                Carnet = txtCarnet.Text,
                Oficio = txtOficio.Text
            };

            string json = JsonConvert.SerializeObject(empleado);
            string Filename = "Roropiroro.json";
            File.WriteAllText(Filename,json);

           
        }

        private void btnDeserializar_Click(object sender, EventArgs e)
        {


            Empleado empleadoReceptor = new Empleado();

            string fileName = "Roropiroro.json";
            string json = File.ReadAllText(fileName);
            empleadoReceptor = JsonConvert.DeserializeObject<Empleado>(json);



            richTextBox1.Text = $"Nombre : {empleadoReceptor.Nombre} "+
            $"Apellido : {empleadoReceptor.Apellido} "+
             $"Edad : {empleadoReceptor.Edad} "+
            $"Carnet : {empleadoReceptor.Carnet} "+
             $"Oficio : {empleadoReceptor.Oficio} ";

         


        }
    }
}
