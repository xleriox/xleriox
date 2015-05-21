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
    public partial class Nuevo_Usuario : Form
    {
        string connectionString = "Data Source=localHost\\SQLEXPRESS;" + "Initial Catalog=DK-Center;Integrated Security=SSPI";
        SqlConnection con = new SqlConnection();
        public Nuevo_Usuario()
        {
            InitializeComponent();
        }

        private void btn_acp_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = connectionString;
                SqlCommand cmd = new SqlCommand();
                SqlParameter parametro = new SqlParameter();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO L01MUSU " + "VALUES(@COD_USU,@USUARIO,@CONTRASEÑA,@NOMBRE,@CARGO)";
                parametro = cmd.Parameters.Add("@COD_USU", SqlDbType.Int);
                parametro.Value = Convert.ToInt32(txt_cod.Text);
                parametro = cmd.Parameters.Add("@USUARIO", SqlDbType.NVarChar, 10);
                parametro.Value = txt_usu.Text.Trim();
                parametro = cmd.Parameters.Add("@CONTRASEÑA", SqlDbType.NVarChar, 10);
                parametro.Value = txt_con_val.Text.Trim();
                parametro = cmd.Parameters.Add("@NOMBRE", SqlDbType.NVarChar, 50);
                parametro.Value = txt_nom.Text.Trim();
                parametro = cmd.Parameters.Add("@CARGO", SqlDbType.NVarChar, 50);
                parametro.Value = cbx_car.Text.Trim();
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

        private void txt_con_val_Validating(object sender, CancelEventArgs e)
        {
            if (txt_cont.Text==txt_con_val.Text)
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_con_val, string.Empty);
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_con_val, "Escriba la misma Contraseña");
                
            }
        }

        private void Nuevo_Usuario_Load(object sender, EventArgs e)
        {
            Login l = new Login();
            l.ShowDialog();
        }
    }
}
