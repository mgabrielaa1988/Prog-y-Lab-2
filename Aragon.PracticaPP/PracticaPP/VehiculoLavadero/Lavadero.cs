using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculoLavadero
{
    class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        private static float _precioAuto;
        private static float _precioCamion;
        private static float _precioMoto;
        private string _razonSocial;

        public string LavaderoToString
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Razon Social: {0}", this._razonSocial);
                sb.AppendFormat("Precio Auto: ${0}\t Precio Camion: ${1}\t Precio Moto: ${2}", Lavadero._precioAuto, Lavadero._precioCamion, Lavadero._precioMoto);
                sb.AppendFormat("Vehiculos:\n\n{0}", ListaVehiculos);
                return sb.ToString();
            }
        }
        public string ListaVehiculos
        {
            get
            {
                StringBuilder sbAuto = new StringBuilder();
                StringBuilder sbCamion = new StringBuilder();
                StringBuilder sbMoto = new StringBuilder();
                foreach (Vehiculo item in _vehiculos)
                {
                    if(item is Auto)
                    {
                        sbAuto.AppendLine("Autos\n\n");
                        sbAuto.AppendLine(item.ToString());
                    }
                    if (item is Camion)
                    {
                        sbCamion.AppendLine("Camiones\n\n");
                        sbCamion.AppendLine(item.ToString());
                    }
                    if (item is Moto)
                    {
                        sbMoto.AppendLine("Motos\n\n");
                        sbMoto.AppendLine(item.ToString());
                    }
                }
                return sbAuto+sbCamion+sbMoto;
            }
        }

        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }
        static Lavadero()
        {
            Random random = new Random();
            _precioAuto = random.Next(150, 565);
            _precioCamion = random.Next(150, 565);
            _precioMoto = random.Next(150, 565);
        }

        double MostrarTotalFacturado()
        {

        }
        /*MostrarTotalFacturado: devolverá la ganancia total del lavadero (Double), dicho método
tendrá una sobrecarga que reciba como parámetro la enumeración EVehiculos (con Auto,
Camión y Moto como enumerados) y retornará la ganancia del Lavadero por tipo de
vehículo.
 Sobrecarga == entre un lavadero y un vehículo, retornara TRUE, si el vehículo se encuentra
en el lavadero.
 Sobrecarga == entre vehículo y lavadero, retorna -1 si no está el vehículo en el lavadero,
caso contrario, retorna el índice de donde se encuentra dicho vehículo.
 Sobrecarga del operador +, que agregara un vehículo siempre y cuando el vehículo no se
encuentre en el lavadero. Ej. miLavadero += unAuto;
 Sobrecarga del operador -, que quitara al vehículo del lavadero, siempre y cuando este
dicho vehículo. Reutilizar sobrecargas. Ej. miLavadero -= unaMoto;
 Generar un método estático (OrdenarVehiculosPorPatente : int) que reciba dos vehículos y
retorne un 0 (cero), si ambas patentes son iguales, si la primera patente es ‘mayor’ que la
segunda, retornará un 1 (uno) y si no, retornará un -1 (menos uno).
 Generar un método de instancia (OrdenarVehiculosPorMarca : int) que reciba dos
vehículos retorne un 0 (cero), si ambas marcas son iguales, si la primera marca es ‘mayor’
que la segunda, retornará un 1 (uno) y si no, retornará un -1 (menos uno).
La aplicación debe poder ingresar vehículos de distintos tipos y marcas al lavadero, quitarlos,
obtener las ganancias totales o por tipo de vehículo y mostrar los vehículos ingresados al lavadero
ordenado por los distintos criterios.*/
    }
}
