using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        private String Nombre;
        private String Especialidad;
        private int Id;

        public Doctor (String nombre, String especialidad, int id)
        {
            if (string.IsNullOrEmpty(nombre) & string.IsNullOrEmpty(especialidad))
            {
                return ;
            }
            else
            {
                this.Nombre = nombre;
                this.Especialidad = especialidad;
                this.Id = id;
            }
        }
    }
}
