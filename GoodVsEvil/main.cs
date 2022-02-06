using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
class Program {

  public static void Main (string[] args) 
  {
    Console.WriteLine(GoodVsEvil("0 8 0 3 4 2", "3 6 7 5 2 1 1"));
  }
  
      public static string GoodVsEvil(string good, string evil)
      {

          List <string> goodParse = good.Split(' ').ToList(); //list of good for parse
          List <string> evilParse = evil.Split(' ').ToList(); // "" of evil for parse

          List <int> intermediate_list = new List<int>(); // list create for parse of "goods"

          List <int> intermediate_list_2 = new List<int>();  // list create for parse of "evil"

          foreach(string m in goodParse) //iteration of GoodParse
          {
           intermediate_list.Add(Convert.ToInt16(m));
          }
          int [] miau = intermediate_list.ToArray();
  //Calculate worths good of battle
         int GoodWorth =
         (int) Good.Hobbits * miau[0] +
         (int) Good.Men * miau[1] +
         (int) Good.Elves * miau[2] +
         (int) Good.Dwarves * miau[3] +
         (int) Good.Eagles * miau[4] +
         (int) Good.Wizards * miau[5]; 

        //-------------Evil------------------
        foreach(string n in evilParse) //iteration of evilParse
        {
          intermediate_list_2.Add(Convert.ToInt16(n));
        }
         
        int [] miau_2 = intermediate_list_2.ToArray();
        
// calculate worths evil of battle
         int EvilWorth =
         (int) Evil.Orcs * miau_2[0] +
         (int) Evil.Men * miau_2[1] +
         (int) Evil.Wargs * miau_2[2] +
         (int) Evil.Goblins * miau_2[3] +
         (int) Evil.UrukHai * miau_2[4] +
         (int) Evil.Trolls * miau_2[5] + 
         (int) Evil.Wizards * miau_2[6];
          
       
         return (GoodWorth > EvilWorth) ? "Battle Result: Good triumphs over Evil" : (GoodWorth == EvilWorth) ? "Battle Result: No victor on this battle field" : "Battle Result: Evil eradicates all trace of Good" ; 

      }

      enum Good  // races
      {
         Hobbits = 1,

         Men = 2,

         Elves = 3,

         Dwarves = 3,
 
         Eagles = 4,

         Wizards = 10
      };
       
      enum Evil
      {
         Orcs = 1,

         Men = 2,

         Wargs = 2,

         Goblins = 2,

         UrukHai = 3,

         Trolls = 5,

         Wizards= 10
      };

}
