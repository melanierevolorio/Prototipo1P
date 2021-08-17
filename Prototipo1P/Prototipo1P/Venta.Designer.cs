namespace Prototipo1P
{
    partial class Venta
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
            this.cbVenta = new System.Windows.Forms.ComboBox();
            this.txtVenta = new System.Windows.Forms.Label();
            this.NoVenta = new System.Windows.Forms.TextBox();
            this.TotalVenta = new System.Windows.Forms.TextBox();
            this.EstatusVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaVenta = new System.Windows.Forms.DateTimePicker();
            this.txtNombreCliente = new System.Windows.Forms.Label();
            this.txtEstatusCliente = new System.Windows.Forms.Label();
            this.txtTotalVenta = new System.Windows.Forms.Label();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.txtFechaVenta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbVenta
            // 
            this.cbVenta.FormattingEnabled = true;
            this.cbVenta.Location = new System.Drawing.Point(268, 141);
            this.cbVenta.Name = "cbVenta";
            this.cbVenta.Size = new System.Drawing.Size(121, 21);
            this.cbVenta.TabIndex = 0;
            // 
            // txtVenta
            // 
            this.txtVenta.AutoSize = true;
            this.txtVenta.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenta.Location = new System.Drawing.Point(261, 25);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(136, 42);
            this.txtVenta.TabIndex = 1;
            this.txtVenta.Text = "V E N T A";
            // 
            // NoVenta
            // 
            this.NoVenta.Location = new System.Drawing.Point(40, 81);
            this.NoVenta.Name = "NoVenta";
            this.NoVenta.Size = new System.Drawing.Size(73, 20);
            this.NoVenta.TabIndex = 2;
            // 
            // TotalVenta
            // 
            this.TotalVenta.Location = new System.Drawing.Point(268, 298);
            this.TotalVenta.Name = "TotalVenta";
            this.TotalVenta.Size = new System.Drawing.Size(121, 20);
            this.TotalVenta.TabIndex = 3;
            // 
            // EstatusVenta
            // 
            this.EstatusVenta.Location = new System.Drawing.Point(268, 224);
            this.EstatusVenta.Name = "EstatusVenta";
            this.EstatusVenta.Size = new System.Drawing.Size(121, 20);
            this.EstatusVenta.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "No. Venta";
            // 
            // FechaVenta
            // 
            this.FechaVenta.Location = new System.Drawing.Point(497, 240);
            this.FechaVenta.Name = "FechaVenta";
            this.FechaVenta.Size = new System.Drawing.Size(200, 20);
            this.FechaVenta.TabIndex = 6;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.AutoSize = true;
            this.txtNombreCliente.Location = new System.Drawing.Point(280, 112);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(102, 13);
            this.txtNombreCliente.TabIndex = 7;
            this.txtNombreCliente.Text = "NOMBRE CLIENTE";
            // 
            // txtEstatusCliente
            // 
            this.txtEstatusCliente.AutoSize = true;
            this.txtEstatusCliente.Location = new System.Drawing.Point(295, 186);
            this.txtEstatusCliente.Name = "txtEstatusCliente";
            this.txtEstatusCliente.Size = new System.Drawing.Size(57, 13);
            this.txtEstatusCliente.TabIndex = 8;
            this.txtEstatusCliente.Text = "ESTATUS";
            // 
            // txtTotalVenta
            // 
            this.txtTotalVenta.AutoSize = true;
            this.txtTotalVenta.Location = new System.Drawing.Point(295, 267);
            this.txtTotalVenta.Name = "txtTotalVenta";
            this.txtTotalVenta.Size = new System.Drawing.Size(81, 13);
            this.txtTotalVenta.TabIndex = 9;
            this.txtTotalVenta.Text = "TOTAL VENTA";
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarVenta.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVenta.Location = new System.Drawing.Point(226, 345);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(208, 54);
            this.btnAgregarVenta.TabIndex = 10;
            this.btnAgregarVenta.Text = "AGREGAR VENTA";
            this.btnAgregarVenta.UseVisualStyleBackColor = false;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // txtFechaVenta
            // 
            this.txtFechaVenta.AutoSize = true;
            this.txtFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaVenta.Location = new System.Drawing.Point(493, 202);
            this.txtFechaVenta.Name = "txtFechaVenta";
            this.txtFechaVenta.Size = new System.Drawing.Size(213, 24);
            this.txtFechaVenta.TabIndex = 11;
            this.txtFechaVenta.Text = "Fecha realización Venta";
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.txtFechaVenta);
            this.Controls.Add(this.btnAgregarVenta);
            this.Controls.Add(this.txtTotalVenta);
            this.Controls.Add(this.txtEstatusCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.FechaVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EstatusVenta);
            this.Controls.Add(this.TotalVenta);
            this.Controls.Add(this.NoVenta);
            this.Controls.Add(this.txtVenta);
            this.Controls.Add(this.cbVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVenta;
        private System.Windows.Forms.Label txtVenta;
        private System.Windows.Forms.TextBox NoVenta;
        private System.Windows.Forms.TextBox TotalVenta;
        private System.Windows.Forms.TextBox EstatusVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechaVenta;
        private System.Windows.Forms.Label txtNombreCliente;
        private System.Windows.Forms.Label txtEstatusCliente;
        private System.Windows.Forms.Label txtTotalVenta;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.Label txtFechaVenta;
    }
}