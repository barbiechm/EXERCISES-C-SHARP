using System;

class Program 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine("Input a string for reverse it position: ");
    Reverse_String(Console.ReadLine());
  }

  public static void Reverse_String(string s)
  {
     
     char[] arr = s.ToCharArray();
     Array.Reverse(arr);
     Console.WriteLine( new String(arr));
      
  }
} 
  
