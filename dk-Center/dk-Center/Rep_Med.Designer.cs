namespace dk_Center
{
    partial class Rep_Med
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rep_Med));
            this.L01MMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Med_DK_CenterDataSet = new dk_Center.Med_DK_CenterDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.L01MMERTableAdapter = new dk_Center.Med_DK_CenterDataSetTableAdapters.L01MMERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.L01MMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Med_DK_CenterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // L01MMERBindingSource
            // 
            this.L01MMERBindingSource.DataMember = "L01MMER";
            this.L01MMERBindingSource.DataSource = this.Med_DK_CenterDataSet;
            // 
            // Med_DK_CenterDataSet
            // 
            this.Med_DK_CenterDataSet.DataSetName = "Med_DK_CenterDataSet";
            this.Med_DK_CenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.L01MMERBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "dk_Center.Report_Med.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(787, 349);
            this.reportViewer1.TabIndex = 0;
            // 
            // L01MMERTableAdapter
            // 
            this.L01MMERTableAdapter.ClearBeforeFill = true;
            // 
            // Rep_Med
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 349);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rep_Med";
            this.Text = "Rep_Med";
            this.Load += new System.EventHandler(this.Rep_Med_Load);
            ((System.ComponentModel.ISupportInitialize)(this.L01MMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Med_DK_CenterDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource L01MMERBindingSource;
        private Med_DK_CenterDataSet Med_DK_CenterDataSet;
        private Med_DK_CenterDataSetTableAdapters.L01MMERTableAdapter L01MMERTableAdapter;
    }
}