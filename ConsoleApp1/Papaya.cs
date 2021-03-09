using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Papaya : Fruit //Derived class
    {
        public string papaya = "1. Red Lady Papaya is RM90.80";

        public Papaya(int qty) : base(qty)
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
                    double price = 90.80;
                    double calTotal = price * qtySelected;

                    Console.WriteLine("\nYou are choosing " + papaya + " for quantity " + qtySelected + ".");
                    Console.WriteLine("Total: RM" + calTotal.ToString("0.00"));
                    Console.WriteLine("\n\t ***Quantity left: " + qtyLeft + "***");

                    Console.WriteLine("We always provide fresh PAPAYA for our customer.");
                    Console.WriteLine("Please proceed to counter for payment. Thank you.\n");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("" +e.Message);
            }

    }

    }
}
