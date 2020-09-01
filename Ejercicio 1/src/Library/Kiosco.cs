using System;
// No cumple SRP ya que si se agregan distintas monedas ya habria una razon de cambio
//Cumple Expert
namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            //Double pesos = Cambio.ConvertirAPesos(dinero, moneda);
            Double pesos = dinero;
            return pesos >= a.GetPrecioAlfajor();
        }
        
    }
}