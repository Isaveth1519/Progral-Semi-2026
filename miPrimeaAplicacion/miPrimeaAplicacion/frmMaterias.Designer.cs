namespace miPrimeaAplicacion
{
    partial class frmMaterias
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
            this.lblBuscarMaterias = new System.Windows.Forms.Label();
            this.txtBuscarMaterias = new System.Windows.Forms.TextBox();
            this.grdDatosMaterias = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbEdicion = new System.Windows.Forms.GroupBox();
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.btnModificarMateria = new System.Windows.Forms.Button();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.grbNavegacion = new System.Windows.Forms.GroupBox();
            this.lblRegistrosMateria = new System.Windows.Forms.Label();
            this.btnUltimoMateria = new System.Windows.Forms.Button();
            this.btnSiguienteMateria = new System.Windows.Forms.Button();
            this.btnAnteriorMateria = new System.Windows.Forms.Button();
            this.btnPrimeroMateria = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.idMateria = new System.Windows.Forms.Label();
            this.lblIdMateria = new System.Windows.Forms.Label();
            this.txtUvMateria = new System.Windows.Forms.TextBox();
            this.lblUvMateria = new System.Windows.Forms.Label();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.txtCodigoMateria = new System.Windows.Forms.TextBox();
            this.lblCodigoMateria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosMaterias)).BeginInit();
            this.grbEdicion.SuspendLayout();
            this.grbNavegacion.SuspendLayout();
            this.grbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBuscarMaterias
            // 
            this.lblBuscarMaterias.AutoSize = true;
            this.lblBuscarMaterias.Location = new System.Drawing.Point(635, 39);
            this.lblBuscarMaterias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarMaterias.Name = "lblBuscarMaterias";
            this.lblBuscarMaterias.Size = new System.Drawing.Size(52, 16);
            this.lblBuscarMaterias.TabIndex = 17;
            this.lblBuscarMaterias.Text = "Buscar:";
            // 
            // txtBuscarMaterias
            // 
            this.txtBuscarMaterias.Location = new System.Drawing.Point(700, 36);
            this.txtBuscarMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarMaterias.Name = "txtBuscarMaterias";
            this.txtBuscarMaterias.Size = new System.Drawing.Size(531, 22);
            this.txtBuscarMaterias.TabIndex = 18;
            this.txtBuscarMaterias.TextChanged += new System.EventHandler(this.txtBuscarMaterias_TextChanged);
            this.txtBuscarMaterias.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarMaterias_KeyUp);
            // 
            // grdDatosMaterias
            // 
            this.grdDatosMaterias.AllowUserToAddRows = false;
            this.grdDatosMaterias.AllowUserToDeleteRows = false;
            this.grdDatosMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nombre,
            this.direccion});
            this.grdDatosMaterias.Location = new System.Drawing.Point(639, 76);
            this.grdDatosMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdDatosMaterias.Name = "grdDatosMaterias";
            this.grdDatosMaterias.ReadOnly = true;
            this.grdDatosMaterias.RowHeadersWidth = 51;
            this.grdDatosMaterias.Size = new System.Drawing.Size(593, 300);
            this.grdDatosMaterias.TabIndex = 16;
            // 
            // id
            // 
            this.id.DataPropertyName = "idMateria";
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
            this.nombre.Width = 200;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "uv";
            this.direccion.HeaderText = "UV";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 60;
            // 
            // grbEdicion
            // 
            this.grbEdicion.Controls.Add(this.btnEliminarMateria);
            this.grbEdicion.Controls.Add(this.btnModificarMateria);
            this.grbEdicion.Controls.Add(this.btnAgregarMateria);
            this.grbEdicion.Location = new System.Drawing.Point(301, 398);
            this.grbEdicion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbEdicion.Name = "grbEdicion";
            this.grbEdicion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbEdicion.Size = new System.Drawing.Size(391, 75);
            this.grbEdicion.TabIndex = 15;
            this.grbEdicion.TabStop = false;
            this.grbEdicion.Text = "Edicion";
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMateria.Location = new System.Drawing.Point(253, 25);
            this.btnEliminarMateria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(127, 44);
            this.btnEliminarMateria.TabIndex = 9;
            this.btnEliminarMateria.Text = "Eliminar";
            this.btnEliminarMateria.UseVisualStyleBackColor = true;
            this.btnEliminarMateria.Click += new System.EventHandler(this.btnEliminarMateria_Click);
            // 
            // btnModificarMateria
            // 
            this.btnModificarMateria.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMateria.Location = new System.Drawing.Point(119, 23);
            this.btnModificarMateria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificarMateria.Name = "btnModificarMateria";
            this.btnModificarMateria.Size = new System.Drawing.Size(127, 44);
            this.btnModificarMateria.TabIndex = 8;
            this.btnModificarMateria.Text = "Modificar";
            this.btnModificarMateria.UseVisualStyleBackColor = true;
            this.btnModificarMateria.Click += new System.EventHandler(this.btnModificarMateria_Click);
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMateria.Location = new System.Drawing.Point(4, 23);
            this.btnAgregarMateria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(112, 44);
            this.btnAgregarMateria.TabIndex = 7;
            this.btnAgregarMateria.Text = "Agregar";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // grbNavegacion
            // 
            this.grbNavegacion.Controls.Add(this.lblRegistrosMateria);
            this.grbNavegacion.Controls.Add(this.btnUltimoMateria);
            this.grbNavegacion.Controls.Add(this.btnSiguienteMateria);
            this.grbNavegacion.Controls.Add(this.btnAnteriorMateria);
            this.grbNavegacion.Controls.Add(this.btnPrimeroMateria);
            this.grbNavegacion.Controls.Add(this.groupBox3);
            this.grbNavegacion.Location = new System.Drawing.Point(8, 398);
            this.grbNavegacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbNavegacion.Size = new System.Drawing.Size(277, 75);
            this.grbNavegacion.TabIndex = 14;
            this.grbNavegacion.TabStop = false;
            this.grbNavegacion.Text = "Navegacion";
            // 
            // lblRegistrosMateria
            // 
            this.lblRegistrosMateria.AutoSize = true;
            this.lblRegistrosMateria.Location = new System.Drawing.Point(111, 46);
            this.lblRegistrosMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrosMateria.Name = "lblRegistrosMateria";
            this.lblRegistrosMateria.Size = new System.Drawing.Size(42, 16);
            this.lblRegistrosMateria.TabIndex = 10;
            this.lblRegistrosMateria.Text = "x de n";
            // 
            // btnUltimoMateria
            // 
            this.btnUltimoMateria.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoMateria.Location = new System.Drawing.Point(225, 25);
            this.btnUltimoMateria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUltimoMateria.Name = "btnUltimoMateria";
            this.btnUltimoMateria.Size = new System.Drawing.Size(52, 50);
            this.btnUltimoMateria.TabIndex = 6;
            this.btnUltimoMateria.Text = ">|";
            this.btnUltimoMateria.UseVisualStyleBackColor = true;
            this.btnUltimoMateria.Click += new System.EventHandler(this.btnUltimoMateria_Click);
            // 
            // btnSiguienteMateria
            // 
            this.btnSiguienteMateria.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteMateria.Location = new System.Drawing.Point(177, 25);
            this.btnSiguienteMateria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiguienteMateria.Name = "btnSiguienteMateria";
            this.btnSiguienteMateria.Size = new System.Drawing.Size(52, 50);
            this.btnSiguienteMateria.TabIndex = 5;
            this.btnSiguienteMateria.Text = ">";
            this.btnSiguienteMateria.UseVisualStyleBackColor = true;
            this.btnSiguienteMateria.Click += new System.EventHandler(this.btnSiguienteMateria_Click);
            // 
            // btnAnteriorMateria
            // 
            this.btnAnteriorMateria.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorMateria.Location = new System.Drawing.Point(51, 25);
            this.btnAnteriorMateria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnteriorMateria.Name = "btnAnteriorMateria";
            this.btnAnteriorMateria.Size = new System.Drawing.Size(52, 50);
            this.btnAnteriorMateria.TabIndex = 4;
            this.btnAnteriorMateria.Text = "<";
            this.btnAnteriorMateria.UseVisualStyleBackColor = true;
            this.btnAnteriorMateria.Click += new System.EventHandler(this.btnAnteriorMateria_Click);
            // 
            // btnPrimeroMateria
            // 
            this.btnPrimeroMateria.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroMateria.Location = new System.Drawing.Point(3, 25);
            this.btnPrimeroMateria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrimeroMateria.Name = "btnPrimeroMateria";
            this.btnPrimeroMateria.Size = new System.Drawing.Size(52, 50);
            this.btnPrimeroMateria.TabIndex = 3;
            this.btnPrimeroMateria.Text = "|<";
            this.btnPrimeroMateria.UseVisualStyleBackColor = true;
            this.btnPrimeroMateria.Click += new System.EventHandler(this.btnPrimeroMateria_Click);
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
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.idMateria);
            this.grbDatos.Controls.Add(this.lblIdMateria);
            this.grbDatos.Controls.Add(this.txtUvMateria);
            this.grbDatos.Controls.Add(this.lblUvMateria);
            this.grbDatos.Controls.Add(this.txtNombreMateria);
            this.grbDatos.Controls.Add(this.lblNombreMateria);
            this.grbDatos.Controls.Add(this.txtCodigoMateria);
            this.grbDatos.Controls.Add(this.lblCodigoMateria);
            this.grbDatos.Enabled = false;
            this.grbDatos.Location = new System.Drawing.Point(8, 20);
            this.grbDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbDatos.Size = new System.Drawing.Size(601, 357);
            this.grbDatos.TabIndex = 13;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "DATOS";
            // 
            // idMateria
            // 
            this.idMateria.AutoSize = true;
            this.idMateria.Location = new System.Drawing.Point(121, 78);
            this.idMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idMateria.Name = "idMateria";
            this.idMateria.Size = new System.Drawing.Size(14, 16);
            this.idMateria.TabIndex = 11;
            this.idMateria.Text = "0";
            // 
            // lblIdMateria
            // 
            this.lblIdMateria.AutoSize = true;
            this.lblIdMateria.Location = new System.Drawing.Point(16, 78);
            this.lblIdMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdMateria.Name = "lblIdMateria";
            this.lblIdMateria.Size = new System.Drawing.Size(23, 16);
            this.lblIdMateria.TabIndex = 10;
            this.lblIdMateria.Text = "ID:";
            // 
            // txtUvMateria
            // 
            this.txtUvMateria.Location = new System.Drawing.Point(115, 210);
            this.txtUvMateria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUvMateria.Name = "txtUvMateria";
            this.txtUvMateria.Size = new System.Drawing.Size(197, 22);
            this.txtUvMateria.TabIndex = 9;
            this.txtUvMateria.TextChanged += new System.EventHandler(this.txtUvMateria_TextChanged);
            // 
            // lblUvMateria
            // 
            this.lblUvMateria.AutoSize = true;
            this.lblUvMateria.Location = new System.Drawing.Point(16, 214);
            this.lblUvMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUvMateria.Name = "lblUvMateria";
            this.lblUvMateria.Size = new System.Drawing.Size(29, 16);
            this.lblUvMateria.TabIndex = 8;
            this.lblUvMateria.Text = "UV:";
            this.lblUvMateria.Click += new System.EventHandler(this.lblUvMateria_Click);
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(115, 155);
            this.txtNombreMateria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(361, 22);
            this.txtNombreMateria.TabIndex = 3;
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.Location = new System.Drawing.Point(16, 159);
            this.lblNombreMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(69, 16);
            this.lblNombreMateria.TabIndex = 2;
            this.lblNombreMateria.Text = "NOMBRE:";
            // 
            // txtCodigoMateria
            // 
            this.txtCodigoMateria.Location = new System.Drawing.Point(115, 111);
            this.txtCodigoMateria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoMateria.Name = "txtCodigoMateria";
            this.txtCodigoMateria.Size = new System.Drawing.Size(197, 22);
            this.txtCodigoMateria.TabIndex = 1;
            // 
            // lblCodigoMateria
            // 
            this.lblCodigoMateria.AutoSize = true;
            this.lblCodigoMateria.Location = new System.Drawing.Point(16, 114);
            this.lblCodigoMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoMateria.Name = "lblCodigoMateria";
            this.lblCodigoMateria.Size = new System.Drawing.Size(62, 16);
            this.lblCodigoMateria.TabIndex = 0;
            this.lblCodigoMateria.Text = "CODIGO:";
            // 
            // frmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 507);
            this.Controls.Add(this.lblBuscarMaterias);
            this.Controls.Add(this.txtBuscarMaterias);
            this.Controls.Add(this.grdDatosMaterias);
            this.Controls.Add(this.grbEdicion);
            this.Controls.Add(this.grbNavegacion);
            this.Controls.Add(this.grbDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMaterias";
            this.Text = "Administracion de Materias";
            this.Load += new System.EventHandler(this.frmMaterias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosMaterias)).EndInit();
            this.grbEdicion.ResumeLayout(false);
            this.grbNavegacion.ResumeLayout(false);
            this.grbNavegacion.PerformLayout();
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarMaterias;
        private System.Windows.Forms.TextBox txtBuscarMaterias;
        private System.Windows.Forms.DataGridView grdDatosMaterias;
        private System.Windows.Forms.GroupBox grbEdicion;
        private System.Windows.Forms.Button btnEliminarMateria;
        private System.Windows.Forms.Button btnModificarMateria;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.GroupBox grbNavegacion;
        private System.Windows.Forms.Label lblRegistrosMateria;
        private System.Windows.Forms.Button btnUltimoMateria;
        private System.Windows.Forms.Button btnSiguienteMateria;
        private System.Windows.Forms.Button btnAnteriorMateria;
        private System.Windows.Forms.Button btnPrimeroMateria;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Label idMateria;
        private System.Windows.Forms.Label lblIdMateria;
        private System.Windows.Forms.TextBox txtUvMateria;
        private System.Windows.Forms.Label lblUvMateria;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.Label lblNombreMateria;
        private System.Windows.Forms.TextBox txtCodigoMateria;
        private System.Windows.Forms.Label lblCodigoMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
    }
}