using System;

namespace math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bool cal = false;
            bool entry= false;
            double amtGiven = 0;
            double cost = 0;
            mathCal obj = new mathCal();
            while(!cal)
            {
                Console.WriteLine("Enter price:" +"\n");
                cost = cost + double.Parse(Console.ReadLine());
                Console.WriteLine("Add another item?(y/n)");
                var addItem = Console.ReadLine();
                
                if (addItem == "n"|| addItem == "N")
                        {
                    cal = true;
                }
                else if (addItem == "Y" || addItem == "y")
                {
                    cal = false;
                }
                else
                {
                    
                       Console.WriteLine("Invaild entry!" + "\n" + "Try Again");

                    entry = true;
                    if (entry == true)
                    {
                        cost = 0;
                    }

                }



              
            }
            Console.WriteLine("Enter the amount given");
            amtGiven = double.Parse(Console.ReadLine());
            Console.WriteLine("Your change is : R"+ obj.change(amtGiven, cost));
           

        }
    }
}
