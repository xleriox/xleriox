namespace dk_Center
{
    partial class ReporteMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteMenu));
            this.btn_det = new System.Windows.Forms.Button();
            this.btn_med = new System.Windows.Forms.Button();
            this.btn_gen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cli = new System.Windows.Forms.Button();
            this.btn_fec_fac = new System.Windows.Forms.Button();
            this.btn_gen_fac = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_fec = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_uni = new System.Windows.Forms.Button();
            this.btn_lab = new System.Windows.Forms.Button();
            this.btn_stock = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_det
            // 
            this.btn_det.Location = new System.Drawing.Point(15, 19);
            this.btn_det.Name = "btn_det";
            this.btn_det.Size = new System.Drawing.Size(117, 23);
            this.btn_det.TabIndex = 0;
            this.btn_det.Text = "Detallada";
            this.btn_det.UseVisualStyleBackColor = true;
            this.btn_det.Click += new System.EventHandler(this.btn_det_Click);
            // 
            // btn_med
            // 
            this.btn_med.Location = new System.Drawing.Point(15, 19);
            this.btn_med.Name = "btn_med";
            this.btn_med.Size = new System.Drawing.Size(132, 23);
            this.btn_med.TabIndex = 1;
            this.btn_med.Text = "Medicamento";
            this.btn_med.UseVisualStyleBackColor = true;
            this.btn_med.Click += new System.EventHandler(this.btn_med_Click);
            // 
            // btn_gen
            // 
            this.btn_gen.Location = new System.Drawing.Point(15, 19);
            this.btn_gen.Name = "btn_gen";
            this.btn_gen.Size = new System.Drawing.Size(128, 23);
            this.btn_gen.TabIndex = 2;
            this.btn_gen.Text = "General";
            this.btn_gen.UseVisualStyleBackColor = true;
            this.btn_gen.Click += new System.EventHandler(this.btn_gen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cli);
            this.groupBox1.Controls.Add(this.btn_fec_fac);
            this.groupBox1.Controls.Add(this.btn_gen_fac);
            this.groupBox1.Controls.Add(this.btn_det);
            this.groupBox1.Location = new System.Drawing.Point(197, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 181);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reporte Factura";
            // 
            // btn_cli
            // 
            this.btn_cli.Location = new System.Drawing.Point(15, 146);
            this.btn_cli.Name = "btn_cli";
            this.btn_cli.Size = new System.Drawing.Size(117, 23);
            this.btn_cli.TabIndex = 3;
            this.btn_cli.Text = "Clientes";
            this.btn_cli.UseVisualStyleBackColor = true;
            this.btn_cli.Click += new System.EventHandler(this.btn_cli_Click);
            // 
            // btn_fec_fac
            // 
            this.btn_fec_fac.Location = new System.Drawing.Point(15, 104);
            this.btn_fec_fac.Name = "btn_fec_fac";
            this.btn_fec_fac.Size = new System.Drawing.Size(117, 23);
            this.btn_fec_fac.TabIndex = 2;
            this.btn_fec_fac.Text = "Fecha";
            this.btn_fec_fac.UseVisualStyleBackColor = true;
            this.btn_fec_fac.Click += new System.EventHandler(this.btn_fec_fac_Click);
            // 
            // btn_gen_fac
            // 
            this.btn_gen_fac.Location = new System.Drawing.Point(15, 64);
            this.btn_gen_fac.Name = "btn_gen_fac";
            this.btn_gen_fac.Size = new System.Drawing.Size(117, 23);
            this.btn_gen_fac.TabIndex = 1;
            this.btn_gen_fac.Text = "General";
            this.btn_gen_fac.UseVisualStyleBackColor = true;
            this.btn_gen_fac.Click += new System.EventHandler(this.btn_gen_fac_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_fec);
            this.groupBox2.Controls.Add(this.btn_gen);
            this.groupBox2.Location = new System.Drawing.Point(107, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 108);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reporte Compra";
            // 
            // btn_fec
            // 
            this.btn_fec.Location = new System.Drawing.Point(15, 64);
            this.btn_fec.Name = "btn_fec";
            this.btn_fec.Size = new System.Drawing.Size(128, 23);
            this.btn_fec.TabIndex = 3;
            this.btn_fec.Text = "Fecha";
            this.btn_fec.UseVisualStyleBackColor = true;
            this.btn_fec.Click += new System.EventHandler(this.btn_fec_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_uni);
            this.groupBox3.Controls.Add(this.btn_lab);
            this.groupBox3.Controls.Add(this.btn_stock);
            this.groupBox3.Controls.Add(this.btn_med);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 181);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reporte Medicamentos";
            // 
            // btn_uni
            // 
            this.btn_uni.Location = new System.Drawing.Point(15, 146);
            this.btn_uni.Name = "btn_uni";
            this.btn_uni.Size = new System.Drawing.Size(132, 23);
            this.btn_uni.TabIndex = 4;
            this.btn_uni.Text = "Unidades";
            this.btn_uni.UseVisualStyleBackColor = true;
            this.btn_uni.Click += new System.EventHandler(this.btn_uni_Click);
            // 
            // btn_lab
            // 
            this.btn_lab.Location = new System.Drawing.Point(15, 104);
            this.btn_lab.Name = "btn_lab";
            this.btn_lab.Size = new System.Drawing.Size(132, 23);
            this.btn_lab.TabIndex = 3;
            this.btn_lab.Text = "Laboratorio";
            this.btn_lab.UseVisualStyleBackColor = true;
            this.btn_lab.Click += new System.EventHandler(this.btn_lab_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.Location = new System.Drawing.Point(15, 64);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(132, 23);
            this.btn_stock.TabIndex = 2;
            this.btn_stock.Text = "Stock";
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // ReporteMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 336);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteMenu";
            this.Text = "ReporteMenu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_det;
        private System.Windows.Forms.Button btn_med;
        private System.Windows.Forms.Button btn_gen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_fec_fac;
        private System.Windows.Forms.Button btn_gen_fac;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_fec;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.Button btn_uni;
        private System.Windows.Forms.Button btn_lab;
        private System.Windows.Forms.Button btn_cli;
    }
}