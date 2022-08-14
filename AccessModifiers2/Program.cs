using AccessModifiers2.Models;
using System;
using System.Text.RegularExpressions;

namespace AccessModifiers2
{
    class Program
    {
        static void Main(string[] args)
        {
            Singer Rovsen = new Singer()
            {
                Name = "rovsen",
                Surname = "Xelilli",
                Age = 19
                

            };
            Song Money = new Song()
            {
                Singer = Rovsen,
            };
       
          Money.Name = "Money";
          Money.Genre = "Pop";
          string spice = " ";
         Console.WriteLine(Money.Singer.Name + spice + Money.Singer.Surname + spice + Money.Singer.Age +spice+ Money.Name + spice + Money.Genre);
          
            
            
        
       
           


        }

       
    }
}
