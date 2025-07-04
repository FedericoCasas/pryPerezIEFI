namespace pryPerezIEFI
{
    partial class frmAdministrador
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rbModificar = new System.Windows.Forms.RadioButton();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.clbPermisos = new System.Windows.Forms.CheckedListBox();
            this.gbUsuarios = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.cbOrganizacion = new System.Windows.Forms.ComboBox();
            this.lblOrganizacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gbUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 612);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(1341, 250);
            this.dgvUsuarios.TabIndex = 29;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Lavender;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.lblTitulo.Location = new System.Drawing.Point(555, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(212, 42);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "USUARIOS";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.btnModificar.Location = new System.Drawing.Point(791, 547);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(262, 56);
            this.btnModificar.TabIndex = 50;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.btnEliminar.Location = new System.Drawing.Point(1097, 547);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(243, 56);
            this.btnEliminar.TabIndex = 51;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.lblSubTitulo.Location = new System.Drawing.Point(24, 18);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(467, 42);
            this.lblSubTitulo.TabIndex = 30;
            this.lblSubTitulo.Text = "CONTROL DE USUARIOS";
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblCodigoBarras.Location = new System.Drawing.Point(17, 83);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(89, 37);
            this.lblCodigoBarras.TabIndex = 31;
            this.lblCodigoBarras.Text = "CUIL";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblNombre.Location = new System.Drawing.Point(17, 146);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(72, 37);
            this.lblNombre.TabIndex = 32;
            this.lblNombre.Text = "DNI";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblDescripcion.Location = new System.Drawing.Point(343, 87);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(156, 37);
            this.lblDescripcion.TabIndex = 33;
            this.lblDescripcion.Text = "NOMBRE";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblStock.Location = new System.Drawing.Point(343, 150);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(191, 37);
            this.lblStock.TabIndex = 34;
            this.lblStock.Text = "TELEFONO";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblPrecio.Location = new System.Drawing.Point(623, 299);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(134, 37);
            this.lblPrecio.TabIndex = 35;
            this.lblPrecio.Text = "CARGO";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblCategoria.Location = new System.Drawing.Point(308, 253);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(241, 37);
            this.lblCategoria.TabIndex = 36;
            this.lblCategoria.Text = "CONTRASEÑA";
            // 
            // txtCuil
            // 
            this.txtCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.txtCuil.Location = new System.Drawing.Point(120, 80);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(165, 44);
            this.txtCuil.TabIndex = 37;
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.txtDni.Location = new System.Drawing.Point(109, 143);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(196, 44);
            this.txtDni.TabIndex = 38;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.txtNombre.Location = new System.Drawing.Point(532, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(232, 44);
            this.txtNombre.TabIndex = 39;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.txtTelefono.Location = new System.Drawing.Point(567, 147);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(244, 44);
            this.txtTelefono.TabIndex = 40;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.txtContraseña.Location = new System.Drawing.Point(301, 312);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(248, 44);
            this.txtContraseña.TabIndex = 42;
            this.txtContraseña.Text = "********";
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPermisos
            // 
            this.lblPermisos.AutoSize = true;
            this.lblPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblPermisos.Location = new System.Drawing.Point(40, 244);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.Size = new System.Drawing.Size(182, 37);
            this.lblPermisos.TabIndex = 43;
            this.lblPermisos.Text = "PERMISOS";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblEstado.Location = new System.Drawing.Point(837, 150);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(149, 37);
            this.lblEstado.TabIndex = 44;
            this.lblEstado.Text = "ESTADO";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.btnBuscar.Location = new System.Drawing.Point(779, 364);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(243, 56);
            this.btnBuscar.TabIndex = 48;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.btnAgregar.Location = new System.Drawing.Point(1085, 364);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(243, 56);
            this.btnAgregar.TabIndex = 49;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rbModificar
            // 
            this.rbModificar.AutoSize = true;
            this.rbModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.rbModificar.Location = new System.Drawing.Point(301, 364);
            this.rbModificar.Name = "rbModificar";
            this.rbModificar.Size = new System.Drawing.Size(233, 29);
            this.rbModificar.TabIndex = 51;
            this.rbModificar.TabStop = true;
            this.rbModificar.Text = "modificar contraseña";
            this.rbModificar.UseVisualStyleBackColor = true;
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado.Location = new System.Drawing.Point(1015, 146);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(195, 45);
            this.cbEstado.TabIndex = 52;
            // 
            // clbPermisos
            // 
            this.clbPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.clbPermisos.FormattingEnabled = true;
            this.clbPermisos.Items.AddRange(new object[] {
            "Basico",
            "Auditor",
            "Reclamos",
            "Administrativo"});
            this.clbPermisos.Location = new System.Drawing.Point(31, 284);
            this.clbPermisos.Name = "clbPermisos";
            this.clbPermisos.Size = new System.Drawing.Size(202, 108);
            this.clbPermisos.TabIndex = 53;
            // 
            // gbUsuarios
            // 
            this.gbUsuarios.BackColor = System.Drawing.Color.AliceBlue;
            this.gbUsuarios.Controls.Add(this.cbOrganizacion);
            this.gbUsuarios.Controls.Add(this.lblOrganizacion);
            this.gbUsuarios.Controls.Add(this.txtApellido);
            this.gbUsuarios.Controls.Add(this.lblApellido);
            this.gbUsuarios.Controls.Add(this.cbCargo);
            this.gbUsuarios.Controls.Add(this.clbPermisos);
            this.gbUsuarios.Controls.Add(this.cbEstado);
            this.gbUsuarios.Controls.Add(this.rbModificar);
            this.gbUsuarios.Controls.Add(this.btnAgregar);
            this.gbUsuarios.Controls.Add(this.btnBuscar);
            this.gbUsuarios.Controls.Add(this.lblEstado);
            this.gbUsuarios.Controls.Add(this.lblPermisos);
            this.gbUsuarios.Controls.Add(this.txtContraseña);
            this.gbUsuarios.Controls.Add(this.txtTelefono);
            this.gbUsuarios.Controls.Add(this.txtNombre);
            this.gbUsuarios.Controls.Add(this.txtDni);
            this.gbUsuarios.Controls.Add(this.txtCuil);
            this.gbUsuarios.Controls.Add(this.lblCategoria);
            this.gbUsuarios.Controls.Add(this.lblPrecio);
            this.gbUsuarios.Controls.Add(this.lblStock);
            this.gbUsuarios.Controls.Add(this.lblDescripcion);
            this.gbUsuarios.Controls.Add(this.lblNombre);
            this.gbUsuarios.Controls.Add(this.lblCodigoBarras);
            this.gbUsuarios.Controls.Add(this.lblSubTitulo);
            this.gbUsuarios.Location = new System.Drawing.Point(12, 90);
            this.gbUsuarios.Name = "gbUsuarios";
            this.gbUsuarios.Size = new System.Drawing.Size(1341, 451);
            this.gbUsuarios.TabIndex = 47;
            this.gbUsuarios.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(1251, 10);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(102, 69);
            this.btnVolver.TabIndex = 52;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cbCargo
            // 
            this.cbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Jefe de Area",
            "Administrativo",
            "Coordinador",
            "Contaduria",
            "Aux Administrativo",
            "Soporte IT",
            "Soporte Redes",
            "",
            ""});
            this.cbCargo.Location = new System.Drawing.Point(779, 296);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(227, 45);
            this.cbCargo.TabIndex = 54;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.txtApellido.Location = new System.Drawing.Point(994, 76);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(232, 44);
            this.txtApellido.TabIndex = 56;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblApellido.Location = new System.Drawing.Point(805, 83);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(173, 37);
            this.lblApellido.TabIndex = 55;
            this.lblApellido.Text = "APELLIDO";
            // 
            // cbOrganizacion
            // 
            this.cbOrganizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.cbOrganizacion.FormattingEnabled = true;
            this.cbOrganizacion.Items.AddRange(new object[] {
            "Gobierno",
            "Tercearizada",
            "Gubernamental"});
            this.cbOrganizacion.Location = new System.Drawing.Point(886, 221);
            this.cbOrganizacion.Name = "cbOrganizacion";
            this.cbOrganizacion.Size = new System.Drawing.Size(221, 45);
            this.cbOrganizacion.TabIndex = 58;
            // 
            // lblOrganizacion
            // 
            this.lblOrganizacion.AutoSize = true;
            this.lblOrganizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblOrganizacion.Location = new System.Drawing.Point(615, 229);
            this.lblOrganizacion.Name = "lblOrganizacion";
            this.lblOrganizacion.Size = new System.Drawing.Size(265, 37);
            this.lblOrganizacion.TabIndex = 57;
            this.lblOrganizacion.Text = "ORGANIZACION";
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1363, 865);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gbUsuarios);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdministrador";
            this.Load += new System.EventHandler(this.frmAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gbUsuarios.ResumeLayout(false);
            this.gbUsuarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblPermisos;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton rbModificar;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.CheckedListBox clbPermisos;
        private System.Windows.Forms.GroupBox gbUsuarios;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.ComboBox cbOrganizacion;
        private System.Windows.Forms.Label lblOrganizacion;
    }
}