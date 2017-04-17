using System;
using System.Linq;
using System.Text;

namespace CSC6dotNET46
{
    class Program
    {
        static void Main(string[] args)
        {
            //FunWithStringBuilder();
            //LinqQueryOverInts();
            //ValueTypeContainingRefType();
            FunWithCars();
            Console.Read();
        }

        static void FunWithCars()
        {
            Console.WriteLine("***** Fun with Class Types *****\n");
            
            // Allocate and configure a Car object
            Car myCar = new Car
            {
                petName = "Henry",
                currSpeed = 10
            };

            // Speed up the car a few times and print out the new state.
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }
        }

        static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using the StringBuilder:");
            StringBuilder sb = new StringBuilder("**** Fantastic Games ****");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("Deus Ex" + "2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", " Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
            Console.WriteLine();
        }

        static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            // LINQ query!  
            var subset = from i in numbers where i < 10 select i;

            Console.Write("Values in subset: ");
            foreach (var i in subset) { Console.Write("{0} ", i); }
            Console.WriteLine();

            // Hmm...what type is subset?  
            Console.WriteLine("subset is a: {0}", subset.GetType().Name);
            Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
        }

        class ShapeInfo
        {
            public string infoString;

            public ShapeInfo(string info)
            {
                infoString = info;
            }
        }

        struct Rectangle
        {
            public ShapeInfo rectInfo;

            public int rectTop, rectLeft, rectBottom, rectRight;

            public Rectangle(string info, int top, int left, int bottom, int right)
            {
                rectInfo = new ShapeInfo(info);
                rectTop = top;
                rectBottom = bottom;
                rectLeft = left;
                rectRight = right;
            }

            public void Display()
            {
                Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, " +
                    "Left = {3}, Right = {4}",
                    rectInfo.infoString, rectTop, rectBottom, rectLeft, rectRight);
            }
        }

        static void ValueTypeContainingRefType()
        {
            // Create the first Rectangle
            Console.WriteLine(" -> Creating r1");
            Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);

            // Now assign a new Rectangle to r1
            Console.WriteLine(" -> Assigning r2 to r1");
            Rectangle r2 = r1;

            // Change some values of r2.
            Console.WriteLine(" -> Changing values of r2");
            r2.rectInfo.infoString = "This is new info!";
            r2.rectBottom = 4444;

            // Print values of both rectangles.
            r1.Display();
            r2.Display();
        }
    }
}
