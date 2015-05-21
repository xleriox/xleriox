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
    public partial class medicamentos : Form
    {
        public medicamentos()
        {
            InitializeComponent();
        }

        private void medicamentos_Load(object sender, EventArgs e)
        {
            dataSet1.Clear();
            sqlDataAdapter1.SelectCommand.Connection = sqlConnection1;
            sqlDataAdapter1.Fill(dataSet1, "Medicamentos");
            
            sqlDataAdapter1.SelectCommand.CommandText = "SELECT * FROM L01MMER ORDER BY COD_MER";
            if (dataSet1.Tables["Medicamento"] != null)
                dataSet1.Tables["Medicamento"].Clear();
            sqlDataAdapter1.Fill(dataSet1, "Medicamento");
            dataGrid1.SetDataBinding(dataSet1, "Medicamento");
        }

        private void txt_bus_med_TextChanged(object sender, EventArgs e)
        {

            sqlDataAdapter1.SelectCommand.CommandText = "SELECT COD_MER,NOMBRE_MER,LAB_MER,LOTE_MER,PRECIO_MER,UNIDADES,STOCK_MER FROM dbo.L01MMER WHERE NOMBRE_MER LIKE '" + txt_bus_med.Text + "%'";
            if (dataSet1.Tables["Medicamento"] != null)
                dataSet1.Tables["Medicamento"].Clear();
            sqlDataAdapter1.Fill(dataSet1, "Medicamento");
            dataGrid1.SetDataBinding(dataSet1, "Medicamento");
        }
    }
}
