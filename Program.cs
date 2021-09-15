using System;

namespace exercise_inheritance_furniture
{
    public class Program
    {
        static void Main(string[] args)
        {
            //create an array  of objects in furniture type
            Furniture[] f = new Furniture[2];
            //create program class object
            Program p = new Program();
            // call AddToStock(<furniture array>);
            p.AddToStock(f);
            //call ShowStockDetails(<furniture array>);
            p.ShowStockDetails(f);
            // call TotalStockValue(<furniture array>) and display output 
            Console.WriteLine("Total Stock Value = ", p.TotalStockValue(f));
        }
        public int AddToStock(Furniture[] items)
        {
            //accept the choice from user for type of furniture(BookShelf  or DiningTable)
            int i = 0;

            Console.WriteLine("Please select from the folowing options 1. DInning Table 2. Book shelf");
            int choice = Convert.ToInt32(Console.ReadLine());
            // and according to the choice create necessary sub class object and store data
            do
            {
                switch (choice)
                {
                    //continue the process up to the size of array
                    case 1:
                        items[i] = new DiningTable();
                        items[i].Accept();
                        break;
                    case 2:
                        items[i] = new BookShelf();
                        items[i].Accept();
                        break;

                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
                i++;
            } while (i < items.Length);
            return items.Length;
        // return <size of array>;
    }
    public double TotalStockValue(Furniture[] items)
        {
            double stockValue = default;
            //calculate total stock value i.e qty * price of each item
            foreach (Furniture f in items)
            {
                stockValue = f.Price * f.Qty;
            }
            return stockValue;
        }
        public int ShowStockDetails(Furniture[] items)
        {
            //call display method from all object to display the stock 
            //return <size of array>;
            foreach (Furniture f in items)
            {
                f.Display();
            }
            return items.Length;
        }
    }
    }
