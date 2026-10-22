using System;
using System.Data;
using System.Windows.Forms;

namespace miPrimeaAplicacion
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion objConexion = new Conexion();
                DataSet dsUsuarios = objConexion.obtenerDatos();
                DataTable dtUsuarios = dsUsuarios.Tables["usuarios_usss078426"];

                // Busca si coincide el usuario y clave ingresados
                DataRow[] filasEncontradas = dtUsuarios.Select("usuario = '" + txtUsuarioLogin.Text.Trim() + "' AND clave = '" + txtClaveLogin.Text + "'");

                if (filasEncontradas.Length > 0)
                {
                    MessageBox.Show("Acceso concedido. Bienvenido al sistema.", "UGB Control", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abre tu pantalla de mantenimiento de usuarios (frm_usuario) y oculta el login
                    frm_usuario pantallaUsuarios = new frm_usuario();
                    this.Hide();
                    pantallaUsuarios.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos. Acceso denegado.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveLogin.Clear();
                    txtUsuarioLogin.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de ejecución: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion objConexion = new Conexion();
                DataSet dsUsuarios = objConexion.obtenerDatos();
                DataTable dtUsuarios = dsUsuarios.Tables["usuarios_usss078426"];

                // Busca si coincide el usuario y clave ingresados en tus cuadros de texto del login
                DataRow[] filasEncontradas = dtUsuarios.Select("usuario = '" + txtUsuarioLogin.Text.Trim() + "' AND clave = '" + txtClaveLogin.Text + "'");

                if (filasEncontradas.Length > 0)
                {
                    MessageBox.Show("Acceso autorizado. ¡Bienvenido al sistema!", "UGB Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frm_usuario pantallaUsuarios = new frm_usuario();
                    this.Hide();
                    pantallaUsuarios.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos. Acceso denegado.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de ejecución: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuarioLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
