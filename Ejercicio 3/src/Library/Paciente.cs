using System;
using System.Text;

namespace Library
{
    public class Paciente
    {
        private String Nombre;
        private int Edad;
        private int Phone;
        private int Id;
        public Paciente (String nombre, int edad, int phone, int id)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Phone = phone;
            this.Id = id;
        }
    }
}
