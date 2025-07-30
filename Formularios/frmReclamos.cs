using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPerezIEFI
{
    public partial class frmReclamos : Form
    {
        public frmReclamos()
        {
            InitializeComponent();
        }
        int idEmpleadoSeleccionado = -1;
        private void CargarComboTipoReclamo()
        {
            using (OleDbConnection conn = new OleDbConnection(Conexion.ObtenerCadena()))
            {
                string consulta = "SELECT * FROM TipoReclamo";
                OleDbDataAdapter da = new OleDbDataAdapter(consulta, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbTipoReclamo.DataSource = dt;
                cmbTipoReclamo.DisplayMember = "NombreTipoReclamo";
                cmbTipoReclamo.ValueMember = "IdTipoReclamo";
            }
        }

        private void frmReclamos_Load(object sender, EventArgs e)
        {
            CargarComboTipoReclamo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Ingresá un DNI para buscar.");
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(Conexion.ObtenerCadena()))
                {
                    conn.Open();
                    string consulta = "SELECT DniEmpleado, Nombre FROM Empleado WHERE DniEmpleado = ?";
                    OleDbCommand cmd = new OleDbCommand(consulta, conn);
                    cmd.Parameters.AddWithValue("?", txtDni.Text.Trim());

                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        idEmpleadoSeleccionado = Convert.ToInt32(reader["DniEmpleado"]); // Usamos DniEmpleado como ID
                        lblEmpleado.Text = reader["Nombre"].ToString();
                        CargarReclamosEmpleado(idEmpleadoSeleccionado);
                    }
                    else
                    {
                        MessageBox.Show("Empleado no encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar empleado: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (idEmpleadoSeleccionado == -1 || cmbTipoReclamo.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Completar todos los campos.");
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(Conexion.ObtenerCadena()))
            {
                conn.Open();
                string consulta = @"INSERT INTO Reclamos (IdEmpleado, IdTipoReclamo, Descripcion, FechaReclamo)
                            VALUES (?, ?, ?, ?)";

                OleDbCommand cmd = new OleDbCommand(consulta, conn);
                cmd.Parameters.AddWithValue("?", idEmpleadoSeleccionado);
                cmd.Parameters.AddWithValue("?", cmbTipoReclamo.SelectedValue);
                cmd.Parameters.AddWithValue("?", txtDescripcion.Text.Trim());
                cmd.Parameters.AddWithValue("?", dtpFechaReclamo.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Reclamo registrado correctamente.");
                CargarReclamosEmpleado(idEmpleadoSeleccionado);
            }
        }
        private void CargarReclamosEmpleado(int idEmpleado)
        {
            using (OleDbConnection conn = new OleDbConnection(Conexion.ObtenerCadena()))
            {
                string consulta = @"
            SELECT R.IdReclamo, T.NombreTipoReclamo, R.Descripcion, R.FechaReclamo
            FROM Reclamos R
            INNER JOIN TipoReclamo T ON R.IdTipoReclamo = T.IdTipoReclamo
            WHERE R.IdEmpleado = ?";

                OleDbDataAdapter da = new OleDbDataAdapter(consulta, conn);
                da.SelectCommand.Parameters.AddWithValue("?", idEmpleado);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReclamos.DataSource = dt;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
