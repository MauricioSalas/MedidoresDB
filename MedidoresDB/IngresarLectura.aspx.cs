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
    public partial class IngresarLectura : System.Web.UI.Page
    {
        private IMedidorDALDB medidorDAL = new MedidorDALDB();
        private ILecturasDALDB lecturasDAL = new LecturasDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Medidor> medidor = medidorDAL.ObtenerMedidores();
                this.codigoMedidorDropdown.DataSource = medidor;
                this.codigoMedidorDropdown.DataValueField = "Id";
                this.codigoMedidorDropdown.DataTextField = "CodigoMedidor";
                this.codigoMedidorDropdown.DataBind();
            }
        }

        protected void agregarButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int idMedidor = Convert.ToInt32(codigoMedidorDropdown.SelectedValue.Trim());
                    Lectura lectura = new Lectura()
                    {
                        IdMedidor = idMedidor,
                        Fecha = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                        kWh = Convert.ToInt32(valorConsumo.Text.Trim())
                    };
                    lecturasDAL.AgregarLectura(lectura);
                    this.mensajesLabel.CssClass = "text-success";
                    this.mensajesLabel.Text = "Lectura ingresada. ID Medidor: " + idMedidor;
            }
        }
    }
}