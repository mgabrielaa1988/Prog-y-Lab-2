using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesClase19
{
    public static class Extensora
    {
        public static string ObtenerDatos(this Entidades.Externa.Sellada.PersonaExternaSellada sellada)
        {
            return sellada.Apellido + ", " + sellada.Nombre + " Edad: " + sellada.Edad + " Sexo: " + sellada.Sexo;
        }

        public static bool EsNulo(this Object obj)
        {
            if (obj == null)
                return true;
            return false;
        }

        //tiene que mostrar la cantidad de digitos
        public static Int32 CantidadDigitos(this Int32 num)
        {
            Int32 cantidad = (Int32)Math.Floor(Math.Log10(num)+1);          
            return cantidad;
        }

        public static bool TieneLaMismaCantidad(this Int32 num1, Int32 num2)
        {
            if (num1.CantidadDigitos() == num2.CantidadDigitos())
                return true;
            return false;
        }
    }
}
