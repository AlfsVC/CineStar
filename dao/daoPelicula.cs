using System;
using CineStar.bd;

namespace CineStar.dao
{
   
    public class daoPelicula
    {
        clsBD clsBD = new clsBD("cnCineStarSQL");

        public daoPelicula() { }

        internal object getVerCines()
        {
            clsBD.Sentencia("sp_getPelicula");
            return clsBD.getDataTable();
        }
       

        internal object getVerPelicula(string idPelicula)
        {
            clsBD.Sentencia("sp_getPelicula " + idPelicula);
            return clsBD.getDataTable();
        }

        internal object getVerPeliculas(string idPeliculas)
        {
            clsBD.Sentencia("sp_getPeliculas " + idPeliculas);
            return clsBD.getDataTable();
        }
    }
}
   