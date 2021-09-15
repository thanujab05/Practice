using System;

namespace exercise_inheritance_furniture
{
    //child of Furniture
    public class BookShelf : Furniture
    {
        //Add  NoOfShelves  property
        public int NoOfShelves { get;set; }
        //overrride the Accept method to read NoOfLegs property also
        public override void Accept()
        {
            Console.WriteLine(NoOfShelves);
            NoOfShelves = Console.Read();
            base.Accept();
        }
        //override the Display method to include the display of NoOfLegs property also
        public override void Display()
        {
            Console.WriteLine("NoOfShelves");
            Console.WriteLine(NoOfShelves);
            base.Display();
        }





    }
}













































/**
* @author Anilkumar.S
*
* @date - 8/24/2020 2:28:32 PM 
*/
