namespace CADAplicacionComercial
{
    public class DetalleCompra
    {
        public int IDProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public float Cantidad { get; set; }
        public float PorcentajeIVA { get; set; }
        public float PorcentajeDescuento { get; set; }
    }
}
