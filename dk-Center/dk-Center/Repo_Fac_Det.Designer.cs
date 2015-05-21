namespace dk_Center
{
    partial class Repo_Fac_Det
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Repo_Fac_Det));
            this.L02PDETFACBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Factura_DK_CenterDataSet = new dk_Center.Factura_DK_CenterDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.l01PENCFACBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.L02PDETFACTableAdapter = new dk_Center.Factura_DK_CenterDataSetTableAdapters.L02PDETFACTableAdapter();
            this.l01PENCFACTableAdapter = new dk_Center.Factura_DK_CenterDataSetTableAdapters.L01PENCFACTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.L02PDETFACBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Factura_DK_CenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l01PENCFACBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // L02PDETFACBindingSource
            // 
            this.L02PDETFACBindingSource.DataMember = "L02PDETFAC";
            this.L02PDETFACBindingSource.DataSource = this.Factura_DK_CenterDataSet;
            // 
            // Factura_DK_CenterDataSet
            // 
            this.Factura_DK_CenterDataSet.DataSetName = "Factura_DK_CenterDataSet";
            this.Factura_DK_CenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nro. Facturas:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.l01PENCFACBindingSource;
            this.comboBox1.DisplayMember = "NRO_FAC";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "NRO_FAC";
            // 
            // l01PENCFACBindingSource
            // 
            this.l01PENCFACBindingSource.DataMember = "L01PENCFAC";
            this.l01PENCFACBindingSource.DataSource = this.Factura_DK_CenterDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.L02PDETFACBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dk_Center.Report_Fac_Det.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 51);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(744, 367);
            this.reportViewer1.TabIndex = 3;
            // 
            // L02PDETFACTableAdapter
            // 
            this.L02PDETFACTableAdapter.ClearBeforeFill = true;
            // 
            // l01PENCFACTableAdapter
            // 
            this.l01PENCFACTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Repo_Fac_Det
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Repo_Fac_Det";
            this.Text = "Repo_Fac_Det";
            this.Load += new System.EventHandler(this.Repo_Fac_Det_Load);
            ((System.ComponentModel.ISupportInitialize)(this.L02PDETFACBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Factura_DK_CenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l01PENCFACBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource L02PDETFACBindingSource;
        private Factura_DK_CenterDataSet Factura_DK_CenterDataSet;
        private Factura_DK_CenterDataSetTableAdapters.L02PDETFACTableAdapter L02PDETFACTableAdapter;
        private System.Windows.Forms.BindingSource l01PENCFACBindingSource;
        private Factura_DK_CenterDataSetTableAdapters.L01PENCFACTableAdapter l01PENCFACTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}