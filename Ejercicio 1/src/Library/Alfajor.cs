using System;
// Se agrega el calculo del precio del alfajor para cumplir con Expert
namespace Expert_SRP
{
    public class Alfajor 
    {
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}

        public double GetPrecioAlfajor()
        {
            return this.PrecioDulce + this.PrecioMasa;
        }
    }
}