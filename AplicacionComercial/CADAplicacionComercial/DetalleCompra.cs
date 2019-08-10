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
        public decimal ValorBruto { get { return Costo * (decimal)Cantidad/(1+(decimal)PorcentajeIVA); } }
        public decimal ValorIVA { get {return Costo*(decimal)Cantidad-ValorBruto; } }
        public decimal ValorDescuento { get { return ValorBruto * (decimal)PorcentajeDescuento; } }
        public decimal ValorNeto { get { return Costo*(decimal)Cantidad -ValorDescuento; } }
    }
}
 