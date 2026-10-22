using System;
using System.Data;
using System.Windows.Forms;

namespace miPrimeaAplicacion
{
    public partial class frm_usuario : Form
    {
        public frm_usuario()
        {
            InitializeComponent();
        }

        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        String accion = "nuevo";
        int posicion = 0;

        private void frm_usuario_Load(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        public void obtenerDatos()
        {
            try
            {
                ds.Clear();
                ds = objConexion.obtenerDatos();
                dt = ds.Tables["usuarios_usss078426"];
                dt.PrimaryKey = new DataColumn[] { dt.Columns["idUsuario"] };

                if (grdDatosUsuarios != null)
                {
                    grdDatosUsuarios.DataSource = dt.DefaultView;
                }
                mostrarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }


        private void mostrarDatos()
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                // Sincronizado con tus componentes reales del diseño
                idUsuario.Text = dt.Rows[posicion]["idUsuario"].ToString();
                txtUsuario.Text = dt.Rows[posicion]["usuario"].ToString();
                txtClave.Text = dt.Rows[posicion]["clave"].ToString();
                txtConfirmarClave.Text = dt.Rows[posicion]["clave"].ToString();
                txtNombre.Text = dt.Rows[posicion]["nombre"].ToString();
                txtDireccion.Text = dt.Rows[posicion]["direccion"].ToString();
                txtTelefono.Text = dt.Rows[posicion]["telefono"].ToString();

                lblRegistrosUsuarios.Text = (posicion + 1) + " de " + dt.Rows.Count;
            }
        }

        private void limpiarControles()
        {
            idUsuario.Text = "";
            txtUsuario.Text = "";
            txtClave.Text = "";
            txtConfirmarClave.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }

        private void activarDesactivarCtrls(Boolean estado)
        {
            txtUsuario.Enabled = estado;
            txtClave.Enabled = estado;
            txtConfirmarClave.Enabled = estado;
            txtNombre.Enabled = estado;
            txtDireccion.Enabled = estado;
            txtTelefono.Enabled = estado;
        }

        public void procesarGuardar()
        {
            if (txtUsuario.Text.Trim().Length < 6 || txtUsuario.Text.Trim().Length > 16)
            {
                MessageBox.Show("El usuario debe tener entre 6 y 16 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtClave.Text != txtConfirmarClave.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool tieneLetras = false;
            bool tieneNumeros = false;
            foreach (char c in txtClave.Text)
            {
                if (char.IsLetter(c)) tieneLetras = true;
                if (char.IsDigit(c)) tieneNumeros = true;
            }

            if (!tieneLetras || !tieneNumeros)
            {
                MessageBox.Show("La contraseña debe llevar letras y números obligatoriamente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String[] usuarios = {
                idUsuario.Text, txtUsuario.Text, txtClave.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text
            };

            String respuesta = objConexion.mantenimiento_usuarios_usss078426(usuarios, accion);

            if (respuesta != "1")
            {
                MessageBox.Show(respuesta, "Error al guardar.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Operación realizada con éxito.", "UGB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                obtenerDatos();
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            login pantalla = new login();
            this.Hide();
            pantalla.Show();
        }

        private void frm_usuario_Load_1(object sender, EventArgs e)
        {

        }
        private void grdDatosUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que se haya hecho clic en una fila válida y no en los encabezados
            if (e.RowIndex >= 0)
            {
                // Obtiene la fila actual seleccionada
                DataGridViewRow fila = grdDatosUsuarios.Rows[e.RowIndex];

                // Pasa los datos de la fila a tus TextBox de la izquierda utilizando los índices de celda correctos
                idUsuario.Text = fila.Cells[0].Value.ToString();       // ID
                txtUsuario.Text = fila.Cells[1].Value.ToString();  // CODIGO / USUARIO
                txtNombre.Text = fila.Cells[2].Value.ToString();   // NOMBRE
                txtDireccion.Text = fila.Cells[3].Value.ToString(); // DIRECCION
                txtTelefono.Text = fila.Cells[4].Value.ToString();  // TELEFONO
            }

        }

    }
}

