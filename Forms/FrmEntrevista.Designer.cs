namespace Comisarias.App.Escritorio.Forms
{
    partial class FrmEntrevista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntrevista));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombrePpal = new System.Windows.Forms.Label();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnConsultarBarequero = new System.Windows.Forms.Button();
            this.txtCedulaConsultar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlVentasMes = new System.Windows.Forms.GroupBox();
            this.dgvVentasMes = new System.Windows.Forms.DataGridView();
            this.pnlVentasAnio = new System.Windows.Forms.GroupBox();
            this.dgvVentasAno = new System.Windows.Forms.DataGridView();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnlVentasMes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasMes)).BeginInit();
            this.pnlVentasAnio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasAno)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            label17.Size = new System.Drawing.Size(186, 31);
            label17.TabIndex = 2;
            label17.Text = "ENTREVISTA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombrePpal);
            this.groupBox1.Controls.Add(this.btnAprobar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.lblMensaje);
            this.groupBox1.Controls.Add(this.btnConsultarBarequero);
            this.groupBox1.Controls.Add(this.txtCedulaConsultar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(16, 188);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1627, 499);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMACIÓN USUARIO";
            // 
            // lblNombrePpal
            // 
            this.lblNombrePpal.AutoSize = true;
            this.lblNombrePpal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNombrePpal.Location = new System.Drawing.Point(429, 121);
            this.lblNombrePpal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrePpal.Name = "lblNombrePpal";
            this.lblNombrePpal.Size = new System.Drawing.Size(0, 25);
            this.lblNombrePpal.TabIndex = 40;
            // 
            // btnAprobar
            // 
            this.btnAprobar.Location = new System.Drawing.Point(796, 346);
            this.btnAprobar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(205, 58);
            this.btnAprobar.TabIndex = 34;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimpiar.Location = new System.Drawing.Point(1459, 148);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(156, 37);
            this.btnLimpiar.TabIndex = 39;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMensaje.ForeColor = System.Drawing.Color.IndianRed;
            this.lblMensaje.Location = new System.Drawing.Point(385, 13);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(713, 32);
            this.lblMensaje.TabIndex = 38;
            // 
            // btnConsultarBarequero
            // 
            this.btnConsultarBarequero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConsultarBarequero.Location = new System.Drawing.Point(163, 113);
            this.btnConsultarBarequero.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarBarequero.Name = "btnConsultarBarequero";
            this.btnConsultarBarequero.Size = new System.Drawing.Size(199, 48);
            this.btnConsultarBarequero.TabIndex = 2;
            this.btnConsultarBarequero.Text = "Consultar";
            this.btnConsultarBarequero.UseVisualStyleBackColor = true;
            // 
            // txtCedulaConsultar
            // 
            this.txtCedulaConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCedulaConsultar.Location = new System.Drawing.Point(163, 70);
            this.txtCedulaConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedulaConsultar.Name = "txtCedulaConsultar";
            this.txtCedulaConsultar.Size = new System.Drawing.Size(192, 30);
            this.txtCedulaConsultar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(40, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula";
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
            // FrmEntrevista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1711, 752);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlVentasAnio);
            this.Controls.Add(this.pnlVentasMes);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEntrevista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar barequero";
            this.Load += new System.EventHandler(this.FrmValidarBarequero_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlVentasMes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasMes)).EndInit();
            this.pnlVentasAnio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasAno)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultarBarequero;
        private System.Windows.Forms.TextBox txtCedulaConsultar;
        private System.Windows.Forms.GroupBox pnlVentasMes;
        private System.Windows.Forms.DataGridView dgvVentasMes;
        private System.Windows.Forms.GroupBox pnlVentasAnio;
        private System.Windows.Forms.DataGridView dgvVentasAno;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblNombrePpal;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}