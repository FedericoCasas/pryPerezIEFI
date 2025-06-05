using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace pryPerezIEFI
{
    public partial class Loguin : Form
    {
        OleDbConnection nuevaConeccion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LoguinIEFI.accdb");

        public Loguin()
        {
            InitializeComponent();

            //textBox.MaxLength = 10;

            txtContraseña.MaxLength = 10;
            txtDniUsuario.MaxLength = 10;
        }

        private void Loguin_Load(object sender, EventArgs e)
        {
            try {

                nuevaConeccion.Open();
                nuevaConeccion.Close();
                stlEstadoConeccion.Text = "Conectado";
            }
            catch (Exception s) {
            
                string error = s.ToString();
                MessageBox.Show(error);
            }


        }
        private void borrartxt() {
            txtDniUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            //abrimos la base de datos
            nuevaConeccion.Open();
            //guardamos la consulta en un string donde 
            //seleccionamos  DniEmpleado, Contraseña de la tabla Empleado y revisa si no coincide
            ////ARMANDO LA CONSULTA
            string consulta = "select DniEmpleado,Contraseña from Empleado where Contraseña = " + txtContraseña.Text + " and DniEmpleado = " + txtDniUsuario.Text + ";";
            //creamos un nuevo comando donde guardamos la consulta y la direccion de la base de datos 
            OleDbCommand Commando = new OleDbCommand(consulta , nuevaConeccion);
            //creamos OBJETO DE TIPO READER QUE ES COMO UNA TABLA QUE SE LLENARA DESPUES DE LA CONSULTA PARA GUARDAR LOS DATOS SOLICITADOS, PUEDE QUEDAR VACIA DEPENDE LA CONSULTA
            OleDbDataReader leerDB; //TABLA VACIA UQE SE LLENA POR EL OBJETO COMANDO DESDE LA CONSULTA
            // lee la consulta para ver que este todo correcto
            leerDB = Commando.ExecuteReader(); // SE REALIZA LA CONSULTA Y SE CARGA LA TABLA CREADA
            //HasRows verifia que la tabla este vacia o no, dando un resultado booleano. 
            Boolean Existe = leerDB.HasRows;
            if (Existe){
                MessageBox.Show("Bienvenido al sistema " + txtDniUsuario.Text, "USUARIO AUTORISADO", MessageBoxButtons.OK,MessageBoxIcon.Information);

                MenuPrincipal menuPrincipal = new MenuPrincipal();
                this.Hide();
                menuPrincipal.Show();

            }
            else{
                MessageBox.Show("ERROR : CONTRASEÑA INCORRECTA");
                borrartxt();
            }
            nuevaConeccion.Close();
        }

        private void txtDniUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)/*verifica que no sea enter o eliminar*/ && !char.IsDigit(e.KeyChar) /*verifica que solo sean numeros*/)
            {
                e.Handled = true; // Esta línea cancela la tecla si no es número
            }
        }
    }
}
