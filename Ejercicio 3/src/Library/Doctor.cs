using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        private String Nombre {get; set;}
        private String Especialidad;
        private int Id;

        public Doctor (String nombre, String especialidad, int id)
        {
            this.Nombre = nombre;
            this.Especialidad = especialidad;
            this.Id = id;
        }
    }
}
