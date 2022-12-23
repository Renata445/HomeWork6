Console.Clear();
Console.WriteLine("Введите k1: ");
double number_k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double number_k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1: ");
double number_b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double number_b2 = Convert.ToDouble(Console.ReadLine());
double x, y;

x = -(number_b1 - number_b2) / (number_k1 - number_k2);
y = number_k1 * x + number_b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");