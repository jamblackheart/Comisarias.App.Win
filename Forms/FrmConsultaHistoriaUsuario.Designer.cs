namespace Comisarias.App.Escritorio.Forms
{
    partial class FrmConsultaHistoriaUsuario
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
            System.Windows.Forms.Label label17;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaHistoriaUsuario));
            this.pnlVisitasAnteriores = new System.Windows.Forms.GroupBox();
            this.dgvVisitasAnteriores = new System.Windows.Forms.DataGridView();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCedulaConsultar = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblNombrePpal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.grbFechaNacimiento = new System.Windows.Forms.GroupBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lblDia = new System.Windows.Forms.Label();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.cmbGeneros = new System.Windows.Forms.ComboBox();
            this.lblGeneros = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCualEtnia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbtEtniaNo = new System.Windows.Forms.RadioButton();
            this.rbtEtniaSi = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCualDiscapacidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbtDiscapacidadNo = new System.Windows.Forms.RadioButton();
            this.rbtDiscapacidadSi = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtVictimaConfictoNo = new System.Windows.Forms.RadioButton();
            this.rbtVictimaConfictoSi = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbMotivoVisita = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvAgresiones = new System.Windows.Forms.DataGridView();
            label17 = new System.Windows.Forms.Label();
            this.pnlVisitasAnteriores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitasAnteriores)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.grbFechaNacimiento.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgresiones)).BeginInit();
            this.SuspendLayout();
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(58)))));
            label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            label17.Location = new System.Drawing.Point(309, 57);
            label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(315, 31);
            label17.TabIndex = 2;
            label17.Text = "CONSULTAR USUARIO";
            // 
            // pnlVisitasAnteriores
            // 
            this.pnlVisitasAnteriores.Controls.Add(this.dgvVisitasAnteriores);
            this.pnlVisitasAnteriores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlVisitasAnteriores.Location = new System.Drawing.Point(1155, 201);
            this.pnlVisitasAnteriores.Margin = new System.Windows.Forms.Padding(4);
            this.pnlVisitasAnteriores.Name = "pnlVisitasAnteriores";
            this.pnlVisitasAnteriores.Padding = new System.Windows.Forms.Padding(4);
            this.pnlVisitasAnteriores.Size = new System.Drawing.Size(528, 258);
            this.pnlVisitasAnteriores.TabIndex = 25;
            this.pnlVisitasAnteriores.TabStop = false;
            this.pnlVisitasAnteriores.Text = "Visitas Anteriores";
            this.pnlVisitasAnteriores.Visible = false;
            // 
            // dgvVisitasAnteriores
            // 
            this.dgvVisitasAnteriores.AllowUserToAddRows = false;
            this.dgvVisitasAnteriores.AllowUserToDeleteRows = false;
            this.dgvVisitasAnteriores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitasAnteriores.Location = new System.Drawing.Point(8, 50);
            this.dgvVisitasAnteriores.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVisitasAnteriores.Name = "dgvVisitasAnteriores";
            this.dgvVisitasAnteriores.ReadOnly = true;
            this.dgvVisitasAnteriores.RowHeadersWidth = 51;
            this.dgvVisitasAnteriores.Size = new System.Drawing.Size(496, 181);
            this.dgvVisitasAnteriores.TabIndex = 24;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(58)))));
            this.pnlTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTitulo.Controls.Add(this.pictureBox1);
            this.pnlTitulo.Controls.Add(label17);
            this.pnlTitulo.Controls.Add(this.label19);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1683, 147);
            this.pnlTitulo.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.label19.Location = new System.Drawing.Point(-8, 57);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(606, 42);
            this.label19.TabIndex = 1;
            this.label19.Text = "____________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(65, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula";
            // 
            // txtCedulaConsultar
            // 
            this.txtCedulaConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCedulaConsultar.Location = new System.Drawing.Point(157, 101);
            this.txtCedulaConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedulaConsultar.Name = "txtCedulaConsultar";
            this.txtCedulaConsultar.Size = new System.Drawing.Size(183, 30);
            this.txtCedulaConsultar.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConsultar.Location = new System.Drawing.Point(348, 100);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(109, 32);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMensaje.ForeColor = System.Drawing.Color.IndianRed;
            this.lblMensaje.Location = new System.Drawing.Point(385, 13);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(713, 82);
            this.lblMensaje.TabIndex = 38;
            // 
            // lblNombrePpal
            // 
            this.lblNombrePpal.AutoSize = true;
            this.lblNombrePpal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNombrePpal.Location = new System.Drawing.Point(408, 87);
            this.lblNombrePpal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrePpal.Name = "lblNombrePpal";
            this.lblNombrePpal.Size = new System.Drawing.Size(0, 25);
            this.lblNombrePpal.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(19, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Fecha Actual";
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFechaActual.Location = new System.Drawing.Point(154, 53);
            this.lblFechaActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(115, 25);
            this.lblFechaActual.TabIndex = 43;
            this.lblFechaActual.Text = "fechaActual";
            // 
            // grbFechaNacimiento
            // 
            this.grbFechaNacimiento.Controls.Add(this.lblAnio);
            this.grbFechaNacimiento.Controls.Add(this.lblMes);
            this.grbFechaNacimiento.Controls.Add(this.cmbAnio);
            this.grbFechaNacimiento.Controls.Add(this.cmbMes);
            this.grbFechaNacimiento.Controls.Add(this.lblDia);
            this.grbFechaNacimiento.Controls.Add(this.cmbDia);
            this.grbFechaNacimiento.Location = new System.Drawing.Point(452, 8);
            this.grbFechaNacimiento.Name = "grbFechaNacimiento";
            this.grbFechaNacimiento.Size = new System.Drawing.Size(462, 104);
            this.grbFechaNacimiento.TabIndex = 45;
            this.grbFechaNacimiento.TabStop = false;
            this.grbFechaNacimiento.Text = "Fecha nacimiento";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAnio.Location = new System.Drawing.Point(287, 33);
            this.lblAnio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(48, 25);
            this.lblAnio.TabIndex = 47;
            this.lblAnio.Text = "Año";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMes.Location = new System.Drawing.Point(146, 33);
            this.lblMes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(50, 25);
            this.lblMes.TabIndex = 45;
            this.lblMes.Text = "Mes";
            // 
            // cmbAnio
            // 
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Location = new System.Drawing.Point(292, 61);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(121, 33);
            this.cmbAnio.TabIndex = 48;
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(151, 61);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 33);
            this.cmbMes.TabIndex = 46;
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDia.Location = new System.Drawing.Point(11, 33);
            this.lblDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(41, 25);
            this.lblDia.TabIndex = 41;
            this.lblDia.Text = "Día";
            // 
            // cmbDia
            // 
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Location = new System.Drawing.Point(16, 61);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(121, 33);
            this.cmbDia.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(34, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nombres";
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombres.Location = new System.Drawing.Point(133, 26);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(192, 30);
            this.txtNombres.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(33, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtApellidos.Location = new System.Drawing.Point(133, 75);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(192, 30);
            this.txtApellidos.TabIndex = 49;
            // 
            // cmbGeneros
            // 
            this.cmbGeneros.FormattingEnabled = true;
            this.cmbGeneros.Location = new System.Drawing.Point(133, 124);
            this.cmbGeneros.Name = "cmbGeneros";
            this.cmbGeneros.Size = new System.Drawing.Size(192, 33);
            this.cmbGeneros.TabIndex = 51;
            // 
            // lblGeneros
            // 
            this.lblGeneros.AutoSize = true;
            this.lblGeneros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGeneros.Location = new System.Drawing.Point(48, 128);
            this.lblGeneros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeneros.Name = "lblGeneros";
            this.lblGeneros.Size = new System.Drawing.Size(77, 25);
            this.lblGeneros.TabIndex = 50;
            this.lblGeneros.Text = "Genero";
            // 
            // cmbArea
            // 
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(133, 176);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(192, 33);
            this.cmbArea.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(71, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 52;
            this.label5.Text = "Area";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(32, 329);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 54;
            this.label6.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDireccion.Location = new System.Drawing.Point(133, 326);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(288, 30);
            this.txtDireccion.TabIndex = 55;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCualEtnia);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rbtEtniaNo);
            this.groupBox2.Controls.Add(this.rbtEtniaSi);
            this.groupBox2.Location = new System.Drawing.Point(452, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 104);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pertenece a etnia?";
            // 
            // txtCualEtnia
            // 
            this.txtCualEtnia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCualEtnia.Location = new System.Drawing.Point(74, 60);
            this.txtCualEtnia.Margin = new System.Windows.Forms.Padding(4);
            this.txtCualEtnia.Name = "txtCualEtnia";
            this.txtCualEtnia.Size = new System.Drawing.Size(192, 30);
            this.txtCualEtnia.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 57;
            this.label7.Text = "Cúal?";
            // 
            // rbtEtniaNo
            // 
            this.rbtEtniaNo.AutoSize = true;
            this.rbtEtniaNo.Location = new System.Drawing.Point(160, 29);
            this.rbtEtniaNo.Name = "rbtEtniaNo";
            this.rbtEtniaNo.Size = new System.Drawing.Size(63, 29);
            this.rbtEtniaNo.TabIndex = 1;
            this.rbtEtniaNo.TabStop = true;
            this.rbtEtniaNo.Text = "NO";
            this.rbtEtniaNo.UseVisualStyleBackColor = true;
            // 
            // rbtEtniaSi
            // 
            this.rbtEtniaSi.AutoSize = true;
            this.rbtEtniaSi.Location = new System.Drawing.Point(62, 29);
            this.rbtEtniaSi.Name = "rbtEtniaSi";
            this.rbtEtniaSi.Size = new System.Drawing.Size(52, 29);
            this.rbtEtniaSi.TabIndex = 0;
            this.rbtEtniaSi.TabStop = true;
            this.rbtEtniaSi.Text = "SI";
            this.rbtEtniaSi.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCualDiscapacidad);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.rbtDiscapacidadNo);
            this.groupBox3.Controls.Add(this.rbtDiscapacidadSi);
            this.groupBox3.Location = new System.Drawing.Point(756, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 104);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Discapacidad?";
            // 
            // txtCualDiscapacidad
            // 
            this.txtCualDiscapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCualDiscapacidad.Location = new System.Drawing.Point(74, 60);
            this.txtCualDiscapacidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCualDiscapacidad.Name = "txtCualDiscapacidad";
            this.txtCualDiscapacidad.Size = new System.Drawing.Size(192, 30);
            this.txtCualDiscapacidad.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(6, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 57;
            this.label8.Text = "Cúal?";
            // 
            // rbtDiscapacidadNo
            // 
            this.rbtDiscapacidadNo.AutoSize = true;
            this.rbtDiscapacidadNo.Location = new System.Drawing.Point(173, 28);
            this.rbtDiscapacidadNo.Name = "rbtDiscapacidadNo";
            this.rbtDiscapacidadNo.Size = new System.Drawing.Size(63, 29);
            this.rbtDiscapacidadNo.TabIndex = 1;
            this.rbtDiscapacidadNo.TabStop = true;
            this.rbtDiscapacidadNo.Text = "NO";
            this.rbtDiscapacidadNo.UseVisualStyleBackColor = true;
            // 
            // rbtDiscapacidadSi
            // 
            this.rbtDiscapacidadSi.AutoSize = true;
            this.rbtDiscapacidadSi.Location = new System.Drawing.Point(76, 29);
            this.rbtDiscapacidadSi.Name = "rbtDiscapacidadSi";
            this.rbtDiscapacidadSi.Size = new System.Drawing.Size(52, 29);
            this.rbtDiscapacidadSi.TabIndex = 0;
            this.rbtDiscapacidadSi.TabStop = true;
            this.rbtDiscapacidadSi.Text = "SI";
            this.rbtDiscapacidadSi.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtVictimaConfictoNo);
            this.groupBox4.Controls.Add(this.rbtVictimaConfictoSi);
            this.groupBox4.Location = new System.Drawing.Point(756, 268);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(305, 84);
            this.groupBox4.TabIndex = 60;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Victima del conficto armado?";
            // 
            // rbtVictimaConfictoNo
            // 
            this.rbtVictimaConfictoNo.AutoSize = true;
            this.rbtVictimaConfictoNo.Location = new System.Drawing.Point(173, 37);
            this.rbtVictimaConfictoNo.Name = "rbtVictimaConfictoNo";
            this.rbtVictimaConfictoNo.Size = new System.Drawing.Size(63, 29);
            this.rbtVictimaConfictoNo.TabIndex = 1;
            this.rbtVictimaConfictoNo.TabStop = true;
            this.rbtVictimaConfictoNo.Text = "NO";
            this.rbtVictimaConfictoNo.UseVisualStyleBackColor = true;
            // 
            // rbtVictimaConfictoSi
            // 
            this.rbtVictimaConfictoSi.AutoSize = true;
            this.rbtVictimaConfictoSi.Location = new System.Drawing.Point(76, 37);
            this.rbtVictimaConfictoSi.Name = "rbtVictimaConfictoSi";
            this.rbtVictimaConfictoSi.Size = new System.Drawing.Size(52, 29);
            this.rbtVictimaConfictoSi.TabIndex = 0;
            this.rbtVictimaConfictoSi.TabStop = true;
            this.rbtVictimaConfictoSi.Text = "SI";
            this.rbtVictimaConfictoSi.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(36, 231);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 25);
            this.label10.TabIndex = 61;
            this.label10.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTelefono.Location = new System.Drawing.Point(133, 228);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(192, 30);
            this.txtTelefono.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(56, 280);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 25);
            this.label9.TabIndex = 63;
            this.label9.Text = "Email";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefrescar);
            this.groupBox1.Controls.Add(this.pnlRegistro);
            this.groupBox1.Controls.Add(this.lblFechaActual);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCedulaConsultar);
            this.groupBox1.Controls.Add(this.lblMensaje);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(16, 188);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1116, 689);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMACIÓN USUARIO";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRefrescar.Location = new System.Drawing.Point(986, 99);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(109, 32);
            this.btnRefrescar.TabIndex = 68;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.Controls.Add(this.grbFechaNacimiento);
            this.pnlRegistro.Controls.Add(this.label11);
            this.pnlRegistro.Controls.Add(this.cmbMotivoVisita);
            this.pnlRegistro.Controls.Add(this.txtEmail);
            this.pnlRegistro.Controls.Add(this.btnGuardar);
            this.pnlRegistro.Controls.Add(this.label9);
            this.pnlRegistro.Controls.Add(this.lblNombrePpal);
            this.pnlRegistro.Controls.Add(this.txtTelefono);
            this.pnlRegistro.Controls.Add(this.label2);
            this.pnlRegistro.Controls.Add(this.label10);
            this.pnlRegistro.Controls.Add(this.txtNombres);
            this.pnlRegistro.Controls.Add(this.groupBox4);
            this.pnlRegistro.Controls.Add(this.label4);
            this.pnlRegistro.Controls.Add(this.groupBox3);
            this.pnlRegistro.Controls.Add(this.txtApellidos);
            this.pnlRegistro.Controls.Add(this.groupBox2);
            this.pnlRegistro.Controls.Add(this.cmbGeneros);
            this.pnlRegistro.Controls.Add(this.txtDireccion);
            this.pnlRegistro.Controls.Add(this.lblGeneros);
            this.pnlRegistro.Controls.Add(this.label6);
            this.pnlRegistro.Controls.Add(this.cmbArea);
            this.pnlRegistro.Controls.Add(this.label5);
            this.pnlRegistro.Location = new System.Drawing.Point(24, 142);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(1085, 523);
            this.pnlRegistro.TabIndex = 67;
            this.pnlRegistro.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(130, 398);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 25);
            this.label11.TabIndex = 65;
            this.label11.Text = "Motivo de Visita";
            // 
            // cmbMotivoVisita
            // 
            this.cmbMotivoVisita.FormattingEnabled = true;
            this.cmbMotivoVisita.Location = new System.Drawing.Point(135, 431);
            this.cmbMotivoVisita.Name = "cmbMotivoVisita";
            this.cmbMotivoVisita.Size = new System.Drawing.Size(405, 33);
            this.cmbMotivoVisita.TabIndex = 66;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(133, 277);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(288, 30);
            this.txtEmail.TabIndex = 64;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGuardar.Location = new System.Drawing.Point(603, 398);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(256, 70);
            this.btnGuardar.TabIndex = 39;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(941, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvAgresiones);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox5.Location = new System.Drawing.Point(1155, 481);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(528, 258);
            this.groupBox5.TabIndex = 34;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Agresiones";
            this.groupBox5.Visible = false;
            // 
            // dgvAgresiones
            // 
            this.dgvAgresiones.AllowUserToAddRows = false;
            this.dgvAgresiones.AllowUserToDeleteRows = false;
            this.dgvAgresiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgresiones.Location = new System.Drawing.Point(8, 50);
            this.dgvAgresiones.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAgresiones.Name = "dgvAgresiones";
            this.dgvAgresiones.ReadOnly = true;
            this.dgvAgresiones.RowHeadersWidth = 51;
            this.dgvAgresiones.Size = new System.Drawing.Size(496, 181);
            this.dgvAgresiones.TabIndex = 24;
            // 
            // FrmConsultaHistoriaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1187, 752);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlVisitasAnteriores);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConsultaHistoriaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar barequero";
            this.Load += new System.EventHandler(this.FrmValidarBarequero_Load);
            this.pnlVisitasAnteriores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitasAnteriores)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.grbFechaNacimiento.ResumeLayout(false);
            this.grbFechaNacimiento.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgresiones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox pnlVisitasAnteriores;
        private System.Windows.Forms.DataGridView dgvVisitasAnteriores;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCedulaConsultar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblNombrePpal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.GroupBox grbFechaNacimiento;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ComboBox cmbAnio;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.ComboBox cmbGeneros;
        private System.Windows.Forms.Label lblGeneros;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCualEtnia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtEtniaNo;
        private System.Windows.Forms.RadioButton rbtEtniaSi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCualDiscapacidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbtDiscapacidadNo;
        private System.Windows.Forms.RadioButton rbtDiscapacidadSi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtVictimaConfictoNo;
        private System.Windows.Forms.RadioButton rbtVictimaConfictoSi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbMotivoVisita;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvAgresiones;
    }
}