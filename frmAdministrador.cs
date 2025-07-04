using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace pryPerezIEFI
{
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LoguinIEFI.accdb";
        int idEmpleadoSeleccionado;



        private void frmAdministrador_Load(object sender, EventArgs e)
        {
            CargarEmpleadosEnGrilla();

            cbEstado.Items.Clear();
            cbEstado.Items.Add("Activo");
            cbEstado.Items.Add("Inactivo");

            dgvUsuarios.ReadOnly = true; // No permite editar celdas
            dgvUsuarios.AllowUserToAddRows = false; // No muestra la fila vacía al final
            dgvUsuarios.AllowUserToDeleteRows = false; // No permite eliminar con teclado
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selección por fila completa
            dgvUsuarios.MultiSelect = false; // Solo permite seleccionar una fila a la vez



        }

        private void CargarEmpleadosEnGrilla()
        {
            string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LoguinIEFI.accdb";

            using (OleDbConnection conn = new OleDbConnection(cadenaConexion))
            {
                string consulta = @"
                SELECT 
                    E.Cuil, 
                    E.Nombre, 
                    E.Apellido, 
                    E.Estado, 
                    C.NombreDeCargo AS Cargo, 
                    O.NombreDeOrganizacion AS Organizacion
                FROM 
                    ((Empleado AS E 
                    INNER JOIN Cargo AS C ON E.IdCargo = C.IdCargo)
                    INNER JOIN Permisos AS P ON E.IdPermisos = P.IdPermisos)
                    INNER JOIN Organizacion AS O ON E.IdOrganizacion = O.IdOrganizacion";

                OleDbDataAdapter adapter = new OleDbDataAdapter(consulta, conn);
                DataTable tabla = new DataTable();

                try
                {
                    adapter.Fill(tabla);
                    dgvUsuarios.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar empleados: " + ex.Message);
                }
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string cuil = txtCuil.Text.Trim();

            if (cuil == null)
            {
                MessageBox.Show("Ingrese un CUIL para buscar.");
                return;
            }
            else {
                string consulta = "SELECT * FROM Empleado WHERE Cuil = ?";
                using (OleDbConnection conn = new OleDbConnection(cadenaConexion))
                using (OleDbCommand cmd = new OleDbCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("?", cuil);
                    conn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtDni.Text = reader["Nombre"].ToString();
                        txtApellido.Text = reader["Apellido"].ToString();
                        txtDni.Text = reader["DniEmpleado"].ToString();
                        txtTelefono.Text = reader["Telefono"].ToString();
                        txtContraseña.Text = reader["Contraseña"].ToString();
                        cbCargo.SelectedValue = reader["IdCargo"];
                        cbEstado.SelectedItem = Convert.ToBoolean(reader["Estado"]) ? "Activo" : "Inactivo";
                        cbOrganizacion.SelectedValue = reader["IdOrganizacion"];
                        // Guardar ID para futuras operaciones
                        idEmpleadoSeleccionado = Convert.ToInt32(reader["IdEmpleado"]);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el empleado.");
                    }
                }
            }

            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           // s




        }
    }

}
