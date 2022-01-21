using System;

class Program
{
  public static void Main (string[] args) 
  {  
    Pago_Empleados pago = new Pago_Empleados();
    pago.Calcular_Pago();

  }
}

class Pago_Empleados
{
   public int horas;
   public int coste_horas;

  public void Calcular_Pago()
  {
   Console.WriteLine ("Ingrese el número de horas trabajadas: ");
   horas = Convert.ToInt16(Console.ReadLine());
   Console.WriteLine ("Ingrese el precio por hora: ");
   coste_horas = Convert.ToInt16(Console.ReadLine());

   Console.WriteLine($"Este es su pago total: {horas * coste_horas}$");
  }
}
