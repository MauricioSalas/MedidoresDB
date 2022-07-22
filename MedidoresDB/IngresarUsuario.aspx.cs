using MedidoresModel;
using MedidoresModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresDB
{
    public partial class IngresarUsuario : System.Web.UI.Page
    {
        private IUsuarioDALDB usuarioDAL = new UsuarioDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void agregarButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Usuario usuario = new Usuario()
                {
                    Rut = rutUsuario.Text.Trim(),
                    Nombre = nombreUsuario.Text.Trim(),
                    Email = emailUsuario.Text.Trim(),
                    Contrasena = passwordUsuario.Text.Trim()
                };
                usuarioDAL.IngresarUsuario(usuario);
                Response.Redirect("MostrarUsuario.aspx");
            }
        }
    }
}