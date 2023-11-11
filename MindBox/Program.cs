using MindBox;

Console.WriteLine("Тестовый треугольник:");
Triangle triangle = new Triangle(3, 4, 5);
Console.WriteLine($"Площадь: {triangle.CalculateArea()}");
Console.WriteLine($"Прямоугольный: {triangle.IsTriangleRectangular()}");


Console.WriteLine("Тестовый круг:");
Circle circle = new Circle(4);
Console.WriteLine($"Площадь: {circle.CalculateArea()}");