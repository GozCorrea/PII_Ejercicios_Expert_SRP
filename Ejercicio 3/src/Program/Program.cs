using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor Bianchi = new Doctor ("Guzman", "general", 123);
            Paciente Guz = new Paciente ("Luciana", 30, 89981556, 871);
            Clinica Septiembre = new Clinica ("Septiembre", "Ricaldoni", 191529489, 124);
            Consulta nueva = new Consulta (Bianchi, Guz, Septiembre, "12/8/2020", "878");

        }
    }
}
