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
    public partial class frmVerTareas : Form
    {
        public frmVerTareas()
        {
            InitializeComponent();
        }
        private void frmVerTareas_Load(object sender, EventArgs e)
        {
            dgvTareasEmpleado.ReadOnly = true;
            dgvTareasEmpleado.AllowUserToAddRows = false;
            dgvTareasEmpleado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void dgvAuditoriaAdaptarContenido(DataGridView grilla)
        {
            grilla.DefaultCellStyle.Font = new Font("Segoe UI", 10);// esto sirbe para establecer la fuente de las celdas
            grilla.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold); // esto sirve para establecer la fuente de los encabezados de las columnas
            grilla.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // esto sirve para que el texto de las celdas se ajuste automáticamente al tamaño de la celda

            grilla.Columns["Nombre"].Width = 120;

            grilla.Columns["Apellido"].Width = 120;
            grilla.Columns["DNI"].Width = 80;
            grilla.Columns["Hora Ingreso"].Width = 120;
            grilla.Columns["Hora Salida"].Width = 120;
            grilla.Columns["Tiempo en App"].Width = 100;
            grilla.Columns["DNI"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // esto sirve para alinear el texto de la celda al centro


            //grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;// esto sirve para que las columnas se ajusten automáticamente al contenido de las celdas
            //grilla.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;// esto sirve para que las filas se ajusten automáticamente al contenido de las celdas

            grilla.RowTemplate.Height = 30;// esto sirve para establecer la altura de las filas
            grilla.AllowUserToResizeRows = false;// esto sirve para que el usuario no pueda cambiar el tamaño de las filas

            // Unificar fuentes
            foreach (DataGridViewRow fila in grilla.Rows)
            {
                fila.DefaultCellStyle.Font = grilla.DefaultCellStyle.Font;
            }

            // Sumar margen horizontal
            //foreach (DataGridViewColumn col in grilla.Columns)
            //{
            //    col.Width += 18; // margen extra visual
            //}

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try {
                string dni = txtDniBuscar.Text.Trim();

                if (string.IsNullOrEmpty(dni))
                {
                    MessageBox.Show("Ingrese un DNI.");
                    return;
                }

                using (OleDbConnection conn = new OleDbConnection(Conexion.ObtenerCadena()))
                {
                    conn.Open();

                    string consulta = @"
                    SELECT T.Fecha, TT.NombreTipoTarea AS Tarea, L.NombreLugar AS Lugar, T.Comentario,
                           T.Prioridad, T.Insumo, T.Uniforme, T.Estudio, T.Supervision, T.Presencial
                    FROM (Tareas AS T
                          INNER JOIN TipoTareas AS TT ON T.IdTipoTareas = TT.IdTipoTareas)
                          INNER JOIN Lugar AS L ON T.IdLugar = L.IdLugar
                    WHERE T.IdEmpleado = ?
                    ORDER BY T.Fecha DESC";


                    OleDbCommand cmd = new OleDbCommand(consulta, conn);
                    cmd.Parameters.AddWithValue("?", dni); // se usa directamente como FK

                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron tareas para ese DNI.");
                        dgvTareasEmpleado.DataSource = null;
                    }
                    else
                    {
                        dgvTareasEmpleado.DataSource = dt;
                        //dgvAuditoriaAdaptarContenido(dgvTareasEmpleado);
                    }
                }
            }
            catch (Exception s)
            {

                string error = s.ToString();
                MessageBox.Show(error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
