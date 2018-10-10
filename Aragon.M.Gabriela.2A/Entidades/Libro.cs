using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        protected Autor _autor;
        protected int _cantidadDePaginas;
        protected static Random _generadorDePaginas;
        protected float _precio;
        protected string _titulo;

        public int CantidadDePaginas
        {
            get
            {
                if (this._cantidadDePaginas == 0)
                {
                    this._cantidadDePaginas = Libro._generadorDePaginas.Next(10, 580);
                }
                return this._cantidadDePaginas;
            }
        }

        static Libro()
        {
            Libro._generadorDePaginas = new Random();
        }

        public Libro(float precio,string titulo, string nombre, string apellido) : this(titulo, new Autor(nombre, apellido), precio)
        {

        }

        public Libro(string titulo, Autor autor, float precio)
        {
            this._titulo = titulo;
            this._autor = autor;
            this._precio = precio;
        }

        public static explicit operator string(Libro l)
        {
            return Libro.Mostrar(l);
        }

        private static string Mostrar(Libro l)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Titulo: {0}\nAutor: ", l._titulo);
            sb.AppendLine(l._autor);
            sb.AppendFormat("Cantidad de Paginas: {0}\n", l.CantidadDePaginas);
            sb.AppendFormat("Precio: {0:#.##}", l._precio);
            return sb.ToString();
        }

        public static bool operator ==(Libro a,Libro b)
        {
            bool retorno = false;
            if ((a._autor == b._autor) && (a._titulo == b._titulo))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Libro a, Libro b)
        {
            return !(a == b);
        }
    }
}
