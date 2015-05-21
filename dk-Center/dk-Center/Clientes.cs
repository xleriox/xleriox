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
    public partial class Clientes : Form
    {
        string connectionString = "Data Source=localHost\\SQLEXPRESS;" + "Initial Catalog=DK-Center;Integrated Security=SSPI";
        SqlConnection con = new SqlConnection();
        public Clientes()
        {
            InitializeComponent();
        }
        private void Clientes_Load(object sender, EventArgs e)
        {
            dataSet1.Clear();
            sqlDataAdapter1.SelectCommand.Connection = sqlConnection1;
            sqlDataAdapter1.Fill(dataSet1, "Clientes");
            cbx_cli.DataSource = dataSet1.Tables["Clientes"];
            cbx_cli.DisplayMember = "NOMBRE_CLI";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente_nuevo cn = new Cliente_nuevo();
            cn.ShowDialog();
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            btn_nuevo.Enabled = false;
            btn_act.Visible = true;
            groupBox1.Enabled = true;
        }

        private void btn_can_Click(object sender, EventArgs e)
        {
            txt_dir.Text = "";
            txt_raz_soc.Text = "";
            txt_ruc.Text = "";
            txt_tel.Text = "";
            groupBox1.Enabled = false;
            btn_act.Visible = false;
            btn_nuevo.Enabled = true;
        }

        private void btn_bus_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = connectionString;
                con.Open();
                SqlDataAdapter daBus = new SqlDataAdapter("SELECT RUC,NOMBRE_CLI,DIRECCION_CLI,TELEFONO_CLI FROM L01MCLI WHERE NOMBRE_CLI='" + cbx_cli.Text + "'", con);
                DataSet dsBus = new DataSet();
                daBus.Fill(dsBus);
                dsBus.Dispose();
                daBus.Dispose();
                txt_ruc.Text = dsBus.Tables[0].Rows[0][0].ToString();
                txt_raz_soc.Text = dsBus.Tables[0].Rows[0][1].ToString();
                txt_dir.Text = dsBus.Tables[0].Rows[0][2].ToString();
                txt_tel.Text = dsBus.Tables[0].Rows[0][3].ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


    }
}
