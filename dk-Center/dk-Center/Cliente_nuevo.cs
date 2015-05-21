using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace dk_Center
{
    public partial class Cliente_nuevo : Form
    {
        string connectionString = "Data Source=localHost\\SQLEXPRESS;" + "Initial Catalog=DK-Center;Integrated Security=SSPI";
        SqlConnection con = new SqlConnection();
        public Cliente_nuevo()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = connectionString;
                SqlCommand cmd = new SqlCommand();
                SqlParameter parametro = new SqlParameter();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO L01MCLI " + "VALUES(@RUC,@NOMBRE_CLI,@DIRECCION_CLI,@TELEFONO_CLI)";
                parametro = cmd.Parameters.Add("@RUC", SqlDbType.NChar, 11);
                parametro.Value = txt_ruc.Text.Trim();
                parametro = cmd.Parameters.Add("@NOMBRE_CLI", SqlDbType.NVarChar, 90);
                parametro.Value = txt_raz_soc.Text.Trim();
                parametro = cmd.Parameters.Add("@DIRECCION_CLI", SqlDbType.NVarChar, 90);
                parametro.Value = txt_dir.Text.Trim();
                parametro = cmd.Parameters.Add("@TELEFONO_CLI", SqlDbType.NChar, 20);
                parametro.Value = txt_tel.Text.Trim();

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos Guadados", "Datos Guadados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
    }
}
