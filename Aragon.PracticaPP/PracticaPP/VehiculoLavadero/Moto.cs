using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculoLavadero
{
    class Moto : Vehiculo
    { 
        protected float _cilindrada;

        public Moto(string patente, Byte ruedas, EMarcas marca, float cilindrada):base(patente,ruedas,marca)
        {
            this._cilindrada = cilindrada;
        }
        public Moto(EMarcas marca, float cilindrada, string patente, Byte ruedas) : this(patente, ruedas, marca, cilindrada) { }

        public override string ToString()
        {
            return base.Mostrar();
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("\t Cilindrada: {0}", this._cilindrada);
            return sb.ToString();
        }
    }
}
