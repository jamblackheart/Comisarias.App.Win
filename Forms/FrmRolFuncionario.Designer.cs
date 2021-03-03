namespace Comisarias.App.Escritorio.Forms
{
    partial class FrmRolFuncionario
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkConsultas = new System.Windows.Forms.CheckBox();
            this.chkRegistrarVisita = new System.Windows.Forms.CheckBox();
            this.chkProcedimientos = new System.Windows.Forms.CheckBox();
            this.chkParametros = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.motivoVisitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motivoVisitaBindingSource)).BeginInit();
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
            label17.Size = new System.Drawing.Size(183, 25);
            label17.TabIndex = 2;
            label17.Text = "ROL USUARIO(A)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDatos);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblMensaje);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 552);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ROL USUARIO";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(36, 72);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(518, 215);
            this.dgvDatos.TabIndex = 43;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkConsultas);
            this.groupBox5.Controls.Add(this.chkRegistrarVisita);
            this.groupBox5.Controls.Add(this.chkProcedimientos);
            this.groupBox5.Controls.Add(this.chkParametros);
            this.groupBox5.Location = new System.Drawing.Point(36, 321);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(518, 197);
            this.groupBox5.TabIndex = 75;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Roles";
            // 
            // chkConsultas
            // 
            this.chkConsultas.AutoSize = true;
            this.chkConsultas.Location = new System.Drawing.Point(56, 105);
            this.chkConsultas.Margin = new System.Windows.Forms.Padding(2);
            this.chkConsultas.Name = "chkConsultas";
            this.chkConsultas.Size = new System.Drawing.Size(99, 24);
            this.chkConsultas.TabIndex = 4;
            this.chkConsultas.Text = "Consultas";
            this.chkConsultas.UseVisualStyleBackColor = true;
            this.chkConsultas.CheckedChanged += new System.EventHandler(this.chkConsultas_CheckedChanged);
            // 
            // chkRegistrarVisita
            // 
            this.chkRegistrarVisita.AutoSize = true;
            this.chkRegistrarVisita.Location = new System.Drawing.Point(56, 75);
            this.chkRegistrarVisita.Margin = new System.Windows.Forms.Padding(2);
            this.chkRegistrarVisita.Name = "chkRegistrarVisita";
            this.chkRegistrarVisita.Size = new System.Drawing.Size(132, 24);
            this.chkRegistrarVisita.TabIndex = 2;
            this.chkRegistrarVisita.Text = "RegistrarVisita";
            this.chkRegistrarVisita.UseVisualStyleBackColor = true;
            this.chkRegistrarVisita.CheckedChanged += new System.EventHandler(this.chkRegistrarVisita_CheckedChanged);
            // 
            // chkProcedimientos
            // 
            this.chkProcedimientos.AutoSize = true;
            this.chkProcedimientos.Location = new System.Drawing.Point(56, 135);
            this.chkProcedimientos.Margin = new System.Windows.Forms.Padding(2);
            this.chkProcedimientos.Name = "chkProcedimientos";
            this.chkProcedimientos.Size = new System.Drawing.Size(137, 24);
            this.chkProcedimientos.TabIndex = 1;
            this.chkProcedimientos.Text = "Procedimientos";
            this.chkProcedimientos.UseVisualStyleBackColor = true;
            this.chkProcedimientos.CheckedChanged += new System.EventHandler(this.chkProcedimientos_CheckedChanged);
            // 
            // chkParametros
            // 
            this.chkParametros.AutoSize = true;
            this.chkParametros.Location = new System.Drawing.Point(56, 45);
            this.chkParametros.Margin = new System.Windows.Forms.Padding(2);
            this.chkParametros.Name = "chkParametros";
            this.chkParametros.Size = new System.Drawing.Size(110, 24);
            this.chkParametros.TabIndex = 0;
            this.chkParametros.Text = "Parametros";
            this.chkParametros.UseVisualStyleBackColor = true;
            this.chkParametros.CheckedChanged += new System.EventHandler(this.chkParametros_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Usuario(a)";
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
            this.pnlTitulo.Size = new System.Drawing.Size(766, 120);
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
            // FrmRolFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(783, 427);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRolFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar barequero";
            this.Load += new System.EventHandler(this.FrmRolFuncionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motivoVisitaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label19;
  //      private dbComisariaDataSet1 dbComisariaDataSet1;
        private System.Windows.Forms.BindingSource motivoVisitaBindingSource;
 //       private dbComisariaDataSet1TableAdapters.MotivoVisitaTableAdapter motivoVisitaTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkConsultas;
        private System.Windows.Forms.CheckBox chkRegistrarVisita;
        private System.Windows.Forms.CheckBox chkProcedimientos;
        private System.Windows.Forms.CheckBox chkParametros;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}