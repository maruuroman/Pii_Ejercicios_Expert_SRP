using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            string appointmentResult = AppointmentService.CreateAppointment("Juan", "54687315", "098-654-321", "28", DateTime.Now, "Wall Street", "Bautista", "Nutricionista");
            Console.WriteLine(appointmentResult);
                    
        }
    }
}