using CADAplicacionComercial.DSAplicacionComercialTableAdapters;

namespace CADAplicacionComercial
{
   public class CADBarra
    {
        private static BarraTableAdapter adapter = new BarraTableAdapter();

        public static bool ExisteBarra(long Barra)
        {
            if (adapter.ExisteBarra(Barra) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void InsertBarra(int IDProducto, long Barra)
        {
            adapter.InsertBarra(IDProducto, Barra);
        }

        public static void DeleteBarra( long Barra)
        {
            adapter.DeleteBarra(Barra);
        }

        public static void DeleteBarraByIDProducto(int IDProducto)
        {
            adapter.DeleteBarraByIDProducto(IDProducto);
        }
    }
}
