using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Manual : Libro
    {
        ETipo tipo;

        public Manual(string titulo, float precio, string nombre, string apellido, ETipo tipo) : base(precio, titulo, nombre, apellido)
        {
            this.tipo = tipo;
        }

        public static implicit operator double(Manual m)
        {
            return m._precio;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(((string)this));
            sb.AppendFormat("Tipo: {0}", this.tipo);

            return sb.ToString();
        }

        public static bool operator ==(Manual a,Manual b)
        {
            bool retorno = false;

            if (((Libro)a) == ((Libro)b) && (a.tipo == b.tipo))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Manual a, Manual b)
        {
            return !(a == b);
        }
    }
}
