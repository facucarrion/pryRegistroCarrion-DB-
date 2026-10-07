using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Security.Policy;

namespace pryRegistroCarrion_DB_
{
    internal class clsCliente
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Cliente.mdb";
        private string Tabla = "Lista";

        private Decimal deuda;
        private Int32 cantidad;

        public Decimal DeudaTotal
        {
            get { return deuda; }
        }

        public Int32 CantidadDeudores
        {
            get { return cantidad; }
        }

        public Decimal PromedioDeuda
        {
            get { return deuda / cantidad; }
        }

        public void Listar(DataGridView dgvListado)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los datos: " + ex.Message);
            }
        }

        public void Deudores(DataGridView dgvListado)
        {
            try {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader dataReader = comando.ExecuteReader();
                dgvListado.Rows.Clear();

                cantidad = 0;
                deuda = 0;

                while (dataReader.Read())
                {
                    if (dataReader.GetDecimal(2) > 0)
                    {
                        dgvListado.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetDecimal(2));
                        cantidad++;
                        deuda += dataReader.GetDecimal(2);
                    }
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los datos: " + ex.Message);
            }
        }
    }
}
