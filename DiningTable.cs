using System;
using System.Collections.Generic;
using System.Text;

namespace exercise_inheritance_furniture
{
    //child of furniture
    public class DiningTable : Furniture
    {
        //Add  NoOfLegs  property
        public int NoOfLegs { get; set; }
        //overrride the Accept method to read NoOfLegs property also
        public override void Accept()
        {
            Console.WriteLine(NoOfLegs);
            NoOfLegs = Console.Read();
            base.Accept();
        }
        //override the Display method to include the display of NoOfLegs property also
        public override void Display()
        {
            Console.WriteLine("NoOfLegs");
            Console.WriteLine(NoOfLegs);
            base.Display();
        }



    }
}
















































/**
* @author Anilkumar.S
*
* @date - 8/24/2020 2:27:28 PM 
*/
