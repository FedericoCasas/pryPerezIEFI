namespace pryPerezIEFI
{
    partial class frmStock
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
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gbCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.SlateBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(550, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(294, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Control de Stock";
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.lblSubTitulo.Location = new System.Drawing.Point(224, 36);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(232, 42);
            this.lblSubTitulo.TabIndex = 1;
            this.lblSubTitulo.Text = "PRODUCTO";
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblCodigoBarras.Location = new System.Drawing.Point(80, 123);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(153, 37);
            this.lblCodigoBarras.TabIndex = 2;
            this.lblCodigoBarras.Text = "C. Barras";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblNombre.Location = new System.Drawing.Point(80, 212);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(132, 37);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblDescripcion.Location = new System.Drawing.Point(80, 299);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(184, 37);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblStock.Location = new System.Drawing.Point(80, 380);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(211, 37);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Stock ingreso";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblPrecio.Location = new System.Drawing.Point(80, 460);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(93, 37);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Valor";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.lblCategoria.Location = new System.Drawing.Point(80, 545);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(80, 37);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "Tipo";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.txtCodigoBarras.Location = new System.Drawing.Point(334, 116);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(255, 44);
            this.txtCodigoBarras.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.txtNombre.Location = new System.Drawing.Point(334, 209);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(255, 44);
            this.txtNombre.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.txtDescripcion.Location = new System.Drawing.Point(334, 292);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(255, 44);
            this.txtDescripcion.TabIndex = 10;
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.txtStock.Location = new System.Drawing.Point(334, 373);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(255, 44);
            this.txtStock.TabIndex = 11;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.txtValor.Location = new System.Drawing.Point(334, 457);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(255, 44);
            this.txtValor.TabIndex = 12;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(688, 87);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(663, 766);
            this.dgvProductos.TabIndex = 14;
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F);
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Location = new System.Drawing.Point(334, 542);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(255, 45);
            this.cmbTipoProducto.TabIndex = 15;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.2F);
            this.btnNuevoProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNuevoProducto.Location = new System.Drawing.Point(84, 632);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(225, 87);
            this.btnNuevoProducto.TabIndex = 16;
            this.btnNuevoProducto.Text = "Nuevo Producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = false;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // gbCategoria
            // 
            this.gbCategoria.BackColor = System.Drawing.Color.Lavender;
            this.gbCategoria.Controls.Add(this.btnEliminarProducto);
            this.gbCategoria.Controls.Add(this.cmbTipoProducto);
            this.gbCategoria.Controls.Add(this.btnNuevoProducto);
            this.gbCategoria.Controls.Add(this.txtValor);
            this.gbCategoria.Controls.Add(this.txtStock);
            this.gbCategoria.Controls.Add(this.txtDescripcion);
            this.gbCategoria.Controls.Add(this.txtNombre);
            this.gbCategoria.Controls.Add(this.txtCodigoBarras);
            this.gbCategoria.Controls.Add(this.lblCategoria);
            this.gbCategoria.Controls.Add(this.lblPrecio);
            this.gbCategoria.Controls.Add(this.lblStock);
            this.gbCategoria.Controls.Add(this.lblDescripcion);
            this.gbCategoria.Controls.Add(this.lblNombre);
            this.gbCategoria.Controls.Add(this.lblCodigoBarras);
            this.gbCategoria.Controls.Add(this.lblSubTitulo);
            this.gbCategoria.Location = new System.Drawing.Point(12, 87);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(670, 766);
            this.gbCategoria.TabIndex = 17;
            this.gbCategoria.TabStop = false;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.2F);
            this.btnEliminarProducto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarProducto.Location = new System.Drawing.Point(361, 632);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(225, 87);
            this.btnEliminarProducto.TabIndex = 17;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(1206, 24);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 49);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1363, 865);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbCategoria);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStock";
            this.Load += new System.EventHandler(this.frmStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gbCategoria.ResumeLayout(false);
            this.gbCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnCancelar;
    }
}