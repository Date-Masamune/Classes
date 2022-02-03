using System;

namespace Classes_exercise
{
   class program
   {
    
      static void Main(string[] args)
      {
         InVoice Invoice1 = new InVoice(" 0415"," nails",  5 ,  4.15m);

         Console.WriteLine($"The Part Number is { Invoice1.PartNum}");


         Console.WriteLine($"The item is{ Invoice1.PartDes}");

        
         Console.WriteLine($"The quantity is{ Invoice1.qTy}");


         Console.WriteLine($"The price is{ Invoice1.UnitPrice}");

         
         Console.WriteLine($"The Invoice amout is{ InVoice.GetInAmount( Invoice1.qTy, Invoice1.UnitPrice)}");

         
      }
   }
}
