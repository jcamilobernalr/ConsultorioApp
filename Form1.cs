using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCotizacion f = new FormCotizacion();
            f.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReceta_Click(object sender, EventArgs e)
        {
            FormFormula f = new FormFormula();
            f.ShowDialog();
        }

        private void btnExcusa_Click(object sender, EventArgs e)
        {
            FormExcusa formExcusa = new FormExcusa();
            formExcusa.ShowDialog();
        }

        private void btnHistoria_Click(object sender, EventArgs e)
        {
            FormDocumento f = new FormDocumento("Historia clínica");
            f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
