using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temperaturaDepartamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Departamento> departamentos = new List<Departamento>();
        List<Temperatura> temperaturas = new List<Temperatura>();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Temperatura temperaturaTemp = new Temperatura();
            temperaturaTemp.noIdentificacion = comboBox1.SelectedIndex.ToString();
            temperaturaTemp.temperatura = textBox1.Text;
            temperaturaTemp.fecha = dateTimePicker1.Value;
            
            int pocicion = temperaturas.FindIndex(c => c.noIdentificacion == temperaturaTemp.noIdentificacion);
            if (pocicion == -1)
            {
                temperaturas.Add(temperaturaTemp);
                guardar("temperatura.txt");
            }
            else
            {
                MessageBox.Show("departameto ya ingresado");
            }

            textBox1.Text = "";
        }

        private void guardar(String fileNombre)
        {
            FileStream stream = new FileStream(fileNombre, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (var temp in temperaturas)
            {
                writer.WriteLine(temp.noIdentificacion);
                writer.WriteLine(temp.temperatura);
                writer.WriteLine(temp.fecha);
            }
            writer.Close();
        }

        private void CargarComboBox()
        {       
            comboBox1.DataSource = null;
            comboBox1.Refresh();

            comboBox1.DisplayMember = "nombre";
            comboBox1.DataSource = departamentos;
            comboBox1.Refresh();

        }

        private void Leer(string fileName)
        {

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Departamento departamentoTemp = new Departamento();
                departamentoTemp.nombre = reader.ReadLine();
                departamentoTemp.nombre = reader.ReadLine();
                
                departamentos.Add(departamentoTemp);
            }

            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Leer("departamentos.txt");
            CargarComboBox();
        }
    }
}
