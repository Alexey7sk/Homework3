// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] coordinates = new int[6];

System.Console.WriteLine("Введите координату x1: ");
coordinates[0] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату y1: ");
coordinates[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату z1: ");
coordinates[2] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату x2: ");
coordinates[3] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату y2: ");
coordinates[4] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату z2: ");
coordinates[5] = Convert.ToInt32(Console.ReadLine());


double distance = Math.Sqrt((coordinates[3]-coordinates[0]) * (coordinates[3]-coordinates[0]) + (coordinates[4]-coordinates[1]) * (coordinates[4]-coordinates[1]) + (coordinates[5]-coordinates[2]) * (coordinates[5]-coordinates[2]));
System.Console.WriteLine($"Расстояние между точками равно: {distance}");
