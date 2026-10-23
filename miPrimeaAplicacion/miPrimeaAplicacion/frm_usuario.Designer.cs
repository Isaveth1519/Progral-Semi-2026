namespace miPrimeaAplicacion
{
    partial class frm_usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBuscarAlumnos = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdDatosUsuarios = new System.Windows.Forms.DataGridView();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnModificarALumno = new System.Windows.Forms.Button();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.txtBuscarAlumnos = new System.Windows.Forms.TextBox();
            this.grbEdicion = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblRegistrosAlumnos = new System.Windows.Forms.Label();
            this.btnUltimoAlumno = new System.Windows.Forms.Button();
            this.btnSiguienteAlumno = new System.Windows.Forms.Button();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idUsuario = new System.Windows.Forms.Label();
            this.lblIdAlumno = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblEmailAlumno = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefonoAlumno = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccionAlumno = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            this.lblRegistrosUsuarios = new System.Windows.Forms.GroupBox();
            this.btnAnteriorAlumno = new System.Windows.Forms.Button();
            this.btnPrimeroAlumno = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosUsuarios)).BeginInit();
            this.grbEdicion.SuspendLayout();
            this.grbDatos.SuspendLayout();
            this.lblRegistrosUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscarAlumnos
            // 
            this.lblBuscarAlumnos.AutoSize = true;
            this.lblBuscarAlumnos.Location = new System.Drawing.Point(611, 41);
            this.lblBuscarAlumnos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarAlumnos.Name = "lblBuscarAlumnos";
            this.lblBuscarAlumnos.Size = new System.Drawing.Size(52, 16);
            this.lblBuscarAlumnos.TabIndex = 17;
            this.lblBuscarAlumnos.Text = "Buscar:";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "EMAIL";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 125;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 125;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 125;
            // 
            // id
            // 
            this.id.DataPropertyName = "idAlumno";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // grdDatosUsuarios
            // 
            this.grdDatosUsuarios.AllowUserToAddRows = false;
            this.grdDatosUsuarios.AllowUserToDeleteRows = false;
            this.grdDatosUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nombre,
            this.direccion,
            this.telefono,
            this.email});
            this.grdDatosUsuarios.Location = new System.Drawing.Point(615, 78);
            this.grdDatosUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.grdDatosUsuarios.Name = "grdDatosUsuarios";
            this.grdDatosUsuarios.ReadOnly = true;
            this.grdDatosUsuarios.RowHeadersWidth = 51;
            this.grdDatosUsuarios.Size = new System.Drawing.Size(677, 300);
            this.grdDatosUsuarios.TabIndex = 16;
            this.grdDatosUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatosUsuarios_CellClick);
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumno.Location = new System.Drawing.Point(253, 25);
            this.btnEliminarAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(127, 44);
            this.btnEliminarAlumno.TabIndex = 9;
            this.btnEliminarAlumno.Text = "Eliminar";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
            // 
            // btnModificarALumno
            // 
            this.btnModificarALumno.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarALumno.Location = new System.Drawing.Point(119, 23);
            this.btnModificarALumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarALumno.Name = "btnModificarALumno";
            this.btnModificarALumno.Size = new System.Drawing.Size(127, 44);
            this.btnModificarALumno.TabIndex = 8;
            this.btnModificarALumno.Text = "Modificar";
            this.btnModificarALumno.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlumno.Location = new System.Drawing.Point(4, 23);
            this.btnAgregarAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(112, 44);
            this.btnAgregarAlumno.TabIndex = 7;
            this.btnAgregarAlumno.Text = "Agregar";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // txtBuscarAlumnos
            // 
            this.txtBuscarAlumnos.Location = new System.Drawing.Point(676, 37);
            this.txtBuscarAlumnos.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarAlumnos.Name = "txtBuscarAlumnos";
            this.txtBuscarAlumnos.Size = new System.Drawing.Size(615, 22);
            this.txtBuscarAlumnos.TabIndex = 18;
            // 
            // grbEdicion
            // 
            this.grbEdicion.Controls.Add(this.button1);
            this.grbEdicion.Controls.Add(this.btnEliminarAlumno);
            this.grbEdicion.Controls.Add(this.btnModificarALumno);
            this.grbEdicion.Controls.Add(this.btnAgregarAlumno);
            this.grbEdicion.Location = new System.Drawing.Point(337, 399);
            this.grbEdicion.Margin = new System.Windows.Forms.Padding(4);
            this.grbEdicion.Name = "grbEdicion";
            this.grbEdicion.Padding = new System.Windows.Forms.Padding(4);
            this.grbEdicion.Size = new System.Drawing.Size(488, 75);
            this.grbEdicion.TabIndex = 15;
            this.grbEdicion.TabStop = false;
            this.grbEdicion.Text = "Edicion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 42);
            this.button1.TabIndex = 20;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRegistrosAlumnos
            // 
            this.lblRegistrosAlumnos.AutoSize = true;
            this.lblRegistrosAlumnos.Location = new System.Drawing.Point(111, 46);
            this.lblRegistrosAlumnos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrosAlumnos.Name = "lblRegistrosAlumnos";
            this.lblRegistrosAlumnos.Size = new System.Drawing.Size(42, 16);
            this.lblRegistrosAlumnos.TabIndex = 10;
            this.lblRegistrosAlumnos.Text = "x de n";
            // 
            // btnUltimoAlumno
            // 
            this.btnUltimoAlumno.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoAlumno.Location = new System.Drawing.Point(225, 25);
            this.btnUltimoAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnUltimoAlumno.Name = "btnUltimoAlumno";
            this.btnUltimoAlumno.Size = new System.Drawing.Size(52, 50);
            this.btnUltimoAlumno.TabIndex = 6;
            this.btnUltimoAlumno.Text = ">|";
            this.btnUltimoAlumno.UseVisualStyleBackColor = true;
            this.btnUltimoAlumno.Click += new System.EventHandler(this.btnUltimoAlumno_Click);
            // 
            // btnSiguienteAlumno
            // 
            this.btnSiguienteAlumno.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteAlumno.Location = new System.Drawing.Point(177, 25);
            this.btnSiguienteAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguienteAlumno.Name = "btnSiguienteAlumno";
            this.btnSiguienteAlumno.Size = new System.Drawing.Size(52, 50);
            this.btnSiguienteAlumno.TabIndex = 5;
            this.btnSiguienteAlumno.Text = ">";
            this.btnSiguienteAlumno.UseVisualStyleBackColor = true;
            this.btnSiguienteAlumno.Click += new System.EventHandler(this.btnSiguienteAlumno_Click);
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.txtConfirmarClave);
            this.grbDatos.Controls.Add(this.label1);
            this.grbDatos.Controls.Add(this.idUsuario);
            this.grbDatos.Controls.Add(this.lblIdAlumno);
            this.grbDatos.Controls.Add(this.txtClave);
            this.grbDatos.Controls.Add(this.lblEmailAlumno);
            this.grbDatos.Controls.Add(this.txtTelefono);
            this.grbDatos.Controls.Add(this.lblTelefonoAlumno);
            this.grbDatos.Controls.Add(this.txtDireccion);
            this.grbDatos.Controls.Add(this.lblDireccionAlumno);
            this.grbDatos.Controls.Add(this.txtNombre);
            this.grbDatos.Controls.Add(this.lblNombreAlumno);
            this.grbDatos.Controls.Add(this.txtUsuario);
            this.grbDatos.Controls.Add(this.lblCodigoAlumno);
            this.grbDatos.Location = new System.Drawing.Point(9, 13);
            this.grbDatos.Margin = new System.Windows.Forms.Padding(4);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Padding = new System.Windows.Forms.Padding(4);
            this.grbDatos.Size = new System.Drawing.Size(594, 365);
            this.grbDatos.TabIndex = 13;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "DATOS";
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Location = new System.Drawing.Point(124, 314);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.Size = new System.Drawing.Size(197, 22);
            this.txtConfirmarClave.TabIndex = 13;
            this.txtConfirmarClave.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "CONFIRMAR;";
            // 
            // idUsuario
            // 
            this.idUsuario.AutoSize = true;
            this.idUsuario.Location = new System.Drawing.Point(131, 20);
            this.idUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.Size = new System.Drawing.Size(81, 16);
            this.idUsuario.TabIndex = 11;
            this.idUsuario.Text = "IDUSUARIO";
            // 
            // lblIdAlumno
            // 
            this.lblIdAlumno.AutoSize = true;
            this.lblIdAlumno.Location = new System.Drawing.Point(25, 20);
            this.lblIdAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdAlumno.Name = "lblIdAlumno";
            this.lblIdAlumno.Size = new System.Drawing.Size(23, 16);
            this.lblIdAlumno.TabIndex = 10;
            this.lblIdAlumno.Text = "ID:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(124, 282);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(197, 22);
            this.txtClave.TabIndex = 9;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // lblEmailAlumno
            // 
            this.lblEmailAlumno.AutoSize = true;
            this.lblEmailAlumno.Location = new System.Drawing.Point(25, 286);
            this.lblEmailAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailAlumno.Name = "lblEmailAlumno";
            this.lblEmailAlumno.Size = new System.Drawing.Size(104, 16);
            this.lblEmailAlumno.TabIndex = 8;
            this.lblEmailAlumno.Text = "CONTRASEÑA;";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(124, 234);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(197, 22);
            this.txtTelefono.TabIndex = 7;
            // 
            // lblTelefonoAlumno
            // 
            this.lblTelefonoAlumno.AutoSize = true;
            this.lblTelefonoAlumno.Location = new System.Drawing.Point(25, 238);
            this.lblTelefonoAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoAlumno.Name = "lblTelefonoAlumno";
            this.lblTelefonoAlumno.Size = new System.Drawing.Size(82, 16);
            this.lblTelefonoAlumno.TabIndex = 6;
            this.lblTelefonoAlumno.Text = "TELEFONO:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(124, 151);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(361, 58);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblDireccionAlumno
            // 
            this.lblDireccionAlumno.AutoSize = true;
            this.lblDireccionAlumno.Location = new System.Drawing.Point(25, 155);
            this.lblDireccionAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionAlumno.Name = "lblDireccionAlumno";
            this.lblDireccionAlumno.Size = new System.Drawing.Size(83, 16);
            this.lblDireccionAlumno.TabIndex = 4;
            this.lblDireccionAlumno.Text = "DIRECCION:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(124, 97);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(361, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Location = new System.Drawing.Point(25, 101);
            this.lblNombreAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(69, 16);
            this.lblNombreAlumno.TabIndex = 2;
            this.lblNombreAlumno.Text = "NOMBRE:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(124, 53);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(197, 22);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Location = new System.Drawing.Point(25, 57);
            this.lblCodigoAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(71, 16);
            this.lblCodigoAlumno.TabIndex = 0;
            this.lblCodigoAlumno.Text = "USUARIO;";
            // 
            // lblRegistrosUsuarios
            // 
            this.lblRegistrosUsuarios.Controls.Add(this.lblRegistrosAlumnos);
            this.lblRegistrosUsuarios.Controls.Add(this.btnUltimoAlumno);
            this.lblRegistrosUsuarios.Controls.Add(this.btnSiguienteAlumno);
            this.lblRegistrosUsuarios.Controls.Add(this.btnAnteriorAlumno);
            this.lblRegistrosUsuarios.Controls.Add(this.btnPrimeroAlumno);
            this.lblRegistrosUsuarios.Controls.Add(this.groupBox3);
            this.lblRegistrosUsuarios.Location = new System.Drawing.Point(13, 399);
            this.lblRegistrosUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.lblRegistrosUsuarios.Name = "lblRegistrosUsuarios";
            this.lblRegistrosUsuarios.Padding = new System.Windows.Forms.Padding(4);
            this.lblRegistrosUsuarios.Size = new System.Drawing.Size(283, 75);
            this.lblRegistrosUsuarios.TabIndex = 14;
            this.lblRegistrosUsuarios.TabStop = false;
            this.lblRegistrosUsuarios.Text = "Navegacion";
            // 
            // btnAnteriorAlumno
            // 
            this.btnAnteriorAlumno.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorAlumno.Location = new System.Drawing.Point(51, 25);
            this.btnAnteriorAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnteriorAlumno.Name = "btnAnteriorAlumno";
            this.btnAnteriorAlumno.Size = new System.Drawing.Size(52, 50);
            this.btnAnteriorAlumno.TabIndex = 4;
            this.btnAnteriorAlumno.Text = "<";
            this.btnAnteriorAlumno.UseVisualStyleBackColor = true;
            this.btnAnteriorAlumno.Click += new System.EventHandler(this.btnAnteriorAlumno_Click);
            // 
            // btnPrimeroAlumno
            // 
            this.btnPrimeroAlumno.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroAlumno.Location = new System.Drawing.Point(3, 25);
            this.btnPrimeroAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrimeroAlumno.Name = "btnPrimeroAlumno";
            this.btnPrimeroAlumno.Size = new System.Drawing.Size(52, 50);
            this.btnPrimeroAlumno.TabIndex = 3;
            this.btnPrimeroAlumno.Text = "|<";
            this.btnPrimeroAlumno.UseVisualStyleBackColor = true;
            this.btnPrimeroAlumno.Click += new System.EventHandler(this.btnPrimeroAlumno_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(285, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(316, 75);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(1191, 426);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(120, 46);
            this.btnCerrarSesion.TabIndex = 19;
            this.btnCerrarSesion.Text = "Cerrar Sesion ";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click_1);
            // 
            // frm_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 596);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblBuscarAlumnos);
            this.Controls.Add(this.grdDatosUsuarios);
            this.Controls.Add(this.txtBuscarAlumnos);
            this.Controls.Add(this.grbEdicion);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.lblRegistrosUsuarios);
            this.Name = "frm_usuario";
            this.Text = "frm_usuario";
            this.Load += new System.EventHandler(this.frm_usuario_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosUsuarios)).EndInit();
            this.grbEdicion.ResumeLayout(false);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.lblRegistrosUsuarios.ResumeLayout(false);
            this.lblRegistrosUsuarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridView grdDatosUsuarios;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Button btnModificarALumno;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.TextBox txtBuscarAlumnos;
        private System.Windows.Forms.GroupBox grbEdicion;
        private System.Windows.Forms.Label lblRegistrosAlumnos;
        private System.Windows.Forms.Button btnUltimoAlumno;
        private System.Windows.Forms.Button btnSiguienteAlumno;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Label idUsuario;
        private System.Windows.Forms.Label lblIdAlumno;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblEmailAlumno;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefonoAlumno;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccionAlumno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.GroupBox lblRegistrosUsuarios;
        private System.Windows.Forms.Button btnAnteriorAlumno;
        private System.Windows.Forms.Button btnPrimeroAlumno;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button button1;
    }
}