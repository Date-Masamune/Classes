using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_exercise
{
   class InVoice
   {
      private string part_number; // instance variable for part_number
      private string part_description; //instance variable for description
      private int quantity; // instance variable for quantity
      private decimal unit_price; // instance variable for unit_price

      //property to get and set the part_number instance variable
      public string Part_number
      {
         get // returns the corrisponding instance variable's value
         {
            return part_number; //returns the value of part_number to the client code
         }
         set // assignes a new value to the coresponding instance variable
         { 
         part_number = value; //value is implicitly delcared and intialized
         }
      }

      public string Part_description
      {
         get // returns the corrisponding instance variable's value
         {
            return Part_description; //returns the value of part_description to the client code
         }
         set // assignes a new value to the coresponding instance variable
         {
            part_description = value; //value is implicitly delcared and intialized
         }


      }





   }
}
