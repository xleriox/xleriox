namespace dk_Center
{
    partial class medicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medicamentos));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bus_med = new System.Windows.Forms.TextBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.dataSet1 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medicamentos:";
            // 
            // txt_bus_med
            // 
            this.txt_bus_med.Location = new System.Drawing.Point(88, 12);
            this.txt_bus_med.Name = "txt_bus_med";
            this.txt_bus_med.Size = new System.Drawing.Size(502, 20);
            this.txt_bus_med.TabIndex = 2;
            this.txt_bus_med.TextChanged += new System.EventHandler(this.txt_bus_med_TextChanged);
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(15, 47);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(575, 279);
            this.dataGrid1.TabIndex = 3;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "Select * from L01MMER";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=EDMUNDOAPA\\SQLEXPRESS;Initial Catalog=DK-Center;Integrated Security=T" +
                "rue";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@COD_MER", System.Data.SqlDbType.Int, 0, "COD_MER"),
            new System.Data.SqlClient.SqlParameter("@NOMBRE_MER", System.Data.SqlDbType.NVarChar, 0, "NOMBRE_MER"),
            new System.Data.SqlClient.SqlParameter("@LAB_MER", System.Data.SqlDbType.NVarChar, 0, "LAB_MER"),
            new System.Data.SqlClient.SqlParameter("@LOTE_MER", System.Data.SqlDbType.NVarChar, 0, "LOTE_MER"),
            new System.Data.SqlClient.SqlParameter("@PRECIO_MER", System.Data.SqlDbType.Float, 0, "PRECIO_MER"),
            new System.Data.SqlClient.SqlParameter("@UNIDADES", System.Data.SqlDbType.NVarChar, 0, "UNIDADES"),
            new System.Data.SqlClient.SqlParameter("@STOCK_MER", System.Data.SqlDbType.Int, 0, "STOCK_MER")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@COD_MER", System.Data.SqlDbType.Int, 0, "COD_MER"),
            new System.Data.SqlClient.SqlParameter("@NOMBRE_MER", System.Data.SqlDbType.NVarChar, 0, "NOMBRE_MER"),
            new System.Data.SqlClient.SqlParameter("@LAB_MER", System.Data.SqlDbType.NVarChar, 0, "LAB_MER"),
            new System.Data.SqlClient.SqlParameter("@LOTE_MER", System.Data.SqlDbType.NVarChar, 0, "LOTE_MER"),
            new System.Data.SqlClient.SqlParameter("@PRECIO_MER", System.Data.SqlDbType.Float, 0, "PRECIO_MER"),
            new System.Data.SqlClient.SqlParameter("@UNIDADES", System.Data.SqlDbType.NVarChar, 0, "UNIDADES"),
            new System.Data.SqlClient.SqlParameter("@STOCK_MER", System.Data.SqlDbType.Int, 0, "STOCK_MER"),
            new System.Data.SqlClient.SqlParameter("@Original_COD_MER", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COD_MER", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_NOMBRE_MER", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NOMBRE_MER", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LAB_MER", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LAB_MER", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LAB_MER", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LAB_MER", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LOTE_MER", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LOTE_MER", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LOTE_MER", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LOTE_MER", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_PRECIO_MER", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PRECIO_MER", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_UNIDADES", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UNIDADES", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_STOCK_MER", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "STOCK_MER", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_COD_MER", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "COD_MER", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_NOMBRE_MER", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "NOMBRE_MER", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LAB_MER", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LAB_MER", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LAB_MER", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LAB_MER", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LOTE_MER", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LOTE_MER", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LOTE_MER", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LOTE_MER", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_PRECIO_MER", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PRECIO_MER", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_UNIDADES", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UNIDADES", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_STOCK_MER", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "STOCK_MER", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "L01MMER", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("COD_MER", "COD_MER"),
                        new System.Data.Common.DataColumnMapping("NOMBRE_MER", "NOMBRE_MER"),
                        new System.Data.Common.DataColumnMapping("LAB_MER", "LAB_MER"),
                        new System.Data.Common.DataColumnMapping("LOTE_MER", "LOTE_MER"),
                        new System.Data.Common.DataColumnMapping("PRECIO_MER", "PRECIO_MER"),
                        new System.Data.Common.DataColumnMapping("UNIDADES", "UNIDADES"),
                        new System.Data.Common.DataColumnMapping("STOCK_MER", "STOCK_MER")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 338);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.txt_bus_med);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "medicamentos";
            this.Text = "Medicamentos";
            this.Load += new System.EventHandler(this.medicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_bus_med;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Data.DataSet dataSet1;
    }
}