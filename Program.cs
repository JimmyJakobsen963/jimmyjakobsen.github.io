using System;

namespace rng & switch statements
{
    class Program
{
    static void Main(string[] args)
    {
    Start:
        Random numberGenerator = new Random();

        int num01 = numberGenerator.Next(1, 11);
        int num02 = numberGenerator.Next(1, 11);

        Console.WriteLine("What is " + num01 + " times " + num02 + "?");

        int answer = Convert.ToInt32(Console.ReadLine());

        if (answer == num01 * num02)
        {
            Console.WriteLine("Well done! Your answer is correct.");
        }
        else
        {
            int responseIndex = numberGenerator.Next(1, 5);

            switch (responseIndex)
            {
                case 1:
                    Console.WriteLine("Are you even trying?");
                    break;

                case 2:
                    Console.WriteLine("The answer was incorrect.");
                    break;
                case 3:
                    Console.WriteLine("Wrong answer.");
                    break;
                default:
                    Console.WriteLine("You can do better than that!");
                    break;

            }
        //} else if {
        //    int answer = numberGenerator.Next(1, 5);

        //    switch (answer)
        //    {
        //        case 1:
        //            Console.WriteLine("Nice!");
        //            break;
        //        case 2:
        //            Console.WriteLine("Good job!");
        //            break;
        //        case 3:
        //            Console.WriteLine("Well done.");
        //    }
        //}
        Console.ReadKey();

        //Console.WriteLine ();
        //Console.ReadKey();
        //goto Start;
    }
}
}
