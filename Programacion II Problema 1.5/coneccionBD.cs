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
            coneccion = new SqlConnection(@"Data Source=YASSPC\SQLEXPRESS;Initial Catalog=VETERINARIA;Integrated Security=True");
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
    }
}
