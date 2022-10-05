using GeometryLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace GeometryTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CircleInt()
        {
            var circle = new Circle<int>(5);
            Assert.IsTrue(circle.radius == 5, "Радиус не верен.");
            Assert.IsTrue(circle.diameter == 10, "Диаметр не верен.");
            Assert.IsTrue(circle.Square() == (int)(Math.PI*5*5), "Расчет не верен.");
        }

        [Test]
        public void CircleDouble()
        {
            var circle = new Circle<double>(5.5);
            Assert.IsTrue(circle.radius == 5.5, "Радиус не верен.");
            Assert.IsTrue(circle.diameter == 11, "Диаметр не верен.");
            Assert.IsTrue(circle.Square() == Math.PI * 5.5 * 5.5, "Расчет не верен.");
        }

        [Test]
        public void TriangleInt()
        {
            var triangle = new Triangle<int>(1,3,3);
            Assert.IsTrue(triangle.sideA == 1 && triangle.sideB == 3 && triangle.sideC == 3, "Стороны не верен.");
            Assert.IsTrue(triangle.Square() - (int)1.479019945774904 == 0 , "Расчет не верен.");
        }

        [Test]
        public void TriangleDouble()
        {
            var triangle = new Triangle<double>(1, 3, 3);
            Assert.IsTrue(triangle.sideA == 1 && triangle.sideB == 3 && triangle.sideC == 3, "Стороны не верен.");
            Assert.IsTrue(Math.Round(triangle.Square() - 1.479019945774904, 10) == 0, "Расчет не верен.");
        }

        [Test]
        public void TriangleFalse()
        {
            var triangle = new Triangle<double>(1, 1, 3);
            Assert.IsTrue(triangle.Square() == 0, "Расчет не верен.");
        }

        [Test]
        public void IsRectangular()
        {
            var triangle = new Triangle<double>(6, 8, 10);
            Assert.IsTrue(triangle.IsRectangular, "Не прямоугольный треугольник.");
            triangle = new Triangle<double>(5, 6, 7);
            Assert.IsTrue(!triangle.IsRectangular, "Прямоугольный треугольник.");
        }

        [Test]
        public void ListGometry()
        {
            var list = new List<IGeometryObject<double>> 
            {
                new Circle<double>(3),
                new Circle<double>(5),
                new Triangle<double>(2,2,3),
                new Triangle<double>(1,3,3),
            };
            var arr = new[] { Math.PI * 3 * 3, Math.PI * 5 * 5, 1.984313483298443, 1.479019945774904 };

            for(int i = 0; i < list.Count; ++i)
            {
                Assert.IsTrue(list[i].Square() == arr[i], "Расчет не верен.");
            }
        }
    }
}