using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class UsuarioDALDB : IUsuarioDALDB
    {
        private MedidoresDBEntities medidoresEnt = new MedidoresDBEntities();
        public void EliminarUsuario(int id)
        {
            Usuario usuario = this.medidoresEnt.Usuarios.Find(id);
            this.medidoresEnt.Usuarios.Remove(usuario);
            this.medidoresEnt.SaveChanges();
        }

        public void IngresarUsuario(Usuario usuario)
        {
            this.medidoresEnt.Usuarios.Add(usuario);
            this.medidoresEnt.SaveChanges();
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return this.medidoresEnt.Usuarios.ToList();
        }
    }
}
