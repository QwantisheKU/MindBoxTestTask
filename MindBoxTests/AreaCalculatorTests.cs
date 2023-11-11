using MindBox;

namespace MindBoxTests
{
	[TestClass]
	public class TriangleTest
	{
		[TestMethod]
		public void Triangle_5_3_5_Return_7_15()
		{
			var triangle = new Triangle(5, 3, 5);
			var area = triangle.CalculateArea();

			Assert.AreEqual(area, 7.15);
		}

		[TestMethod]
		public void Triangle_3_4_5_IsRectengular_ReturnTrue()
		{
			var triangle = new Triangle(3, 4, 5);
			var rect = triangle.IsTriangleRectangular();

			Assert.IsTrue(rect);
		}
	}

	[TestClass]
	public class CircleTest
	{
		[TestMethod]
		public void Circle_4_Return_50_27()
		{
			var circle = new Circle(4);
			var area = circle.CalculateArea();

			Assert.AreEqual(area, 50.27);
		}
	}
}