using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
    
        {
            Paciente pas= new Paciente("Steven Jhonson", "986782342", "5555-555-555");
            pas.AgregarEdad("33");
            Doctor med= new Doctor("Jhonson James");
            AppointmentService app= new AppointmentService(pas,med,"Wall Street",DateTime.Now);





            //string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            //Console.WriteLine(appointmentResult);

            //string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            //Console.WriteLine(appointmentResult2);
        }
    }
}
