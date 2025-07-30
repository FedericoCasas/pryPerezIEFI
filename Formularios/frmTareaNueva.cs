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
    public partial class frmTareaNueva : Form
    {
        public frmTareaNueva()
        {
            InitializeComponent();
        }
        private int idEmpleadoAsignado;

        private void frmTareaNueva_Load(object sender, EventArgs e)
        {

            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            // Cargar combos de tareas y lugares
            Procesos procesos = new Procesos();
            procesos.CargarCombo(cmbTareas, "SELECT * FROM TipoTareas", "NombreTipoTarea", "IdTipoTareas");
            procesos.CargarCombo(cmbLugar, "SELECT * FROM Lugar", "NombreLugar", "IdLugar");

            cmbTareas.SelectedIndex = -1;
            cmbLugar.SelectedIndex = -1;
            HabilitarControlesTarea(false);

            // Configuración del DataGridView
            CargarGrilla();
            dgvTareas.ReadOnly = true; // No permite editar las celdas
            dgvTareas.AllowUserToAddRows = false; // No permite la fila vacía inferior
            dgvTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selección por fila
        }

        private void CargarGrilla()
        {
            dgvTareas.Columns.Add("Fecha", "Fecha");
            dgvTareas.Columns.Add("Tarea", "Tarea");
            dgvTareas.Columns.Add("Lugar", "Lugar");
            dgvTareas.Columns.Add("Comentario", "Comentario");
            dgvTareas.Columns.Add("Prioridad", "Prioridad");
            dgvTareas.Columns.Add("Insumo", "Insumo");
            dgvTareas.Columns.Add("Uniforme", "Uniforme");
            dgvTareas.Columns.Add("Estudio", "Estudio");
            dgvTareas.Columns.Add("Supervision", "Supervisión");
            dgvTareas.Columns.Add("Presencial", "Presencial");

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text.Trim();
            idEmpleadoAsignado = Convert.ToInt32(dni);
            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Ingrese un DNI válido.");
                return;
            }

            idEmpleadoAsignado = Convert.ToInt32(txtDni.Text.Trim());

            Usuario usuario = new Usuario();
            string nombre = usuario.ObtenerNombrePorDni(dni);

            if (nombre == "Usuario")
            {
                MessageBox.Show("Empleado no encontrado.");
                HabilitarControlesTarea(false);
            }
            else
            {
                lblEmpleado.Text = "Empleado " + nombre; // o donde quieras mostrarlo
                SesionUsuario.IdEmpleado = dni;
                HabilitarControlesTarea(true);
            }

            //----------------------

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbTareas.SelectedIndex == -1 || cmbLugar.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una tarea y un lugar.");
                return;
            }

            dgvTareas.Rows.Add(
                dtpFecha.Value.ToShortDateString(),
                cmbTareas.Text,
                cmbLugar.Text,
                txtComentario.Text.Trim(),
                chkPrioridad.Checked ? "Sí" : "No",
                chkInsumo.Checked ? "Sí" : "No",
                chkUniforme.Checked ? "Sí" : "No",
                chkEstudio.Checked ? "Sí" : "No",
                chkSupervision.Checked ? "Sí" : "No",
                chkPresencial.Checked ? "Sí" : "No"
            );

            limpiarCntroles();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.Rows.Count == 0)
            {
                MessageBox.Show("No hay tareas para grabar.");
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(Conexion.ObtenerCadena()))
            {
                conn.Open();

                foreach (DataGridViewRow fila in dgvTareas.Rows)
                {
                    if (fila.IsNewRow) continue;

                    string fecha = fila.Cells["Fecha"].Value.ToString();
                    string nombreTarea = fila.Cells["Tarea"].Value.ToString();
                    string nombreLugar = fila.Cells["Lugar"].Value.ToString();
                    string comentario = fila.Cells["Comentario"].Value.ToString();

                    // Convertir valores de Sí/No
                    bool prioridad = fila.Cells["Prioridad"].Value.ToString() == "Sí";
                    bool insumo = fila.Cells["Insumo"].Value.ToString() == "Sí";
                    bool uniforme = fila.Cells["Uniforme"].Value.ToString() == "Sí";
                    bool estudio = fila.Cells["Estudio"].Value.ToString() == "Sí";
                    bool supervision = fila.Cells["Supervision"].Value.ToString() == "Sí";
                    bool presencial = fila.Cells["Presencial"].Value.ToString() == "Sí";

                    // Obtener los IDs reales desde los combos cargados
                    int idTarea = ObtenerIdDesdeCombo("TipoTareas", "NombreTipoTarea", nombreTarea);
                    int idLugar = ObtenerIdDesdeCombo("Lugar", "NombreLugar", nombreLugar);

                    string query = @"
                    INSERT INTO Tareas (IdTipoTareas, IdLugar, Comentario, Fecha, Prioridad, Insumo, Uniforme, Estudio, Supervision, Presencial, IdEmpleado)
                    VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                    OleDbCommand cmd = new OleDbCommand(query, conn);
                    cmd.Parameters.AddWithValue("?", idTarea);
                    cmd.Parameters.AddWithValue("?", idLugar);
                    cmd.Parameters.AddWithValue("?", comentario);
                    cmd.Parameters.AddWithValue("?", Convert.ToDateTime(fecha));
                    cmd.Parameters.AddWithValue("?", prioridad);
                    cmd.Parameters.AddWithValue("?", insumo);
                    cmd.Parameters.AddWithValue("?", uniforme);
                    cmd.Parameters.AddWithValue("?", estudio);
                    cmd.Parameters.AddWithValue("?", supervision);
                    cmd.Parameters.AddWithValue("?", presencial);
                    cmd.Parameters.AddWithValue("?", idEmpleadoAsignado);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Tareas grabadas correctamente.");
                dgvTareas.Rows.Clear();
            }

        }
        private int ObtenerIdDesdeCombo(string tabla, string campoNombre, string valor)
        {
            using (OleDbConnection conn = new OleDbConnection(Conexion.ObtenerCadena()))
            {
                conn.Open();
                string consulta = $"SELECT Id{tabla} FROM {tabla} WHERE {campoNombre} = ?";
                OleDbCommand cmd = new OleDbCommand(consulta, conn);
                cmd.Parameters.AddWithValue("?", valor);
                object resultado = cmd.ExecuteScalar();
                return resultado != null ? Convert.ToInt32(resultado) : -1;
            }
        }

        private void limpiarCntroles()
        {
            cmbTareas.SelectedIndex = -1;
            txtComentario.Clear();
            chkPrioridad.Checked = false;
            chkInsumo.Checked = false;
            chkUniforme.Checked = false;
            chkEstudio.Checked = false;
            chkSupervision.Checked = false;
            chkPresencial.Checked = false;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvTareas.Rows.Clear();
            txtDni.Clear();
            lblEmpleado.Text = "Empleado :";
            cmbLugar.SelectedIndex = -1;
            limpiarCntroles();
            HabilitarControlesTarea(false);
            this.Hide();



        }
        private void HabilitarControlesTarea(bool Estado)
        {
            cmbTareas.Enabled = Estado;
            btnAgregar.Enabled = Estado;
            dgvTareas.Enabled = Estado;
            cmbLugar.Enabled = Estado;
            txtComentario.Enabled = Estado;

            chkPrioridad.Enabled = Estado;
            chkInsumo.Enabled = Estado;
            chkUniforme.Enabled = Estado;
            chkEstudio.Enabled = Estado;
            chkSupervision.Enabled = Estado;
            chkPresencial.Enabled = Estado;

            btnGrabar.Enabled = Estado;
        }

        private void grbDetalle_Enter(object sender, EventArgs e)
        {

        }
    }
}
