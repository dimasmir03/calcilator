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

        static public double sqrt(double a)
        {
            return System.Math.Sqrt(a);
            /*if (a < 0) return -1;
            for (int i = 0; i < a / 2; i++)
            {
                if (i * i == a) return i;
            }
            return -1;*/
        }
    }
}
