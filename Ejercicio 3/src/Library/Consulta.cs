using System;
using System.Text;

namespace Library
{
    public class Consulta
    {
        public static String CrearConsulta (Doctor a, Paciente b, Clinica clinica, String date, String id)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;
            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }
            return stringBuilder.ToString();

        }
    }
}
