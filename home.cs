using lab;
class Progam
{
    static void Main(string[] args)
    {
        while (true)
        {


            //commit
            //commit
            //long long code
            //verryyyyyyy long code
            char choice;
            Console.WriteLine("1.Operations between 2 num");
            Console.WriteLine("2.know number exponent");
            Console.WriteLine("3.know number root");
            choice = Console.ReadKey().KeyChar;

            switch (choice)
            {
                case '1':
                    Console.Clear();
                    double a, b;
                    char c;
                    Console.Write("Enter first num:"); a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second num:"); b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter op num:"); c = Convert.ToChar(Console.ReadLine());
                    Calc.Solve(a, b, c);
                    Console.ReadKey();

                    break;
                case '2':
                    Console.Clear();
                    Console.Write("Enter first num:"); a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second num:"); b = Convert.ToDouble(Console.ReadLine());
                    Calc.GetPOW(a, b);
                    Console.ReadKey();
                    break;

                case '3':
                    Console.Clear();
                    Console.Write("Enter first num:"); a = Convert.ToDouble(Console.ReadLine());
                    Calc.GetSqrt(a);
                    Console.ReadKey();
                    break;
                default:
                    Console.Clear();
                    break;
            
                

            }   


        }
    }
} 