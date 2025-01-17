﻿namespace Comisarias.App.Escritorio.Forms
{
    partial class FrmFuncionario
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
            System.Windows.Forms.Label label17;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMedidasProteccion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlVentasMes = new System.Windows.Forms.GroupBox();
            this.dgvVentasMes = new System.Windows.Forms.DataGridView();
            this.pnlVentasAnio = new System.Windows.Forms.GroupBox();
            this.dgvVentasAno = new System.Windows.Forms.DataGridView();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dbComisariaDataSet1 = new Comisarias.App.Escritorio.dbComisariaDataSet1();
            this.motivoVisitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motivoVisitaTableAdapter = new Comisarias.App.Escritorio.dbComisariaDataSet1TableAdapters.MotivoVisitaTableAdapter();
            label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.pnlVentasMes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasMes)).BeginInit();
            this.pnlVentasAnio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasAno)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbComisariaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivoVisitaBindingSource)).BeginInit();
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
            label17.Size = new System.Drawing.Size(373, 31);
            label17.TabIndex = 2;
            label17.Text = "MEDIDAS DE PROTECCIÓN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefrescar);
            this.groupBox1.Controls.Add(this.dgvDatos);
            this.groupBox1.Controls.Add(this.Eliminar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.lblMensaje);
            this.groupBox1.Controls.Add(this.btnInsertar);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(16, 188);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1627, 498);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MEDIDAS DE PROTECCIÓN";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRefrescar.Location = new System.Drawing.Point(467, 457);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(199, 34);
            this.btnRefrescar.TabIndex = 43;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(45, 196);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(621, 254);
            this.dgvDatos.TabIndex = 42;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Eliminar.Location = new System.Drawing.Point(467, 130);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(199, 34);
            this.Eliminar.TabIndex = 41;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnActualizar.Location = new System.Drawing.Point(467, 89);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(199, 34);
            this.btnActualizar.TabIndex = 40;
            this.btnActualizar.Text = "Editar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
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
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnInsertar.Location = new System.Drawing.Point(467, 47);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(199, 34);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.Location = new System.Drawing.Point(163, 70);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 30);
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
            this.pnlTitulo.Size = new System.Drawing.Size(1759, 147);
            this.pnlTitulo.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(783, 15);
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
            // dbComisariaDataSet1
            // 
            this.dbComisariaDataSet1.DataSetName = "dbComisariaDataSet1";
            this.dbComisariaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // motivoVisitaBindingSource
            // 
            this.motivoVisitaBindingSource.DataMember = "MotivoVisita";
            this.motivoVisitaBindingSource.DataSource = this.dbComisariaDataSet1;
            // 
            // motivoVisitaTableAdapter
            // 
            this.motivoVisitaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMedidasProteccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1780, 750);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlVentasAnio);
            this.Controls.Add(this.pnlVentasMes);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMedidasProteccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar barequero";
            this.Load += new System.EventHandler(this.FrmMedidasProteccion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.pnlVentasMes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasMes)).EndInit();
            this.pnlVentasAnio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasAno)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbComisariaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivoVisitaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox pnlVentasMes;
        private System.Windows.Forms.DataGridView dgvVentasMes;
        private System.Windows.Forms.GroupBox pnlVentasAnio;
        private System.Windows.Forms.DataGridView dgvVentasAno;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label19;
        private dbComisariaDataSet1 dbComisariaDataSet1;
        private System.Windows.Forms.BindingSource motivoVisitaBindingSource;
        private dbComisariaDataSet1TableAdapters.MotivoVisitaTableAdapter motivoVisitaTableAdapter;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}