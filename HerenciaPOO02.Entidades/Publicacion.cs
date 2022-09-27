using System;

namespace HerenciaPOO02.Entidades
{
    public class Publicacion
    {
        public int Precio { get;}
        public string Titulo { get;}


        public Publicacion(int precio, string titulo)
        {
            Precio = precio;
            Titulo=titulo;
        }

        public string MostrarDatos()
        {
            return $"Titulo: {Titulo} - Precio: {Precio}";
        }

        public override bool Equals(object obj)
        {
            return this.Precio == ((Publicacion)obj).Precio && this.Titulo == ((Publicacion)obj).Titulo;
        }

    }
}
