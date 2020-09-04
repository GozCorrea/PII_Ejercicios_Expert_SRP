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
            if (string.IsNullOrEmpty(nombre))
            {
                return ;
            }
            else
            {
                this.Nombre = nombre;
                this.Edad = edad;
                this.Phone = phone;
                this.Id = id;
            }
        }
    }
}
