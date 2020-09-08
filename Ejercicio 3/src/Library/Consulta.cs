using System;
using System.Text;

namespace Library
{
    public class Consulta
    {
        private String Date {get;}
        private String Id {get;}
        
        public Consulta (Doctor a, Paciente b, Clinica c, String date, String id)
        {
            this.Date = date;
            this.Id = id;
        }
    }
}
