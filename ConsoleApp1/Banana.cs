using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Banana : Fruit
    {
        public string banana = "2. Lady Finger Banana is RM56.50";

        public Banana(int qty) : base(qty)
        {
            this.qty = qty;
        }

        public override void selected()
        {
            try
            {
                Console.WriteLine("\t***Available quantity: " + this.qty + "***");
                Console.Write("Please select your quantity: ");
                int qtySelected = Convert.ToInt32(Console.ReadLine());

                if (qtySelected > qty)
                {
                    Console.WriteLine("Wrong quantity input.");
                }
                else
                {
                    int qtyLeft = this.qty - qtySelected;
                    double price = 56.50;
                    double calTotal = price * qtySelected;

                    Console.WriteLine("\nYou are choosing " + banana + " for quantity " + qtySelected + ".");
                    Console.WriteLine("Total: RM" + calTotal.ToString("0.00"));
                    Console.WriteLine("\n\t ***Quantity left: " + qtyLeft + "***");

                    Console.WriteLine("We always provide fresh BANANA for our customer.");
                    Console.WriteLine("Please proceed to counter for payment. Thank you.\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" + e.Message);
            }
        }

    }
}
