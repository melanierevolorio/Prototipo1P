namespace Prototipo1P
{
    partial class VistaPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.txtMenu = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReporteVentaEnca = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnMostrarClientes = new System.Windows.Forms.Button();
            this.btnReporteProductos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelMenu);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 459);
            this.panel1.TabIndex = 0;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelMenu.Controls.Add(this.txtMenu);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMenu.Location = new System.Drawing.Point(0, 38);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(768, 421);
            this.PanelMenu.TabIndex = 1;
            // 
            // txtMenu
            // 
            this.txtMenu.AutoSize = true;
            this.txtMenu.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenu.Location = new System.Drawing.Point(314, 156);
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(124, 42);
            this.txtMenu.TabIndex = 0;
            this.txtMenu.Text = "M E N U";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.btnReporteVentaEnca);
            this.flowLayoutPanel1.Controls.Add(this.btnVenta);
            this.flowLayoutPanel1.Controls.Add(this.btnMostrarClientes);
            this.flowLayoutPanel1.Controls.Add(this.btnReporteProductos);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(768, 38);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnReporteVentaEnca
            // 
            this.btnReporteVentaEnca.BackColor = System.Drawing.Color.SkyBlue;
            this.btnReporteVentaEnca.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteVentaEnca.Location = new System.Drawing.Point(3, 3);
            this.btnReporteVentaEnca.Name = "btnReporteVentaEnca";
            this.btnReporteVentaEnca.Size = new System.Drawing.Size(196, 35);
            this.btnReporteVentaEnca.TabIndex = 0;
            this.btnReporteVentaEnca.Text = "Reporte Ventas";
            this.btnReporteVentaEnca.UseVisualStyleBackColor = false;
            this.btnReporteVentaEnca.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.SkyBlue;
            this.btnVenta.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.Location = new System.Drawing.Point(205, 3);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(178, 35);
            this.btnVenta.TabIndex = 1;
            this.btnVenta.Text = "NUEVA VENTA";
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnMostrarClientes
            // 
            this.btnMostrarClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMostrarClientes.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMostrarClientes.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarClientes.Location = new System.Drawing.Point(389, 3);
            this.btnMostrarClientes.Name = "btnMostrarClientes";
            this.btnMostrarClientes.Size = new System.Drawing.Size(213, 35);
            this.btnMostrarClientes.TabIndex = 2;
            this.btnMostrarClientes.Text = "CLIENTES";
            this.btnMostrarClientes.UseVisualStyleBackColor = false;
            this.btnMostrarClientes.Click += new System.EventHandler(this.btnMostrarClientes_Click);
            // 
            // btnReporteProductos
            // 
            this.btnReporteProductos.BackColor = System.Drawing.Color.SkyBlue;
            this.btnReporteProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteProductos.Location = new System.Drawing.Point(608, 3);
            this.btnReporteProductos.Name = "btnReporteProductos";
            this.btnReporteProductos.Size = new System.Drawing.Size(157, 35);
            this.btnReporteProductos.TabIndex = 3;
            this.btnReporteProductos.Text = "Reporte";
            this.btnReporteProductos.UseVisualStyleBackColor = false;
            this.btnReporteProductos.Click += new System.EventHandler(this.btnReporteProductos_Click);
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(768, 459);
            this.Controls.Add(this.panel1);
            this.Name = "VistaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VistaPrincipal";
            this.panel1.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnReporteVentaEnca;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnMostrarClientes;
        private System.Windows.Forms.Label txtMenu;
        private System.Windows.Forms.Button btnReporteProductos;
    }
}