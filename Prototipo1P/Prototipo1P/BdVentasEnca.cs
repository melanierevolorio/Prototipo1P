using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo1P
{
    class BdVentasEnca
    {
        private ConexionODBC ODBC = new ConexionODBC();

        public List<ModeloClientes> mostrarClientes()
        {
            List<ModeloClientes> sqlresultado = new List<ModeloClientes>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM clientes;";
                sqlresultado = conexionODBC.Query<ModeloClientes>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
                return sqlresultado;
            }
            return null;
        }


        public ModeloVentasEnca agregarVentaEncabezado(ModeloVentasEnca modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO ventas_encabezado(documento_ventaenca, codigo_cliente, fecha_ventaenca, total_ventaenca, estatus_ventaenca) " +
                "VALUES (?documento_ventaenca?,?codigo_cliente?, ?fecha_ventaenca?, ?total_ventaenca?, ?estatus_ventaenca?);";
                var ValorDeVariables = new
                {
                    documento_ventaenca = modelo.documento_ventaenca,
                    codigo_cliente = modelo.codigo_cliente,
                    fecha_ventaenca = modelo.fecha_ventaenca,
                    total_ventaenca = modelo.total_ventaenca,
                    estatus_ventaenca = modelo.estatus_ventaenca
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }
    }
}
