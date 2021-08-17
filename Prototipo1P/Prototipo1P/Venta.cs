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
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            BdVentasEnca BdVentasEnca = new BdVentasEnca();
            cbVenta.DataSource = BdVentasEnca.mostrarClientes();
            cbVenta.DisplayMember = "nombre_cliente";
            cbVenta.ValueMember = "codigo_cliente";
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            BdVentasEnca db = new BdVentasEnca();
            ModeloVentasEnca modelo = new ModeloVentasEnca();
            modelo.codigo_cliente = cbVenta.SelectedValue.ToString();
            modelo.documento_ventaenca = NoVenta.Text;
            modelo.estatus_ventaenca = EstatusVenta.Text;
            modelo.total_ventaenca = float.Parse(TotalVenta.Text);
            string fecha = FechaVenta.Value.ToString("yyyy-MM-dd");
            modelo.fecha_ventaenca = fecha;
            db.agregarVentaEncabezado(modelo);
        }
    }
}
