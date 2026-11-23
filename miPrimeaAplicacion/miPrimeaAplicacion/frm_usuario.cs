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
        bool iniciado = false;

        // Los dos Load hacen lo mismo, así funciona sin importar cuál esté enlazado en el diseñador
        private void frm_usuario_Load(object sender, EventArgs e)
        {
            iniciarFormulario();
        }

        private void frm_usuario_Load_1(object sender, EventArgs e)
        {
            iniciarFormulario();
        }

        private void iniciarFormulario()
        {
            if (iniciado) return;
            iniciado = true;
            obtenerDatos();
            activarDesactivarCtrls(false);
        }

        public void obtenerDatos()
        {
            try
            {
                // 1. Desenlazar el grid ANTES de recargar los datos
                if (grdDatosUsuarios != null)
                {
                    grdDatosUsuarios.DataSource = null;
                }

                // 2. Recargar (Conexion.obtenerDatos ya hace el Clear internamente)
                ds = objConexion.obtenerDatos();
                dt = ds.Tables["usuarios_usss078426"];
                dt.PrimaryKey = new DataColumn[] { dt.Columns["idUsuario"] };

                if (posicion >= dt.Rows.Count) posicion = dt.Rows.Count - 1;
                if (posicion < 0) posicion = 0;

                // 3. Volver a enlazar el grid
                if (grdDatosUsuarios != null)
                {
                    grdDatosUsuarios.AutoGenerateColumns = true;
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
                idUsuario.Text = dt.Rows[posicion]["idUsuario"].ToString();
                txtUsuario.Text = dt.Rows[posicion]["usuario"].ToString();
                txtClave.Text = dt.Rows[posicion]["clave"].ToString();
                txtConfirmarClave.Text = dt.Rows[posicion]["clave"].ToString();
                txtNombre.Text = dt.Rows[posicion]["nombre"].ToString();
                txtDireccion.Text = dt.Rows[posicion]["direccion"].ToString();
                txtTelefono.Text = dt.Rows[posicion]["telefono"].ToString();

                lblRegistrosUsuarios.Text = (posicion + 1) + " de " + dt.Rows.Count;
            }
            else
            {
                limpiarControles();
                lblRegistrosUsuarios.Text = "0 de 0";
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
            grbDatos.Enabled = true;
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

        // Los dos de cerrar sesión hacen lo mismo, así funciona sin importar cuál esté enlazado
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            cerrarSesion();
        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            cerrarSesion();
        }

        private void cerrarSesion()
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                login pantalla = new login();
                pantalla.Show();
                this.Close();
            }
        }

        private void grdDatosUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dt != null && e.RowIndex >= 0 && e.RowIndex < dt.Rows.Count)
            {
                posicion = e.RowIndex;
                mostrarDatos();
            }
        }

        // ===== Navegación =====
        private void btnPrimeroAlumno_Click(object sender, EventArgs e)
        {
            if (dt == null || dt.Rows.Count == 0) return;
            posicion = 0;
            mostrarDatos();
        }

        private void btnAnteriorAlumno_Click(object sender, EventArgs e)
        {
            if (dt == null || dt.Rows.Count == 0) return;
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
        }

        private void btnSiguienteAlumno_Click(object sender, EventArgs e)
        {
            if (dt == null || dt.Rows.Count == 0) return;
            if (posicion < dt.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
        }

        private void btnUltimoAlumno_Click(object sender, EventArgs e)
        {
            if (dt == null || dt.Rows.Count == 0) return;
            posicion = dt.Rows.Count - 1;
            mostrarDatos();
        }

        // ===== Edición =====
        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            accion = "nuevo";
            limpiarControles();
            activarDesactivarCtrls(true);
            txtUsuario.Focus();
        }

        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            accion = "modificar";
            activarDesactivarCtrls(true);
            txtUsuario.Focus();
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (idUsuario.Text == "") return;

            if (MessageBox.Show("¿Seguro que desea eliminar este usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] usuarios = { idUsuario.Text, "", "", "", "", "" };
                String respuesta = objConexion.mantenimiento_usuarios_usss078426(usuarios, "eliminar");
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Usuario eliminado.", "UGB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    obtenerDatos();
                }
            }
        }

        // Botón Guardar
        private void button1_Click(object sender, EventArgs e)
        {
            procesarGuardar();
            activarDesactivarCtrls(false);
        }
    }
}