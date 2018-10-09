using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculoLavadero
{
    class Vehiculo
    {
        protected string _patente;
        protected Byte _cantRuedas;
        protected EMarcas _marca;

        public string GetPatente
        {
            get { return this._patente; }
        }
        public Byte GetSetCantRuedas
        {
            get { return this._cantRuedas; }
            set { this._cantRuedas = value; }
        }
        public EMarcas GetEMarcas
        {
            get { return this._marca; }
        }
        public Vehiculo(string patente,Byte ruedas,EMarcas marca)
        {
            this._patente = patente;
            this._cantRuedas = ruedas;
            this._marca = marca;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Marca: {0}\t Cantidad de ruedas: {1}\t Patente: {2}", this._marca, this._cantRuedas, this._patente);
            return sb.ToString();
        }
        public static bool operator ==(Vehiculo v1,Vehiculo v2)
        {
            bool retorno = false;
            if(v1 is Vehiculo && v2 is Vehiculo)
            {
                if ((v1._patente == v2._patente) && (v1._marca == v2._marca))
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
