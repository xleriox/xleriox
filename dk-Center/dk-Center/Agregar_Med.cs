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
    public partial class Agregar_Med : Form
    {
        string connectionString = "Data Source=localHost\\SQLEXPRESS;" + "Initial Catalog=DK-Center;Integrated Security=SSPI";
        SqlConnection con = new SqlConnection();
        public Agregar_Med()
        {
            InitializeComponent();
        }

        private void Agregar_Med_Load(object sender, EventArgs e)
        {
            dataSet1.Clear();
            sqlDataAdapter1.SelectCommand.Connection = sqlConnection1;
            sqlDataAdapter1.Fill(dataSet1, "Medicamento");
            cbx_med.DataSource = dataSet1.Tables["Medicamento"];
            cbx_med.DisplayMember = "Nombre_Mer";
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = connectionString;
                SqlCommand cmd = new SqlCommand();
                SqlParameter parametro = new SqlParameter();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO L01MMER " + "VALUES(@COD_MER,@NOMBRE_MER,@LAB_MER,@LOTE_MER,@PRECIO_MER,@UNIDADES,@STOCK_MER)";
                parametro = cmd.Parameters.Add("@COD_MER", SqlDbType.Int);
                parametro.Value = Convert.ToInt32(txt_cod.Text);
                parametro = cmd.Parameters.Add("@NOMBRE_MER", SqlDbType.VarChar, 90);
                parametro.Value = txt_nom.Text.Trim();
                parametro = cmd.Parameters.Add("@LAB_MER", SqlDbType.VarChar, 90);
                parametro.Value = txt_lab.Text.Trim();
                parametro = cmd.Parameters.Add("@LOTE_MER", SqlDbType.VarChar, 20);
                parametro.Value = txt_lot.Text.Trim();
                parametro = cmd.Parameters.Add("@PRECIO_MER", SqlDbType.Float);
                parametro.Value = Convert.ToDouble(txt_pre.Text);
                parametro = cmd.Parameters.Add("@UNIDADES", SqlDbType.NVarChar, 50);
                parametro.Value = txt_uni.Text.Trim();
                parametro = cmd.Parameters.Add("@STOCK_MER", SqlDbType.Int);
                parametro.Value = Convert.ToInt32(txt_stock.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                compra();
                MessageBox.Show("Medicamento Registrado codigo " + txt_cod.Text + " Nombre " + txt_nom.Text, "Datos Guadados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
            
        }
        private void compra()
        {
            try
            {
                con.ConnectionString = connectionString;
                SqlCommand cmd1 = new SqlCommand();
                SqlParameter parametro = new SqlParameter();
                cmd1.Connection = con;
                cmd1.CommandText = "INSERT INTO L01MCOM " + "VALUES(@NRO_FACTURA,@FECHA_COMPRA,@NOMBRE_MED,@LOTE,@UNIDADES,@PRECIO_COMPRA)";
                parametro = cmd1.Parameters.Add("@NRO_FACTURA", SqlDbType.NVarChar, 11);
                parametro.Value = txt_nro_fac.Text;
                parametro = cmd1.Parameters.Add("@FECHA_COMPRA", SqlDbType.Date);
                parametro.Value = dtp_fec_com.Text;
                parametro = cmd1.Parameters.Add("@NOMBRE_MED", SqlDbType.NVarChar, 50);
                parametro.Value = txt_nom.Text.Trim();
                parametro = cmd1.Parameters.Add("@LOTE", SqlDbType.NVarChar, 50);
                parametro.Value = txt_lot.Text.Trim();
                parametro = cmd1.Parameters.Add("@UNIDADES", SqlDbType.Int);
                parametro.Value = Convert.ToInt16(txt_stock.Text);
                parametro = cmd1.Parameters.Add("@PRECIO_COMPRA", SqlDbType.Float);
                parametro.Value = Convert.ToDouble(txt_pre.Text);


                con.Open();
                cmd1.ExecuteNonQuery();
                // MessageBox.Show("Medicamento Registrado codigo " + txt_cod.Text + " Nombre " + txt_nom.Text, "Datos Guadados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        private void btn_buscar_Click(object sender, EventArgs e)
        {
                try
                {
                    con.ConnectionString = connectionString;
                    con.Open();
                    SqlDataAdapter daBus = new SqlDataAdapter("SELECT COD_MER,NOMBRE_MER,LAB_MER,LOTE_MER,PRECIO_MER,UNIDADES,STOCK_MER FROM dbo.L01MMER WHERE NOMBRE_MER='" + txt_bus_med.Text + "'", con);
                    DataSet dsBus = new DataSet();
                    daBus.Fill(dsBus);
                    dsBus.Dispose();
                    daBus.Dispose();
                    txt_cod.Text = dsBus.Tables[0].Rows[0][0].ToString();
                    txt_nom.Text = dsBus.Tables[0].Rows[0][1].ToString();
                    txt_lab.Text = dsBus.Tables[0].Rows[0][2].ToString();
                    txt_lot.Text = dsBus.Tables[0].Rows[0][3].ToString();
                    txt_pre.Text = dsBus.Tables[0].Rows[0][4].ToString();
                    txt_uni.Text = dsBus.Tables[0].Rows[0][5].ToString();
                    txt_stock.Text = dsBus.Tables[0].Rows[0][6].ToString();
                    txt_cod.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            txt_bus_med.Text = "";
            txt_cod.Text = "";
            txt_lab.Text = "";
            txt_lot.Text = "";
            txt_nom.Text = "";
            txt_pre.Text = "";
            txt_stock.Text = "";
            txt_uni.Text = "";
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            gp_nuevo.Enabled = true;
            btn_guardar.Enabled = false;
            btn_nuevo.Enabled = false;
            btn_act.Visible = true;
            btn_modificar.Enabled = false;
        }

        private void btn_nuevo_Click_1(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            gp_buscar.Enabled = false;
            btn_modificar.Enabled = false;
            gp_nuevo.Enabled = true;
            txt_cod.Enabled = true;
            btn_nuevo.Enabled = false;
            btn_guardar.Enabled = true;
            limpiar();
        }

        private void cbx_med_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = connectionString;
                con.Open();
                SqlDataAdapter daBus = new SqlDataAdapter("SELECT COD_MER,NOMBRE_MER,LAB_MER,LOTE_MER,PRECIO_MER,UNIDADES,STOCK_MER FROM dbo.L01MMER WHERE NOMBRE_MER='" + cbx_med.Text + "'", con);
                DataSet dsBus = new DataSet();
                daBus.Fill(dsBus);
                dsBus.Dispose();
                daBus.Dispose();
                txt_cod.Text = dsBus.Tables[0].Rows[0][0].ToString();
                txt_nom.Text = dsBus.Tables[0].Rows[0][1].ToString();
                txt_lab.Text = dsBus.Tables[0].Rows[0][2].ToString();
                txt_lot.Text = dsBus.Tables[0].Rows[0][3].ToString();
                txt_pre.Text = dsBus.Tables[0].Rows[0][4].ToString();
                txt_uni.Text = dsBus.Tables[0].Rows[0][5].ToString();
                txt_stock.Text = dsBus.Tables[0].Rows[0][6].ToString();
                txt_cod.Enabled = false;

                SqlDataAdapter daCom = new SqlDataAdapter("SELECT Nro_Factura,Fecha_Compra,Precio_Compra FROM L01MCOM WHERE NOMBRE_MER='" + cbx_med.Text + "'", con);
                DataSet dsCom = new DataSet();
                daCom.Fill(dsCom);
                dsCom.Dispose();
                daCom.Dispose();
                txt_nro_fac.Text = dsCom.Tables[0].Rows[0][0].ToString();
                dtp_fec_com.Text = dsCom.Tables[0].Rows[0][1].ToString();
                txt_pre_com.Text = dsCom.Tables[0].Rows[0][2].ToString();
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

        private void txt_cod_Validating(object sender, CancelEventArgs e)
        {
            if (txt_cod.Text.Length == 0 || txt_cod.Text.Length > 7)
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_cod, "Codigo Invalido Ingrese 7 Digitos");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_cod, string.Empty);
            }
        }

        private void btn_act_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE L01MMER SET NOMBRE_MER ='" + txt_nom.Text + "', LAB_MER='" + txt_lab.Text + "',LOTE_MER='" + txt_lot.Text + "',PRECIO_MER='" + txt_pre.Text + "',UNIDADES='" + txt_uni.Text + "',STOCK_MER='" + txt_stock.Text + "' WHERE COD_MER=" + txt_cod.Text, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            compra();
            MessageBox.Show("Datos Actualizados");
            limpiar();
            btn_act.Visible = false;
            btn_nuevo.Enabled = true;
            btn_guardar.Enabled = false;
            btn_modificar.Enabled = true;
            gp_nuevo.Enabled = false;
            gp_buscar.Enabled = true;
        }
        private void txt_nro_fac_Validating(object sender, CancelEventArgs e)
        {
            if (txt_nro_fac.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_nro_fac, "Ingrese numero Factura");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_nro_fac, string.Empty);
            }

        }

        private void txt_pre_com_Validating(object sender, CancelEventArgs e)
        {
            if (txt_pre_com.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_pre_com, "Ingrese numero Precio");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_pre_com, string.Empty);
            }
        }

    }
}
