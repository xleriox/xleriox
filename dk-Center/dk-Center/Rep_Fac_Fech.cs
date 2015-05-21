using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dk_Center
{
    public partial class Rep_Fac_Fech : Form
    {
        public Rep_Fac_Fech()
        {
            InitializeComponent();
        }

        private void Rep_Fac_Fech_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'factura_DK_CenterDataSet.L01PENCFAC1' Puede moverla o quitarla según sea necesario.
           
            // TODO: esta línea de código carga datos en la tabla 'factura_DK_CenterDataSet.L01PENCFAC' Puede moverla o quitarla según sea necesario.
            this.l01PENCFACTableAdapter.Fill(this.factura_DK_CenterDataSet.L01PENCFAC);
            this.L01PENCFAC1TableAdapter.Fac_fec_Fill(this.factura_DK_CenterDataSet.L01PENCFAC1, comboBox1.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.L01PENCFAC1TableAdapter.Fac_fec_Fill(this.factura_DK_CenterDataSet.L01PENCFAC1, comboBox1.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }
    }
}
