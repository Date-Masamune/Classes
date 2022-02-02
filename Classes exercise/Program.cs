using System;

namespace Classes_exercise
{
   class program
   {
    
      static void Main(string[] args)
      {
         InVoice Invoice1 = new InVoice("0511589, nails, 5, 4.15");

         Console.WriteLine($"The Part Number is {InVoice.partNum}");
         

      }
   }
}
