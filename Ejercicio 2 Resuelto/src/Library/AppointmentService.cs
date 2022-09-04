using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {

        public string Donde;
        public DateTime Cuando;
        public static int Codigo;

        public Paciente Enfermo;

        public Doctor Doc;



        public AppointmentService(Paciente enfermo, Doctor doc,String donde, DateTime cuando)
        {
            this.Donde = donde;
            Codigo++;
            this.Cuando = cuando;
            this.Enfermo = enfermo;
            this.Doc = doc;
            if (this.Checkeo())
            {
                this.Mostrar();

            }
            
        }

        public void Mostrar()
        {

            Console.WriteLine($"Se agendo una consulta a nombre de {this.Enfermo.Nombre}\ncon el doctor {this.Doc.Nombre} para el {this.Cuando} en {this.Donde} ");
            


        }
        public Boolean Checkeo()
        {
            Boolean isValid = true;

            if (string.IsNullOrEmpty(this.Donde))
            {
                Console.WriteLine("El lugar no es valido");
                isValid = false;

            }
            if (!this.Enfermo.Checkeo())
            {
                isValid = false;

            }
            if (!this.Doc.Checkeo())
            {
                isValid = false;

            }
            return isValid;

        }
    }

        

}

