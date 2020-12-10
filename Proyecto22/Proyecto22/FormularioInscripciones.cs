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
    public partial class FormularioInscripciones : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=SAM; Initial Catalog=bd1; Integrated security=True");

        public FormularioInscripciones()
        {
            InitializeComponent();
        }

        private void FormularioInscripciones_Load(object sender, EventArgs e)
        {
            conexion.Open();

            SqlDataAdapter adaptador1 = new SqlDataAdapter();
            string sql = "select codigo,nombrecarrera from carreras";

            adaptador1.SelectCommand = new SqlCommand(sql, conexion);
            DataTable tabla1 = new DataTable();
            adaptador1.Fill(tabla1);

            tabla1.Rows.Add(-1, "Seleccionar");
            tabla1.DefaultView.Sort = "codigo";
            comboBox1.DataSource = tabla1;
            comboBox1.DisplayMember = "nombrecarrera";
            comboBox1.ValueMember = "codigo";

            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Inscripto())
            {
                MessageBox.Show("El alumno ya está inscripto a dicha carrera");
                return;
            }

            if (!ExisteDNI())
            {
                MessageBox.Show("No existe un alumno con dicho DNI");
                return;
            }

            if (int.Parse(comboBox1.SelectedValue.ToString())==-1)
            {
                MessageBox.Show("Debe Seleccionar una carrera");
            }
            else
            {
                conexion.Open();

                string sql = "insert into inscripciones(dni,codigocarrera) values (@dni,@codigocarrera)";
                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.Add("@dni", SqlDbType.Char).Value = textBox1.Text;
                comando.Parameters.Add("@codigocarrera", SqlDbType.Int).Value = comboBox1.SelectedValue.ToString();
                comando.ExecuteNonQuery();

                textBox1.Text = "";
                comboBox1.SelectedIndex = 0;

                conexion.Close();

                MessageBox.Show("Se inscribio el alumno a la carrera");
            }

        }

        private bool Inscripto()
        {
            conexion.Open();

            string sql = "select * from inscripciones where dni=@dni and codigocarrera=@codigocarrera";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@dni", SqlDbType.Char).Value = textBox1.Text;
            comando.Parameters.Add("@codigocarrera", SqlDbType.Int).Value = comboBox1.SelectedValue.ToString();

            bool existe = false;
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
                existe = true;

            conexion.Close();

            return existe;
        }

        private bool ExisteDNI()
        {
            conexion.Open();

            string sql = "select * from alumnos where dni=@dni";
            SqlCommand comando = new SqlCommand(sql, conexion);

            comando.Parameters.Add("@dni", SqlDbType.Char).Value = textBox1.Text;

            bool existe = false;
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
                existe = true;

            conexion.Close();

            return existe;
        }
    }
}
