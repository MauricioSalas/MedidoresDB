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
    public partial class MostrarLecturas : System.Web.UI.Page
    {
        private ILecturasDALDB lecturasDAL = new LecturasDALDB();
        private IMedidorDALDB medidoresDAL = new MedidorDALDB();

        private void cargarGrilla()
        {
            List<Lectura> lecturas = lecturasDAL.ObtenerLecturas(Convert.ToInt32(codigoMedidorDropdown.SelectedItem.Value));
            List<Medidor> medidor = medidoresDAL.ObtenerMedidores();
            //Cambiar IdMedidor e Id DataField's en Frontend
            this.grillaLecturas.DataSource = lecturas;
            this.grillaLecturas.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
                this.codigoMedidorDropdown.DataSource = medidores;
                this.codigoMedidorDropdown.DataTextField = "CodigoMedidor";
                this.codigoMedidorDropdown.DataValueField = "Id";
                this.codigoMedidorDropdown.DataBind();
                cargarGrilla();
            }
        }

        protected void recargarLecturas_Click(object sender, EventArgs e)
        {
            Response.Redirect("MostrarLecturas.aspx");
        }

        protected void codigoMedidorDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        protected void grillaLecturas_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
    }
}