namespace MathLib0202_Lyabin
{
    public class Algebra
    {
        public static double[] QuadraticEquation(double a, double b, double c)
        {

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                throw new Exception("Уравнение не имеет действительных корней");
            }

            double sqrtDiscriminant = Math.Sqrt(discriminant);
            double x1 = (-b + sqrtDiscriminant) / (2 * a);
            double x2 = (-b - sqrtDiscriminant) / (2 * a);

            double[] squares = new double[] { x1, x2 };

            return squares;
        }

        public static double LinearEquation(double a, double b)
        {

            if (a == 0)
            {
                throw new Exception("Уравнение не является линейным");
            }
            return -b / a;
        }

        public static double SumofSeries(double[] series)
        {

            if (series.Length == 0)
            {
                throw new Exception("Ряд не содержит элементов");
            }

            double sum = 0;

            foreach (double item in series) 
            {
                sum += item;
            }
            return sum;
        }

        public static double FindMaxNumberOfSeries(double[] series)
        {
            double max = series[0];
            if (series.Length == 0)
            {
                throw new Exception("Ряд не содержит элементов");
            }

            for (int i = 1; i < series.Length; i++)
            {
                if (series[i] > max) { max = series[i]; }
                
            }

            return max;
        }

        public static double FindAverageValueInSeries(double[] series)
        {        
            return SumofSeries(series)/series.Length;
        }

}
}