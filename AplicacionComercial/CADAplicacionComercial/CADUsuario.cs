
namespace CADAplicacionComercial
{
    using CADAplicacionComercial.DSAplicacionComercialTableAdapters;
    public class CADUsuario
    {
        private static UsuarioTableAdapter adapter = new UsuarioTableAdapter();
        public static bool ValidaUsuario(string IDUsuario,string Clave)
        {
            if (adapter.ValidaUsuario(IDUsuario, Clave) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
