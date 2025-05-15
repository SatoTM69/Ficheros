using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Ficheros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearFichero_Click(object sender, EventArgs e)
        {
            /*StreamWriter es la clase que representa a un fichereo de texto
             en el que podemos escribir informacion.
            El fichero de texto lo creamos con el metodo(estatico) CreateText,
            que pertenece a la clase File.
            Para escribir en el fichero,empleamos Write y WriteLine.
            Close para cerrar el archivo, o podria quedar algun dato
            sin guardar*/
            StreamWriter fichero = File.CreateText("fichero1.txt");
            fichero.WriteLine("Hola este es mi primer fichero");
            fichero.Write("Siguiente fila\r\n");
            fichero.WriteLine("olas");
            fichero.Close();

            MessageBox.Show("Fichero creado con éxito.");

        }

        private void btnForma2Crear_Click(object sender, EventArgs e)
        {
            using (StreamWriter fichero = new StreamWriter("fichero1.txt"))
            {
                fichero.WriteLine("Este código es más compacto");
                fichero.WriteLine("Jesús");
                fichero.WriteLine("Carlos");
            }

            MessageBox.Show("Fichero sobrescrito con éxito.");
        }

        private void btnLeerArchivo_Click(object sender, EventArgs e)
        {
            if (File.Exists("fichero1.txt"))
            {
                StreamReader fichero = File.OpenText("fichero1.txt");
                string linea = fichero.ReadLine();
                MessageBox.Show(linea);
                fichero.Close();
            }
            else
            {
                MessageBox.Show("El archivo no existe.");
            }
        }

        private void btnLeerArchivos4_Click(object sender, EventArgs e)
        {
            try
            {
                string contenido = File.ReadAllText("fichero1.txt");
                MessageBox.Show(contenido);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            File.WriteAllText("fichero2.txt", "primera prueba\n");
            File.AppendAllText("fichero2.txt", "segunda prueba\n");
            MessageBox.Show("Fichero modificado con éxito.");
        }

        private void btnLeerArchivos2_Click(object sender, EventArgs e)
        {
            if (File.Exists("fichero1.txt"))
            {
                string[] lineas = File.ReadAllLines("fichero1.txt");
                MessageBox.Show(string.Join(Environment.NewLine, lineas));
            }
            else
            {
                MessageBox.Show("El archivo no existe.");
            }
        }

        private void btnLeerArchivos3_Click(object sender, EventArgs e)
        {
            if (File.Exists("fichero1.txt"))
            {
                using (StreamReader fichero = File.OpenText("fichero1.txt"))
                {
                    string resultado = "";
                    string linea;
                    while ((linea = fichero.ReadLine()) != null)
                    {
                        resultado += linea + "\n";
                    }
                    MessageBox.Show(resultado);
                }
            }
            else
            {
                MessageBox.Show("El archivo no existe.");
            }
        }
    }
}
