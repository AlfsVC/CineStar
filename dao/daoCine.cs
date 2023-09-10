using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CineStar.bd;

namespace CineStar.dao
{
    public class daoCine
    {
        clsBD clsBD = new clsBD("cnCineStarSQL");
        public daoCine() { }
        public object getVerCines()
        {
            clsBD.Sentencia("sp_getCines");
            return clsBD.getDataTable();
        }
        public object getCine(string idCine )
        {
            clsBD.Sentencia("sp_getCine " + idCine );
            return clsBD.getDataTable();
        }

        public object getCinePeliculas(string idCine )
        {
            clsBD.Sentencia("sp_getCinePeliculas " + idCine );
            return clsBD.getDataTable();
        }

        public object getCineTarifas(string idCine)
        {
            clsBD.Sentencia("sp_getCineTarifas " + idCine );
            return clsBD.getDataTable();
        }

       
    }
}