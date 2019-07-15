using CADAplicacionComercial.DSAplicacionComercialTableAdapters;

namespace CADAplicacionComercial
{
    public class CADProducto
    {
        public int IDProducto { get; set; }
        public string Descripcion { get; set; }
        public int IDDepartamento{ get; set; }
        public int IDIVA{ get; set; }
        public decimal Precio{ get; set; }
        public string Notas { get; set; }
        public string Imagen { get; set; }
        public float Medida { get; set; }

        private static ProductoTableAdapter adapter = new ProductoTableAdapter();

        public static CADProducto GetProductoByIDProducto(int IDProducto)
        {
            CADProducto miProducto = null;
            DSAplicacionComercial.ProductoDataTable miTabla = adapter.GetProductoByIDProducto(IDProducto);
            if (miTabla.Rows.Count == 0) return miProducto;
            DSAplicacionComercial.ProductoRow miRegistro =(DSAplicacionComercial.ProductoRow) miTabla.Rows[0];
            miProducto = new CADProducto();
            miProducto.IDProducto = miRegistro.IDProducto;
            miProducto.Descripcion = miRegistro.Descripcion;
            miProducto.IDDepartamento = miRegistro.IDDepartamento;
            miProducto.IDIVA = miRegistro.IDIVA;
            miProducto.Precio = miRegistro.Precio;
            miProducto.Notas = miRegistro.Notas;
            miProducto.Imagen = miRegistro.Imagen;
            miProducto.Medida =(float) miRegistro.Medida;
            return miProducto;
        }

        public static CADProducto GetProductoByBarra(int Barra)
        {
            CADProducto miProducto = null;
            DSAplicacionComercial.ProductoDataTable miTabla = adapter.GetProductoByBarra(Barra);
            if (miTabla.Rows.Count == 0) return miProducto;
            DSAplicacionComercial.ProductoRow miRegistro = (DSAplicacionComercial.ProductoRow)miTabla.Rows[0];
            miProducto = new CADProducto();
            miProducto.IDProducto = miRegistro.IDProducto;
            miProducto.Descripcion = miRegistro.Descripcion;
            miProducto.IDDepartamento = miRegistro.IDDepartamento;
            miProducto.IDIVA = miRegistro.IDIVA;
            miProducto.Precio = miRegistro.Precio;
            miProducto.Notas = miRegistro.Notas;
            miProducto.Imagen = miRegistro.Imagen;
            miProducto.Medida = (float)miRegistro.Medida;
            return miProducto;
        }
    }
}
