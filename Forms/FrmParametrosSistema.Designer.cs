namespace Comisarias.App.Escritorio.Forms
{
    partial class FrmParametrosSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParametrosSistema));
            this.pnlVentasMes = new System.Windows.Forms.GroupBox();
            this.dgvVentasMes = new System.Windows.Forms.DataGridView();
            this.pnlVentasAnio = new System.Windows.Forms.GroupBox();
            this.dgvVentasAno = new System.Windows.Forms.DataGridView();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            this.pnlVentasMes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasMes)).BeginInit();
            this.pnlVentasAnio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasAno)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            label17.Size = new System.Drawing.Size(330, 31);
            label17.TabIndex = 2;
            label17.Text = "PARÁMETROS SISTEMA";
            // 
            // pnlVentasMes
            // 
            this.pnlVentasMes.Controls.Add(this.dgvVentasMes);
            this.pnlVentasMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlVentasMes.Location = new System.Drawing.Point(16, 1158);
            this.pnlVentasMes.Margin = new System.Windows.Forms.Padding(4);
            this.pnlVentasMes.Name = "pnlVentasMes";
            this.pnlVentasMes.Padding = new System.Windows.Forms.Padding(4);
            this.pnlVentasMes.Size = new System.Drawing.Size(1627, 302);
            this.pnlVentasMes.TabIndex = 25;
            this.pnlVentasMes.TabStop = false;
            this.pnlVentasMes.Text = "Ventas mes";
            this.pnlVentasMes.Visible = false;
            // 
            // dgvVentasMes
            // 
            this.dgvVentasMes.AllowUserToAddRows = false;
            this.dgvVentasMes.AllowUserToDeleteRows = false;
            this.dgvVentasMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasMes.Location = new System.Drawing.Point(8, 34);
            this.dgvVentasMes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVentasMes.Name = "dgvVentasMes";
            this.dgvVentasMes.ReadOnly = true;
            this.dgvVentasMes.RowHeadersWidth = 51;
            this.dgvVentasMes.Size = new System.Drawing.Size(1595, 254);
            this.dgvVentasMes.TabIndex = 24;
            // 
            // pnlVentasAnio
            // 
            this.pnlVentasAnio.Controls.Add(this.dgvVentasAno);
            this.pnlVentasAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlVentasAnio.Location = new System.Drawing.Point(16, 1481);
            this.pnlVentasAnio.Margin = new System.Windows.Forms.Padding(4);
            this.pnlVentasAnio.Name = "pnlVentasAnio";
            this.pnlVentasAnio.Padding = new System.Windows.Forms.Padding(4);
            this.pnlVentasAnio.Size = new System.Drawing.Size(1627, 305);
            this.pnlVentasAnio.TabIndex = 26;
            this.pnlVentasAnio.TabStop = false;
            this.pnlVentasAnio.Text = "Ventas año";
            this.pnlVentasAnio.Visible = false;
            // 
            // dgvVentasAno
            // 
            this.dgvVentasAno.AllowUserToAddRows = false;
            this.dgvVentasAno.AllowUserToDeleteRows = false;
            this.dgvVentasAno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasAno.Location = new System.Drawing.Point(8, 34);
            this.dgvVentasAno.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVentasAno.Name = "dgvVentasAno";
            this.dgvVentasAno.ReadOnly = true;
            this.dgvVentasAno.RowHeadersWidth = 51;
            this.dgvVentasAno.Size = new System.Drawing.Size(1595, 263);
            this.dgvVentasAno.TabIndex = 24;
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
            this.pnlTitulo.Size = new System.Drawing.Size(1690, 147);
            this.pnlTitulo.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(759, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLogo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRuta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMunicipio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDepartamento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblMensaje);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(24, 187);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1627, 498);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PARÁMETROS GENERALES";
            // 
            // txtLogo
            // 
            this.txtLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLogo.Location = new System.Drawing.Point(204, 238);
            this.txtLogo.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(413, 30);
            this.txtLogo.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(40, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 50;
            this.label4.Text = "Ruta Logo";
            // 
            // txtRuta
            // 
            this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRuta.Location = new System.Drawing.Point(204, 195);
            this.txtRuta.Margin = new System.Windows.Forms.Padding(4);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(413, 30);
            this.txtRuta.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(40, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Ruta BaseDatos";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMunicipio.Location = new System.Drawing.Point(204, 150);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(4);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(413, 30);
            this.txtMunicipio.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(40, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Municipio";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDepartamento.Location = new System.Drawing.Point(204, 109);
            this.txtDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(413, 30);
            this.txtDepartamento.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(40, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Departamento";
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMensaje.ForeColor = System.Drawing.Color.IndianRed;
            this.lblMensaje.Location = new System.Drawing.Point(385, 14);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(713, 32);
            this.lblMensaje.TabIndex = 38;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGuardar.Location = new System.Drawing.Point(418, 311);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(199, 34);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.Location = new System.Drawing.Point(204, 70);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(413, 30);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNombre.Location = new System.Drawing.Point(40, 70);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // FrmParametrosSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1711, 752);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlVentasAnio);
            this.Controls.Add(this.pnlVentasMes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmParametrosSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar barequero";
            this.Load += new System.EventHandler(this.FrmParametrosSistema_Load);
            this.pnlVentasMes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasMes)).EndInit();
            this.pnlVentasAnio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasAno)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox pnlVentasMes;
        private System.Windows.Forms.DataGridView dgvVentasMes;
        private System.Windows.Forms.GroupBox pnlVentasAnio;
        private System.Windows.Forms.DataGridView dgvVentasAno;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}