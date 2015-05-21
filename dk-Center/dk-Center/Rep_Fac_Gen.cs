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
    public partial class Rep_Fac_Gen : Form
    {
        public Rep_Fac_Gen()
        {
            InitializeComponent();
        }

        private void Rep_Fac_Gen_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Factura_DK_CenterDataSet.L01PENCFAC' Puede moverla o quitarla según sea necesario.
            this.L01PENCFACTableAdapter.Fill(this.Factura_DK_CenterDataSet.L01PENCFAC);

            this.reportViewer1.RefreshReport();
        }
    }
}
