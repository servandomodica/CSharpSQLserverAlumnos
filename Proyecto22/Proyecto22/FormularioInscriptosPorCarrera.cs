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

namespace Proyecto22
{
    public partial class FormularioInscriptosPorCarrera : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=SAM; Initial Catalog=bd1; Integrated security=True");
        
        public FormularioInscriptosPorCarrera()
        {
            InitializeComponent();
        }

        private void FormularioInscriptosPorCarrera_Load(object sender, EventArgs e)
        {
            conexion.Open();

            string sql = "select codigo,nombrecarrera from carreras";

            SqlDataAdapter adaptador1 = new SqlDataAdapter();
            adaptador1.SelectCommand = new SqlCommand(sql, conexion);

            DataTable tabla1 = new DataTable();
            adaptador1.Fill(tabla1);

            tabla1.Rows.Add(-1, "Seleccione la carrera");
            tabla1.DefaultView.Sort = "codigo";
            comboBox1.DataSource = tabla1;
            comboBox1.DisplayMember="nombrecarrera";
            comboBox1.ValueMember = "codigo";

            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if  (comboBox1.Text== "Seleccione la carrera") //(comboBox1.SelectedValue.ToString() == "-1")
            {
                MessageBox.Show("Debe Seleccionar una carrera");
            }
            else
            {
                conexion.Open();

                string sql = "select alu.dni as dni,nombrealumno " +
                                " from inscripciones as incri " +
                                " join alumnos as alu on alu.dni = incri.dni" +
                                " where codigocarrera = @codigocarrera";
                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.Add("@codigocarrera", SqlDbType.Int).Value = comboBox1.SelectedValue;

                SqlDataReader registros = comando.ExecuteReader();

                dataGridView1.Rows.Clear();

                while (registros.Read())
                {
                    dataGridView1.Rows.Add(registros["dni"].ToString(), registros["nombrealumno"]);
                }

                registros.Close();
                conexion.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
