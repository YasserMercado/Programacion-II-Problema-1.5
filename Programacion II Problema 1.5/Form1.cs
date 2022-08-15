using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_II_Problema_1._5
{
    public partial class Form1 : Form
    {
        coneccionBD oBD;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCombo(cboxCLIENTES, "SP_CLIENTES", "Nombre Completo", "id_cliente");
        }

        private void cargarCombo(ComboBox name, string sp_name, string columnaDisplay, string columnaValue)
        {
            oBD = new coneccionBD();
            DataTable tabla = oBD.consultaSP(sp_name);
            name.DataSource = tabla;
            name.DisplayMember = columnaDisplay;
            name.ValueMember = columnaValue;
        }
    }
}
