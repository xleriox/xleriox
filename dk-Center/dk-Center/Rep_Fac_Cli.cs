﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dk_Center
{
    public partial class Rep_Fac_Cli : Form
    {
        public Rep_Fac_Cli()
        {
            InitializeComponent();
        }

        private void Rep_Fac_Cli_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'factura_DK_CenterDataSet.DataTable1' Puede moverla o quitarla según sea necesario.

            // TODO: esta línea de código carga datos en la tabla 'factura_DK_CenterDataSet.L01PENCFAC' Puede moverla o quitarla según sea necesario.
            this.l01PENCFACTableAdapter.Fill(this.factura_DK_CenterDataSet.L01PENCFAC);
            this.dataTable1TableAdapter.Fac_Cli_Fill(this.factura_DK_CenterDataSet.DataTable1, comboBox1.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }
    }
}
