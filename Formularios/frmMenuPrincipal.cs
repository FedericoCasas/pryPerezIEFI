﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPerezIEFI
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("EVENTO CLOSING DISPARADO");
            try
            {
                string dni = SesionUsuario.IdEmpleado;


                DateTime fechaInicio = SesionUsuario.HoraInicioSesion; //frmLoguin.horaInicioSesion;
                DateTime fechaCierre = DateTime.Now;

                MessageBox.Show($"INSERTANDO:\nDNI: {dni}\nInicio: {fechaInicio}\nCierre: {fechaCierre}");

                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LoguinIEFI.accdb"))
                {
                    conn.Open();

                    string query = "INSERT INTO Sesiones (IdEmpleado, FechaDeInicio, FechaDeCierre) VALUES (?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.Add("@dni", OleDbType.Integer).Value = dni;
                        cmd.Parameters.Add("@fechaInicio", OleDbType.Date).Value = fechaInicio;
                        cmd.Parameters.Add("@fechaCierre", OleDbType.Date).Value = fechaCierre;

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        MessageBox.Show($"Filas insertadas: {filasAfectadas}");

                        //Application.Exit();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar auditoría:\n" + ex.Message);
                //Application.Exit();

            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            /*
            frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
            this.Hide();
            menuPrincipal.Show();
            */
            frmStock frmStock = new frmStock();
            //this.Hide();
            frmStock.ShowDialog();
        }

        private void auditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuditoria frmaudi = new frmAuditoria();

            frmaudi.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrador frmAdministrador = new frmAdministrador();

            frmAdministrador.ShowDialog();
        }

        private void nuevaTareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTareaNueva frmTareaNueva = new frmTareaNueva();

            frmTareaNueva.ShowDialog();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerTareas frmVerTareas = new frmVerTareas();
            frmVerTareas.ShowDialog();
        }

        private void modificarTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarTareas frmModificarTareas = new frmModificarTareas();
            frmModificarTareas.ShowDialog();
        }

        private void reclamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReclamos frmReclamos = new frmReclamos();
            frmReclamos.ShowDialog();
        }
    }
}
