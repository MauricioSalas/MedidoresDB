using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public interface IUsuarioDALDB
    {
        void IngresarUsuario(Usuario usuario);
        List<Usuario> ObtenerUsuarios();
        void EliminarUsuario(int id);
    }
}
