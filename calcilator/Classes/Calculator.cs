namespace calcilator.Classes
{
    class Calculator
    {
        static public int div(int a, int b)
        {
            return a / b;
        }
        static public int add(int a, int b)
        {
            return a + b;
        }
        static public int mult(int a, int b)
        {
            return a * b;
        }
        static public int sub(int a, int b)
        {
            return a - b;
        }
        static public double div(double a, double b)
        {
            return a / b;
        }
        static public double add(double a, double b)
        {
            return a + b;
        }
        static public double mult(double a, double b)
        {
            return a * b;
        }
        static public double sub(double a, double b)
        {
            return a - b;
        }
        static public int pow(int a)
        {
            return a*a;
        }
        static public double pow(double a)
        {
            return a * a;
        }
        static public double sqrt(double number)
        {
            double t;
            double squareRoot = number / 2;
            do
            {
                t = squareRoot;
                squareRoot = (t + (number / t)) / 2;
            } while ((t - squareRoot) != 0);

            return squareRoot;
        }
    }
}
