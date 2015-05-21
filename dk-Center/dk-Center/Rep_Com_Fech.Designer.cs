namespace dk_Center
{
    partial class Rep_Com_Fech
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rep_Com_Fech));
            this.L01MCOM1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Compras_DK_CenterDataSet = new dk_Center.Compras_DK_CenterDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.L01MCOM1TableAdapter = new dk_Center.Compras_DK_CenterDataSetTableAdapters.L01MCOM1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.L01MCOM1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Compras_DK_CenterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // L01MCOM1BindingSource
            // 
            this.L01MCOM1BindingSource.DataMember = "L01MCOM1";
            this.L01MCOM1BindingSource.DataSource = this.Compras_DK_CenterDataSet;
            // 
            // Compras_DK_CenterDataSet
            // 
            this.Compras_DK_CenterDataSet.DataSetName = "Compras_DK_CenterDataSet";
            this.Compras_DK_CenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.L01MCOM1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dk_Center.Report_Comp_Fech.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 54);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(755, 349);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha(aaaa/mm/dd):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // L01MCOM1TableAdapter
            // 
            this.L01MCOM1TableAdapter.ClearBeforeFill = true;
            // 
            // Rep_Com_Fech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rep_Com_Fech";
            this.Text = "Rep_Com_Fech";
            this.Load += new System.EventHandler(this.Rep_Com_Fech_Load);
            ((System.ComponentModel.ISupportInitialize)(this.L01MCOM1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Compras_DK_CenterDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource L01MCOM1BindingSource;
        private Compras_DK_CenterDataSet Compras_DK_CenterDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private Compras_DK_CenterDataSetTableAdapters.L01MCOM1TableAdapter L01MCOM1TableAdapter;
    }
}