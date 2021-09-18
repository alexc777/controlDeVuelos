namespace ProyectoPrimerTrimestrePrograll
{
    partial class SucursalForm
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
            this.GvSucursal = new System.Windows.Forms.DataGridView();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.btn_cargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GvSucursal)).BeginInit();
            this.SuspendLayout();
            // 
            // GvSucursal
            // 
            this.GvSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvSucursal.Location = new System.Drawing.Point(12, 93);
            this.GvSucursal.Name = "GvSucursal";
            this.GvSucursal.Size = new System.Drawing.Size(541, 206);
            this.GvSucursal.TabIndex = 0;
            // 
            // btn_Crear
            // 
            this.btn_Crear.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Crear.ForeColor = System.Drawing.Color.White;
            this.btn_Crear.Location = new System.Drawing.Point(42, 25);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(97, 38);
            this.btn_Crear.TabIndex = 1;
            this.btn_Crear.Text = "Crear Sucursal";
            this.btn_Crear.UseVisualStyleBackColor = false;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // btn_cargar
            // 
            this.btn_cargar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_cargar.ForeColor = System.Drawing.Color.White;
            this.btn_cargar.Location = new System.Drawing.Point(165, 25);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(105, 38);
            this.btn_cargar.TabIndex = 2;
            this.btn_cargar.Text = "Cargar Sucursales";
            this.btn_cargar.UseVisualStyleBackColor = false;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // SucursalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(593, 353);
            this.Controls.Add(this.btn_cargar);
            this.Controls.Add(this.btn_Crear);
            this.Controls.Add(this.GvSucursal);
            this.Name = "SucursalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sucursales";
            ((System.ComponentModel.ISupportInitialize)(this.GvSucursal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GvSucursal;
        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.Button btn_cargar;
    }
}