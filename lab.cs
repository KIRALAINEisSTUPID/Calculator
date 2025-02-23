namespace lab
{
    class Calc
    {
        public static void Solve(double a,double b,char op)
        {
           switch (op)
            {
                case '+':
                    Console.WriteLine(a + b); break;
                case '-':
                    Console.WriteLine(a - b); break;
                case '/':
                    if (b == 0){
                        Console.WriteLine("are u know that you cant do this or u just playing with me?");
                    }
                    break;
                case '*':
                    Console.WriteLine(a * b);
                    break;
                        
            }
        }
    }
}