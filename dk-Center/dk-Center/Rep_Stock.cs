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
    public partial class Rep_Stock : Form
    {
        public Rep_Stock()
        {
            InitializeComponent();
        }

        private void Rep_Stock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Med_DK_CenterDataSet.L01MMER1' Puede moverla o quitarla según sea necesario.
            //this.L01MMER1TableAdapter.Stock_Fill(this.Med_DK_CenterDataSet.L01MMER1,Convert.ToInt32(textBox1.Text));
            //this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.L01MMER1TableAdapter.Stock_Fill(this.Med_DK_CenterDataSet.L01MMER1, Convert.ToInt32(textBox1.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}
