namespace miPrimeaAplicacion {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.idAlumno = new System.Windows.Forms.Label();
            this.lblIdAlumno = new System.Windows.Forms.Label();
            this.txtEmailAlumno = new System.Windows.Forms.TextBox();
            this.lblEmailAlumno = new System.Windows.Forms.Label();
            this.txtTelefonoAlumno = new System.Windows.Forms.TextBox();
            this.lblTelefonoAlumno = new System.Windows.Forms.Label();
            this.txtDireccionAlumno = new System.Windows.Forms.TextBox();
            this.lblDireccionAlumno = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.txtCodigoAlumno = new System.Windows.Forms.TextBox();
            this.lblCodigoAlumno = new System.Windows.Forms.Label();
            this.grbNavegacion = new System.Windows.Forms.GroupBox();
            this.lblRegistrosAlumnos = new System.Windows.Forms.Label();
            this.btnUltimoAlumno = new System.Windows.Forms.Button();
            this.btnSiguienteAlumno = new System.Windows.Forms.Button();
            this.btnAnteriorAlumno = new System.Windows.Forms.Button();
            this.btnPrimeroAlumno = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grbEdicion = new System.Windows.Forms.GroupBox();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.btnModificarALumno = new System.Windows.Forms.Button();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.grdDatosAlumnos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarAlumnos = new System.Windows.Forms.TextBox();
            this.lblBuscarAlumnos = new System.Windows.Forms.Label();
            this.grbDatos.SuspendLayout();
            this.grbNavegacion.SuspendLayout();
            this.grbEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.idAlumno);
            this.grbDatos.Controls.Add(this.lblIdAlumno);
            this.grbDatos.Controls.Add(this.txtEmailAlumno);
            this.grbDatos.Controls.Add(this.lblEmailAlumno);
            this.grbDatos.Controls.Add(this.txtTelefonoAlumno);
            this.grbDatos.Controls.Add(this.lblTelefonoAlumno);
            this.grbDatos.Controls.Add(this.txtDireccionAlumno);
            this.grbDatos.Controls.Add(this.lblDireccionAlumno);
            this.grbDatos.Controls.Add(this.txtNombreAlumno);
            this.grbDatos.Controls.Add(this.lblNombreAlumno);
            this.grbDatos.Controls.Add(this.txtCodigoAlumno);
            this.grbDatos.Controls.Add(this.lblCodigoAlumno);
            this.grbDatos.Enabled = false;
            this.grbDatos.Location = new System.Drawing.Point(37, 32);
            this.grbDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbDatos.Size = new System.Drawing.Size(601, 357);
            this.grbDatos.TabIndex = 0;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "DATOS";
            // 
            // idAlumno
            // 
            this.idAlumno.AutoSize = true;
            this.idAlumno.Location = new System.Drawing.Point(131, 20);
            this.idAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.Size = new System.Drawing.Size(14, 16);
            this.idAlumno.TabIndex = 11;
            this.idAlumno.Text = "0";
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
            // txtEmailAlumno
            // 
            this.txtEmailAlumno.Location = new System.Drawing.Point(124, 282);
            this.txtEmailAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmailAlumno.Name = "txtEmailAlumno";
            this.txtEmailAlumno.Size = new System.Drawing.Size(197, 22);
            this.txtEmailAlumno.TabIndex = 9;
            // 
            // lblEmailAlumno
            // 
            this.lblEmailAlumno.AutoSize = true;
            this.lblEmailAlumno.Location = new System.Drawing.Point(25, 286);
            this.lblEmailAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailAlumno.Name = "lblEmailAlumno";
            this.lblEmailAlumno.Size = new System.Drawing.Size(49, 16);
            this.lblEmailAlumno.TabIndex = 8;
            this.lblEmailAlumno.Text = "EMAIL:";
            // 
            // txtTelefonoAlumno
            // 
            this.txtTelefonoAlumno.Location = new System.Drawing.Point(124, 234);
            this.txtTelefonoAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            this.txtTelefonoAlumno.Size = new System.Drawing.Size(197, 22);
            this.txtTelefonoAlumno.TabIndex = 7;
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
            // txtDireccionAlumno
            // 
            this.txtDireccionAlumno.Location = new System.Drawing.Point(124, 151);
            this.txtDireccionAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccionAlumno.Multiline = true;
            this.txtDireccionAlumno.Name = "txtDireccionAlumno";
            this.txtDireccionAlumno.Size = new System.Drawing.Size(361, 58);
            this.txtDireccionAlumno.TabIndex = 5;
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
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(124, 97);
            this.txtNombreAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(361, 22);
            this.txtNombreAlumno.TabIndex = 3;
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
            // txtCodigoAlumno
            // 
            this.txtCodigoAlumno.Location = new System.Drawing.Point(124, 53);
            this.txtCodigoAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoAlumno.Name = "txtCodigoAlumno";
            this.txtCodigoAlumno.Size = new System.Drawing.Size(197, 22);
            this.txtCodigoAlumno.TabIndex = 1;
            // 
            // lblCodigoAlumno
            // 
            this.lblCodigoAlumno.AutoSize = true;
            this.lblCodigoAlumno.Location = new System.Drawing.Point(25, 57);
            this.lblCodigoAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoAlumno.Name = "lblCodigoAlumno";
            this.lblCodigoAlumno.Size = new System.Drawing.Size(62, 16);
            this.lblCodigoAlumno.TabIndex = 0;
            this.lblCodigoAlumno.Text = "CODIGO:";
            // 
            // grbNavegacion
            // 
            this.grbNavegacion.Controls.Add(this.lblRegistrosAlumnos);
            this.grbNavegacion.Controls.Add(this.btnUltimoAlumno);
            this.grbNavegacion.Controls.Add(this.btnSiguienteAlumno);
            this.grbNavegacion.Controls.Add(this.btnAnteriorAlumno);
            this.grbNavegacion.Controls.Add(this.btnPrimeroAlumno);
            this.grbNavegacion.Controls.Add(this.groupBox3);
            this.grbNavegacion.Location = new System.Drawing.Point(37, 410);
            this.grbNavegacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbNavegacion.Size = new System.Drawing.Size(277, 75);
            this.grbNavegacion.TabIndex = 1;
            this.grbNavegacion.TabStop = false;
            this.grbNavegacion.Text = "Navegacion";
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
            this.btnUltimoAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnSiguienteAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiguienteAlumno.Name = "btnSiguienteAlumno";
            this.btnSiguienteAlumno.Size = new System.Drawing.Size(52, 50);
            this.btnSiguienteAlumno.TabIndex = 5;
            this.btnSiguienteAlumno.Text = ">";
            this.btnSiguienteAlumno.UseVisualStyleBackColor = true;
            this.btnSiguienteAlumno.Click += new System.EventHandler(this.btnSiguienteAlumno_Click);
            // 
            // btnAnteriorAlumno
            // 
            this.btnAnteriorAlumno.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorAlumno.Location = new System.Drawing.Point(51, 25);
            this.btnAnteriorAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnPrimeroAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(316, 75);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // grbEdicion
            // 
            this.grbEdicion.Controls.Add(this.btnEliminarAlumno);
            this.grbEdicion.Controls.Add(this.btnModificarALumno);
            this.grbEdicion.Controls.Add(this.btnAgregarAlumno);
            this.grbEdicion.Location = new System.Drawing.Point(331, 410);
            this.grbEdicion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbEdicion.Name = "grbEdicion";
            this.grbEdicion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbEdicion.Size = new System.Drawing.Size(423, 75);
            this.grbEdicion.TabIndex = 3;
            this.grbEdicion.TabStop = false;
            this.grbEdicion.Text = "Edicion";
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumno.Location = new System.Drawing.Point(253, 25);
            this.btnEliminarAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnModificarALumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarALumno.Name = "btnModificarALumno";
            this.btnModificarALumno.Size = new System.Drawing.Size(127, 44);
            this.btnModificarALumno.TabIndex = 8;
            this.btnModificarALumno.Text = "Modificar";
            this.btnModificarALumno.UseVisualStyleBackColor = true;
            this.btnModificarALumno.Click += new System.EventHandler(this.btnModificarALumno_Click);
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlumno.Location = new System.Drawing.Point(4, 23);
            this.btnAgregarAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(112, 44);
            this.btnAgregarAlumno.TabIndex = 7;
            this.btnAgregarAlumno.Text = "Agregar";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // grdDatosAlumnos
            // 
            this.grdDatosAlumnos.AllowUserToAddRows = false;
            this.grdDatosAlumnos.AllowUserToDeleteRows = false;
            this.grdDatosAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nombre,
            this.direccion,
            this.telefono,
            this.email});
            this.grdDatosAlumnos.Location = new System.Drawing.Point(668, 89);
            this.grdDatosAlumnos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdDatosAlumnos.Name = "grdDatosAlumnos";
            this.grdDatosAlumnos.ReadOnly = true;
            this.grdDatosAlumnos.RowHeadersWidth = 51;
            this.grdDatosAlumnos.Size = new System.Drawing.Size(677, 300);
            this.grdDatosAlumnos.TabIndex = 4;
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
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 125;
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
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 125;
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
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "EMAIL";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 125;
            // 
            // txtBuscarAlumnos
            // 
            this.txtBuscarAlumnos.Location = new System.Drawing.Point(729, 48);
            this.txtBuscarAlumnos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarAlumnos.Name = "txtBuscarAlumnos";
            this.txtBuscarAlumnos.Size = new System.Drawing.Size(615, 22);
            this.txtBuscarAlumnos.TabIndex = 12;
            this.txtBuscarAlumnos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarAlumnos_KeyUp);
            // 
            // lblBuscarAlumnos
            // 
            this.lblBuscarAlumnos.AutoSize = true;
            this.lblBuscarAlumnos.Location = new System.Drawing.Point(664, 52);
            this.lblBuscarAlumnos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarAlumnos.Name = "lblBuscarAlumnos";
            this.lblBuscarAlumnos.Size = new System.Drawing.Size(52, 16);
            this.lblBuscarAlumnos.TabIndex = 12;
            this.lblBuscarAlumnos.Text = "Buscar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 577);
            this.Controls.Add(this.lblBuscarAlumnos);
            this.Controls.Add(this.txtBuscarAlumnos);
            this.Controls.Add(this.grdDatosAlumnos);
            this.Controls.Add(this.grbEdicion);
            this.Controls.Add(this.grbNavegacion);
            this.Controls.Add(this.grbDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Administracion de Alumnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.grbNavegacion.ResumeLayout(false);
            this.grbNavegacion.PerformLayout();
            this.grbEdicion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.GroupBox grbNavegacion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grbEdicion;
        private System.Windows.Forms.TextBox txtCodigoAlumno;
        private System.Windows.Forms.Label lblCodigoAlumno;
        private System.Windows.Forms.Button btnPrimeroAlumno;
        private System.Windows.Forms.TextBox txtTelefonoAlumno;
        private System.Windows.Forms.Label lblTelefonoAlumno;
        private System.Windows.Forms.TextBox txtDireccionAlumno;
        private System.Windows.Forms.Label lblDireccionAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.TextBox txtEmailAlumno;
        private System.Windows.Forms.Label lblEmailAlumno;
        private System.Windows.Forms.Button btnUltimoAlumno;
        private System.Windows.Forms.Button btnSiguienteAlumno;
        private System.Windows.Forms.Button btnAnteriorAlumno;
        private System.Windows.Forms.Button btnModificarALumno;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Label lblRegistrosAlumnos;
        private System.Windows.Forms.Label lblIdAlumno;
        private System.Windows.Forms.Label idAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.DataGridView grdDatosAlumnos;
        private System.Windows.Forms.TextBox txtBuscarAlumnos;
        private System.Windows.Forms.Label lblBuscarAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}

