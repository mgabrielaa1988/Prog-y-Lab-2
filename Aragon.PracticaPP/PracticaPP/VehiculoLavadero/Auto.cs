using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculoLavadero
{
    class Auto : Vehiculo
    {
        protected int _cantidadAsientos;

        public Auto(string patente, Byte ruedas, EMarcas marca, int cantAsientos) : base(patente, ruedas, marca)
        {
            this._cantidadAsientos = cantAsientos;
        }
        public Auto(string patente, EMarcas marca, int cantAsientos) : this(patente, 4, marca, cantAsientos) { }

        public override string ToString()
        {
            return base.Mostrar();
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("\t Cantidad de asientos: {0}", this._cantidadAsientos);
            return sb.ToString();
        }
    }
}
