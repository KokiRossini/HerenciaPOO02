using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaPOO02.Entidades
{
    public class AudioLibro:Publicacion
    {
        private double Duracion;

        public double duracion => Duracion;
        public AudioLibro(int precio, string titulo, double duracion):base(precio,titulo)
        {
            Duracion = duracion;
        }

        public new string MostrarDatos()
        {
            return $"{base.MostrarDatos()} - Duracion: {Duracion}";
        }

    }
}
