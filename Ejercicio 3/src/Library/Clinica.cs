using System;
using System.Text;

namespace Library
{
    public class Clinica
    {
        private String Nombre;
        private String Address;
        private int Phone;
        private int Id;

        public Clinica (String nombre, String address, int phone, int id)
        {
            this.Nombre = nombre;
            this.Address = address;
            this.Phone = phone;
            this.Id = id;
        }
    }
}

