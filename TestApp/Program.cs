using MathLib0202_Lyabin;


double[] series = { 1, 2, 3, 4, 5 };

Console.WriteLine("Sum of series: " + Algebra.SumofSeries(series));
Console.WriteLine("Average value in series: " + Algebra.FindAverageValueInSeries(series));
Console.WriteLine("Triangle area: " + Geometry.FindTriangleArea(5, 8));
Console.WriteLine("Right triangle area: "+ Geometry.FindRightTriangleArea(5, 8));
Console.WriteLine("Cosinus of 180: " + Trigonometry.Cos(180));
Console.WriteLine(Algebra.LinearEquation(0, 2));



