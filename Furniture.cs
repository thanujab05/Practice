using System;

namespace exercise_inheritance_furniture
{
    public class Furniture
    {
        //Add below mentioned Properties 
        //Height(int),Width(int),Color(string),Price(double),Qty(int)
        public int Height { get; set; }
        public int Width { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }

        public virtual void Accept()
        {
            //code to accept height,width ,color,price and qty
            Console.WriteLine("Height");
            Height = Console.Read();
            Console.WriteLine("Width");
            Width = Console.Read();
            Console.WriteLine("Color");
            Color = Console.ReadLine();
            Console.WriteLine("Price");
            Price = Console.Read();
            Console.WriteLine("Qty");
            Qty = Console.Read();

        }
        public virtual void Display()
        {
            //code to display height width ,price,qty and color
            Console.WriteLine("Height");
            Console.WriteLine(Height);
            Console.WriteLine("Width");
            Console.WriteLine(Width);
            Console.WriteLine("Color");
            Console.WriteLine(Color);
            Console.WriteLine("Price");
            Console.WriteLine(Price);
            Console.WriteLine("Qty");
            Console.WriteLine(Qty);


        }
    }
}















/**
* @author Anilkumar.S
*
* @date - 8/24/2020 2:24:45 PM 
*/
