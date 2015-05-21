namespace dk_Center
{
    partial class Rep_Fac_Fech
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rep_Fac_Fech));
            this.L01PENCFAC1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factura_DK_CenterDataSet = new dk_Center.Factura_DK_CenterDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.l01PENCFACBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.l01PENCFACTableAdapter = new dk_Center.Factura_DK_CenterDataSetTableAdapters.L01PENCFACTableAdapter();
            this.L01PENCFAC1TableAdapter = new dk_Center.Factura_DK_CenterDataSetTableAdapters.L01PENCFAC1TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.L01PENCFAC1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura_DK_CenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.l01PENCFACBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // L01PENCFAC1BindingSource
            // 
            this.L01PENCFAC1BindingSource.DataMember = "L01PENCFAC1";
            this.L01PENCFAC1BindingSource.DataSource = this.factura_DK_CenterDataSet;
            // 
            // factura_DK_CenterDataSet
            // 
            this.factura_DK_CenterDataSet.DataSetName = "Factura_DK_CenterDataSet";
            this.factura_DK_CenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.L01PENCFAC1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dk_Center.Report_Fac_Fec.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 47);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(672, 363);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.l01PENCFACBindingSource;
            this.comboBox1.DisplayMember = "FECHA_EMI";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "FECHA_EMI";
            // 
            // l01PENCFACBindingSource
            // 
            this.l01PENCFACBindingSource.DataMember = "L01PENCFAC";
            this.l01PENCFACBindingSource.DataSource = this.factura_DK_CenterDataSet;
            // 
            // l01PENCFACTableAdapter
            // 
            this.l01PENCFACTableAdapter.ClearBeforeFill = true;
            // 
            // L01PENCFAC1TableAdapter
            // 
            this.L01PENCFAC1TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rep_Fac_Fech
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rep_Fac_Fech";
            this.Text = "Rep_Fac_Fech";
            this.Load += new System.EventHandler(this.Rep_Fac_Fech_Load);
            ((System.ComponentModel.ISupportInitialize)(this.L01PENCFAC1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura_DK_CenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.l01PENCFACBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Factura_DK_CenterDataSet factura_DK_CenterDataSet;
        private System.Windows.Forms.BindingSource l01PENCFACBindingSource;
        private Factura_DK_CenterDataSetTableAdapters.L01PENCFACTableAdapter l01PENCFACTableAdapter;
        private System.Windows.Forms.BindingSource L01PENCFAC1BindingSource;
        private Factura_DK_CenterDataSetTableAdapters.L01PENCFAC1TableAdapter L01PENCFAC1TableAdapter;
        private System.Windows.Forms.Button button1;
    }
}