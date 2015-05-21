namespace dk_Center
{
    partial class Rep_Com_Gen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rep_Com_Gen));
            this.L01MCOMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Compras_DK_CenterDataSet = new dk_Center.Compras_DK_CenterDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.L01MCOMTableAdapter = new dk_Center.Compras_DK_CenterDataSetTableAdapters.L01MCOMTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.L01MCOMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Compras_DK_CenterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // L01MCOMBindingSource
            // 
            this.L01MCOMBindingSource.DataMember = "L01MCOM";
            this.L01MCOMBindingSource.DataSource = this.Compras_DK_CenterDataSet;
            // 
            // Compras_DK_CenterDataSet
            // 
            this.Compras_DK_CenterDataSet.DataSetName = "Compras_DK_CenterDataSet";
            this.Compras_DK_CenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.L01MCOMBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dk_Center.Report_Comp_Gen.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(691, 393);
            this.reportViewer1.TabIndex = 0;
            // 
            // L01MCOMTableAdapter
            // 
            this.L01MCOMTableAdapter.ClearBeforeFill = true;
            // 
            // Rep_Com_Gen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 393);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rep_Com_Gen";
            this.Text = "Rep_Com_Gen";
            this.Load += new System.EventHandler(this.Rep_Com_Gen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.L01MCOMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Compras_DK_CenterDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource L01MCOMBindingSource;
        private Compras_DK_CenterDataSet Compras_DK_CenterDataSet;
        private Compras_DK_CenterDataSetTableAdapters.L01MCOMTableAdapter L01MCOMTableAdapter;
    }
}