using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args)
  {
   Console.WriteLine(DeadFish("iiisdoso"));
  }

  public static int[] DeadFish(string data)
  {
    int value = 0;
    List<int> values = new List<int>();
    foreach(char n in data)
    {
      switch(n)
      {
        case 'i': value += 1;
         break;
        
        case 'd': value -= 1;
         break;

        case 's': value *= value;
         break;

        case 'o': values.Add(value);
         break;
      }
    }
 
  return values.ToArray();
  }
}