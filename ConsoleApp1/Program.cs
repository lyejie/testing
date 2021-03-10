using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //create a fruit object
            //var fruit = new Fruit(190);
            var papaya = new Papaya(50);
            var banana = new Banana(40);
            var strawberry = new Strawberry(70);
            var apple = new Apple(30);
            var durian = new Durian(55);

            //fruit.welcome();


            //Console.WriteLine(papaya.welcome);
            Console.WriteLine(papaya.papaya + " " + papaya.size);
            Console.WriteLine(banana.banana + " " + banana.size);
            Console.WriteLine(strawberry.strawberry + " " + strawberry.size);
            Console.WriteLine(apple.apple + " " + apple.size);
            Console.WriteLine(durian.durian + " " + durian.size);

            try
            {
                Console.Write("\nWhich item do you wish to purchase? (1-4, select one only): ");
                int item = Convert.ToInt32(Console.ReadLine());

                switch (item)
                {
                    case 1:
                        papaya.selected();
                        papaya.payment();
                        break;

                    case 2:
                        banana.selected();
                        banana.payment();
                        break;

                    case 3:
                        strawberry.selected();
                        strawberry.payment();
                        break;

                    case 4:
                        apple.selected();
                        apple.payment();
                        break;

                    case 5:
                        durian.selected();
                        durian.payment();
                        break;

                    default:
                        Console.WriteLine("\nNo selected item. Please try again.\n");
                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Please input an integer value. \n" + e.Message);
            }

        }
    }
}
