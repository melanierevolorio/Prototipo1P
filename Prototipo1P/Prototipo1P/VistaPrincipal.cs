using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo1P
{
    public partial class VistaPrincipal : Form
    {
        public VistaPrincipal()
        {
            InitializeComponent();
        }

        private Form formActivo = null;
        private string formPrincipalAnterior = "";
        private void gestorDeFormActivo(Form formHijo, string formHijoActual)
        {
            if (formPrincipalAnterior == formHijoActual)
            {
                cerrarFormActivo();
                formPrincipalAnterior = "";
            }
            else
            {
                formPrincipalAnterior = formHijoActual;
                cerrarFormActivo();
                abrirFormHijo(formHijo, PanelMenu);
            }
        }

        private void abrirFormHijo(Form formHijo, Panel panel)
        {
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panel.Controls.Add(formHijo);
            panel.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void cerrarFormActivo()
        {
            if (formActivo != null)
            {
                formActivo.Close();
                formActivo = null;
            }
        }


        private void btnReporteProductos_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new ReporteVentas(), "BotonReporteVentas");
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new Clientes(), "BotonCliente");
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new Venta(), "BotonVenta");
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new VerClientes(), "BotonVerClientes");
        }

        
    }
}
