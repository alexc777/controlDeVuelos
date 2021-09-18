namespace ProyectoPrimerTrimestrePrograll
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminEmpresaToolStripMenuItem,
            this.administrarVuelosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminEmpresaToolStripMenuItem
            // 
            this.adminEmpresaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem,
            this.sucursalesToolStripMenuItem,
            this.empleadosToolStripMenuItem});
            this.adminEmpresaToolStripMenuItem.Enabled = false;
            this.adminEmpresaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.adminEmpresaToolStripMenuItem.Name = "adminEmpresaToolStripMenuItem";
            this.adminEmpresaToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.adminEmpresaToolStripMenuItem.Text = "Admin Empresa";
            this.adminEmpresaToolStripMenuItem.Visible = false;
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // sucursalesToolStripMenuItem
            // 
            this.sucursalesToolStripMenuItem.Name = "sucursalesToolStripMenuItem";
            this.sucursalesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sucursalesToolStripMenuItem.Text = "Sucursales";
            this.sucursalesToolStripMenuItem.Click += new System.EventHandler(this.sucursalesToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // administrarVuelosToolStripMenuItem
            // 
            this.administrarVuelosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeVuelosToolStripMenuItem});
            this.administrarVuelosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.administrarVuelosToolStripMenuItem.Name = "administrarVuelosToolStripMenuItem";
            this.administrarVuelosToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.administrarVuelosToolStripMenuItem.Text = "Administrar Vuelos";
            // 
            // listadoDeVuelosToolStripMenuItem
            // 
            this.listadoDeVuelosToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.listadoDeVuelosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.listadoDeVuelosToolStripMenuItem.Name = "listadoDeVuelosToolStripMenuItem";
            this.listadoDeVuelosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listadoDeVuelosToolStripMenuItem.Text = "Listado de vuelos";
            this.listadoDeVuelosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeVuelosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Vuelos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucursalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarVuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeVuelosToolStripMenuItem;
    }
}

