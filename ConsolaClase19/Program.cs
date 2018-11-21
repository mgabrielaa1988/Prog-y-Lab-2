using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesClase19;
using Entidades.Externa;

namespace ConsolaClase19
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Juan", "Perez", 25, ClasesClase19.ESexo.Masculino);
            Console.WriteLine(persona1.ObtenerDatos());
            Console.ReadLine();
            PersonaExterna persona2 = new PersonaExterna("Maria", "Flores", 24, Entidades.Externa.ESexo.Femenino);
            //Console.WriteLine(persona2.ObtenerDatos());
            //Console.ReadLine();
            PersonaExternaHeredada persona3 = new PersonaExternaHeredada("Jose", "Lopez", 27, Entidades.Externa.ESexo.Indefinido);
            Console.WriteLine(persona3.ObtenerDatos());
            Console.ReadLine();
            Entidades.Externa.Sellada.PersonaExternaSellada persona4 = new Entidades.Externa.Sellada.PersonaExternaSellada("Pablo", "Perez", 34, Entidades.Externa.Sellada.ESexo.Masculino);
            Console.WriteLine(persona4.ObtenerDatos());
            Console.ReadLine();
        }
    }
}
