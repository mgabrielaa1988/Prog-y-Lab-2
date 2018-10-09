using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculoLavadero
{
    class Camion:Vehiculo
    {
        protected float _tara;

        public Camion(string patente, Byte ruedas, EMarcas marca, float tara) : base(patente, ruedas, marca)
        {
            this._tara = tara;
        }
        public Camion(Vehiculo vehiculo,float tara) : this(vehiculo.GetPatente, vehiculo.GetSetCantRuedas, vehiculo.GetEMarcas, tara) { }

        public override string ToString()
        {
            return base.Mostrar();
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("\t Tara: {0}", this._tara);
            return sb.ToString();
        }
    }
}
