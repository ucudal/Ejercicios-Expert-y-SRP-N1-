using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        public string Nombre;

        public string Especializacion;


        public Doctor(String nombre)
        {
            this.Nombre = nombre;

        }
        public Boolean Checkeo()
        {

            if (string.IsNullOrEmpty(this.Nombre))
            {
                Console.WriteLine("El nombre del doctor no es valido");
                return false;
            }
            return true;

        }

        public void AgregarEspecializacion(String especializacion)
        {
            if (string.IsNullOrEmpty(especializacion))
            {
                return;
            }
            this.Especializacion= especializacion;

        }

    }
}
