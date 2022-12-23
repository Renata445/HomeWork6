Console.Clear();

Console.WriteLine("Введите координату x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату x3: ");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y3: ");
double y3 = Convert.ToDouble(Console.ReadLine());

double S = Math.Abs((x1-x3)*(y2-y3)-(x2-x3)*(y1-y3))/2;

Console.WriteLine(S);