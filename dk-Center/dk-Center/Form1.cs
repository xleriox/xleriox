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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Med agm = new Agregar_Med();
            agm.MdiParent = this;
            agm.Show();
        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            medicamentos med = new medicamentos();
            med.MdiParent = this;
            med.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas v = new Ventas();
            v.MdiParent = this;
            v.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.ShowDialog();
        }
        private void salir()
        {
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes cl = new Clientes();
            cl.MdiParent = this;
            cl.Show();
        }

        private void repotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteMenu rpm = new ReporteMenu();
            rpm.MdiParent = this;
            rpm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ventas v = new Ventas();
            v.MdiParent = this;
            v.Show();
        }

        private void compraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Agregar_Med agm = new Agregar_Med();
            agm.MdiParent = this;
            agm.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_Med agm = new Agregar_Med();
            agm.MdiParent = this;
            agm.Show();
        }

        private void listaMedicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            medicamentos med = new medicamentos();
            med.MdiParent = this;
            med.Show();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cliente_nuevo cl_n = new Cliente_nuevo();
            cl_n.MdiParent = this;
            cl_n.Show();
        }

        private void listaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes cl = new Clientes();
            cl.MdiParent = this;
            cl.Show();
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rep_Fac_Gen rpf_g = new Rep_Fac_Gen();
            rpf_g.MdiParent = this;
            rpf_g.Show();
        }

        private void detalladaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Repo_Fac_Det rpf_d = new Repo_Fac_Det();
            rpf_d.MdiParent = this;
            rpf_d.Show();
        }

        private void fechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rep_Fac_Fech rpf_f = new Rep_Fac_Fech();
            rpf_f.MdiParent = this;
            rpf_f.Show();
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Rep_Fac_Cli rpf_c = new Rep_Fac_Cli();
            rpf_c.MdiParent = this;
            rpf_c.Show();
        }

        private void generalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Rep_Com_Gen rpc_g = new Rep_Com_Gen();
            rpc_g.MdiParent=this;
            rpc_g.Show();
        }

        private void fechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rep_Com_Fech rpc_f = new Rep_Com_Fech();
            rpc_f.MdiParent = this;
            rpc_f.Show();
        }

        private void medicamentosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Rep_Med rp_m = new Rep_Med();
            rp_m.MdiParent = this;
            rp_m.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rep_Stock rp_s = new Rep_Stock();
            rp_s.MdiParent = this;
            rp_s.Show();
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rep_Unid rp_u = new Rep_Unid();
            rp_u.MdiParent = this;
            rp_u.Show();
        }

        private void laboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rep_Lab rp_l = new Rep_Lab();
            rp_l.MdiParent = this;
            rp_l.Show();
        }

        private void bloquearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.ShowDialog();
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo_Usuario nvu = new Nuevo_Usuario();
            nvu.MdiParent = this;
            nvu.Show();
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.MdiParent = this;
            ab.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda a = new Ayuda();
            a.MdiParent = this;
            a.Show();
        }

    }
}
