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
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }
        //FALTA COMPLETAR 
        private void frmStock_Load(object sender, EventArgs e)
        {
            Procesos procesos = new Procesos();
            procesos.CargarCombo(cmbTipoProducto, "SELECT * FROM TipoProducto", "NombreTipo", "IdTipoProducto");
            CargarGrillaProductos();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void LimpiarCampos()
        {
            txtCodigoBarras.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtStock.Clear();
            txtValor.Clear();
            cmbTipoProducto.SelectedIndex = -1;
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoBarras.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text) ||
                string.IsNullOrWhiteSpace(txtValor.Text) ||
                cmbTipoProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, completá todos los campos.");
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(Conexion.ObtenerCadena()))
                {
                    conn.Open();
                    string consulta = @"INSERT INTO Producto 
                        (CodigoBarras, NombreProducto, Descripcion, StockActual, Valor, IdTipoProducto)
                        VALUES (?, ?, ?, ?, ?, ?)";
                   
                    OleDbCommand cmd = new OleDbCommand(consulta, conn);
                    cmd.Parameters.AddWithValue("?", txtCodigoBarras.Text.Trim());
                    cmd.Parameters.AddWithValue("?", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("?", txtDescripcion.Text.Trim());
                    cmd.Parameters.AddWithValue("?", Convert.ToInt32(txtStock.Text.Trim()));
                    cmd.Parameters.AddWithValue("?", Convert.ToDecimal(txtValor.Text.Trim()));
                    cmd.Parameters.AddWithValue("?", cmbTipoProducto.SelectedValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producto agregado correctamente.");

                    LimpiarCampos(); // Limpia el formulario después de agregar
                    CargarGrillaProductos(); // Si tenés una grilla para mostrar productos
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message);
            }
        }
        private void CargarGrillaProductos()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(Conexion.ObtenerCadena()))
                {
                    conn.Open();
                    string consulta = @"
                    SELECT 
                        P.IdProducto,
                        P.CodigoBarras,
                        P.NombreProducto,
                        P.Descripcion,
                        P.StockActual,
                        P.Valor,
                        T.NombreTipo
                    FROM Producto P
                    INNER JOIN TipoProducto T ON P.IdTipoProducto = T.IdTipoProducto";

                    OleDbDataAdapter da = new OleDbDataAdapter(consulta, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvProductos.DataSource = dt;

                    dgvProductos.Columns["IdProducto"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos: " + ex.Message);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                DialogResult confirmacion = MessageBox.Show(
                    "¿Estás seguro de eliminar este producto?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    int idProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells["IdProducto"].Value);

                    using (OleDbConnection conn = new OleDbConnection(Conexion.ObtenerCadena()))
                    {
                        conn.Open();
                        string consulta = "DELETE FROM Producto WHERE IdProducto = ?";
                        OleDbCommand cmd = new OleDbCommand(consulta, conn);
                        cmd.Parameters.AddWithValue("?", idProducto);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Producto eliminado correctamente.");
                    CargarGrillaProductos(); // Refrescar
                }
            }
            else
            {
                MessageBox.Show("Seleccioná un producto para eliminar.");
            }
        }
    }
}
