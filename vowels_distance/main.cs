using System;

class Program 
{
  public static void Main (string[] args) 
  {
    Vowels_Distance();
  }  

  public static void Vowels_Distance()
  {
    string letters = "hola";
    char[] vowels = {'a','e','i','o','u'};
    int index = 0;
      foreach(char c in letters) 
      {
        if(Array.Exists(vowels, v => v == c)) 
        { 
          index++;
          Console.WriteLine($"La vocal es: {c} y su posición es: {index}");
          break;   
        } else {
          continue; 
        }
      }
  } 
}
 /