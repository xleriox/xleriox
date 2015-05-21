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
    public partial class Login : Form
    {
        string connectionString = "Data Source=localHost\\SQLEXPRESS;" + "Initial Catalog=DK-Center;Integrated Security=SSPI";
        SqlConnection con = new SqlConnection();
        string u, c,carg;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            try
            {
                con.ConnectionString = connectionString;
                con.Open();
                SqlDataAdapter daUser = new SqlDataAdapter("SELECT USUARIO,CONTRASEÑA,CARGO FROM L01MUSER WHERE USUARIO= '" + txt_usu.Text + "'", con);
                DataSet dsUser = new DataSet();
                daUser.Fill(dsUser);
                dsUser.Dispose();
                daUser.Dispose();
                u = dsUser.Tables[0].Rows[0][0].ToString();
                c = dsUser.Tables[0].Rows[0][1].ToString();
                carg = dsUser.Tables[0].Rows[0][2].ToString();
                if (u == txt_usu.Text && c == txt_pas.Text)
                {
                    Bienvenido bn = new Bienvenido();
                    bn.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario no Existe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta");
            }
            finally
            {
                con.Close();
            }
        
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
        


    }
}
