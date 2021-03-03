namespace Comisarias.App.Escritorio
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.parametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motivosDeVisitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relacionAgresorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosGeneralesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVisitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procedimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agresionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orientaciónALaVictimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrevistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioDeProcesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audienciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizacionIncumplimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizacionMedidasProtecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizacionTerminaciónMedidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actializacionCasoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rehacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.seleccionartodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.guardarcomoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contenidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.índiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametrosToolStripMenuItem,
            this.registrarVisitaToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.procedimientosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1229, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // parametrosToolStripMenuItem
            // 
            this.parametrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motivosDeVisitaToolStripMenuItem,
            this.relacionAgresorToolStripMenuItem,
            this.generosToolStripMenuItem,
            this.parametrosGeneralesToolStripMenuItem,
            this.funcionariosToolStripMenuItem,
            this.rolFuncionarioToolStripMenuItem});
            this.parametrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("parametrosToolStripMenuItem.Image")));
            this.parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            this.parametrosToolStripMenuItem.Size = new System.Drawing.Size(133, 34);
            this.parametrosToolStripMenuItem.Text = "Parametros";
            this.parametrosToolStripMenuItem.Visible = false;
            this.parametrosToolStripMenuItem.Click += new System.EventHandler(this.ConsultarBarequeroToolStripMenuItem_Click);
            // 
            // motivosDeVisitaToolStripMenuItem
            // 
            this.motivosDeVisitaToolStripMenuItem.Name = "motivosDeVisitaToolStripMenuItem";
            this.motivosDeVisitaToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.motivosDeVisitaToolStripMenuItem.Text = "Motivos de atención";
            this.motivosDeVisitaToolStripMenuItem.Click += new System.EventHandler(this.motivosDeVisitaToolStripMenuItem_Click);
            // 
            // relacionAgresorToolStripMenuItem
            // 
            this.relacionAgresorToolStripMenuItem.Name = "relacionAgresorToolStripMenuItem";
            this.relacionAgresorToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.relacionAgresorToolStripMenuItem.Text = "Relación agresor";
            this.relacionAgresorToolStripMenuItem.Click += new System.EventHandler(this.relacionAgresorToolStripMenuItem_Click);
            // 
            // generosToolStripMenuItem
            // 
            this.generosToolStripMenuItem.Name = "generosToolStripMenuItem";
            this.generosToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.generosToolStripMenuItem.Text = "Género";
            this.generosToolStripMenuItem.Click += new System.EventHandler(this.generosToolStripMenuItem_Click);
            // 
            // parametrosGeneralesToolStripMenuItem
            // 
            this.parametrosGeneralesToolStripMenuItem.Name = "parametrosGeneralesToolStripMenuItem";
            this.parametrosGeneralesToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.parametrosGeneralesToolStripMenuItem.Text = "Parámetros generales";
            this.parametrosGeneralesToolStripMenuItem.Click += new System.EventHandler(this.parametrosGeneralesToolStripMenuItem_Click);
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.funcionariosToolStripMenuItem.Text = "Funcionarios(as)";
            this.funcionariosToolStripMenuItem.Click += new System.EventHandler(this.funcionariosToolStripMenuItem_Click);
            // 
            // rolFuncionarioToolStripMenuItem
            // 
            this.rolFuncionarioToolStripMenuItem.Name = "rolFuncionarioToolStripMenuItem";
            this.rolFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.rolFuncionarioToolStripMenuItem.Text = "Rol funcionario(a)";
            this.rolFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.rolFuncionarioToolStripMenuItem_Click);
            // 
            // registrarVisitaToolStripMenuItem
            // 
            this.registrarVisitaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrarVisitaToolStripMenuItem.Image")));
            this.registrarVisitaToolStripMenuItem.Name = "registrarVisitaToolStripMenuItem";
            this.registrarVisitaToolStripMenuItem.Size = new System.Drawing.Size(155, 34);
            this.registrarVisitaToolStripMenuItem.Text = "Registrar casos";
            this.registrarVisitaToolStripMenuItem.Visible = false;
            this.registrarVisitaToolStripMenuItem.Click += new System.EventHandler(this.registrarVisitaToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historiaUsuarioToolStripMenuItem});
            this.consultasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultasToolStripMenuItem.Image")));
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(122, 34);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Visible = false;
            // 
            // historiaUsuarioToolStripMenuItem
            // 
            this.historiaUsuarioToolStripMenuItem.Name = "historiaUsuarioToolStripMenuItem";
            this.historiaUsuarioToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.historiaUsuarioToolStripMenuItem.Text = "Historia usuario(a)";
            this.historiaUsuarioToolStripMenuItem.Click += new System.EventHandler(this.historiaUsuarioToolStripMenuItem_Click);
            // 
            // procedimientosToolStripMenuItem
            // 
            this.procedimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agresionToolStripMenuItem,
            this.orientaciónALaVictimaToolStripMenuItem,
            this.entrevistaToolStripMenuItem,
            this.inicioDeProcesoToolStripMenuItem,
            this.audienciaToolStripMenuItem,
            this.actualizacionIncumplimientoToolStripMenuItem,
            this.actualizacionMedidasProtecciónToolStripMenuItem,
            this.actualizacionTerminaciónMedidasToolStripMenuItem,
            this.actializacionCasoToolStripMenuItem});
            this.procedimientosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("procedimientosToolStripMenuItem.Image")));
            this.procedimientosToolStripMenuItem.Name = "procedimientosToolStripMenuItem";
            this.procedimientosToolStripMenuItem.Size = new System.Drawing.Size(160, 34);
            this.procedimientosToolStripMenuItem.Text = "Procedimientos";
            this.procedimientosToolStripMenuItem.Visible = false;
            // 
            // agresionToolStripMenuItem
            // 
            this.agresionToolStripMenuItem.Name = "agresionToolStripMenuItem";
            this.agresionToolStripMenuItem.Size = new System.Drawing.Size(322, 24);
            this.agresionToolStripMenuItem.Text = "Agresión";
            this.agresionToolStripMenuItem.Click += new System.EventHandler(this.agresionToolStripMenuItem_Click);
            // 
            // orientaciónALaVictimaToolStripMenuItem
            // 
            this.orientaciónALaVictimaToolStripMenuItem.Name = "orientaciónALaVictimaToolStripMenuItem";
            this.orientaciónALaVictimaToolStripMenuItem.Size = new System.Drawing.Size(322, 24);
            this.orientaciónALaVictimaToolStripMenuItem.Text = "Orientación a la víctima";
            this.orientaciónALaVictimaToolStripMenuItem.Click += new System.EventHandler(this.orientaciónALaVictimaToolStripMenuItem_Click);
            // 
            // entrevistaToolStripMenuItem
            // 
            this.entrevistaToolStripMenuItem.Name = "entrevistaToolStripMenuItem";
            this.entrevistaToolStripMenuItem.Size = new System.Drawing.Size(322, 24);
            this.entrevistaToolStripMenuItem.Text = "Entrevista";
            this.entrevistaToolStripMenuItem.Click += new System.EventHandler(this.entrevistaToolStripMenuItem_Click);
            // 
            // inicioDeProcesoToolStripMenuItem
            // 
            this.inicioDeProcesoToolStripMenuItem.Name = "inicioDeProcesoToolStripMenuItem";
            this.inicioDeProcesoToolStripMenuItem.Size = new System.Drawing.Size(322, 24);
            this.inicioDeProcesoToolStripMenuItem.Text = "Inicio de proceso";
            this.inicioDeProcesoToolStripMenuItem.Click += new System.EventHandler(this.inicioDeProcesoToolStripMenuItem_Click);
            // 
            // audienciaToolStripMenuItem
            // 
            this.audienciaToolStripMenuItem.Name = "audienciaToolStripMenuItem";
            this.audienciaToolStripMenuItem.Size = new System.Drawing.Size(322, 24);
            this.audienciaToolStripMenuItem.Text = "Audiencia";
            this.audienciaToolStripMenuItem.Click += new System.EventHandler(this.audienciaToolStripMenuItem_Click);
            // 
            // actualizacionIncumplimientoToolStripMenuItem
            // 
            this.actualizacionIncumplimientoToolStripMenuItem.Name = "actualizacionIncumplimientoToolStripMenuItem";
            this.actualizacionIncumplimientoToolStripMenuItem.Size = new System.Drawing.Size(322, 24);
            this.actualizacionIncumplimientoToolStripMenuItem.Text = "Actualización Incumplimiento";
            this.actualizacionIncumplimientoToolStripMenuItem.Click += new System.EventHandler(this.actualizacionIncumplimientoToolStripMenuItem_Click);
            // 
            // actualizacionMedidasProtecciónToolStripMenuItem
            // 
            this.actualizacionMedidasProtecciónToolStripMenuItem.Name = "actualizacionMedidasProtecciónToolStripMenuItem";
            this.actualizacionMedidasProtecciónToolStripMenuItem.Size = new System.Drawing.Size(322, 24);
            this.actualizacionMedidasProtecciónToolStripMenuItem.Text = "Actualización Medidas Protección";
            this.actualizacionMedidasProtecciónToolStripMenuItem.Click += new System.EventHandler(this.actualizacionMedidasProtecciónToolStripMenuItem_Click);
            // 
            // actualizacionTerminaciónMedidasToolStripMenuItem
            // 
            this.actualizacionTerminaciónMedidasToolStripMenuItem.Name = "actualizacionTerminaciónMedidasToolStripMenuItem";
            this.actualizacionTerminaciónMedidasToolStripMenuItem.Size = new System.Drawing.Size(322, 24);
            this.actualizacionTerminaciónMedidasToolStripMenuItem.Text = "ActualizaciónTerminación Medidas";
            this.actualizacionTerminaciónMedidasToolStripMenuItem.Click += new System.EventHandler(this.actualizacionTerminaciónMedidasToolStripMenuItem_Click);
            // 
            // actializacionCasoToolStripMenuItem
            // 
            this.actializacionCasoToolStripMenuItem.Name = "actializacionCasoToolStripMenuItem";
            this.actializacionCasoToolStripMenuItem.Size = new System.Drawing.Size(322, 24);
            this.actializacionCasoToolStripMenuItem.Text = "Actualización Caso";
            this.actializacionCasoToolStripMenuItem.Click += new System.EventHandler(this.actializacionCasoToolStripMenuItem_Click);
            // 
            // personalizarToolStripMenuItem
            // 
            this.personalizarToolStripMenuItem.Name = "personalizarToolStripMenuItem";
            this.personalizarToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.personalizarToolStripMenuItem.Text = "&Personalizar";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.opcionesToolStripMenuItem.Text = "&Opciones";
            // 
            // deshacerToolStripMenuItem
            // 
            this.deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            this.deshacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.deshacerToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.deshacerToolStripMenuItem.Text = "&Deshacer";
            // 
            // rehacerToolStripMenuItem
            // 
            this.rehacerToolStripMenuItem.Name = "rehacerToolStripMenuItem";
            this.rehacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.rehacerToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.rehacerToolStripMenuItem.Text = "&Rehacer";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(193, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(193, 6);
            // 
            // seleccionartodoToolStripMenuItem
            // 
            this.seleccionartodoToolStripMenuItem.Name = "seleccionartodoToolStripMenuItem";
            this.seleccionartodoToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.seleccionartodoToolStripMenuItem.Text = "&Seleccionar todo";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(249, 6);
            // 
            // guardarcomoToolStripMenuItem
            // 
            this.guardarcomoToolStripMenuItem.Name = "guardarcomoToolStripMenuItem";
            this.guardarcomoToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.guardarcomoToolStripMenuItem.Text = "G&uardar como";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(249, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(249, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.salirToolStripMenuItem.Text = "&Salir";
            // 
            // contenidoToolStripMenuItem
            // 
            this.contenidoToolStripMenuItem.Name = "contenidoToolStripMenuItem";
            this.contenidoToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.contenidoToolStripMenuItem.Text = "&Contenido";
            // 
            // índiceToolStripMenuItem
            // 
            this.índiceToolStripMenuItem.Name = "índiceToolStripMenuItem";
            this.índiceToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.índiceToolStripMenuItem.Text = "Índic&e";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.buscarToolStripMenuItem.Text = "&Buscar";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(156, 6);
            // 
            // acercadeToolStripMenuItem
            // 
            this.acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
            this.acercadeToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.acercadeToolStripMenuItem.Text = "&Acerca de...";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1229, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sistema de gestión minera - Comisarias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem parametrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVisitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procedimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deshacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rehacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem seleccionartodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem guardarcomoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contenidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem índiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motivosDeVisitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relacionAgresorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosGeneralesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agresionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orientaciónALaVictimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrevistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioDeProcesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem audienciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizacionIncumplimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizacionMedidasProtecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizacionTerminaciónMedidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actializacionCasoToolStripMenuItem;
    }
}

