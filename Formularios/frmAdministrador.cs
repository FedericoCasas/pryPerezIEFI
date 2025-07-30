using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryPerezIEFI
{
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void frmAdministrador_Load(object sender, EventArgs e)
        {

            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;


            Procesos procesos = new Procesos();

            procesos.CargarCombo(cmbOrganizacion, "SELECT * FROM Organizacion", "NombreDeOrganizacion", "IdOrganizacion");
            procesos.CargarCombo(cmbCargo, "SELECT * FROM Cargo", "NombreDeCargo", "IdCargo");

            cmbEstado.Items.AddRange(new[] { "Activo", "Inactivo" });
            /*cmbOrganizacion.SelectedIndex = -1;
            cmbCargo.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            */
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txxDniBuscado.Text.Trim();

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Ingrese un DNI válido.");
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(Conexion.ObtenerCadena()))
            {
                conn.Open();
                string consulta = "SELECT * FROM Empleado WHERE DniEmpleado = ?";
                OleDbCommand cmd = new OleDbCommand(consulta, conn);
                cmd.Parameters.AddWithValue("?", dni);

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtNombre.Text = reader["Nombre"].ToString();
                    txtApellido.Text = reader["Apellido"].ToString();
                    txtDni.Text = reader["DniEmpleado"].ToString();
                    txtDni.Enabled = false;
                    txtTelefono.Text = reader["Telefono"].ToString();
                    txtContraseña.Text = reader["Contraseña"].ToString();

                    bool estado = Convert.ToBoolean(reader["Estado"]);

                    if (estado)
                    {
                        cmbEstado.SelectedIndex = 0; // Activo
                    }
                    else
                    {
                        cmbEstado.SelectedIndex = 1; // Inactivo
                    }

                    //cmbEstado.SelectedItem = reader["Estado"].ToString();

                    cmbOrganizacion.SelectedValue = Convert.ToInt32(reader["IdOrganizacion"]);
                    cmbCargo.SelectedValue = Convert.ToInt32(reader["IdCargo"]);
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario.");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Debe buscar un usuario antes de modificar.");
                return;
            }

            if (cmbEstado.SelectedItem == null ||
                cmbOrganizacion.SelectedIndex == -1 ||
                cmbCargo.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Debe completar todos los campos antes de modificar.");
                return;
            }

            using (OleDbConnection ConeXion = new OleDbConnection(Conexion.ObtenerCadena()))
            {
                ConeXion.Open();

                string query = rbModificar.Checked ?
                @"
                UPDATE Empleado SET 
                    Nombre = ?, Apellido = ?, Telefono = ?, Estado = ?, 
                    IdOrganizacion = ?, IdCargo = ?, Contraseña = ?
                WHERE DniEmpleado = ?" :
                        @"
                UPDATE Empleado SET 
                    Nombre = ?, Apellido = ?, Telefono = ?, Estado = ?, 
                    IdOrganizacion = ?, IdCargo = ?
                WHERE DniEmpleado = ?";

                OleDbCommand cmd = new OleDbCommand(query, ConeXion);

                cmd.Parameters.AddWithValue("?", txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("?", txtApellido.Text.Trim());
                cmd.Parameters.AddWithValue("?", txtTelefono.Text.Trim());

                string estado = cmbEstado.SelectedItem?.ToString() ?? "";
                cmd.Parameters.AddWithValue("?", estado == "Activo");

                cmd.Parameters.AddWithValue("?", Convert.ToInt32(cmbOrganizacion.SelectedValue));
                cmd.Parameters.AddWithValue("?", Convert.ToInt32(cmbCargo.SelectedValue));

                if (rbModificar.Checked)
                {
                    cmd.Parameters.AddWithValue("?", txtContraseña.Text.Trim());
                }

                cmd.Parameters.AddWithValue("?", Convert.ToInt32(txtDni.Text.Trim()));

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario modificado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el usuario: " + ex.Message);
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Debe buscar un usuario antes de eliminar.");
                return;
            }

            if (!int.TryParse(txtDni.Text.Trim(), out int dni))
            {
                MessageBox.Show("El DNI debe ser numérico.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro que desea dar de baja al usuario?",
                "Confirmar baja lógica", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.No)
            {
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(Conexion.ObtenerCadena()))
            {
                conn.Open();

                string query = @"
                UPDATE Empleado SET 
                      Nombre = ?, Apellido = ?, Telefono = ?, Estado = ?, 
                      IdOrganizacion = ?, IdCargo = ?, Contraseña = ?
                WHERE DniEmpleado = ?";

                OleDbCommand cmd = new OleDbCommand(query, conn);

                // Orden de parámetros IMPORTANTE en OleDb
                cmd.Parameters.AddWithValue("?", "");//NOMBRE
                cmd.Parameters.AddWithValue("?", "");//APELLIDO
                cmd.Parameters.AddWithValue("?", "");//TELEFONO

                // Convertimos el estado a booleano
                cmd.Parameters.AddWithValue("?", false); //ESTADO


                cmd.Parameters.AddWithValue("?", 1); //organizacion
                cmd.Parameters.AddWithValue("?", 1); //cargo

                cmd.Parameters.AddWithValue("?", "ADMINISTRATIVO004"); //contraseña

                cmd.Parameters.AddWithValue("?", dni); //dni

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario dado de baja correctamente.");

                    // Limpiar campos
                    txtDni.Text = "";
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtTelefono.Text = "";
                    txtContraseña.Text = "";
                    cmbCargo.SelectedIndex = -1;
                    cmbOrganizacion.SelectedIndex = -1;
                    cmbEstado.SelectedIndex = -1;
                    txtDni.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al dar de baja el usuario: " + ex.Message);
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}
