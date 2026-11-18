using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_I
{
    public partial class frmCalculoImpuestos : Form
    {
        // Matriz con los datos de la tabla (Desde, Hasta, Precio, Adicional)[cite: 1]
        double[,] tablaImpuestos = new double[,]
        {
            { 0.01, 500.00, 1.50, 0.00 },
            { 500.01, 1000.00, 1.50, 3.00 },
            { 1000.01, 2000.00, 3.00, 3.00 },
            { 2000.01, 3000.00, 6.00, 3.00 },
            { 3000.01, 6000.00, 9.00, 2.00 },
            { 6000.01, 8000.00, 15.00, 2.00 },
            { 8000.01, 18000.00, 15.00, 2.00 },
            { 18000.01, 30000.00, 39.00, 2.00 },
            { 30000.01, 60000.00, 63.00, 1.00 },
            { 60000.01, 100000.00, 93.00, 0.80 },
            { 100000.01, 200000.00, 125.00, 0.70 },
            { 200000.01, 300000.00, 195.00, 0.60 },
            { 300000.01, 400000.00, 255.00, 0.45 },
            { 400000.01, 500000.00, 300.00, 0.40 },
            { 500000.01, 1000000.00, 340.00, 0.30 },
            { 1000000.01, 99999999.00, 490.00, 0.18 }
        };

        public frmCalculoImpuestos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCalculoImpuestos_Load(object sender, EventArgs e)
        {
            // Suscripción explícita de eventos para asegurar que los botones respondan al hacer clic
            btnCalcular.Click += new EventHandler(btnCalcular_Click);
            btnLimpiar.Click += new EventHandler(btnLimpiar_Click);
            btnSalir.Click += new EventHandler(btnSalir_Click);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMonto_Click(object sender, EventArgs e)
        {

        }

        // --- MÉTODOS PARA NAVEGAR LOS BOTONES ---

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        // --- FUNCIONES DE LÓGICA ---

        private void Calcular()
        {
            if (double.TryParse(txtMonto.Text, out double monto) && monto > 0)
            {
                int filas = tablaImpuestos.GetLength(0);

                for (int i = 0; i < filas; i++)
                {
                    double desde = tablaImpuestos[i, 0];
                    double hasta = tablaImpuestos[i, 1];
                    double precio = tablaImpuestos[i, 2];
                    double adicional = tablaImpuestos[i, 3];

                    if (monto >= desde && monto <= hasta)
                    {
                        double sobrante = monto - desde;
                        double total = (sobrante / 1000.0) * adicional + precio;

                        lblTramo.Text = "Tramo aplicado: N° " + (i + 1) + " ($" + desde + " - $" + hasta + ")";
                        lblImpuesto.Text = "Impuesto a pagar: $" + Math.Round(total, 2).ToString("F2");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese un monto numérico válido mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            txtMonto.Clear();
            lblTramo.Text = "Tramo aplicado: ?";
            lblImpuesto.Text = "Impuesto a pagar: ?";
            txtMonto.Focus();
        }
    }
}