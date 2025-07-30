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
using System.IO;


namespace pryPerezIEFI
{
    public partial class frmLoguin : Form
    {
        //private string cadenaConexion = Conexion.ObtenerCadena();

        OleDbConnection nuevaConeccion = new OleDbConnection(Conexion.ObtenerCadena());
        public static string dniUsuarioGlobal;
        public static DateTime horaInicioSesion;

        public frmLoguin()
        {
            InitializeComponent();

            //textBox.MaxLength = 10;
            txtContraseña.MaxLength = 10;
            txtdniUsuario.MaxLength = 10;

            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LoguinIEFI.accdb");
            if (!File.Exists(ruta))
            {
                MessageBox.Show("No se encontró la base de datos en la carpeta de ejecución.\nVerificá que esté en 'bin\\Debug'.");
                return;
            }

        }

        private void Loguin_Load(object sender, EventArgs e)
        {
            try
            {
                nuevaConeccion.Open();
                nuevaConeccion.Close();
                stlEstadoConeccion.Text = "Conectado";
            }
            catch (Exception s)
            {

                string error = s.ToString();
                MessageBox.Show(error);
            }
        }

        private void borrartxt()
        {
            txtdniUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {


            string dni = txtdniUsuario.Text.Trim();
            string contra = txtContraseña.Text.Trim();

            if (string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(contra))
            {
                MessageBox.Show("Ingrese un Usuario y Contraseña válidos.");
                return;
            }

            Usuario usuario = new Usuario();

            if (usuario.ValidarLogin(dni, contra))
            {
                // Buscar nombre del usuario
                string nombre = usuario.ObtenerNombrePorDni(dni);

                // Guardar en SesionUsuario
                
                SesionUsuario.IdEmpleado = dni;
                SesionUsuario.NombreUsuario = nombre;
                SesionUsuario.HoraInicioSesion = DateTime.Now;

                MessageBox.Show($"Bienvenido al sistema, {nombre}", "USUARIO AUTORIZADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmMenuPrincipal menu = new frmMenuPrincipal();
                this.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("ERROR : CONTRASEÑA INCORRECTA");
                borrartxt();
            }

            /*
            string contra = txtContraseña.Text;
            string usua = txtdniUsuario.Text;
            if (contra == @"""Ingrese su contraseña""" || usua == @"""Ingrese su DNI""" || contra == "" || usua == "")
            {
                MessageBox.Show("Ingrese un Usuario y Contraseña valido!");
            }
            else
            {
                try
                {
                    //abrimos la base de datos
                    nuevaConeccion.Open();
                    //guardamos la consulta en un string donde 
                    //seleccionamos  DniEmpleado, Contraseña de la tabla Empleado y revisa si no coincide
                    ////ARMANDO LA CONSULTA
                    string consulta = "select DniEmpleado,Contraseña from Empleado where Contraseña = " + txtContraseña.Text + " and DniEmpleado = " + txtdniUsuario.Text + ";";
                    //creamos un nuevo comando donde guardamos la consulta y la direccion de la base de datos 
                    OleDbCommand Commando = new OleDbCommand(consulta, nuevaConeccion);
                    //creamos OBJETO DE TIPO READER QUE ES COMO UNA TABLA QUE SE LLENARA DESPUES DE LA CONSULTA PARA GUARDAR LOS DATOS SOLICITADOS, PUEDE QUEDAR VACIA DEPENDE LA CONSULTA
                    OleDbDataReader leerDB; //TABLA VACIA UQE SE LLENA POR EL OBJETO COMANDO DESDE LA CONSULTA
                                            // lee la consulta para ver que este todo correcto
                    leerDB = Commando.ExecuteReader(); // SE REALIZA LA CONSULTA Y SE CARGA LA TABLA CREADA
                                                       //HasRows verifia que la tabla este vacia o no, dando un resultado booleano. 
                    
                    Boolean Existe = leerDB.HasRows;
                    if (Existe)
                    {
                        MessageBox.Show("Bienvenido al sistema " + txtdniUsuario.Text, "USUARIO AUTORISADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //GUARDAMOS LOS DATOS DE LA HORA Y USUARIO
                        dniUsuarioGlobal = txtdniUsuario.Text.Trim();
                        horaInicioSesion = DateTime.Now;

                        MessageBox.Show($"DNI guardado correctamente: {dniUsuarioGlobal}\nHora de inicio: {horaInicioSesion}", "DEBUG");

                        nuevaConeccion.Close();

                        frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
                        this.Hide();
                        menuPrincipal.Show();

                    }
                    else
                    {
                        MessageBox.Show("ERROR : CONTRASEÑA INCORRECTA");
                        borrartxt();
                    }
                    nuevaConeccion.Close();

                }
                catch (Exception s)
                {

                    string error = s.ToString();
                    MessageBox.Show(error);
                }
            }
            */
        }

        private void txtdniUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)/*verifica que no sea enter o eliminar*/ && !char.IsDigit(e.KeyChar) /*verifica que solo sean numeros*/)
            {
                e.Handled = true; // Esta línea cancela la tecla si no es número
            }
        }

        private void txtdniUsuario_Click(object sender, EventArgs e)
        {
            txtdniUsuario.Text = "";
        }

        private void txtContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.Text = "";
            //PasswordPropertyTextAttribute passwordProperty = new PasswordPropertyTextAttribute(true);
            
        }

        private void Loguin_Click(object sender, EventArgs e)
        {
            string contra = txtContraseña.Text;
            string usua = txtdniUsuario.Text;
            if (contra == "")
            {
                txtContraseña.Text = @"""Ingrese su contraseña""";
            }
            if (usua == "")
            {
                txtdniUsuario.Text = @"""Ingrese su DNI""";
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtdniUsuario_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.ForeColor = Color.Black;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true; // Esto oculta el texto ingresado
            
            if (txtContraseña.Text != @"""Ingrese su contraseña""") //esto verifica que el texto no sea el predeterminado
            {
                txtContraseña.ForeColor = Color.Black;
                //txtContraseña.Text = "";
            }
        }
    }
}
