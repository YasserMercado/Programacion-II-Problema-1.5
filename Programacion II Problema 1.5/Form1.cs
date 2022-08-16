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
using System.Xml.Linq;

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
            cargarCombo(cboxTIPO_MASCOTA,"SP_TIPO_MASCOTAS","tipo","id_tipo");
            cargarLista(lboxCLIENTES, "SP_CLIENTES", "Nombre Completo", "id_cliente");
        }

        private void cargarLista(ListBox name, string sp_name, string columnaDisplay, string columnaValue)
        {
            oBD = new coneccionBD();
            DataTable tabla = oBD.consultaSP(sp_name);
            name.DataSource = tabla;
            name.DisplayMember = columnaDisplay;
            name.ValueMember = columnaValue;
        }

        private void cargarCombo(ComboBox  name, string sp_name, string columnaDisplay, string columnaValue)
        {
            oBD = new coneccionBD();
            DataTable tabla = oBD.consultaSP(sp_name);
            name.DataSource = tabla;
            name.DisplayMember = columnaDisplay;
            name.ValueMember = columnaValue;
        }

        private void insetarDatos(string sp, string name, int edad, string descripcion, int importe)
        {
            oBD.cargarDatos(sp, name, edad, descripcion, importe);
        }

        private void btnCARGAR_Click(object sender, EventArgs e)
        {
            insetarDatos("SP_CONSULTA", textBoxNOMBRE_MASCOTA.Text, Convert.ToInt32(textBoxEDAD.Text), textBoxDESCRIPCION_CONSULTA.Text, Convert.ToInt32(textBoxIMPORTE.Text));
        }
    }
}