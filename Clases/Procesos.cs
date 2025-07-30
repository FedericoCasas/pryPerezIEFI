using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPerezIEFI
{
    internal class Procesos
    {
        private string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LoguinIEFI.accdb";

        public void CargarCombo(ComboBox combo, string consulta, string display, string value)
        {
            using (OleDbConnection conn = new OleDbConnection(cadenaConexion))
            {
                OleDbDataAdapter da = new OleDbDataAdapter(consulta, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                combo.DataSource = dt;
                combo.DisplayMember = display;
                combo.ValueMember = value;
            }
        }
    }
}
