using System;

using CineStar.dao;

namespace CineStar.pages
{
    public partial class verPeliculas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id;
            string idPeliculas = Request.QueryString["idPeliculas"];
            if(idPeliculas != null && int.TryParse(idPeliculas, out id) ) 
            { 
            rptPeliculas.DataSource = new dao.daoPelicula().getVerPeliculas(idPeliculas);
            rptPeliculas.DataBind();
            if (rptPeliculas.DataSource == null)
                Response.Redirect("Inicio.aspx");
            }
        }
    }
}