namespace MindBox
{
    public abstract class Figure
    {
        public abstract double CalculateArea();

        public abstract bool IfExists(params double[] values);
    }

    public class Triangle : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (IfExists(sideA, sideB, sideC))
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
            }
            else
            {
                throw new ArgumentException("Невалидная фигура");
            }
        }

        public override double CalculateArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            double area = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return Math.Round(area, 2);
        }

        public override bool IfExists(params double[] values)
        {
            if (values[0] <= 0 || values[1] <= 0 || values[2] <= 0 || // Стороны треугольника должны быть больше 0
                values[0] + values[1] <= values[2] || values[0] + values[2] <= values[1] || values[1] + values[2] <= values[0]) // Сумма двух сторон треугольника должна быть больше третьей стороны
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsTriangleRectangular()
        {
            double max = Math.Max(SideA, Math.Max(SideB, SideC));
            double min = Math.Min(SideA, Math.Min(SideB, SideC));
            double mid = SideA + SideB + SideC - max - min;

            if (Math.Pow(min, 2) + Math.Pow(mid, 2) == Math.Pow(max, 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (IfExists(radius))
            {
                Radius = radius;
            }
            else
            {
                throw new ArgumentException("Невалидная фигура");
            }
        }

        public override double CalculateArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            return Math.Round(area, 2);
        }

        public override bool IfExists(params double[] values)
        {
            if (values[0] == 0) // Окружность с радиусом 0 - точка, пропускаю отрицательные значения для расчета площади
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
