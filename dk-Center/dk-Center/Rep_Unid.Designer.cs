namespace dk_Center
{
    partial class Rep_Unid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rep_Unid));
            this.L01MMER3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Med_DK_CenterDataSet = new dk_Center.Med_DK_CenterDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.L01MMER3TableAdapter = new dk_Center.Med_DK_CenterDataSetTableAdapters.L01MMER3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.L01MMER3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Med_DK_CenterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // L01MMER3BindingSource
            // 
            this.L01MMER3BindingSource.DataMember = "L01MMER3";
            this.L01MMER3BindingSource.DataSource = this.Med_DK_CenterDataSet;
            // 
            // Med_DK_CenterDataSet
            // 
            this.Med_DK_CenterDataSet.DataSetName = "Med_DK_CenterDataSet";
            this.Med_DK_CenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.L01MMER3BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dk_Center.Report_Unid.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 41);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(802, 353);
            this.reportViewer1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unidades";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // L01MMER3TableAdapter
            // 
            this.L01MMER3TableAdapter.ClearBeforeFill = true;
            // 
            // Rep_Unid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rep_Unid";
            this.Text = "Rep_Unid";
            this.Load += new System.EventHandler(this.Rep_Unid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.L01MMER3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Med_DK_CenterDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource L01MMER3BindingSource;
        private Med_DK_CenterDataSet Med_DK_CenterDataSet;
        private Med_DK_CenterDataSetTableAdapters.L01MMER3TableAdapter L01MMER3TableAdapter;
    }
}