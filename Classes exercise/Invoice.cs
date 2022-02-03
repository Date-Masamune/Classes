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
      private string partDes; //instance variable for description
      private int Qty; // instance variable for quantity
      private decimal Unitprc; // instance variable for unit_price
      private 



      public string PartNum { get; set; }  // auto-implemented property
      public string PartDes { get; set; } // auto- implemeted property

      public int qTy
      {
         get //return the quantity of item
         {
            return qTy;

         }


         set
         {
            //validate that the balance is greater the 0.0 if it's not, 
            // instance variable keeps it's prior value. 
            if (value > 0)
            {
               qTy = value;
            }

         }
      }

         public decimal UnitPrc
      {
         get
         {
            return UnitPrc;
         }

         set
         {
            if (UnitPrc > 0.0m)
            {
               UnitPrc = value;
            }


         }






      }


   }


}
   
