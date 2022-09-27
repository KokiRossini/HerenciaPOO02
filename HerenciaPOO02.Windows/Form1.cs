using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HerenciaPOO02.Datos;
using HerenciaPOO02.Entidades;

namespace HerenciaPOO02.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            repositorio = new Repositorio();
        }
        private Repositorio repositorio;

        private Publicacion publicacion;
        private Libro libro;
        private AudioLibro audioLibro;
        private void CapturarDatosButton_Click(object sender, EventArgs e)
        {
            if (LibroImpresoRadioButton.Checked)
            {
                libro = new Libro(int.Parse(this.PrecioTextBox.Text), this.TituloTextBox.Text, int.Parse(this.PaginasTextBox.Text));
                publicacion = libro;
            }
            else
            {
                audioLibro=new AudioLibro(int.Parse(this.PrecioTextBox.Text), this.TituloTextBox.Text, int.Parse(this.TiempoTextBox.Text));
                publicacion=audioLibro;
            }
            
            if (repositorio!=publicacion)
            {
                if (repositorio+publicacion)
                {
                    MessageBox.Show("Publicaciòn agregada");
                }
                else
                {
                    MessageBox.Show("Publicaciòpn existente!!!");
                }
            }
        }
    }
}
