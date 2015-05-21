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
    public partial class Ventas : Form
    {
        string connectionString = "Data Source=localHost\\SQLEXPRESS;" + "Initial Catalog=DK-Center;Integrated Security=SSPI";
        SqlConnection con = new SqlConnection();
        string cod, lab, lot, uni;

        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            dataSet1.Clear();
            sqlDataAdapter1.SelectCommand.Connection = sqlConnection1;
            sqlDataAdapter1.Fill(dataSet1, "Medicamento");
            cbx_med.DataSource = dataSet1.Tables["Medicamento"];
            cbx_med.DisplayMember = "Nombre_Mer";
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
                cod = dsBus.Tables[0].Rows[0][0].ToString();
                txt_nom_med.Text = dsBus.Tables[0].Rows[0][1].ToString();
                lab = dsBus.Tables[0].Rows[0][2].ToString();
                lot = dsBus.Tables[0].Rows[0][3].ToString();
                txt_pre_med.Text = dsBus.Tables[0].Rows[0][4].ToString();
                uni = dsBus.Tables[0].Rows[0][5].ToString();
                stock.Text = dsBus.Tables[0].Rows[0][6].ToString();


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

        private void buscar_ruc()
        {
            try
            {
                con.ConnectionString = connectionString;
                con.Open();
                SqlDataAdapter daBus = new SqlDataAdapter("SELECT NOMBRE_CLI,DIRECCION_CLI,TELEFONO_CLI FROM L01MCLI WHERE RUC=" + txt_ruc.Text , con);
                DataSet dsBus = new DataSet();
                daBus.Fill(dsBus);
                dsBus.Dispose();
                daBus.Dispose();
                txt_raz_soc.Text= dsBus.Tables[0].Rows[0][0].ToString();
                txt_dir.Text = dsBus.Tables[0].Rows[0][1].ToString();
                txt_tel.Text = dsBus.Tables[0].Rows[0][2].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cliente no Registrado");
                Cliente_nuevo cn = new Cliente_nuevo();
                cn.ShowDialog();
            }
            finally
            {
                con.Close();
            }
        }

        private void txt_ruc_Validating(object sender, CancelEventArgs e)
        {
            if (txt_ruc.Text.Length == 0 || txt_ruc.Text.Length > 11 || txt_ruc.Text.Length <= 10)
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_ruc, "RUC Invalido Ingrese 11 Digitos");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_ruc, string.Empty);
                buscar_ruc();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int s,can;
            if (txt_can_med.Text.Length!=0)
            {
                con.ConnectionString = connectionString;
                con.Open();
                SqlDataAdapter daAgr = new SqlDataAdapter("SELECT STOCK_MER FROM L01MMER WHERE NOMBRE_MER='" + txt_nom_med.Text + "'", con);
                DataSet dsAgr = new DataSet();
                daAgr.Fill(dsAgr);
                dsAgr.Dispose();
                daAgr.Dispose();
                s = Convert.ToInt16(dsAgr.Tables[0].Rows[0][0].ToString());
                can = Convert.ToInt16(txt_can_med.Text);
                if (can <= s && can != 0)
                {
                    con.Close();
                    agregar_med();
                   // med_repetido();
                    
                }
                else
                {
                    MessageBox.Show("No se dispone en stock");
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Ingrese la Cantidad");
            }
        }
        private void actualizar_stock()
        {
            int stock_actual=0;
            stock_actual = Convert.ToInt16(stock.Text) - Convert.ToInt16(txt_can_med.Text);
            SqlCommand cmd = new SqlCommand("UPDATE L01MMER SET STOCK_MER='" + stock_actual + "' WHERE NOMBRE_MER='" + txt_nom_med.Text+"'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
           // MessageBox.Show("Datos Actualizados");
        }
        private void med_repetido()
        {
            string nombre=null;
            bool rep = false;
            int row = Convert.ToInt16(dataGridView1.RowCount);

            if (row > 1)
            {
                    for (int i = 0; i < row - 1; i++)
                    {
                        nombre = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        if (txt_nom_med.Text == nombre)
                        {
                            MessageBox.Show("No se Agrego Medicamento Repetido " + nombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                
                if (txt_nom_med.Text != nombre)
                {
                   // nombre = null;
                    MessageBox.Show("ENTRE "+nombre);
                    //con.Close();
                    agregar_med();
                }
            }
            else
            {
                //con.Close();
                agregar_med();
            }
        }
        private void agregar_med()
        {
            double precio_ven;
            precio_ven = Convert.ToDouble(txt_pre_med.Text) * Convert.ToDouble(txt_can_med.Text);
            dataGridView1.Rows.Add(new object[] { cod, txt_can_med.Text, uni, txt_nom_med.Text, lot, lab, txt_pre_med.Text, precio_ven.ToString(" #,##0.00;($#,##0.00);Zero") });
            total_venta();
            actualizar_stock();
 
        }
        private void total_venta() 
        {
            double sum = 0.0;
            double ven = 0.0;
            //txt_val_ven.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
            int row = Convert.ToInt16(dataGridView1.RowCount);
           for (int i = 0; i < row-1; i++)
            {
                ven= Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value.ToString());
                sum = sum + ven;
            }
            txt_val_ven.Text = sum.ToString("#,##0.00;(#,##0.00);Zero");
            txt_igv.Text = (sum * 0.18).ToString("#,##0.00;(#,##0.00);Zero");
            txt_tot.Text = (sum * 1.18).ToString("#,##0.00;(#,##0.00);Zero");
 
        }

        private void btn_elim_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int r = 0, cant=0,stock;
            string nom;
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    r=dataGridView1.SelectedRows[i].Index;
                }
            }
            nom = dataGridView1.Rows[r].Cells[3].Value.ToString();
            cant = Convert.ToInt16(dataGridView1.Rows[r].Cells[1].Value.ToString());
            con.ConnectionString = connectionString;
            con.Open();
            SqlDataAdapter daEli = new SqlDataAdapter("SELECT STOCK_MER FROM L01MMER WHERE NOMBRE_MER='" + nom + "'", con);
            DataSet dsEli = new DataSet();
            daEli.Fill(dsEli);
            dsEli.Dispose();
            daEli.Dispose();
            stock = Convert.ToInt16(dsEli.Tables[0].Rows[0][0].ToString());
            cant = cant + stock;
            SqlCommand cmd = new SqlCommand("UPDATE L01MMER SET STOCK_MER='" + cant + "' WHERE NOMBRE_MER= '" + nom +"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            dataGridView1.Rows.RemoveAt(r);
            total_venta();
        }
        void validar_fac()
        {
            if (txt_num_fac.Text != "" && txt_raz_soc.Text != "" && txt_dir.Text != "" && txt_ruc.Text != "" && txt_ord.Text != "" && txt_cond.Text != "" && txt_guia.Text != "" && txt_val_ven.Text != "" && txt_igv.Text != "" && txt_tot.Text != "")
            {
                guardar_fac();
            }
            else
            {
                MessageBox.Show("Ingrese todos lo Campos","Campos en Blaco",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        void guardar_fac()
        {
           // try
            //{
                con.ConnectionString = connectionString;
                SqlCommand cmd = new SqlCommand();
                SqlParameter parametro = new SqlParameter();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO L01PENCFAC " + "VALUES(@NRO_FAC,@RUC,@ORD_COMPRA,@FECHA_EMI,@FECHA_VEN,@CONDICION,@NRO_GUIA,@VALOR_MER,@IGV,@TOTAL)";
                parametro = cmd.Parameters.Add("@NRO_FAC", SqlDbType.NVarChar,10);
                parametro.Value = txt_num_fac.Text.Trim();
                parametro = cmd.Parameters.Add("@RUC", SqlDbType.NChar, 11);
                parametro.Value = txt_ruc.Text.Trim();
                parametro = cmd.Parameters.Add("@ORD_COMPRA", SqlDbType.Int);
                parametro.Value = Convert.ToInt32(txt_ord.Text);
                parametro = cmd.Parameters.Add("@FECHA_EMI", SqlDbType.Date);
                parametro.Value = dt_emi.Text;
                parametro = cmd.Parameters.Add("@FECHA_VEN", SqlDbType.Date);
                parametro.Value = dt_ven.Text;
                parametro = cmd.Parameters.Add("@CONDICION", SqlDbType.NVarChar, 50);
                parametro.Value = txt_cond.Text.Trim();
                parametro = cmd.Parameters.Add("@NRO_GUIA", SqlDbType.NVarChar,10);
                parametro.Value = txt_guia.Text.Trim();
                parametro = cmd.Parameters.Add("@VALOR_MER", SqlDbType.Float);
                parametro.Value = Convert.ToDouble(txt_val_ven.Text);
                parametro = cmd.Parameters.Add("@IGV", SqlDbType.Float);
                parametro.Value = Convert.ToDouble(txt_igv.Text);
                parametro = cmd.Parameters.Add("@TOTAL", SqlDbType.Float);
                parametro.Value = Convert.ToDouble(txt_tot.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                guardar_fac_det();
                
                //MessageBox.Show("Medicamento Registrado codigo " + txt_cod.Text + " Nombre " + txt_nom.Text, "Datos Guadados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          /*  }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " ENCABEZADO");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }*/
        }
        void guardar_fac_det()
        {
            int row = Convert.ToInt16(dataGridView1.RowCount);
           // try
          //  {
                
                    for (int i = 0; i < row - 1; i++)
                    {
                        con.ConnectionString = connectionString;
                        SqlCommand cmd1 = new SqlCommand();
                        SqlParameter parametro1 = new SqlParameter();
                        cmd1.Connection = con;
                        cmd1.CommandText = "INSERT INTO L02PDETFAC " + "VALUES(@NRO_FAC,@COD_MER,@CANTIDAD,@UNIDAD,@DESCRIPCION,@PRECIO_UNI,@PRECIO_VEN)";
                        parametro1 = cmd1.Parameters.Add("@NRO_FAC", SqlDbType.NVarChar, 10);
                        parametro1.Value = txt_num_fac.Text.Trim();
                        parametro1 = cmd1.Parameters.Add("@COD_MER", SqlDbType.Int);
                        parametro1.Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                        parametro1 = cmd1.Parameters.Add("@CANTIDAD", SqlDbType.Int);
                        parametro1.Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                        parametro1 = cmd1.Parameters.Add("@UNIDAD", SqlDbType.NVarChar, 50);
                        parametro1.Value = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        parametro1 = cmd1.Parameters.Add("@DESCRIPCION", SqlDbType.NVarChar, 10);
                        parametro1.Value = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        parametro1 = cmd1.Parameters.Add("@PRECIO_UNI", SqlDbType.Float);
                        parametro1.Value = Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                        parametro1 = cmd1.Parameters.Add("@PRECIO_VEN", SqlDbType.Float);
                        parametro1.Value = Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
                        con.Open();
                        cmd1.ExecuteNonQuery();
                        con.Close();
                    }
              
                //MessageBox.Show("Medicamento Registrado codigo " + txt_cod.Text + " Nombre " + txt_nom.Text, "Datos Guadados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          /*  }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+ " DETALLE");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }*/
                    printDocument1.DefaultPageSettings.Landscape = true;       
                    printDocument1.DocumentName = "Factura" + txt_num_fac.Text;
                    pageSetupDialog1.ShowDialog();
                    printPreviewDialog1.ShowDialog();
                    Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            validar_fac();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            int row = Convert.ToInt16(dataGridView1.RowCount);
            int y = 219;
            Font drawFont = new Font("Arial", 8);
            e.Graphics.DrawString(txt_raz_soc.Text,drawFont,Brushes.Black,11,135);
            e.Graphics.DrawString(txt_dir.Text, drawFont, Brushes.Black, 11, 147);
            e.Graphics.DrawString(txt_ruc.Text, drawFont, Brushes.Black, 11, 158);
            e.Graphics.DrawString(txt_ord.Text, drawFont, Brushes.Black, 5, 185);
            e.Graphics.DrawString(dt_emi.Text, drawFont, Brushes.Black, 110, 185);
            e.Graphics.DrawString(dt_ven.Text, drawFont, Brushes.Black, 320, 185);
            e.Graphics.DrawString(txt_cond.Text, drawFont, Brushes.Black, 550, 185);
            e.Graphics.DrawString(txt_guia.Text, drawFont, Brushes.Black, 670, 185);
            for (int i = 0; i < row - 1; i++)
            {
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), drawFont, Brushes.Black, 11, y);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), drawFont, Brushes.Black, 80, y);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), drawFont, Brushes.Black, 120, y);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), drawFont, Brushes.Black, 200, y);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), drawFont, Brushes.Black, 480, y);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[5].Value.ToString(), drawFont, Brushes.Black, 580, y);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[6].Value.ToString(), drawFont, Brushes.Black, 680, y);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[7].Value.ToString(),drawFont, Brushes.Black, 725, y);
                y = y + 15;
            }
           
            

            e.Graphics.DrawString(txt_val_ven.Text, drawFont, Brushes.Black, 725, 500);
            e.Graphics.DrawString(txt_igv.Text, drawFont, Brushes.Black, 725, 510);
            e.Graphics.DrawString(txt_tot.Text, drawFont, Brushes.Black,725,520);
            
        }

        private void printDocument1_QueryPageSettings(object sender, System.Drawing.Printing.QueryPageSettingsEventArgs e)
        {
           
        }

        private void txt_nom_med_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_val_ven_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
