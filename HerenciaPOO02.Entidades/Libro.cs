using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaPOO02.Entidades
{
    public class Libro:Publicacion
    {
        private int Paginas;

        public int paginas => Paginas;

        public Libro(int precio, string titulo, int paginas):base(precio,titulo)
        {
            Paginas = paginas;
        }

        public new string MostrarDatos()
        {
            return $"{base.MostrarDatos()} - Paginas: {Paginas}";
        }
        public override bool Equals(object obj)
        {
            return this.paginas == ((Libro)obj).paginas && base.Equals(obj);
        }

    }
}
