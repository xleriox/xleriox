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
    public partial class Rep_Com_Fech : Form
    {
        public Rep_Com_Fech()
        {
            InitializeComponent();
        }

        private void Rep_Com_Fech_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Compras_DK_CenterDataSet.L01MCOM1' Puede moverla o quitarla según sea necesario.
            //this.L01MCOM1TableAdapter.Fecha_Fill(this.Compras_DK_CenterDataSet.L01MCOM1);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.L01MCOM1TableAdapter.Fecha_Fill(this.Compras_DK_CenterDataSet.L01MCOM1,textBox1.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
