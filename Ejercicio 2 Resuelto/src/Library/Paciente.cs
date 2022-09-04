using System;
using System.Text;

namespace Library
{
    public class Paciente
    {
        public string Nombre;
        public string Id;
        public string Telefono;

        public string Edad;

        public Paciente(String nombre, String id, String telefono)
        {
            this.Nombre = nombre;
            this.Id = id;
            this.Telefono = telefono;
        }
        public Boolean Checkeo()
        {
            Boolean isValid = true;
            if (string.IsNullOrEmpty(this.Nombre))
            {
                Console.WriteLine("El nombre del paciente no es valido");
                isValid = false;
            }
            if (string.IsNullOrEmpty(this.Id))
            {
                Console.WriteLine("El id del paciente no es valido");
                isValid = false;
            }
            if (string.IsNullOrEmpty(this.Telefono))
            {
                Console.WriteLine("El telefono del paciente no es valido");
                isValid = false;
            }
            return isValid;
        }

        public void AgregarEdad(String edad)
        {
            if (string.IsNullOrEmpty(edad))
            {
                return;
            }
            this.Edad= edad;

        }

    }
}
