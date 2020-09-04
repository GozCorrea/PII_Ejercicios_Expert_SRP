using System;
// No cumple SRP ya que si se agregan distintas monedas ya habria una razon de cambio
//Cumple Expert
namespace Expert_SRP
{
    public class Cambio 
    {
        public static Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}