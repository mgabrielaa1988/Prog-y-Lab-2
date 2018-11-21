using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ClasesClase19
{
    public enum ESexo { Masculino, Femenino, Indeterminado}

    public class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected int _edad;
        protected ESexo _sexo;

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

        public ESexo Sexo
        {
            get
            {
                return this._sexo;
            }
        }

        public Persona(string nombre, string apellido, int edad, ESexo sexo)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
            this._sexo = sexo;
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

        public List<Persona> TraerDB(this Persona pers)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Conexion);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * from personas";
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Persona> personas = new List<Persona>();
            while (reader.Read())
            {
                Persona p = new Persona(reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
            }
        }
    }
}
