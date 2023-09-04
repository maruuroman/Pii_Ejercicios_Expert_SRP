using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        
        public static string CreateAppointment( string name, string id, string phoneNumber, string age, DateTime date, string appointmentPlace, string doctorName, string specialty )
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phoneNumber' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(age))
            {
                stringBuilder.Append("Unable to schedule appointment, 'age' is required\n");
                isValid = false;
            }

             if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(specialty))
            {
                stringBuilder.Append("Unable to schedule appointment, 'specialty' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appointment place' is required\n");
                isValid = false;
            }
            
            if (isValid)
            {
                Paciente pacienteData = new Paciente(name, id, phoneNumber, age);

                Dr drData = new Dr(doctorName, specialty);
        
               stringBuilder.Append($"Appoinment scheduled the {date}, at {appointmentPlace} for {name} id number: {id} with Dr.{doctorName}, seecialty {specialty}");            }

            return stringBuilder.ToString();


        }  
    }
}