namespace DEINT_WordMarcaBlanca
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
            this.navBar = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFuente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnColor = new System.Windows.Forms.ToolStripMenuItem();
            this.barraOpciones = new System.Windows.Forms.ToolStrip();
            this.tb = new System.Windows.Forms.RichTextBox();
            this.footer = new System.Windows.Forms.StatusStrip();
            this.navBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem});
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(800, 24);
            this.navBar.TabIndex = 0;
            this.navBar.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnAbrir,
            this.btnGuardar,
            this.btnSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(180, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(180, 22);
            this.btnAbrir.Text = "Abrir";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(180, 22);
            this.btnGuardar.Text = "Guardar";
            // 
            // btnSalir
            // 
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(180, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCortar,
            this.btnCopiar,
            this.btnPegar,
            this.btnBuscar,
            this.btnFuente,
            this.btnColor});
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // btnCortar
            // 
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(180, 22);
            this.btnCortar.Text = "Cortar";
            // 
            // btnCopiar
            // 
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(180, 22);
            this.btnCopiar.Text = "Copiar";
            // 
            // btnPegar
            // 
            this.btnPegar.Name = "btnPegar";
            this.btnPegar.Size = new System.Drawing.Size(180, 22);
            this.btnPegar.Text = "Pegar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(180, 22);
            this.btnBuscar.Text = "Buscar";
            // 
            // btnFuente
            // 
            this.btnFuente.Name = "btnFuente";
            this.btnFuente.Size = new System.Drawing.Size(180, 22);
            this.btnFuente.Text = "Fuente";
            // 
            // btnColor
            // 
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(180, 22);
            this.btnColor.Text = "Color";
            // 
            // barraOpciones
            // 
            this.barraOpciones.Location = new System.Drawing.Point(0, 24);
            this.barraOpciones.Name = "barraOpciones";
            this.barraOpciones.Size = new System.Drawing.Size(800, 25);
            this.barraOpciones.TabIndex = 1;
            this.barraOpciones.Text = "toolStrip1";
            // 
            // tb
            // 
            this.tb.Enabled = false;
            this.tb.Location = new System.Drawing.Point(12, 52);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(776, 373);
            this.tb.TabIndex = 2;
            this.tb.Text = "";
            // 
            // footer
            // 
            this.footer.Location = new System.Drawing.Point(0, 428);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(800, 22);
            this.footer.TabIndex = 3;
            this.footer.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.barraOpciones);
            this.Controls.Add(this.navBar);
            this.MainMenuStrip = this.navBar;
            this.Name = "Form1";
            this.Text = " WordMarcaBlanca";
            this.navBar.ResumeLayout(false);
            this.navBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip navBar;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnNuevo;
        private System.Windows.Forms.ToolStripMenuItem btnAbrir;
        private System.Windows.Forms.ToolStripMenuItem btnGuardar;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCortar;
        private System.Windows.Forms.ToolStripMenuItem btnCopiar;
        private System.Windows.Forms.ToolStripMenuItem btnPegar;
        private System.Windows.Forms.ToolStripMenuItem btnBuscar;
        private System.Windows.Forms.ToolStripMenuItem btnFuente;
        private System.Windows.Forms.ToolStripMenuItem btnColor;
        private System.Windows.Forms.ToolStrip barraOpciones;
        private System.Windows.Forms.RichTextBox tb;
        private System.Windows.Forms.StatusStrip footer;
    }
}

