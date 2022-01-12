namespace UtilityKnife.Calculator
{
    /* He modifies the Calculator class to use doubles, and
while he is at it, he makes all the methods (and the class) static. (If you're not familiar
with C#, don't worry about what that means; the important thing is that he's made a
change) */
    public class Calculator
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static double Subtract(double x, double y)
        {
            return x - y;
        }
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
        public static int Division(int x, int y)
        {
            return x / y;
        }
        public static double Division(double x, double y)
        {
            return x / y;
        }
    }
}
