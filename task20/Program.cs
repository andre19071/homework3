// Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату по Х первой точки");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату по Y первой точки");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату по С первой точки");
double с1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату по Х второй точки");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату по Y второй точки");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату по С второй точки");
double с2 = Convert.ToDouble(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(x1-x2 ,2)+ Math.Pow(y1-y2 ,2)+ Math.Pow(с1-с2 ,2));

Console.WriteLine( $"{res:f2}");
