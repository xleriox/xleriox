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
    public partial class Rep_Med : Form
    {
        public Rep_Med()
        {
            InitializeComponent();
        }

        private void Rep_Med_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Med_DK_CenterDataSet.L01MMER' Puede moverla o quitarla según sea necesario.
            this.L01MMERTableAdapter.Fill(this.Med_DK_CenterDataSet.L01MMER);

            this.reportViewer1.RefreshReport();
        }
    }
}
