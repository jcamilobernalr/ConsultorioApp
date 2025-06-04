using System;
using System.Windows.Forms;

namespace ConsultorioApp
{
    public partial class FormMedicamento : Form
    {
        public MedicamentoRecetado Medicamento { get; private set; }

        public FormMedicamento()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor ingresa el nombre del medicamento.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Medicamento = new MedicamentoRecetado
            {
                Nombre = txtNombre.Text.Trim(),
                Dosis = txtDosis.Text.Trim(),
                Frecuencia = txtFrecuencia.Text.Trim(),
                Duracion = txtDuracion.Text.Trim()
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
