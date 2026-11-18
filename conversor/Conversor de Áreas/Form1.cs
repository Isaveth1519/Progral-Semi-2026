using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_Áreas
{
    public partial class frmConversorAreas : Form
    {
        // Diccionario: unidad -> factor de conversión a METROS CUADRADOS (unidad base)
        private Dictionary<string, double> factoresAMetros = new Dictionary<string, double>
        {
            { "Pies Cuadrados", 0.092903 },
            { "Varas Cuadradas", 0.698896 },
            { "Yardas Cuadradas", 0.836127 },
            { "Metros Cuadrados", 1.0 },
            { "Tareas", 437.5 },
            { "Manzanas", 6988.96 },
            { "Hectáreas", 10000.0 }
        };

        public frmConversorAreas()
        {
            InitializeComponent();
            PrepararFormulario();
        }

        private void PrepararFormulario()
        {
            cboDe.Items.Clear();
            cboA.Items.Clear();

            foreach (string unidad in factoresAMetros.Keys)
            {
                cboDe.Items.Add(unidad);
                cboA.Items.Add(unidad);
            }

            cboDe.SelectedIndex = 0;
            cboA.SelectedIndex = 3;
            lblResultado.Text = "Resultado: ---";
        }

        private void frmConversorAreas_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor ingrese un valor a convertir.",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return;
            }

            if (!double.TryParse(txtCantidad.Text, out double valor) || valor < 0)
            {
                MessageBox.Show("El valor ingresado no es un número válido.",
                                "Error de entrada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return;
            }

            if (cboDe.SelectedItem == null || cboA.SelectedItem == null)
            {
                MessageBox.Show("Seleccione la unidad de origen y destino.", "Atención");
                return;
            }

            string unidadDesde = cboDe.SelectedItem.ToString();
            string unidadHasta = cboA.SelectedItem.ToString();

            // Conversión matemática directa
            double valorEnMetros = valor * factoresAMetros[unidadDesde];
            double resultado = valorEnMetros / factoresAMetros[unidadHasta];

            lblResultado.Text = "Resultado: " + resultado.ToString("G8") + " " + unidadHasta;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            cboDe.SelectedIndex = 0;
            cboA.SelectedIndex = 3;
            lblResultado.Text = "Resultado: ---";
            txtCantidad.Focus();
        }

        
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void cboDe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}