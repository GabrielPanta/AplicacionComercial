using CADAplicacionComercial.DSAplicacionComercialTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADAplicacionComercial
{
    public class CADIVA
    {
        public int IDIVA { get; set; }
        public string Descripcion { get; set; }
        public float Tarifa { get; set; }

        private static IVATableAdapter adapter = new IVATableAdapter();

        public static CADIVA GetIVA(int IDIVA)
        {
            CADIVA miIVA = null;
            DSAplicacionComercial.IVADataTable miTabla = adapter.GetIVA(IDIVA);
            if (miTabla.Rows.Count == 0) return miIVA;
            DSAplicacionComercial.IVARow miRegistro =(DSAplicacionComercial.IVARow)miTabla.Rows[0];
            miIVA = new CADIVA();
            miIVA.Descripcion = miRegistro.Descripcion;
            miIVA.IDIVA = miRegistro.IDIVA;
            miIVA.Tarifa = (float)miRegistro.Tarifa;
            return miIVA;
        }

    }
}
