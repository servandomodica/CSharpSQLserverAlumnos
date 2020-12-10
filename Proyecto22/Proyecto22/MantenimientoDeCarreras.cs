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
    public partial class MantenimientoDeCarreras : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=SAM; Initial Catalog=bd1; Integrated security=True");

        public MantenimientoDeCarreras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string sql = "insert into carreras(nombrecarrera) values (@nombrecarrera)";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@nombrecarrera", SqlDbType.VarChar).Value = textBox1.Text;
            comando.ExecuteNonQuery();

            conexion.Close();

            CargarGrilla();

            textBox1.Text = "";

            MessageBox.Show("Se dio de alta la carrera");
        }

        private void CargarGrilla()
        {
            conexion.Open();

            string sql = "select codigo,nombrecarrera from carreras";
            SqlCommand comando = new SqlCommand(sql, conexion);

            SqlDataReader registros = comando.ExecuteReader();

            dataGridView1.Rows.Clear();

            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["codigo"].ToString(), registros["nombrecarrera"].ToString());
            }

            registros.Close();
            conexion.Close();
        }

        private void MantenimientoDeCarreras_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
