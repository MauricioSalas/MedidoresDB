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
    public partial class IngresarMedidor : System.Web.UI.Page
    {
        private IMedidorDALDB medidoresDAL = new MedidorDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void agregarButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int codigoMedidor = Convert.ToInt32(this.codigoMedidor.Text.Trim());
                List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
                if (!medidores.Any(m => m.CodigoMedidor == codigoMedidor))
                {
                    Medidor medidor = new Medidor()
                    {
                        CodigoMedidor = codigoMedidor,
                        TipoMedidor = this.tipoMedidorDropdown.SelectedItem.Text.Trim()
                    };
                    medidoresDAL.AgregarMedidores(medidor);
                    Response.Redirect("VerMedidores.aspx");
                }
                else
                {
                    this.mensajesLabel.CssClass = "text-danger";
                    this.mensajesLabel.Text = "Código de Medidor existente.";
                }
            }
        }
    }
}