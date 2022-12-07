/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве. 
Задание должно быть выполнено в методе. 
В методе не должно быть вывода в консоль.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
Console.WriteLine("Введите координаты точек А и Б");
bool isNumX1 = double.TryParse(Console.ReadLine(), out double coordinatesx1);
bool isNumY1 = double.TryParse(Console.ReadLine(), out double coordinatesy1);
bool isNumZ1 = double.TryParse(Console.ReadLine(), out double coordinatesz1);
bool isNumX2 = double.TryParse(Console.ReadLine(), out double coordinatesx2);
bool isNumY2 = double.TryParse(Console.ReadLine(), out double coordinatesy2);
bool isNumY3 = double.TryParse(Console.ReadLine(), out double coordinatesz2);
double amountX = coordinatesx2 - coordinatesx1;
double amountY = coordinatesy2 - coordinatesy1;
double amountZ = coordinatesz2 - coordinatesz1;
double Calculation(double amountX, double amountY, double amountZ)
{
    double distance = Math.Sqrt(amountX * amountX + amountY * amountY + amountZ * amountZ);
    return distance;
    Console.WriteLine();
}
double result = Calculation(amountX, amountY, amountZ);
Console.WriteLine($"Длинна отрезка {result}");


