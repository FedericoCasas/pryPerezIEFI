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
                        Empleado E ON S.DniUsuario = E.DniEmpleado";


                try
                {
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conn);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvAuditoria.DataSource = tabla;
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
    }
}
