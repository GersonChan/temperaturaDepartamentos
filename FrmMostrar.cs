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
    public partial class FrmMostrar : Form
    {
        public FrmMostrar()
        {
            InitializeComponent();
        }

        List<Mostrar> mostrar = new List<Mostrar>();
        List<Departamento> departamentos = new List<Departamento>();
        List<Temperatura> temperaturas = new List<Temperatura>();

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Leer("departamentos.txt");
            Leer("temperatura.txt");
            cargarListMostrar();
            cargarVista();
            btnPromedio.Enabled = true;
        }

        private void cargarVista()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            dataGridView1.DataSource = mostrar;
            dataGridView1.Refresh();
        }

        private void cargarListMostrar()
        {
            foreach (var i in departamentos)
            {                
                foreach (var j in temperaturas)
                {
                    if (i.noIdentificacion == j.noIdentificacion)
                    {
                        Mostrar mostrarTemp = new Mostrar();
                        mostrarTemp.nombre = i.nombre;
                        mostrarTemp.temperatura = j.temperatura;
                        mostrarTemp.fecha = j.fecha;
                        mostrar.Add(mostrarTemp);
                    }
                }
            }
        }

        private void Leer(string fileName)
        {

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                if (fileName == "departamentos.txt")
                {
                    Departamento departamentoTemp = new Departamento();
                    departamentoTemp.noIdentificacion = reader.ReadLine();
                    departamentoTemp.nombre = reader.ReadLine();

                    departamentos.Add(departamentoTemp);
                }
                else if (fileName == "temperatura.txt")
                {
                    Temperatura temperaturaTemp = new Temperatura();
                    temperaturaTemp.noIdentificacion = reader.ReadLine();
                    temperaturaTemp.temperatura = reader.ReadLine();
                    temperaturaTemp.fecha = Convert.ToDateTime(reader.ReadLine());

                    temperaturas.Add(temperaturaTemp);
                }
            }

            reader.Close();
        }

        private void temperaturaMasAltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrar = mostrar.OrderByDescending(t => t.temperatura).ToList();
            cargarVista();
        }

        private void temperaturaMasBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrar = mostrar.OrderBy(t => t.temperatura).ToList();
            cargarVista();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double contador = 0;
            foreach (var i in mostrar)
            {
                contador += Convert.ToInt16(i.temperatura);
            }
            double promedio = contador / mostrar.Count;
            MessageBox.Show("Promedio de la Temperatura: " + promedio + " grados");
        }
    }
}
