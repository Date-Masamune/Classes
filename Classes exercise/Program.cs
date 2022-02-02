using System;

namespace Classes_exercise
{
   class program
   {
    
      static void Main(string[] args)
      {
         InVoice myInVoice = new InVoice();

         Console.Write("Please enter the part number"); //prompt
         myInVoice.Part_number = Console.ReadLine(); 
         //display part_number 
         Console.WriteLine($"Part number is: {myInVoice.Part_number}");


         Console.Write("Please enter the description"); //prompt
         myInVoice.Part_description = Console.ReadLine();
         //display description 
         Console.WriteLine($"Description is: {myInVoice.Part_description}");

      }
   }
}
