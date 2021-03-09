using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Fruit
    {
        
        protected int qty;

        public Fruit(int qty)
        {
            this.qty = qty;
        }

        /*public void welcome() //method
        {
            Console.WriteLine("\t\t\t---------------------------------");
            Console.WriteLine("\t\t\t   Welcome to Fruit Shopping!");
            Console.WriteLine("\t\t\t---------------------------------\n");
        }*/
        
        //public string welcome = "Welcome to Fruit Shopping!\n";
        public string size = "per box."; //field

        /*public virtual void selected()
        {
            Console.WriteLine("\n\t\t\t---------------------------------");
            Console.WriteLine("\t\t\t   Thank you for choosing us!");
            Console.WriteLine("\t\t\t---------------------------------");
        }*/

        public abstract void selected();

        public void payment()
        {
            Console.WriteLine("\t\t\t---------------------------------");
            Console.WriteLine("\t\t\t      Please visit us AGAIN!");
            Console.WriteLine("\t\t\t---------------------------------");
        }

    }
}
