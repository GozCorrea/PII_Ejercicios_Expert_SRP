using System;

namespace SRP
{
    public class Almacenamiento
    {
        private string SectorBiblioteca { get ; set; }
        private string EstanteBiblioteca { get ; set; }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
