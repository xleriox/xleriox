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
    public partial class ReporteMenu : Form
    {
        public ReporteMenu()
        {
            InitializeComponent();
        }

        private void btn_med_Click(object sender, EventArgs e)
        {
            Rep_Med rp_m = new Rep_Med();
            rp_m.Show();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            Rep_Stock rp_s = new Rep_Stock();
            rp_s.Show();
        }

        private void btn_lab_Click(object sender, EventArgs e)
        {
            Rep_Lab rp_l = new Rep_Lab();
            rp_l.Show();
        }

        private void btn_uni_Click(object sender, EventArgs e)
        {
            Rep_Unid rp_u = new Rep_Unid();
            rp_u.Show();
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
            Rep_Com_Gen rpc_g = new Rep_Com_Gen();
            rpc_g.Show();

        }

        private void btn_fec_Click(object sender, EventArgs e)
        {
            Rep_Com_Fech rpc_f = new Rep_Com_Fech();
            rpc_f.Show();
        }

        private void btn_det_Click(object sender, EventArgs e)
        {
            Repo_Fac_Det rpf_d = new Repo_Fac_Det();
            rpf_d.Show();
        }

        private void btn_gen_fac_Click(object sender, EventArgs e)
        {
            Rep_Fac_Gen rpf_g = new Rep_Fac_Gen();
            rpf_g.Show();
        }

        private void btn_fec_fac_Click(object sender, EventArgs e)
        {
            Rep_Fac_Fech rpf_f = new Rep_Fac_Fech();
            rpf_f.Show();
        }

        private void btn_cli_Click(object sender, EventArgs e)
        {
            Rep_Fac_Cli rpf_c = new Rep_Fac_Cli();
            rpf_c.Show();
        }
    }
}
