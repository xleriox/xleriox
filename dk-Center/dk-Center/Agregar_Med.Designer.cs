namespace dk_Center
{
    partial class Agregar_Med
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Med));
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_lab = new System.Windows.Forms.TextBox();
            this.txt_lot = new System.Windows.Forms.TextBox();
            this.txt_pre = new System.Windows.Forms.TextBox();
            this.txt_uni = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gp_nuevo = new System.Windows.Forms.GroupBox();
            this.gp_buscar = new System.Windows.Forms.GroupBox();
            this.cbx_med = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_bus_med = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.dataSet1 = new System.Data.DataSet();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_act = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_pre_com = new System.Windows.Forms.TextBox();
            this.dtp_fec_com = new System.Windows.Forms.DateTimePicker();
            this.txt_nro_fac = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gp_nuevo.SuspendLayout();
            this.gp_buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(80, 20);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(127, 20);
            this.txt_cod.TabIndex = 0;
            this.txt_cod.Validating += new System.ComponentModel.CancelEventHandler(this.txt_cod_Validating);
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(80, 48);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(275, 20);
            this.txt_nom.TabIndex = 1;
            // 
            // txt_lab
            // 
            this.txt_lab.Location = new System.Drawing.Point(80, 75);
            this.txt_lab.Name = "txt_lab";
            this.txt_lab.Size = new System.Drawing.Size(275, 20);
            this.txt_lab.TabIndex = 2;
            // 
            // txt_lot
            // 
            this.txt_lot.Location = new System.Drawing.Point(80, 101);
            this.txt_lot.Name = "txt_lot";
            this.txt_lot.Size = new System.Drawing.Size(127, 20);
            this.txt_lot.TabIndex = 3;
            // 
            // txt_pre
            // 
            this.txt_pre.Location = new System.Drawing.Point(80, 127);
            this.txt_pre.Name = "txt_pre";
            this.txt_pre.Size = new System.Drawing.Size(127, 20);
            this.txt_pre.TabIndex = 4;
            // 
            // txt_uni
            // 
            this.txt_uni.Location = new System.Drawing.Point(80, 153);
            this.txt_uni.Name = "txt_uni";
            this.txt_uni.Size = new System.Drawing.Size(66, 20);
            this.txt_uni.TabIndex = 5;
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(80, 179);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(66, 20);
            this.txt_stock.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Codigo Med:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Laboratorio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lote:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Unidades:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Stock:";
            // 
            // gp_nuevo
            // 
            this.gp_nuevo.Controls.Add(this.label4);
            this.gp_nuevo.Controls.Add(this.label7);
            this.gp_nuevo.Controls.Add(this.txt_cod);
            this.gp_nuevo.Controls.Add(this.label6);
            this.gp_nuevo.Controls.Add(this.txt_nom);
            this.gp_nuevo.Controls.Add(this.label5);
            this.gp_nuevo.Controls.Add(this.txt_lab);
            this.gp_nuevo.Controls.Add(this.txt_lot);
            this.gp_nuevo.Controls.Add(this.label3);
            this.gp_nuevo.Controls.Add(this.txt_pre);
            this.gp_nuevo.Controls.Add(this.label2);
            this.gp_nuevo.Controls.Add(this.txt_uni);
            this.gp_nuevo.Controls.Add(this.label1);
            this.gp_nuevo.Controls.Add(this.txt_stock);
            this.gp_nuevo.Enabled = false;
            this.gp_nuevo.Location = new System.Drawing.Point(13, 92);
            this.gp_nuevo.Name = "gp_nuevo";
            this.gp_nuevo.Size = new System.Drawing.Size(386, 216);
            this.gp_nuevo.TabIndex = 14;
            this.gp_nuevo.TabStop = false;
            // 
            // gp_buscar
            // 
            this.gp_buscar.Controls.Add(this.cbx_med);
            this.gp_buscar.Controls.Add(this.btn_buscar);
            this.gp_buscar.Controls.Add(this.txt_bus_med);
            this.gp_buscar.Controls.Add(this.label8);
            this.gp_buscar.Location = new System.Drawing.Point(13, 13);
            this.gp_buscar.Name = "gp_buscar";
            this.gp_buscar.Size = new System.Drawing.Size(486, 73);
            this.gp_buscar.TabIndex = 15;
            this.gp_buscar.TabStop = false;
            // 
            // cbx_med
            // 
            this.cbx_med.FormattingEnabled = true;
            this.cbx_med.Location = new System.Drawing.Point(90, 13);
            this.cbx_med.Name = "cbx_med";
            this.cbx_med.Size = new System.Drawing.Size(296, 21);
            this.cbx_med.TabIndex = 3;
            this.cbx_med.Text = "---Seleccione----";
            this.cbx_med.SelectedIndexChanged += new System.EventHandler(this.cbx_med_SelectedIndexChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(405, 41);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_bus_med
            // 
            this.txt_bus_med.Location = new System.Drawing.Point(90, 41);
            this.txt_bus_med.Name = "txt_bus_med";
            this.txt_bus_med.Size = new System.Drawing.Size(296, 20);
            this.txt_bus_med.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Medicamentos:";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(418, 109);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_nuevo.TabIndex = 16;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click_1);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(418, 258);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 18;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Enabled = false;
            this.btn_guardar.Location = new System.Drawing.Point(418, 159);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 14;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(418, 209);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 17;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_act
            // 
            this.btn_act.Location = new System.Drawing.Point(418, 306);
            this.btn_act.Name = "btn_act";
            this.btn_act.Size = new System.Drawing.Size(75, 23);
            this.btn_act.TabIndex = 19;
            this.btn_act.Text = "Actualizar";
            this.btn_act.UseVisualStyleBackColor = true;
            this.btn_act.Visible = false;
            this.btn_act.Click += new System.EventHandler(this.btn_act_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_pre_com);
            this.groupBox1.Controls.Add(this.dtp_fec_com);
            this.groupBox1.Controls.Add(this.txt_nro_fac);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(13, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 107);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Precio Compra:";
            // 
            // txt_pre_com
            // 
            this.txt_pre_com.Location = new System.Drawing.Point(115, 76);
            this.txt_pre_com.Name = "txt_pre_com";
            this.txt_pre_com.Size = new System.Drawing.Size(92, 20);
            this.txt_pre_com.TabIndex = 4;
            this.txt_pre_com.Validating += new System.ComponentModel.CancelEventHandler(this.txt_pre_com_Validating);
            // 
            // dtp_fec_com
            // 
            this.dtp_fec_com.Location = new System.Drawing.Point(115, 48);
            this.dtp_fec_com.Name = "dtp_fec_com";
            this.dtp_fec_com.Size = new System.Drawing.Size(200, 20);
            this.dtp_fec_com.TabIndex = 3;
            // 
            // txt_nro_fac
            // 
            this.txt_nro_fac.Location = new System.Drawing.Point(115, 19);
            this.txt_nro_fac.Name = "txt_nro_fac";
            this.txt_nro_fac.Size = new System.Drawing.Size(200, 20);
            this.txt_nro_fac.TabIndex = 2;
            this.txt_nro_fac.Validating += new System.ComponentModel.CancelEventHandler(this.txt_nro_fac_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Fecha de Compra:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nro. Factura:";
            // 
            // Agregar_Med
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 458);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_act);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.gp_buscar);
            this.Controls.Add(this.gp_nuevo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agregar_Med";
            this.Text = "Modificar Medicamento";
            this.Load += new System.EventHandler(this.Agregar_Med_Load);
            this.gp_nuevo.ResumeLayout(false);
            this.gp_nuevo.PerformLayout();
            this.gp_buscar.ResumeLayout(false);
            this.gp_buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_lab;
        private System.Windows.Forms.TextBox txt_lot;
        private System.Windows.Forms.TextBox txt_pre;
        private System.Windows.Forms.TextBox txt_uni;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gp_nuevo;
        private System.Windows.Forms.GroupBox gp_buscar;
        private System.Windows.Forms.ComboBox cbx_med;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_bus_med;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_act;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_fec_com;
        private System.Windows.Forms.TextBox txt_nro_fac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_pre_com;
        private System.Windows.Forms.Label label11;
    }
}