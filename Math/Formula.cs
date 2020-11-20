using Functions;


namespace Math
{
    public static class Formula
    {

        // (((((cosec(x)/sin(x)) -sin(x))*sin(x))^3)-(sin(x)*((ctg(x)-sec(x))^3)))

        // (((((ln(x) * log3(x)) ^ 3) + lg(x)) / log3(x)) ^ 2)

        //https://planetcalc.ru/2787/ useful thing

        public static double formula(double x)
        {
            if (x <=0)
            {
                double part1 = ((Func.Csc(x) / Func.Sin(x)) - Func.Sin(x))*Func.Sin(x);
                double part2 = Func.Sin(x) * Func.Pow(Func.cotan(x) - Func.Sec(x), 3);
                return Func.Pow(part1, 3) - part2;
            }

            else 
            {
                return Func.Pow((Func.Pow(Func.Ln(x) * Func.Log(x, 3),3) + Func.Log(x, 10)) / Func.Log(x, 3), 2);
            }
        }
    }
}
