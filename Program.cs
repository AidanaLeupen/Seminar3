// программа принимает координаты точки (x, y) и выдает 
// номер четверти плоскости. X и Y не равны нулю. 

Console.Write("x = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
    Console.Write("1");
else if (x < 0 && y > 0)
    Console.Write("2");
else if (x < 0 && y < 0)
    Console.Write("3");
else if (x > 0 && y < 0)
    Console.Write("4");
