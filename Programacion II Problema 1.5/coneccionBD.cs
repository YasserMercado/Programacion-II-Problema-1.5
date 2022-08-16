using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_II_Problema_1._5
{
    internal class coneccionBD
    {
        SqlConnection coneccion;
        SqlCommand cmd;
        public coneccionBD()
        {
            coneccion = new SqlConnection(@"Data Source=YASS-TMK\SQLEXPRESS;Initial Catalog=VETERINARIA;Integrated Security=True");
        }
        private void openConeccion(string sp)
        {
            coneccion.Open();
            cmd = new SqlCommand(sp, coneccion);
            cmd.CommandType = CommandType.StoredProcedure;
        }
        private void closeConeccion()
        {
            coneccion.Close();
        }
        public DataTable consultaSP(string sp)
        {
            DataTable tabla = new DataTable();
            openConeccion(sp);
            tabla.Load(cmd.ExecuteReader());
            closeConeccion();
            return tabla;
        }
        public void cargarDatos(string sp, string name, int edad, int id_tipo, int id_cliente, string descripcion, int importe)
        {
            openConeccion(sp);
            cmd.Parameters.AddWithValue("@nombre", name);
            cmd.Parameters.AddWithValue("@edad", edad);
            cmd.Parameters.AddWithValue("@id_tipo", id_tipo);
            cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
            cmd.Parameters.AddWithValue("@descripcion", descripcion);
            cmd.Parameters.AddWithValue("@importe", importe);
            cmd.ExecuteNonQuery();
            closeConeccion();
        }
    }
}
