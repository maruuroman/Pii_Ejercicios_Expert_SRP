using System;
using System.Text;

namespace Library
{
    public class Paciente
    {
        public string Name { get; set;}
        public string Id { get; set;}
        public string PhoneNumber { get; set;}
        public string Age { get; set;}



        public Paciente(string name, string id, string phoneNumber, string age)
        {
            this.Name = name;
            this.Id = id;   
            this.PhoneNumber = phoneNumber; 
            this.Age = age;
        }
    }
}