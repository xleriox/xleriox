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
    public partial class Repo_Fac_Det : Form
    {
        public Repo_Fac_Det()
        {
            InitializeComponent();
        }

        private void Repo_Fac_Det_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Factura_DK_CenterDataSet.L01PENCFAC' Puede moverla o quitarla según sea necesario.
            this.l01PENCFACTableAdapter.Fill(this.Factura_DK_CenterDataSet.L01PENCFAC);
            // TODO: esta línea de código carga datos en la tabla 'Factura_DK_CenterDataSet.L02PDETFAC' Puede moverla o quitarla según sea necesario.
            this.L02PDETFACTableAdapter.Fac_Det_Fill(this.Factura_DK_CenterDataSet.L02PDETFAC,comboBox1.SelectedValue.ToString());

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.L02PDETFACTableAdapter.Fac_Det_Fill(this.Factura_DK_CenterDataSet.L02PDETFAC, comboBox1.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }
    }
}
