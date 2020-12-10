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
    public partial class MantenimientoAlumnos : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=SAM; Initial Catalog=bd1; Integrated security=True");

        public MantenimientoAlumnos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string sql = "insert into alumnos(dni,nombrealumno) values (@dni,@nombrealumno)";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@dni", SqlDbType.Char).Value = textBox1.Text;
            comando.Parameters.Add("@nombrealumno", SqlDbType.VarChar).Value = textBox2.Text;
            comando.ExecuteNonQuery();

            textBox1.Text = "";
            textBox2.Text = "";

            conexion.Close();

            CargarGrilla();

            MessageBox.Show("Se cargaron los datos del alumno");
        }

        private void CargarGrilla()
        {
            conexion.Open();

            string sql = "select dni,nombrealumno from alumnos";
            SqlCommand comando = new SqlCommand(sql, conexion);

            SqlDataReader registros = comando.ExecuteReader();

            dataGridView1.Rows.Clear();

            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["dni"].ToString(), registros["nombrealumno"].ToString());
            }

            registros.Close();
            conexion.Close();
        }

        private void MantenimientoAlumnos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
