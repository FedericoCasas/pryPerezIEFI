namespace pryPerezIEFI
{
    partial class frmLoguin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stlEstadoConeccion = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtdniUsuario = new System.Windows.Forms.TextBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lblContraseñaPerdida = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlEstadoConeccion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 449);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(537, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stlEstadoConeccion
            // 
            this.stlEstadoConeccion.Name = "stlEstadoConeccion";
            this.stlEstadoConeccion.Size = new System.Drawing.Size(0, 16);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(47, 222);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(430, 49);
            this.txtContraseña.TabIndex = 15;
            this.txtContraseña.Text = "\"Ingrese su contraseña\"";
            this.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContraseña.Click += new System.EventHandler(this.txtContraseña_Click);
            // 
            // txtdniUsuario
            // 
            this.txtdniUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdniUsuario.Location = new System.Drawing.Point(99, 114);
            this.txtdniUsuario.Name = "txtdniUsuario";
            this.txtdniUsuario.Size = new System.Drawing.Size(326, 49);
            this.txtdniUsuario.TabIndex = 14;
            this.txtdniUsuario.Text = "\"Ingrese su DNI\"";
            this.txtdniUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdniUsuario.Click += new System.EventHandler(this.txtdniUsuario_Click);
            this.txtdniUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdniUsuario_KeyPress_1);
            // 
            // btnInicio
            // 
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Location = new System.Drawing.Point(99, 326);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(326, 53);
            this.btnInicio.TabIndex = 13;
            this.btnInicio.Text = "inicio de sesion";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // lblContraseñaPerdida
            // 
            this.lblContraseñaPerdida.AutoSize = true;
            this.lblContraseñaPerdida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaPerdida.Location = new System.Drawing.Point(151, 424);
            this.lblContraseñaPerdida.Name = "lblContraseñaPerdida";
            this.lblContraseñaPerdida.Size = new System.Drawing.Size(223, 25);
            this.lblContraseñaPerdida.TabIndex = 12;
            this.lblContraseñaPerdida.Text = "olvidaste tu contraseña?";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.SlateBlue;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(-13, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(550, 94);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "LOGUIN";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // frmLoguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(537, 471);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtdniUsuario);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.lblContraseñaPerdida);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoguin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loguin";
            this.Load += new System.EventHandler(this.Loguin_Load);
            this.Click += new System.EventHandler(this.Loguin_Click);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stlEstadoConeccion;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtdniUsuario;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label lblContraseñaPerdida;
        private System.Windows.Forms.Label lblTitulo;
    }
}

