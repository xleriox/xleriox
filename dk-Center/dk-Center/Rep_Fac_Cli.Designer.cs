namespace dk_Center
{
    partial class Rep_Fac_Cli
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rep_Fac_Cli));
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factura_DK_CenterDataSet = new dk_Center.Factura_DK_CenterDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.l01PENCFACBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.l01PENCFACTableAdapter = new dk_Center.Factura_DK_CenterDataSetTableAdapters.L01PENCFACTableAdapter();
            this.dataTable1TableAdapter = new dk_Center.Factura_DK_CenterDataSetTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura_DK_CenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l01PENCFACBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.factura_DK_CenterDataSet;
            // 
            // factura_DK_CenterDataSet
            // 
            this.factura_DK_CenterDataSet.DataSetName = "Factura_DK_CenterDataSet";
            this.factura_DK_CenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RUC:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.l01PENCFACBindingSource;
            this.comboBox1.DisplayMember = "RUC";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "RUC";
            // 
            // l01PENCFACBindingSource
            // 
            this.l01PENCFACBindingSource.DataMember = "L01PENCFAC";
            this.l01PENCFACBindingSource.DataSource = this.factura_DK_CenterDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.dataTable1BindingSource;
            this.comboBox2.DisplayMember = "NOMBRE_CLI";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(302, 8);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(283, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dk_Center.Report_Fac_Cli.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 51);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(609, 320);
            this.reportViewer1.TabIndex = 4;
            // 
            // l01PENCFACTableAdapter
            // 
            this.l01PENCFACTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // Rep_Fac_Cli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 433);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rep_Fac_Cli";
            this.Text = "Rep_Fac_Cli";
            this.Load += new System.EventHandler(this.Rep_Fac_Cli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura_DK_CenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l01PENCFACBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Factura_DK_CenterDataSet factura_DK_CenterDataSet;
        private System.Windows.Forms.BindingSource l01PENCFACBindingSource;
        private Factura_DK_CenterDataSetTableAdapters.L01PENCFACTableAdapter l01PENCFACTableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private Factura_DK_CenterDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    }
}