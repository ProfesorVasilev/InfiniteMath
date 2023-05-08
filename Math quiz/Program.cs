using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks.Sources;

while (true)
{
    Random randomGenerator = new Random();
    int randomN1 = randomGenerator.Next(1, 100);
    int randomN2 = randomGenerator.Next(1, 100);
    int actDecider = randomGenerator.Next(1, 4); //1+  2-  3x
    switch (actDecider)
    {
        case 1:
            int sum = randomN1 + randomN2;
            while (true)
            {
                Console.Write($"{randomN1} + {randomN2} = ");
                int guess = int.Parse(Console.ReadLine());
                if (guess == sum)
                {
                    Console.WriteLine("Ur right");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }
            break;
        case 2:
            int diff = randomN1 - randomN2;
            while (true)
            {
                Console.WriteLine($"{randomN1} - {randomN2} = ");
                int guess = int.Parse(Console.ReadLine());
                if (guess == diff)
                {
                    Console.WriteLine("Good job!");
                    break;
                }
                else
                {
                    Console.WriteLine("try again");
                }
            }
            break;
        case 3:
            int mult1 = randomGenerator.Next(3, 12);
            int mult2 = randomGenerator.Next(3, 12);
            int result = mult1 * mult2;
            while (true)
            {
                Console.WriteLine($"{mult1} x {mult2} = ");
                int guess = int.Parse(Console.ReadLine());
                if (guess == result)
                {
                    Console.WriteLine("Nice one!");
                    break;
                }
                else
                {
                    Console.WriteLine("try again");
                }
            }
            break;

    }
}
