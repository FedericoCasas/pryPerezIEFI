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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rbModificar = new System.Windows.Forms.RadioButton();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblIngreseDni = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cmbOrganizacion = new System.Windows.Forms.ComboBox();
            this.lblOrganizacion = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txxDniBuscado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblIngreseDni.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.SlateBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(496, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(374, 46);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Control de Usuarios";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Location = new System.Drawing.Point(1044, 505);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(181, 43);
            this.btnModificar.TabIndex = 50;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Location = new System.Drawing.Point(748, 504);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(181, 44);
            this.btnEliminar.TabIndex = 51;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.lblSubTitulo.Location = new System.Drawing.Point(499, 43);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(308, 42);
            this.lblSubTitulo.TabIndex = 30;
            this.lblSubTitulo.Text = "Modificar Usuario";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblNombre.Location = new System.Drawing.Point(40, 209);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 37);
            this.lblNombre.TabIndex = 32;
            this.lblNombre.Text = "Dni";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblDescripcion.Location = new System.Drawing.Point(46, 159);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(132, 37);
            this.lblDescripcion.TabIndex = 33;
            this.lblDescripcion.Text = "Nombre";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblStock.Location = new System.Drawing.Point(38, 258);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(141, 37);
            this.lblStock.TabIndex = 34;
            this.lblStock.Text = "Telefono";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblPrecio.Location = new System.Drawing.Point(705, 264);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(105, 37);
            this.lblPrecio.TabIndex = 35;
            this.lblPrecio.Text = "Cargo";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblCategoria.Location = new System.Drawing.Point(2, 16);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(183, 37);
            this.lblCategoria.TabIndex = 36;
            this.lblCategoria.Text = "Contraseña";
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.txtDni.Location = new System.Drawing.Point(281, 206);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(284, 44);
            this.txtDni.TabIndex = 38;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.txtNombre.Location = new System.Drawing.Point(281, 156);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(284, 44);
            this.txtNombre.TabIndex = 39;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.txtTelefono.Location = new System.Drawing.Point(281, 255);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(284, 44);
            this.txtTelefono.TabIndex = 40;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.txtContraseña.Location = new System.Drawing.Point(236, 13);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(284, 44);
            this.txtContraseña.TabIndex = 42;
            this.txtContraseña.Text = "********";
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblEstado.Location = new System.Drawing.Point(38, 314);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(234, 37);
            this.lblEstado.TabIndex = 44;
            this.lblEstado.Text = "Estado Laboral";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(849, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(181, 44);
            this.btnBuscar.TabIndex = 48;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(12, 10);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 69);
            this.btnAgregar.TabIndex = 49;
            this.btnAgregar.Text = "Agregar Usuario";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // rbModificar
            // 
            this.rbModificar.AutoSize = true;
            this.rbModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.rbModificar.Location = new System.Drawing.Point(236, 63);
            this.rbModificar.Name = "rbModificar";
            this.rbModificar.Size = new System.Drawing.Size(120, 29);
            this.rbModificar.TabIndex = 51;
            this.rbModificar.TabStop = true;
            this.rbModificar.Text = "modificar";
            this.rbModificar.UseVisualStyleBackColor = true;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(281, 311);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(284, 45);
            this.cmbEstado.TabIndex = 52;
            // 
            // lblIngreseDni
            // 
            this.lblIngreseDni.BackColor = System.Drawing.Color.AliceBlue;
            this.lblIngreseDni.Controls.Add(this.groupBox2);
            this.lblIngreseDni.Controls.Add(this.cmbOrganizacion);
            this.lblIngreseDni.Controls.Add(this.btnEliminar);
            this.lblIngreseDni.Controls.Add(this.lblOrganizacion);
            this.lblIngreseDni.Controls.Add(this.txtApellido);
            this.lblIngreseDni.Controls.Add(this.btnModificar);
            this.lblIngreseDni.Controls.Add(this.lblApellido);
            this.lblIngreseDni.Controls.Add(this.cmbCargo);
            this.lblIngreseDni.Controls.Add(this.cmbEstado);
            this.lblIngreseDni.Controls.Add(this.lblEstado);
            this.lblIngreseDni.Controls.Add(this.txtTelefono);
            this.lblIngreseDni.Controls.Add(this.txtNombre);
            this.lblIngreseDni.Controls.Add(this.txtDni);
            this.lblIngreseDni.Controls.Add(this.lblPrecio);
            this.lblIngreseDni.Controls.Add(this.lblStock);
            this.lblIngreseDni.Controls.Add(this.lblDescripcion);
            this.lblIngreseDni.Controls.Add(this.lblNombre);
            this.lblIngreseDni.Controls.Add(this.lblSubTitulo);
            this.lblIngreseDni.Location = new System.Drawing.Point(12, 211);
            this.lblIngreseDni.Name = "lblIngreseDni";
            this.lblIngreseDni.Size = new System.Drawing.Size(1341, 632);
            this.lblIngreseDni.TabIndex = 47;
            this.lblIngreseDni.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.rbModificar);
            this.groupBox2.Controls.Add(this.txtContraseña);
            this.groupBox2.Controls.Add(this.lblCategoria);
            this.groupBox2.Location = new System.Drawing.Point(705, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 108);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.radioButton1.Location = new System.Drawing.Point(370, 63);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(150, 29);
            this.radioButton1.TabIndex = 59;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "no modificar";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // cmbOrganizacion
            // 
            this.cmbOrganizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.cmbOrganizacion.FormattingEnabled = true;
            this.cmbOrganizacion.Location = new System.Drawing.Point(939, 206);
            this.cmbOrganizacion.Name = "cmbOrganizacion";
            this.cmbOrganizacion.Size = new System.Drawing.Size(284, 45);
            this.cmbOrganizacion.TabIndex = 58;
            // 
            // lblOrganizacion
            // 
            this.lblOrganizacion.AutoSize = true;
            this.lblOrganizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblOrganizacion.Location = new System.Drawing.Point(705, 208);
            this.lblOrganizacion.Name = "lblOrganizacion";
            this.lblOrganizacion.Size = new System.Drawing.Size(207, 37);
            this.lblOrganizacion.TabIndex = 57;
            this.lblOrganizacion.Text = "Organizacion";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.txtApellido.Location = new System.Drawing.Point(939, 156);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(284, 44);
            this.txtApellido.TabIndex = 56;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblApellido.Location = new System.Drawing.Point(705, 163);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(131, 37);
            this.lblApellido.TabIndex = 55;
            this.lblApellido.Text = "Apellido";
            // 
            // cmbCargo
            // 
            this.cmbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Location = new System.Drawing.Point(939, 261);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(284, 45);
            this.cmbCargo.TabIndex = 54;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.txxDniBuscado);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1341, 123);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            // 
            // txxDniBuscado
            // 
            this.txxDniBuscado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.txxDniBuscado.Location = new System.Drawing.Point(538, 49);
            this.txxDniBuscado.Name = "txxDniBuscado";
            this.txxDniBuscado.Size = new System.Drawing.Size(232, 44);
            this.txxDniBuscado.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(299, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 32);
            this.label10.TabIndex = 31;
            this.label10.Text = "Ingrese el Dni";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(1206, 17);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 49);
            this.btnCancelar.TabIndex = 61;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1363, 865);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblIngreseDni);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdministrador";
            this.Load += new System.EventHandler(this.frmAdministrador_Load);
            this.lblIngreseDni.ResumeLayout(false);
            this.lblIngreseDni.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton rbModificar;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.GroupBox lblIngreseDni;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.ComboBox cmbOrganizacion;
        private System.Windows.Forms.Label lblOrganizacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txxDniBuscado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnCancelar;
    }
}