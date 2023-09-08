namespace FRONT
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMStreamingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNFORMESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mayorDuraciónCategoríaYMontoRecaudadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menorDuraciónCategoríaYMontoRecaudadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.montoTotalPorCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMToolStripMenuItem,
            this.iNFORMESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aBMToolStripMenuItem
            // 
            this.aBMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMClienteToolStripMenuItem,
            this.aBMStreamingToolStripMenuItem});
            this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            this.aBMToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.aBMToolStripMenuItem.Text = "ABM";
            // 
            // aBMClienteToolStripMenuItem
            // 
            this.aBMClienteToolStripMenuItem.Name = "aBMClienteToolStripMenuItem";
            this.aBMClienteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aBMClienteToolStripMenuItem.Text = "ABMCliente";
            this.aBMClienteToolStripMenuItem.Click += new System.EventHandler(this.aBMClienteToolStripMenuItem_Click);
            // 
            // aBMStreamingToolStripMenuItem
            // 
            this.aBMStreamingToolStripMenuItem.Name = "aBMStreamingToolStripMenuItem";
            this.aBMStreamingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aBMStreamingToolStripMenuItem.Text = "ABMStreaming";
            this.aBMStreamingToolStripMenuItem.Click += new System.EventHandler(this.aBMStreamingToolStripMenuItem_Click);
            // 
            // iNFORMESToolStripMenuItem
            // 
            this.iNFORMESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mayorDuraciónCategoríaYMontoRecaudadoToolStripMenuItem,
            this.menorDuraciónCategoríaYMontoRecaudadoToolStripMenuItem,
            this.montoTotalPorCategoríaToolStripMenuItem});
            this.iNFORMESToolStripMenuItem.Name = "iNFORMESToolStripMenuItem";
            this.iNFORMESToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.iNFORMESToolStripMenuItem.Text = "INFORMES";
            // 
            // mayorDuraciónCategoríaYMontoRecaudadoToolStripMenuItem
            // 
            this.mayorDuraciónCategoríaYMontoRecaudadoToolStripMenuItem.Name = "mayorDuraciónCategoríaYMontoRecaudadoToolStripMenuItem";
            this.mayorDuraciónCategoríaYMontoRecaudadoToolStripMenuItem.Size = new System.Drawing.Size(401, 26);
            this.mayorDuraciónCategoríaYMontoRecaudadoToolStripMenuItem.Text = "Mayor duración, categoría y monto recaudado";
            this.mayorDuraciónCategoríaYMontoRecaudadoToolStripMenuItem.Click += new System.EventHandler(this.mayorDuraciónCategoríaYMontoRecaudadoToolStripMenuItem_Click);
            // 
            // menorDuraciónCategoríaYMontoRecaudadoToolStripMenuItem
            // 
            this.menorDuraciónCategoríaYMontoRecaudadoToolStripMenuItem.Name = "menorDuraciónCategoríaYMontoRecaudadoToolStripMenuItem";
            this.menorDuraciónCategoríaYMontoRecaudadoToolStripMenuItem.Size = new System.Drawing.Size(401, 26);
            this.menorDuraciónCategoríaYMontoRecaudadoToolStripMenuItem.Text = "Menor duración, categoría y monto recaudado";
            this.menorDuraciónCategoríaYMontoRecaudadoToolStripMenuItem.Click += new System.EventHandler(this.menorDuraciónCategoríaYMontoRecaudadoToolStripMenuItem_Click);
            // 
            // montoTotalPorCategoríaToolStripMenuItem
            // 
            this.montoTotalPorCategoríaToolStripMenuItem.Name = "montoTotalPorCategoríaToolStripMenuItem";
            this.montoTotalPorCategoríaToolStripMenuItem.Size = new System.Drawing.Size(401, 26);
            this.montoTotalPorCategoríaToolStripMenuItem.Text = "Monto total por categoría";
            this.montoTotalPorCategoríaToolStripMenuItem.Click += new System.EventHandler(this.montoTotalPorCategoríaToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMStreamingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNFORMESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mayorDuraciónCategoríaYMontoRecaudadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menorDuraciónCategoríaYMontoRecaudadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem montoTotalPorCategoríaToolStripMenuItem;
    }
}

