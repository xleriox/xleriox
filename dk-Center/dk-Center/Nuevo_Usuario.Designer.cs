namespace dk_Center
{
    partial class Nuevo_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevo_Usuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.txt_usu = new System.Windows.Forms.TextBox();
            this.txt_cont = new System.Windows.Forms.TextBox();
            this.txt_con_val = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.cbx_car = new System.Windows.Forms.ComboBox();
            this.btn_acp = new System.Windows.Forms.Button();
            this.btn_can = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Validacion Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cargo:";
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(141, 23);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(173, 20);
            this.txt_cod.TabIndex = 6;
            // 
            // txt_usu
            // 
            this.txt_usu.Location = new System.Drawing.Point(141, 56);
            this.txt_usu.Name = "txt_usu";
            this.txt_usu.Size = new System.Drawing.Size(173, 20);
            this.txt_usu.TabIndex = 7;
            // 
            // txt_cont
            // 
            this.txt_cont.Location = new System.Drawing.Point(141, 88);
            this.txt_cont.Name = "txt_cont";
            this.txt_cont.PasswordChar = '*';
            this.txt_cont.Size = new System.Drawing.Size(173, 20);
            this.txt_cont.TabIndex = 8;
            // 
            // txt_con_val
            // 
            this.txt_con_val.Location = new System.Drawing.Point(141, 120);
            this.txt_con_val.Name = "txt_con_val";
            this.txt_con_val.PasswordChar = '*';
            this.txt_con_val.Size = new System.Drawing.Size(173, 20);
            this.txt_con_val.TabIndex = 9;
            this.txt_con_val.Validating += new System.ComponentModel.CancelEventHandler(this.txt_con_val_Validating);
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(141, 153);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(173, 20);
            this.txt_nom.TabIndex = 10;
            // 
            // cbx_car
            // 
            this.cbx_car.FormattingEnabled = true;
            this.cbx_car.Items.AddRange(new object[] {
            "Administrador",
            "Empleado Ventas"});
            this.cbx_car.Location = new System.Drawing.Point(141, 189);
            this.cbx_car.Name = "cbx_car";
            this.cbx_car.Size = new System.Drawing.Size(173, 21);
            this.cbx_car.TabIndex = 11;
            this.cbx_car.Text = "              --- seleccione ---";
            // 
            // btn_acp
            // 
            this.btn_acp.Location = new System.Drawing.Point(77, 255);
            this.btn_acp.Name = "btn_acp";
            this.btn_acp.Size = new System.Drawing.Size(75, 23);
            this.btn_acp.TabIndex = 12;
            this.btn_acp.Text = "Aceptar";
            this.btn_acp.UseVisualStyleBackColor = true;
            this.btn_acp.Click += new System.EventHandler(this.btn_acp_Click);
            // 
            // btn_can
            // 
            this.btn_can.Location = new System.Drawing.Point(297, 255);
            this.btn_can.Name = "btn_can";
            this.btn_can.Size = new System.Drawing.Size(75, 23);
            this.btn_can.TabIndex = 13;
            this.btn_can.Text = "Cancelar";
            this.btn_can.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Nuevo_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 335);
            this.Controls.Add(this.btn_can);
            this.Controls.Add(this.btn_acp);
            this.Controls.Add(this.cbx_car);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_con_val);
            this.Controls.Add(this.txt_cont);
            this.Controls.Add(this.txt_usu);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nuevo_Usuario";
            this.Text = "Nuevo_Usuario";
            this.Load += new System.EventHandler(this.Nuevo_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.TextBox txt_usu;
        private System.Windows.Forms.TextBox txt_cont;
        private System.Windows.Forms.TextBox txt_con_val;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.ComboBox cbx_car;
        private System.Windows.Forms.Button btn_acp;
        private System.Windows.Forms.Button btn_can;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}