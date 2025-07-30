using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryPerezIEFI
{
    internal class Usuario
    {
        private string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LoguinIEFI.accdb";

        public bool ValidarLogin(string dni, string contraseña)
        {
            using (OleDbConnection conn = new OleDbConnection(cadenaConexion))
            {
                conn.Open();
                string consulta = "SELECT * FROM Empleado WHERE DniEmpleado = ? AND Contraseña = ?";
                OleDbCommand cmd = new OleDbCommand(consulta, conn);
                cmd.Parameters.AddWithValue("?", dni);
                cmd.Parameters.AddWithValue("?", contraseña);
                OleDbDataReader reader = cmd.ExecuteReader();
                return reader.HasRows;
            }
        }

        public string ObtenerNombrePorDni(string dni)
        {
            using (OleDbConnection conn = new OleDbConnection(cadenaConexion))
            {
                conn.Open();
                string consulta = "SELECT Nombre FROM Empleado WHERE DniEmpleado = ?";
                OleDbCommand cmd = new OleDbCommand(consulta, conn);
                cmd.Parameters.AddWithValue("?", dni);

                object resultado = cmd.ExecuteScalar();
                return resultado != null ? resultado.ToString() : "Usuario";
            }
        }



    }
}
