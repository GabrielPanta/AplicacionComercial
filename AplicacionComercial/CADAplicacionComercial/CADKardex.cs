using CADAplicacionComercial.DSAplicacionComercialTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADAplicacionComercial
{
    public class CADKardex
    {
        public int IDKardex { get; set; }
        public int IDBodega { get; set; }
        public int IDProducto { get; set; }
        public DateTime Fecha{ get; set; }
        public string Documento { get; set; }
        public float Entrada { get; set; }
        public float Salida { get; set; }
        public float Saldo { get; set; }
        public decimal UltimoCosto { get; set; }
        public decimal CostoPromedio { get; set; }

        private static KardexTableAdapter adapter = new KardexTableAdapter();

        public static CADKardex UltimoKardex(int IDBodega,int IDProducto)
        {
            CADKardex miKardex = null;
            DSAplicacionComercial.KardexDataTable miTabla = adapter.UltimoKardex(IDBodega, IDProducto);
            if (miTabla.Rows.Count == 0) return miKardex;
            DSAplicacionComercial.KardexRow miRegistro =(DSAplicacionComercial.KardexRow) miTabla.Rows[0];
            miKardex = new CADKardex();

            miKardex.IDProducto = miRegistro.IDProducto;
            miKardex.Entrada = (float)miRegistro.Entrada;
            miKardex.IDKardex = miRegistro.IDKardex;
            miKardex.Fecha = miRegistro.Fecha;
            miKardex.Documento= miRegistro.Documento;
            miKardex.Salida= (float) miRegistro.Salida;
            miKardex.Saldo= (float) miRegistro.Saldo;
            miKardex.UltimoCosto= miRegistro.UltimoCosto;
            miKardex.CostoPromedio= miRegistro.CostoPromedio;
            miKardex.IDProducto = miRegistro.IDProducto;

            return miKardex;
        }

        public static int InsertKardex(int IDBodega, int IDProducto,DateTime Fecha,
            string Documento,float Entrada,float Salida,float Saldo,decimal UltimoCosto,
            decimal CostoPromedio)
        {
            return (int)adapter.InsertKardex(IDBodega, IDProducto, Fecha, Documento, Entrada, 
                Salida, Saldo, UltimoCosto, CostoPromedio);
        }
        
    }
}
