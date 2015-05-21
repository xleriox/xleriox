namespace dk_Center
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stock = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_can_med = new System.Windows.Forms.TextBox();
            this.txt_pre_med = new System.Windows.Forms.TextBox();
            this.txt_nom_med = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_med = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_ruc = new System.Windows.Forms.TextBox();
            this.txt_dir = new System.Windows.Forms.TextBox();
            this.txt_raz_soc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_val_ven = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_tot = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dt_ven = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_guia = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_cond = new System.Windows.Forms.TextBox();
            this.dt_emi = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_ord = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_igv = new System.Windows.Forms.TextBox();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.dataSet1 = new System.Data.DataSet();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_num_fac = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIDADES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LABORATORIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_UNITARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_VENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_elim = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stock);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_can_med);
            this.groupBox1.Controls.Add(this.txt_pre_med);
            this.groupBox1.Controls.Add(this.txt_nom_med);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_med);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(64, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicamentos";
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(556, 52);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(40, 16);
            this.stock.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stock:";
            // 
            // txt_can_med
            // 
            this.txt_can_med.Location = new System.Drawing.Point(455, 52);
            this.txt_can_med.Name = "txt_can_med";
            this.txt_can_med.Size = new System.Drawing.Size(39, 20);
            this.txt_can_med.TabIndex = 8;
            // 
            // txt_pre_med
            // 
            this.txt_pre_med.Enabled = false;
            this.txt_pre_med.Location = new System.Drawing.Point(302, 52);
            this.txt_pre_med.Name = "txt_pre_med";
            this.txt_pre_med.Size = new System.Drawing.Size(98, 20);
            this.txt_pre_med.TabIndex = 7;
            // 
            // txt_nom_med
            // 
            this.txt_nom_med.Enabled = false;
            this.txt_nom_med.Location = new System.Drawing.Point(52, 52);
            this.txt_nom_med.Name = "txt_nom_med";
            this.txt_nom_med.Size = new System.Drawing.Size(188, 20);
            this.txt_nom_med.TabIndex = 6;
            this.txt_nom_med.TextChanged += new System.EventHandler(this.txt_nom_med_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio Uni:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Medicamentos:";
            // 
            // cbx_med
            // 
            this.cbx_med.FormattingEnabled = true;
            this.cbx_med.Location = new System.Drawing.Point(82, 16);
            this.cbx_med.Name = "cbx_med";
            this.cbx_med.Size = new System.Drawing.Size(468, 21);
            this.cbx_med.TabIndex = 1;
            this.cbx_med.SelectedIndexChanged += new System.EventHandler(this.cbx_med_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_tel);
            this.groupBox2.Controls.Add(this.txt_ruc);
            this.groupBox2.Controls.Add(this.txt_dir);
            this.groupBox2.Controls.Add(this.txt_raz_soc);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(64, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Cliente";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(336, 60);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(158, 20);
            this.txt_tel.TabIndex = 7;
            // 
            // txt_ruc
            // 
            this.txt_ruc.Location = new System.Drawing.Point(82, 61);
            this.txt_ruc.Name = "txt_ruc";
            this.txt_ruc.Size = new System.Drawing.Size(178, 20);
            this.txt_ruc.TabIndex = 6;
            this.txt_ruc.Validating += new System.ComponentModel.CancelEventHandler(this.txt_ruc_Validating);
            // 
            // txt_dir
            // 
            this.txt_dir.Location = new System.Drawing.Point(82, 37);
            this.txt_dir.Name = "txt_dir";
            this.txt_dir.Size = new System.Drawing.Size(412, 20);
            this.txt_dir.TabIndex = 5;
            // 
            // txt_raz_soc
            // 
            this.txt_raz_soc.Location = new System.Drawing.Point(82, 13);
            this.txt_raz_soc.Name = "txt_raz_soc";
            this.txt_raz_soc.Size = new System.Drawing.Size(412, 20);
            this.txt_raz_soc.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Telefono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "RUC*:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Direccion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Razon Social:";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(154, 490);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 3;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(598, 490);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(577, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Valor de Venta : S/.";
            // 
            // txt_val_ven
            // 
            this.txt_val_ven.Enabled = false;
            this.txt_val_ven.Location = new System.Drawing.Point(684, 143);
            this.txt_val_ven.Name = "txt_val_ven";
            this.txt_val_ven.Size = new System.Drawing.Size(95, 20);
            this.txt_val_ven.TabIndex = 6;
            this.txt_val_ven.TextChanged += new System.EventHandler(this.txt_val_ven_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(623, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Total : S/.";
            // 
            // txt_tot
            // 
            this.txt_tot.Enabled = false;
            this.txt_tot.Location = new System.Drawing.Point(684, 193);
            this.txt_tot.Name = "txt_tot";
            this.txt_tot.Size = new System.Drawing.Size(95, 20);
            this.txt_tot.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dt_ven);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txt_guia);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txt_cond);
            this.groupBox3.Controls.Add(this.dt_emi);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_ord);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(64, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(688, 69);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // dt_ven
            // 
            this.dt_ven.Location = new System.Drawing.Point(479, 43);
            this.dt_ven.Name = "dt_ven";
            this.dt_ven.Size = new System.Drawing.Size(203, 20);
            this.dt_ven.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(372, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Fecha Vencimiento:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(394, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Fecha Emision:";
            // 
            // txt_guia
            // 
            this.txt_guia.Location = new System.Drawing.Point(266, 14);
            this.txt_guia.Name = "txt_guia";
            this.txt_guia.Size = new System.Drawing.Size(100, 20);
            this.txt_guia.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(222, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "N° Guia:";
            // 
            // txt_cond
            // 
            this.txt_cond.Location = new System.Drawing.Point(101, 43);
            this.txt_cond.Name = "txt_cond";
            this.txt_cond.Size = new System.Drawing.Size(115, 20);
            this.txt_cond.TabIndex = 3;
            // 
            // dt_emi
            // 
            this.dt_emi.Location = new System.Drawing.Point(479, 15);
            this.dt_emi.Name = "dt_emi";
            this.dt_emi.Size = new System.Drawing.Size(203, 20);
            this.dt_emi.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Condicion:";
            // 
            // txt_ord
            // 
            this.txt_ord.Location = new System.Drawing.Point(101, 15);
            this.txt_ord.Name = "txt_ord";
            this.txt_ord.Size = new System.Drawing.Size(115, 20);
            this.txt_ord.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Orden de Compra:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(606, 172);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "IGV 18% : S/.";
            // 
            // txt_igv
            // 
            this.txt_igv.Enabled = false;
            this.txt_igv.Location = new System.Drawing.Point(684, 167);
            this.txt_igv.Name = "txt_igv";
            this.txt_igv.Size = new System.Drawing.Size(95, 20);
            this.txt_igv.TabIndex = 11;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        COD_MER, NOMBRE_MER, LAB_MER, LOTE_MER, PRECIO_MER, UNIDADES, STOCK" +
                "_MER\r\nFROM            L01MMER";
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
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(510, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "N° Factura:";
            // 
            // txt_num_fac
            // 
            this.txt_num_fac.Location = new System.Drawing.Point(572, 8);
            this.txt_num_fac.Name = "txt_num_fac";
            this.txt_num_fac.Size = new System.Drawing.Size(169, 20);
            this.txt_num_fac.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(281, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(112, 24);
            this.label20.TabIndex = 15;
            this.label20.Text = "FACTURA";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.CANTIDAD,
            this.UNIDADES,
            this.DESCRIPCION,
            this.LOTE,
            this.LABORATORIO,
            this.PRECIO_UNITARIO,
            this.PRECIO_VENTA});
            this.dataGridView1.Location = new System.Drawing.Point(12, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(824, 172);
            this.dataGridView1.TabIndex = 16;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "CODIGO";
            this.Codigo.MaxInputLength = 7;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 75;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANT.";
            this.CANTIDAD.MaxInputLength = 3;
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.Width = 40;
            // 
            // UNIDADES
            // 
            this.UNIDADES.HeaderText = "UNID.";
            this.UNIDADES.MaxInputLength = 10;
            this.UNIDADES.Name = "UNIDADES";
            this.UNIDADES.Width = 70;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.Width = 290;
            // 
            // LOTE
            // 
            this.LOTE.HeaderText = "LOTE";
            this.LOTE.MaxInputLength = 10;
            this.LOTE.Name = "LOTE";
            this.LOTE.Width = 90;
            // 
            // LABORATORIO
            // 
            this.LABORATORIO.HeaderText = "LABORATORIO";
            this.LABORATORIO.Name = "LABORATORIO";
            this.LABORATORIO.Width = 85;
            // 
            // PRECIO_UNITARIO
            // 
            this.PRECIO_UNITARIO.HeaderText = "PREC. UNIT.";
            this.PRECIO_UNITARIO.MaxInputLength = 10;
            this.PRECIO_UNITARIO.Name = "PRECIO_UNITARIO";
            this.PRECIO_UNITARIO.Width = 65;
            // 
            // PRECIO_VENTA
            // 
            this.PRECIO_VENTA.HeaderText = "PREC. VENT.";
            this.PRECIO_VENTA.MaxInputLength = 10;
            this.PRECIO_VENTA.Name = "PRECIO_VENTA";
            this.PRECIO_VENTA.Width = 65;
            // 
            // btn_elim
            // 
            this.btn_elim.Location = new System.Drawing.Point(389, 490);
            this.btn_elim.Name = "btn_elim";
            this.btn_elim.Size = new System.Drawing.Size(75, 23);
            this.btn_elim.TabIndex = 17;
            this.btn_elim.Text = "Eliminar";
            this.btn_elim.UseVisualStyleBackColor = true;
            this.btn_elim.Click += new System.EventHandler(this.btn_elim_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.OriginAtMargins = true;
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            this.printDocument1.QueryPageSettings += new System.Drawing.Printing.QueryPageSettingsEventHandler(this.printDocument1_QueryPageSettings);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 530);
            this.Controls.Add(this.btn_elim);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txt_num_fac);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt_igv);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txt_tot);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_val_ven);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_can_med;
        private System.Windows.Forms.TextBox txt_pre_med;
        private System.Windows.Forms.TextBox txt_nom_med;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_med;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_ruc;
        private System.Windows.Forms.TextBox txt_dir;
        private System.Windows.Forms.TextBox txt_raz_soc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_val_ven;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_tot;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dt_ven;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_guia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_cond;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_ord;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dt_emi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_igv;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_num_fac;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIDADES;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn LABORATORIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_UNITARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_VENTA;
        private System.Windows.Forms.Button btn_elim;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}