
namespace NavegadorWeb
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Behind = new System.Windows.Forms.ToolStripButton();
            this.Ahead = new System.Windows.Forms.ToolStripButton();
            this.Refrescar = new System.Windows.Forms.ToolStripButton();
            this.Stop = new System.Windows.Forms.ToolStripButton();
            this.Home = new System.Windows.Forms.ToolStripButton();
            this.Url = new System.Windows.Forms.ToolStripTextBox();
            this.Search = new System.Windows.Forms.ToolStripButton();
            this.Navegador = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Behind,
            this.Ahead,
            this.Refrescar,
            this.Stop,
            this.Home,
            this.Url,
            this.Search});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Behind
            // 
            this.Behind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Behind.Image = ((System.Drawing.Image)(resources.GetObject("Behind.Image")));
            this.Behind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Behind.Name = "Behind";
            this.Behind.Size = new System.Drawing.Size(23, 22);
            this.Behind.Text = "toolStripButton1";
            this.Behind.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Ahead
            // 
            this.Ahead.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Ahead.Image = ((System.Drawing.Image)(resources.GetObject("Ahead.Image")));
            this.Ahead.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Ahead.Name = "Ahead";
            this.Ahead.Size = new System.Drawing.Size(23, 22);
            this.Ahead.Text = "toolStripButton2";
            this.Ahead.Click += new System.EventHandler(this.Ahead_Click);
            // 
            // Refrescar
            // 
            this.Refrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Refrescar.Image = ((System.Drawing.Image)(resources.GetObject("Refrescar.Image")));
            this.Refrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Refrescar.Name = "Refrescar";
            this.Refrescar.Size = new System.Drawing.Size(23, 22);
            this.Refrescar.Text = "toolStripButton3";
            this.Refrescar.Click += new System.EventHandler(this.Refrescar_Click);
            // 
            // Stop
            // 
            this.Stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Stop.Image = ((System.Drawing.Image)(resources.GetObject("Stop.Image")));
            this.Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(23, 22);
            this.Stop.Text = "toolStripButton4";
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Home
            // 
            this.Home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(23, 22);
            this.Home.Text = "toolStripButton5";
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Url
            // 
            this.Url.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Url.Name = "Url";
            this.Url.Size = new System.Drawing.Size(600, 25);
            // 
            // Search
            // 
            this.Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(23, 22);
            this.Search.Text = "toolStripButton6";
            this.Search.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // Navegador
            // 
            this.Navegador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Navegador.Location = new System.Drawing.Point(0, 25);
            this.Navegador.MinimumSize = new System.Drawing.Size(20, 20);
            this.Navegador.Name = "Navegador";
            this.Navegador.Size = new System.Drawing.Size(784, 536);
            this.Navegador.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Navegador);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zero Browser";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Behind;
        private System.Windows.Forms.ToolStripButton Ahead;
        private System.Windows.Forms.ToolStripButton Refrescar;
        private System.Windows.Forms.ToolStripButton Stop;
        private System.Windows.Forms.ToolStripButton Home;
        private System.Windows.Forms.ToolStripTextBox Url;
        private System.Windows.Forms.ToolStripButton Search;
        private System.Windows.Forms.WebBrowser Navegador;
    }
}

