namespace pryPerezIEFI
{
    partial class frmTareaNueva
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbTareas = new System.Windows.Forms.ComboBox();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.chkPrioridad = new System.Windows.Forms.CheckBox();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.lblInsumo = new System.Windows.Forms.Label();
            this.chkInsumo = new System.Windows.Forms.CheckBox();
            this.lblUniforme = new System.Windows.Forms.Label();
            this.chkUniforme = new System.Windows.Forms.CheckBox();
            this.lblEstudio = new System.Windows.Forms.Label();
            this.chkEstudio = new System.Windows.Forms.CheckBox();
            this.lblSupervicion = new System.Windows.Forms.Label();
            this.chkSupervision = new System.Windows.Forms.CheckBox();
            this.lblPresencial = new System.Windows.Forms.Label();
            this.chkPresencial = new System.Windows.Forms.CheckBox();
            this.grbDetalle = new System.Windows.Forms.GroupBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.gdbUsuarioTarea = new System.Windows.Forms.GroupBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.RichTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAuditoria = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.grbDetalle.SuspendLayout();
            this.gdbUsuarioTarea.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(36, 147);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(552, 41);
            this.dtpFecha.TabIndex = 0;
            // 
            // cmbTareas
            // 
            this.cmbTareas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTareas.FormattingEnabled = true;
            this.cmbTareas.Location = new System.Drawing.Point(142, 255);
            this.cmbTareas.Name = "cmbTareas";
            this.cmbTareas.Size = new System.Drawing.Size(333, 44);
            this.cmbTareas.TabIndex = 1;
            // 
            // dgvTareas
            // 
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(29, 551);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.RowTemplate.Height = 24;
            this.dgvTareas.Size = new System.Drawing.Size(1288, 194);
            this.dgvTareas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tareas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Detalle";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Location = new System.Drawing.Point(1145, 496);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(145, 49);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lugar";
            // 
            // cmbLugar
            // 
            this.cmbLugar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Location = new System.Drawing.Point(142, 195);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(333, 44);
            this.cmbLugar.TabIndex = 7;
            // 
            // chkPrioridad
            // 
            this.chkPrioridad.AutoSize = true;
            this.chkPrioridad.Location = new System.Drawing.Point(265, 30);
            this.chkPrioridad.Name = "chkPrioridad";
            this.chkPrioridad.Size = new System.Drawing.Size(18, 17);
            this.chkPrioridad.TabIndex = 10;
            this.chkPrioridad.UseVisualStyleBackColor = true;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridad.Location = new System.Drawing.Point(9, 13);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(196, 36);
            this.lblPrioridad.TabIndex = 13;
            this.lblPrioridad.Text = "Prioridad Alta";
            // 
            // lblInsumo
            // 
            this.lblInsumo.AutoSize = true;
            this.lblInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsumo.Location = new System.Drawing.Point(9, 62);
            this.lblInsumo.Name = "lblInsumo";
            this.lblInsumo.Size = new System.Drawing.Size(112, 36);
            this.lblInsumo.TabIndex = 15;
            this.lblInsumo.Text = "Insumo";
            // 
            // chkInsumo
            // 
            this.chkInsumo.AutoSize = true;
            this.chkInsumo.Location = new System.Drawing.Point(265, 79);
            this.chkInsumo.Name = "chkInsumo";
            this.chkInsumo.Size = new System.Drawing.Size(18, 17);
            this.chkInsumo.TabIndex = 14;
            this.chkInsumo.UseVisualStyleBackColor = true;
            // 
            // lblUniforme
            // 
            this.lblUniforme.AutoSize = true;
            this.lblUniforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniforme.Location = new System.Drawing.Point(9, 120);
            this.lblUniforme.Name = "lblUniforme";
            this.lblUniforme.Size = new System.Drawing.Size(237, 36);
            this.lblUniforme.TabIndex = 17;
            this.lblUniforme.Text = "Uniforme (pauta)";
            // 
            // chkUniforme
            // 
            this.chkUniforme.AutoSize = true;
            this.chkUniforme.Location = new System.Drawing.Point(265, 137);
            this.chkUniforme.Name = "chkUniforme";
            this.chkUniforme.Size = new System.Drawing.Size(18, 17);
            this.chkUniforme.TabIndex = 16;
            this.chkUniforme.UseVisualStyleBackColor = true;
            // 
            // lblEstudio
            // 
            this.lblEstudio.AutoSize = true;
            this.lblEstudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudio.Location = new System.Drawing.Point(328, 13);
            this.lblEstudio.Name = "lblEstudio";
            this.lblEstudio.Size = new System.Drawing.Size(116, 36);
            this.lblEstudio.TabIndex = 19;
            this.lblEstudio.Text = "Estudio";
            // 
            // chkEstudio
            // 
            this.chkEstudio.AutoSize = true;
            this.chkEstudio.Location = new System.Drawing.Point(647, 30);
            this.chkEstudio.Name = "chkEstudio";
            this.chkEstudio.Size = new System.Drawing.Size(18, 17);
            this.chkEstudio.TabIndex = 18;
            this.chkEstudio.UseVisualStyleBackColor = true;
            // 
            // lblSupervicion
            // 
            this.lblSupervicion.AutoSize = true;
            this.lblSupervicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupervicion.Location = new System.Drawing.Point(328, 62);
            this.lblSupervicion.Name = "lblSupervicion";
            this.lblSupervicion.Size = new System.Drawing.Size(302, 36);
            this.lblSupervicion.TabIndex = 21;
            this.lblSupervicion.Text = "Requiere Supervisión";
            // 
            // chkSupervision
            // 
            this.chkSupervision.AutoSize = true;
            this.chkSupervision.Location = new System.Drawing.Point(647, 79);
            this.chkSupervision.Name = "chkSupervision";
            this.chkSupervision.Size = new System.Drawing.Size(18, 17);
            this.chkSupervision.TabIndex = 20;
            this.chkSupervision.UseVisualStyleBackColor = true;
            // 
            // lblPresencial
            // 
            this.lblPresencial.AutoSize = true;
            this.lblPresencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresencial.Location = new System.Drawing.Point(328, 120);
            this.lblPresencial.Name = "lblPresencial";
            this.lblPresencial.Size = new System.Drawing.Size(154, 36);
            this.lblPresencial.TabIndex = 23;
            this.lblPresencial.Text = "Presencial";
            // 
            // chkPresencial
            // 
            this.chkPresencial.AutoSize = true;
            this.chkPresencial.Location = new System.Drawing.Point(647, 137);
            this.chkPresencial.Name = "chkPresencial";
            this.chkPresencial.Size = new System.Drawing.Size(18, 17);
            this.chkPresencial.TabIndex = 22;
            this.chkPresencial.UseVisualStyleBackColor = true;
            // 
            // grbDetalle
            // 
            this.grbDetalle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grbDetalle.Controls.Add(this.lblPresencial);
            this.grbDetalle.Controls.Add(this.chkPresencial);
            this.grbDetalle.Controls.Add(this.lblSupervicion);
            this.grbDetalle.Controls.Add(this.chkSupervision);
            this.grbDetalle.Controls.Add(this.lblEstudio);
            this.grbDetalle.Controls.Add(this.chkEstudio);
            this.grbDetalle.Controls.Add(this.lblUniforme);
            this.grbDetalle.Controls.Add(this.chkUniforme);
            this.grbDetalle.Controls.Add(this.lblInsumo);
            this.grbDetalle.Controls.Add(this.chkInsumo);
            this.grbDetalle.Controls.Add(this.lblPrioridad);
            this.grbDetalle.Controls.Add(this.chkPrioridad);
            this.grbDetalle.Location = new System.Drawing.Point(594, 138);
            this.grbDetalle.Name = "grbDetalle";
            this.grbDetalle.Size = new System.Drawing.Size(688, 171);
            this.grbDetalle.TabIndex = 24;
            this.grbDetalle.TabStop = false;
            // 
            // txtDni
            // 
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(335, 16);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(226, 41);
            this.txtDni.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 36);
            this.label5.TabIndex = 27;
            this.label5.Text = "Empleado Asignado: ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(582, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(145, 49);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(853, 21);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(25, 36);
            this.lblEmpleado.TabIndex = 30;
            this.lblEmpleado.Text = "-";
            // 
            // gdbUsuarioTarea
            // 
            this.gdbUsuarioTarea.BackColor = System.Drawing.Color.Lavender;
            this.gdbUsuarioTarea.Controls.Add(this.label8);
            this.gdbUsuarioTarea.Controls.Add(this.lblEmpleado);
            this.gdbUsuarioTarea.Controls.Add(this.btnBuscar);
            this.gdbUsuarioTarea.Controls.Add(this.label5);
            this.gdbUsuarioTarea.Controls.Add(this.txtDni);
            this.gdbUsuarioTarea.Controls.Add(this.grbDetalle);
            this.gdbUsuarioTarea.Controls.Add(this.label3);
            this.gdbUsuarioTarea.Controls.Add(this.label4);
            this.gdbUsuarioTarea.Controls.Add(this.label2);
            this.gdbUsuarioTarea.Controls.Add(this.cmbLugar);
            this.gdbUsuarioTarea.Controls.Add(this.label1);
            this.gdbUsuarioTarea.Controls.Add(this.cmbTareas);
            this.gdbUsuarioTarea.Controls.Add(this.dtpFecha);
            this.gdbUsuarioTarea.Location = new System.Drawing.Point(29, 51);
            this.gdbUsuarioTarea.Name = "gdbUsuarioTarea";
            this.gdbUsuarioTarea.Size = new System.Drawing.Size(1288, 328);
            this.gdbUsuarioTarea.TabIndex = 31;
            this.gdbUsuarioTarea.TabStop = false;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblComentario.Location = new System.Drawing.Point(56, 382);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(167, 36);
            this.lblComentario.TabIndex = 33;
            this.lblComentario.Text = "Comentario";
            // 
            // txtComentario
            // 
            this.txtComentario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.Location = new System.Drawing.Point(29, 421);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(1288, 63);
            this.txtComentario.TabIndex = 32;
            this.txtComentario.Text = "";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(1145, 757);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 49);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnGrabar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGrabar.Location = new System.Drawing.Point(957, 757);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(145, 49);
            this.btnGrabar.TabIndex = 35;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(59, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 36);
            this.label7.TabIndex = 34;
            this.label7.Text = "Tareas por Cargar";
            // 
            // lblAuditoria
            // 
            this.lblAuditoria.AutoSize = true;
            this.lblAuditoria.BackColor = System.Drawing.Color.SlateBlue;
            this.lblAuditoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.lblAuditoria.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAuditoria.Location = new System.Drawing.Point(463, 6);
            this.lblAuditoria.Name = "lblAuditoria";
            this.lblAuditoria.Size = new System.Drawing.Size(422, 42);
            this.lblAuditoria.TabIndex = 36;
            this.lblAuditoria.Text = "Establecer Nueva Tarea";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SlateBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(198, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(428, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "establecer busqueda de empleado para establecer tarea";
            // 
            // frmTareaNueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1345, 818);
            this.Controls.Add(this.lblAuditoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.gdbUsuarioTarea);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTareaNueva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTareaNueva";
            this.Load += new System.EventHandler(this.frmTareaNueva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.grbDetalle.ResumeLayout(false);
            this.grbDetalle.PerformLayout();
            this.gdbUsuarioTarea.ResumeLayout(false);
            this.gdbUsuarioTarea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbTareas;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLugar;
        private System.Windows.Forms.CheckBox chkPrioridad;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.Label lblInsumo;
        private System.Windows.Forms.CheckBox chkInsumo;
        private System.Windows.Forms.Label lblUniforme;
        private System.Windows.Forms.CheckBox chkUniforme;
        private System.Windows.Forms.Label lblEstudio;
        private System.Windows.Forms.CheckBox chkEstudio;
        private System.Windows.Forms.Label lblSupervicion;
        private System.Windows.Forms.CheckBox chkSupervision;
        private System.Windows.Forms.Label lblPresencial;
        private System.Windows.Forms.CheckBox chkPresencial;
        private System.Windows.Forms.GroupBox grbDetalle;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.GroupBox gdbUsuarioTarea;
        private System.Windows.Forms.RichTextBox txtComentario;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAuditoria;
        private System.Windows.Forms.Label label8;
    }
}