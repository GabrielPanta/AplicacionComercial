using CADAplicacionComercial.DSAplicacionComercialTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADAplicacionComercial
{
    public class CADCompra
    {
        private static CompraTableAdapter adapter = new CompraTableAdapter();

        public static int InsertCompra(DateTime Fecha, int IDProveedor,int IDBodega)
        {
            return (int)adapter.InsertCompra(Fecha, IDProveedor, IDBodega);
        }
        public static void AumentarStock(double Cantidad, int IDBodega, int IDProducto)
        {
            adapter.AumentarStock(Cantidad, IDBodega, IDProducto);
        }
    }
}
