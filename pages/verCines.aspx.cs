using System;
using CineStar.dao;

namespace CineStar.pages
{
    public partial class verCines : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rptCines.DataSource = new daoCine().getVerCines();
            rptCines.DataBind();
            if (rptCines.DataSource == null)
                Response.Redirect("Inicio.aspx");

        }
    }
}