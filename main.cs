using System;
class Program 
{
  public static void Main (string[] args)
  {
     Asteriscos();
  }

  	public static void Asteriscos()
 	  {
    Console.WriteLine("Ingresa una palabra: ");
		string ast = Console.ReadLine();
		int asterik_count = 0;
		
	   	foreach (char pito in ast)
	  	{
		   if(pito == '*')
        {
           asterik_count += 1;
        }
		  }
      Console.WriteLine("La cantidad de asteriscos es: {0}", asterik_count);
    }
}
