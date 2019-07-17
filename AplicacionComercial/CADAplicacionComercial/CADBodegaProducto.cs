using CADAplicacionComercial.DSAplicacionComercialTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADAplicacionComercial
{
    public class CADBodegaProducto
    {
        public int IDBodega { get; set; }
        public int IDProducto { get; set; }
        public float Stock { get; set; }
        public float Minimo { get; set; }
        public float Maximo { get; set; }
        public int DiasReposicion { get; set; }
        public float CantidadMinima { get; set; }

        private static BodegaProductoTableAdapter adapter = new BodegaProductoTableAdapter();

        public static CADBodegaProducto GetBodegaProductoByIDBodegaAndIDProducto(int IDBodega,int IDProducto)
        {
            CADBodegaProducto miBodegProducto = null;
            DSAplicacionComercial.BodegaProductoDataTable miTabla = adapter.GetBodegaProductoByIDBodegaAndIDProducto(IDBodega, IDProducto);
            if (miTabla.Rows.Count == 0) return miBodegProducto;
            DSAplicacionComercial.BodegaProductoRow miRegistro = (DSAplicacionComercial.BodegaProductoRow)miTabla.Rows[0];
            miBodegProducto = new CADBodegaProducto();
            miBodegProducto.IDBodega = miRegistro.IDBodega;
            miBodegProducto.IDProducto = miRegistro.IDProducto;
            miBodegProducto.Stock = (float)miRegistro.Stock;
            miBodegProducto.Minimo = (float)miRegistro.Minimo;
            miBodegProducto.Maximo = (float)miRegistro.Maximo;
            miBodegProducto.DiasReposicion = miRegistro.DiasReposicion;
            miBodegProducto.CantidadMinima = (float)miRegistro.CantidadMinima;
            return miBodegProducto;
        }

        public static void UpdateBodegaProducto(int IDBodega,int IDProducto, double Minimo, double Maximo,int DiasReposicion,double CantidadMinima)
        {
            try
            {
            adapter.InsertBodegaProducto(IDBodega, IDProducto, Minimo, Maximo, DiasReposicion, CantidadMinima);
            }
            catch (Exception)
            {

                adapter.UpdateBodegaProducto(Minimo, Maximo, DiasReposicion, CantidadMinima, IDBodega, IDProducto);
            }
        }


    }
}
