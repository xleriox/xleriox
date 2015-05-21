using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AcroPDFLib;


namespace dk_Center
{
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "c:\\ayuda.pdf";
            proc.Start();
            proc.Close();

        }
    }
}
