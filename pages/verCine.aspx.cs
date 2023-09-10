using System;
using CineStar.dao;

namespace CineStar.pages
{
    public partial class verCine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id;
            string idCine = Request.QueryString["idCine"];
            if (idCine != null && int.TryParse(idCine, out id)) {
                dao.daoCine daoCine = new dao.daoCine();
                fvCine.DataSource = daoCine.getCine(idCine);
                if (fvCine.DataSource == null)
                    Response.Redirect("Inicio.aspx");

                imgCine.ImageUrl = "~/img/cine/" + idCine + ".2.jpg";
                rptTarifas.DataSource = daoCine.getCineTarifas(idCine);
                rptPeliculas.DataSource = daoCine.getCinePeliculas(idCine);
                DataBind();
            }
        }
    }
}