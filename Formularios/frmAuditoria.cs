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
    public partial class frmAuditoria : Form
    {
        public frmAuditoria()
        {
            InitializeComponent();
        }

        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;

            string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LoguinIEFI.accdb";

            using (OleDbConnection conn = new OleDbConnection(cadenaConexion))
            {
                string consulta = @"
                    SELECT 
                        E.DniEmpleado AS [DNI],
                        E.Nombre,
                        E.Apellido,
                        S.FechaDeInicio AS [Hora Ingreso],
                        S.FechaDeCierre AS [Hora Salida],
                        FORMAT(S.FechaDeCierre - S.FechaDeInicio, 'hh:nn:ss') AS [Tiempo en App]
                    FROM 
                        Sesiones S
                    INNER JOIN 
                        Empleado E ON S.IdEmpleado = E.DniEmpleado";


                try
                {
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conn);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvAuditoria.DataSource = tabla;
                    dgvAuditoriaAdaptarContenido(dgvAuditoria); // Llamamos al método para adaptar el contenido de la grilla
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar auditoría: " + ex.Message);
                }
            }
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
