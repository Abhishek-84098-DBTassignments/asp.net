using Calculator1;
namespace MenuDrivenCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            while (true)
            {
                Console.WriteLine("Enter value of a : ");
                string aValue = Console.ReadLine();
                int a = Convert.ToInt32(aValue);

                Console.WriteLine("Enter value of b : ");
                string bValue = Console.ReadLine();
                int b = Convert.ToInt32(bValue);

                Console.WriteLine("Choose Operation :: 1.Add  2.Sub  3.Mul  4.Div");
                int opchoice = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                switch(opchoice)
                {
                    case 1:
                        result = calc.Add(a, b);
                        Console.WriteLine(result);
                        break;

                    case 2:
                        result = calc.Sub(a, b);
                        Console.WriteLine(result);
                        break;

                    case 3:
                        result = calc.Mul(a, b);
                        Console.WriteLine(result);
                        break;

                    case 4:
                        result = calc.Div(a, b);
                        Console.WriteLine(result);
                        break;

                    default:
                        Console.WriteLine("Invalid choice!!!");
                        break;
                }
                Console.WriteLine("Do you want continue? y/n");
                string choice = Console.ReadLine();
                if(choice != "y")
                {
                    break;
                }
                Console.WriteLine("Hit enter to close the app!!");
                Console.ReadLine();
            }
        }
    }
}
