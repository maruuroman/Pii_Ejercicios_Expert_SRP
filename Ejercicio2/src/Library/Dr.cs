using System;
using System.Text;

namespace Library
{
    public class Dr
    {
         public string DoctorName { get; set;}
        public string Specialty { get; set;}

        public Dr(string doctorName, string specialty)
        {
            this.DoctorName = doctorName;
            this.Specialty = specialty;   
            
        }
    }
}