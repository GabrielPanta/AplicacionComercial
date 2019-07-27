
namespace CADAplicacionComercial
{
    using CADAplicacionComercial.DSAplicacionComercialTableAdapters;
    using System;
    using static CADAplicacionComercial.DSAplicacionComercial;

    public class CADUsuario
    {
        public string IDUsuario { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Clave { get; set; }
        public DateTime FechaModificacionClave { get; set; }
        public int IDRol { get; set; }
        public string Correo { get; set; }


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

        public static bool ExisteUsuarios(string IDUsuario)
        {
            if (adapter.ExisteUsuario(IDUsuario) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static CADUsuario GetUsuario(string IDUsuario)
        {
            CADUsuario miUsuario = null;
            UsuarioDataTable miTabla = adapter.GetUsuario(IDUsuario);
            if (miTabla.Rows.Count == 0) return miUsuario;
            UsuarioRow miRegistro = (UsuarioRow)miTabla.Rows[0];
            miUsuario = new CADUsuario();
            miUsuario.Apellidos = miRegistro.Apellidos;
            miUsuario.Nombres = miRegistro.Nombres;
            miUsuario.Clave = miRegistro.Clave;
            miUsuario.Correo = miRegistro.Correo;
            miUsuario.FechaModificacionClave = miRegistro.FechaModificacionClave;
            miUsuario.IDRol = miRegistro.IDRol;
            miUsuario.IDUsuario = miRegistro.IDUsuario;
            return miUsuario;
        }

        public static void CambioClave(string Clave, string IDUsuario)
        {
            adapter.CambioClave(Clave, DateTime.Now, IDUsuario);
        }
    }
}