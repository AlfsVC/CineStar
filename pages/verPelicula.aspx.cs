using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CineStar.pages
{
    public partial class verPelicula : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id;
            string idPelicula = Request.QueryString["idPelicula"];
            if (idPelicula != null && int.TryParse(idPelicula, out id))
            {
                frmPelicula.DataSource = new dao.daoPelicula().getVerPelicula(idPelicula);
                frmPelicula.DataBind();
            }


        }
    }
}