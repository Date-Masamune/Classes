using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_exercise
{
   class InVoice
   {

     

      private string partNum; // instance variable for part_number
      private string partDes; // instance variable for part_number
      private int Qty; // instance variable for quantity
      public decimal UnitPrice; // instance variable for unit_price
      

      public InVoice(string parts, string Des, int Quant, decimal price)
      {
         PartNum = parts;
         PartDes = Des;
         Qty = Quant;
         UnitPrice = price;
      }


      public string PartNum
      {
         get
         {
            return partNum;  // return the value of the client code
         }

         set
         {
            partNum = value; //value is implicitly declared and intialized 
         }
      }
      

      public string PartDes
      {
         get
         {
            return partDes; // retuns the value of the client code
         }

         set
         {
            partDes = value; //vale is implicitly declared and initialized 
         }

      }

      public static decimal GetInAmount(int Quant, decimal price) 
      {
         return Quant * price;
      }
     
        


      public int qTy
      {
         get //return the quantity of item
         {
            return Qty;

         }


         set
         {
            //validate that the balance is greater the 0.0 if it's not, 
             //instance variable keeps it's prior value. 
            if (value > 0)
            {
               qTy = value;
            }

         }
      }

         public decimal Unitprice
      {
         get
         {
            return UnitPrice;
         }

         set
         {
            if (UnitPrice > 0.0m)
            {
               UnitPrice = value;
            }


         }


         




      }


   }


}
   
