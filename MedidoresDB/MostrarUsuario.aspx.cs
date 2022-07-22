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
    public partial class MostrarUsuario : System.Web.UI.Page
    {
        private IUsuarioDALDB usuariosDAL = new UsuarioDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrilla();
            }
        }

        private void cargarGrilla()
        {
            List<Usuario> usuarios = this.usuariosDAL.ObtenerUsuarios();
            this.grillaUsuarios.DataSource = usuarios;
            this.grillaUsuarios.DataBind();
        }
        protected void grillaUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                usuariosDAL.EliminarUsuario(id);
                cargarGrilla();
            }
        }
    }
}