using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {
        private int _capacidad;
        private List<Libro> _libros;

        public double PrecioDeManuales
        {
            get
            {
                return this.ObtenerPrecio(ELibro.Manual);
            }
        }

        public double PrecioDeNovelas
        {
            get
            {
                return this.ObtenerPrecio(ELibro.Novela);
            }
        }

        public double PrecioTotal
        {
            get
            {
                return (this.ObtenerPrecio(ELibro.Novela) + this.ObtenerPrecio(ELibro.Manual));
            }
        }

        private Biblioteca()
        {
            this._libros = new List<Libro>();
        }

        private Biblioteca(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public static implicit operator Biblioteca(int capacidad)
        {
            return (new Biblioteca(capacidad));
        }

        public static string Mostrar(Biblioteca e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Capacidad de la biblioteca: {0}\n", e._capacidad);
            sb.AppendFormat("Total por Manuales: ${0:#.##}\n", e.PrecioDeManuales);
            sb.AppendFormat("Total por Novelas: $ {0:#.##}\n", e.PrecioDeNovelas);
            sb.AppendFormat("Total: $ {0:#.##}\n", e.PrecioTotal);
            sb.AppendLine("****************************************");
            sb.AppendLine("Listado de Libros");
            sb.AppendFormat("****************************************");

            foreach (Libro libroA in e._libros)
            {
                sb.AppendLine("");
                if (libroA is Manual)
                {
                    sb.AppendLine(((Manual)libroA).Mostrar());
                }
                else if (libroA is Novela)
                {
                    sb.AppendLine(((Novela)libroA).Mostrar());
                }
            }
            return sb.ToString();
        }

        private double ObtenerPrecio(ELibro tipoLibro)
        {
            double retorno = 0;

            foreach (Libro libroA in this._libros)
            {
                switch (tipoLibro)
                {
                    case ELibro.Manual:
                        if (libroA is Manual)
                        {
                            retorno += ((Manual)libroA);
                        }
                        break;
                    case ELibro.Novela:
                        if (libroA is Novela)
                        {
                            retorno += ((Novela)libroA);
                        }
                        break;
                    default:
                        break;
                }
            }
            return retorno;
        }

        public static bool operator ==(Biblioteca e, Libro l)
        {
            bool retorno = false;
            foreach (Libro libro in e._libros)
            {
                if ((l is Novela) && (libro is Novela))
                {
                    if (((Novela)libro) == ((Novela)l))
                    {
                        retorno = true;
                        break;
                    }
                }
                else if ((l is Manual) && (libro is Manual))
                {
                    if (((Manual)libro) == ((Manual)l))
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static Boolean operator !=(Biblioteca e, Libro l)
        {
            return !(e == l);
        }

        public static Biblioteca operator +(Biblioteca e, Libro l)
        {
            if (e._libros.Count < e._capacidad)
            {
                if (e != l)
                {
                    e._libros.Add(l);
                }
                else
                {
                    Console.WriteLine("El libro ya esta en la biblioteca!!!\n");
                }
            }
            else
            {
                Console.WriteLine("No hay mas lugar en la biblioteca!!!\n");
            }
            return e;
        }
    }
}
