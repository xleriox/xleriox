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
    public partial class Rep_Com_Gen : Form
    {
        public Rep_Com_Gen()
        {
            InitializeComponent();
        }

        private void Rep_Com_Gen_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Compras_DK_CenterDataSet.L01MCOM' Puede moverla o quitarla según sea necesario.
            this.L01MCOMTableAdapter.Fill(this.Compras_DK_CenterDataSet.L01MCOM);

            this.reportViewer1.RefreshReport();
        }
    }
}
