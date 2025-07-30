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
    public partial class frmModificarTareas : Form
    {
        public frmModificarTareas()
        {
            InitializeComponent();
        }

        int idTareaSeleccionada = -1; // Variable global para almacenar el ID de la tarea seleccionada
        int idEmpleadoSeleccionado = -1;
        Procesos misProcesos = new Procesos();


        private void frmModificarTareas_Load(object sender, EventArgs e)
        {
            misProcesos.CargarCombo(cmbLugar, "SELECT * FROM Lugar", "NombreLugar", "IdLugar");
            misProcesos.CargarCombo(cmbTarea, "SELECT * FROM TipoTareas", "NombreTipoTarea", "IdTipoTareas");

            // Deshabilitamos campos hasta encontrar empleado
            HabilitarControlesTarea(false);
        }
        private void HabilitarControlesTarea(bool Estado)
        {
            cmbTarea.Enabled = Estado;
            
            //dgvTareas.Enabled = Estado;
            cmbLugar.Enabled = Estado;
            

            chkPrioridad.Enabled = Estado;
            chkInsumo.Enabled = Estado;
            chkUniforme.Enabled = Estado;
            chkEstudio.Enabled = Estado;
            chkSupervision.Enabled = Estado;
            chkPresencial.Enabled = Estado;

            btnModificar.Enabled = Estado;
        }
        private void CargarTareas(int idEmpleado)
        {
            using (OleDbConnection conn = new OleDbConnection(Conexion.ObtenerCadena()))
            {
                conn.Open();

                string consulta = @"
                    SELECT 
                        T.IdTareas, 
                        TT.NombreTipoTarea, 
                        L.NombreLugar, 
                        T.Comentario, 
                        T.Fecha,
                        T.Prioridad, 
                        T.Insumo, 
                        T.Uniforme, 
                        T.Estudio, 
                        T.Supervision, 
                        T.Presencial
                    FROM 
                        (Tareas T 
                        INNER JOIN TipoTareas TT ON T.IdTipoTareas = TT.IdTipoTareas)
                        INNER JOIN Lugar L ON T.IdLugar = L.IdLugar
                    WHERE 
                        T.IdEmpleado = ?";

                OleDbDataAdapter da = new OleDbDataAdapter(consulta, conn);
                da.SelectCommand.Parameters.AddWithValue("?", idEmpleado);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTareas.DataSource = dt;
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(Conexion.ObtenerCadena()))
            {
                conn.Open();
                string consulta = "SELECT DniEmpleado, Nombre FROM Empleado WHERE DniEmpleado = ?";
                OleDbCommand cmd = new OleDbCommand(consulta, conn);
                cmd.Parameters.AddWithValue("?", txtDniModificar.Text.Trim());
                int Dni = Convert.ToInt32(txtDniModificar.Text.Trim());
                object resultado = cmd.ExecuteScalar();



                if (resultado != null)
                {
                    idEmpleadoSeleccionado = Convert.ToInt32(resultado);
                    Usuario usuario = new Usuario(); // instanciamos la clase
                    lblEmpleado.Text = usuario.ObtenerNombrePorDni(txtDniModificar.Text.Trim());
                    CargarTareas(idEmpleadoSeleccionado);

                }
                else
                {
                    MessageBox.Show("Empleado no encontrado.");
                    HabilitarControlesTarea(false);
                }
            }
        }

        private void dgvTareas_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dgvTareas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvTareas.Rows[e.RowIndex];
                idTareaSeleccionada = Convert.ToInt32(fila.Cells["IdTareas"].Value); // variable global

                cmbTarea.Text = fila.Cells["NombreTipoTarea"].Value.ToString();
                cmbLugar.Text = fila.Cells["NombreLugar"].Value.ToString();
                //txtComentario.Text = fila.Cells["Comentario"].Value.ToString();
                dtpFecha.Value = Convert.ToDateTime(fila.Cells["Fecha"].Value);

                chkPrioridad.Checked = Convert.ToBoolean(fila.Cells["Prioridad"].Value);
                chkInsumo.Checked = Convert.ToBoolean(fila.Cells["Insumo"].Value);
                chkUniforme.Checked = Convert.ToBoolean(fila.Cells["Uniforme"].Value);
                chkEstudio.Checked = Convert.ToBoolean(fila.Cells["Estudio"].Value);
                chkSupervision.Checked = Convert.ToBoolean(fila.Cells["Supervision"].Value);
                chkPresencial.Checked = Convert.ToBoolean(fila.Cells["Presencial"].Value);

                HabilitarControlesTarea(true);
            }
        }


        private void CargarTareasEmpleado(int idEmpleado)
        {
            using (OleDbConnection conn = new OleDbConnection(Conexion.ObtenerCadena()))
            {
                string consulta = "SELECT IdTareas, Fecha, Comentario FROM Tareas WHERE IdEmpleado = ?";
                OleDbDataAdapter da = new OleDbDataAdapter(consulta, conn);
                da.SelectCommand.Parameters.AddWithValue("?", idEmpleado);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTareas.DataSource = dt;

                dgvTareas.ReadOnly = true;
                dgvTareas.ClearSelection();
                HabilitarControlesTarea(false);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvTareas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idTareaSeleccionada == -1)
            {
                MessageBox.Show("Seleccione una tarea para modificar.");
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(Conexion.ObtenerCadena()))
            {
                conn.Open();
                string consulta = @"
                UPDATE Tareas SET 
                    IdTipoTareas = ?, 
                    IdLugar = ?, 
                    Fecha = ?, 
                    Prioridad = ?, 
                    Insumo = ?, 
                    Uniforme = ?, 
                    Estudio = ?, 
                    Supervision = ?, 
                    Presencial = ?
                WHERE IdTareas = ?";

                OleDbCommand cmd = new OleDbCommand(consulta, conn);

                // Parámetros en el mismo orden que en la consulta
                cmd.Parameters.AddWithValue("?", cmbTarea.SelectedValue);
                cmd.Parameters.AddWithValue("?", cmbLugar.SelectedValue);
                //cmd.Parameters.AddWithValue("?", txtComentario.Text.Trim());
                cmd.Parameters.AddWithValue("?", dtpFecha.Value);
                cmd.Parameters.AddWithValue("?", chkPrioridad.Checked);
                cmd.Parameters.AddWithValue("?", chkInsumo.Checked);
                cmd.Parameters.AddWithValue("?", chkUniforme.Checked);
                cmd.Parameters.AddWithValue("?", chkEstudio.Checked);
                cmd.Parameters.AddWithValue("?", chkSupervision.Checked);
                cmd.Parameters.AddWithValue("?", chkPresencial.Checked);
                cmd.Parameters.AddWithValue("?", idTareaSeleccionada);

                try
                {
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Tarea modificada correctamente.");
                        CargarTareasEmpleado(idEmpleadoSeleccionado);
                        HabilitarControlesTarea(false);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar la tarea.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar la tarea: " + ex.Message);
                }
            }

            using (OleDbConnection conn = new OleDbConnection(Conexion.ObtenerCadena()))
            {
                conn.Open();

                string consulta = @"
                    SELECT 
                        T.IdTareas, 
                        TT.NombreTipoTarea, 
                        L.NombreLugar, 
                        T.Comentario, 
                        T.Fecha,
                        T.Prioridad, 
                        T.Insumo, 
                        T.Uniforme, 
                        T.Estudio, 
                        T.Supervision, 
                        T.Presencial
                    FROM 
                        (Tareas T 
                        INNER JOIN TipoTareas TT ON T.IdTipoTareas = TT.IdTipoTareas)
                        INNER JOIN Lugar L ON T.IdLugar = L.IdLugar
                    WHERE 
                        T.IdEmpleado = ?";

                OleDbDataAdapter da = new OleDbDataAdapter(consulta, conn);
                da.SelectCommand.Parameters.AddWithValue("?", idEmpleadoSeleccionado);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTareas.DataSource = dt;
            }


        }
    }
}
