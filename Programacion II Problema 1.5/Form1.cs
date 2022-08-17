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
    public partial class VETERINARIA : Form
    {
        coneccionBD oBD;
        public VETERINARIA()
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
        private void insetarDatos(string sp, string name, int edad, int id_tipo, int id_cliente, string descripcion, int importe)
        {
            oBD.cargarDatos(sp, name, edad, id_tipo, id_cliente, descripcion, importe);
        }
        private void clearCampos()
        {
            textBoxNOMBRE_MASCOTA.Clear();
            textBoxEDAD.Clear();
            textBoxDESCRIPCION_CONSULTA.Clear();
            textBoxIMPORTE.Clear();
        }
        private void btnCARGAR_Click(object sender, EventArgs e)
        {
            insetarDatos("SP_CONSULTA", textBoxNOMBRE_MASCOTA.Text, Convert.ToInt32(textBoxEDAD.Text), int.Parse(cboxTIPO_MASCOTA.SelectedValue.ToString()), int.Parse(lboxCLIENTES.SelectedValue.ToString()), textBoxDESCRIPCION_CONSULTA.Text, Convert.ToInt32(textBoxIMPORTE.Text));
            clearCampos();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}