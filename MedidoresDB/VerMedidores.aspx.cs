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
    public partial class VerMedidores : System.Web.UI.Page
    {
        private IMedidorDALDB medidorDAL = new MedidorDALDB();
        private void cargarGrilla(List<Medidor> medidores)
        {
            this.grillaMedidores.DataSource = medidores;
            this.grillaMedidores.DataBind();
        }

        private void cargarGrilla()
        {
            List<Medidor> medidores;
            medidores = this.medidorDAL.ObtenerMedidores();
            this.cargarGrilla(medidores);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.cargarGrilla();
            }
        }

        protected void tipoMedidorDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grillaMedidores_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
    }
}