using System;
/* No cumple Expert ya que esta clase posee mas informacion de la necesaria:
     el libro no tiene porque conocer la estanteria
   NO cumple SRP ya que tiene mas de una razon de cambio: 
    Si se quisiera editar para incluir total de paginas de libro es una razon de cambio
    Si se quisiera editar la forma de almacenamiento seria otra razon de cambio
    

*/
namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }


    }
}
