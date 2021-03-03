namespace Comisarias.App.Escritorio.Forms
{
    partial class FrmMotivoVisita
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.label19 = new System.Windows.Forms.Label();
            this.motivoVisitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motivoVisitaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
           
            label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.pnlVentasMes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasMes)).BeginInit();
            this.pnlVentasAnio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasAno)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motivoVisitaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivoVisitaBindingSource1)).BeginInit();
          
            this.SuspendLayout();
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(58)))));
            label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            label17.Location = new System.Drawing.Point(232, 46);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(214, 25);
            label17.TabIndex = 2;
            label17.Text = "MOTIVOS DE ATENCIÓN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDatos);
            this.groupBox1.Controls.Add(this.Eliminar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.lblMensaje);
            this.groupBox1.Controls.Add(this.btnInsertar);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1220, 405);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMACIÓN MOTIVO";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(34, 159);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(466, 206);
            this.dgvDatos.TabIndex = 42;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Eliminar.Location = new System.Drawing.Point(350, 106);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(149, 28);
            this.Eliminar.TabIndex = 41;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnActualizar.Location = new System.Drawing.Point(350, 72);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(149, 28);
            this.btnActualizar.TabIndex = 40;
            this.btnActualizar.Text = "Editar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMensaje.ForeColor = System.Drawing.Color.IndianRed;
            this.lblMensaje.Location = new System.Drawing.Point(289, 11);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(535, 26);
            this.lblMensaje.TabIndex = 38;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnInsertar.Location = new System.Drawing.Point(350, 38);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(149, 28);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.Location = new System.Drawing.Point(122, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(145, 26);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNombre.Location = new System.Drawing.Point(30, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // pnlVentasMes
            // 
            this.pnlVentasMes.Controls.Add(this.dgvVentasMes);
            this.pnlVentasMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlVentasMes.Location = new System.Drawing.Point(26, 941);
            this.pnlVentasMes.Name = "pnlVentasMes";
            this.pnlVentasMes.Size = new System.Drawing.Size(1525, 306);
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
            this.dgvVentasMes.Location = new System.Drawing.Point(6, 28);
            this.dgvVentasMes.Name = "dgvVentasMes";
            this.dgvVentasMes.ReadOnly = true;
            this.dgvVentasMes.RowHeadersWidth = 51;
            this.dgvVentasMes.Size = new System.Drawing.Size(1196, 206);
            this.dgvVentasMes.TabIndex = 24;
            // 
            // pnlVentasAnio
            // 
            this.pnlVentasAnio.Controls.Add(this.dgvVentasAno);
            this.pnlVentasAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlVentasAnio.Location = new System.Drawing.Point(26, 1269);
            this.pnlVentasAnio.Name = "pnlVentasAnio";
            this.pnlVentasAnio.Size = new System.Drawing.Size(1525, 310);
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
            this.dgvVentasAno.Location = new System.Drawing.Point(6, 28);
            this.dgvVentasAno.Name = "dgvVentasAno";
            this.dgvVentasAno.ReadOnly = true;
            this.dgvVentasAno.RowHeadersWidth = 51;
            this.dgvVentasAno.Size = new System.Drawing.Size(1196, 214);
            this.dgvVentasAno.TabIndex = 24;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(64)))), ((int)(((byte)(58)))));
            this.pnlTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTitulo.Controls.Add(label17);
            this.pnlTitulo.Controls.Add(this.label19);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1232, 120);
            this.pnlTitulo.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(200)))), ((int)(((byte)(176)))));
            this.label19.Location = new System.Drawing.Point(-6, 46);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(491, 33);
            this.label19.TabIndex = 1;
            this.label19.Text = "____________________________";
            // 
            // motivoVisitaBindingSource
            // 
            this.motivoVisitaBindingSource.DataMember = "MotivoVisita";
            // 
            // motivoVisitaBindingSource1
            // 
            this.motivoVisitaBindingSource1.DataMember = "MotivoVisita";
           
            // 
            // comisariaDataSet1
            // 
           
            // 
            // motivoVisitaTableAdapter
            // 
           
            // 
            // FrmMotivoVisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1172, 626);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlVentasAnio);
            this.Controls.Add(this.pnlVentasMes);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMotivoVisita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar barequero";
            this.Load += new System.EventHandler(this.FrmMotivoVisita_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.pnlVentasMes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasMes)).EndInit();
            this.pnlVentasAnio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasAno)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motivoVisitaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motivoVisitaBindingSource1)).EndInit();
         
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
     //   private dbComisariaDataSet1 dbComisariaDataSet1;
        private System.Windows.Forms.BindingSource motivoVisitaBindingSource;
       // private dbComisariaDataSet1TableAdapters.MotivoVisitaTableAdapter motivoVisitaTableAdapter;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button btnActualizar;
       
        private System.Windows.Forms.BindingSource motivoVisitaBindingSource1;
        
    }
}