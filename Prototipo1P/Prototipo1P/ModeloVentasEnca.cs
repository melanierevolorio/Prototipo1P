using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo1P
{
    class ModeloVentasEnca
    {
        public string documento_ventaenca { get; set; }
        public string codigo_cliente { get; set; }
        public string fecha_ventaenca { get; set; }
        public float total_ventaenca { get; set; }
        public string estatus_ventaenca { get; set; }

        public ModeloVentasEnca()
        {
        }

        public ModeloVentasEnca(string Documento_ventaenca, string Codigo_cliente, string Fecha_ventaenca,
            float Total_ventaenca, string Estatus_ventaenca)
        {
            documento_ventaenca = Documento_ventaenca;
            codigo_cliente = Codigo_cliente;
            fecha_ventaenca = Fecha_ventaenca;
            total_ventaenca = Total_ventaenca;
            estatus_ventaenca = Estatus_ventaenca;
        }


    }
}
