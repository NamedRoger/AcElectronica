namespace AcUsuarios
{
    partial class Usuarios
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.navbar1 = new LoginLib.Navbar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chxVentas = new System.Windows.Forms.CheckBox();
            this.chxInsumos = new System.Windows.Forms.CheckBox();
            this.cbxAlmacen = new System.Windows.Forms.CheckBox();
            this.cbxClientes = new System.Windows.Forms.CheckBox();
            this.cbxProveedores = new System.Windows.Forms.CheckBox();
            this.cbxUsuarios = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.txtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoInfo = new System.Windows.Forms.TextBox();
            this.txtNss = new System.Windows.Forms.TextBox();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaUsuarios = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 8;
            // 
            // navbar1
            // 
            this.navbar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navbar1.Location = new System.Drawing.Point(0, 0);
            this.navbar1.Name = "navbar1";
            this.navbar1.Size = new System.Drawing.Size(1094, 72);
            this.navbar1.TabIndex = 30;
            this.navbar1.Load += new System.EventHandler(this.navbar1_Load);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.chxVentas);
            this.panel1.Controls.Add(this.chxInsumos);
            this.panel1.Controls.Add(this.cbxAlmacen);
            this.panel1.Controls.Add(this.cbxClientes);
            this.panel1.Controls.Add(this.cbxProveedores);
            this.panel1.Controls.Add(this.cbxUsuarios);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtFechaAlta);
            this.panel1.Controls.Add(this.txtFechaNacimiento);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNoInfo);
            this.panel1.Controls.Add(this.txtNss);
            this.panel1.Controls.Add(this.txtCurp);
            this.panel1.Controls.Add(this.txtCelular);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 213);
            this.panel1.TabIndex = 31;
            // 
            // chxVentas
            // 
            this.chxVentas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chxVentas.AutoSize = true;
            this.chxVentas.Enabled = false;
            this.chxVentas.Location = new System.Drawing.Point(546, 179);
            this.chxVentas.Name = "chxVentas";
            this.chxVentas.Size = new System.Drawing.Size(60, 19);
            this.chxVentas.TabIndex = 61;
            this.chxVentas.Text = "Ventas";
            this.chxVentas.UseVisualStyleBackColor = true;
            // 
            // chxInsumos
            // 
            this.chxInsumos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chxInsumos.AutoSize = true;
            this.chxInsumos.Enabled = false;
            this.chxInsumos.Location = new System.Drawing.Point(469, 178);
            this.chxInsumos.Name = "chxInsumos";
            this.chxInsumos.Size = new System.Drawing.Size(71, 19);
            this.chxInsumos.TabIndex = 60;
            this.chxInsumos.Text = "Insumos";
            this.chxInsumos.UseVisualStyleBackColor = true;
            // 
            // cbxAlmacen
            // 
            this.cbxAlmacen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxAlmacen.AutoSize = true;
            this.cbxAlmacen.Enabled = false;
            this.cbxAlmacen.Location = new System.Drawing.Point(390, 179);
            this.cbxAlmacen.Name = "cbxAlmacen";
            this.cbxAlmacen.Size = new System.Drawing.Size(73, 19);
            this.cbxAlmacen.TabIndex = 59;
            this.cbxAlmacen.Text = "Almacen";
            this.cbxAlmacen.UseVisualStyleBackColor = true;
            // 
            // cbxClientes
            // 
            this.cbxClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxClientes.AutoSize = true;
            this.cbxClientes.Enabled = false;
            this.cbxClientes.Location = new System.Drawing.Point(316, 179);
            this.cbxClientes.Name = "cbxClientes";
            this.cbxClientes.Size = new System.Drawing.Size(68, 19);
            this.cbxClientes.TabIndex = 58;
            this.cbxClientes.Text = "Clientes";
            this.cbxClientes.UseVisualStyleBackColor = true;
            // 
            // cbxProveedores
            // 
            this.cbxProveedores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxProveedores.AutoSize = true;
            this.cbxProveedores.Enabled = false;
            this.cbxProveedores.Location = new System.Drawing.Point(219, 179);
            this.cbxProveedores.Name = "cbxProveedores";
            this.cbxProveedores.Size = new System.Drawing.Size(91, 19);
            this.cbxProveedores.TabIndex = 57;
            this.cbxProveedores.Text = "Proveedores";
            this.cbxProveedores.UseVisualStyleBackColor = true;
            // 
            // cbxUsuarios
            // 
            this.cbxUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbxUsuarios.AutoSize = true;
            this.cbxUsuarios.Enabled = false;
            this.cbxUsuarios.Location = new System.Drawing.Point(142, 179);
            this.cbxUsuarios.Name = "cbxUsuarios";
            this.cbxUsuarios.Size = new System.Drawing.Size(71, 19);
            this.cbxUsuarios.TabIndex = 56;
            this.cbxUsuarios.Text = "Usuarios";
            this.cbxUsuarios.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Location = new System.Drawing.Point(819, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // txtFechaAlta
            // 
            this.txtFechaAlta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFechaAlta.CustomFormat = "";
            this.txtFechaAlta.Enabled = false;
            this.txtFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaAlta.Location = new System.Drawing.Point(518, 140);
            this.txtFechaAlta.Name = "txtFechaAlta";
            this.txtFechaAlta.Size = new System.Drawing.Size(200, 23);
            this.txtFechaAlta.TabIndex = 54;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFechaNacimiento.Enabled = false;
            this.txtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(218, 140);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(200, 23);
            this.txtFechaNacimiento.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.Location = new System.Drawing.Point(457, 140);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(69, 35);
            this.label6.TabIndex = 52;
            this.label6.Text = "Fecha de Alta";
            // 
            // txtNoInfo
            // 
            this.txtNoInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNoInfo.Enabled = false;
            this.txtNoInfo.Location = new System.Drawing.Point(539, 102);
            this.txtNoInfo.Name = "txtNoInfo";
            this.txtNoInfo.Size = new System.Drawing.Size(179, 23);
            this.txtNoInfo.TabIndex = 51;
            // 
            // txtNss
            // 
            this.txtNss.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNss.Enabled = false;
            this.txtNss.Location = new System.Drawing.Point(215, 102);
            this.txtNss.Name = "txtNss";
            this.txtNss.Size = new System.Drawing.Size(193, 23);
            this.txtNss.TabIndex = 50;
            // 
            // txtCurp
            // 
            this.txtCurp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCurp.Enabled = false;
            this.txtCurp.Location = new System.Drawing.Point(587, 73);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(131, 23);
            this.txtCurp.TabIndex = 49;
            // 
            // txtCelular
            // 
            this.txtCelular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCelular.Enabled = false;
            this.txtCelular.Location = new System.Drawing.Point(402, 73);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(131, 23);
            this.txtCelular.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(352, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 15);
            this.label11.TabIndex = 47;
            this.label11.Text = "Celular";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(539, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 46;
            this.label10.Text = "Curp";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 15);
            this.label9.TabIndex = 45;
            this.label9.Text = "NSS";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(457, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 44;
            this.label8.Text = "No. Infonavit";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.Location = new System.Drawing.Point(142, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 35);
            this.label7.TabIndex = 43;
            this.label7.Text = "Fecha de Nacimiento";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(215, 73);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(131, 23);
            this.txtTelefono.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "Teléfono";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(215, 44);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(503, 23);
            this.txtAddress.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Dirección";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(513, 15);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(205, 23);
            this.txtPassword.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Contraseña";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(215, 15);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(205, 23);
            this.txtUserName.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Usuario";
            // 
            // tablaUsuarios
            // 
            this.tablaUsuarios.AllowDrop = true;
            this.tablaUsuarios.AllowUserToAddRows = false;
            this.tablaUsuarios.AllowUserToDeleteRows = false;
            this.tablaUsuarios.AllowUserToOrderColumns = true;
            this.tablaUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tablaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaUsuarios.Location = new System.Drawing.Point(12, 324);
            this.tablaUsuarios.Name = "tablaUsuarios";
            this.tablaUsuarios.ReadOnly = true;
            this.tablaUsuarios.RowTemplate.Height = 25;
            this.tablaUsuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaUsuarios.Size = new System.Drawing.Size(1070, 247);
            this.tablaUsuarios.TabIndex = 31;
            this.tablaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaUsuarios_CellClick);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1094, 609);
            this.Controls.Add(this.tablaUsuarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navbar1);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.Name = "Usuarios";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private LoginLib.Navbar navbar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbxAlmacen;
        private System.Windows.Forms.CheckBox cbxClientes;
        private System.Windows.Forms.CheckBox cbxProveedores;
        private System.Windows.Forms.CheckBox cbxUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker txtFechaAlta;
        private System.Windows.Forms.DateTimePicker txtFechaNacimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNoInfo;
        private System.Windows.Forms.TextBox txtNss;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaUsuarios;
        private System.Windows.Forms.CheckBox chxInsumos;
        private System.Windows.Forms.CheckBox chxVentas;
    }
}

