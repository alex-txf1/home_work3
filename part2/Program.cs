Console.WriteLine("поиск расстояния между точками в 3D");
Console.WriteLine("_______________________________");
Console.Write("введите координаты x1   ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координаты x2   ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координаты y1   ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координаты y2   ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координаты z1   ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координаты z2   ");
double z2 = Convert.ToInt32(Console.ReadLine());
double dist(double x1 , double x2 , double y1 , double y2 , double z1 , double z2)
{
    //double result = 0;
    double result = Math.Sqrt(Math.Pow(x2-x1, 2 ) + Math.Pow(y2-y1, 2 ) + Math.Pow(z2-z1, 2 ));
    return result;
}
double A = dist(x1 , x2 , y1 , y2 , z1 , z2);
Console.WriteLine(A);