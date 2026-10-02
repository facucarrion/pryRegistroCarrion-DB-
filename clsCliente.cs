using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryRegistroCarrion_DB_
{
    internal class clsCliente
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Cliente.mdb";
        private string Tabla = "Lista";

        public void Listar(DataGridView dgvListado)
        {
            conexion.ConnectionString = CadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = Tabla;

            adaptador = new OleDbDataAdapter(comando);
            DataSet dataSet = new DataSet();

            adaptador.Fill(dataSet, Tabla);

            dgvListado.DataSource = dataSet.Tables[0];

            conexion.Close();
        }
    }
}
