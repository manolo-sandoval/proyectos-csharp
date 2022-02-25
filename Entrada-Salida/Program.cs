using System;

namespace Fundamentos 
{
  class EntradaSalida
  {
     public static void Main (string [] args)
     {  
         String nombre;
         Console.Write("Escribe tu nombre:");
         nombre = Console.ReadLine();
         Console.WriteLine("Hola" +  nombre);
         Console.Read();
    }
  }
}
