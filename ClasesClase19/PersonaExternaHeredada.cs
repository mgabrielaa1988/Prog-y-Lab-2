using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;

namespace ClasesClase19
{
    public class PersonaExternaHeredada : PersonaExterna
    {
        public PersonaExternaHeredada(string nombre, string apellido, int edad, Entidades.Externa.ESexo sexo) : base(nombre, apellido, edad, sexo) { }

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this._apellido;
            }
        }

        public int Edad
        {
            get
            {
                return this._edad;
            }
        }

        public Entidades.Externa.ESexo Sexo
        {
            get
            {
                return this._sexo;
            }
        }

        public string GetNombre()
        {
            return this.Nombre;
        }

        public string GetApellido()
        {
            return this.Apellido;
        }

        public string GetEdad()
        {
            return this.Edad.ToString();
        }

        public string GetSexo()
        {
            return this.Sexo.ToString();
        }

        public string ObtenerDatos()
        {
            return this.GetApellido() + ", " + this.GetNombre() + " Edad: " + this.GetEdad() + "Sexo: " + this.GetSexo();
        }
    }


}
