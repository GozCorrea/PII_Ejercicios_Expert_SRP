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
            if (string.IsNullOrEmpty(nombre) & string.IsNullOrEmpty(address))
            {
                return ;
            }
            else
            {
                this.Nombre = nombre;
                this.Address = address;
                this.Phone = phone;
                this.Id = id;
            }
        }
    }
}

